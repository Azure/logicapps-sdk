//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Monday
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MondayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<GetUsersV2Response> GetUsersV2()
        {
            var apiCallPath = "/getData/getUsersV2";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUsersV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<GetTagsV2Response> GetTagsV2()
        {
            var apiCallPath = "/getData/getTagsV2";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTagsV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateItemResponse> CreateItem(Expression<Func<string>> bodygroupId, Expression<Func<string>> bodyitemName, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<string>> bodyboardId = null, Expression<Func<object>> bodycolumnValues = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<DuplicateBoardResponse> DuplicateBoard(Expression<Func<string>> bodysourceWorkspaceId, Expression<Func<string>> bodysourceBoardId, Expression<Func<bodyduplicationTypeInput>> bodyduplicationType, Expression<Func<bool>> bodykeepBoardSubscribers, Expression<Func<string>> bodyduplicatedBoardName = null, Expression<Func<string>> bodydestinationWorkspaceId = null, Expression<Func<string>> bodydestinationFolder = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateBoardResponse> CreateBoard(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardName)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateColumnResponse> CreateColumn(Expression<Func<string>> bodytitle, Expression<Func<bodycolumnTypeInput>> bodycolumnType, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<string>> bodyboardId = null, Expression<Func<string>> bodydescription = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup(Expression<Func<string>> bodygroupName, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<string>> bodyboardId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<UpdateItemColumnResponse> UpdateItemColumn(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, Expression<Func<string>> bodyitemId, Expression<Func<string>> bodycolumnId = null, Expression<Func<object>> bodycolumnValues = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<UpdateMultipleItemColumnsResponse> UpdateMultipleItemColumns(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, Expression<Func<string>> bodyitemId, Expression<Func<string>> bodyitemName = null, Expression<Func<object>> bodycolumnValues = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<MoveItemToGroupResponse> MoveItemToGroup(Expression<Func<string>> bodygroupId, Expression<Func<string>> bodyitemId, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<string>> bodyboardId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateNotificationResponse> CreateNotification(Expression<Func<string>> bodyuserId, Expression<Func<string>> bodytargetId, Expression<Func<string>> bodytext)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateSubitemResponse> CreateSubitem(Expression<Func<string>> bodyboardId, Expression<Func<string>> bodyparentItemId, Expression<Func<string>> bodyitemName, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<object>> bodycolumnValues = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<JToken> GetItemsV2(Expression<Func<string>> workspaceId, Expression<Func<string>> boardId, Expression<Func<string>> groupId, Expression<Func<string>> filter1Column = null, Expression<Func<string>> filter1Operator = null, Expression<Func<string>> filter1Value = null, Expression<Func<string>> filter2Column = null, Expression<Func<string>> filter2Operator = null, Expression<Func<string>> filter2Value = null, Expression<Func<string>> filter3Column = null, Expression<Func<string>> filter3Operator = null, Expression<Func<string>> filter3Value = null, Expression<Func<string>> filter4Column = null, Expression<Func<string>> filter4Operator = null, Expression<Func<string>> filter4Value = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<JToken> GetSubitems(Expression<Func<string>> workspaceId, Expression<Func<string>> boardId, Expression<Func<string>> itemId)
        {
            var apiCallPath = "/getData/getSubitems";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            callPayload.Queries["boardId"] = ExpressionConverter.Convert(boardId);
            callPayload.Queries["itemId"] = ExpressionConverter.Convert(itemId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateUpdateResponse> CreateUpdate(Expression<Func<string>> bodygroupId, Expression<Func<string>> bodyitemId, Expression<Func<string>> bodybody, Expression<Func<string>> bodyworkspaceId = null, Expression<Func<string>> bodyboardId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateWorkspaceV2Response> CreateWorkspaceV2(Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<JToken> GetItemById(Expression<Func<string>> itemId, Expression<Func<string>> workspaceId, Expression<Func<string>> boardId)
        {
            var apiCallPath = "/getData/getItemById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["itemId"] = ExpressionConverter.Convert(itemId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            callPayload.Queries["boardId"] = ExpressionConverter.Convert(boardId);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class MondayTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<JToken> WebhookCreateItem(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId)
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
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        public IOutputWorkflowTrigger<JToken> WebhookCreateUpdate(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId)
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
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        public IOutputWorkflowTrigger<JToken> WebhookChangeName(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId)
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
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        public IOutputWorkflowTrigger<JToken> WebhookChangeSubitemName(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId)
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
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        public IOutputWorkflowTrigger<JToken> WebhookCreateSubitem(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId)
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
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        public IOutputWorkflowTrigger<JToken> WebhookColumnChanges(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId, Expression<Func<string>> bodycolumnId)
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
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        public IOutputWorkflowTrigger<JToken> WebhookAnyColumnChanges(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId)
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
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        public IOutputWorkflowTrigger<JToken> WebhookSubitemColumnChanges(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyboardId)
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
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload);
        }
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Monday;

    public partial class WorkflowManagedActions
    {
        public MondayActions Monday(string connectionId) => new MondayActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MondayTriggers Monday(string connectionId) => new MondayTriggers(connectionId);
    }
}