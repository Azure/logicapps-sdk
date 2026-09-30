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
        public IBodyWorkflowAction<GetUpdatesResponse> GetUpdates([WorkflowExpression] Func<string> token)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bot{0}/getupdates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(token, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetUpdatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<GetMeResponse> GetMe([WorkflowExpression] Func<string> token)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bot{0}/getMe", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(token, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> bodychatId = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyparseMode = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(bodychatId, nameof(bodychatId), required: false);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodyparseMode, nameof(bodyparseMode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bot{0}/sendMessage", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(token, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodychatId != null)
                {
                    body["chat_id"] = SourceExpressionConverter.ConvertToken(bodychatId);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyparseMode != null)
                {
                    body["parse_mode"] = SourceExpressionConverter.ConvertToken(bodyparseMode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<Message> SendPhoto([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> bodychatId = null, [WorkflowExpression] Func<string> bodyphoto = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(bodychatId, nameof(bodychatId), required: false);
            SourceExpression.Validate(bodyphoto, nameof(bodyphoto), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bot{0}/sendPhoto", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(token, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodychatId != null)
                {
                    body["chat_id"] = SourceExpressionConverter.ConvertToken(bodychatId);
                    bodypropCount++;
                }

                if (bodyphoto != null)
                {
                    body["photo"] = SourceExpressionConverter.ConvertToken(bodyphoto);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Message>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telegrambotip")]
        public IBodyWorkflowAction<Message> GetChat([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> bodychatId = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(bodychatId, nameof(bodychatId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bot{0}/getChat", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(token, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodychatId != null)
                {
                    body["chat_id"] = SourceExpressionConverter.ConvertToken(bodychatId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Message>(BuildSourceInput);
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