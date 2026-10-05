//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Twitter
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TwitterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        [WorkflowExpressionFactory(nameof(__BuildUserTimeline))]
        public IBodyWorkflowAction<TweetModel[]> UserTimeline([WorkflowExpression] Func<string> userName, [WorkflowExpression] Func<int> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TweetModel[]> __BuildUserTimeline(WorkflowValue<string> userName, WorkflowValue<int> maxResults = null)
        {
            WorkflowValue.Validate(userName, nameof(userName), required: true);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<TweetModel[]>(() =>
            {
                var apiCallPath = "/usertimeline";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = ExpressionConverter.Convert(userName);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
                return new ApiConnectionAction<TweetModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        [WorkflowExpressionFactory(nameof(__BuildHomeTimeline))]
        public IBodyWorkflowAction<TweetModel[]> HomeTimeline([WorkflowExpression] Func<int> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TweetModel[]> __BuildHomeTimeline(WorkflowValue<int> maxResults = null)
        {
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<TweetModel[]>(() =>
            {
                var apiCallPath = "/hometimeline";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
                return new ApiConnectionAction<TweetModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        [WorkflowExpressionFactory(nameof(__BuildSearchTweet))]
        public IBodyWorkflowAction<TweetModel[]> SearchTweet([WorkflowExpression] Func<string> searchQuery, [WorkflowExpression] Func<int> maxResults = null, [WorkflowExpression] Func<string> sinceId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TweetModel[]> __BuildSearchTweet(WorkflowValue<string> searchQuery, WorkflowValue<int> maxResults = null, WorkflowValue<string> sinceId = null)
        {
            WorkflowValue.Validate(searchQuery, nameof(searchQuery), required: true);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            WorkflowValue.Validate(sinceId, nameof(sinceId), required: false);
            return new DeferredBodyAction<TweetModel[]>(() =>
            {
                var apiCallPath = "/searchtweets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchQuery"] = ExpressionConverter.Convert(searchQuery);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
                if (sinceId != null)
                    callPayload.Queries["sinceId"] = ExpressionConverter.Convert(sinceId);
                return new ApiConnectionAction<TweetModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        [WorkflowExpressionFactory(nameof(__BuildFollowers))]
        public IBodyWorkflowAction<UserDetailsModel[]> Followers([WorkflowExpression] Func<string> userName, [WorkflowExpression] Func<int> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserDetailsModel[]> __BuildFollowers(WorkflowValue<string> userName, WorkflowValue<int> maxResults = null)
        {
            WorkflowValue.Validate(userName, nameof(userName), required: true);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<UserDetailsModel[]>(() =>
            {
                var apiCallPath = "/followers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = ExpressionConverter.Convert(userName);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
                return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        [WorkflowExpressionFactory(nameof(__BuildMyFollowers))]
        public IBodyWorkflowAction<UserDetailsModel[]> MyFollowers([WorkflowExpression] Func<int> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserDetailsModel[]> __BuildMyFollowers(WorkflowValue<int> maxResults = null)
        {
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<UserDetailsModel[]>(() =>
            {
                var apiCallPath = "/myfollowers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
                return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        [WorkflowExpressionFactory(nameof(__BuildFollowing))]
        public IBodyWorkflowAction<UserDetailsModel[]> Following([WorkflowExpression] Func<string> userName, [WorkflowExpression] Func<int> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserDetailsModel[]> __BuildFollowing(WorkflowValue<string> userName, WorkflowValue<int> maxResults = null)
        {
            WorkflowValue.Validate(userName, nameof(userName), required: true);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<UserDetailsModel[]>(() =>
            {
                var apiCallPath = "/friends";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = ExpressionConverter.Convert(userName);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
                return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        [WorkflowExpressionFactory(nameof(__BuildMyFollowing))]
        public IBodyWorkflowAction<UserDetailsModel[]> MyFollowing([WorkflowExpression] Func<int> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserDetailsModel[]> __BuildMyFollowing(WorkflowValue<int> maxResults = null)
        {
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<UserDetailsModel[]>(() =>
            {
                var apiCallPath = "/myfriends";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
                return new ApiConnectionAction<UserDetailsModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        [WorkflowExpressionFactory(nameof(__BuildUser))]
        public IBodyWorkflowAction<UserDetailsModel> User([WorkflowExpression] Func<string> userName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserDetailsModel> __BuildUser(WorkflowValue<string> userName)
        {
            WorkflowValue.Validate(userName, nameof(userName), required: true);
            return new DeferredBodyAction<UserDetailsModel>(() =>
            {
                var apiCallPath = "/user";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = ExpressionConverter.Convert(userName);
                return new ApiConnectionAction<UserDetailsModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        [WorkflowExpressionFactory(nameof(__BuildTweet))]
        public IBodyWorkflowAction<TweetResponseModel> Tweet([WorkflowExpression] Func<string> tweetText = null, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TweetResponseModel> __BuildTweet(WorkflowValue<string> tweetText = null, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(tweetText, nameof(tweetText), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<TweetResponseModel>(() =>
            {
                var apiCallPath = "/posttweet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tweetText != null)
                    callPayload.Queries["tweetText"] = ExpressionConverter.Convert(tweetText);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<TweetResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        [WorkflowExpressionFactory(nameof(__BuildRetweet))]
        public IBodyWorkflowAction<TweetResponseModel> Retweet([WorkflowExpression] Func<string> tweetId, [WorkflowExpression] Func<bool> trimUser = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TweetResponseModel> __BuildRetweet(WorkflowValue<string> tweetId, WorkflowValue<bool> trimUser = null)
        {
            WorkflowValue.Validate(tweetId, nameof(tweetId), required: true);
            WorkflowValue.Validate(trimUser, nameof(trimUser), required: false);
            return new DeferredBodyAction<TweetResponseModel>(() =>
            {
                var apiCallPath = "/retweet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tweetId"] = ExpressionConverter.Convert(tweetId);
                callPayload.Queries["trimUser"] = Convert.ToString(false);
                if (trimUser != null)
                    callPayload.Queries["trimUser"] = ExpressionConverter.Convert(trimUser);
                return new ApiConnectionAction<TweetResponseModel>(callPayload);
            });
        }
    }

    public class TwitterTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnNewTweet))]
        public IBodyWorkflowTrigger<TriggerBatchResponseTweetModel> OnNewTweet([WorkflowExpression] Func<string> searchQuery, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerBatchResponseTweetModel> __BuildOnNewTweet(WorkflowValue<string> searchQuery, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(searchQuery, nameof(searchQuery), required: true);
            return new DeferredBodyTrigger<TriggerBatchResponseTweetModel>(() =>
            {
                var apiCallPath = "/onnewtweet";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchQuery"] = ExpressionConverter.Convert(searchQuery);
                return new ApiConnectionTrigger<TriggerBatchResponseTweetModel>(callPayload, triggerName, recurrence);
            }, triggerName);
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
