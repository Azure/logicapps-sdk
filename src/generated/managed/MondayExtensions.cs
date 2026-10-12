//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Monday
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MondayActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildCreateItem))]
        public IBodyWorkflowAction<CreateItemResponse> CreateItem([WorkflowExpression] Func<string> bodygroupId, [WorkflowExpression] Func<string> bodyitemName, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodyboardId = null, [WorkflowExpression] Func<object> bodycolumnValues = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateItemResponse> __BuildCreateItem(WorkflowExpression<string> bodygroupId, WorkflowExpression<string> bodyitemName, WorkflowExpression<string> bodyworkspaceId = null, WorkflowExpression<string> bodyboardId = null, WorkflowExpression<object> bodycolumnValues = null)
        {
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: true);
            WorkflowExpression.Validate(bodyitemName, nameof(bodyitemName), required: true);
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            WorkflowExpression.Validate(bodycolumnValues, nameof(bodycolumnValues), required: false);
            return new DeferredBodyAction<CreateItemResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
                body["itemName"] = ExpressionConverter.ConvertO(bodyitemName);
                if (bodycolumnValues != null)
                {
                    body["columnValues"] = ExpressionConverter.ConvertO(bodycolumnValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildDuplicateBoard))]
        public IBodyWorkflowAction<DuplicateBoardResponse> DuplicateBoard([WorkflowExpression] Func<string> bodysourceWorkspaceId, [WorkflowExpression] Func<string> bodysourceBoardId, [WorkflowExpression] Func<bodyduplicationTypeInput> bodyduplicationType, [WorkflowExpression] Func<bool> bodykeepBoardSubscribers, [WorkflowExpression] Func<string> bodyduplicatedBoardName = null, [WorkflowExpression] Func<string> bodydestinationWorkspaceId = null, [WorkflowExpression] Func<string> bodydestinationFolder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DuplicateBoardResponse> __BuildDuplicateBoard(WorkflowExpression<string> bodysourceWorkspaceId, WorkflowExpression<string> bodysourceBoardId, WorkflowExpression<bodyduplicationTypeInput> bodyduplicationType, WorkflowExpression<bool> bodykeepBoardSubscribers, WorkflowExpression<string> bodyduplicatedBoardName = null, WorkflowExpression<string> bodydestinationWorkspaceId = null, WorkflowExpression<string> bodydestinationFolder = null)
        {
            WorkflowExpression.Validate(bodysourceWorkspaceId, nameof(bodysourceWorkspaceId), required: true);
            WorkflowExpression.Validate(bodysourceBoardId, nameof(bodysourceBoardId), required: true);
            WorkflowExpression.Validate(bodyduplicationType, nameof(bodyduplicationType), required: true);
            WorkflowExpression.Validate(bodykeepBoardSubscribers, nameof(bodykeepBoardSubscribers), required: true);
            WorkflowExpression.Validate(bodyduplicatedBoardName, nameof(bodyduplicatedBoardName), required: false);
            WorkflowExpression.Validate(bodydestinationWorkspaceId, nameof(bodydestinationWorkspaceId), required: false);
            WorkflowExpression.Validate(bodydestinationFolder, nameof(bodydestinationFolder), required: false);
            return new DeferredBodyAction<DuplicateBoardResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/DuplicateBoard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sourceWorkspaceId"] = ExpressionConverter.ConvertO(bodysourceWorkspaceId);
                bodypropCount++;
                body["sourceBoardId"] = ExpressionConverter.ConvertO(bodysourceBoardId);
                if (bodyduplicatedBoardName != null)
                {
                    body["duplicatedBoardName"] = ExpressionConverter.ConvertO(bodyduplicatedBoardName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["duplicationType"] = ExpressionConverter.ConvertO(bodyduplicationType);
                if (bodydestinationWorkspaceId != null)
                {
                    body["destinationWorkspaceId"] = ExpressionConverter.ConvertO(bodydestinationWorkspaceId);
                    bodypropCount++;
                }

                if (bodydestinationFolder != null)
                {
                    body["destinationFolder"] = ExpressionConverter.ConvertO(bodydestinationFolder);
                    bodypropCount++;
                }

                bodypropCount++;
                body["keepBoardSubscribers"] = ExpressionConverter.ConvertO(bodykeepBoardSubscribers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DuplicateBoardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildCreateBoard))]
        public IBodyWorkflowAction<CreateBoardResponse> CreateBoard([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateBoardResponse> __BuildCreateBoard(WorkflowExpression<string> bodyworkspaceId, WorkflowExpression<string> bodyboardName)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyboardName, nameof(bodyboardName), required: true);
            return new DeferredBodyAction<CreateBoardResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateBoard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["boardName"] = ExpressionConverter.ConvertO(bodyboardName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateBoardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildCreateColumn))]
        public IBodyWorkflowAction<CreateColumnResponse> CreateColumn([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<bodycolumnTypeInput> bodycolumnType, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodyboardId = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateColumnResponse> __BuildCreateColumn(WorkflowExpression<string> bodytitle, WorkflowExpression<bodycolumnTypeInput> bodycolumnType, WorkflowExpression<string> bodyworkspaceId = null, WorkflowExpression<string> bodyboardId = null, WorkflowExpression<string> bodydescription = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodycolumnType, nameof(bodycolumnType), required: true);
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<CreateColumnResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["columnType"] = ExpressionConverter.ConvertO(bodycolumnType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildCreateGroup))]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup([WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodyboardId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateGroupResponse> __BuildCreateGroup(WorkflowExpression<string> bodygroupName, WorkflowExpression<string> bodyworkspaceId = null, WorkflowExpression<string> bodyboardId = null)
        {
            WorkflowExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            return new DeferredBodyAction<CreateGroupResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupName"] = ExpressionConverter.ConvertO(bodygroupName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateItemColumn))]
        public IBodyWorkflowAction<UpdateItemColumnResponse> UpdateItemColumn([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, [WorkflowExpression] Func<string> bodyitemId, [WorkflowExpression] Func<string> bodycolumnId = null, [WorkflowExpression] Func<object> bodycolumnValues = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateItemColumnResponse> __BuildUpdateItemColumn(WorkflowExpression<string> bodyworkspaceId, WorkflowExpression<string> bodyboardId, WorkflowExpression<string> bodyitemId, WorkflowExpression<string> bodycolumnId = null, WorkflowExpression<object> bodycolumnValues = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            WorkflowExpression.Validate(bodyitemId, nameof(bodyitemId), required: true);
            WorkflowExpression.Validate(bodycolumnId, nameof(bodycolumnId), required: false);
            WorkflowExpression.Validate(bodycolumnValues, nameof(bodycolumnValues), required: false);
            return new DeferredBodyAction<UpdateItemColumnResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/UpdateItemColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                if (bodycolumnId != null)
                {
                    body["columnId"] = ExpressionConverter.ConvertO(bodycolumnId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["itemId"] = ExpressionConverter.ConvertO(bodyitemId);
                if (bodycolumnValues != null)
                {
                    body["columnValues"] = ExpressionConverter.ConvertO(bodycolumnValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateItemColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateMultipleItemColumns))]
        public IBodyWorkflowAction<UpdateMultipleItemColumnsResponse> UpdateMultipleItemColumns([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, [WorkflowExpression] Func<string> bodyitemId, [WorkflowExpression] Func<string> bodyitemName = null, [WorkflowExpression] Func<object> bodycolumnValues = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateMultipleItemColumnsResponse> __BuildUpdateMultipleItemColumns(WorkflowExpression<string> bodyworkspaceId, WorkflowExpression<string> bodyboardId, WorkflowExpression<string> bodyitemId, WorkflowExpression<string> bodyitemName = null, WorkflowExpression<object> bodycolumnValues = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            WorkflowExpression.Validate(bodyitemId, nameof(bodyitemId), required: true);
            WorkflowExpression.Validate(bodyitemName, nameof(bodyitemName), required: false);
            WorkflowExpression.Validate(bodycolumnValues, nameof(bodycolumnValues), required: false);
            return new DeferredBodyAction<UpdateMultipleItemColumnsResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/UpdateMultipleItemColumns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                bodypropCount++;
                body["itemId"] = ExpressionConverter.ConvertO(bodyitemId);
                if (bodyitemName != null)
                {
                    body["itemName"] = ExpressionConverter.ConvertO(bodyitemName);
                    bodypropCount++;
                }

                if (bodycolumnValues != null)
                {
                    body["columnValues"] = ExpressionConverter.ConvertO(bodycolumnValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateMultipleItemColumnsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildMoveItemToGroup))]
        public IBodyWorkflowAction<MoveItemToGroupResponse> MoveItemToGroup([WorkflowExpression] Func<string> bodygroupId, [WorkflowExpression] Func<string> bodyitemId, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodyboardId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MoveItemToGroupResponse> __BuildMoveItemToGroup(WorkflowExpression<string> bodygroupId, WorkflowExpression<string> bodyitemId, WorkflowExpression<string> bodyworkspaceId = null, WorkflowExpression<string> bodyboardId = null)
        {
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: true);
            WorkflowExpression.Validate(bodyitemId, nameof(bodyitemId), required: true);
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            return new DeferredBodyAction<MoveItemToGroupResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/MoveItemToGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
                body["itemId"] = ExpressionConverter.ConvertO(bodyitemId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MoveItemToGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildCreateNotification))]
        public IBodyWorkflowAction<CreateNotificationResponse> CreateNotification([WorkflowExpression] Func<string> bodyuserId, [WorkflowExpression] Func<string> bodytargetId, [WorkflowExpression] Func<string> bodytext)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateNotificationResponse> __BuildCreateNotification(WorkflowExpression<string> bodyuserId, WorkflowExpression<string> bodytargetId, WorkflowExpression<string> bodytext)
        {
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            WorkflowExpression.Validate(bodytargetId, nameof(bodytargetId), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<CreateNotificationResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
                body["targetId"] = ExpressionConverter.ConvertO(bodytargetId);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateNotificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSubitem))]
        public IBodyWorkflowAction<CreateSubitemResponse> CreateSubitem([WorkflowExpression] Func<string> bodyboardId, [WorkflowExpression] Func<string> bodyparentItemId, [WorkflowExpression] Func<string> bodyitemName, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<object> bodycolumnValues = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSubitemResponse> __BuildCreateSubitem(WorkflowExpression<string> bodyboardId, WorkflowExpression<string> bodyparentItemId, WorkflowExpression<string> bodyitemName, WorkflowExpression<string> bodyworkspaceId = null, WorkflowExpression<object> bodycolumnValues = null)
        {
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            WorkflowExpression.Validate(bodyparentItemId, nameof(bodyparentItemId), required: true);
            WorkflowExpression.Validate(bodyitemName, nameof(bodyitemName), required: true);
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            WorkflowExpression.Validate(bodycolumnValues, nameof(bodycolumnValues), required: false);
            return new DeferredBodyAction<CreateSubitemResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateSubitem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                bodypropCount++;
                body["parentItemId"] = ExpressionConverter.ConvertO(bodyparentItemId);
                bodypropCount++;
                body["itemName"] = ExpressionConverter.ConvertO(bodyitemName);
                if (bodycolumnValues != null)
                {
                    body["columnValues"] = ExpressionConverter.ConvertO(bodycolumnValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateSubitemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildGetSubitems))]
        public IBodyWorkflowAction<JToken> GetSubitems([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> itemId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetSubitems(WorkflowExpression<string> workspaceId, WorkflowExpression<string> boardId, WorkflowExpression<string> itemId)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowExpression.Validate(boardId, nameof(boardId), required: true);
            WorkflowExpression.Validate(itemId, nameof(itemId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/getData/getSubitems";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
                callPayload.Queries["boardId"] = ExpressionConverter.Convert(boardId);
                callPayload.Queries["itemId"] = ExpressionConverter.Convert(itemId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildCreateUpdate))]
        public IBodyWorkflowAction<CreateUpdateResponse> CreateUpdate([WorkflowExpression] Func<string> bodygroupId, [WorkflowExpression] Func<string> bodyitemId, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodyboardId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateUpdateResponse> __BuildCreateUpdate(WorkflowExpression<string> bodygroupId, WorkflowExpression<string> bodyitemId, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodyworkspaceId = null, WorkflowExpression<string> bodyboardId = null)
        {
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: true);
            WorkflowExpression.Validate(bodyitemId, nameof(bodyitemId), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            return new DeferredBodyAction<CreateUpdateResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
                body["itemId"] = ExpressionConverter.ConvertO(bodyitemId);
                bodypropCount++;
                body["body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemById))]
        public IBodyWorkflowAction<JToken> GetItemById([WorkflowExpression] Func<string> itemId, [WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> boardId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItemById(WorkflowExpression<string> itemId, WorkflowExpression<string> workspaceId, WorkflowExpression<string> boardId)
        {
            WorkflowExpression.Validate(itemId, nameof(itemId), required: true);
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowExpression.Validate(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/getData/getItemById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["itemId"] = ExpressionConverter.Convert(itemId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
                callPayload.Queries["boardId"] = ExpressionConverter.Convert(boardId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkspace))]
        public IBodyWorkflowAction<CreateWorkspaceV2Response> CreateWorkspace([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateWorkspaceV2Response> __BuildCreateWorkspace(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodydescription = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<CreateWorkspaceV2Response>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateWorkspaceV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateWorkspaceV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        [WorkflowExpressionFactory(nameof(__BuildGetItems))]
        public IBodyWorkflowAction<JToken> GetItems([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> filter1Column = null, [WorkflowExpression] Func<string> filter1Operator = null, [WorkflowExpression] Func<string> filter1Value = null, [WorkflowExpression] Func<string> filter2Column = null, [WorkflowExpression] Func<string> filter2Operator = null, [WorkflowExpression] Func<string> filter2Value = null, [WorkflowExpression] Func<string> filter3Column = null, [WorkflowExpression] Func<string> filter3Operator = null, [WorkflowExpression] Func<string> filter3Value = null, [WorkflowExpression] Func<string> filter4Column = null, [WorkflowExpression] Func<string> filter4Operator = null, [WorkflowExpression] Func<string> filter4Value = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItems(WorkflowExpression<string> workspaceId, WorkflowExpression<string> boardId, WorkflowExpression<string> groupId, WorkflowExpression<string> filter1Column = null, WorkflowExpression<string> filter1Operator = null, WorkflowExpression<string> filter1Value = null, WorkflowExpression<string> filter2Column = null, WorkflowExpression<string> filter2Operator = null, WorkflowExpression<string> filter2Value = null, WorkflowExpression<string> filter3Column = null, WorkflowExpression<string> filter3Operator = null, WorkflowExpression<string> filter3Value = null, WorkflowExpression<string> filter4Column = null, WorkflowExpression<string> filter4Operator = null, WorkflowExpression<string> filter4Value = null)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowExpression.Validate(boardId, nameof(boardId), required: true);
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(filter1Column, nameof(filter1Column), required: false);
            WorkflowExpression.Validate(filter1Operator, nameof(filter1Operator), required: false);
            WorkflowExpression.Validate(filter1Value, nameof(filter1Value), required: false);
            WorkflowExpression.Validate(filter2Column, nameof(filter2Column), required: false);
            WorkflowExpression.Validate(filter2Operator, nameof(filter2Operator), required: false);
            WorkflowExpression.Validate(filter2Value, nameof(filter2Value), required: false);
            WorkflowExpression.Validate(filter3Column, nameof(filter3Column), required: false);
            WorkflowExpression.Validate(filter3Operator, nameof(filter3Operator), required: false);
            WorkflowExpression.Validate(filter3Value, nameof(filter3Value), required: false);
            WorkflowExpression.Validate(filter4Column, nameof(filter4Column), required: false);
            WorkflowExpression.Validate(filter4Operator, nameof(filter4Operator), required: false);
            WorkflowExpression.Validate(filter4Value, nameof(filter4Value), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/getData/getItemsV2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
                callPayload.Queries["boardId"] = ExpressionConverter.Convert(boardId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                if (filter1Column != null)
                    callPayload.Queries["filter1Column"] = ExpressionConverter.Convert(filter1Column);
                if (filter1Operator != null)
                    callPayload.Queries["filter1Operator"] = ExpressionConverter.Convert(filter1Operator);
                if (filter1Value != null)
                    callPayload.Queries["filter1Value"] = ExpressionConverter.Convert(filter1Value);
                if (filter2Column != null)
                    callPayload.Queries["filter2Column"] = ExpressionConverter.Convert(filter2Column);
                if (filter2Operator != null)
                    callPayload.Queries["filter2Operator"] = ExpressionConverter.Convert(filter2Operator);
                if (filter2Value != null)
                    callPayload.Queries["filter2Value"] = ExpressionConverter.Convert(filter2Value);
                if (filter3Column != null)
                    callPayload.Queries["filter3Column"] = ExpressionConverter.Convert(filter3Column);
                if (filter3Operator != null)
                    callPayload.Queries["filter3Operator"] = ExpressionConverter.Convert(filter3Operator);
                if (filter3Value != null)
                    callPayload.Queries["filter3Value"] = ExpressionConverter.Convert(filter3Value);
                if (filter4Column != null)
                    callPayload.Queries["filter4Column"] = ExpressionConverter.Convert(filter4Column);
                if (filter4Operator != null)
                    callPayload.Queries["filter4Operator"] = ExpressionConverter.Convert(filter4Operator);
                if (filter4Value != null)
                    callPayload.Queries["filter4Value"] = ExpressionConverter.Convert(filter4Value);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<GetTagsV2Response> GetTags()
        {
            var apiCallPath = "/getData/getTagsV2";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTagsV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<GetUsersV2Response> GetUsers()
        {
            var apiCallPath = "/getData/getUsersV2";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUsersV2Response>(callPayload);
        }
    }

    public class MondayTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWebhookCreateItem))]
        public IBodyWorkflowTrigger<JToken> WebhookCreateItem([WorkflowExpression] Func<string> bodyworkspaceId,[WorkflowExpression] Func<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildWebhookCreateItem(WorkflowExpression<string> bodyworkspaceId,WorkflowExpression<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/CreateItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookCreateUpdate))]
        public IBodyWorkflowTrigger<JToken> WebhookCreateUpdate([WorkflowExpression] Func<string> bodyworkspaceId,[WorkflowExpression] Func<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildWebhookCreateUpdate(WorkflowExpression<string> bodyworkspaceId,WorkflowExpression<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/CreateUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookChangeName))]
        public IBodyWorkflowTrigger<JToken> WebhookChangeName([WorkflowExpression] Func<string> bodyworkspaceId,[WorkflowExpression] Func<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildWebhookChangeName(WorkflowExpression<string> bodyworkspaceId,WorkflowExpression<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/ChangeName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookChangeSubitemName))]
        public IBodyWorkflowTrigger<JToken> WebhookChangeSubitemName([WorkflowExpression] Func<string> bodyworkspaceId,[WorkflowExpression] Func<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildWebhookChangeSubitemName(WorkflowExpression<string> bodyworkspaceId,WorkflowExpression<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/ChangeSubitemName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookCreateSubitem))]
        public IBodyWorkflowTrigger<JToken> WebhookCreateSubitem([WorkflowExpression] Func<string> bodyworkspaceId,[WorkflowExpression] Func<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildWebhookCreateSubitem(WorkflowExpression<string> bodyworkspaceId,WorkflowExpression<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/CreateSubitem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookColumnChanges))]
        public IBodyWorkflowTrigger<JToken> WebhookColumnChanges([WorkflowExpression] Func<string> bodyworkspaceId,[WorkflowExpression] Func<string> bodyboardId,[WorkflowExpression] Func<string> bodycolumnId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildWebhookColumnChanges(WorkflowExpression<string> bodyworkspaceId,WorkflowExpression<string> bodyboardId,WorkflowExpression<string> bodycolumnId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            WorkflowExpression.Validate(bodycolumnId, nameof(bodycolumnId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/ColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                bodypropCount++;
                body["columnId"] = ExpressionConverter.ConvertO(bodycolumnId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookAnyColumnChanges))]
        public IBodyWorkflowTrigger<JToken> WebhookAnyColumnChanges([WorkflowExpression] Func<string> bodyworkspaceId,[WorkflowExpression] Func<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildWebhookAnyColumnChanges(WorkflowExpression<string> bodyworkspaceId,WorkflowExpression<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/AnyColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookSubitemColumnChanges))]
        public IBodyWorkflowTrigger<JToken> WebhookSubitemColumnChanges([WorkflowExpression] Func<string> bodyworkspaceId,[WorkflowExpression] Func<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildWebhookSubitemColumnChanges(WorkflowExpression<string> bodyworkspaceId,WorkflowExpression<string> bodyboardId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/SubitemColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class DuplicateBoardResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyduplicationTypeInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycolumnTypeInput
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