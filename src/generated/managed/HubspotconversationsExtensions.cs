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
        public IBodyWorkflowAction<GetConversationsInboxesResponse> GetConversationsInboxes(Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> defaultPageLength = null)
        {
            var apiCallPath = "/conversations/v3/conversations/inboxes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (defaultPageLength != null)
                callPayload.Queries["defaultPageLength"] = CSharpExpressionConverter.ConvertO(defaultPageLength);
            return new ApiConnectionAction<GetConversationsInboxesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleThreadResponse> GetASingleThread(Expression<Func<string>> threadId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (property != null)
                callPayload.Queries["property"] = CSharpExpressionConverter.ConvertO(property);
            return new ApiConnectionAction<GetASingleThreadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<string> ArchivesAThread(Expression<Func<string>> threadId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<UpdateAThreadResponse> UpdateAThread(Expression<Func<string>> threadId, Expression<Func<bool>> archived = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodyarchived = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyarchived != null)
            {
                body["archived"] = CSharpExpressionConverter.ConvertToken(bodyarchived);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateAThreadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetTheOriginalContentOfASingleMessageResponse> GetTheOriginalContentOfASingleMessage(Expression<Func<string>> threadId, Expression<Func<string>> messageId, Expression<Func<string>> property = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}/messages/{1}/original-content", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (property != null)
                callPayload.Queries["property"] = CSharpExpressionConverter.ConvertO(property);
            return new ApiConnectionAction<GetTheOriginalContentOfASingleMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetMessageHistoryForAThreadResponse> GetMessageHistoryForAThread(Expression<Func<string>> threadId, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> sort = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}/messages", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (property != null)
                callPayload.Queries["property"] = CSharpExpressionConverter.ConvertO(property);
            return new ApiConnectionAction<GetMessageHistoryForAThreadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetChannelAccountsResponse> GetChannelAccounts(Expression<Func<string>> channelId = null, Expression<Func<string>> inboxId = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> defaultPageLength = null)
        {
            var apiCallPath = "/conversations/v3/conversations/channel-accounts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (channelId != null)
                callPayload.Queries["channelId"] = CSharpExpressionConverter.ConvertO(channelId);
            if (inboxId != null)
                callPayload.Queries["inboxId"] = CSharpExpressionConverter.ConvertO(inboxId);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (defaultPageLength != null)
                callPayload.Queries["defaultPageLength"] = CSharpExpressionConverter.ConvertO(defaultPageLength);
            return new ApiConnectionAction<GetChannelAccountsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleChannelResponse> GetASingleChannel(Expression<Func<string>> channelId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/channels/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetASingleChannelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleMessageResponse> GetASingleMessage(Expression<Func<string>> threadId, Expression<Func<string>> messageId, Expression<Func<string>> property = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}/messages/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (property != null)
                callPayload.Queries["property"] = CSharpExpressionConverter.ConvertO(property);
            return new ApiConnectionAction<GetASingleMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetChannelsResponse> GetChannels(Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> defaultPageLength = null)
        {
            var apiCallPath = "/conversations/v3/conversations/channels";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (defaultPageLength != null)
                callPayload.Queries["defaultPageLength"] = CSharpExpressionConverter.ConvertO(defaultPageLength);
            return new ApiConnectionAction<GetChannelsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleActorResponse> GetASingleActor(Expression<Func<string>> actorId, Expression<Func<string>> property = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/actors/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(actorId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (property != null)
                callPayload.Queries["property"] = CSharpExpressionConverter.ConvertO(property);
            return new ApiConnectionAction<GetASingleActorResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetThreadsResponse> GetThreads(Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> inboxId = null, Expression<Func<string>> associatedContactId = null, Expression<Func<string>> threadStatus = null, Expression<Func<string>> latestMessageTimestampAfter = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = "/conversations/v3/conversations/threads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (inboxId != null)
                callPayload.Queries["inboxId"] = CSharpExpressionConverter.ConvertO(inboxId);
            if (associatedContactId != null)
                callPayload.Queries["associatedContactId"] = CSharpExpressionConverter.ConvertO(associatedContactId);
            if (threadStatus != null)
                callPayload.Queries["threadStatus"] = CSharpExpressionConverter.ConvertO(threadStatus);
            if (latestMessageTimestampAfter != null)
                callPayload.Queries["latestMessageTimestampAfter"] = CSharpExpressionConverter.ConvertO(latestMessageTimestampAfter);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (property != null)
                callPayload.Queries["property"] = CSharpExpressionConverter.ConvertO(property);
            return new ApiConnectionAction<GetThreadsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleChannelAccountResponse> GetASingleChannelAccount(Expression<Func<string>> channelAccountId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/channel-accounts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelAccountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetASingleChannelAccountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        public IBodyWorkflowAction<GetASingleConversationsInboxResponse> GetASingleConversationsInbox(Expression<Func<string>> inboxId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/inboxes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(inboxId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetASingleConversationsInboxResponse>(callPayload);
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