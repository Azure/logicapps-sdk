//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Monday
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MondayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateItemResponse> CreateItem([WorkflowExpression] Func<string> bodygroupId, [WorkflowExpression] Func<string> bodyitemName, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodyboardId = null, [WorkflowExpression] Func<object> bodycolumnValues = null)
        {
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: true);
            SourceExpression.Validate(bodyitemName, nameof(bodyitemName), required: true);
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            SourceExpression.Validate(bodycolumnValues, nameof(bodycolumnValues), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/CreateItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                bodypropCount++;
                body["itemName"] = SourceExpressionConverter.ConvertToken(bodyitemName);
                if (bodycolumnValues != null)
                {
                    body["columnValues"] = SourceExpressionConverter.ConvertToken(bodycolumnValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<DuplicateBoardResponse> DuplicateBoard([WorkflowExpression] Func<string> bodysourceWorkspaceId, [WorkflowExpression] Func<string> bodysourceBoardId, [WorkflowExpression] Func<bodyduplicationTypeInput> bodyduplicationType, [WorkflowExpression] Func<bool> bodykeepBoardSubscribers, [WorkflowExpression] Func<string> bodyduplicatedBoardName = null, [WorkflowExpression] Func<string> bodydestinationWorkspaceId = null, [WorkflowExpression] Func<string> bodydestinationFolder = null)
        {
            SourceExpression.Validate(bodysourceWorkspaceId, nameof(bodysourceWorkspaceId), required: true);
            SourceExpression.Validate(bodysourceBoardId, nameof(bodysourceBoardId), required: true);
            SourceExpression.Validate(bodyduplicationType, nameof(bodyduplicationType), required: true);
            SourceExpression.Validate(bodykeepBoardSubscribers, nameof(bodykeepBoardSubscribers), required: true);
            SourceExpression.Validate(bodyduplicatedBoardName, nameof(bodyduplicatedBoardName), required: false);
            SourceExpression.Validate(bodydestinationWorkspaceId, nameof(bodydestinationWorkspaceId), required: false);
            SourceExpression.Validate(bodydestinationFolder, nameof(bodydestinationFolder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/DuplicateBoard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sourceWorkspaceId"] = SourceExpressionConverter.ConvertToken(bodysourceWorkspaceId);
                bodypropCount++;
                body["sourceBoardId"] = SourceExpressionConverter.ConvertToken(bodysourceBoardId);
                if (bodyduplicatedBoardName != null)
                {
                    body["duplicatedBoardName"] = SourceExpressionConverter.ConvertToken(bodyduplicatedBoardName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["duplicationType"] = SourceExpressionConverter.Convert(bodyduplicationType);
                if (bodydestinationWorkspaceId != null)
                {
                    body["destinationWorkspaceId"] = SourceExpressionConverter.ConvertToken(bodydestinationWorkspaceId);
                    bodypropCount++;
                }

                if (bodydestinationFolder != null)
                {
                    body["destinationFolder"] = SourceExpressionConverter.ConvertToken(bodydestinationFolder);
                    bodypropCount++;
                }

                bodypropCount++;
                body["keepBoardSubscribers"] = SourceExpressionConverter.ConvertToken(bodykeepBoardSubscribers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DuplicateBoardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateBoardResponse> CreateBoard([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardName)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            SourceExpression.Validate(bodyboardName, nameof(bodyboardName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/CreateBoard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["boardName"] = SourceExpressionConverter.ConvertToken(bodyboardName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateBoardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateColumnResponse> CreateColumn([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<bodycolumnTypeInput> bodycolumnType, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodyboardId = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodycolumnType, nameof(bodycolumnType), required: true);
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/CreateColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["columnType"] = SourceExpressionConverter.Convert(bodycolumnType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateColumnResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup([WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodyboardId = null)
        {
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/CreateGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<UpdateItemColumnResponse> UpdateItemColumn([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, [WorkflowExpression] Func<string> bodyitemId, [WorkflowExpression] Func<string> bodycolumnId = null, [WorkflowExpression] Func<object> bodycolumnValues = null)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            SourceExpression.Validate(bodyitemId, nameof(bodyitemId), required: true);
            SourceExpression.Validate(bodycolumnId, nameof(bodycolumnId), required: false);
            SourceExpression.Validate(bodycolumnValues, nameof(bodycolumnValues), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/UpdateItemColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                if (bodycolumnId != null)
                {
                    body["columnId"] = SourceExpressionConverter.ConvertToken(bodycolumnId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["itemId"] = SourceExpressionConverter.ConvertToken(bodyitemId);
                if (bodycolumnValues != null)
                {
                    body["columnValues"] = SourceExpressionConverter.ConvertToken(bodycolumnValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateItemColumnResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<UpdateMultipleItemColumnsResponse> UpdateMultipleItemColumns([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, [WorkflowExpression] Func<string> bodyitemId, [WorkflowExpression] Func<string> bodyitemName = null, [WorkflowExpression] Func<object> bodycolumnValues = null)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            SourceExpression.Validate(bodyitemId, nameof(bodyitemId), required: true);
            SourceExpression.Validate(bodyitemName, nameof(bodyitemName), required: false);
            SourceExpression.Validate(bodycolumnValues, nameof(bodycolumnValues), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/UpdateMultipleItemColumns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                bodypropCount++;
                body["itemId"] = SourceExpressionConverter.ConvertToken(bodyitemId);
                if (bodyitemName != null)
                {
                    body["itemName"] = SourceExpressionConverter.ConvertToken(bodyitemName);
                    bodypropCount++;
                }

                if (bodycolumnValues != null)
                {
                    body["columnValues"] = SourceExpressionConverter.ConvertToken(bodycolumnValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateMultipleItemColumnsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<MoveItemToGroupResponse> MoveItemToGroup([WorkflowExpression] Func<string> bodygroupId, [WorkflowExpression] Func<string> bodyitemId, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodyboardId = null)
        {
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: true);
            SourceExpression.Validate(bodyitemId, nameof(bodyitemId), required: true);
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/MoveItemToGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                bodypropCount++;
                body["itemId"] = SourceExpressionConverter.ConvertToken(bodyitemId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MoveItemToGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateNotificationResponse> CreateNotification([WorkflowExpression] Func<string> bodyuserId, [WorkflowExpression] Func<string> bodytargetId, [WorkflowExpression] Func<string> bodytext)
        {
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            SourceExpression.Validate(bodytargetId, nameof(bodytargetId), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/CreateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                bodypropCount++;
                body["targetId"] = SourceExpressionConverter.ConvertToken(bodytargetId);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateNotificationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateSubitemResponse> CreateSubitem([WorkflowExpression] Func<string> bodyboardId, [WorkflowExpression] Func<string> bodyparentItemId, [WorkflowExpression] Func<string> bodyitemName, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<object> bodycolumnValues = null)
        {
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            SourceExpression.Validate(bodyparentItemId, nameof(bodyparentItemId), required: true);
            SourceExpression.Validate(bodyitemName, nameof(bodyitemName), required: true);
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            SourceExpression.Validate(bodycolumnValues, nameof(bodycolumnValues), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/CreateSubitem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                bodypropCount++;
                body["parentItemId"] = SourceExpressionConverter.ConvertToken(bodyparentItemId);
                bodypropCount++;
                body["itemName"] = SourceExpressionConverter.ConvertToken(bodyitemName);
                if (bodycolumnValues != null)
                {
                    body["columnValues"] = SourceExpressionConverter.ConvertToken(bodycolumnValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateSubitemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<JToken> GetSubitems([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> itemId)
        {
            SourceExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            SourceExpression.Validate(boardId, nameof(boardId), required: true);
            SourceExpression.Validate(itemId, nameof(itemId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getData/getSubitems";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                callPayload.Queries["boardId"] = SourceExpressionConverter.ConvertO(boardId);
                callPayload.Queries["itemId"] = SourceExpressionConverter.ConvertO(itemId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateUpdateResponse> CreateUpdate([WorkflowExpression] Func<string> bodygroupId, [WorkflowExpression] Func<string> bodyitemId, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodyboardId = null)
        {
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: true);
            SourceExpression.Validate(bodyitemId, nameof(bodyitemId), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/CreateUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                bodypropCount++;
                body["itemId"] = SourceExpressionConverter.ConvertToken(bodyitemId);
                bodypropCount++;
                body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<JToken> GetItemById([WorkflowExpression] Func<string> itemId, [WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> boardId)
        {
            SourceExpression.Validate(itemId, nameof(itemId), required: true);
            SourceExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            SourceExpression.Validate(boardId, nameof(boardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getData/getItemById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["itemId"] = SourceExpressionConverter.ConvertO(itemId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                callPayload.Queries["boardId"] = SourceExpressionConverter.ConvertO(boardId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<CreateWorkspaceV2Response> CreateWorkspace([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/executePowerAutomateAction/CreateWorkspaceV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateWorkspaceV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<JToken> GetItems([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> filter1Column = null, [WorkflowExpression] Func<string> filter1Operator = null, [WorkflowExpression] Func<string> filter1Value = null, [WorkflowExpression] Func<string> filter2Column = null, [WorkflowExpression] Func<string> filter2Operator = null, [WorkflowExpression] Func<string> filter2Value = null, [WorkflowExpression] Func<string> filter3Column = null, [WorkflowExpression] Func<string> filter3Operator = null, [WorkflowExpression] Func<string> filter3Value = null, [WorkflowExpression] Func<string> filter4Column = null, [WorkflowExpression] Func<string> filter4Operator = null, [WorkflowExpression] Func<string> filter4Value = null)
        {
            SourceExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            SourceExpression.Validate(boardId, nameof(boardId), required: true);
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(filter1Column, nameof(filter1Column), required: false);
            SourceExpression.Validate(filter1Operator, nameof(filter1Operator), required: false);
            SourceExpression.Validate(filter1Value, nameof(filter1Value), required: false);
            SourceExpression.Validate(filter2Column, nameof(filter2Column), required: false);
            SourceExpression.Validate(filter2Operator, nameof(filter2Operator), required: false);
            SourceExpression.Validate(filter2Value, nameof(filter2Value), required: false);
            SourceExpression.Validate(filter3Column, nameof(filter3Column), required: false);
            SourceExpression.Validate(filter3Operator, nameof(filter3Operator), required: false);
            SourceExpression.Validate(filter3Value, nameof(filter3Value), required: false);
            SourceExpression.Validate(filter4Column, nameof(filter4Column), required: false);
            SourceExpression.Validate(filter4Operator, nameof(filter4Operator), required: false);
            SourceExpression.Validate(filter4Value, nameof(filter4Value), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getData/getItemsV2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                callPayload.Queries["boardId"] = SourceExpressionConverter.ConvertO(boardId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                if (filter1Column != null)
                    callPayload.Queries["filter1Column"] = SourceExpressionConverter.ConvertO(filter1Column);
                if (filter1Operator != null)
                    callPayload.Queries["filter1Operator"] = SourceExpressionConverter.ConvertO(filter1Operator);
                if (filter1Value != null)
                    callPayload.Queries["filter1Value"] = SourceExpressionConverter.ConvertO(filter1Value);
                if (filter2Column != null)
                    callPayload.Queries["filter2Column"] = SourceExpressionConverter.ConvertO(filter2Column);
                if (filter2Operator != null)
                    callPayload.Queries["filter2Operator"] = SourceExpressionConverter.ConvertO(filter2Operator);
                if (filter2Value != null)
                    callPayload.Queries["filter2Value"] = SourceExpressionConverter.ConvertO(filter2Value);
                if (filter3Column != null)
                    callPayload.Queries["filter3Column"] = SourceExpressionConverter.ConvertO(filter3Column);
                if (filter3Operator != null)
                    callPayload.Queries["filter3Operator"] = SourceExpressionConverter.ConvertO(filter3Operator);
                if (filter3Value != null)
                    callPayload.Queries["filter3Value"] = SourceExpressionConverter.ConvertO(filter3Value);
                if (filter4Column != null)
                    callPayload.Queries["filter4Column"] = SourceExpressionConverter.ConvertO(filter4Column);
                if (filter4Operator != null)
                    callPayload.Queries["filter4Operator"] = SourceExpressionConverter.ConvertO(filter4Operator);
                if (filter4Value != null)
                    callPayload.Queries["filter4Value"] = SourceExpressionConverter.ConvertO(filter4Value);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<GetTagsV2Response> GetTags()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getData/getTagsV2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTagsV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monday")]
        public IBodyWorkflowAction<GetUsersV2Response> GetUsers()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getData/getUsersV2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetUsersV2Response>(BuildSourceInput);
        }
    }

    public class MondayTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> WebhookCreateItem([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/registerWebhook/CreateItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> WebhookCreateUpdate([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/registerWebhook/CreateUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> WebhookChangeName([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/registerWebhook/ChangeName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> WebhookChangeSubitemName([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/registerWebhook/ChangeSubitemName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> WebhookCreateSubitem([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/registerWebhook/CreateSubitem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> WebhookColumnChanges([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, [WorkflowExpression] Func<string> bodycolumnId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            SourceExpression.Validate(bodycolumnId, nameof(bodycolumnId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/registerWebhook/ColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                bodypropCount++;
                body["columnId"] = SourceExpressionConverter.ConvertToken(bodycolumnId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> WebhookAnyColumnChanges([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/registerWebhook/AnyColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> WebhookSubitemColumnChanges([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/registerWebhook/SubitemColumnChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
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