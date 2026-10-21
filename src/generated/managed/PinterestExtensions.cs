//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pinterest
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PinterestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<PinResponse> ListPinsFromBoard(Expression<Func<string>> board)
        {
            var __workflow_board = WorkflowExpression.Compile(board, nameof(board), required: true);
            return new DeferredBodyAction<PinResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/boards/{0}/pins", __workflow_board.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PinResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<BoardResponseData> CreateBoard(Expression<Func<string>> name, Expression<Func<string>> description = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            return new DeferredBodyAction<BoardResponseData>(() =>
            {
                var apiCallPath = "/boards";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                return new ApiConnectionAction<BoardResponseData>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<PinResponseData> CreatePin(Expression<Func<string>> boardId, Expression<Func<string>> description, Expression<Func<string>> imageUrl, Expression<Func<string>> sourceUrl = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: true);
            var __workflow_imageUrl = WorkflowExpression.Compile(imageUrl, nameof(imageUrl), required: true);
            var __workflow_sourceUrl = WorkflowExpression.Compile(sourceUrl, nameof(sourceUrl), required: false);
            return new DeferredBodyAction<PinResponseData>(() =>
            {
                var apiCallPath = "/pins";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                callPayload.Queries["image_url"] = ExpressionConverter.Convert(__workflow_imageUrl);
                if (__workflow_sourceUrl != null)
                    callPayload.Queries["source_url"] = ExpressionConverter.Convert(__workflow_sourceUrl);
                return new ApiConnectionAction<PinResponseData>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<PinResponseData> EditPin(Expression<Func<string>> boardId, Expression<Func<string>> pin, Expression<Func<string>> description, Expression<Func<string>> link = null, Expression<Func<string>> secondBoard = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_pin = WorkflowExpression.Compile(pin, nameof(pin), required: true);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: true);
            var __workflow_link = WorkflowExpression.Compile(link, nameof(link), required: false);
            var __workflow_secondBoard = WorkflowExpression.Compile(secondBoard, nameof(secondBoard), required: false);
            return new DeferredBodyAction<PinResponseData>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pins/{0}/save", __workflow_pin.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                if (__workflow_link != null)
                    callPayload.Queries["link"] = ExpressionConverter.Convert(__workflow_link);
                if (__workflow_secondBoard != null)
                    callPayload.Queries["secondBoard"] = ExpressionConverter.Convert(__workflow_secondBoard);
                return new ApiConnectionAction<PinResponseData>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
        public IBodyWorkflowTrigger<PinResponse> OnPinAddedToFollowedBoard(Expression<Func<string>> board, FlowRecurrence recurrence = null)
        {
            var __workflow_board = WorkflowExpression.Compile(board, nameof(board), required: true);
            return new DeferredBodyTrigger<PinResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger1/boards/{0}/pins", __workflow_board.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<PinResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<PinResponse> OnPinAddedToMyBoard(Expression<Func<string>> board, FlowRecurrence recurrence = null)
        {
            var __workflow_board = WorkflowExpression.Compile(board, nameof(board), required: true);
            return new DeferredBodyTrigger<PinResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger2/boards/{0}/pins", __workflow_board.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<PinResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<UserResponse> OnSomeoneFollowsMe(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger4/users/me/followers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<UserResponse>(callPayload, recurrence: recurrence);
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
