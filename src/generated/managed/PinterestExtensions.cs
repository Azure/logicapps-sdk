//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pinterest
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PinterestActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        [WorkflowExpressionFactory(nameof(__BuildListPinsFromBoard))]
        public IBodyWorkflowAction<PinResponse> ListPinsFromBoard([WorkflowExpression] Func<string> board)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PinResponse> __BuildListPinsFromBoard(WorkflowExpression<string> board)
        {
            WorkflowExpression.Validate(board, nameof(board), required: true);
            return new DeferredBodyAction<PinResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/boards/{0}/pins", ExpressionConverter.ConvertWithUrlEncoding(board, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PinResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        [WorkflowExpressionFactory(nameof(__BuildCreateBoard))]
        public IBodyWorkflowAction<BoardResponseData> CreateBoard([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> description = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BoardResponseData> __BuildCreateBoard(WorkflowExpression<string> name, WorkflowExpression<string> description = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(description, nameof(description), required: false);
            return new DeferredBodyAction<BoardResponseData>(() =>
            {
                var apiCallPath = "/boards";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(description);
                return new ApiConnectionAction<BoardResponseData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePin))]
        public IBodyWorkflowAction<PinResponseData> CreatePin([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> description, [WorkflowExpression] Func<string> imageUrl, [WorkflowExpression] Func<string> sourceUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PinResponseData> __BuildCreatePin(WorkflowExpression<string> boardId, WorkflowExpression<string> description, WorkflowExpression<string> imageUrl, WorkflowExpression<string> sourceUrl = null)
        {
            WorkflowExpression.Validate(boardId, nameof(boardId), required: true);
            WorkflowExpression.Validate(description, nameof(description), required: true);
            WorkflowExpression.Validate(imageUrl, nameof(imageUrl), required: true);
            WorkflowExpression.Validate(sourceUrl, nameof(sourceUrl), required: false);
            return new DeferredBodyAction<PinResponseData>(() =>
            {
                var apiCallPath = "/pins";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
                callPayload.Queries["description"] = ExpressionConverter.Convert(description);
                callPayload.Queries["image_url"] = ExpressionConverter.Convert(imageUrl);
                if (sourceUrl != null)
                    callPayload.Queries["source_url"] = ExpressionConverter.Convert(sourceUrl);
                return new ApiConnectionAction<PinResponseData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        [WorkflowExpressionFactory(nameof(__BuildEditPin))]
        public IBodyWorkflowAction<PinResponseData> EditPin([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> pin, [WorkflowExpression] Func<string> description, [WorkflowExpression] Func<string> link = null, [WorkflowExpression] Func<string> secondBoard = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PinResponseData> __BuildEditPin(WorkflowExpression<string> boardId, WorkflowExpression<string> pin, WorkflowExpression<string> description, WorkflowExpression<string> link = null, WorkflowExpression<string> secondBoard = null)
        {
            WorkflowExpression.Validate(boardId, nameof(boardId), required: true);
            WorkflowExpression.Validate(pin, nameof(pin), required: true);
            WorkflowExpression.Validate(description, nameof(description), required: true);
            WorkflowExpression.Validate(link, nameof(link), required: false);
            WorkflowExpression.Validate(secondBoard, nameof(secondBoard), required: false);
            return new DeferredBodyAction<PinResponseData>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pins/{0}/save", ExpressionConverter.ConvertWithUrlEncoding(pin, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
                callPayload.Queries["description"] = ExpressionConverter.Convert(description);
                if (link != null)
                    callPayload.Queries["link"] = ExpressionConverter.Convert(link);
                if (secondBoard != null)
                    callPayload.Queries["secondBoard"] = ExpressionConverter.Convert(secondBoard);
                return new ApiConnectionAction<PinResponseData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<CurrentUserResponse> GetCurrentUser()
        {
            var apiCallPath = "/users/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CurrentUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<PinResponse> ListAllPins()
        {
            var apiCallPath = "/users/me/pins";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PinResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<BoardResponse> ListFollowBoards()
        {
            var apiCallPath = "/users/me/boards/following";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BoardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<BoardResponse> ListMyBoards()
        {
            var apiCallPath = "/users/me/boards/feed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BoardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<UserResponse> ListMyFollowers()
        {
            var apiCallPath = "/users/me/followers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<UserResponse> ListMyFollowings()
        {
            var apiCallPath = "/users/me/following";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserResponse>(callPayload);
        }
    }

    public class PinterestTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnPinAddedToFollowedBoard))]
        public IBodyWorkflowTrigger<PinResponse> OnPinAddedToFollowedBoard([WorkflowExpression] Func<string> board, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PinResponse> __BuildOnPinAddedToFollowedBoard(WorkflowExpression<string> board, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(board, nameof(board), required: true);
            return new DeferredBodyTrigger<PinResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger1/boards/{0}/pins", ExpressionConverter.ConvertWithUrlEncoding(board, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<PinResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnPinAddedToMyBoard))]
        public IBodyWorkflowTrigger<PinResponse> OnPinAddedToMyBoard([WorkflowExpression] Func<string> board, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PinResponse> __BuildOnPinAddedToMyBoard(WorkflowExpression<string> board, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(board, nameof(board), required: true);
            return new DeferredBodyTrigger<PinResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger2/boards/{0}/pins", ExpressionConverter.ConvertWithUrlEncoding(board, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<PinResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        public IBodyWorkflowTrigger<UserResponse> OnSomeoneFollowsMe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger4/users/me/followers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<UserResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class PinResponse
    {
        [JsonProperty("data")]
        public PinResponseData[] PinData { get; set; }
    }

    public class PinResponseData
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class BoardResponseData
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CurrentUserResponse
    {
        [JsonProperty("data")]
        public JToken UserData { get; set; }
    }

    public class BoardResponse
    {
        [JsonProperty("data")]
        public BoardResponseData[] BoardData { get; set; }
    }

    public class UserResponse
    {
        [JsonProperty("data")]
        public UserResponseData[] UserData { get; set; }

        [JsonProperty("page")]
        public UserResponsePage Page { get; set; }
    }

    public class UserResponseData
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class UserResponsePage
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pinterest;

    public partial class WorkflowManagedActions
    {
        public PinterestActions Pinterest(string connectionId) => new PinterestActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PinterestTriggers Pinterest(string connectionId) => new PinterestTriggers(connectionId);
    }
}