//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Foremip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ForemipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foremip")]
        [WorkflowExpressionFactory(nameof(__BuildGetArticles))]
        public IBodyWorkflowAction<Articles200Item[]> GetArticles([WorkflowExpression] Func<int> page, [WorkflowExpression] Func<int> perPage, [WorkflowExpression] Func<string> tag, [WorkflowExpression] Func<string> tags = null, [WorkflowExpression] Func<string> tagsExclude = null, [WorkflowExpression] Func<string> username = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> top = null, [WorkflowExpression] Func<string> collectionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Articles200Item[]> __BuildGetArticles(WorkflowValue<int> page, WorkflowValue<int> perPage, WorkflowValue<string> tag, WorkflowValue<string> tags = null, WorkflowValue<string> tagsExclude = null, WorkflowValue<string> username = null, WorkflowValue<string> state = null, WorkflowValue<string> top = null, WorkflowValue<string> collectionId = null)
        {
            WorkflowValue.Validate(page, nameof(page), required: true);
            WorkflowValue.Validate(perPage, nameof(perPage), required: true);
            WorkflowValue.Validate(tag, nameof(tag), required: true);
            WorkflowValue.Validate(tags, nameof(tags), required: false);
            WorkflowValue.Validate(tagsExclude, nameof(tagsExclude), required: false);
            WorkflowValue.Validate(username, nameof(username), required: false);
            WorkflowValue.Validate(state, nameof(state), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(collectionId, nameof(collectionId), required: false);
            return new DeferredBodyAction<Articles200Item[]>(() =>
            {
                var apiCallPath = "/api/articles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
                if (tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
                if (tagsExclude != null)
                    callPayload.Queries["tags_exclude"] = ExpressionConverter.Convert(tagsExclude);
                if (username != null)
                    callPayload.Queries["username"] = ExpressionConverter.Convert(username);
                callPayload.Queries["state"] = Convert.ToString("fresh");
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                callPayload.Queries["top"] = Convert.ToString("2");
                if (top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["collection_id"] = Convert.ToString("99");
                if (collectionId != null)
                    callPayload.Queries["collection_id"] = ExpressionConverter.Convert(collectionId);
                return new ApiConnectionAction<Articles200Item[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foremip")]
        [WorkflowExpressionFactory(nameof(__BuildGetUser))]
        public IBodyWorkflowAction<User> GetUser([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> url)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<User> __BuildGetUser(WorkflowValue<string> userId, WorkflowValue<string> url)
        {
            WorkflowValue.Validate(userId, nameof(userId), required: true);
            WorkflowValue.Validate(url, nameof(url), required: true);
            return new DeferredBodyAction<User>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                return new ApiConnectionAction<User>(callPayload);
            });
        }
    }

    public class ForemipTriggers([ConnectionName] string connectionId)
    {
    }

    public class Articles200Item
    {
        [JsonProperty("type_of")]
        public string ArticleType { get; set; }

        [JsonProperty("id")]
        public int ArticleID { get; set; }

        [JsonProperty("title")]
        public string ArticleTitle { get; set; }

        [JsonProperty("description")]
        public string ArticleDescription { get; set; }

        [JsonProperty("published")]
        public bool ArticlePublished { get; set; }

        [JsonProperty("published_at")]
        public string ArticlePublishedAt { get; set; }

        [JsonProperty("slug")]
        public string ArticleSLUG { get; set; }

        [JsonProperty("path")]
        public string ArticlePath { get; set; }

        [JsonProperty("url")]
        public string ArticleURL { get; set; }

        [JsonProperty("comments_count")]
        public int ArticleCommentsCount { get; set; }

        [JsonProperty("public_reactions_count")]
        public int ArticlePublicReactionsCount { get; set; }

        [JsonProperty("page_views_count")]
        public int ArticlePageViewsCount { get; set; }

        [JsonProperty("published_timestamp")]
        public string ArticlePublishedTimestamp { get; set; }

        [JsonProperty("body_markdown")]
        public string ArticleBodyMarkdown { get; set; }

        [JsonProperty("positive_reactions_count")]
        public int ArticlePositiveReactionsCount { get; set; }

        [JsonProperty("cover_image")]
        public string ArticleCoverImage { get; set; }

        [JsonProperty("tag_list")]
        public string[] ArticleTagList { get; set; }

        [JsonProperty("canonical_url")]
        public string ArticleCanonicalURL { get; set; }

        [JsonProperty("reading_time_minutes")]
        public int ArticleReadingTimeInMinutes { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("organization")]
        public Organization Organization { get; set; }
    }

    public class User
    {
        [JsonProperty("name")]
        public string UserName { get; set; }

        [JsonProperty("user_id")]
        public int UserID { get; set; }

        [JsonProperty("username")]
        public string UserUsername { get; set; }

        [JsonProperty("twitter_username")]
        public string UserTwitterUsername { get; set; }

        [JsonProperty("github_username")]
        public string UserGitHubUsername { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteURL { get; set; }

        [JsonProperty("profile_image")]
        public string OrganizationProfileImage { get; set; }

        [JsonProperty("profile_image_90")]
        public string UserProfileImage90x90 { get; set; }
    }

    public class Organization
    {
        [JsonProperty("name")]
        public string OrganizationName { get; set; }

        [JsonProperty("username")]
        public string OrganizationUsername { get; set; }

        [JsonProperty("slug")]
        public string OrganizationSLUG { get; set; }

        [JsonProperty("profile_image")]
        public string OrganizationProfileImage { get; set; }

        [JsonProperty("profile_image_90")]
        public string OrganizationProfileImage90x90 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Foremip;

    public partial class WorkflowManagedActions
    {
        public ForemipActions Foremip(string connectionId) => new ForemipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ForemipTriggers Foremip(string connectionId) => new ForemipTriggers(connectionId);
    }
}
