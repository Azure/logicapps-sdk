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
            var apiCallPath = "/users/self/blogs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlogList>(callPayload);
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
        public IBodyWorkflowAction<Post, ApiConnectionActionConfiguration> Create(Expression<Func<string>> blogId, Expression<Func<string>> posttitle, Expression<Func<string>> postcontent, Expression<Func<string[]>> postlabels = null, Expression<Func<bool>> isDraft = null)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_posttitle = WorkflowExpression.Compile(posttitle, nameof(posttitle), required: true);
            var __workflow_postcontent = WorkflowExpression.Compile(postcontent, nameof(postcontent), required: true);
            var __workflow_postlabels = WorkflowExpression.Compile(postlabels, nameof(postlabels), required: false);
            var __workflow_isDraft = WorkflowExpression.Compile(isDraft, nameof(isDraft), required: false);
            return new DeferredBodyAction<Post, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/{0}/posts", __workflow_blogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isDraft"] = Convert.ToString(false);
                if (__workflow_isDraft != null)
                    callPayload.Queries["isDraft"] = ExpressionConverter.Convert(__workflow_isDraft);
                var post = new JObject();
                var postpropCount = 0;
                postpropCount++;
                post["title"] = ExpressionConverter.ConvertO(__workflow_posttitle);
                postpropCount++;
                post["content"] = ExpressionConverter.ConvertO(__workflow_postcontent);
                if (__workflow_postlabels != null)
                {
                    post["labels"] = ExpressionConverter.ConvertO(__workflow_postlabels);
                    postpropCount++;
                }

                if (postpropCount > 0)
                {
                    callPayload.Body = post;
                }

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
        public IBodyWorkflowAction<Post, ApiConnectionActionConfiguration> Edit(Expression<Func<string>> blogId, Expression<Func<string>> postId, Expression<Func<string>> posttitle = null, Expression<Func<string>> postcontent = null, Expression<Func<string[]>> postlabels = null)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_postId = WorkflowExpression.Compile(postId, nameof(postId), required: true);
            var __workflow_posttitle = WorkflowExpression.Compile(posttitle, nameof(posttitle), required: false);
            var __workflow_postcontent = WorkflowExpression.Compile(postcontent, nameof(postcontent), required: false);
            var __workflow_postlabels = WorkflowExpression.Compile(postlabels, nameof(postlabels), required: false);
            return new DeferredBodyAction<Post, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/{0}/posts/{1}", __workflow_blogId.WithUrlEncoding(1), __workflow_postId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var post = new JObject();
                var postpropCount = 0;
                if (__workflow_posttitle != null)
                {
                    post["title"] = ExpressionConverter.ConvertO(__workflow_posttitle);
                    postpropCount++;
                }

                if (__workflow_postcontent != null)
                {
                    post["content"] = ExpressionConverter.ConvertO(__workflow_postcontent);
                    postpropCount++;
                }

                if (__workflow_postlabels != null)
                {
                    post["labels"] = ExpressionConverter.ConvertO(__workflow_postlabels);
                    postpropCount++;
                }

                if (postpropCount > 0)
                {
                    callPayload.Body = post;
                }

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
        public string BlogID { get; set; }

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
