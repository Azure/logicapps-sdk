//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Letterdrop
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LetterdropActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [WorkflowExpressionFactory(nameof(__BuildSubscriber))]
        public IBodyWorkflowAction<SubscriberPostResponse> Subscriber([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bool> bodywelcomeEmail = null, [WorkflowExpression] Func<string> bodyadditionalDataname = null, [WorkflowExpression] Func<string> bodyadditionalDatalocation = null, [WorkflowExpression] Func<string> bodyadditionalDatatitle = null, [WorkflowExpression] Func<string> bodyadditionalDatacompany = null, [WorkflowExpression] Func<int> bodyadditionalDatacompanySize = null, [WorkflowExpression] Func<string> bodyadditionalDataindustry = null, [WorkflowExpression] Func<string> bodyadditionalDatatwitter = null, [WorkflowExpression] Func<int> bodyadditionalDatatwitterFollowers = null, [WorkflowExpression] Func<string> bodyadditionalDatalinkedin = null, [WorkflowExpression] Func<string> bodyadditionalDatagithub = null, [WorkflowExpression] Func<string> bodyadditionalDatafacebook = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriberPostResponse> __BuildSubscriber(WorkflowExpression<string> bodyemail, WorkflowExpression<bool> bodywelcomeEmail = null, WorkflowExpression<string> bodyadditionalDataname = null, WorkflowExpression<string> bodyadditionalDatalocation = null, WorkflowExpression<string> bodyadditionalDatatitle = null, WorkflowExpression<string> bodyadditionalDatacompany = null, WorkflowExpression<int> bodyadditionalDatacompanySize = null, WorkflowExpression<string> bodyadditionalDataindustry = null, WorkflowExpression<string> bodyadditionalDatatwitter = null, WorkflowExpression<int> bodyadditionalDatatwitterFollowers = null, WorkflowExpression<string> bodyadditionalDatalinkedin = null, WorkflowExpression<string> bodyadditionalDatagithub = null, WorkflowExpression<string> bodyadditionalDatafacebook = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodywelcomeEmail, nameof(bodywelcomeEmail), required: false);
            WorkflowExpression.Validate(bodyadditionalDataname, nameof(bodyadditionalDataname), required: false);
            WorkflowExpression.Validate(bodyadditionalDatalocation, nameof(bodyadditionalDatalocation), required: false);
            WorkflowExpression.Validate(bodyadditionalDatatitle, nameof(bodyadditionalDatatitle), required: false);
            WorkflowExpression.Validate(bodyadditionalDatacompany, nameof(bodyadditionalDatacompany), required: false);
            WorkflowExpression.Validate(bodyadditionalDatacompanySize, nameof(bodyadditionalDatacompanySize), required: false);
            WorkflowExpression.Validate(bodyadditionalDataindustry, nameof(bodyadditionalDataindustry), required: false);
            WorkflowExpression.Validate(bodyadditionalDatatwitter, nameof(bodyadditionalDatatwitter), required: false);
            WorkflowExpression.Validate(bodyadditionalDatatwitterFollowers, nameof(bodyadditionalDatatwitterFollowers), required: false);
            WorkflowExpression.Validate(bodyadditionalDatalinkedin, nameof(bodyadditionalDatalinkedin), required: false);
            WorkflowExpression.Validate(bodyadditionalDatagithub, nameof(bodyadditionalDatagithub), required: false);
            WorkflowExpression.Validate(bodyadditionalDatafacebook, nameof(bodyadditionalDatafacebook), required: false);
            return new DeferredBodyAction<SubscriberPostResponse>(() =>
            {
                var apiCallPath = "/subscriber/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodywelcomeEmail != null)
                {
                    body["welcomeEmail"] = ExpressionConverter.ConvertO(bodywelcomeEmail);
                    bodypropCount++;
                }

                var additionalDataObject = new JObject();
                var additionalDataObjectpropCount = 0;
                if (bodyadditionalDataname != null)
                {
                    additionalDataObject["name"] = ExpressionConverter.ConvertO(bodyadditionalDataname);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatalocation != null)
                {
                    additionalDataObject["location"] = ExpressionConverter.ConvertO(bodyadditionalDatalocation);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatatitle != null)
                {
                    additionalDataObject["title"] = ExpressionConverter.ConvertO(bodyadditionalDatatitle);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatacompany != null)
                {
                    additionalDataObject["company"] = ExpressionConverter.ConvertO(bodyadditionalDatacompany);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatacompanySize != null)
                {
                    additionalDataObject["companySize"] = ExpressionConverter.ConvertO(bodyadditionalDatacompanySize);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDataindustry != null)
                {
                    additionalDataObject["industry"] = ExpressionConverter.ConvertO(bodyadditionalDataindustry);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatatwitter != null)
                {
                    additionalDataObject["twitter"] = ExpressionConverter.ConvertO(bodyadditionalDatatwitter);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatatwitterFollowers != null)
                {
                    additionalDataObject["twitterFollowers"] = ExpressionConverter.ConvertO(bodyadditionalDatatwitterFollowers);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatalinkedin != null)
                {
                    additionalDataObject["linkedin"] = ExpressionConverter.ConvertO(bodyadditionalDatalinkedin);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatagithub != null)
                {
                    additionalDataObject["github"] = ExpressionConverter.ConvertO(bodyadditionalDatagithub);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatafacebook != null)
                {
                    additionalDataObject["facebook"] = ExpressionConverter.ConvertO(bodyadditionalDatafacebook);
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
        [WorkflowExpressionFactory(nameof(__BuildSubscriberRemove))]
        public IBodyWorkflowAction<SubscriberRemovePostResponse> SubscriberRemove([WorkflowExpression] Func<string> email)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriberRemovePostResponse> __BuildSubscriberRemove(WorkflowExpression<string> email)
        {
            WorkflowExpression.Validate(email, nameof(email), required: true);
            return new DeferredBodyAction<SubscriberRemovePostResponse>(() =>
            {
                var apiCallPath = "/subscriber/remove";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                return new ApiConnectionAction<SubscriberRemovePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [WorkflowExpressionFactory(nameof(__BuildPostsGet))]
        public IBodyWorkflowAction<PostsGetPostResponse> PostsGet([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<int> bodyoffset = null, [WorkflowExpression] Func<int> bodylimit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostsGetPostResponse> __BuildPostsGet(WorkflowExpression<string> bodyquery, WorkflowExpression<int> bodyoffset = null, WorkflowExpression<int> bodylimit = null)
        {
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            WorkflowExpression.Validate(bodyoffset, nameof(bodyoffset), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<PostsGetPostResponse>(() =>
            {
                var apiCallPath = "/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(bodyquery);
                if (bodyoffset != null)
                {
                    if (bodyoffset != null)
                    {
                        body["offset"] = ExpressionConverter.ConvertO(bodyoffset);
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
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
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
        [WorkflowExpressionFactory(nameof(__BuildPostGet))]
        public IBodyWorkflowAction<PostGetPostResponse> PostGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostGetPostResponse> __BuildPostGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<PostGetPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/post/get/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PostGetPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [WorkflowExpressionFactory(nameof(__BuildPostDraft))]
        public IBodyWorkflowAction<PostDraftPostResponse> PostDraft([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyhtml, [WorkflowExpression] Func<string> bodysubtitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostDraftPostResponse> __BuildPostDraft(WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodyhtml, WorkflowExpression<string> bodysubtitle = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodyhtml, nameof(bodyhtml), required: true);
            WorkflowExpression.Validate(bodysubtitle, nameof(bodysubtitle), required: false);
            return new DeferredBodyAction<PostDraftPostResponse>(() =>
            {
                var apiCallPath = "/post/draft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodysubtitle != null)
                {
                    body["subtitle"] = ExpressionConverter.ConvertO(bodysubtitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["html"] = ExpressionConverter.ConvertO(bodyhtml);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostDraftPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [WorkflowExpressionFactory(nameof(__BuildProjectGet))]
        public IBodyWorkflowAction<ProjectGetPostResponse> ProjectGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectGetPostResponse> __BuildProjectGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ProjectGetPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/project/get/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectGetPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [WorkflowExpressionFactory(nameof(__BuildIdeaCreate))]
        public IBodyWorkflowAction<IdeaCreatePostResponse> IdeaCreate([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodysuggestedBy, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodykeyword = null, [WorkflowExpression] Func<string[]> bodylabels = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IdeaCreatePostResponse> __BuildIdeaCreate(WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodysuggestedBy, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodykeyword = null, WorkflowExpression<string[]> bodylabels = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodysuggestedBy, nameof(bodysuggestedBy), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodykeyword, nameof(bodykeyword), required: false);
            WorkflowExpression.Validate(bodylabels, nameof(bodylabels), required: false);
            return new DeferredBodyAction<IdeaCreatePostResponse>(() =>
            {
                var apiCallPath = "/idea/new";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["suggestedBy"] = ExpressionConverter.ConvertO(bodysuggestedBy);
                if (bodykeyword != null)
                {
                    body["keyword"] = ExpressionConverter.ConvertO(bodykeyword);
                    bodypropCount++;
                }

                if (bodylabels != null)
                {
                    body["labels"] = ExpressionConverter.ConvertO(bodylabels);
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
        [WorkflowExpressionFactory(nameof(__BuildIdeaAssign))]
        public IBodyWorkflowAction<IdeaAssignPostResponse> IdeaAssign([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyassignTo, [WorkflowExpression] Func<string> bodypublishOn, [WorkflowExpression] Func<string[]> bodyapprovers = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IdeaAssignPostResponse> __BuildIdeaAssign(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyassignTo, WorkflowExpression<string> bodypublishOn, WorkflowExpression<string[]> bodyapprovers = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyassignTo, nameof(bodyassignTo), required: true);
            WorkflowExpression.Validate(bodypublishOn, nameof(bodypublishOn), required: true);
            WorkflowExpression.Validate(bodyapprovers, nameof(bodyapprovers), required: false);
            return new DeferredBodyAction<IdeaAssignPostResponse>(() =>
            {
                var apiCallPath = "/idea/assign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
                body["assignTo"] = ExpressionConverter.ConvertO(bodyassignTo);
                bodypropCount++;
                body["publishOn"] = ExpressionConverter.ConvertO(bodypublishOn);
                if (bodyapprovers != null)
                {
                    body["approvers"] = ExpressionConverter.ConvertO(bodyapprovers);
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