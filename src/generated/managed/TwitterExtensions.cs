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
        public IBodyWorkflowAction<TweetModel[]> UserTimeline([WorkflowExpression] Func<string> userName, [WorkflowExpression] Func<int> maxResults = null)
        {
            SourceExpression.Validate(userName, nameof(userName), required: true);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/usertimeline";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = SourceExpressionConverter.ConvertO(userName);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<TweetModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetModel[]> HomeTimeline([WorkflowExpression] Func<int> maxResults = null)
        {
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hometimeline";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<TweetModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetModel[]> SearchTweet([WorkflowExpression] Func<string> searchQuery, [WorkflowExpression] Func<int> maxResults = null, [WorkflowExpression] Func<string> sinceId = null)
        {
            SourceExpression.Validate(searchQuery, nameof(searchQuery), required: true);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            SourceExpression.Validate(sinceId, nameof(sinceId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/searchtweets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchQuery"] = SourceExpressionConverter.ConvertO(searchQuery);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                if (sinceId != null)
                    callPayload.Queries["sinceId"] = SourceExpressionConverter.ConvertO(sinceId);
                return callPayload;
            }

            return new ApiConnectionAction<TweetModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[]> Followers([WorkflowExpression] Func<string> userName, [WorkflowExpression] Func<int> maxResults = null)
        {
            SourceExpression.Validate(userName, nameof(userName), required: true);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/followers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = SourceExpressionConverter.ConvertO(userName);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<UserDetailsModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[]> MyFollowers([WorkflowExpression] Func<int> maxResults = null)
        {
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/myfollowers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<UserDetailsModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[]> Following([WorkflowExpression] Func<string> userName, [WorkflowExpression] Func<int> maxResults = null)
        {
            SourceExpression.Validate(userName, nameof(userName), required: true);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/friends";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = SourceExpressionConverter.ConvertO(userName);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<UserDetailsModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel[]> MyFollowing([WorkflowExpression] Func<int> maxResults = null)
        {
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/myfriends";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<UserDetailsModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<UserDetailsModel> User([WorkflowExpression] Func<string> userName)
        {
            SourceExpression.Validate(userName, nameof(userName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/user";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = SourceExpressionConverter.ConvertO(userName);
                return callPayload;
            }

            return new ApiConnectionAction<UserDetailsModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetResponseModel> Tweet([WorkflowExpression] Func<string> tweetText = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(tweetText, nameof(tweetText), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/posttweet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tweetText != null)
                    callPayload.Queries["tweetText"] = SourceExpressionConverter.ConvertO(tweetText);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<TweetResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twitter")]
        public IBodyWorkflowAction<TweetResponseModel> Retweet([WorkflowExpression] Func<string> tweetId, [WorkflowExpression] Func<bool> trimUser = null)
        {
            SourceExpression.Validate(tweetId, nameof(tweetId), required: true);
            SourceExpression.Validate(trimUser, nameof(trimUser), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/retweet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tweetId"] = SourceExpressionConverter.ConvertO(tweetId);
                callPayload.Queries["trimUser"] = Convert.ToString(false);
                if (trimUser != null)
                    callPayload.Queries["trimUser"] = SourceExpressionConverter.ConvertO(trimUser);
                return callPayload;
            }

            return new ApiConnectionAction<TweetResponseModel>(BuildSourceInput);
        }
    }

    public class TwitterTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerBatchResponseTweetModel> OnNewTweet([WorkflowExpression] Func<string> searchQuery, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(searchQuery, nameof(searchQuery), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/onnewtweet";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchQuery"] = SourceExpressionConverter.ConvertO(searchQuery);
                return callPayload;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseTweetModel>(BuildSourceInput, triggerName, recurrence);
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