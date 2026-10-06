//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotconversations
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotconversationsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetConversationsInboxes))]
        public IBodyWorkflowAction<GetConversationsInboxesResponse> GetConversationsInboxes([WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> defaultPageLength = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetConversationsInboxesResponse> __BuildGetConversationsInboxes(WorkflowExpression<string> after = null, WorkflowExpression<string> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> defaultPageLength = null)
        {
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(defaultPageLength, nameof(defaultPageLength), required: false);
            return new DeferredBodyAction<GetConversationsInboxesResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/conversations/inboxes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (defaultPageLength != null)
                    callPayload.Queries["defaultPageLength"] = ExpressionConverter.Convert(defaultPageLength);
                return new ApiConnectionAction<GetConversationsInboxesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetASingleThread))]
        public IBodyWorkflowAction<GetASingleThreadResponse> GetASingleThread([WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetASingleThreadResponse> __BuildGetASingleThread(WorkflowExpression<string> threadId, WorkflowExpression<bool> archived = null, WorkflowExpression<string> property = null)
        {
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(property, nameof(property), required: false);
            return new DeferredBodyAction<GetASingleThreadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(property);
                return new ApiConnectionAction<GetASingleThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildArchivesAThread))]
        public IBodyWorkflowAction<string> ArchivesAThread([WorkflowExpression] Func<string> threadId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchivesAThread(WorkflowExpression<string> threadId)
        {
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateAThread))]
        public IBodyWorkflowAction<UpdateAThreadResponse> UpdateAThread([WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodyarchived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateAThreadResponse> __BuildUpdateAThread(WorkflowExpression<string> threadId, WorkflowExpression<bool> archived = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bool> bodyarchived = null)
        {
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyarchived, nameof(bodyarchived), required: false);
            return new DeferredBodyAction<UpdateAThreadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyarchived != null)
                {
                    body["archived"] = ExpressionConverter.ConvertO(bodyarchived);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateAThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetTheOriginalContentOfASingleMessage))]
        public IBodyWorkflowAction<GetTheOriginalContentOfASingleMessageResponse> GetTheOriginalContentOfASingleMessage([WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> property = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTheOriginalContentOfASingleMessageResponse> __BuildGetTheOriginalContentOfASingleMessage(WorkflowExpression<string> threadId, WorkflowExpression<string> messageId, WorkflowExpression<string> property = null)
        {
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(property, nameof(property), required: false);
            return new DeferredBodyAction<GetTheOriginalContentOfASingleMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}/messages/{1}/original-content", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(property);
                return new ApiConnectionAction<GetTheOriginalContentOfASingleMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessageHistoryForAThread))]
        public IBodyWorkflowAction<GetMessageHistoryForAThreadResponse> GetMessageHistoryForAThread([WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMessageHistoryForAThreadResponse> __BuildGetMessageHistoryForAThread(WorkflowExpression<string> threadId, WorkflowExpression<string> after = null, WorkflowExpression<string> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> property = null)
        {
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(property, nameof(property), required: false);
            return new DeferredBodyAction<GetMessageHistoryForAThreadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(property);
                return new ApiConnectionAction<GetMessageHistoryForAThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetChannelAccounts))]
        public IBodyWorkflowAction<GetChannelAccountsResponse> GetChannelAccounts([WorkflowExpression] Func<string> channelId = null, [WorkflowExpression] Func<string> inboxId = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> defaultPageLength = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetChannelAccountsResponse> __BuildGetChannelAccounts(WorkflowExpression<string> channelId = null, WorkflowExpression<string> inboxId = null, WorkflowExpression<string> after = null, WorkflowExpression<string> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> defaultPageLength = null)
        {
            WorkflowExpression.Validate(channelId, nameof(channelId), required: false);
            WorkflowExpression.Validate(inboxId, nameof(inboxId), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(defaultPageLength, nameof(defaultPageLength), required: false);
            return new DeferredBodyAction<GetChannelAccountsResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/conversations/channel-accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (channelId != null)
                    callPayload.Queries["channelId"] = ExpressionConverter.Convert(channelId);
                if (inboxId != null)
                    callPayload.Queries["inboxId"] = ExpressionConverter.Convert(inboxId);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (defaultPageLength != null)
                    callPayload.Queries["defaultPageLength"] = ExpressionConverter.Convert(defaultPageLength);
                return new ApiConnectionAction<GetChannelAccountsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetASingleChannel))]
        public IBodyWorkflowAction<GetASingleChannelResponse> GetASingleChannel([WorkflowExpression] Func<string> channelId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetASingleChannelResponse> __BuildGetASingleChannel(WorkflowExpression<string> channelId)
        {
            WorkflowExpression.Validate(channelId, nameof(channelId), required: true);
            return new DeferredBodyAction<GetASingleChannelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/channels/{0}", ExpressionConverter.ConvertWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetASingleChannelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetASingleMessage))]
        public IBodyWorkflowAction<GetASingleMessageResponse> GetASingleMessage([WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> property = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetASingleMessageResponse> __BuildGetASingleMessage(WorkflowExpression<string> threadId, WorkflowExpression<string> messageId, WorkflowExpression<string> property = null)
        {
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(property, nameof(property), required: false);
            return new DeferredBodyAction<GetASingleMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/threads/{0}/messages/{1}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(property);
                return new ApiConnectionAction<GetASingleMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetChannels))]
        public IBodyWorkflowAction<GetChannelsResponse> GetChannels([WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> defaultPageLength = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetChannelsResponse> __BuildGetChannels(WorkflowExpression<string> after = null, WorkflowExpression<string> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> defaultPageLength = null)
        {
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(defaultPageLength, nameof(defaultPageLength), required: false);
            return new DeferredBodyAction<GetChannelsResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/conversations/channels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (defaultPageLength != null)
                    callPayload.Queries["defaultPageLength"] = ExpressionConverter.Convert(defaultPageLength);
                return new ApiConnectionAction<GetChannelsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetASingleActor))]
        public IBodyWorkflowAction<GetASingleActorResponse> GetASingleActor([WorkflowExpression] Func<string> actorId, [WorkflowExpression] Func<string> property = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetASingleActorResponse> __BuildGetASingleActor(WorkflowExpression<string> actorId, WorkflowExpression<string> property = null)
        {
            WorkflowExpression.Validate(actorId, nameof(actorId), required: true);
            WorkflowExpression.Validate(property, nameof(property), required: false);
            return new DeferredBodyAction<GetASingleActorResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/actors/{0}", ExpressionConverter.ConvertWithUrlEncoding(actorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(property);
                return new ApiConnectionAction<GetASingleActorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetThreads))]
        public IBodyWorkflowAction<GetThreadsResponse> GetThreads([WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> inboxId = null, [WorkflowExpression] Func<string> associatedContactId = null, [WorkflowExpression] Func<string> threadStatus = null, [WorkflowExpression] Func<string> latestMessageTimestampAfter = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetThreadsResponse> __BuildGetThreads(WorkflowExpression<string> after = null, WorkflowExpression<string> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> inboxId = null, WorkflowExpression<string> associatedContactId = null, WorkflowExpression<string> threadStatus = null, WorkflowExpression<string> latestMessageTimestampAfter = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> property = null)
        {
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(inboxId, nameof(inboxId), required: false);
            WorkflowExpression.Validate(associatedContactId, nameof(associatedContactId), required: false);
            WorkflowExpression.Validate(threadStatus, nameof(threadStatus), required: false);
            WorkflowExpression.Validate(latestMessageTimestampAfter, nameof(latestMessageTimestampAfter), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(property, nameof(property), required: false);
            return new DeferredBodyAction<GetThreadsResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/conversations/threads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (inboxId != null)
                    callPayload.Queries["inboxId"] = ExpressionConverter.Convert(inboxId);
                if (associatedContactId != null)
                    callPayload.Queries["associatedContactId"] = ExpressionConverter.Convert(associatedContactId);
                if (threadStatus != null)
                    callPayload.Queries["threadStatus"] = ExpressionConverter.Convert(threadStatus);
                if (latestMessageTimestampAfter != null)
                    callPayload.Queries["latestMessageTimestampAfter"] = ExpressionConverter.Convert(latestMessageTimestampAfter);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(property);
                return new ApiConnectionAction<GetThreadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetASingleChannelAccount))]
        public IBodyWorkflowAction<GetASingleChannelAccountResponse> GetASingleChannelAccount([WorkflowExpression] Func<string> channelAccountId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetASingleChannelAccountResponse> __BuildGetASingleChannelAccount(WorkflowExpression<string> channelAccountId)
        {
            WorkflowExpression.Validate(channelAccountId, nameof(channelAccountId), required: true);
            return new DeferredBodyAction<GetASingleChannelAccountResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/channel-accounts/{0}", ExpressionConverter.ConvertWithUrlEncoding(channelAccountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetASingleChannelAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [WorkflowExpressionFactory(nameof(__BuildGetASingleConversationsInbox))]
        public IBodyWorkflowAction<GetASingleConversationsInboxResponse> GetASingleConversationsInbox([WorkflowExpression] Func<string> inboxId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotconversations")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetASingleConversationsInboxResponse> __BuildGetASingleConversationsInbox(WorkflowExpression<string> inboxId)
        {
            WorkflowExpression.Validate(inboxId, nameof(inboxId), required: true);
            return new DeferredBodyAction<GetASingleConversationsInboxResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/conversations/inboxes/{0}", ExpressionConverter.ConvertWithUrlEncoding(inboxId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetASingleConversationsInboxResponse>(callPayload);
            });
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