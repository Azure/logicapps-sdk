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
        public IBodyWorkflowAction<PinResponse> ListPinsFromBoard([WorkflowExpression] Func<string> board)
        {
            SourceExpression.Validate(board, nameof(board), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/boards/{0}/pins", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(board, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PinResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<BoardResponseData> CreateBoard([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> description = null)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(description, nameof(description), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/boards";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (description != null)
                    callPayload.Queries["description"] = SourceExpressionConverter.ConvertO(description);
                return callPayload;
            }

            return new ApiConnectionAction<BoardResponseData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<PinResponseData> CreatePin([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> description, [WorkflowExpression] Func<string> imageUrl, [WorkflowExpression] Func<string> sourceUrl = null)
        {
            SourceExpression.Validate(boardId, nameof(boardId), required: true);
            SourceExpression.Validate(description, nameof(description), required: true);
            SourceExpression.Validate(imageUrl, nameof(imageUrl), required: true);
            SourceExpression.Validate(sourceUrl, nameof(sourceUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pins";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                callPayload.Queries["description"] = SourceExpressionConverter.ConvertO(description);
                callPayload.Queries["image_url"] = SourceExpressionConverter.ConvertO(imageUrl);
                if (sourceUrl != null)
                    callPayload.Queries["source_url"] = SourceExpressionConverter.ConvertO(sourceUrl);
                return callPayload;
            }

            return new ApiConnectionAction<PinResponseData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<PinResponseData> EditPin([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> pin, [WorkflowExpression] Func<string> description, [WorkflowExpression] Func<string> link = null, [WorkflowExpression] Func<string> secondBoard = null)
        {
            SourceExpression.Validate(boardId, nameof(boardId), required: true);
            SourceExpression.Validate(pin, nameof(pin), required: true);
            SourceExpression.Validate(description, nameof(description), required: true);
            SourceExpression.Validate(link, nameof(link), required: false);
            SourceExpression.Validate(secondBoard, nameof(secondBoard), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pins/{0}/save", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pin, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                callPayload.Queries["description"] = SourceExpressionConverter.ConvertO(description);
                if (link != null)
                    callPayload.Queries["link"] = SourceExpressionConverter.ConvertO(link);
                if (secondBoard != null)
                    callPayload.Queries["secondBoard"] = SourceExpressionConverter.ConvertO(secondBoard);
                return callPayload;
            }

            return new ApiConnectionAction<PinResponseData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<CurrentUserResponse> GetCurrentUser()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CurrentUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<PinResponse> ListAllPins()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/me/pins";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PinResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<BoardResponse> ListFollowBoards()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/me/boards/following";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BoardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<BoardResponse> ListMyBoards()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/me/boards/feed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BoardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<UserResponse> ListMyFollowers()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/me/followers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pinterest")]
        public IBodyWorkflowAction<UserResponse> ListMyFollowings()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/me/following";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserResponse>(BuildSourceInput);
        }
    }

    public class PinterestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PinResponse> OnPinAddedToFollowedBoard([WorkflowExpression] Func<string> board, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(board, nameof(board), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger1/boards/{0}/pins", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(board, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<PinResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PinResponse> OnPinAddedToMyBoard([WorkflowExpression] Func<string> board, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(board, nameof(board), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger2/boards/{0}/pins", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(board, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<PinResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<UserResponse> OnSomeoneFollowsMe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger4/users/me/followers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<UserResponse>(BuildSourceInput, triggerName, recurrence);
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