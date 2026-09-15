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
        public IBodyWorkflowAction<GetMyUserProfileResponse> GetMyUserProfile(Expression<Func<string>> accept)
        {
            var apiCallPath = "/api/v1.00/user/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetMyUserProfileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyBoardsResponseItem[]> GetMyBoards(Expression<Func<string>> accept)
        {
            var apiCallPath = "/api/v1.00/boards";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetMyBoardsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyOwnedTreesResponseItem[]> GetMyOwnedTrees(Expression<Func<string>> accept)
        {
            var apiCallPath = "/api/v1.00/owned";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetMyOwnedTreesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyAssignedBoardsResponseItem[]> GetMyAssignedBoards(Expression<Func<string>> accept)
        {
            var apiCallPath = "/api/v1.00/assigned";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetMyAssignedBoardsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardGroupsResponseItem[]> GetBoardGroups(Expression<Func<string>> boardUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/boardgroups/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetBoardGroupsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyNotificationsResponse> GetMyNotifications(Expression<Func<string>> accept)
        {
            var apiCallPath = "/api/v1.00/notifications";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetMyNotificationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyTasksAllResponse> GetMyTasksAll(Expression<Func<string>> accept)
        {
            var apiCallPath = "/api/v1.00/tasks/all";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetMyTasksAllResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyTasksNewResponse> GetMyTasksNew(Expression<Func<string>> accept)
        {
            var apiCallPath = "/api/v1.00/tasks/new";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetMyTasksNewResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetMyTasksOverdueResponse> GetMyTasksOverdue(Expression<Func<string>> accept)
        {
            var apiCallPath = "/api/v1.00/tasks/overdue";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetMyTasksOverdueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardListsResponseItem[]> GetBoardLists(Expression<Func<string>> boardUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/boardlists/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetBoardListsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardCardsResponseItem[]> GetBoardCards(Expression<Func<string>> boardUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/boardcards/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetBoardCardsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetListCardsResponseItem[]> GetListCards(Expression<Func<string>> listUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/listcards/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetListCardsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetListResponseItem[]> GetList(Expression<Func<string>> listUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/list/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetListResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetCardResponseItem[]> GetCard(Expression<Func<string>> cardUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/card/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetCardResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<JToken> GetBoardMessages(Expression<Func<string>> boardUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/messages/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardMembersResponse> GetBoardMembers(Expression<Func<string>> boardUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/members/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetBoardMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardRecordsResponseItem[]> GetBoardRecords(Expression<Func<string>> boardUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/boardrecords/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetBoardRecordsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetListRecordsResponseItem[]> GetListRecords(Expression<Func<string>> listUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/listrecords/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetListRecordsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetTreeClientsResponse> GetTreeClients(Expression<Func<string>> boardUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/clients/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetTreeClientsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<GetBoardHierarchyResponseItem[]> GetBoardHierarchy(Expression<Func<string>> boardUUID, Expression<Func<string>> accept)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/boardhierarchy/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetBoardHierarchyResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAddCardResponse> ActionAddCard(Expression<Func<string>> boardUUID, Expression<Func<string>> accept, Expression<Func<string>> bodyname, Expression<Func<string>> bodylistuuid)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/add/card/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["listuuid"] = CSharpExpressionConverter.ConvertToken(bodylistuuid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionAddCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionDeleteCardResponse> ActionDeleteCard(Expression<Func<string>> cardUUID, Expression<Func<string>> accept, Expression<Func<int>> bodyconfirmed)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/delete/card/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["confirmed"] = CSharpExpressionConverter.ConvertToken(bodyconfirmed);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionDeleteCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAddMessageToBoardResponse> ActionAddMessageToBoard(Expression<Func<string>> boardUUID, Expression<Func<string>> accept, Expression<Func<string>> bodymessage)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/add/message/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["message"] = CSharpExpressionConverter.ConvertToken(bodymessage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionAddMessageToBoardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAddChecklistToCardResponse> ActionAddChecklistToCard(Expression<Func<string>> cardUUID, Expression<Func<string>> accept, Expression<Func<string>> bodyname)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/add/checklist/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionAddChecklistToCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAddListResponse> ActionAddList(Expression<Func<string>> baordUUID, Expression<Func<string>> accept, Expression<Func<string>> bodyname)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/add/list/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(baordUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionAddListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionListRenameResponse> ActionListRename(Expression<Func<string>> listUUID, Expression<Func<string>> accept, Expression<Func<string>> bodyname)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/rename/list/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionListRenameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionBoardRenameResponse> ActionBoardRename(Expression<Func<string>> boardUUID, Expression<Func<string>> accept, Expression<Func<string>> bodyname)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/rename/board/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionBoardRenameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAssignToCardResponse> ActionAssignToCard(Expression<Func<string>> cardUUID, Expression<Func<string>> accept, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyrole)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/assign/card/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            bodypropCount++;
            body["role"] = CSharpExpressionConverter.ConvertToken(bodyrole);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionAssignToCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionAssignToBoardResponse> ActionAssignToBoard(Expression<Func<string>> boardUUID, Expression<Func<string>> accept, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyrole)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/assign/board/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            bodypropCount++;
            body["role"] = CSharpExpressionConverter.ConvertToken(bodyrole);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionAssignToBoardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionUnassignFromCardResponse> ActionUnassignFromCard(Expression<Func<string>> cardUUID, Expression<Func<string>> accept, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyrole)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/unassign/card/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            bodypropCount++;
            body["role"] = CSharpExpressionConverter.ConvertToken(bodyrole);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionUnassignFromCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionUnassignFromBoardResponse> ActionUnassignFromBoard(Expression<Func<string>> boardUUID, Expression<Func<string>> accept, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyrole)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/unassign/board/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            bodypropCount++;
            body["role"] = CSharpExpressionConverter.ConvertToken(bodyrole);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionUnassignFromBoardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "krozupmip")]
        public IBodyWorkflowAction<ActionDeleteListResponse> ActionDeleteList(Expression<Func<string>> listUUID, Expression<Func<string>> accept, Expression<Func<int>> bodyconfirm)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1.00/delete/list/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listUUID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["confirm"] = CSharpExpressionConverter.ConvertToken(bodyconfirm);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionDeleteListResponse>(callPayload);
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