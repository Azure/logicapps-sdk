//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365groupsmail
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Office365groupsmailActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConversation))]
        public IBodyWorkflowAction<CreateConversationResponse> CreateConversation([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodynewTopic, [WorkflowExpression] Func<string> bodypostbodycontent, [WorkflowExpression] Func<string[]> bodypostpostCategories = null, [WorkflowExpression] Func<GetUsersGraphAction[]> bodypostnewParticipants = null, [WorkflowExpression] Func<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateConversationResponse> __BuildCreateConversation(WorkflowExpression<string> groupId, WorkflowExpression<string> bodynewTopic, WorkflowExpression<string> bodypostbodycontent, WorkflowExpression<string[]> bodypostpostCategories = null, WorkflowExpression<GetUsersGraphAction[]> bodypostnewParticipants = null, WorkflowExpression<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(bodynewTopic, nameof(bodynewTopic), required: true);
            WorkflowExpression.Validate(bodypostbodycontent, nameof(bodypostbodycontent), required: true);
            WorkflowExpression.Validate(bodypostpostCategories, nameof(bodypostpostCategories), required: false);
            WorkflowExpression.Validate(bodypostnewParticipants, nameof(bodypostnewParticipants), required: false);
            WorkflowExpression.Validate(bodypostfileAttachments, nameof(bodypostfileAttachments), required: false);
            return new DeferredBodyAction<CreateConversationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/conversations", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topic"] = ExpressionConverter.ConvertO(bodynewTopic);
                var postObject = new JObject();
                var postObjectpropCount = 0;
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObjectpropCount++;
                bodyObject["content"] = ExpressionConverter.ConvertO(bodypostbodycontent);
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    postObject["body"] = bodyObject;
                    postObjectpropCount++;
                }

                if (bodypostpostCategories != null)
                {
                    postObject["categories"] = ExpressionConverter.ConvertO(bodypostpostCategories);
                    postObjectpropCount++;
                }

                if (bodypostnewParticipants != null)
                {
                    postObject["newParticipants"] = ExpressionConverter.ConvertO(bodypostnewParticipants);
                    postObjectpropCount++;
                }

                if (bodypostfileAttachments != null)
                {
                    postObject["attachments"] = ExpressionConverter.ConvertO(bodypostfileAttachments);
                    postObjectpropCount++;
                }

                if (postObjectpropCount > 0)
                {
                    body["post"] = postObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildGetGroupConversation))]
        public IBodyWorkflowAction<Conversation> GetGroupConversation([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> conversationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Conversation> __BuildGetGroupConversation(WorkflowExpression<string> groupId, WorkflowExpression<string> conversationId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(conversationId, nameof(conversationId), required: true);
            return new DeferredBodyAction<Conversation>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/conversations/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(conversationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Conversation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildListConversationThreads))]
        public IBodyWorkflowAction<ListConversationThreadsResponse> ListConversationThreads([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> conversationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListConversationThreadsResponse> __BuildListConversationThreads(WorkflowExpression<string> groupId, WorkflowExpression<string> conversationId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(conversationId, nameof(conversationId), required: true);
            return new DeferredBodyAction<ListConversationThreadsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/conversations/{1}/threads", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(conversationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListConversationThreadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConversationThread))]
        public IBodyWorkflowAction<NewConversationThreadResponse> CreateConversationThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> conversationId, [WorkflowExpression] Func<string> bodynewTopic, [WorkflowExpression] Func<string> bodypostbodycontent, [WorkflowExpression] Func<string[]> bodypostpostCategories = null, [WorkflowExpression] Func<GetUsersGraphAction[]> bodypostnewParticipants = null, [WorkflowExpression] Func<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewConversationThreadResponse> __BuildCreateConversationThread(WorkflowExpression<string> groupId, WorkflowExpression<string> conversationId, WorkflowExpression<string> bodynewTopic, WorkflowExpression<string> bodypostbodycontent, WorkflowExpression<string[]> bodypostpostCategories = null, WorkflowExpression<GetUsersGraphAction[]> bodypostnewParticipants = null, WorkflowExpression<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(conversationId, nameof(conversationId), required: true);
            WorkflowExpression.Validate(bodynewTopic, nameof(bodynewTopic), required: true);
            WorkflowExpression.Validate(bodypostbodycontent, nameof(bodypostbodycontent), required: true);
            WorkflowExpression.Validate(bodypostpostCategories, nameof(bodypostpostCategories), required: false);
            WorkflowExpression.Validate(bodypostnewParticipants, nameof(bodypostnewParticipants), required: false);
            WorkflowExpression.Validate(bodypostfileAttachments, nameof(bodypostfileAttachments), required: false);
            return new DeferredBodyAction<NewConversationThreadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/conversations/{1}/threads", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(conversationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topic"] = ExpressionConverter.ConvertO(bodynewTopic);
                var postObject = new JObject();
                var postObjectpropCount = 0;
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObjectpropCount++;
                bodyObject["content"] = ExpressionConverter.ConvertO(bodypostbodycontent);
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    postObject["body"] = bodyObject;
                    postObjectpropCount++;
                }

                if (bodypostpostCategories != null)
                {
                    postObject["categories"] = ExpressionConverter.ConvertO(bodypostpostCategories);
                    postObjectpropCount++;
                }

                if (bodypostnewParticipants != null)
                {
                    postObject["newParticipants"] = ExpressionConverter.ConvertO(bodypostnewParticipants);
                    postObjectpropCount++;
                }

                if (bodypostfileAttachments != null)
                {
                    postObject["attachments"] = ExpressionConverter.ConvertO(bodypostfileAttachments);
                    postObjectpropCount++;
                }

                if (postObjectpropCount > 0)
                {
                    body["post"] = postObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NewConversationThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildListGroupThreads))]
        public IBodyWorkflowAction<ListGroupThreadsResponse> ListGroupThreads([WorkflowExpression] Func<string> groupId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListGroupThreadsResponse> __BuildListGroupThreads(WorkflowExpression<string> groupId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<ListGroupThreadsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListGroupThreadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildCreateGroupThread))]
        public IBodyWorkflowAction<NewConversationThreadResponse> CreateGroupThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodynewTopic, [WorkflowExpression] Func<string> bodypostbodycontent, [WorkflowExpression] Func<string[]> bodypostpostCategories = null, [WorkflowExpression] Func<GetUsersGraphAction[]> bodypostnewParticipants = null, [WorkflowExpression] Func<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewConversationThreadResponse> __BuildCreateGroupThread(WorkflowExpression<string> groupId, WorkflowExpression<string> bodynewTopic, WorkflowExpression<string> bodypostbodycontent, WorkflowExpression<string[]> bodypostpostCategories = null, WorkflowExpression<GetUsersGraphAction[]> bodypostnewParticipants = null, WorkflowExpression<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(bodynewTopic, nameof(bodynewTopic), required: true);
            WorkflowExpression.Validate(bodypostbodycontent, nameof(bodypostbodycontent), required: true);
            WorkflowExpression.Validate(bodypostpostCategories, nameof(bodypostpostCategories), required: false);
            WorkflowExpression.Validate(bodypostnewParticipants, nameof(bodypostnewParticipants), required: false);
            WorkflowExpression.Validate(bodypostfileAttachments, nameof(bodypostfileAttachments), required: false);
            return new DeferredBodyAction<NewConversationThreadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topic"] = ExpressionConverter.ConvertO(bodynewTopic);
                var postObject = new JObject();
                var postObjectpropCount = 0;
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObjectpropCount++;
                bodyObject["content"] = ExpressionConverter.ConvertO(bodypostbodycontent);
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    postObject["body"] = bodyObject;
                    postObjectpropCount++;
                }

                if (bodypostpostCategories != null)
                {
                    postObject["categories"] = ExpressionConverter.ConvertO(bodypostpostCategories);
                    postObjectpropCount++;
                }

                if (bodypostnewParticipants != null)
                {
                    postObject["newParticipants"] = ExpressionConverter.ConvertO(bodypostnewParticipants);
                    postObjectpropCount++;
                }

                if (bodypostfileAttachments != null)
                {
                    postObject["attachments"] = ExpressionConverter.ConvertO(bodypostfileAttachments);
                    postObjectpropCount++;
                }

                if (postObjectpropCount > 0)
                {
                    body["post"] = postObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NewConversationThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildGetConversationThread))]
        public IBodyWorkflowAction<ConversationThread> GetConversationThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConversationThread> __BuildGetConversationThread(WorkflowExpression<string> groupId, WorkflowExpression<string> threadId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ConversationThread>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConversationThread>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConversationThread))]
        public IWorkflowAction DeleteConversationThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConversationThread(WorkflowExpression<string> groupId, WorkflowExpression<string> threadId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildListThreadPosts))]
        public IBodyWorkflowAction<ListThreadPostsResponse> ListThreadPosts([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListThreadPostsResponse> __BuildListThreadPosts(WorkflowExpression<string> groupId, WorkflowExpression<string> threadId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ListThreadPostsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}/posts", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListThreadPostsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildGetThread))]
        public IBodyWorkflowAction<Post> GetThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> postId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Post> __BuildGetThread(WorkflowExpression<string> groupId, WorkflowExpression<string> threadId, WorkflowExpression<string> postId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(postId, nameof(postId), required: true);
            return new DeferredBodyAction<Post>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}/posts/{2}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("attachments");
                return new ApiConnectionAction<Post>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildGetAttachments))]
        public IBodyWorkflowAction<GetAttachmentsResponse> GetAttachments([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> postId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAttachmentsResponse> __BuildGetAttachments(WorkflowExpression<string> groupId, WorkflowExpression<string> threadId, WorkflowExpression<string> postId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(postId, nameof(postId), required: true);
            return new DeferredBodyAction<GetAttachmentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}/posts/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAttachmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildReplyToAThread))]
        public IWorkflowAction ReplyToAThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> bodypostbodycontent, [WorkflowExpression] Func<string[]> bodypostpostCategories = null, [WorkflowExpression] Func<GetUsersGraphAction[]> bodypostnewParticipants = null, [WorkflowExpression] Func<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReplyToAThread(WorkflowExpression<string> groupId, WorkflowExpression<string> threadId, WorkflowExpression<string> bodypostbodycontent, WorkflowExpression<string[]> bodypostpostCategories = null, WorkflowExpression<GetUsersGraphAction[]> bodypostnewParticipants = null, WorkflowExpression<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(bodypostbodycontent, nameof(bodypostbodycontent), required: true);
            WorkflowExpression.Validate(bodypostpostCategories, nameof(bodypostpostCategories), required: false);
            WorkflowExpression.Validate(bodypostnewParticipants, nameof(bodypostnewParticipants), required: false);
            WorkflowExpression.Validate(bodypostfileAttachments, nameof(bodypostfileAttachments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}/reply", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var postObject = new JObject();
                var postObjectpropCount = 0;
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObjectpropCount++;
                bodyObject["content"] = ExpressionConverter.ConvertO(bodypostbodycontent);
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    postObject["body"] = bodyObject;
                    postObjectpropCount++;
                }

                if (bodypostpostCategories != null)
                {
                    postObject["categories"] = ExpressionConverter.ConvertO(bodypostpostCategories);
                    postObjectpropCount++;
                }

                if (bodypostnewParticipants != null)
                {
                    postObject["newParticipants"] = ExpressionConverter.ConvertO(bodypostnewParticipants);
                    postObjectpropCount++;
                }

                if (bodypostfileAttachments != null)
                {
                    postObject["attachments"] = ExpressionConverter.ConvertO(bodypostfileAttachments);
                    postObjectpropCount++;
                }

                if (postObjectpropCount > 0)
                {
                    body["post"] = postObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildReply))]
        public IWorkflowAction Reply([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> postId, [WorkflowExpression] Func<string> bodypostbodycontent, [WorkflowExpression] Func<string[]> bodypostpostCategories = null, [WorkflowExpression] Func<GetUsersGraphAction[]> bodypostnewParticipants = null, [WorkflowExpression] Func<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReply(WorkflowExpression<string> groupId, WorkflowExpression<string> threadId, WorkflowExpression<string> postId, WorkflowExpression<string> bodypostbodycontent, WorkflowExpression<string[]> bodypostpostCategories = null, WorkflowExpression<GetUsersGraphAction[]> bodypostnewParticipants = null, WorkflowExpression<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(postId, nameof(postId), required: true);
            WorkflowExpression.Validate(bodypostbodycontent, nameof(bodypostbodycontent), required: true);
            WorkflowExpression.Validate(bodypostpostCategories, nameof(bodypostpostCategories), required: false);
            WorkflowExpression.Validate(bodypostnewParticipants, nameof(bodypostnewParticipants), required: false);
            WorkflowExpression.Validate(bodypostfileAttachments, nameof(bodypostfileAttachments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}/posts/{2}/reply", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var postObject = new JObject();
                var postObjectpropCount = 0;
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObjectpropCount++;
                bodyObject["content"] = ExpressionConverter.ConvertO(bodypostbodycontent);
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    postObject["body"] = bodyObject;
                    postObjectpropCount++;
                }

                if (bodypostpostCategories != null)
                {
                    postObject["categories"] = ExpressionConverter.ConvertO(bodypostpostCategories);
                    postObjectpropCount++;
                }

                if (bodypostnewParticipants != null)
                {
                    postObject["newParticipants"] = ExpressionConverter.ConvertO(bodypostnewParticipants);
                    postObjectpropCount++;
                }

                if (bodypostfileAttachments != null)
                {
                    postObject["attachments"] = ExpressionConverter.ConvertO(bodypostfileAttachments);
                    postObjectpropCount++;
                }

                if (postObjectpropCount > 0)
                {
                    body["post"] = postObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildHttpRequest))]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> customHeader1 = null, [WorkflowExpression] Func<string> customHeader2 = null, [WorkflowExpression] Func<string> customHeader3 = null, [WorkflowExpression] Func<string> customHeader4 = null, [WorkflowExpression] Func<string> customHeader5 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildHttpRequest(WorkflowExpression<string> uri, WorkflowExpression<methodInput> method, WorkflowExpression<string> body = null, WorkflowExpression<string> contentType = null, WorkflowExpression<string> customHeader1 = null, WorkflowExpression<string> customHeader2 = null, WorkflowExpression<string> customHeader3 = null, WorkflowExpression<string> customHeader4 = null, WorkflowExpression<string> customHeader5 = null)
        {
            WorkflowExpression.Validate(uri, nameof(uri), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(customHeader1, nameof(customHeader1), required: false);
            WorkflowExpression.Validate(customHeader2, nameof(customHeader2), required: false);
            WorkflowExpression.Validate(customHeader3, nameof(customHeader3), required: false);
            WorkflowExpression.Validate(customHeader4, nameof(customHeader4), required: false);
            WorkflowExpression.Validate(customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = ExpressionConverter.Convert(uri);
                callPayload.Headers["Method"] = ExpressionConverter.Convert(method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["ContentType"] = ExpressionConverter.Convert(contentType);
                if (customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(customHeader1);
                if (customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(customHeader2);
                if (customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(customHeader3);
                if (customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(customHeader4);
                if (customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(customHeader5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        [WorkflowExpressionFactory(nameof(__BuildForward))]
        public IWorkflowAction Forward([WorkflowExpression] Func<string> groupMail, [WorkflowExpression] Func<string> conversationId, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> postId, [WorkflowExpression] Func<GetUsersGraphAction[]> bodyrecipients, [WorkflowExpression] Func<string> bodycomment = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildForward(WorkflowExpression<string> groupMail, WorkflowExpression<string> conversationId, WorkflowExpression<string> threadId, WorkflowExpression<string> postId, WorkflowExpression<GetUsersGraphAction[]> bodyrecipients, WorkflowExpression<string> bodycomment = null)
        {
            WorkflowExpression.Validate(groupMail, nameof(groupMail), required: true);
            WorkflowExpression.Validate(conversationId, nameof(conversationId), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(postId, nameof(postId), required: true);
            WorkflowExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: true);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/groups/{0}/conversations/{1}/threads/{2}/posts/{3}/forward", ExpressionConverter.ConvertWithUrlEncoding(groupMail, 1), ExpressionConverter.ConvertWithUrlEncoding(conversationId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Prefer"] = Convert.ToString("exchange.behavior=\"ForwardPostWithMessage\"");
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["Comment"] = ExpressionConverter.ConvertO(bodycomment);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ToRecipients"] = ExpressionConverter.ConvertO(bodyrecipients);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Office365groupsmailTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewEmailInGroup))]
        public IBodyWorkflowTrigger<OnNewEmailInGroupResponse> OnNewEmailInGroup([WorkflowExpression] Func<string> groupId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnNewEmailInGroupResponse> __BuildOnNewEmailInGroup(WorkflowExpression<string> groupId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnNewEmailInGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/v1.0/groups/{0}/conversations", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$select"] = Convert.ToString("id,lastDeliveredDateTime");
                callPayload.Queries["$expand"] = Convert.ToString("threads($select=id;$expand=posts($select=id,createdDateTime))");
                callPayload.Queries["$orderby"] = Convert.ToString("lastDeliveredDateTime desc");
                return new ApiConnectionTrigger<OnNewEmailInGroupResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateConversationResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string ConversationID { get; set; }

        [JsonProperty("threads@odata.context")]
        public string ThreadsOdataContext { get; set; }

        [JsonProperty("threads")]
        public CreateConversationResponseConversationThreadsTypeItem[] ConversationThreads { get; set; }
    }

    public class CreateConversationResponseConversationThreadsTypeItem
    {
        [JsonProperty("id")]
        public string ThreadID { get; set; }
    }

    public class GetUsersGraphAction
    {
        public GetUsersGraphActionEmailAddressType EmailAddress { get; set; }
    }

    public class GetUsersGraphActionEmailAddressType
    {
        public string Address { get; set; }
    }

    public class ClientSendAttachment
    {
        [JsonProperty("@odata.type")]
        public string FileAttachmentOdataType { get; set; }

        [JsonProperty("Name")]
        public string AttachmentName { get; set; }

        [JsonProperty("ContentBytes")]
        public string AttachmentContent { get; set; }
    }

    public class Conversation
    {
        [JsonProperty("id")]
        public string ConversationID { get; set; }

        [JsonProperty("topic")]
        public string ConversationTopic { get; set; }

        [JsonProperty("hasAttachments")]
        public bool HasAttachments { get; set; }

        [JsonProperty("lastDeliveredDateTime")]
        public string LastDeliveredTimestamp { get; set; }

        [JsonProperty("uniqueSenders")]
        public string[] UniqueSendersArray { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }

        [JsonProperty("threads")]
        public ConversationThread[] Threads { get; set; }
    }

    public class ConversationThread
    {
        [JsonProperty("id")]
        public string ConversationThreadID { get; set; }

        [JsonProperty("topic")]
        public string ConversationTopic { get; set; }

        [JsonProperty("hasAttachments")]
        public bool HasAttachments { get; set; }

        [JsonProperty("lastDeliveredDateTime")]
        public string LastDeliveredTimestamp { get; set; }

        [JsonProperty("uniqueSenders")]
        public string[] UniqueSendersArray { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }

        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }

        [JsonProperty("toRecipients")]
        public EmailAddressInfo[] ToRecipients { get; set; }

        [JsonProperty("ccRecipients")]
        public EmailAddressInfo[] CcRecipients { get; set; }

        [JsonProperty("posts")]
        public Post[] Posts { get; set; }
    }

    public class EmailAddressInfo
    {
        [JsonProperty("emailAddress")]
        public EmailAddressEmailAddressType EmailAddress { get; set; }
    }

    public class EmailAddressEmailAddressType
    {
        [JsonProperty("name")]
        public string NameOfTheUser { get; set; }

        [JsonProperty("address")]
        public string EmailAddressOfTheUser { get; set; }
    }

    public class Post
    {
        [JsonProperty("id")]
        public string PostID { get; set; }

        [JsonProperty("createdDateTime")]
        public string PostCreatedTimestamp { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string PostLastModifiedTimestamp { get; set; }

        [JsonProperty("changeKey")]
        public string PostChangeKey { get; set; }

        [JsonProperty("conversationId")]
        public string PostConversationID { get; set; }

        [JsonProperty("conversationThreadId")]
        public string PostConversationThreadID { get; set; }

        [JsonProperty("categories")]
        public string[] PostCategories { get; set; }

        [JsonProperty("receivedDateTime")]
        public string PostReceivedTimestamp { get; set; }

        [JsonProperty("hasAttachments")]
        public bool HasAttachments { get; set; }

        [JsonProperty("newParticipants")]
        public EmailAddressInfo[] NewParticipants { get; set; }

        [JsonProperty("body")]
        public ItemBody Body { get; set; }

        [JsonProperty("from")]
        public EmailAddressInfo From { get; set; }

        [JsonProperty("sender")]
        public EmailAddressInfo Sender { get; set; }

        [JsonProperty("attachments")]
        public Attachment[] Attachments { get; set; }
    }

    public class ItemBody
    {
        [JsonProperty("contentType")]
        public string BodyContentType { get; set; }

        [JsonProperty("content")]
        public string BodyContent { get; set; }
    }

    public class Attachment
    {
        [JsonProperty("id")]
        public string AttachmentID { get; set; }

        [JsonProperty("name")]
        public string AttachmentName { get; set; }

        [JsonProperty("contentType")]
        public string AttachmentContentType { get; set; }

        [JsonProperty("size")]
        public int AttachmentSize { get; set; }

        [JsonProperty("contentBytes")]
        public string AttachmentContentBytes { get; set; }
    }

    public class ListConversationThreadsResponse
    {
        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("@odata.context")]
        public string ODataContext { get; set; }

        [JsonProperty("value")]
        public ConversationThread[] Value { get; set; }
    }

    public class NewConversationThreadResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string ConversationThreadID { get; set; }
    }

    public class ListGroupThreadsResponse
    {
        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public ConversationThread[] Value { get; set; }
    }

    public class ListThreadPostsResponse
    {
        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public Post[] Value { get; set; }
    }

    public class GetAttachmentsResponse
    {
        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public Attachment[] Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum methodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public class OnNewEmailInGroupResponse
    {
        [JsonProperty("value")]
        public ConversationTriggerResponse[] Value { get; set; }
    }

    public class ConversationTriggerResponse
    {
        [JsonProperty("id")]
        public string ConversationID { get; set; }

        [JsonProperty("lastDeliveredDateTime")]
        public string LastDeliveredTimestamp { get; set; }

        [JsonProperty("threads")]
        public ConversationThreadTriggerResponse[] Threads { get; set; }
    }

    public class ConversationThreadTriggerResponse
    {
        [JsonProperty("id")]
        public string ConversationThreadID { get; set; }

        [JsonProperty("posts")]
        public PostTriggerResponse[] Posts { get; set; }
    }

    public class PostTriggerResponse
    {
        [JsonProperty("id")]
        public string PostID { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string PostLastModifiedTimestamp { get; set; }

        [JsonProperty("changeKey")]
        public string PostChangeKey { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365groupsmail;

    public partial class WorkflowManagedActions
    {
        public Office365groupsmailActions Office365groupsmail(string connectionId) => new Office365groupsmailActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Office365groupsmailTriggers Office365groupsmail(string connectionId) => new Office365groupsmailTriggers(connectionId);
    }
}