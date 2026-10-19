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
        public IBodyWorkflowAction<SubscriberPostResponse> Subscriber(Expression<Func<string>> bodyemail, Expression<Func<bool>> bodywelcomeEmail = null, Expression<Func<string>> bodyadditionalDataname = null, Expression<Func<string>> bodyadditionalDatalocation = null, Expression<Func<string>> bodyadditionalDatatitle = null, Expression<Func<string>> bodyadditionalDatacompany = null, Expression<Func<int>> bodyadditionalDatacompanySize = null, Expression<Func<string>> bodyadditionalDataindustry = null, Expression<Func<string>> bodyadditionalDatatwitter = null, Expression<Func<int>> bodyadditionalDatatwitterFollowers = null, Expression<Func<string>> bodyadditionalDatalinkedin = null, Expression<Func<string>> bodyadditionalDatagithub = null, Expression<Func<string>> bodyadditionalDatafacebook = null)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodywelcomeEmail = WorkflowExpression.Compile(bodywelcomeEmail, nameof(bodywelcomeEmail), required: false);
            var __workflow_bodyadditionalDataname = WorkflowExpression.Compile(bodyadditionalDataname, nameof(bodyadditionalDataname), required: false);
            var __workflow_bodyadditionalDatalocation = WorkflowExpression.Compile(bodyadditionalDatalocation, nameof(bodyadditionalDatalocation), required: false);
            var __workflow_bodyadditionalDatatitle = WorkflowExpression.Compile(bodyadditionalDatatitle, nameof(bodyadditionalDatatitle), required: false);
            var __workflow_bodyadditionalDatacompany = WorkflowExpression.Compile(bodyadditionalDatacompany, nameof(bodyadditionalDatacompany), required: false);
            var __workflow_bodyadditionalDatacompanySize = WorkflowExpression.Compile(bodyadditionalDatacompanySize, nameof(bodyadditionalDatacompanySize), required: false);
            var __workflow_bodyadditionalDataindustry = WorkflowExpression.Compile(bodyadditionalDataindustry, nameof(bodyadditionalDataindustry), required: false);
            var __workflow_bodyadditionalDatatwitter = WorkflowExpression.Compile(bodyadditionalDatatwitter, nameof(bodyadditionalDatatwitter), required: false);
            var __workflow_bodyadditionalDatatwitterFollowers = WorkflowExpression.Compile(bodyadditionalDatatwitterFollowers, nameof(bodyadditionalDatatwitterFollowers), required: false);
            var __workflow_bodyadditionalDatalinkedin = WorkflowExpression.Compile(bodyadditionalDatalinkedin, nameof(bodyadditionalDatalinkedin), required: false);
            var __workflow_bodyadditionalDatagithub = WorkflowExpression.Compile(bodyadditionalDatagithub, nameof(bodyadditionalDatagithub), required: false);
            var __workflow_bodyadditionalDatafacebook = WorkflowExpression.Compile(bodyadditionalDatafacebook, nameof(bodyadditionalDatafacebook), required: false);
            return new DeferredBodyAction<SubscriberPostResponse>(() =>
            {
                var apiCallPath = "/subscriber/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodywelcomeEmail != null)
                {
                    body["welcomeEmail"] = ExpressionConverter.ConvertO(__workflow_bodywelcomeEmail);
                    bodypropCount++;
                }

                var additionalDataObject = new JObject();
                var additionalDataObjectpropCount = 0;
                if (__workflow_bodyadditionalDataname != null)
                {
                    additionalDataObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDataname);
                    additionalDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalDatalocation != null)
                {
                    additionalDataObject["location"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDatalocation);
                    additionalDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalDatatitle != null)
                {
                    additionalDataObject["title"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDatatitle);
                    additionalDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalDatacompany != null)
                {
                    additionalDataObject["company"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDatacompany);
                    additionalDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalDatacompanySize != null)
                {
                    additionalDataObject["companySize"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDatacompanySize);
                    additionalDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalDataindustry != null)
                {
                    additionalDataObject["industry"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDataindustry);
                    additionalDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalDatatwitter != null)
                {
                    additionalDataObject["twitter"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDatatwitter);
                    additionalDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalDatatwitterFollowers != null)
                {
                    additionalDataObject["twitterFollowers"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDatatwitterFollowers);
                    additionalDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalDatalinkedin != null)
                {
                    additionalDataObject["linkedin"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDatalinkedin);
                    additionalDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalDatagithub != null)
                {
                    additionalDataObject["github"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDatagithub);
                    additionalDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalDatafacebook != null)
                {
                    additionalDataObject["facebook"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDatafacebook);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<SubscriberRemovePostResponse> SubscriberRemove(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<SubscriberRemovePostResponse>(() =>
            {
                var apiCallPath = "/subscriber/remove";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction<SubscriberRemovePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostsGetPostResponse> PostsGet(Expression<Func<string>> bodyquery, Expression<Func<int>> bodyoffset = null, Expression<Func<int>> bodylimit = null)
        {
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: true);
            var __workflow_bodyoffset = WorkflowExpression.Compile(bodyoffset, nameof(bodyoffset), required: false);
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<PostsGetPostResponse>(() =>
            {
                var apiCallPath = "/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                if (__workflow_bodyoffset != null)
                {
                    if (__workflow_bodyoffset != null)
                    {
                        body["offset"] = ExpressionConverter.ConvertO(__workflow_bodyoffset);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["offset"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostsGetPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostGetPostResponse> PostGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PostGetPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/post/get/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PostGetPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostDraftPostResponse> PostDraft(Expression<Func<string>> bodytitle, Expression<Func<string>> bodyhtml, Expression<Func<string>> bodysubtitle = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyhtml = WorkflowExpression.Compile(bodyhtml, nameof(bodyhtml), required: true);
            var __workflow_bodysubtitle = WorkflowExpression.Compile(bodysubtitle, nameof(bodysubtitle), required: false);
            return new DeferredBodyAction<PostDraftPostResponse>(() =>
            {
                var apiCallPath = "/post/draft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodysubtitle != null)
                {
                    body["subtitle"] = ExpressionConverter.ConvertO(__workflow_bodysubtitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["html"] = ExpressionConverter.ConvertO(__workflow_bodyhtml);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostDraftPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<ProjectGetPostResponse> ProjectGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ProjectGetPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/project/get/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectGetPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<IdeaCreatePostResponse> IdeaCreate(Expression<Func<string>> bodytitle, Expression<Func<string>> bodysuggestedBy, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodykeyword = null, Expression<Func<string[]>> bodylabels = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodysuggestedBy = WorkflowExpression.Compile(bodysuggestedBy, nameof(bodysuggestedBy), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodykeyword = WorkflowExpression.Compile(bodykeyword, nameof(bodykeyword), required: false);
            var __workflow_bodylabels = WorkflowExpression.Compile(bodylabels, nameof(bodylabels), required: false);
            return new DeferredBodyAction<IdeaCreatePostResponse>(() =>
            {
                var apiCallPath = "/idea/new";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["suggestedBy"] = ExpressionConverter.ConvertO(__workflow_bodysuggestedBy);
                if (__workflow_bodykeyword != null)
                {
                    body["keyword"] = ExpressionConverter.ConvertO(__workflow_bodykeyword);
                    bodypropCount++;
                }

                if (__workflow_bodylabels != null)
                {
                    body["labels"] = ExpressionConverter.ConvertO(__workflow_bodylabels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IdeaCreatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<IdeaAssignPostResponse> IdeaAssign(Expression<Func<string>> bodyid, Expression<Func<string>> bodyassignTo, Expression<Func<string>> bodypublishOn, Expression<Func<string[]>> bodyapprovers = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyassignTo = WorkflowExpression.Compile(bodyassignTo, nameof(bodyassignTo), required: true);
            var __workflow_bodypublishOn = WorkflowExpression.Compile(bodypublishOn, nameof(bodypublishOn), required: true);
            var __workflow_bodyapprovers = WorkflowExpression.Compile(bodyapprovers, nameof(bodyapprovers), required: false);
            return new DeferredBodyAction<IdeaAssignPostResponse>(() =>
            {
                var apiCallPath = "/idea/assign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["assignTo"] = ExpressionConverter.ConvertO(__workflow_bodyassignTo);
                bodypropCount++;
                body["publishOn"] = ExpressionConverter.ConvertO(__workflow_bodypublishOn);
                if (__workflow_bodyapprovers != null)
                {
                    body["approvers"] = ExpressionConverter.ConvertO(__workflow_bodyapprovers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
