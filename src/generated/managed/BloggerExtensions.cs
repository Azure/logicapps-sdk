//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blogger
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BloggerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<BlogList, ApiConnectionActionConfiguration> ListBlogs()
        {
            return new DeferredBodyAction<BlogList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users/self/blogs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlogList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<PostList, ApiConnectionActionConfiguration> ListPosts(Expression<Func<string>> blogId, Expression<Func<string>> status = null)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<PostList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/{0}/posts", __workflow_blogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = Convert.ToString("live");
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<PostList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post, ApiConnectionActionConfiguration> Create(Expression<Func<string>> blogId, Expression<Func<CreatePostInput>> post, Expression<Func<bool>> isDraft = null)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_post = WorkflowExpression.Compile(post, nameof(post), required: true);
            var __workflow_isDraft = WorkflowExpression.Compile(isDraft, nameof(isDraft), required: false);
            return new DeferredBodyAction<Post, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/{0}/posts", __workflow_blogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isDraft"] = Convert.ToString(false);
                if (__workflow_isDraft != null)
                    callPayload.Queries["isDraft"] = ExpressionConverter.Convert(__workflow_isDraft);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_post);
                return new ApiConnectionAction<Post>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post, ApiConnectionActionConfiguration> Get(Expression<Func<string>> blogId, Expression<Func<string>> postId)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_postId = WorkflowExpression.Compile(postId, nameof(postId), required: true);
            return new DeferredBodyAction<Post, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/{0}/posts/{1}", __workflow_blogId.WithUrlEncoding(1), __workflow_postId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Post>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post, ApiConnectionActionConfiguration> Edit(Expression<Func<string>> blogId, Expression<Func<string>> postId, Expression<Func<EditPostInput>> post)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_postId = WorkflowExpression.Compile(postId, nameof(postId), required: true);
            var __workflow_post = WorkflowExpression.Compile(post, nameof(post), required: true);
            return new DeferredBodyAction<Post, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/{0}/posts/{1}", __workflow_blogId.WithUrlEncoding(1), __workflow_postId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_post);
                return new ApiConnectionAction<Post>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Delete(Expression<Func<string>> blogId, Expression<Func<string>> postId)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_postId = WorkflowExpression.Compile(postId, nameof(postId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/{0}/posts/{1}", __workflow_blogId.WithUrlEncoding(1), __workflow_postId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post, ApiConnectionActionConfiguration> Publish(Expression<Func<string>> blogId, Expression<Func<string>> postId)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_postId = WorkflowExpression.Compile(postId, nameof(postId), required: true);
            return new DeferredBodyAction<Post, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/{0}/posts/{1}/publish", __workflow_blogId.WithUrlEncoding(1), __workflow_postId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Post>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post, ApiConnectionActionConfiguration> Revert(Expression<Func<string>> blogId, Expression<Func<string>> postId)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_postId = WorkflowExpression.Compile(postId, nameof(postId), required: true);
            return new DeferredBodyAction<Post, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/{0}/posts/{1}/revert", __workflow_blogId.WithUrlEncoding(1), __workflow_postId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Post>(callPayload);
            });
        }
    }

    public class BloggerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Post[], ApiConnectionTriggerConfiguration> OnPostCreated(Expression<Func<string>> blogId, Expression<Func<statusInput>> status, FlowRecurrence recurrence = null)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            return new DeferredBodyTrigger<Post[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger1/blogs/{0}/posts", __workflow_blogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionTrigger<Post[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class BlogList
    {
        [JsonProperty("items")]
        public Blog[] Blogs { get; set; }
    }

    public class Blog
    {
        [JsonProperty("id")]
        public string BlogId { get; set; }

        [JsonProperty("name")]
        public string BlogName { get; set; }

        [JsonProperty("description")]
        public string BlogDescription { get; set; }

        [JsonProperty("published")]
        public string PublishedDate { get; set; }

        [JsonProperty("updated")]
        public string UpdatedDate { get; set; }

        [JsonProperty("url")]
        public string BlogURL { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostList
    {
        [JsonProperty("items")]
        public Post[] Posts { get; set; }
    }

    public class Post
    {
        [JsonProperty("id")]
        public string PostId { get; set; }

        [JsonProperty("blog.id")]
        public string BlogId { get; set; }

        [JsonProperty("published")]
        public string PublishedDate { get; set; }

        [JsonProperty("updated")]
        public string UpdatedDate { get; set; }

        [JsonProperty("url")]
        public string PostURL { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string PostContent { get; set; }

        [JsonProperty("author.id")]
        public string AuthorId { get; set; }

        [JsonProperty("author.displayName")]
        public string AuthorName { get; set; }

        [JsonProperty("author.url")]
        public string AuthorURL { get; set; }

        [JsonProperty("author.image.url")]
        public string AuthorImageURL { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class Location
    {
        [JsonProperty("name")]
        public string LocationName { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lng")]
        public double Longitude { get; set; }

        [JsonProperty("span")]
        public string LocationSpan { get; set; }
    }

    public class CreatePostInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }
    }

    public class EditPostInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        Draft,
        Live,
        All
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blogger;

    public partial class WorkflowManagedActions
    {
        public BloggerActions Blogger(string connectionId) => new BloggerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BloggerTriggers Blogger(string connectionId) => new BloggerTriggers(connectionId);
    }
}