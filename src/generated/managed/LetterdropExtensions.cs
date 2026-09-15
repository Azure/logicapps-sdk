//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Letterdrop
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LetterdropActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<SubscriberPostResponse> Subscriber(Expression<Func<string>> bodyemail, Expression<Func<bool>> bodywelcomeEmail = null, Expression<Func<string>> bodyadditionalDataname = null, Expression<Func<string>> bodyadditionalDatalocation = null, Expression<Func<string>> bodyadditionalDatatitle = null, Expression<Func<string>> bodyadditionalDatacompany = null, Expression<Func<int>> bodyadditionalDatacompanySize = null, Expression<Func<string>> bodyadditionalDataindustry = null, Expression<Func<string>> bodyadditionalDatatwitter = null, Expression<Func<int>> bodyadditionalDatatwitterFollowers = null, Expression<Func<string>> bodyadditionalDatalinkedin = null, Expression<Func<string>> bodyadditionalDatagithub = null, Expression<Func<string>> bodyadditionalDatafacebook = null)
        {
            var apiCallPath = "/subscriber/add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            if (bodywelcomeEmail != null)
            {
                body["welcomeEmail"] = CSharpExpressionConverter.ConvertToken(bodywelcomeEmail);
                bodypropCount++;
            }

            var additionalDataObject = new JObject();
            var additionalDataObjectpropCount = 0;
            if (bodyadditionalDataname != null)
            {
                additionalDataObject["name"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDataname);
                additionalDataObjectpropCount++;
            }

            if (bodyadditionalDatalocation != null)
            {
                additionalDataObject["location"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDatalocation);
                additionalDataObjectpropCount++;
            }

            if (bodyadditionalDatatitle != null)
            {
                additionalDataObject["title"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDatatitle);
                additionalDataObjectpropCount++;
            }

            if (bodyadditionalDatacompany != null)
            {
                additionalDataObject["company"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDatacompany);
                additionalDataObjectpropCount++;
            }

            if (bodyadditionalDatacompanySize != null)
            {
                additionalDataObject["companySize"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDatacompanySize);
                additionalDataObjectpropCount++;
            }

            if (bodyadditionalDataindustry != null)
            {
                additionalDataObject["industry"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDataindustry);
                additionalDataObjectpropCount++;
            }

            if (bodyadditionalDatatwitter != null)
            {
                additionalDataObject["twitter"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDatatwitter);
                additionalDataObjectpropCount++;
            }

            if (bodyadditionalDatatwitterFollowers != null)
            {
                additionalDataObject["twitterFollowers"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDatatwitterFollowers);
                additionalDataObjectpropCount++;
            }

            if (bodyadditionalDatalinkedin != null)
            {
                additionalDataObject["linkedin"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDatalinkedin);
                additionalDataObjectpropCount++;
            }

            if (bodyadditionalDatagithub != null)
            {
                additionalDataObject["github"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDatagithub);
                additionalDataObjectpropCount++;
            }

            if (bodyadditionalDatafacebook != null)
            {
                additionalDataObject["facebook"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDatafacebook);
                additionalDataObjectpropCount++;
            }

            if (additionalDataObjectpropCount > 0)
            {
                body["additionalData"] = additionalDataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SubscriberPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<SubscriberRemovePostResponse> SubscriberRemove(Expression<Func<string>> email)
        {
            var apiCallPath = "/subscriber/remove";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["email"] = CSharpExpressionConverter.ConvertO(email);
            return new ApiConnectionAction<SubscriberRemovePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostsGetPostResponse> PostsGet(Expression<Func<string>> bodyquery, Expression<Func<int>> bodyoffset = null, Expression<Func<int>> bodylimit = null)
        {
            var apiCallPath = "/posts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
            if (bodyoffset != null)
            {
                if (bodyoffset != null)
                {
                    body["offset"] = CSharpExpressionConverter.ConvertToken(bodyoffset);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["offset"] = 0;
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostsGetPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostGetPostResponse> PostGet(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/post/get/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PostGetPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostDraftPostResponse> PostDraft(Expression<Func<string>> bodytitle, Expression<Func<string>> bodyhtml, Expression<Func<string>> bodysubtitle = null)
        {
            var apiCallPath = "/post/draft";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            if (bodysubtitle != null)
            {
                body["subtitle"] = CSharpExpressionConverter.ConvertToken(bodysubtitle);
                bodypropCount++;
            }

            bodypropCount++;
            body["html"] = CSharpExpressionConverter.ConvertToken(bodyhtml);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostDraftPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<ProjectGetPostResponse> ProjectGet(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/project/get/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectGetPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<IdeaCreatePostResponse> IdeaCreate(Expression<Func<string>> bodytitle, Expression<Func<string>> bodysuggestedBy, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodykeyword = null, Expression<Func<string[]>> bodylabels = null)
        {
            var apiCallPath = "/idea/new";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            bodypropCount++;
            body["suggestedBy"] = CSharpExpressionConverter.ConvertToken(bodysuggestedBy);
            if (bodykeyword != null)
            {
                body["keyword"] = CSharpExpressionConverter.ConvertToken(bodykeyword);
                bodypropCount++;
            }

            if (bodylabels != null)
            {
                body["labels"] = CSharpExpressionConverter.ConvertToken(bodylabels);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IdeaCreatePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<IdeaAssignPostResponse> IdeaAssign(Expression<Func<string>> bodyid, Expression<Func<string>> bodyassignTo, Expression<Func<string>> bodypublishOn, Expression<Func<string[]>> bodyapprovers = null)
        {
            var apiCallPath = "/idea/assign";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = CSharpExpressionConverter.ConvertToken(bodyid);
            bodypropCount++;
            body["assignTo"] = CSharpExpressionConverter.ConvertToken(bodyassignTo);
            bodypropCount++;
            body["publishOn"] = CSharpExpressionConverter.ConvertToken(bodypublishOn);
            if (bodyapprovers != null)
            {
                body["approvers"] = CSharpExpressionConverter.ConvertToken(bodyapprovers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IdeaAssignPostResponse>(callPayload);
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

    public class IdeaAssignPostResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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