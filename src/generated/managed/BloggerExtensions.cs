//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blogger
{
    using System.Linq.Expressions;
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
        public IBodyWorkflowAction<PostList> ListPosts(Expression<Func<string>> blogId, Expression<Func<string>> status = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["status"] = Convert.ToString("live");
            if (status != null)
                callPayload.Queries["status"] = CSharpExpressionConverter.ConvertO(status);
            return new ApiConnectionAction<PostList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post> Create(Expression<Func<string>> blogId, Expression<Func<string>> posttitle, Expression<Func<string>> postcontent, Expression<Func<string[]>> postlabels = null, Expression<Func<bool>> isDraft = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["isDraft"] = Convert.ToString(false);
            if (isDraft != null)
                callPayload.Queries["isDraft"] = CSharpExpressionConverter.ConvertO(isDraft);
            var post = new JObject();
            var postpropCount = 0;
            postpropCount++;
            post["title"] = CSharpExpressionConverter.ConvertToken(posttitle);
            postpropCount++;
            post["content"] = CSharpExpressionConverter.ConvertToken(postcontent);
            if (postlabels != null)
            {
                post["labels"] = CSharpExpressionConverter.ConvertToken(postlabels);
                postpropCount++;
            }

            if (postpropCount > 0)
            {
                callPayload.Body = post;
            }

            return new ApiConnectionAction<Post>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post> Get(Expression<Func<string>> blogId, Expression<Func<string>> postId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Post>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post> Edit(Expression<Func<string>> blogId, Expression<Func<string>> postId, Expression<Func<string>> posttitle = null, Expression<Func<string>> postcontent = null, Expression<Func<string[]>> postlabels = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var post = new JObject();
            var postpropCount = 0;
            if (posttitle != null)
            {
                post["title"] = CSharpExpressionConverter.ConvertToken(posttitle);
                postpropCount++;
            }

            if (postcontent != null)
            {
                post["content"] = CSharpExpressionConverter.ConvertToken(postcontent);
                postpropCount++;
            }

            if (postlabels != null)
            {
                post["labels"] = CSharpExpressionConverter.ConvertToken(postlabels);
                postpropCount++;
            }

            if (postpropCount > 0)
            {
                callPayload.Body = post;
            }

            return new ApiConnectionAction<Post>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IWorkflowAction Delete(Expression<Func<string>> blogId, Expression<Func<string>> postId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post> Publish(Expression<Func<string>> blogId, Expression<Func<string>> postId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}/publish", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Post>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post> Revert(Expression<Func<string>> blogId, Expression<Func<string>> postId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}/revert", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Post>(callPayload);
        }
    }

    public class BloggerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Post[]> OnPostCreated(Expression<Func<string>> blogId, Expression<Func<statusInput>> status, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/trigger1/blogs/{0}/posts", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["status"] = CSharpExpressionConverter.Convert(status);
            return new ApiConnectionTrigger<Post[]>(callPayload, triggerName, recurrence);
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