//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Holopin
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HolopinActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopin")]
        [WorkflowExpressionFactory(nameof(__BuildIssue))]
        public IBodyWorkflowAction<IssuePostResponse> Issue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyemail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopin")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IssuePostResponse> __BuildIssue(WorkflowExpression<string> id, WorkflowExpression<string> bodyemail)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<IssuePostResponse>(() =>
            {
                var apiCallPath = "/sticker/share";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IssuePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopin")]
        [WorkflowExpressionFactory(nameof(__BuildUserStickerGet))]
        public IBodyWorkflowAction<UserStickerGetResponse> UserStickerGet([WorkflowExpression] Func<string> username)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopin")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserStickerGetResponse> __BuildUserStickerGet(WorkflowExpression<string> username)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            return new DeferredBodyAction<UserStickerGetResponse>(() =>
            {
                var apiCallPath = "/stickers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(username);
                return new ApiConnectionAction<UserStickerGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopin")]
        [WorkflowExpressionFactory(nameof(__BuildUserBoardGet))]
        public IBodyWorkflowAction<UserBoardGetResponse> UserBoardGet([WorkflowExpression] Func<string> user)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopin")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserBoardGetResponse> __BuildUserBoardGet(WorkflowExpression<string> user)
        {
            WorkflowExpression.Validate(user, nameof(user), required: true);
            return new DeferredBodyAction<UserBoardGetResponse>(() =>
            {
                var apiCallPath = "/user/board";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["user"] = ExpressionConverter.Convert(user);
                return new ApiConnectionAction<UserBoardGetResponse>(callPayload);
            });
        }
    }

    public class HolopinTriggers([ConnectionName] string connectionId)
    {
    }

    public class IssuePostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IssuePostResponseDataType Data { get; set; }
    }

    public class IssuePostResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("stickerId")]
        public string StickerId { get; set; }
    }

    public class UserStickerGetResponse
    {
        [JsonProperty("data")]
        public UserStickerGetResponseDataType Data { get; set; }
    }

    public class UserStickerGetResponseDataType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("stickers")]
        public UserStickerGetResponseDataTypeStickersTypeItem[] Stickers { get; set; }
    }

    public class UserStickerGetResponseDataTypeStickersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("organization")]
        public UserStickerGetResponseDataTypeStickersTypeItemOrganizationType Organization { get; set; }
        public UserStickerGetResponseDataTypeStickersTypeItemUserStickerTypeItem[] UserSticker { get; set; }
    }

    public class UserStickerGetResponseDataTypeStickersTypeItemOrganizationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class UserStickerGetResponseDataTypeStickersTypeItemUserStickerTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class UserBoardGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Holopin;

    public partial class WorkflowManagedActions
    {
        public HolopinActions Holopin(string connectionId) => new HolopinActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HolopinTriggers Holopin(string connectionId) => new HolopinTriggers(connectionId);
    }
}