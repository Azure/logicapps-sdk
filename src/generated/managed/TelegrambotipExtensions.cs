//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Telegrambotip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TelegrambotipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<GetUpdatesResponse> GetUpdates(Expression<Func<string>> token)
        {
            var apiCallPath = String.Format("/bot{0}/getupdates", ExpressionConverter.ConvertWithUrlEncoding(token, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUpdatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<GetMeResponse> GetMe(Expression<Func<string>> token)
        {
            var apiCallPath = String.Format("/bot{0}/getMe", ExpressionConverter.ConvertWithUrlEncoding(token, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string>> token, Expression<Func<string>> bodychatID = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyparseMode = null)
        {
            var apiCallPath = String.Format("/bot{0}/sendMessage", ExpressionConverter.ConvertWithUrlEncoding(token, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodychatID != null)
            {
                body["chat_id"] = ExpressionConverter.ConvertO(bodychatID);
                bodypropCount++;
            }

            if (bodytext != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodyparseMode != null)
            {
                body["parse_mode"] = ExpressionConverter.ConvertO(bodyparseMode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<Message> SendPhoto(Expression<Func<string>> token, Expression<Func<string>> bodychatID = null, Expression<Func<string>> bodyphoto = null)
        {
            var apiCallPath = String.Format("/bot{0}/sendPhoto", ExpressionConverter.ConvertWithUrlEncoding(token, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodychatID != null)
            {
                body["chat_id"] = ExpressionConverter.ConvertO(bodychatID);
                bodypropCount++;
            }

            if (bodyphoto != null)
            {
                body["photo"] = ExpressionConverter.ConvertO(bodyphoto);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Message>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<Message> GetChat(Expression<Func<string>> token, Expression<Func<string>> bodychatID = null)
        {
            var apiCallPath = String.Format("/bot{0}/getChat", ExpressionConverter.ConvertWithUrlEncoding(token, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodychatID != null)
            {
                body["chat_id"] = ExpressionConverter.ConvertO(bodychatID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Message>(callPayload);
        }
    }

    public class TelegrambotipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetUpdatesResponse
    {
        [JsonProperty("ok")]
        public bool OK { get; set; }

        [JsonProperty("result")]
        public Update[] Result { get; set; }
    }

    public class Update
    {
        [JsonProperty("update_id")]
        public int UpdateID { get; set; }

        [JsonProperty("message")]
        public Message Message { get; set; }
    }

    public class Message
    {
        [JsonProperty("message_id")]
        public int MessageID { get; set; }

        [JsonProperty("from")]
        public User From { get; set; }

        [JsonProperty("chat")]
        public ChatInfo Chat { get; set; }

        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class User
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("is_bot")]
        public bool IsBot { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("can_join_groups")]
        public bool CanJoinGroups { get; set; }

        [JsonProperty("can_read_all_group_messages")]
        public bool CanReadAllGroupMessages { get; set; }

        [JsonProperty("supports_inline_queries")]
        public bool SupportsInlineQueries { get; set; }
    }

    public class ChatInfo
    {
        [JsonProperty("id")]
        public int ChatID { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("type")]
        public string Chat { get; set; }
    }

    public class GetMeResponse
    {
        [JsonProperty("ok")]
        public bool OK { get; set; }

        [JsonProperty("result")]
        public User Result { get; set; }
    }

    public class SendMessageResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public Message Result { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Telegrambotip;

    public partial class WorkflowManagedActions
    {
        public TelegrambotipActions Telegrambotip(string connectionId) => new TelegrambotipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TelegrambotipTriggers Telegrambotip(string connectionId) => new TelegrambotipTriggers(connectionId);
    }
}