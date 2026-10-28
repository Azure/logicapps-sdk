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
        public IBodyWorkflowAction<CreateItemResponse> CreateItem(Expression<Func<string>> bodygroupId, Expression<Func<string>> bodyitemName, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<string>> bodyboardId = null, Expression<Func<object>> bodycolumnValues = null)
        {
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: true);
            var __workflow_bodyitemName = WorkflowExpression.Compile(bodyitemName, nameof(bodyitemName), required: true);
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: false);
            var __workflow_bodycolumnValues = WorkflowExpression.Compile(bodycolumnValues, nameof(bodycolumnValues), required: false);
            return new DeferredBodyAction<CreateItemResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                bodypropCount++;
                body["itemName"] = ExpressionConverter.ConvertO(__workflow_bodyitemName);
                if (__workflow_bodycolumnValues != null)
                {
                    body["columnValues"] = ExpressionConverter.ConvertO(__workflow_bodycolumnValues);
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
        public IBodyWorkflowAction<DuplicateBoardResponse> DuplicateBoard(Expression<Func<string>> bodysourceWorkspaceId, Expression<Func<string>> bodysourceBoardId, Expression<Func<bodyduplicationTypeInput>> bodyduplicationType, Expression<Func<bool>> bodykeepBoardSubscribers, Expression<Func<string>> bodyduplicatedBoardName = null, Expression<Func<string>> bodydestinationWorkspaceId = null, Expression<Func<string>> bodydestinationFolder = null)
        {
            var __workflow_bodysourceWorkspaceId = WorkflowExpression.Compile(bodysourceWorkspaceId, nameof(bodysourceWorkspaceId), required: true);
            var __workflow_bodysourceBoardId = WorkflowExpression.Compile(bodysourceBoardId, nameof(bodysourceBoardId), required: true);
            var __workflow_bodyduplicationType = WorkflowExpression.Compile(bodyduplicationType, nameof(bodyduplicationType), required: true);
            var __workflow_bodykeepBoardSubscribers = WorkflowExpression.Compile(bodykeepBoardSubscribers, nameof(bodykeepBoardSubscribers), required: true);
            var __workflow_bodyduplicatedBoardName = WorkflowExpression.Compile(bodyduplicatedBoardName, nameof(bodyduplicatedBoardName), required: false);
            var __workflow_bodydestinationWorkspaceId = WorkflowExpression.Compile(bodydestinationWorkspaceId, nameof(bodydestinationWorkspaceId), required: false);
            var __workflow_bodydestinationFolder = WorkflowExpression.Compile(bodydestinationFolder, nameof(bodydestinationFolder), required: false);
            return new DeferredBodyAction<DuplicateBoardResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/DuplicateBoard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sourceWorkspaceId"] = ExpressionConverter.ConvertO(__workflow_bodysourceWorkspaceId);
                bodypropCount++;
                body["sourceBoardId"] = ExpressionConverter.ConvertO(__workflow_bodysourceBoardId);
                if (__workflow_bodyduplicatedBoardName != null)
                {
                    body["duplicatedBoardName"] = ExpressionConverter.ConvertO(__workflow_bodyduplicatedBoardName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["duplicationType"] = ExpressionConverter.ConvertO(__workflow_bodyduplicationType);
                if (__workflow_bodydestinationWorkspaceId != null)
                {
                    body["destinationWorkspaceId"] = ExpressionConverter.ConvertO(__workflow_bodydestinationWorkspaceId);
                    bodypropCount++;
                }

                if (__workflow_bodydestinationFolder != null)
                {
                    body["destinationFolder"] = ExpressionConverter.ConvertO(__workflow_bodydestinationFolder);
                    bodypropCount++;
                }

                bodypropCount++;
                body["keepBoardSubscribers"] = ExpressionConverter.ConvertO(__workflow_bodykeepBoardSubscribers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DuplicateBoardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateBoardResponse> CreateBoard(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardName)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyboardName = WorkflowExpression.Compile(bodyboardName, nameof(bodyboardName), required: true);
            return new DeferredBodyAction<CreateBoardResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateBoard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["boardName"] = ExpressionConverter.ConvertO(__workflow_bodyboardName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateBoardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateColumnResponse> CreateColumn(Expression<Func<string>> bodytitle, Expression<Func<bodycolumnTypeInput>> bodycolumnType, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<string>> bodyboardId = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodycolumnType = WorkflowExpression.Compile(bodycolumnType, nameof(bodycolumnType), required: true);
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<CreateColumnResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["columnType"] = ExpressionConverter.ConvertO(__workflow_bodycolumnType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup(Expression<Func<string>> bodygroupName, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<string>> bodyboardId = null)
        {
            var __workflow_bodygroupName = WorkflowExpression.Compile(bodygroupName, nameof(bodygroupName), required: true);
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: false);
            return new DeferredBodyAction<CreateGroupResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupName"] = ExpressionConverter.ConvertO(__workflow_bodygroupName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<UpdateItemColumnResponse> UpdateItemColumn(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, Expression<Func<string>> bodyitemId, Expression<Func<string>> bodycolumnId = null, Expression<Func<object>> bodycolumnValues = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            var __workflow_bodyitemId = WorkflowExpression.Compile(bodyitemId, nameof(bodyitemId), required: true);
            var __workflow_bodycolumnId = WorkflowExpression.Compile(bodycolumnId, nameof(bodycolumnId), required: false);
            var __workflow_bodycolumnValues = WorkflowExpression.Compile(bodycolumnValues, nameof(bodycolumnValues), required: false);
            return new DeferredBodyAction<UpdateItemColumnResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/UpdateItemColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                if (__workflow_bodycolumnId != null)
                {
                    body["columnId"] = ExpressionConverter.ConvertO(__workflow_bodycolumnId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["itemId"] = ExpressionConverter.ConvertO(__workflow_bodyitemId);
                if (__workflow_bodycolumnValues != null)
                {
                    body["columnValues"] = ExpressionConverter.ConvertO(__workflow_bodycolumnValues);
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
        public IBodyWorkflowAction<UpdateMultipleItemColumnsResponse> UpdateMultipleItemColumns(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, Expression<Func<string>> bodyitemId, Expression<Func<string>> bodyitemName = null, Expression<Func<object>> bodycolumnValues = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            var __workflow_bodyitemId = WorkflowExpression.Compile(bodyitemId, nameof(bodyitemId), required: true);
            var __workflow_bodyitemName = WorkflowExpression.Compile(bodyitemName, nameof(bodyitemName), required: false);
            var __workflow_bodycolumnValues = WorkflowExpression.Compile(bodycolumnValues, nameof(bodycolumnValues), required: false);
            return new DeferredBodyAction<UpdateMultipleItemColumnsResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/UpdateMultipleItemColumns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                bodypropCount++;
                body["itemId"] = ExpressionConverter.ConvertO(__workflow_bodyitemId);
                if (__workflow_bodyitemName != null)
                {
                    body["itemName"] = ExpressionConverter.ConvertO(__workflow_bodyitemName);
                    bodypropCount++;
                }

                if (__workflow_bodycolumnValues != null)
                {
                    body["columnValues"] = ExpressionConverter.ConvertO(__workflow_bodycolumnValues);
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
        public IBodyWorkflowAction<MoveItemToGroupResponse> MoveItemToGroup(Expression<Func<string>> bodygroupId, Expression<Func<string>> bodyitemId, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<string>> bodyboardId = null)
        {
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: true);
            var __workflow_bodyitemId = WorkflowExpression.Compile(bodyitemId, nameof(bodyitemId), required: true);
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: false);
            return new DeferredBodyAction<MoveItemToGroupResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/MoveItemToGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                bodypropCount++;
                body["itemId"] = ExpressionConverter.ConvertO(__workflow_bodyitemId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MoveItemToGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateNotificationResponse> CreateNotification(Expression<Func<string>> bodyuserId, Expression<Func<string>> bodytargetId, Expression<Func<string>> bodytext)
        {
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
            var __workflow_bodytargetId = WorkflowExpression.Compile(bodytargetId, nameof(bodytargetId), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<CreateNotificationResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                bodypropCount++;
                body["targetId"] = ExpressionConverter.ConvertO(__workflow_bodytargetId);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateNotificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateSubitemResponse> CreateSubitem(Expression<Func<string>> bodyboardId, Expression<Func<string>> bodyparentItemId, Expression<Func<string>> bodyitemName, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<object>> bodycolumnValues = null)
        {
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            var __workflow_bodyparentItemId = WorkflowExpression.Compile(bodyparentItemId, nameof(bodyparentItemId), required: true);
            var __workflow_bodyitemName = WorkflowExpression.Compile(bodyitemName, nameof(bodyitemName), required: true);
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            var __workflow_bodycolumnValues = WorkflowExpression.Compile(bodycolumnValues, nameof(bodycolumnValues), required: false);
            return new DeferredBodyAction<CreateSubitemResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateSubitem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                bodypropCount++;
                body["parentItemId"] = ExpressionConverter.ConvertO(__workflow_bodyparentItemId);
                bodypropCount++;
                body["itemName"] = ExpressionConverter.ConvertO(__workflow_bodyitemName);
                if (__workflow_bodycolumnValues != null)
                {
                    body["columnValues"] = ExpressionConverter.ConvertO(__workflow_bodycolumnValues);
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
        public IBodyWorkflowAction<JToken> GetSubitems(Expression<Func<string>> workspaceId, Expression<Func<string>> boardId, Expression<Func<string>> itemId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<CreateUpdateResponse> CreateUpdate(Expression<Func<string>> bodygroupId, Expression<Func<string>> bodyitemId, Expression<Func<string>> bodybody, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<string>> bodyboardId = null)
        {
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: true);
            var __workflow_bodyitemId = WorkflowExpression.Compile(bodyitemId, nameof(bodyitemId), required: true);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: true);
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: false);
            return new DeferredBodyAction<CreateUpdateResponse>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyboardId != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                bodypropCount++;
                body["itemId"] = ExpressionConverter.ConvertO(__workflow_bodyitemId);
                bodypropCount++;
                body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<JToken> GetItemById(Expression<Func<string>> itemId, Expression<Func<string>> workspaceId, Expression<Func<string>> boardId)
        {
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<CreateWorkspaceV2Response> CreateWorkspace(Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<CreateWorkspaceV2Response>(() =>
            {
                var apiCallPath = "/executePowerAutomateAction/CreateWorkspaceV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
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
        public IBodyWorkflowAction<JToken> GetItems(Expression<Func<string>> workspaceId, Expression<Func<string>> boardId, Expression<Func<string>> groupId, Expression<Func<string>> filter1Column = null, Expression<Func<string>> filter1Operator = null, Expression<Func<string>> filter1Value = null, Expression<Func<string>> filter2Column = null, Expression<Func<string>> filter2Operator = null, Expression<Func<string>> filter2Value = null, Expression<Func<string>> filter3Column = null, Expression<Func<string>> filter3Operator = null, Expression<Func<string>> filter3Value = null, Expression<Func<string>> filter4Column = null, Expression<Func<string>> filter4Operator = null, Expression<Func<string>> filter4Value = null)
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
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowTrigger<JToken> WebhookCreateItem(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/CreateItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> WebhookCreateUpdate(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/CreateUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> WebhookChangeName(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/ChangeName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> WebhookChangeSubitemName(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/ChangeSubitemName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> WebhookCreateSubitem(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/CreateSubitem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> WebhookColumnChanges(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, Expression<Func<string>> bodycolumnId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            var __workflow_bodycolumnId = WorkflowExpression.Compile(bodycolumnId, nameof(bodycolumnId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/ColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                bodypropCount++;
                body["columnId"] = ExpressionConverter.ConvertO(__workflow_bodycolumnId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> WebhookAnyColumnChanges(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/AnyColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> WebhookSubitemColumnChanges(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/registerWebhook/SubitemColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
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
