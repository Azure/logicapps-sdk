//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365groupsmail
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Office365groupsmailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<CreateConversationResponse> CreateConversation([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodynewTopic, [WorkflowExpression] Func<string> bodypostbodycontent, [WorkflowExpression] Func<string[]> bodypostpostCategories = null, [WorkflowExpression] Func<GetUsersGraphAction[]> bodypostnewParticipants = null, [WorkflowExpression] Func<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(bodynewTopic, nameof(bodynewTopic), required: true);
            SourceExpression.Validate(bodypostbodycontent, nameof(bodypostbodycontent), required: true);
            SourceExpression.Validate(bodypostpostCategories, nameof(bodypostpostCategories), required: false);
            SourceExpression.Validate(bodypostnewParticipants, nameof(bodypostnewParticipants), required: false);
            SourceExpression.Validate(bodypostfileAttachments, nameof(bodypostfileAttachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/conversations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topic"] = SourceExpressionConverter.ConvertToken(bodynewTopic);
                var postObject = new JObject();
                var postObjectpropCount = 0;
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObjectpropCount++;
                bodyObject["content"] = SourceExpressionConverter.ConvertToken(bodypostbodycontent);
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    postObject["body"] = bodyObject;
                    postObjectpropCount++;
                }

                if (bodypostpostCategories != null)
                {
                    postObject["categories"] = SourceExpressionConverter.ConvertToken(bodypostpostCategories);
                    postObjectpropCount++;
                }

                if (bodypostnewParticipants != null)
                {
                    postObject["newParticipants"] = SourceExpressionConverter.ConvertToken(bodypostnewParticipants);
                    postObjectpropCount++;
                }

                if (bodypostfileAttachments != null)
                {
                    postObject["attachments"] = SourceExpressionConverter.ConvertToken(bodypostfileAttachments);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateConversationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<Conversation> GetGroupConversation([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> conversationId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(conversationId, nameof(conversationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/conversations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(conversationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Conversation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<ListConversationThreadsResponse> ListConversationThreads([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> conversationId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(conversationId, nameof(conversationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/conversations/{1}/threads", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(conversationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListConversationThreadsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<NewConversationThreadResponse> CreateConversationThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> conversationId, [WorkflowExpression] Func<string> bodynewTopic, [WorkflowExpression] Func<string> bodypostbodycontent, [WorkflowExpression] Func<string[]> bodypostpostCategories = null, [WorkflowExpression] Func<GetUsersGraphAction[]> bodypostnewParticipants = null, [WorkflowExpression] Func<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(conversationId, nameof(conversationId), required: true);
            SourceExpression.Validate(bodynewTopic, nameof(bodynewTopic), required: true);
            SourceExpression.Validate(bodypostbodycontent, nameof(bodypostbodycontent), required: true);
            SourceExpression.Validate(bodypostpostCategories, nameof(bodypostpostCategories), required: false);
            SourceExpression.Validate(bodypostnewParticipants, nameof(bodypostnewParticipants), required: false);
            SourceExpression.Validate(bodypostfileAttachments, nameof(bodypostfileAttachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/conversations/{1}/threads", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(conversationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topic"] = SourceExpressionConverter.ConvertToken(bodynewTopic);
                var postObject = new JObject();
                var postObjectpropCount = 0;
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObjectpropCount++;
                bodyObject["content"] = SourceExpressionConverter.ConvertToken(bodypostbodycontent);
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    postObject["body"] = bodyObject;
                    postObjectpropCount++;
                }

                if (bodypostpostCategories != null)
                {
                    postObject["categories"] = SourceExpressionConverter.ConvertToken(bodypostpostCategories);
                    postObjectpropCount++;
                }

                if (bodypostnewParticipants != null)
                {
                    postObject["newParticipants"] = SourceExpressionConverter.ConvertToken(bodypostnewParticipants);
                    postObjectpropCount++;
                }

                if (bodypostfileAttachments != null)
                {
                    postObject["attachments"] = SourceExpressionConverter.ConvertToken(bodypostfileAttachments);
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
                return callPayload;
            }

            return new ApiConnectionAction<NewConversationThreadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<ListGroupThreadsResponse> ListGroupThreads([WorkflowExpression] Func<string> groupId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListGroupThreadsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<NewConversationThreadResponse> CreateGroupThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodynewTopic, [WorkflowExpression] Func<string> bodypostbodycontent, [WorkflowExpression] Func<string[]> bodypostpostCategories = null, [WorkflowExpression] Func<GetUsersGraphAction[]> bodypostnewParticipants = null, [WorkflowExpression] Func<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(bodynewTopic, nameof(bodynewTopic), required: true);
            SourceExpression.Validate(bodypostbodycontent, nameof(bodypostbodycontent), required: true);
            SourceExpression.Validate(bodypostpostCategories, nameof(bodypostpostCategories), required: false);
            SourceExpression.Validate(bodypostnewParticipants, nameof(bodypostnewParticipants), required: false);
            SourceExpression.Validate(bodypostfileAttachments, nameof(bodypostfileAttachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topic"] = SourceExpressionConverter.ConvertToken(bodynewTopic);
                var postObject = new JObject();
                var postObjectpropCount = 0;
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObjectpropCount++;
                bodyObject["content"] = SourceExpressionConverter.ConvertToken(bodypostbodycontent);
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    postObject["body"] = bodyObject;
                    postObjectpropCount++;
                }

                if (bodypostpostCategories != null)
                {
                    postObject["categories"] = SourceExpressionConverter.ConvertToken(bodypostpostCategories);
                    postObjectpropCount++;
                }

                if (bodypostnewParticipants != null)
                {
                    postObject["newParticipants"] = SourceExpressionConverter.ConvertToken(bodypostnewParticipants);
                    postObjectpropCount++;
                }

                if (bodypostfileAttachments != null)
                {
                    postObject["attachments"] = SourceExpressionConverter.ConvertToken(bodypostfileAttachments);
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
                return callPayload;
            }

            return new ApiConnectionAction<NewConversationThreadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<ConversationThread> GetConversationThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConversationThread>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IWorkflowAction DeleteConversationThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<ListThreadPostsResponse> ListThreadPosts([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}/posts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListThreadPostsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<Post> GetThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> postId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(postId, nameof(postId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}/posts/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("attachments");
                return callPayload;
            }

            return new ApiConnectionAction<Post>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<GetAttachmentsResponse> GetAttachments([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> postId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(postId, nameof(postId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}/posts/{2}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAttachmentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IWorkflowAction ReplyToAThread([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> bodypostbodycontent, [WorkflowExpression] Func<string[]> bodypostpostCategories = null, [WorkflowExpression] Func<GetUsersGraphAction[]> bodypostnewParticipants = null, [WorkflowExpression] Func<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(bodypostbodycontent, nameof(bodypostbodycontent), required: true);
            SourceExpression.Validate(bodypostpostCategories, nameof(bodypostpostCategories), required: false);
            SourceExpression.Validate(bodypostnewParticipants, nameof(bodypostnewParticipants), required: false);
            SourceExpression.Validate(bodypostfileAttachments, nameof(bodypostfileAttachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}/reply", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
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
                bodyObject["content"] = SourceExpressionConverter.ConvertToken(bodypostbodycontent);
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    postObject["body"] = bodyObject;
                    postObjectpropCount++;
                }

                if (bodypostpostCategories != null)
                {
                    postObject["categories"] = SourceExpressionConverter.ConvertToken(bodypostpostCategories);
                    postObjectpropCount++;
                }

                if (bodypostnewParticipants != null)
                {
                    postObject["newParticipants"] = SourceExpressionConverter.ConvertToken(bodypostnewParticipants);
                    postObjectpropCount++;
                }

                if (bodypostfileAttachments != null)
                {
                    postObject["attachments"] = SourceExpressionConverter.ConvertToken(bodypostfileAttachments);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IWorkflowAction Reply([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> postId, [WorkflowExpression] Func<string> bodypostbodycontent, [WorkflowExpression] Func<string[]> bodypostpostCategories = null, [WorkflowExpression] Func<GetUsersGraphAction[]> bodypostnewParticipants = null, [WorkflowExpression] Func<ClientSendAttachment[]> bodypostfileAttachments = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(postId, nameof(postId), required: true);
            SourceExpression.Validate(bodypostbodycontent, nameof(bodypostbodycontent), required: true);
            SourceExpression.Validate(bodypostpostCategories, nameof(bodypostpostCategories), required: false);
            SourceExpression.Validate(bodypostnewParticipants, nameof(bodypostnewParticipants), required: false);
            SourceExpression.Validate(bodypostfileAttachments, nameof(bodypostfileAttachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/threads/{1}/posts/{2}/reply", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
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
                bodyObject["content"] = SourceExpressionConverter.ConvertToken(bodypostbodycontent);
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    postObject["body"] = bodyObject;
                    postObjectpropCount++;
                }

                if (bodypostpostCategories != null)
                {
                    postObject["categories"] = SourceExpressionConverter.ConvertToken(bodypostpostCategories);
                    postObjectpropCount++;
                }

                if (bodypostnewParticipants != null)
                {
                    postObject["newParticipants"] = SourceExpressionConverter.ConvertToken(bodypostnewParticipants);
                    postObjectpropCount++;
                }

                if (bodypostfileAttachments != null)
                {
                    postObject["attachments"] = SourceExpressionConverter.ConvertToken(bodypostfileAttachments);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> customHeader1 = null, [WorkflowExpression] Func<string> customHeader2 = null, [WorkflowExpression] Func<string> customHeader3 = null, [WorkflowExpression] Func<string> customHeader4 = null, [WorkflowExpression] Func<string> customHeader5 = null)
        {
            SourceExpression.Validate(uri, nameof(uri), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(customHeader1, nameof(customHeader1), required: false);
            SourceExpression.Validate(customHeader2, nameof(customHeader2), required: false);
            SourceExpression.Validate(customHeader3, nameof(customHeader3), required: false);
            SourceExpression.Validate(customHeader4, nameof(customHeader4), required: false);
            SourceExpression.Validate(customHeader5, nameof(customHeader5), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = SourceExpressionConverter.ConvertO(uri);
                callPayload.Headers["Method"] = SourceExpressionConverter.Convert(method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["ContentType"] = SourceExpressionConverter.ConvertO(contentType);
                if (customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = SourceExpressionConverter.ConvertO(customHeader1);
                if (customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = SourceExpressionConverter.ConvertO(customHeader2);
                if (customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = SourceExpressionConverter.ConvertO(customHeader3);
                if (customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = SourceExpressionConverter.ConvertO(customHeader4);
                if (customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = SourceExpressionConverter.ConvertO(customHeader5);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IWorkflowAction Forward([WorkflowExpression] Func<string> groupMail, [WorkflowExpression] Func<string> conversationId, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> postId, [WorkflowExpression] Func<GetUsersGraphAction[]> bodyrecipients, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(groupMail, nameof(groupMail), required: true);
            SourceExpression.Validate(conversationId, nameof(conversationId), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(postId, nameof(postId), required: true);
            SourceExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/groups/{0}/conversations/{1}/threads/{2}/posts/{3}/forward", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupMail, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(conversationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Prefer"] = Convert.ToString("exchange.behavior=\"ForwardPostWithMessage\"");
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ToRecipients"] = SourceExpressionConverter.ConvertToken(bodyrecipients);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class Office365groupsmailTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnNewEmailInGroupResponse> OnNewEmailInGroup([WorkflowExpression] Func<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/v1.0/groups/{0}/conversations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$select"] = Convert.ToString("id,lastDeliveredDateTime");
                callPayload.Queries["$expand"] = Convert.ToString("threads($select=id;$expand=posts($select=id,createdDateTime))");
                callPayload.Queries["$orderby"] = Convert.ToString("lastDeliveredDateTime desc");
                return callPayload;
            }

            return new ApiConnectionTrigger<OnNewEmailInGroupResponse>(BuildSourceInput, triggerName, recurrence);
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