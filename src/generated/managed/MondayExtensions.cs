//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Monday
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MondayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateItemResponse, ApiConnectionActionConfiguration> CreateItem(Expression<Func<CreateItemInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<DuplicateBoardResponse, ApiConnectionActionConfiguration> DuplicateBoard(Expression<Func<DuplicateBoardInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DuplicateBoardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/DuplicateBoard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DuplicateBoardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateBoardResponse, ApiConnectionActionConfiguration> CreateBoard(Expression<Func<CreateBoardInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateBoardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateBoard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateBoardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateColumnResponse, ApiConnectionActionConfiguration> CreateColumn(Expression<Func<CreateColumnInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateGroupResponse, ApiConnectionActionConfiguration> CreateGroup(Expression<Func<CreateGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<UpdateItemColumnResponse, ApiConnectionActionConfiguration> UpdateItemColumn(Expression<Func<UpdateItemColumnInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateItemColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/UpdateItemColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateItemColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<UpdateMultipleItemColumnsResponse, ApiConnectionActionConfiguration> UpdateMultipleItemColumns(Expression<Func<UpdateMultipleItemColumnsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateMultipleItemColumnsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/UpdateMultipleItemColumns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateMultipleItemColumnsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<MoveItemToGroupResponse, ApiConnectionActionConfiguration> MoveItemToGroup(Expression<Func<MoveItemToGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MoveItemToGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/MoveItemToGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MoveItemToGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateNotificationResponse, ApiConnectionActionConfiguration> CreateNotification(Expression<Func<CreateNotificationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateNotificationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateNotificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateSubitemResponse, ApiConnectionActionConfiguration> CreateSubitem(Expression<Func<CreateSubitemInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateSubitemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateSubitem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSubitemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetSubitems(Expression<Func<string>> workspaceId, Expression<Func<string>> boardId, Expression<Func<string>> itemId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getData/getSubitems";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Queries["boardId"] = ExpressionConverter.Convert(__workflow_boardId);
                callPayload.Queries["itemId"] = ExpressionConverter.Convert(__workflow_itemId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateUpdateResponse, ApiConnectionActionConfiguration> CreateUpdate(Expression<Func<CreateUpdateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetItemById(Expression<Func<string>> itemId, Expression<Func<string>> workspaceId, Expression<Func<string>> boardId)
        {
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getData/getItemById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["itemId"] = ExpressionConverter.Convert(__workflow_itemId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Queries["boardId"] = ExpressionConverter.Convert(__workflow_boardId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateWorkspaceV2Response, ApiConnectionActionConfiguration> CreateWorkspace(Expression<Func<CreateWorkspaceV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateWorkspaceV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateWorkspaceV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateWorkspaceV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetItems(Expression<Func<string>> workspaceId, Expression<Func<string>> boardId, Expression<Func<string>> groupId, Expression<Func<string>> filter1Column = null, Expression<Func<string>> filter1Operator = null, Expression<Func<string>> filter1Value = null, Expression<Func<string>> filter2Column = null, Expression<Func<string>> filter2Operator = null, Expression<Func<string>> filter2Value = null, Expression<Func<string>> filter3Column = null, Expression<Func<string>> filter3Operator = null, Expression<Func<string>> filter3Value = null, Expression<Func<string>> filter4Column = null, Expression<Func<string>> filter4Operator = null, Expression<Func<string>> filter4Value = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_filter1Column = WorkflowExpression.Compile(filter1Column, nameof(filter1Column), required: false);
            var __workflow_filter1Operator = WorkflowExpression.Compile(filter1Operator, nameof(filter1Operator), required: false);
            var __workflow_filter1Value = WorkflowExpression.Compile(filter1Value, nameof(filter1Value), required: false);
            var __workflow_filter2Column = WorkflowExpression.Compile(filter2Column, nameof(filter2Column), required: false);
            var __workflow_filter2Operator = WorkflowExpression.Compile(filter2Operator, nameof(filter2Operator), required: false);
            var __workflow_filter2Value = WorkflowExpression.Compile(filter2Value, nameof(filter2Value), required: false);
            var __workflow_filter3Column = WorkflowExpression.Compile(filter3Column, nameof(filter3Column), required: false);
            var __workflow_filter3Operator = WorkflowExpression.Compile(filter3Operator, nameof(filter3Operator), required: false);
            var __workflow_filter3Value = WorkflowExpression.Compile(filter3Value, nameof(filter3Value), required: false);
            var __workflow_filter4Column = WorkflowExpression.Compile(filter4Column, nameof(filter4Column), required: false);
            var __workflow_filter4Operator = WorkflowExpression.Compile(filter4Operator, nameof(filter4Operator), required: false);
            var __workflow_filter4Value = WorkflowExpression.Compile(filter4Value, nameof(filter4Value), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getData/getItemsV2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Queries["boardId"] = ExpressionConverter.Convert(__workflow_boardId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                if (__workflow_filter1Column != null)
                    callPayload.Queries["filter1Column"] = ExpressionConverter.Convert(__workflow_filter1Column);
                if (__workflow_filter1Operator != null)
                    callPayload.Queries["filter1Operator"] = ExpressionConverter.Convert(__workflow_filter1Operator);
                if (__workflow_filter1Value != null)
                    callPayload.Queries["filter1Value"] = ExpressionConverter.Convert(__workflow_filter1Value);
                if (__workflow_filter2Column != null)
                    callPayload.Queries["filter2Column"] = ExpressionConverter.Convert(__workflow_filter2Column);
                if (__workflow_filter2Operator != null)
                    callPayload.Queries["filter2Operator"] = ExpressionConverter.Convert(__workflow_filter2Operator);
                if (__workflow_filter2Value != null)
                    callPayload.Queries["filter2Value"] = ExpressionConverter.Convert(__workflow_filter2Value);
                if (__workflow_filter3Column != null)
                    callPayload.Queries["filter3Column"] = ExpressionConverter.Convert(__workflow_filter3Column);
                if (__workflow_filter3Operator != null)
                    callPayload.Queries["filter3Operator"] = ExpressionConverter.Convert(__workflow_filter3Operator);
                if (__workflow_filter3Value != null)
                    callPayload.Queries["filter3Value"] = ExpressionConverter.Convert(__workflow_filter3Value);
                if (__workflow_filter4Column != null)
                    callPayload.Queries["filter4Column"] = ExpressionConverter.Convert(__workflow_filter4Column);
                if (__workflow_filter4Operator != null)
                    callPayload.Queries["filter4Operator"] = ExpressionConverter.Convert(__workflow_filter4Operator);
                if (__workflow_filter4Value != null)
                    callPayload.Queries["filter4Value"] = ExpressionConverter.Convert(__workflow_filter4Value);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<GetTagsV2Response, ApiConnectionActionConfiguration> GetTags()
        {
            return new DeferredBodyAction<GetTagsV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getData/getTagsV2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTagsV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<GetUsersV2Response, ApiConnectionActionConfiguration> GetUsers()
        {
            return new DeferredBodyAction<GetUsersV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getData/getUsersV2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUsersV2Response>(callPayload);
            });
        }
    }

    public class MondayTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> WebhookCreateItem(Expression<Func<WebhookCreateItemInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/registerWebhook/CreateItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> WebhookCreateUpdate(Expression<Func<WebhookCreateUpdateInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/registerWebhook/CreateUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> WebhookChangeName(Expression<Func<WebhookChangeNameInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/registerWebhook/ChangeName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> WebhookChangeSubitemName(Expression<Func<WebhookChangeSubitemNameInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/registerWebhook/ChangeSubitemName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> WebhookCreateSubitem(Expression<Func<WebhookCreateSubitemInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/registerWebhook/CreateSubitem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> WebhookColumnChanges(Expression<Func<WebhookColumnChangesInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/registerWebhook/ColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> WebhookAnyColumnChanges(Expression<Func<WebhookAnyColumnChangesInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/registerWebhook/AnyColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> WebhookSubitemColumnChanges(Expression<Func<WebhookSubitemColumnChangesInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/registerWebhook/SubitemColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateItemResponse
    {
        [JsonProperty("data")]
        public CreateItemResponseDataType Data { get; set; }
    }

    public class CreateItemResponseDataType
    {
        [JsonProperty("create_item")]
        public CreateItemResponseDataTypeCreateItemType CreateItem { get; set; }
    }

    public class CreateItemResponseDataTypeCreateItemType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateItemInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("groupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupId { get; set; }

        [JsonProperty("itemName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemName { get; set; }

        [JsonProperty("columnValues")]
        public JToken ColumnValues { get; set; }
    }

    public class DuplicateBoardResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DuplicateBoardInput
    {
        [JsonProperty("sourceWorkspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceWorkspaceId { get; set; }

        [JsonProperty("sourceBoardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceBoardId { get; set; }

        [JsonProperty("duplicatedBoardName")]
        public string DuplicatedBoardName { get; set; }

        [JsonProperty("duplicationType", DefaultValueHandling = DefaultValueHandling.Include)]
        public DuplicateBoardInputDuplicationTypeType DuplicationType { get; set; } = DuplicateBoardInputDuplicationTypeType.DuplicateBoardWithStructure;

        [JsonProperty("destinationWorkspaceId")]
        public string DestinationWorkspaceId { get; set; }

        [JsonProperty("destinationFolder")]
        public string DestinationFolder { get; set; }

        [JsonProperty("keepBoardSubscribers", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool KeepBoardSubscribers { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DuplicateBoardInputDuplicationTypeType
    {
        [EnumMember(Value = "Duplicate board with structure")]
        DuplicateBoardWithStructure,
        [EnumMember(Value = "Duplicate board with items")]
        DuplicateBoardWithItems,
        [EnumMember(Value = "Duplicate board with items and updates")]
        DuplicateBoardWithItemsAndUpdates
    }

    public class CreateBoardResponse
    {
        [JsonProperty("data")]
        public CreateBoardResponseDataType Data { get; set; }
    }

    public class CreateBoardResponseDataType
    {
        [JsonProperty("create_board")]
        public CreateBoardResponseDataTypeCreateBoardType CreateBoard { get; set; }
    }

    public class CreateBoardResponseDataTypeCreateBoardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateBoardInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardName { get; set; }
    }

    public class CreateColumnResponse
    {
        [JsonProperty("data")]
        public CreateColumnResponseDataType Data { get; set; }
    }

    public class CreateColumnResponseDataType
    {
        [JsonProperty("create_column")]
        public CreateColumnResponseDataTypeCreateColumnType CreateColumn { get; set; }
    }

    public class CreateColumnResponseDataTypeCreateColumnType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CreateColumnInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("columnType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateColumnInputColumnTypeType ColumnType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateColumnInputColumnTypeType
    {
        [EnumMember(Value = "auto_number")]
        AutoNumber,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "country")]
        Country,
        [EnumMember(Value = "color_picker")]
        ColorPicker,
        [EnumMember(Value = "creation_log")]
        CreationLog,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "dependency")]
        Dependency,
        [EnumMember(Value = "dropdown")]
        Dropdown,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "hour")]
        Hour,
        [EnumMember(Value = "item_id")]
        ItemId,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "location")]
        Location,
        [EnumMember(Value = "long_text")]
        LongText,
        [EnumMember(Value = "numbers")]
        Numbers,
        [EnumMember(Value = "people")]
        People,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "progress")]
        Progress,
        [EnumMember(Value = "rating")]
        Rating,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "team")]
        Team,
        [EnumMember(Value = "tags")]
        Tags,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "timeline")]
        Timeline,
        [EnumMember(Value = "time_tracking")]
        TimeTracking,
        [EnumMember(Value = "vote")]
        Vote,
        [EnumMember(Value = "week")]
        Week,
        [EnumMember(Value = "world_clock")]
        WorldClock
    }

    public class CreateGroupResponse
    {
        [JsonProperty("data")]
        public CreateGroupResponseDataType Data { get; set; }
    }

    public class CreateGroupResponseDataType
    {
        [JsonProperty("create_group")]
        public CreateGroupResponseDataTypeCreateGroupType CreateGroup { get; set; }
    }

    public class CreateGroupResponseDataTypeCreateGroupType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateGroupInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("groupName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }
    }

    public class UpdateItemColumnResponse
    {
        [JsonProperty("data")]
        public UpdateItemColumnResponseDataType Data { get; set; }
    }

    public class UpdateItemColumnResponseDataType
    {
        [JsonProperty("change_multiple_column_values")]
        public UpdateItemColumnResponseDataTypeChangeMultipleColumnValuesType ChangeMultipleColumnValues { get; set; }
    }

    public class UpdateItemColumnResponseDataTypeChangeMultipleColumnValuesType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateItemColumnInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("columnId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ColumnId { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemId { get; set; }

        [JsonProperty("columnValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ColumnValues { get; set; }
    }

    public class UpdateMultipleItemColumnsResponse
    {
        [JsonProperty("data")]
        public UpdateMultipleItemColumnsResponseDataType Data { get; set; }
    }

    public class UpdateMultipleItemColumnsResponseDataType
    {
        [JsonProperty("change_multiple_column_values")]
        public UpdateMultipleItemColumnsResponseDataTypeChangeMultipleColumnValuesType ChangeMultipleColumnValues { get; set; }
    }

    public class UpdateMultipleItemColumnsResponseDataTypeChangeMultipleColumnValuesType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateMultipleItemColumnsInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemId { get; set; }

        [JsonProperty("itemName")]
        public string ItemName { get; set; }

        [JsonProperty("columnValues")]
        public JToken ColumnValues { get; set; }
    }

    public class MoveItemToGroupResponse
    {
        [JsonProperty("data")]
        public MoveItemToGroupResponseDataType Data { get; set; }
    }

    public class MoveItemToGroupResponseDataType
    {
        [JsonProperty("move_item_to_group")]
        public MoveItemToGroupResponseDataTypeMoveItemToGroupType MoveItemToGroup { get; set; }
    }

    public class MoveItemToGroupResponseDataTypeMoveItemToGroupType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MoveItemToGroupInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("groupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupId { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemId { get; set; }
    }

    public class CreateNotificationResponse
    {
        [JsonProperty("data")]
        public CreateNotificationResponseDataType Data { get; set; }
    }

    public class CreateNotificationResponseDataType
    {
        [JsonProperty("create_notification")]
        public CreateNotificationResponseDataTypeCreateNotificationType CreateNotification { get; set; }
    }

    public class CreateNotificationResponseDataTypeCreateNotificationType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CreateNotificationInput
    {
        [JsonProperty("userId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }

        [JsonProperty("targetId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetId { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class CreateSubitemResponse
    {
        [JsonProperty("data")]
        public CreateSubitemResponseDataType Data { get; set; }
    }

    public class CreateSubitemResponseDataType
    {
        [JsonProperty("create_subitem")]
        public CreateSubitemResponseDataTypeCreateSubitemType CreateSubitem { get; set; }
    }

    public class CreateSubitemResponseDataTypeCreateSubitemType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("board")]
        public CreateSubitemResponseDataTypeCreateSubitemTypeBoardType Board { get; set; }
    }

    public class CreateSubitemResponseDataTypeCreateSubitemTypeBoardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateSubitemInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("parentItemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentItemId { get; set; }

        [JsonProperty("itemName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemName { get; set; }

        [JsonProperty("columnValues")]
        public JToken ColumnValues { get; set; }
    }

    public class CreateUpdateResponse
    {
        [JsonProperty("data")]
        public CreateUpdateResponseDataType Data { get; set; }
    }

    public class CreateUpdateResponseDataType
    {
        [JsonProperty("create_update")]
        public CreateUpdateResponseDataTypeCreateUpdateType CreateUpdate { get; set; }
    }

    public class CreateUpdateResponseDataTypeCreateUpdateType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateUpdateInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("groupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupId { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemId { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
    }

    public class CreateWorkspaceV2Response
    {
        [JsonProperty("data")]
        public CreateWorkspaceV2ResponseDataType Data { get; set; }
    }

    public class CreateWorkspaceV2ResponseDataType
    {
        [JsonProperty("create_workspace")]
        public CreateWorkspaceV2ResponseDataTypeCreateWorkspaceType CreateWorkspace { get; set; }
    }

    public class CreateWorkspaceV2ResponseDataTypeCreateWorkspaceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateWorkspaceV2Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetTagsV2Response
    {
        [JsonProperty("data")]
        public GetTagsV2ResponseDataType Data { get; set; }
    }

    public class GetTagsV2ResponseDataType
    {
        [JsonProperty("tags")]
        public GetTagsV2ResponseDataTypeTagsTypeItem[] Tags { get; set; }
    }

    public class GetTagsV2ResponseDataTypeTagsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetUsersV2Response
    {
        [JsonProperty("data")]
        public GetUsersV2ResponseDataType Data { get; set; }
    }

    public class GetUsersV2ResponseDataType
    {
        [JsonProperty("users")]
        public GetUsersV2ResponseDataTypeUsersTypeItem[] Users { get; set; }
    }

    public class GetUsersV2ResponseDataTypeUsersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class WebhookCreateItemInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookCreateUpdateInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookChangeNameInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookChangeSubitemNameInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookCreateSubitemInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookColumnChangesInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("columnId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ColumnId { get; set; }

        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookAnyColumnChangesInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookSubitemColumnChangesInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Monday;

    public partial class WorkflowManagedActions
    {
        public MondayActions Monday(string connectionId) => new MondayActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MondayTriggers Monday(string connectionId) => new MondayTriggers(connectionId);
    }
}