//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Twitter
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TwitterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetModel[], ApiConnectionActionConfiguration> UserTimeline(Expression<Func<string>> userName, Expression<Func<int>> maxResults = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<TweetModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/usertimeline";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<TweetModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetModel[], ApiConnectionActionConfiguration> HomeTimeline(Expression<Func<int>> maxResults = null)
        {
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<TweetModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hometimeline";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<TweetModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetModel[], ApiConnectionActionConfiguration> SearchTweet(Expression<Func<string>> searchQuery, Expression<Func<int>> maxResults = null, Expression<Func<string>> sinceId = null)
        {
            var __workflow_searchQuery = WorkflowExpression.Compile(searchQuery, nameof(searchQuery), required: true);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            var __workflow_sinceId = WorkflowExpression.Compile(sinceId, nameof(sinceId), required: false);
            return new DeferredBodyAction<TweetModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/searchtweets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchQuery"] = ExpressionConverter.Convert(__workflow_searchQuery);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                if (__workflow_sinceId != null)
                    callPayload.Queries["sinceId"] = ExpressionConverter.Convert(__workflow_sinceId);
                return new ApiConnectionAction<TweetModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[], ApiConnectionActionConfiguration> Followers(Expression<Func<string>> userName, Expression<Func<int>> maxResults = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<UserDetailsModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/followers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[], ApiConnectionActionConfiguration> MyFollowers(Expression<Func<int>> maxResults = null)
        {
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<UserDetailsModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/myfollowers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[], ApiConnectionActionConfiguration> Following(Expression<Func<string>> userName, Expression<Func<int>> maxResults = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<UserDetailsModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/friends";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[], ApiConnectionActionConfiguration> MyFollowing(Expression<Func<int>> maxResults = null)
        {
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<UserDetailsModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/myfriends";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel, ApiConnectionActionConfiguration> User(Expression<Func<string>> userName)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            return new DeferredBodyAction<UserDetailsModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/user";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<UserDetailsModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetResponseModel, ApiConnectionActionConfiguration> Tweet(Expression<Func<string>> tweetText = null, Expression<Func<string>> body = null)
        {
            var __workflow_tweetText = WorkflowExpression.Compile(tweetText, nameof(tweetText), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TweetResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/posttweet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tweetText != null)
                    callPayload.Queries["tweetText"] = ExpressionConverter.Convert(__workflow_tweetText);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TweetResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetResponseModel, ApiConnectionActionConfiguration> Retweet(Expression<Func<string>> tweetId, Expression<Func<bool>> trimUser = null)
        {
            var __workflow_tweetId = WorkflowExpression.Compile(tweetId, nameof(tweetId), required: true);
            var __workflow_trimUser = WorkflowExpression.Compile(trimUser, nameof(trimUser), required: false);
            return new DeferredBodyAction<TweetResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/retweet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tweetId"] = ExpressionConverter.Convert(__workflow_tweetId);
                callPayload.Queries["trimUser"] = Convert.ToString(false);
                if (__workflow_trimUser != null)
                    callPayload.Queries["trimUser"] = ExpressionConverter.Convert(__workflow_trimUser);
                return new ApiConnectionAction<TweetResponseModel>(callPayload);
            });
        }
    }

    public class TwitterTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerBatchResponseTweetModel, ApiConnectionTriggerConfiguration> OnNewTweet(Expression<Func<string>> searchQuery, FlowRecurrence recurrence = null)
        {
            var __workflow_searchQuery = WorkflowExpression.Compile(searchQuery, nameof(searchQuery), required: true);
            return new DeferredBodyTrigger<TriggerBatchResponseTweetModel, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/onnewtweet";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchQuery"] = ExpressionConverter.Convert(__workflow_searchQuery);
                return new ApiConnectionTrigger<TriggerBatchResponseTweetModel>(callPayload, recurrence: recurrence);
            });
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
