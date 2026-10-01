//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Krozupmip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KrozupmipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyUserProfileResponse> GetMyUserProfile([WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1.00/user/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetMyUserProfileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyBoardsResponseItem[]> GetMyBoards([WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1.00/boards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetMyBoardsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyOwnedTreesResponseItem[]> GetMyOwnedTrees([WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1.00/owned";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetMyOwnedTreesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyAssignedBoardsResponseItem[]> GetMyAssignedBoards([WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1.00/assigned";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetMyAssignedBoardsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardGroupsResponseItem[]> GetBoardGroups([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/boardgroups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetBoardGroupsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyNotificationsResponse> GetMyNotifications([WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1.00/notifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetMyNotificationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyTasksAllResponse> GetMyTasksAll([WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1.00/tasks/all";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetMyTasksAllResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyTasksNewResponse> GetMyTasksNew([WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1.00/tasks/new";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetMyTasksNewResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyTasksOverdueResponse> GetMyTasksOverdue([WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1.00/tasks/overdue";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetMyTasksOverdueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardListsResponseItem[]> GetBoardLists([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/boardlists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetBoardListsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardCardsResponseItem[]> GetBoardCards([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/boardcards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetBoardCardsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetListCardsResponseItem[]> GetListCards([WorkflowExpression] Func<string> listUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/listcards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetListCardsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetListResponseItem[]> GetList([WorkflowExpression] Func<string> listUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/list/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetListResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetCardResponseItem[]> GetCard([WorkflowExpression] Func<string> cardUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/card/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetCardResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<JToken> GetBoardMessages([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/messages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardMembersResponse> GetBoardMembers([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/members/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetBoardMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardRecordsResponseItem[]> GetBoardRecords([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/boardrecords/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetBoardRecordsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetListRecordsResponseItem[]> GetListRecords([WorkflowExpression] Func<string> listUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/listrecords/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetListRecordsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetTreeClientsResponse> GetTreeClients([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/clients/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetTreeClientsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardHierarchyResponseItem[]> GetBoardHierarchy([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/boardhierarchy/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<GetBoardHierarchyResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAddCardResponse> ActionAddCard([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodylistuuid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/add/card/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["listuuid"] = SourceExpressionConverter.ConvertToken(bodylistuuid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionAddCardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionDeleteCardResponse> ActionDeleteCard([WorkflowExpression] Func<string> cardUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<int> bodyconfirmed)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/delete/card/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["confirmed"] = SourceExpressionConverter.ConvertToken(bodyconfirmed);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionDeleteCardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAddMessageToBoardResponse> ActionAddMessageToBoard([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodymessage)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/add/message/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionAddMessageToBoardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAddChecklistToCardResponse> ActionAddChecklistToCard([WorkflowExpression] Func<string> cardUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyname)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/add/checklist/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionAddChecklistToCardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAddListResponse> ActionAddList([WorkflowExpression] Func<string> baordUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyname)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/add/list/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(baordUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionAddListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionListRenameResponse> ActionListRename([WorkflowExpression] Func<string> listUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyname)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/rename/list/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionListRenameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionBoardRenameResponse> ActionBoardRename([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyname)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/rename/board/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionBoardRenameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAssignToCardResponse> ActionAssignToCard([WorkflowExpression] Func<string> cardUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyrole)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/assign/card/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionAssignToCardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAssignToBoardResponse> ActionAssignToBoard([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyrole)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/assign/board/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionAssignToBoardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionUnassignFromCardResponse> ActionUnassignFromCard([WorkflowExpression] Func<string> cardUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyrole)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/unassign/card/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionUnassignFromCardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionUnassignFromBoardResponse> ActionUnassignFromBoard([WorkflowExpression] Func<string> boardUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyrole)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/unassign/board/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionUnassignFromBoardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionDeleteListResponse> ActionDeleteList([WorkflowExpression] Func<string> listUUID, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<int> bodyconfirm)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1.00/delete/list/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listUUID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["confirm"] = SourceExpressionConverter.ConvertToken(bodyconfirm);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionDeleteListResponse>(BuildSourceInput);
        }
    }

    public class KrozupmipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetMyUserProfileResponse
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clockstatus")]
        public int Clockstatus { get; set; }

        [JsonProperty("taskname")]
        public string Taskname { get; set; }

        [JsonProperty("newInvitationCount")]
        public int NewInvitationCount { get; set; }
    }

    public class GetMyBoardsResponseItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("public")]
        public int Public { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("isboard")]
        public int Isboard { get; set; }

        [JsonProperty("unread")]
        public string Unread { get; set; }

        [JsonProperty("isroot")]
        public int Isroot { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetMyOwnedTreesResponseItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("public")]
        public int Public { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetMyAssignedBoardsResponseItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("public")]
        public int Public { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("isboard")]
        public int Isboard { get; set; }

        [JsonProperty("unread")]
        public string Unread { get; set; }

        [JsonProperty("isroot")]
        public int Isroot { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetBoardGroupsResponseItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sort")]
        public int Sort { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetMyNotificationsResponse
    {
        [JsonProperty("alerts")]
        public GetMyNotificationsResponseAlertsTypeItem[] Alerts { get; set; }

        [JsonProperty("unread")]
        public JToken[] Unread { get; set; }
    }

    public class GetMyNotificationsResponseAlertsTypeItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("subtype")]
        public int Subtype { get; set; }

        [JsonProperty("seen")]
        public int Seen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("fromname")]
        public string Fromname { get; set; }

        [JsonProperty("carduuid")]
        public string Carduuid { get; set; }

        [JsonProperty("isboard")]
        public int Isboard { get; set; }

        [JsonProperty("boarduuid")]
        public string Boarduuid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetMyTasksAllResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public GetMyTasksAllResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }
    }

    public class GetMyTasksAllResponseDataTypeItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("taskname")]
        public string Taskname { get; set; }

        [JsonProperty("projectname")]
        public string Projectname { get; set; }

        [JsonProperty("projectuuid")]
        public string Projectuuid { get; set; }

        [JsonProperty("hours")]
        public string Hours { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }
    }

    public class GetMyTasksNewResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public GetMyTasksNewResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }
    }

    public class GetMyTasksNewResponseDataTypeItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("taskname")]
        public string Taskname { get; set; }

        [JsonProperty("projectname")]
        public string Projectname { get; set; }

        [JsonProperty("projectuuid")]
        public string Projectuuid { get; set; }

        [JsonProperty("hours")]
        public string Hours { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }
    }

    public class GetMyTasksOverdueResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }
    }

    public class GetBoardListsResponseItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("groupuuid")]
        public string Groupuuid { get; set; }

        [JsonProperty("groupsort")]
        public int Groupsort { get; set; }

        [JsonProperty("boardsort")]
        public int Boardsort { get; set; }

        [JsonProperty("cardlimit")]
        public int Cardlimit { get; set; }

        [JsonProperty("weighting")]
        public int Weighting { get; set; }

        [JsonProperty("weigthinglow")]
        public int Weigthinglow { get; set; }

        [JsonProperty("weightinghigh")]
        public int Weightinghigh { get; set; }

        [JsonProperty("timetracking")]
        public int Timetracking { get; set; }

        [JsonProperty("resetcardprogress")]
        public int Resetcardprogress { get; set; }

        [JsonProperty("allowtester")]
        public int Allowtester { get; set; }

        [JsonProperty("archived")]
        public int Archived { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetBoardCardsResponseItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("listuuid")]
        public string Listuuid { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("weightedprogress")]
        public int Weightedprogress { get; set; }

        [JsonProperty("pinned")]
        public int Pinned { get; set; }

        [JsonProperty("archived")]
        public int Archived { get; set; }

        [JsonProperty("estimatedhours")]
        public int Estimatedhours { get; set; }

        [JsonProperty("clientuuid")]
        public string Clientuuid { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetListCardsResponseItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("listuuid")]
        public string Listuuid { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("weightedprogress")]
        public int Weightedprogress { get; set; }

        [JsonProperty("pinned")]
        public int Pinned { get; set; }

        [JsonProperty("archived")]
        public int Archived { get; set; }

        [JsonProperty("estimatedhours")]
        public int Estimatedhours { get; set; }

        [JsonProperty("clientuuid")]
        public string Clientuuid { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetListResponseItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("groupuuid")]
        public string Groupuuid { get; set; }

        [JsonProperty("groupsort")]
        public int Groupsort { get; set; }

        [JsonProperty("boardsort")]
        public int Boardsort { get; set; }

        [JsonProperty("cardlimit")]
        public int Cardlimit { get; set; }

        [JsonProperty("weighting")]
        public int Weighting { get; set; }

        [JsonProperty("weigthinglow")]
        public int Weigthinglow { get; set; }

        [JsonProperty("weightinghigh")]
        public int Weightinghigh { get; set; }

        [JsonProperty("timetracking")]
        public int Timetracking { get; set; }

        [JsonProperty("resetcardprogress")]
        public int Resetcardprogress { get; set; }

        [JsonProperty("allowtester")]
        public int Allowtester { get; set; }

        [JsonProperty("archived")]
        public int Archived { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetCardResponseItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("listuuid")]
        public string Listuuid { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("weightedprogress")]
        public int Weightedprogress { get; set; }

        [JsonProperty("pinned")]
        public int Pinned { get; set; }

        [JsonProperty("archived")]
        public int Archived { get; set; }

        [JsonProperty("estimatedhours")]
        public int Estimatedhours { get; set; }

        [JsonProperty("clientuuid")]
        public string Clientuuid { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetBoardMembersResponse
    {
        [JsonProperty("Tree Owner")]
        public GetBoardMembersResponseTreeOwnerTypeItem[] TreeOwner { get; set; }
        public GetBoardMembersResponseGuestTypeItem[] Guest { get; set; }
    }

    public class GetBoardMembersResponseTreeOwnerTypeItem
    {
        [JsonProperty("carduuid")]
        public string Carduuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("inherited")]
        public int Inherited { get; set; }

        [JsonProperty("inheritedfrom")]
        public string Inheritedfrom { get; set; }

        [JsonProperty("immutable")]
        public bool Immutable { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetBoardMembersResponseGuestTypeItem
    {
        [JsonProperty("carduuid")]
        public string Carduuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("inherited")]
        public int Inherited { get; set; }

        [JsonProperty("inheritedfrom")]
        public string Inheritedfrom { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetBoardRecordsResponseItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("json")]
        public GetBoardRecordsResponseItemJsonType Json { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetBoardRecordsResponseItemJsonType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("show")]
        public bool Show { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("what")]
        public GetBoardRecordsResponseItemJsonTypeWhatType What { get; set; }
    }

    public class GetBoardRecordsResponseItemJsonTypeWhatType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("board_uuid")]
        public string BoardUuid { get; set; }
    }

    public class GetListRecordsResponseItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("json")]
        public GetListRecordsResponseItemJsonType Json { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetListRecordsResponseItemJsonType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("show")]
        public bool Show { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class GetTreeClientsResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public GetTreeClientsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }
    }

    public class GetTreeClientsResponseDataTypeItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetBoardHierarchyResponseItem
    {
        [JsonProperty("dabbed10559a11ec986459ee7f940894")]
        public GetBoardHierarchyResponseItemDabbed10559a11ec986459ee7f940894Type Dabbed10559a11ec986459ee7f940894 { get; set; }
    }

    public class GetBoardHierarchyResponseItemDabbed10559a11ec986459ee7f940894Type
    {
        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("children")]
        public GetBoardHierarchyResponseItemDabbed10559a11ec986459ee7f940894TypeChildrenTypeItem[] Children { get; set; }
    }

    public class GetBoardHierarchyResponseItemDabbed10559a11ec986459ee7f940894TypeChildrenTypeItem
    {
        [JsonProperty("41eb1000ca5a5d2bbfb7b5c2974e1020")]
        public GetBoardHierarchyResponseItemDabbed10559a11ec986459ee7f940894TypeChildrenTypeItem_41eb1000ca5a5d2bbfb7b5c2974e1020Type _41eb1000ca5a5d2bbfb7b5c2974e1020 { get; set; }
    }

    public class GetBoardHierarchyResponseItemDabbed10559a11ec986459ee7f940894TypeChildrenTypeItem_41eb1000ca5a5d2bbfb7b5c2974e1020Type
    {
        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("children")]
        public string[] Children { get; set; }
    }

    public class ActionAddCardResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("carduuid")]
        public string Carduuid { get; set; }

        [JsonProperty("board_update")]
        public ActionAddCardResponseBoardUpdateType BoardUpdate { get; set; }
    }

    public class ActionAddCardResponseBoardUpdateType
    {
        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("thisUpdate")]
        public int ThisUpdate { get; set; }
    }

    public class ActionDeleteCardResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("carduuid")]
        public string Carduuid { get; set; }

        [JsonProperty("boarduuid")]
        public string Boarduuid { get; set; }

        [JsonProperty("board_update")]
        public ActionDeleteCardResponseBoardUpdateType BoardUpdate { get; set; }
    }

    public class ActionDeleteCardResponseBoardUpdateType
    {
        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("thisUpdate")]
        public int ThisUpdate { get; set; }
    }

    public class ActionAddMessageToBoardResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("messageuuid")]
        public string Messageuuid { get; set; }
    }

    public class ActionAddChecklistToCardResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("checklistuuid")]
        public string Checklistuuid { get; set; }

        [JsonProperty("board_update")]
        public ActionAddChecklistToCardResponseBoardUpdateType BoardUpdate { get; set; }
    }

    public class ActionAddChecklistToCardResponseBoardUpdateType
    {
        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("thisUpdate")]
        public int ThisUpdate { get; set; }
    }

    public class ActionAddListResponse
    {
        [JsonProperty("board_update")]
        public ActionAddListResponseBoardUpdateType BoardUpdate { get; set; }

        [JsonProperty("listuuid")]
        public string Listuuid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class ActionAddListResponseBoardUpdateType
    {
        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("thisUpdate")]
        public int ThisUpdate { get; set; }
    }

    public class ActionListRenameResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("board_update")]
        public ActionListRenameResponseBoardUpdateType BoardUpdate { get; set; }
    }

    public class ActionListRenameResponseBoardUpdateType
    {
        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("thisUpdate")]
        public int ThisUpdate { get; set; }
    }

    public class ActionBoardRenameResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("board_update")]
        public ActionBoardRenameResponseBoardUpdateType BoardUpdate { get; set; }
    }

    public class ActionBoardRenameResponseBoardUpdateType
    {
        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("thisUpdate")]
        public int ThisUpdate { get; set; }
    }

    public class ActionAssignToCardResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("carduuid")]
        public string Carduuid { get; set; }

        [JsonProperty("board_update")]
        public ActionAssignToCardResponseBoardUpdateType BoardUpdate { get; set; }
    }

    public class ActionAssignToCardResponseBoardUpdateType
    {
        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("thisUpdate")]
        public int ThisUpdate { get; set; }
    }

    public class ActionAssignToBoardResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("carduuid")]
        public string Carduuid { get; set; }

        [JsonProperty("board_update")]
        public ActionAssignToBoardResponseBoardUpdateType BoardUpdate { get; set; }
    }

    public class ActionAssignToBoardResponseBoardUpdateType
    {
        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("thisUpdate")]
        public int ThisUpdate { get; set; }
    }

    public class ActionUnassignFromCardResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("carduuid")]
        public string Carduuid { get; set; }

        [JsonProperty("board_update")]
        public ActionUnassignFromCardResponseBoardUpdateType BoardUpdate { get; set; }
    }

    public class ActionUnassignFromCardResponseBoardUpdateType
    {
        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("thisUpdate")]
        public int ThisUpdate { get; set; }
    }

    public class ActionUnassignFromBoardResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("carduuid")]
        public string Carduuid { get; set; }

        [JsonProperty("board_update")]
        public ActionUnassignFromBoardResponseBoardUpdateType BoardUpdate { get; set; }
    }

    public class ActionUnassignFromBoardResponseBoardUpdateType
    {
        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("thisUpdate")]
        public int ThisUpdate { get; set; }
    }

    public class ActionDeleteListResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("listuuid")]
        public string Listuuid { get; set; }

        [JsonProperty("boarduuid")]
        public string Boarduuid { get; set; }

        [JsonProperty("board_update")]
        public ActionDeleteListResponseBoardUpdateType BoardUpdate { get; set; }
    }

    public class ActionDeleteListResponseBoardUpdateType
    {
        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("thisUpdate")]
        public int ThisUpdate { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Krozupmip;

    public partial class WorkflowManagedActions
    {
        public KrozupmipActions Krozupmip(string connectionId) => new KrozupmipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KrozupmipTriggers Krozupmip(string connectionId) => new KrozupmipTriggers(connectionId);
    }
}