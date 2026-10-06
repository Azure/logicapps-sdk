//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Disqus
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DisqusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<CreatePostResponse> Create([WorkflowExpression] Func<string> thread, [WorkflowExpression] Func<string> message)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/posts/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = SourceExpressionConverter.ConvertO(thread);
                callPayload.Queries["message"] = SourceExpressionConverter.ConvertO(message);
                return callPayload;
            }

            return new ApiConnectionAction<CreatePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<CreatePostResponse> ReplyTo([WorkflowExpression] Func<string> parent, [WorkflowExpression] Func<string> message)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reply/posts/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["parent"] = SourceExpressionConverter.ConvertO(parent);
                callPayload.Queries["message"] = SourceExpressionConverter.ConvertO(message);
                return callPayload;
            }

            return new ApiConnectionAction<CreatePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<OperationResultResponse> Remove([WorkflowExpression] Func<string> post)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/posts/remove.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["post"] = SourceExpressionConverter.ConvertO(post);
                return callPayload;
            }

            return new ApiConnectionAction<OperationResultResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<Forum[]> GetFollowedForums()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/listFollowingForums.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["order"] = Convert.ToString("desc");
                callPayload.Queries["limit"] = Convert.ToString(100);
                return callPayload;
            }

            return new ApiConnectionAction<Forum[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<EmptyResponse> SubscribeToThread([WorkflowExpression] Func<string> thread)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threads/subscribe.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = SourceExpressionConverter.ConvertO(thread);
                return callPayload;
            }

            return new ApiConnectionAction<EmptyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<OperationResultResponse> OpenThread([WorkflowExpression] Func<string> thread)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threads/open.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = SourceExpressionConverter.ConvertO(thread);
                return callPayload;
            }

            return new ApiConnectionAction<OperationResultResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<OperationResultResponse> CloseThread([WorkflowExpression] Func<string> thread)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threads/close.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = SourceExpressionConverter.ConvertO(thread);
                return callPayload;
            }

            return new ApiConnectionAction<OperationResultResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<RecommendThreadResponse> RecommendThread([WorkflowExpression] Func<string> thread)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threads/vote.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = SourceExpressionConverter.ConvertO(thread);
                callPayload.Queries["vote"] = Convert.ToString("1");
                return callPayload;
            }

            return new ApiConnectionAction<RecommendThreadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<GetThreadResponse> GetThread([WorkflowExpression] Func<string> thread)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threads/details.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["thread"] = SourceExpressionConverter.ConvertO(thread);
                return callPayload;
            }

            return new ApiConnectionAction<GetThreadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "disqus")]
        public IBodyWorkflowAction<Thread[]> GetForumThreads([WorkflowExpression] Func<string> forum)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/forums/listThreads.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["forum"] = SourceExpressionConverter.ConvertO(forum);
                callPayload.Queries["order"] = Convert.ToString("desc");
                callPayload.Queries["limit"] = Convert.ToString(100);
                return callPayload;
            }

            return new ApiConnectionAction<Thread[]>(BuildSourceInput);
        }
    }

    public class DisqusTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Post[]> OnPostCreated([WorkflowExpression] Func<string> forum, [WorkflowExpression] Func<string> thread = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/posts/list.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["forum"] = SourceExpressionConverter.ConvertO(forum);
                if (thread != null)
                    callPayload.Queries["thread"] = SourceExpressionConverter.ConvertO(thread);
                callPayload.Queries["order"] = Convert.ToString("desc");
                callPayload.Queries["limit"] = Convert.ToString(75);
                return callPayload;
            }

            return new ApiConnectionTrigger<Post[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Thread[]> OnThreadCreated([WorkflowExpression] Func<string> forum, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threads/list.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["forum"] = SourceExpressionConverter.ConvertO(forum);
                callPayload.Queries["order"] = Convert.ToString("desc");
                callPayload.Queries["limit"] = Convert.ToString(75);
                return callPayload;
            }

            return new ApiConnectionTrigger<Thread[]>(BuildSourceInput, triggerName, recurrence);
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