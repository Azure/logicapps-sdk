//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Twitter
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TwitterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetModel[]> UserTimeline(Expression<Func<string>> userName, Expression<Func<int>> maxResults = null)
        {
            var apiCallPath = "/usertimeline";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userName"] = CSharpExpressionConverter.ConvertO(userName);
            callPayload.Queries["maxResults"] = Convert.ToString(20);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = CSharpExpressionConverter.ConvertO(maxResults);
            return new ApiConnectionAction<TweetModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetModel[]> HomeTimeline(Expression<Func<int>> maxResults = null)
        {
            var apiCallPath = "/hometimeline";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maxResults"] = Convert.ToString(20);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = CSharpExpressionConverter.ConvertO(maxResults);
            return new ApiConnectionAction<TweetModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetModel[]> SearchTweet(Expression<Func<string>> searchQuery, Expression<Func<int>> maxResults = null, Expression<Func<string>> sinceId = null)
        {
            var apiCallPath = "/searchtweets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["searchQuery"] = CSharpExpressionConverter.ConvertO(searchQuery);
            callPayload.Queries["maxResults"] = Convert.ToString(20);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = CSharpExpressionConverter.ConvertO(maxResults);
            if (sinceId != null)
                callPayload.Queries["sinceId"] = CSharpExpressionConverter.ConvertO(sinceId);
            return new ApiConnectionAction<TweetModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[]> Followers(Expression<Func<string>> userName, Expression<Func<int>> maxResults = null)
        {
            var apiCallPath = "/followers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userName"] = CSharpExpressionConverter.ConvertO(userName);
            callPayload.Queries["maxResults"] = Convert.ToString(20);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = CSharpExpressionConverter.ConvertO(maxResults);
            return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[]> MyFollowers(Expression<Func<int>> maxResults = null)
        {
            var apiCallPath = "/myfollowers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maxResults"] = Convert.ToString(20);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = CSharpExpressionConverter.ConvertO(maxResults);
            return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[]> Following(Expression<Func<string>> userName, Expression<Func<int>> maxResults = null)
        {
            var apiCallPath = "/friends";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userName"] = CSharpExpressionConverter.ConvertO(userName);
            callPayload.Queries["maxResults"] = Convert.ToString(20);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = CSharpExpressionConverter.ConvertO(maxResults);
            return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[]> MyFollowing(Expression<Func<int>> maxResults = null)
        {
            var apiCallPath = "/myfriends";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maxResults"] = Convert.ToString(20);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = CSharpExpressionConverter.ConvertO(maxResults);
            return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel> User(Expression<Func<string>> userName)
        {
            var apiCallPath = "/user";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userName"] = CSharpExpressionConverter.ConvertO(userName);
            return new ApiConnectionAction<UserDetailsModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetResponseModel> Tweet(Expression<Func<string>> tweetText = null, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/posttweet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tweetText != null)
                callPayload.Queries["tweetText"] = CSharpExpressionConverter.ConvertO(tweetText);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<TweetResponseModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetResponseModel> Retweet(Expression<Func<string>> tweetId, Expression<Func<bool>> trimUser = null)
        {
            var apiCallPath = "/retweet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tweetId"] = CSharpExpressionConverter.ConvertO(tweetId);
            callPayload.Queries["trimUser"] = Convert.ToString(false);
            if (trimUser != null)
                callPayload.Queries["trimUser"] = CSharpExpressionConverter.ConvertO(trimUser);
            return new ApiConnectionAction<TweetResponseModel>(callPayload);
        }
    }

    public class TwitterTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerBatchResponseTweetModel> OnNewTweet(Expression<Func<string>> searchQuery, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/onnewtweet";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["searchQuery"] = CSharpExpressionConverter.ConvertO(searchQuery);
            return new ApiConnectionTrigger<TriggerBatchResponseTweetModel>(callPayload, triggerName, recurrence);
        }
    }

    public class TweetModel
    {
        public string TweetText { get; set; }
        public string TweetId { get; set; }

        [JsonProperty("CreatedAtIso")]
        public string CreatedAt { get; set; }
        public int RetweetCount { get; set; }
        public string TweetedBy { get; set; }
        public string[] MediaUrls { get; set; }

        [JsonProperty("TweetLanguageCode")]
        public string TweetLanguage { get; set; }

        [JsonProperty("TweetInReplyToUserId")]
        public string InReplyToUserId { get; set; }
        public bool Favorited { get; set; }
        public UserMentionsModel[] UserMentions { get; set; }
        public OriginalTweetModel OriginalTweet { get; set; }
        public UserDetailsModel UserDetails { get; set; }
    }

    public class UserMentionsModel
    {
        [JsonProperty("Id")]
        public int MentionedUserId { get; set; }

        [JsonProperty("FullName")]
        public string MentionedUserFullName { get; set; }

        [JsonProperty("UserName")]
        public string MentionedUserName { get; set; }
    }

    public class OriginalTweetModel
    {
        [JsonProperty("TweetText")]
        public string OriginalTweetText { get; set; }

        [JsonProperty("TweetId")]
        public string OriginalTweetId { get; set; }

        [JsonProperty("CreatedAtIso")]
        public string OriginalTweetCreatedAt { get; set; }

        [JsonProperty("RetweetCount")]
        public int OriginalTweetRetweetCount { get; set; }

        [JsonProperty("TweetedBy")]
        public string OriginalTweetTweetedBy { get; set; }

        [JsonProperty("MediaUrls")]
        public string[] OriginalTweetMediaUrls { get; set; }

        [JsonProperty("TweetLanguageCode")]
        public string OriginalTweetLanguage { get; set; }

        [JsonProperty("TweetInReplyToUserId")]
        public string OriginalTweetInReplyToUserId { get; set; }

        [JsonProperty("Favorited")]
        public bool OriginalTweetFavorited { get; set; }

        [JsonProperty("UserMentions")]
        public OriginalTweetUserMentionsModel[] OriginalTweetUserMentions { get; set; }
        public OriginalTweetUserDetailsModel UserDetails { get; set; }
    }

    public class OriginalTweetUserMentionsModel
    {
        [JsonProperty("Id")]
        public int OriginalTweetMentionedUserId { get; set; }

        [JsonProperty("FullName")]
        public string OriginalTweetMentionedUserFullName { get; set; }

        [JsonProperty("UserName")]
        public string OriginalTweetMentionedUserName { get; set; }
    }

    public class OriginalTweetUserDetailsModel
    {
        [JsonProperty("FullName")]
        public string OriginalTweetUserFullName { get; set; }

        [JsonProperty("Location")]
        public string OriginalTweetUserLocation { get; set; }

        [JsonProperty("Id")]
        public int OriginalTweetUserId { get; set; }

        [JsonProperty("UserName")]
        public string OriginalTweetUserName { get; set; }

        [JsonProperty("FollowersCount")]
        public int OriginalTweetUserFollowersCount { get; set; }

        [JsonProperty("Description")]
        public string OriginalTweetUserDescription { get; set; }

        [JsonProperty("StatusesCount")]
        public int OriginalTweetUserStatusesCount { get; set; }

        [JsonProperty("FriendsCount")]
        public int OriginalTweetUserFriendsCount { get; set; }

        [JsonProperty("FavouritesCount")]
        public int OriginalTweetUserFavouritesCount { get; set; }

        [JsonProperty("ProfileImageUrl")]
        public string OriginalTweetUserProfileImageUrl { get; set; }
    }

    public class UserDetailsModel
    {
        [JsonProperty("FullName")]
        public string Name { get; set; }
        public string Location { get; set; }

        [JsonProperty("Id")]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int FollowersCount { get; set; }
        public string Description { get; set; }
        public int StatusesCount { get; set; }
        public int FriendsCount { get; set; }
        public int FavouritesCount { get; set; }
        public string ProfileImageUrl { get; set; }
    }

    public class TweetResponseModel
    {
        public string TweetId { get; set; }
    }

    public class TriggerBatchResponseTweetModel
    {
        [JsonProperty("value")]
        public TweetModel[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Twitter;

    public partial class WorkflowManagedActions
    {
        public TwitterActions Twitter(string connectionId) => new TwitterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TwitterTriggers Twitter(string connectionId) => new TwitterTriggers(connectionId);
    }
}