//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Letterdrop
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LetterdropActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<SubscriberPostResponse, ApiConnectionActionConfiguration> Subscriber(Expression<Func<SubscriberPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SubscriberPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscriber/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubscriberPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<SubscriberRemovePostResponse, ApiConnectionActionConfiguration> SubscriberRemove(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<SubscriberRemovePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscriber/remove";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction<SubscriberRemovePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostsGetPostResponse, ApiConnectionActionConfiguration> PostsGet(Expression<Func<PostsGetPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostsGetPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostsGetPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostGetPostResponse, ApiConnectionActionConfiguration> PostGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PostGetPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/post/get/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PostGetPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostDraftPostResponse, ApiConnectionActionConfiguration> PostDraft(Expression<Func<PostDraftPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostDraftPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/post/draft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostDraftPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<ProjectGetPostResponse, ApiConnectionActionConfiguration> ProjectGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ProjectGetPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/project/get/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectGetPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<IdeaCreatePostResponse, ApiConnectionActionConfiguration> IdeaCreate(Expression<Func<IdeaCreatePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IdeaCreatePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/idea/new";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IdeaCreatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<IdeaAssignPostResponse, ApiConnectionActionConfiguration> IdeaAssign(Expression<Func<IdeaAssignPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IdeaAssignPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/idea/assign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IdeaAssignPostResponse>(callPayload);
            });
        }
    }

    public class LetterdropTriggers([ConnectionName] string connectionId)
    {
    }

    public class SubscriberPostResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("publication")]
        public string Publication { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SubscriberPostInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("welcomeEmail")]
        public bool? WelcomeEmail { get; set; }

        [JsonProperty("additionalData")]
        public SubscriberPostInputAdditionalDataType AdditionalData { get; set; }
    }

    public class SubscriberPostInputAdditionalDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("companySize")]
        public int? CompanySize { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("twitterFollowers")]
        public int? TwitterFollowers { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("github")]
        public string Github { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }
    }

    public class SubscriberRemovePostResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("publication")]
        public string Publication { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class PostsGetPostResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("meta")]
        public PostsGetPostResponseMetaType Meta { get; set; }

        [JsonProperty("posts")]
        public PostsGetPostResponsePostsTypeItem[] Posts { get; set; }
    }

    public class PostsGetPostResponseMetaType
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("totalPosts")]
        public int TotalPosts { get; set; }
    }

    public class PostsGetPostResponsePostsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textPreview")]
        public string TextPreview { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("publishedOn")]
        public string PublishedOn { get; set; }

        [JsonProperty("coverImage")]
        public string CoverImage { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("metaTitle")]
        public string MetaTitle { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("publication")]
        public string Publication { get; set; }

        [JsonProperty("readTime")]
        public int ReadTime { get; set; }

        [JsonProperty("wordCount")]
        public int WordCount { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("markdown")]
        public string Markdown { get; set; }
    }

    public class PostsGetPostInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }

        [JsonProperty("offset", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Offset { get; set; } = 0;

        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }

    public class PostGetPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textPreview")]
        public string TextPreview { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("publishedOn")]
        public string PublishedOn { get; set; }

        [JsonProperty("coverImage")]
        public string CoverImage { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("metaTitle")]
        public string MetaTitle { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("publication")]
        public string Publication { get; set; }

        [JsonProperty("readTime")]
        public int ReadTime { get; set; }

        [JsonProperty("wordCount")]
        public int WordCount { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("markdown")]
        public string Markdown { get; set; }
    }

    public class PostDraftPostResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("draftLink")]
        public string DraftLink { get; set; }
    }

    public class PostDraftPostInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Html { get; set; }
    }

    public class ProjectGetPostResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("suggestedBy")]
        public string SuggestedBy { get; set; }

        [JsonProperty("suggestedOn")]
        public string SuggestedOn { get; set; }

        [JsonProperty("assignedBy")]
        public string AssignedBy { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("contributors")]
        public string[] Contributors { get; set; }

        [JsonProperty("contentMapDeadline")]
        public string ContentMapDeadline { get; set; }

        [JsonProperty("approvers")]
        public string[] Approvers { get; set; }

        [JsonProperty("reviewDeadline")]
        public string ReviewDeadline { get; set; }

        [JsonProperty("approvedBy")]
        public string ApprovedBy { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }
    }

    public class IdeaCreatePostResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("suggestedBy")]
        public string SuggestedBy { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class IdeaCreatePostInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("suggestedBy", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SuggestedBy { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }
    }

    public class IdeaAssignPostResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class IdeaAssignPostInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("assignTo", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AssignTo { get; set; }

        [JsonProperty("publishOn", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishOn { get; set; }

        [JsonProperty("approvers")]
        public string[] Approvers { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Letterdrop;

    public partial class WorkflowManagedActions
    {
        public LetterdropActions Letterdrop(string connectionId) => new LetterdropActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LetterdropTriggers Letterdrop(string connectionId) => new LetterdropTriggers(connectionId);
    }
}