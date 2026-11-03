//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Telegrambotip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TelegrambotipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<GetUpdatesResponse, ApiConnectionActionConfiguration> GetUpdates(Expression<Func<string>> token)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            return new DeferredBodyAction<GetUpdatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bot{0}/getupdates", __workflow_token.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUpdatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<GetMeResponse, ApiConnectionActionConfiguration> GetMe(Expression<Func<string>> token)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            return new DeferredBodyAction<GetMeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bot{0}/getMe", __workflow_token.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> token, Expression<Func<string>> bodychatId = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyparseMode = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_bodychatId = WorkflowExpression.Compile(bodychatId, nameof(bodychatId), required: false);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodyparseMode = WorkflowExpression.Compile(bodyparseMode, nameof(bodyparseMode), required: false);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bot{0}/sendMessage", __workflow_token.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodychatId != null)
                {
                    body["chat_id"] = ExpressionConverter.ConvertO(__workflow_bodychatId);
                    bodypropCount++;
                }

                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (__workflow_bodyparseMode != null)
                {
                    body["parse_mode"] = ExpressionConverter.ConvertO(__workflow_bodyparseMode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<Message, ApiConnectionActionConfiguration> SendPhoto(Expression<Func<string>> token, Expression<Func<string>> bodychatId = null, Expression<Func<string>> bodyphoto = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_bodychatId = WorkflowExpression.Compile(bodychatId, nameof(bodychatId), required: false);
            var __workflow_bodyphoto = WorkflowExpression.Compile(bodyphoto, nameof(bodyphoto), required: false);
            return new DeferredBodyAction<Message, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bot{0}/sendPhoto", __workflow_token.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodychatId != null)
                {
                    body["chat_id"] = ExpressionConverter.ConvertO(__workflow_bodychatId);
                    bodypropCount++;
                }

                if (__workflow_bodyphoto != null)
                {
                    body["photo"] = ExpressionConverter.ConvertO(__workflow_bodyphoto);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Message>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<Message, ApiConnectionActionConfiguration> GetChat(Expression<Func<string>> token, Expression<Func<string>> bodychatId = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_bodychatId = WorkflowExpression.Compile(bodychatId, nameof(bodychatId), required: false);
            return new DeferredBodyAction<Message, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bot{0}/getChat", __workflow_token.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodychatId != null)
                {
                    body["chat_id"] = ExpressionConverter.ConvertO(__workflow_bodychatId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Message>(callPayload);
            });
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
        public int UpdateId { get; set; }

        [JsonProperty("message")]
        public Message Message { get; set; }
    }

    public class Message
    {
        [JsonProperty("message_id")]
        public int MessageId { get; set; }

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
        public int Id { get; set; }

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
        public int ChatId { get; set; }

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

namespace Microsoft.Azure.Workflows.Sdk
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