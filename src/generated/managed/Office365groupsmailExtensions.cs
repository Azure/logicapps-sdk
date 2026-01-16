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
        public IBodyWorkflowAction<CreateConversationResponse> CreateConversation(Expression<Func<string>> groupId, Expression<Func<string>> bodynewTopic, Expression<Func<string>> bodypostbodycontent, Expression<Func<string[]>> bodypostpostCategories = null, Expression<Func<GetUsersGraphAction[]>> bodypostnewParticipants = null, Expression<Func<ClientSendAttachment[]>> bodypostfileAttachments = null)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/conversations", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<Conversation> GetGroupConversation(Expression<Func<string>> groupId, Expression<Func<string>> conversationId)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/conversations/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(conversationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Conversation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<ListConversationThreadsResponse> ListConversationThreads(Expression<Func<string>> groupId, Expression<Func<string>> conversationId)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/conversations/{1}/threads", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(conversationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListConversationThreadsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<NewConversationThreadResponse> CreateConversationThread(Expression<Func<string>> groupId, Expression<Func<string>> conversationId, Expression<Func<string>> bodynewTopic, Expression<Func<string>> bodypostbodycontent, Expression<Func<string[]>> bodypostpostCategories = null, Expression<Func<GetUsersGraphAction[]>> bodypostnewParticipants = null, Expression<Func<ClientSendAttachment[]>> bodypostfileAttachments = null)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/conversations/{1}/threads", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(conversationId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<ListGroupThreadsResponse> ListGroupThreads(Expression<Func<string>> groupId)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/threads", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListGroupThreadsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<NewConversationThreadResponse> CreateGroupThread(Expression<Func<string>> groupId, Expression<Func<string>> bodynewTopic, Expression<Func<string>> bodypostbodycontent, Expression<Func<string[]>> bodypostpostCategories = null, Expression<Func<GetUsersGraphAction[]>> bodypostnewParticipants = null, Expression<Func<ClientSendAttachment[]>> bodypostfileAttachments = null)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/threads", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<ConversationThread> GetConversationThread(Expression<Func<string>> groupId, Expression<Func<string>> threadId)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/threads/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConversationThread>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IWorkflowAction DeleteConversationThread(Expression<Func<string>> groupId, Expression<Func<string>> threadId)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/threads/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<ListThreadPostsResponse> ListThreadPosts(Expression<Func<string>> groupId, Expression<Func<string>> threadId)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/threads/{1}/posts", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListThreadPostsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<Post> GetThreadPost(Expression<Func<string>> groupId, Expression<Func<string>> threadId, Expression<Func<string>> postId)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/threads/{1}/posts/{2}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$expand"] = Convert.ToString("attachments");
            return new ApiConnectionAction<Post>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<GetAttachmentsResponse> GetAttachments(Expression<Func<string>> groupId, Expression<Func<string>> threadId, Expression<Func<string>> postId)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/threads/{1}/posts/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAttachmentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IWorkflowAction ReplyToAThread(Expression<Func<string>> groupId, Expression<Func<string>> threadId, Expression<Func<string>> bodypostbodycontent, Expression<Func<string[]>> bodypostpostCategories = null, Expression<Func<GetUsersGraphAction[]>> bodypostnewParticipants = null, Expression<Func<ClientSendAttachment[]>> bodypostfileAttachments = null)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/threads/{1}/reply", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IWorkflowAction ReplyPost(Expression<Func<string>> groupId, Expression<Func<string>> threadId, Expression<Func<string>> postId, Expression<Func<string>> bodypostbodycontent, Expression<Func<string[]>> bodypostpostCategories = null, Expression<Func<GetUsersGraphAction[]>> bodypostnewParticipants = null, Expression<Func<ClientSendAttachment[]>> bodypostfileAttachments = null)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/threads/{1}/posts/{2}/reply", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IWorkflowAction ForwardPostV2(Expression<Func<string>> groupMail, Expression<Func<string>> conversationId, Expression<Func<string>> threadId, Expression<Func<string>> postId, Expression<Func<GetUsersGraphAction[]>> bodyrecipients, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/beta/groups/{0}/conversations/{1}/threads/{2}/posts/{3}/forward", ExpressionConverter.ConvertWithUrlEncoding(groupMail, 1), ExpressionConverter.ConvertWithUrlEncoding(conversationId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groupsmail")]
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
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
        }
    }

    public class Office365groupsmailTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<OnNewEmailInGroupResponse> OnNewEmailInGroup(Expression<Func<string>> groupId)
        {
            var apiCallPath = String.Format("/trigger/v1.0/groups/{0}/conversations", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$select"] = Convert.ToString("id,lastDeliveredDateTime");
            callPayload.Queries["$expand"] = Convert.ToString("threads($select=id;$expand=posts($select=id,createdDateTime))");
            callPayload.Queries["$orderby"] = Convert.ToString("lastDeliveredDateTime desc");
            return new ApiConnectionTrigger<OnNewEmailInGroupResponse>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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