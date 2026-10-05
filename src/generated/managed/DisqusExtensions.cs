//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Disqus
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DisqusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        [WorkflowExpressionFactory(nameof(__BuildCreate))]
        public IBodyWorkflowAction<CreatePostResponse> Create([WorkflowExpression] Func<string> thread, [WorkflowExpression] Func<string> message)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePostResponse> __BuildCreate(WorkflowValue<string> thread, WorkflowValue<string> message)
        {
            WorkflowValue.Validate(thread, nameof(thread), required: true);
            WorkflowValue.Validate(message, nameof(message), required: true);
            return new DeferredBodyAction<CreatePostResponse>(() =>
            {
                var apiCallPath = "/posts/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(thread);
                callPayload.Queries["message"] = ExpressionConverter.Convert(message);
                return new ApiConnectionAction<CreatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        [WorkflowExpressionFactory(nameof(__BuildReplyTo))]
        public IBodyWorkflowAction<CreatePostResponse> ReplyTo([WorkflowExpression] Func<string> parent, [WorkflowExpression] Func<string> message)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePostResponse> __BuildReplyTo(WorkflowValue<string> parent, WorkflowValue<string> message)
        {
            WorkflowValue.Validate(parent, nameof(parent), required: true);
            WorkflowValue.Validate(message, nameof(message), required: true);
            return new DeferredBodyAction<CreatePostResponse>(() =>
            {
                var apiCallPath = "/reply/posts/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["parent"] = ExpressionConverter.Convert(parent);
                callPayload.Queries["message"] = ExpressionConverter.Convert(message);
                return new ApiConnectionAction<CreatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        [WorkflowExpressionFactory(nameof(__BuildRemove))]
        public IBodyWorkflowAction<OperationResultResponse> Remove([WorkflowExpression] Func<string> post)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResultResponse> __BuildRemove(WorkflowValue<string> post)
        {
            WorkflowValue.Validate(post, nameof(post), required: true);
            return new DeferredBodyAction<OperationResultResponse>(() =>
            {
                var apiCallPath = "/posts/remove.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["post"] = ExpressionConverter.Convert(post);
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
        [WorkflowExpressionFactory(nameof(__BuildSubscribeToThread))]
        public IBodyWorkflowAction<EmptyResponse> SubscribeToThread([WorkflowExpression] Func<string> thread)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmptyResponse> __BuildSubscribeToThread(WorkflowValue<string> thread)
        {
            WorkflowValue.Validate(thread, nameof(thread), required: true);
            return new DeferredBodyAction<EmptyResponse>(() =>
            {
                var apiCallPath = "/threads/subscribe.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(thread);
                return new ApiConnectionAction<EmptyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        [WorkflowExpressionFactory(nameof(__BuildOpenThread))]
        public IBodyWorkflowAction<OperationResultResponse> OpenThread([WorkflowExpression] Func<string> thread)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResultResponse> __BuildOpenThread(WorkflowValue<string> thread)
        {
            WorkflowValue.Validate(thread, nameof(thread), required: true);
            return new DeferredBodyAction<OperationResultResponse>(() =>
            {
                var apiCallPath = "/threads/open.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(thread);
                return new ApiConnectionAction<OperationResultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        [WorkflowExpressionFactory(nameof(__BuildCloseThread))]
        public IBodyWorkflowAction<OperationResultResponse> CloseThread([WorkflowExpression] Func<string> thread)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResultResponse> __BuildCloseThread(WorkflowValue<string> thread)
        {
            WorkflowValue.Validate(thread, nameof(thread), required: true);
            return new DeferredBodyAction<OperationResultResponse>(() =>
            {
                var apiCallPath = "/threads/close.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(thread);
                return new ApiConnectionAction<OperationResultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        [WorkflowExpressionFactory(nameof(__BuildRecommendThread))]
        public IBodyWorkflowAction<RecommendThreadResponse> RecommendThread([WorkflowExpression] Func<string> thread)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecommendThreadResponse> __BuildRecommendThread(WorkflowValue<string> thread)
        {
            WorkflowValue.Validate(thread, nameof(thread), required: true);
            return new DeferredBodyAction<RecommendThreadResponse>(() =>
            {
                var apiCallPath = "/threads/vote.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(thread);
                callPayload.Queries["vote"] = Convert.ToString("1");
                return new ApiConnectionAction<RecommendThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        [WorkflowExpressionFactory(nameof(__BuildGetThread))]
        public IBodyWorkflowAction<GetThreadResponse> GetThread([WorkflowExpression] Func<string> thread)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetThreadResponse> __BuildGetThread(WorkflowValue<string> thread)
        {
            WorkflowValue.Validate(thread, nameof(thread), required: true);
            return new DeferredBodyAction<GetThreadResponse>(() =>
            {
                var apiCallPath = "/threads/details.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = ExpressionConverter.Convert(thread);
                return new ApiConnectionAction<GetThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        [WorkflowExpressionFactory(nameof(__BuildGetForumThreads))]
        public IBodyWorkflowAction<Thread[]> GetForumThreads([WorkflowExpression] Func<string> forum)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Thread[]> __BuildGetForumThreads(WorkflowValue<string> forum)
        {
            WorkflowValue.Validate(forum, nameof(forum), required: true);
            return new DeferredBodyAction<Thread[]>(() =>
            {
                var apiCallPath = "/forums/listThreads.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["forum"] = ExpressionConverter.Convert(forum);
                callPayload.Queries["order"] = Convert.ToString("desc");
                callPayload.Queries["limit"] = Convert.ToString(100);
                return new ApiConnectionAction<Thread[]>(callPayload);
            });
        }
    }

    public class DisqusTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnPostCreated))]
        public IBodyWorkflowTrigger<Post[]> OnPostCreated([WorkflowExpression] Func<string> forum, [WorkflowExpression] Func<string> thread = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<Post[]> __BuildOnPostCreated(WorkflowValue<string> forum, WorkflowValue<string> thread = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(forum, nameof(forum), required: true);
            WorkflowValue.Validate(thread, nameof(thread), required: false);
            return new DeferredBodyTrigger<Post[]>(() =>
            {
                var apiCallPath = "/posts/list.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["forum"] = ExpressionConverter.Convert(forum);
                if (thread != null)
                    callPayload.Queries["thread"] = ExpressionConverter.Convert(thread);
                callPayload.Queries["order"] = Convert.ToString("desc");
                callPayload.Queries["limit"] = Convert.ToString(75);
                return new ApiConnectionTrigger<Post[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnThreadCreated))]
        public IBodyWorkflowTrigger<Thread[]> OnThreadCreated([WorkflowExpression] Func<string> forum, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<Thread[]> __BuildOnThreadCreated(WorkflowValue<string> forum, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(forum, nameof(forum), required: true);
            return new DeferredBodyTrigger<Thread[]>(() =>
            {
                var apiCallPath = "/threads/list.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["forum"] = ExpressionConverter.Convert(forum);
                callPayload.Queries["order"] = Convert.ToString("desc");
                callPayload.Queries["limit"] = Convert.ToString(75);
                return new ApiConnectionTrigger<Thread[]>(callPayload, triggerName, recurrence);
            }, triggerName);
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
