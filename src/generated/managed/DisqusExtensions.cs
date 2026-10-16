//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Disqus
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DisqusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<CreatePostResponse> Create(Expression<Func<string>> thread, Expression<Func<string>> message)
        {
            var __workflow_thread = WorkflowExpression.Compile(thread, nameof(thread), required: true);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            return new DeferredBodyAction<CreatePostResponse>(() =>
            {
                var apiCallPath = "/posts/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(__workflow_thread);
                callPayload.Queries["message"] = ExpressionConverter.Convert(__workflow_message);
                return new ApiConnectionAction<CreatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<CreatePostResponse> ReplyTo(Expression<Func<string>> parent, Expression<Func<string>> message)
        {
            var __workflow_parent = WorkflowExpression.Compile(parent, nameof(parent), required: true);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            return new DeferredBodyAction<CreatePostResponse>(() =>
            {
                var apiCallPath = "/reply/posts/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["parent"] = ExpressionConverter.Convert(__workflow_parent);
                callPayload.Queries["message"] = ExpressionConverter.Convert(__workflow_message);
                return new ApiConnectionAction<CreatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<OperationResultResponse> Remove(Expression<Func<string>> post)
        {
            var __workflow_post = WorkflowExpression.Compile(post, nameof(post), required: true);
            return new DeferredBodyAction<OperationResultResponse>(() =>
            {
                var apiCallPath = "/posts/remove.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["post"] = ExpressionConverter.Convert(__workflow_post);
                return new ApiConnectionAction<OperationResultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<Forum[]> GetFollowedForums()
        {
            var apiCallPath = "/users/listFollowingForums.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["order"] = Convert.ToString("desc");
            callPayload.Queries["limit"] = Convert.ToString(100);
            return new ApiConnectionAction<Forum[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<EmptyResponse> SubscribeToThread(Expression<Func<string>> thread)
        {
            var __workflow_thread = WorkflowExpression.Compile(thread, nameof(thread), required: true);
            return new DeferredBodyAction<EmptyResponse>(() =>
            {
                var apiCallPath = "/threads/subscribe.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(__workflow_thread);
                return new ApiConnectionAction<EmptyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<OperationResultResponse> OpenThread(Expression<Func<string>> thread)
        {
            var __workflow_thread = WorkflowExpression.Compile(thread, nameof(thread), required: true);
            return new DeferredBodyAction<OperationResultResponse>(() =>
            {
                var apiCallPath = "/threads/open.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(__workflow_thread);
                return new ApiConnectionAction<OperationResultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<OperationResultResponse> CloseThread(Expression<Func<string>> thread)
        {
            var __workflow_thread = WorkflowExpression.Compile(thread, nameof(thread), required: true);
            return new DeferredBodyAction<OperationResultResponse>(() =>
            {
                var apiCallPath = "/threads/close.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(__workflow_thread);
                return new ApiConnectionAction<OperationResultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<RecommendThreadResponse> RecommendThread(Expression<Func<string>> thread)
        {
            var __workflow_thread = WorkflowExpression.Compile(thread, nameof(thread), required: true);
            return new DeferredBodyAction<RecommendThreadResponse>(() =>
            {
                var apiCallPath = "/threads/vote.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(__workflow_thread);
                callPayload.Queries["vote"] = Convert.ToString("1");
                return new ApiConnectionAction<RecommendThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<GetThreadResponse> GetThread(Expression<Func<string>> thread)
        {
            var __workflow_thread = WorkflowExpression.Compile(thread, nameof(thread), required: true);
            return new DeferredBodyAction<GetThreadResponse>(() =>
            {
                var apiCallPath = "/threads/details.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(__workflow_thread);
                return new ApiConnectionAction<GetThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<Thread[]> GetForumThreads(Expression<Func<string>> forum)
        {
            var __workflow_forum = WorkflowExpression.Compile(forum, nameof(forum), required: true);
            return new DeferredBodyAction<Thread[]>(() =>
            {
                var apiCallPath = "/forums/listThreads.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["forum"] = ExpressionConverter.Convert(__workflow_forum);
                callPayload.Queries["order"] = Convert.ToString("desc");
                callPayload.Queries["limit"] = Convert.ToString(100);
                return new ApiConnectionAction<Thread[]>(callPayload);
            });
        }
    }

    public class DisqusTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Post[]> OnPostCreated(Expression<Func<string>> forum, Expression<Func<string>> thread = null, FlowRecurrence recurrence = null)
        {
            var __workflow_forum = WorkflowExpression.Compile(forum, nameof(forum), required: true);
            var __workflow_thread = WorkflowExpression.Compile(thread, nameof(thread), required: false);
            return new DeferredBodyTrigger<Post[]>(() =>
            {
                var apiCallPath = "/posts/list.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["forum"] = ExpressionConverter.Convert(__workflow_forum);
                if (__workflow_thread != null)
                    callPayload.Queries["thread"] = ExpressionConverter.Convert(__workflow_thread);
                callPayload.Queries["order"] = Convert.ToString("desc");
                callPayload.Queries["limit"] = Convert.ToString(75);
                return new ApiConnectionTrigger<Post[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Thread[]> OnThreadCreated(Expression<Func<string>> forum, FlowRecurrence recurrence = null)
        {
            var __workflow_forum = WorkflowExpression.Compile(forum, nameof(forum), required: true);
            return new DeferredBodyTrigger<Thread[]>(() =>
            {
                var apiCallPath = "/threads/list.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["forum"] = ExpressionConverter.Convert(__workflow_forum);
                callPayload.Queries["order"] = Convert.ToString("desc");
                callPayload.Queries["limit"] = Convert.ToString(75);
                return new ApiConnectionTrigger<Thread[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreatePostResponse
    {
        [JsonProperty("response")]
        public Post Response { get; set; }
    }

    public class Post
    {
        [JsonProperty("dislikes")]
        public int Dislikes { get; set; }

        [JsonProperty("thread")]
        public string DiscussionId { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("message")]
        public string HTMLMessage { get; set; }

        [JsonProperty("id")]
        public string CommentId { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("isSpam")]
        public bool IsSpam { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("parent")]
        public int ParentCommentId { get; set; }

        [JsonProperty("isApproved")]
        public bool IsApproved { get; set; }

        [JsonProperty("isFlagged")]
        public bool IsFlagged { get; set; }

        [JsonProperty("raw_message")]
        public string Message { get; set; }

        [JsonProperty("isHighlighted")]
        public bool IsFeatured { get; set; }

        [JsonProperty("forum")]
        public string ChannelId { get; set; }

        [JsonProperty("isEdited")]
        public bool IsEdited { get; set; }
    }

    public class Author
    {
        [JsonProperty("id")]
        public string AuthorId { get; set; }

        [JsonProperty("joinedAt")]
        public string AuthorJoinDate { get; set; }

        [JsonProperty("isVerified")]
        public bool IsVerifiedAuthor { get; set; }

        [JsonProperty("username")]
        public string AuthorUsername { get; set; }

        [JsonProperty("about")]
        public string AboutTheAuthor { get; set; }

        [JsonProperty("name")]
        public string AuthorName { get; set; }

        [JsonProperty("profileUrl")]
        public string AuthorProfileURL { get; set; }

        [JsonProperty("isAnonymous")]
        public bool IsAnonymousAuthor { get; set; }
    }

    public class OperationResultResponse
    {
        [JsonProperty("response")]
        public OperationResultResponseResponseTypeItem[] Response { get; set; }
    }

    public class OperationResultResponseResponseTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Forum
    {
        [JsonProperty("description")]
        public string HTMLDescription { get; set; }

        [JsonProperty("url")]
        public string ChannelURL { get; set; }

        [JsonProperty("raw_description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("daysAlive")]
        public int DaysAlive { get; set; }

        [JsonProperty("id")]
        public string ChannelId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("name")]
        public string ChannelName { get; set; }
    }

    public class EmptyResponse
    {
        [JsonProperty("response")]
        public JToken Response { get; set; }
    }

    public class RecommendThreadResponse
    {
        [JsonProperty("response")]
        public RecommendThreadResponseResponseType Response { get; set; }
    }

    public class RecommendThreadResponseResponseType
    {
        [JsonProperty("thread")]
        public Thread Thread { get; set; }

        [JsonProperty("vote")]
        public int Vote { get; set; }
    }

    public class Thread
    {
        [JsonProperty("feed")]
        public string RSSFeed { get; set; }

        [JsonProperty("dislikes")]
        public int Dislikes { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("message")]
        public string HTMLMessage { get; set; }

        [JsonProperty("id")]
        public string DiscussionId { get; set; }

        [JsonProperty("author")]
        public string AuthorId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("raw_message")]
        public string Message { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("forum")]
        public string ChannelId { get; set; }

        [JsonProperty("clean_title")]
        public string CleanTitle { get; set; }

        [JsonProperty("posts")]
        public int NumberOfComments { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetThreadResponse
    {
        [JsonProperty("response")]
        public Thread Response { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Disqus;

    public partial class WorkflowManagedActions
    {
        public DisqusActions Disqus(string connectionId) => new DisqusActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DisqusTriggers Disqus(string connectionId) => new DisqusTriggers(connectionId);
    }
}
