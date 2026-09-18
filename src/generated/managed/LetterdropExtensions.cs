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
        public IBodyWorkflowAction<SubscriberPostResponse> Subscriber([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bool> bodywelcomeEmail = null, [WorkflowExpression] Func<string> bodyadditionalDataname = null, [WorkflowExpression] Func<string> bodyadditionalDatalocation = null, [WorkflowExpression] Func<string> bodyadditionalDatatitle = null, [WorkflowExpression] Func<string> bodyadditionalDatacompany = null, [WorkflowExpression] Func<int> bodyadditionalDatacompanySize = null, [WorkflowExpression] Func<string> bodyadditionalDataindustry = null, [WorkflowExpression] Func<string> bodyadditionalDatatwitter = null, [WorkflowExpression] Func<int> bodyadditionalDatatwitterFollowers = null, [WorkflowExpression] Func<string> bodyadditionalDatalinkedin = null, [WorkflowExpression] Func<string> bodyadditionalDatagithub = null, [WorkflowExpression] Func<string> bodyadditionalDatafacebook = null)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodywelcomeEmail, nameof(bodywelcomeEmail), required: false);
            SourceExpression.Validate(bodyadditionalDataname, nameof(bodyadditionalDataname), required: false);
            SourceExpression.Validate(bodyadditionalDatalocation, nameof(bodyadditionalDatalocation), required: false);
            SourceExpression.Validate(bodyadditionalDatatitle, nameof(bodyadditionalDatatitle), required: false);
            SourceExpression.Validate(bodyadditionalDatacompany, nameof(bodyadditionalDatacompany), required: false);
            SourceExpression.Validate(bodyadditionalDatacompanySize, nameof(bodyadditionalDatacompanySize), required: false);
            SourceExpression.Validate(bodyadditionalDataindustry, nameof(bodyadditionalDataindustry), required: false);
            SourceExpression.Validate(bodyadditionalDatatwitter, nameof(bodyadditionalDatatwitter), required: false);
            SourceExpression.Validate(bodyadditionalDatatwitterFollowers, nameof(bodyadditionalDatatwitterFollowers), required: false);
            SourceExpression.Validate(bodyadditionalDatalinkedin, nameof(bodyadditionalDatalinkedin), required: false);
            SourceExpression.Validate(bodyadditionalDatagithub, nameof(bodyadditionalDatagithub), required: false);
            SourceExpression.Validate(bodyadditionalDatafacebook, nameof(bodyadditionalDatafacebook), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscriber/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodywelcomeEmail != null)
                {
                    body["welcomeEmail"] = SourceExpressionConverter.ConvertToken(bodywelcomeEmail);
                    bodypropCount++;
                }

                var additionalDataObject = new JObject();
                var additionalDataObjectpropCount = 0;
                if (bodyadditionalDataname != null)
                {
                    additionalDataObject["name"] = SourceExpressionConverter.ConvertToken(bodyadditionalDataname);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatalocation != null)
                {
                    additionalDataObject["location"] = SourceExpressionConverter.ConvertToken(bodyadditionalDatalocation);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatatitle != null)
                {
                    additionalDataObject["title"] = SourceExpressionConverter.ConvertToken(bodyadditionalDatatitle);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatacompany != null)
                {
                    additionalDataObject["company"] = SourceExpressionConverter.ConvertToken(bodyadditionalDatacompany);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatacompanySize != null)
                {
                    additionalDataObject["companySize"] = SourceExpressionConverter.ConvertToken(bodyadditionalDatacompanySize);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDataindustry != null)
                {
                    additionalDataObject["industry"] = SourceExpressionConverter.ConvertToken(bodyadditionalDataindustry);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatatwitter != null)
                {
                    additionalDataObject["twitter"] = SourceExpressionConverter.ConvertToken(bodyadditionalDatatwitter);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatatwitterFollowers != null)
                {
                    additionalDataObject["twitterFollowers"] = SourceExpressionConverter.ConvertToken(bodyadditionalDatatwitterFollowers);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatalinkedin != null)
                {
                    additionalDataObject["linkedin"] = SourceExpressionConverter.ConvertToken(bodyadditionalDatalinkedin);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatagithub != null)
                {
                    additionalDataObject["github"] = SourceExpressionConverter.ConvertToken(bodyadditionalDatagithub);
                    additionalDataObjectpropCount++;
                }

                if (bodyadditionalDatafacebook != null)
                {
                    additionalDataObject["facebook"] = SourceExpressionConverter.ConvertToken(bodyadditionalDatafacebook);
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
                return callPayload;
            }

            return new ApiConnectionAction<SubscriberPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<SubscriberRemovePostResponse> SubscriberRemove([WorkflowExpression] Func<string> email)
        {
            SourceExpression.Validate(email, nameof(email), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscriber/remove";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                return callPayload;
            }

            return new ApiConnectionAction<SubscriberRemovePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostsGetPostResponse> PostsGet([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<int> bodyoffset = null, [WorkflowExpression] Func<int> bodylimit = null)
        {
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            SourceExpression.Validate(bodyoffset, nameof(bodyoffset), required: false);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                if (bodyoffset != null)
                {
                    if (bodyoffset != null)
                    {
                        body["offset"] = SourceExpressionConverter.ConvertToken(bodyoffset);
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
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostsGetPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostGetPostResponse> PostGet([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/post/get/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PostGetPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<PostDraftPostResponse> PostDraft([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyhtml, [WorkflowExpression] Func<string> bodysubtitle = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodyhtml, nameof(bodyhtml), required: true);
            SourceExpression.Validate(bodysubtitle, nameof(bodysubtitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/post/draft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodysubtitle != null)
                {
                    body["subtitle"] = SourceExpressionConverter.ConvertToken(bodysubtitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["html"] = SourceExpressionConverter.ConvertToken(bodyhtml);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostDraftPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<ProjectGetPostResponse> ProjectGet([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/project/get/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectGetPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<IdeaCreatePostResponse> IdeaCreate([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodysuggestedBy, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodykeyword = null, [WorkflowExpression] Func<string[]> bodylabels = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodysuggestedBy, nameof(bodysuggestedBy), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodykeyword, nameof(bodykeyword), required: false);
            SourceExpression.Validate(bodylabels, nameof(bodylabels), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/idea/new";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["suggestedBy"] = SourceExpressionConverter.ConvertToken(bodysuggestedBy);
                if (bodykeyword != null)
                {
                    body["keyword"] = SourceExpressionConverter.ConvertToken(bodykeyword);
                    bodypropCount++;
                }

                if (bodylabels != null)
                {
                    body["labels"] = SourceExpressionConverter.ConvertToken(bodylabels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IdeaCreatePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "letterdrop")]
        public IBodyWorkflowAction<IdeaAssignPostResponse> IdeaAssign([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyassignTo, [WorkflowExpression] Func<string> bodypublishOn, [WorkflowExpression] Func<string[]> bodyapprovers = null)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyassignTo, nameof(bodyassignTo), required: true);
            SourceExpression.Validate(bodypublishOn, nameof(bodypublishOn), required: true);
            SourceExpression.Validate(bodyapprovers, nameof(bodyapprovers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/idea/assign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["assignTo"] = SourceExpressionConverter.ConvertToken(bodyassignTo);
                bodypropCount++;
                body["publishOn"] = SourceExpressionConverter.ConvertToken(bodypublishOn);
                if (bodyapprovers != null)
                {
                    body["approvers"] = SourceExpressionConverter.ConvertToken(bodyapprovers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IdeaAssignPostResponse>(BuildSourceInput);
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