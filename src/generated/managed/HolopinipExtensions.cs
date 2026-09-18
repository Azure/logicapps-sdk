//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Holopinip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HolopinipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopinip")]
        public IBodyWorkflowAction<IssuePostResponse> Issue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyemail)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopinip")]
        public IBodyWorkflowAction<UserStickerGetResponse> UserStickerGet([WorkflowExpression] Func<string> username)
        {
            var apiCallPath = "/stickers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["username"] = ExpressionConverter.Convert(username);
            return new ApiConnectionAction<UserStickerGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "holopinip")]
        public IBodyWorkflowAction<UserBoardGetResponse> UserBoardGet([WorkflowExpression] Func<string> user)
        {
            var apiCallPath = "/user/board";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["user"] = ExpressionConverter.Convert(user);
            return new ApiConnectionAction<UserBoardGetResponse>(callPayload);
        }
    }

    public class HolopinipTriggers([ConnectionName] string connectionId)
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Holopinip;

    public partial class WorkflowManagedActions
    {
        public HolopinipActions Holopinip(string connectionId) => new HolopinipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HolopinipTriggers Holopinip(string connectionId) => new HolopinipTriggers(connectionId);
    }
}