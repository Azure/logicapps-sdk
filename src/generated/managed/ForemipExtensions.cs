//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Foremip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ForemipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foremip")]
        public IBodyWorkflowAction<Articles200Item[]> GetArticles(Expression<Func<int>> page, Expression<Func<int>> perPage, Expression<Func<string>> tag, Expression<Func<string>> tags = null, Expression<Func<string>> tagsExclude = null, Expression<Func<string>> username = null, Expression<Func<string>> state = null, Expression<Func<string>> top = null, Expression<Func<string>> collectionId = null)
        {
            var apiCallPath = "/api/articles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            callPayload.Queries["tag"] = CSharpExpressionConverter.ConvertO(tag);
            if (tags != null)
                callPayload.Queries["tags"] = CSharpExpressionConverter.ConvertO(tags);
            if (tagsExclude != null)
                callPayload.Queries["tags_exclude"] = CSharpExpressionConverter.ConvertO(tagsExclude);
            if (username != null)
                callPayload.Queries["username"] = CSharpExpressionConverter.ConvertO(username);
            callPayload.Queries["state"] = Convert.ToString("fresh");
            if (state != null)
                callPayload.Queries["state"] = CSharpExpressionConverter.ConvertO(state);
            callPayload.Queries["top"] = Convert.ToString("2");
            if (top != null)
                callPayload.Queries["top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Queries["collection_id"] = Convert.ToString("99");
            if (collectionId != null)
                callPayload.Queries["collection_id"] = CSharpExpressionConverter.ConvertO(collectionId);
            return new ApiConnectionAction<Articles200Item[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foremip")]
        public IBodyWorkflowAction<User> GetUser(Expression<Func<string>> userId, Expression<Func<string>> url)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/users/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["url"] = CSharpExpressionConverter.ConvertO(url);
            return new ApiConnectionAction<User>(callPayload);
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