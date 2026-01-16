//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pinterest
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PinterestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<BoardResponse> ListFollowBoardsV2()
        {
            var apiCallPath = "/users/me/boards/following";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BoardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<BoardResponse> ListMyBoardsV2()
        {
            var apiCallPath = "/users/me/boards/feed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BoardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<BoardResponseData> CreateBoardV2(Expression<Func<string>> name, Expression<Func<string>> description = null)
        {
            var apiCallPath = "/boards";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (description != null)
                callPayload.Queries["description"] = ExpressionConverter.Convert(description);
            return new ApiConnectionAction<BoardResponseData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<PinResponse> ListAllPinsV2()
        {
            var apiCallPath = "/users/me/pins";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PinResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<PinResponse> ListPinsFromBoard(Expression<Func<string>> board)
        {
            var apiCallPath = String.Format("/boards/{0}/pins", ExpressionConverter.ConvertWithUrlEncoding(board, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PinResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<PinResponseData> CreatePinV2(Expression<Func<string>> boardId, Expression<Func<string>> description, Expression<Func<string>> imageUrl, Expression<Func<string>> sourceUrl = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<PinResponseData> EditPinV2(Expression<Func<string>> boardId, Expression<Func<string>> pin, Expression<Func<string>> description, Expression<Func<string>> link = null, Expression<Func<string>> secondBoard = null)
        {
            var apiCallPath = String.Format("/pins/{0}/save", ExpressionConverter.ConvertWithUrlEncoding(pin, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            callPayload.Queries["description"] = ExpressionConverter.Convert(description);
            if (link != null)
                callPayload.Queries["link"] = ExpressionConverter.Convert(link);
            if (secondBoard != null)
                callPayload.Queries["secondBoard"] = ExpressionConverter.Convert(secondBoard);
            return new ApiConnectionAction<PinResponseData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<CurrentUserResponse> GetCurrentUserV2()
        {
            var apiCallPath = "/users/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CurrentUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<UserResponse> ListMyFollowersV2()
        {
            var apiCallPath = "/users/me/followers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<UserResponse> ListMyFollowingsV2()
        {
            var apiCallPath = "/users/me/following";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserResponse>(callPayload);
        }
    }

    public class PinterestTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<PinResponse> OnPinAddedToFollowedBoard(Expression<Func<string>> board, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger1/boards/{0}/pins", ExpressionConverter.ConvertWithUrlEncoding(board, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PinResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<PinResponse> OnPinAddedToMyBoard(Expression<Func<string>> board, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger2/boards/{0}/pins", ExpressionConverter.ConvertWithUrlEncoding(board, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PinResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<UserResponse> OnSomeoneFollowsMeV2(string triggerName = null)
        {
            var apiCallPath = "/trigger4/users/me/followers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<UserResponse>(callPayload);
        }
    }

    public class BoardResponse
    {
        [JsonProperty("data")]
        public BoardResponseData[] BoardData { get; set; }
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

    public class CurrentUserResponse
    {
        [JsonProperty("data")]
        public JToken UserData { get; set; }
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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