//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotconversations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotconversationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetConversationsInboxesResponse> GetConversationsInboxes([WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> defaultPageLength = null)
        {
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(defaultPageLength, nameof(defaultPageLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/conversations/inboxes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (defaultPageLength != null)
                    callPayload.Queries["defaultPageLength"] = SourceExpressionConverter.ConvertO(defaultPageLength);
                return callPayload;
            }

            return new ApiConnectionAction<GetConversationsInboxesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleThreadResponse> GetASingleThread([WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<GetASingleThreadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<string> ArchivesAThread([WorkflowExpression] Func<string> threadId)
        {
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<UpdateAThreadResponse> UpdateAThread([WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodyarchived = null)
        {
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyarchived, nameof(bodyarchived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyarchived != null)
                {
                    body["archived"] = SourceExpressionConverter.ConvertToken(bodyarchived);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateAThreadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetTheOriginalContentOfASingleMessageResponse> GetTheOriginalContentOfASingleMessage([WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}/messages/{1}/original-content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<GetTheOriginalContentOfASingleMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetMessageHistoryForAThreadResponse> GetMessageHistoryForAThread([WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<GetMessageHistoryForAThreadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetChannelAccountsResponse> GetChannelAccounts([WorkflowExpression] Func<string> channelId = null, [WorkflowExpression] Func<string> inboxId = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> defaultPageLength = null)
        {
            SourceExpression.Validate(channelId, nameof(channelId), required: false);
            SourceExpression.Validate(inboxId, nameof(inboxId), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(defaultPageLength, nameof(defaultPageLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/conversations/channel-accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (channelId != null)
                    callPayload.Queries["channelId"] = SourceExpressionConverter.ConvertO(channelId);
                if (inboxId != null)
                    callPayload.Queries["inboxId"] = SourceExpressionConverter.ConvertO(inboxId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (defaultPageLength != null)
                    callPayload.Queries["defaultPageLength"] = SourceExpressionConverter.ConvertO(defaultPageLength);
                return callPayload;
            }

            return new ApiConnectionAction<GetChannelAccountsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleChannelResponse> GetASingleChannel([WorkflowExpression] Func<string> channelId)
        {
            SourceExpression.Validate(channelId, nameof(channelId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/channels/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetASingleChannelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleMessageResponse> GetASingleMessage([WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}/messages/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<GetASingleMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetChannelsResponse> GetChannels([WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> defaultPageLength = null)
        {
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(defaultPageLength, nameof(defaultPageLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/conversations/channels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (defaultPageLength != null)
                    callPayload.Queries["defaultPageLength"] = SourceExpressionConverter.ConvertO(defaultPageLength);
                return callPayload;
            }

            return new ApiConnectionAction<GetChannelsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleActorResponse> GetASingleActor([WorkflowExpression] Func<string> actorId, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(actorId, nameof(actorId), required: true);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/actors/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<GetASingleActorResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetThreadsResponse> GetThreads([WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> inboxId = null, [WorkflowExpression] Func<string> associatedContactId = null, [WorkflowExpression] Func<string> threadStatus = null, [WorkflowExpression] Func<string> latestMessageTimestampAfter = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(inboxId, nameof(inboxId), required: false);
            SourceExpression.Validate(associatedContactId, nameof(associatedContactId), required: false);
            SourceExpression.Validate(threadStatus, nameof(threadStatus), required: false);
            SourceExpression.Validate(latestMessageTimestampAfter, nameof(latestMessageTimestampAfter), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/conversations/threads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (inboxId != null)
                    callPayload.Queries["inboxId"] = SourceExpressionConverter.ConvertO(inboxId);
                if (associatedContactId != null)
                    callPayload.Queries["associatedContactId"] = SourceExpressionConverter.ConvertO(associatedContactId);
                if (threadStatus != null)
                    callPayload.Queries["threadStatus"] = SourceExpressionConverter.ConvertO(threadStatus);
                if (latestMessageTimestampAfter != null)
                    callPayload.Queries["latestMessageTimestampAfter"] = SourceExpressionConverter.ConvertO(latestMessageTimestampAfter);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<GetThreadsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleChannelAccountResponse> GetASingleChannelAccount([WorkflowExpression] Func<string> channelAccountId)
        {
            SourceExpression.Validate(channelAccountId, nameof(channelAccountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/channel-accounts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelAccountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetASingleChannelAccountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleConversationsInboxResponse> GetASingleConversationsInbox([WorkflowExpression] Func<string> inboxId)
        {
            SourceExpression.Validate(inboxId, nameof(inboxId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/inboxes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inboxId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetASingleConversationsInboxResponse>(BuildSourceInput);
        }
    }

    public class HubspotconversationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetConversationsInboxesResponse
    {
        [JsonProperty("results")]
        public GetConversationsInboxesResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public GetConversationsInboxesResponsePagingType Paging { get; set; }
    }

    public class GetConversationsInboxesResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class GetConversationsInboxesResponsePagingType
    {
        [JsonProperty("next")]
        public GetConversationsInboxesResponsePagingTypeNextType Next { get; set; }
    }

    public class GetConversationsInboxesResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetASingleThreadResponse
    {
        [JsonProperty("associatedContactId")]
        public string AssociatedContactId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("inboxId")]
        public string InboxId { get; set; }

        [JsonProperty("spam")]
        public bool Spam { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("closedAt")]
        public string ClosedAt { get; set; }

        [JsonProperty("latestMessageTimestamp")]
        public string LatestMessageTimestamp { get; set; }

        [JsonProperty("latestMessageSentTimestamp")]
        public string LatestMessageSentTimestamp { get; set; }

        [JsonProperty("latestMessageReceivedTimestamp")]
        public string LatestMessageReceivedTimestamp { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }
    }

    public class UpdateAThreadResponse
    {
        [JsonProperty("associatedContactId")]
        public string AssociatedContactId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("inboxId")]
        public string InboxId { get; set; }

        [JsonProperty("spam")]
        public bool Spam { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("closedAt")]
        public string ClosedAt { get; set; }

        [JsonProperty("latestMessageTimestamp")]
        public string LatestMessageTimestamp { get; set; }

        [JsonProperty("latestMessageSentTimestamp")]
        public string LatestMessageSentTimestamp { get; set; }

        [JsonProperty("latestMessageReceivedTimestamp")]
        public string LatestMessageReceivedTimestamp { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }
    }

    public class GetTheOriginalContentOfASingleMessageResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("richText")]
        public string RichText { get; set; }
    }

    public class GetMessageHistoryForAThreadResponse
    {
        [JsonProperty("results")]
        public GetMessageHistoryForAThreadResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public GetMessageHistoryForAThreadResponsePagingType Paging { get; set; }
    }

    public class GetMessageHistoryForAThreadResponseResultsTypeItem
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("client")]
        public GetMessageHistoryForAThreadResponseResultsTypeItemClientType Client { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recipients")]
        public GetMessageHistoryForAThreadResponseResultsTypeItemRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("senders")]
        public GetMessageHistoryForAThreadResponseResultsTypeItemSendersTypeItem[] Senders { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("truncationStatus")]
        public string TruncationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("richText")]
        public string RichText { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("inReplyToId")]
        public string InReplyToId { get; set; }

        [JsonProperty("status")]
        public GetMessageHistoryForAThreadResponseResultsTypeItemStatusType Status { get; set; }

        [JsonProperty("channelId")]
        public string ChannelId { get; set; }

        [JsonProperty("channelAccountId")]
        public string ChannelAccountId { get; set; }

        [JsonProperty("conversationsThreadId")]
        public string ConversationsThreadId { get; set; }
    }

    public class GetMessageHistoryForAThreadResponseResultsTypeItemClientType
    {
        [JsonProperty("clientType")]
        public string ClientType { get; set; }

        [JsonProperty("integrationAppId")]
        public string IntegrationAppId { get; set; }
    }

    public class GetMessageHistoryForAThreadResponseResultsTypeItemRecipientsTypeItem
    {
        [JsonProperty("deliveryIdentifier")]
        public GetMessageHistoryForAThreadResponseResultsTypeItemRecipientsTypeItemDeliveryIdentifierType DeliveryIdentifier { get; set; }

        [JsonProperty("actorId")]
        public string ActorId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("recipientField")]
        public string RecipientField { get; set; }
    }

    public class GetMessageHistoryForAThreadResponseResultsTypeItemRecipientsTypeItemDeliveryIdentifierType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetMessageHistoryForAThreadResponseResultsTypeItemSendersTypeItem
    {
        [JsonProperty("actorId")]
        public string ActorId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("senderField")]
        public string SenderField { get; set; }

        [JsonProperty("deliveryIdentifier")]
        public GetMessageHistoryForAThreadResponseResultsTypeItemSendersTypeItemDeliveryIdentifierType DeliveryIdentifier { get; set; }
    }

    public class GetMessageHistoryForAThreadResponseResultsTypeItemSendersTypeItemDeliveryIdentifierType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetMessageHistoryForAThreadResponseResultsTypeItemStatusType
    {
        [JsonProperty("statusType")]
        public string StatusType { get; set; }

        [JsonProperty("failureDetails")]
        public GetMessageHistoryForAThreadResponseResultsTypeItemStatusTypeFailureDetailsType FailureDetails { get; set; }
    }

    public class GetMessageHistoryForAThreadResponseResultsTypeItemStatusTypeFailureDetailsType
    {
        [JsonProperty("errorMessageTokens")]
        public JToken ErrorMessageTokens { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

    public class GetMessageHistoryForAThreadResponsePagingType
    {
        [JsonProperty("next")]
        public GetMessageHistoryForAThreadResponsePagingTypeNextType Next { get; set; }
    }

    public class GetMessageHistoryForAThreadResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetChannelAccountsResponse
    {
        [JsonProperty("results")]
        public GetChannelAccountsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public GetChannelAccountsResponsePagingType Paging { get; set; }
    }

    public class GetChannelAccountsResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("channelId")]
        public string ChannelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("inboxId")]
        public string InboxId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("authorized")]
        public bool Authorized { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deliveryIdentifier")]
        public GetChannelAccountsResponseResultsTypeItemDeliveryIdentifierType DeliveryIdentifier { get; set; }
    }

    public class GetChannelAccountsResponseResultsTypeItemDeliveryIdentifierType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetChannelAccountsResponsePagingType
    {
        [JsonProperty("next")]
        public GetChannelAccountsResponsePagingTypeNextType Next { get; set; }
    }

    public class GetChannelAccountsResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetASingleChannelResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetASingleMessageResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetChannelsResponse
    {
        [JsonProperty("results")]
        public GetChannelsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public GetChannelsResponsePagingType Paging { get; set; }
    }

    public class GetChannelsResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetChannelsResponsePagingType
    {
        [JsonProperty("next")]
        public GetChannelsResponsePagingTypeNextType Next { get; set; }
    }

    public class GetChannelsResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetASingleActorResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    public class GetThreadsResponse
    {
        [JsonProperty("results")]
        public GetThreadsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public GetThreadsResponsePagingType Paging { get; set; }
    }

    public class GetThreadsResponseResultsTypeItem
    {
        [JsonProperty("associatedContactId")]
        public string AssociatedContactId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("inboxId")]
        public string InboxId { get; set; }

        [JsonProperty("spam")]
        public bool Spam { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("closedAt")]
        public string ClosedAt { get; set; }

        [JsonProperty("latestMessageTimestamp")]
        public string LatestMessageTimestamp { get; set; }

        [JsonProperty("latestMessageSentTimestamp")]
        public string LatestMessageSentTimestamp { get; set; }

        [JsonProperty("latestMessageReceivedTimestamp")]
        public string LatestMessageReceivedTimestamp { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }
    }

    public class GetThreadsResponsePagingType
    {
        [JsonProperty("next")]
        public GetThreadsResponsePagingTypeNextType Next { get; set; }
    }

    public class GetThreadsResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetASingleChannelAccountResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("channelId")]
        public string ChannelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("inboxId")]
        public string InboxId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("authorized")]
        public bool Authorized { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deliveryIdentifier")]
        public GetASingleChannelAccountResponseDeliveryIdentifierType DeliveryIdentifier { get; set; }
    }

    public class GetASingleChannelAccountResponseDeliveryIdentifierType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetASingleConversationsInboxResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotconversations;

    public partial class WorkflowManagedActions
    {
        public HubspotconversationsActions Hubspotconversations(string connectionId) => new HubspotconversationsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HubspotconversationsTriggers Hubspotconversations(string connectionId) => new HubspotconversationsTriggers(connectionId);
    }
}