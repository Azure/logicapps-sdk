//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wordpress
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WordpressActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordpress")]
        public IBodyWorkflowAction<SiteStatsModel> SiteStats(Expression<Func<string>> siteId)
        {
            var apiCallPath = String.Format("/sites/{0}/stats", ExpressionConverter.ConvertWithUrlEncoding(siteId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fields"] = Convert.ToString("stats");
            return new ApiConnectionAction<SiteStatsModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordpress")]
        public IBodyWorkflowAction<PostModel> GetPost(Expression<Func<string>> siteId, Expression<Func<string>> postId)
        {
            var apiCallPath = String.Format("/sites/{0}/posts/{1}", ExpressionConverter.ConvertWithUrlEncoding(siteId, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PostModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordpress")]
        public IBodyWorkflowAction<PostModel> CreatePost(Expression<Func<string>> siteId, Expression<Func<string>> posttitle = null, Expression<Func<string>> postcontent = null, Expression<Func<poststatusInput>> poststatus = null, Expression<Func<string>> posttags = null)
        {
            var apiCallPath = String.Format("/sites/{0}/posts/new", ExpressionConverter.ConvertWithUrlEncoding(siteId, 1));
            var apiCallHttpMethod = "post";
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

            if (poststatus != null)
            {
                post["status"] = ExpressionConverter.ConvertO(poststatus);
                postpropCount++;
            }

            if (posttags != null)
            {
                post["tags"] = ExpressionConverter.ConvertO(posttags);
                postpropCount++;
            }

            if (postpropCount > 0)
            {
                callPayload.Body = post;
            }

            return new ApiConnectionAction<PostModel>(callPayload);
        }
    }

    public class WordpressTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListPostsResponse> OnTriggerNewPost(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/me/posts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListPostsResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class SiteStatsModel
    {
        [JsonProperty("visitors_today")]
        public int VisitorsToday { get; set; }

        [JsonProperty("visitors_yesterday")]
        public int VisitorsYesterday { get; set; }

        [JsonProperty("visitors")]
        public int Visitors { get; set; }

        [JsonProperty("views_today")]
        public int ViewToday { get; set; }

        [JsonProperty("views_yesterday")]
        public int ViewsYesterday { get; set; }

        [JsonProperty("views_best_day")]
        public string ViewsBestDay { get; set; }

        [JsonProperty("views_best_day_total")]
        public int ViewsBestDayTotal { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }

        [JsonProperty("comments")]
        public int Comments { get; set; }

        [JsonProperty("posts")]
        public int Posts { get; set; }

        [JsonProperty("followers_blog")]
        public int FollowersBlog { get; set; }

        [JsonProperty("followers_comments")]
        public int FollowersComments { get; set; }

        [JsonProperty("comments_per_month")]
        public int CommentsPerMonth { get; set; }

        [JsonProperty("comments_most_active_recent_day")]
        public string CommentsMostActiveRecentDay { get; set; }

        [JsonProperty("comments_most_active_time")]
        public string CommentsMostActiveTime { get; set; }

        [JsonProperty("comments_spam")]
        public int CommentsSpam { get; set; }

        [JsonProperty("categories")]
        public int Categories { get; set; }

        [JsonProperty("tags")]
        public int Tags { get; set; }

        [JsonProperty("shares")]
        public int Shares { get; set; }

        [JsonProperty("shares_twitter")]
        public int SharesTwitter { get; set; }

        [JsonProperty("shares_facebook")]
        public int SharesFacebook { get; set; }

        [JsonProperty("shares_press-this")]
        public int SharesPressThis { get; set; }
    }

    public class PostModel
    {
        public int ID { get; set; }

        [JsonProperty("site_ID")]
        public int SiteID { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
        public string URL { get; set; }

        [JsonProperty("short_URL")]
        public string ShortURL { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("sticky")]
        public bool Sticky { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("parent")]
        public JToken Parent { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("likes_enabled")]
        public bool LikesEnabled { get; set; }

        [JsonProperty("sharing_enabled")]
        public bool SharingEnabled { get; set; }

        [JsonProperty("like_count")]
        public int LikeCount { get; set; }

        [JsonProperty("i_like")]
        public bool ILike { get; set; }

        [JsonProperty("is_reblogged")]
        public bool IsRebloggled { get; set; }

        [JsonProperty("is_following")]
        public bool IsFollowing { get; set; }

        [JsonProperty("global_ID")]
        public string GlobalID { get; set; }

        [JsonProperty("featured_image")]
        public string FeaturedImage { get; set; }

        [JsonProperty("post_thumbnail")]
        public JToken PostThumbnail { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("geo")]
        public bool Geo { get; set; }
    }

    public enum poststatusInput
    {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "publish")]
        Publish,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "future")]
        Future,
        [EnumMember(Value = "auto-draft")]
        AutoDraft
    }

    public class ListPostsResponse
    {
        [JsonProperty("posts")]
        public PostResponse[] Posts { get; set; }
    }

    public class PostResponse
    {
        public int ID { get; set; }

        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty("site_ID")]
        public int SiteID { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
        public string URL { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("like_count")]
        public int LikeCount { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wordpress;

    public partial class WorkflowManagedActions
    {
        public WordpressActions Wordpress(string connectionId) => new WordpressActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WordpressTriggers Wordpress(string connectionId) => new WordpressTriggers(connectionId);
    }
}