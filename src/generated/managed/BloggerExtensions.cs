//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blogger
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BloggerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<BlogList> ListBlogs()
        {
            var apiCallPath = "/users/self/blogs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlogList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [WorkflowExpressionFactory(nameof(__BuildListPosts))]
        public IBodyWorkflowAction<PostList> ListPosts([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostList> __BuildListPosts(WorkflowExpression<string> blogId, WorkflowExpression<string> status = null)
        {
            WorkflowExpression.Validate(blogId, nameof(blogId), required: true);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<PostList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts", ExpressionConverter.ConvertWithUrlEncoding(blogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = Convert.ToString("live");
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                return new ApiConnectionAction<PostList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [WorkflowExpressionFactory(nameof(__BuildCreate))]
        public IBodyWorkflowAction<Post> Create([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> posttitle, [WorkflowExpression] Func<string> postcontent, [WorkflowExpression] Func<string[]> postlabels = null, [WorkflowExpression] Func<bool> isDraft = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Post> __BuildCreate(WorkflowExpression<string> blogId, WorkflowExpression<string> posttitle, WorkflowExpression<string> postcontent, WorkflowExpression<string[]> postlabels = null, WorkflowExpression<bool> isDraft = null)
        {
            WorkflowExpression.Validate(blogId, nameof(blogId), required: true);
            WorkflowExpression.Validate(posttitle, nameof(posttitle), required: true);
            WorkflowExpression.Validate(postcontent, nameof(postcontent), required: true);
            WorkflowExpression.Validate(postlabels, nameof(postlabels), required: false);
            WorkflowExpression.Validate(isDraft, nameof(isDraft), required: false);
            return new DeferredBodyAction<Post>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts", ExpressionConverter.ConvertWithUrlEncoding(blogId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isDraft"] = Convert.ToString(false);
                if (isDraft != null)
                    callPayload.Queries["isDraft"] = ExpressionConverter.Convert(isDraft);
                var post = new JObject();
                var postpropCount = 0;
                postpropCount++;
                post["title"] = ExpressionConverter.ConvertO(posttitle);
                postpropCount++;
                post["content"] = ExpressionConverter.ConvertO(postcontent);
                if (postlabels != null)
                {
                    post["labels"] = ExpressionConverter.ConvertO(postlabels);
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
        [WorkflowExpressionFactory(nameof(__BuildGet))]
        public IBodyWorkflowAction<Post> Get([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> postId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Post> __BuildGet(WorkflowExpression<string> blogId, WorkflowExpression<string> postId)
        {
            WorkflowExpression.Validate(blogId, nameof(blogId), required: true);
            WorkflowExpression.Validate(postId, nameof(postId), required: true);
            return new DeferredBodyAction<Post>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}", ExpressionConverter.ConvertWithUrlEncoding(blogId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Post>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [WorkflowExpressionFactory(nameof(__BuildEdit))]
        public IBodyWorkflowAction<Post> Edit([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> postId, [WorkflowExpression] Func<string> posttitle = null, [WorkflowExpression] Func<string> postcontent = null, [WorkflowExpression] Func<string[]> postlabels = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Post> __BuildEdit(WorkflowExpression<string> blogId, WorkflowExpression<string> postId, WorkflowExpression<string> posttitle = null, WorkflowExpression<string> postcontent = null, WorkflowExpression<string[]> postlabels = null)
        {
            WorkflowExpression.Validate(blogId, nameof(blogId), required: true);
            WorkflowExpression.Validate(postId, nameof(postId), required: true);
            WorkflowExpression.Validate(posttitle, nameof(posttitle), required: false);
            WorkflowExpression.Validate(postcontent, nameof(postcontent), required: false);
            WorkflowExpression.Validate(postlabels, nameof(postlabels), required: false);
            return new DeferredBodyAction<Post>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}", ExpressionConverter.ConvertWithUrlEncoding(blogId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var post = new JObject();
                var postpropCount = 0;
                if (posttitle != null)
                {
                    post["title"] = ExpressionConverter.ConvertO(posttitle);
                    postpropCount++;
                }

                if (postcontent != null)
                {
                    post["content"] = ExpressionConverter.ConvertO(postcontent);
                    postpropCount++;
                }

                if (postlabels != null)
                {
                    post["labels"] = ExpressionConverter.ConvertO(postlabels);
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
        [WorkflowExpressionFactory(nameof(__BuildDelete))]
        public IWorkflowAction Delete([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> postId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDelete(WorkflowExpression<string> blogId, WorkflowExpression<string> postId)
        {
            WorkflowExpression.Validate(blogId, nameof(blogId), required: true);
            WorkflowExpression.Validate(postId, nameof(postId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}", ExpressionConverter.ConvertWithUrlEncoding(blogId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [WorkflowExpressionFactory(nameof(__BuildPublish))]
        public IBodyWorkflowAction<Post> Publish([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> postId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Post> __BuildPublish(WorkflowExpression<string> blogId, WorkflowExpression<string> postId)
        {
            WorkflowExpression.Validate(blogId, nameof(blogId), required: true);
            WorkflowExpression.Validate(postId, nameof(postId), required: true);
            return new DeferredBodyAction<Post>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}/publish", ExpressionConverter.ConvertWithUrlEncoding(blogId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Post>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [WorkflowExpressionFactory(nameof(__BuildRevert))]
        public IBodyWorkflowAction<Post> Revert([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> postId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Post> __BuildRevert(WorkflowExpression<string> blogId, WorkflowExpression<string> postId)
        {
            WorkflowExpression.Validate(blogId, nameof(blogId), required: true);
            WorkflowExpression.Validate(postId, nameof(postId), required: true);
            return new DeferredBodyAction<Post>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}/revert", ExpressionConverter.ConvertWithUrlEncoding(blogId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Post>(callPayload);
            });
        }
    }

    public class BloggerTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnPostCreated))]
        public IBodyWorkflowTrigger<Post[]> OnPostCreated([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<statusInput> status, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<Post[]> __BuildOnPostCreated(WorkflowExpression<string> blogId, WorkflowExpression<statusInput> status, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(blogId, nameof(blogId), required: true);
            WorkflowExpression.Validate(status, nameof(status), required: true);
            return new DeferredBodyTrigger<Post[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger1/blogs/{0}/posts", ExpressionConverter.ConvertWithUrlEncoding(blogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                return new ApiConnectionTrigger<Post[]>(callPayload, triggerName, recurrence);
            }, triggerName);
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