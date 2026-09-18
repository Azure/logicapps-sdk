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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/self/blogs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BlogList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<PostList> ListPosts([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> status = null)
        {
            SourceExpression.Validate(blogId, nameof(blogId), required: true);
            SourceExpression.Validate(status, nameof(status), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = Convert.ToString("live");
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<PostList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post> Create([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> posttitle, [WorkflowExpression] Func<string> postcontent, [WorkflowExpression] Func<string[]> postlabels = null, [WorkflowExpression] Func<bool> isDraft = null)
        {
            SourceExpression.Validate(blogId, nameof(blogId), required: true);
            SourceExpression.Validate(posttitle, nameof(posttitle), required: true);
            SourceExpression.Validate(postcontent, nameof(postcontent), required: true);
            SourceExpression.Validate(postlabels, nameof(postlabels), required: false);
            SourceExpression.Validate(isDraft, nameof(isDraft), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isDraft"] = Convert.ToString(false);
                if (isDraft != null)
                    callPayload.Queries["isDraft"] = SourceExpressionConverter.ConvertO(isDraft);
                var post = new JObject();
                var postpropCount = 0;
                postpropCount++;
                post["title"] = SourceExpressionConverter.ConvertToken(posttitle);
                postpropCount++;
                post["content"] = SourceExpressionConverter.ConvertToken(postcontent);
                if (postlabels != null)
                {
                    post["labels"] = SourceExpressionConverter.ConvertToken(postlabels);
                    postpropCount++;
                }

                if (postpropCount > 0)
                {
                    callPayload.Body = post;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Post>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post> Get([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> postId)
        {
            SourceExpression.Validate(blogId, nameof(blogId), required: true);
            SourceExpression.Validate(postId, nameof(postId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Post>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post> Edit([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> postId, [WorkflowExpression] Func<string> posttitle = null, [WorkflowExpression] Func<string> postcontent = null, [WorkflowExpression] Func<string[]> postlabels = null)
        {
            SourceExpression.Validate(blogId, nameof(blogId), required: true);
            SourceExpression.Validate(postId, nameof(postId), required: true);
            SourceExpression.Validate(posttitle, nameof(posttitle), required: false);
            SourceExpression.Validate(postcontent, nameof(postcontent), required: false);
            SourceExpression.Validate(postlabels, nameof(postlabels), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var post = new JObject();
                var postpropCount = 0;
                if (posttitle != null)
                {
                    post["title"] = SourceExpressionConverter.ConvertToken(posttitle);
                    postpropCount++;
                }

                if (postcontent != null)
                {
                    post["content"] = SourceExpressionConverter.ConvertToken(postcontent);
                    postpropCount++;
                }

                if (postlabels != null)
                {
                    post["labels"] = SourceExpressionConverter.ConvertToken(postlabels);
                    postpropCount++;
                }

                if (postpropCount > 0)
                {
                    callPayload.Body = post;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Post>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IWorkflowAction Delete([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> postId)
        {
            SourceExpression.Validate(blogId, nameof(blogId), required: true);
            SourceExpression.Validate(postId, nameof(postId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post> Publish([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> postId)
        {
            SourceExpression.Validate(blogId, nameof(blogId), required: true);
            SourceExpression.Validate(postId, nameof(postId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}/publish", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Post>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blogger")]
        public IBodyWorkflowAction<Post> Revert([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> postId)
        {
            SourceExpression.Validate(blogId, nameof(blogId), required: true);
            SourceExpression.Validate(postId, nameof(postId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/{0}/posts/{1}/revert", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Post>(BuildSourceInput);
        }
    }

    public class BloggerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Post[]> OnPostCreated([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<statusInput> status, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(blogId, nameof(blogId), required: true);
            SourceExpression.Validate(status, nameof(status), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger1/blogs/{0}/posts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                return callPayload;
            }

            return new ApiConnectionTrigger<Post[]>(BuildSourceInput, triggerName, recurrence);
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