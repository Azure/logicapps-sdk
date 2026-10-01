//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Holopin
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HolopinActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopin")]
        public IBodyWorkflowAction<IssuePostResponse> Issue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyemail)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sticker/share";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IssuePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopin")]
        public IBodyWorkflowAction<UserStickerGetResponse> UserStickerGet([WorkflowExpression] Func<string> username)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stickers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = SourceExpressionConverter.ConvertO(username);
                return callPayload;
            }

            return new ApiConnectionAction<UserStickerGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopin")]
        public IBodyWorkflowAction<UserBoardGetResponse> UserBoardGet([WorkflowExpression] Func<string> user)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/user/board";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["user"] = SourceExpressionConverter.ConvertO(user);
                return callPayload;
            }

            return new ApiConnectionAction<UserBoardGetResponse>(BuildSourceInput);
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