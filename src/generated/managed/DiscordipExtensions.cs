//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Discordip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DiscordipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "discordip")]
        public IBodyWorkflowAction<User> GetCurrentUser()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v9/users/@me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<User>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "discordip")]
        public IBodyWorkflowAction<Connection[]> GetUserConnections()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v9/users/@me/connections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Connection[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "discordip")]
        public IBodyWorkflowAction<Guild[]> GetCurrentUserGuilds()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v9/users/@me/guilds";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Guild[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "discordip")]
        public IBodyWorkflowAction<Webhook> ExecuteWebhook([WorkflowExpression] Func<string> webhookId, [WorkflowExpression] Func<string> webhookToken, [WorkflowExpression] Func<contentTypeInput> contentType = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<string> bodyavatarURL = null)
        {
            SourceExpression.Validate(webhookId, nameof(webhookId), required: true);
            SourceExpression.Validate(webhookToken, nameof(webhookToken), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodyusername, nameof(bodyusername), required: false);
            SourceExpression.Validate(bodyavatarURL, nameof(bodyavatarURL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v9/webhooks/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webhookId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webhookToken, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["content-type"] = SourceExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodyusername != null)
                {
                    body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                    bodypropCount++;
                }

                if (bodyavatarURL != null)
                {
                    body["avatar-url"] = SourceExpressionConverter.ConvertToken(bodyavatarURL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Webhook>(BuildSourceInput);
        }
    }

    public class DiscordipTriggers([ConnectionName] string connectionId)
    {
    }

    public class User
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("discriminator")]
        public string Discriminator { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("bot")]
        public bool Bot { get; set; }

        [JsonProperty("system")]
        public bool System { get; set; }

        [JsonProperty("mfa_enabled")]
        public bool MFAEnabled { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("flags")]
        public int Flags { get; set; }

        [JsonProperty("premium_type")]
        public int PremiumType { get; set; }

        [JsonProperty("public_flags")]
        public int PublicFlags { get; set; }
    }

    public class Connection
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("friend_sync")]
        public bool FriendSync { get; set; }

        [JsonProperty("show_activity")]
        public bool ShowActivity { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }

    public class Guild
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("owner")]
        public bool Owner { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("features")]
        public string[] Features { get; set; }
    }

    public class Webhook
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("guild_id")]
        public string GuildID { get; set; }

        [JsonProperty("channel_id")]
        public string ChannelID { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationID { get; set; }

        [JsonProperty("source_guild")]
        public Guild SourceGuild { get; set; }

        [JsonProperty("source_channel")]
        public JToken SourceChannel { get; set; }
    }

    public enum contentTypeInput
    {
        [EnumMember(Value = "application/json")]
        ApplicationJson,
        [EnumMember(Value = "multipart/form-data")]
        MultipartFormData
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Discordip;

    public partial class WorkflowManagedActions
    {
        public DiscordipActions Discordip(string connectionId) => new DiscordipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DiscordipTriggers Discordip(string connectionId) => new DiscordipTriggers(connectionId);
    }
}