//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Githubgistsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GithubgistsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<BaseGist[]> GistsList(Expression<Func<string>> since = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/gists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            callPayload.Queries["per_page"] = Convert.ToString(30);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<BaseGist[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistSimple> GistsCreate(Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodypublic = null)
        {
            var apiCallPath = "/gists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            var filesObject = new JObject();
            var filesObjectpropCount = 0;
            if (filesObjectpropCount > 0)
            {
                body["files"] = filesObject;
                bodypropCount++;
            }

            if (bodypublic != null)
            {
                body["public"] = ExpressionConverter.ConvertO(bodypublic);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GistSimple>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<BaseGist[]> GistsListPublic(Expression<Func<string>> since = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/gists/public";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            callPayload.Queries["per_page"] = Convert.ToString(30);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<BaseGist[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<BaseGist[]> GistsListStarred(Expression<Func<string>> since = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/gists/starred";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            callPayload.Queries["per_page"] = Convert.ToString(30);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<BaseGist[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistSimple> GistsGet(Expression<Func<string>> gistId)
        {
            var apiCallPath = String.Format("/gists/{0}", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GistSimple>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IWorkflowAction GistsDelete(Expression<Func<string>> gistId)
        {
            var apiCallPath = String.Format("/gists/{0}", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistSimple> GistsUpdate(Expression<Func<string>> gistId, Expression<Func<string>> bodydescription)
        {
            var apiCallPath = String.Format("/gists/{0}", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            var filesObject = new JObject();
            var filesObjectpropCount = 0;
            if (filesObjectpropCount > 0)
            {
                body["files"] = filesObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GistSimple>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistComment[]> GistsListComments(Expression<Func<string>> gistId, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = String.Format("/gists/{0}/comments", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["per_page"] = Convert.ToString(30);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<GistComment[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistComment> GistsCreateComment(Expression<Func<string>> gistId, Expression<Func<string>> bodybody)
        {
            var apiCallPath = String.Format("/gists/{0}/comments", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["body"] = ExpressionConverter.ConvertO(bodybody);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GistComment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistComment> GistsGetComment(Expression<Func<string>> gistId, Expression<Func<int>> commentId)
        {
            var apiCallPath = String.Format("/gists/{0}/comments/{1}", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GistComment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IWorkflowAction GistsDeleteComment(Expression<Func<string>> gistId, Expression<Func<int>> commentId)
        {
            var apiCallPath = String.Format("/gists/{0}/comments/{1}", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistComment> GistsUpdateComment(Expression<Func<string>> gistId, Expression<Func<int>> commentId, Expression<Func<string>> bodybody)
        {
            var apiCallPath = String.Format("/gists/{0}/comments/{1}", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["body"] = ExpressionConverter.ConvertO(bodybody);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GistComment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistCommit[]> GistsListCommits(Expression<Func<string>> gistId, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = String.Format("/gists/{0}/commits", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["per_page"] = Convert.ToString(30);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<GistCommit[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistSimple[]> GistsListForks(Expression<Func<string>> gistId, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = String.Format("/gists/{0}/forks", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["per_page"] = Convert.ToString(30);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<GistSimple[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<BaseGist> GistsFork(Expression<Func<string>> gistId)
        {
            var apiCallPath = String.Format("/gists/{0}/forks", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BaseGist>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IWorkflowAction GistsCheckIsStarred(Expression<Func<string>> gistId)
        {
            var apiCallPath = String.Format("/gists/{0}/star", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IWorkflowAction GistsUnstar(Expression<Func<string>> gistId)
        {
            var apiCallPath = String.Format("/gists/{0}/star", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IWorkflowAction GistsStar(Expression<Func<string>> gistId)
        {
            var apiCallPath = String.Format("/gists/{0}/star", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistSimple> GistsGetRevision(Expression<Func<string>> gistId, Expression<Func<string>> sha)
        {
            var apiCallPath = String.Format("/gists/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(gistId, 1), ExpressionConverter.ConvertWithUrlEncoding(sha, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GistSimple>(callPayload);
        }
    }

    public class GithubgistsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class BaseGist
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("forks_url")]
        public string ForksUrl { get; set; }

        [JsonProperty("commits_url")]
        public string CommitsUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("git_pull_url")]
        public string GitPullUrl { get; set; }

        [JsonProperty("git_push_url")]
        public string GitPushUrl { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("files")]
        public JToken Files { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comments")]
        public int Comments { get; set; }

        [JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        [JsonProperty("owner")]
        public SimpleUser Owner { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }

        [JsonProperty("forks")]
        public JToken[] Forks { get; set; }

        [JsonProperty("history")]
        public JToken[] History { get; set; }
    }

    public class SimpleUser
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        public string FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        public string OrganizationsUrl { get; set; }

        [JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("starred_at")]
        public string StarredAt { get; set; }
    }

    public class GistSimple
    {
        [JsonProperty("forks")]
        public GistSimpleForksTypeItem[] Forks { get; set; }

        [JsonProperty("history")]
        public GistHistory[] History { get; set; }

        [JsonProperty("fork_of")]
        public GistSimpleForkOfType ForkOf { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("forks_url")]
        public string ForksUrl { get; set; }

        [JsonProperty("commits_url")]
        public string CommitsUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("git_pull_url")]
        public string GitPullUrl { get; set; }

        [JsonProperty("git_push_url")]
        public string GitPushUrl { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("files")]
        public JToken Files { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comments")]
        public int Comments { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        [JsonProperty("owner")]
        public SimpleUser Owner { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }
    }

    public class GistSimpleForksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("user")]
        public PublicUser User { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class PublicUser
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        public string FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        public string OrganizationsUrl { get; set; }

        [JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("blog")]
        public string Blog { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("hireable")]
        public bool Hireable { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("public_repos")]
        public int PublicRepos { get; set; }

        [JsonProperty("public_gists")]
        public int PublicGists { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("following")]
        public int Following { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("plan")]
        public PublicUserPlanType Plan { get; set; }

        [JsonProperty("suspended_at")]
        public string SuspendedAt { get; set; }

        [JsonProperty("private_gists")]
        public int PrivateGists { get; set; }

        [JsonProperty("total_private_repos")]
        public int TotalPrivateRepos { get; set; }

        [JsonProperty("owned_private_repos")]
        public int OwnedPrivateRepos { get; set; }

        [JsonProperty("disk_usage")]
        public int DiskUsage { get; set; }

        [JsonProperty("collaborators")]
        public int Collaborators { get; set; }
    }

    public class PublicUserPlanType
    {
        [JsonProperty("collaborators")]
        public int Collaborators { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("space")]
        public int Space { get; set; }

        [JsonProperty("private_repos")]
        public int PrivateRepos { get; set; }
    }

    public class GistHistory
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("committed_at")]
        public string CommittedAt { get; set; }

        [JsonProperty("change_status")]
        public GistHistoryChangeStatusType ChangeStatus { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GistHistoryChangeStatusType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("additions")]
        public int Additions { get; set; }

        [JsonProperty("deletions")]
        public int Deletions { get; set; }
    }

    public class GistSimpleForkOfType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("forks_url")]
        public string ForksUrl { get; set; }

        [JsonProperty("commits_url")]
        public string CommitsUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("git_pull_url")]
        public string GitPullUrl { get; set; }

        [JsonProperty("git_push_url")]
        public string GitPushUrl { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("files")]
        public JToken Files { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comments")]
        public int Comments { get; set; }

        [JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        [JsonProperty("owner")]
        public NullableSimpleUser Owner { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }

        [JsonProperty("forks")]
        public JToken[] Forks { get; set; }

        [JsonProperty("history")]
        public JToken[] History { get; set; }
    }

    public class NullableSimpleUser
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        public string FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        public string OrganizationsUrl { get; set; }

        [JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("starred_at")]
        public string StarredAt { get; set; }
    }

    public class GistComment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("author_association")]
        public AuthorAssociation AuthorAssociation { get; set; }
    }

    public enum AuthorAssociation
    {
        COLLABORATOR,
        CONTRIBUTOR,
        [EnumMember(Value = "FIRST_TIMER")]
        FIRSTTIMER,
        [EnumMember(Value = "FIRST_TIME_CONTRIBUTOR")]
        FIRSTTIMECONTRIBUTOR,
        MANNEQUIN,
        MEMBER,
        NONE,
        OWNER
    }

    public class GistCommit
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("change_status")]
        public GistCommitChangeStatusType ChangeStatus { get; set; }

        [JsonProperty("committed_at")]
        public string CommittedAt { get; set; }
    }

    public class GistCommitChangeStatusType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("additions")]
        public int Additions { get; set; }

        [JsonProperty("deletions")]
        public int Deletions { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Githubgistsip;

    public partial class WorkflowManagedActions
    {
        public GithubgistsipActions Githubgistsip(string connectionId) => new GithubgistsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GithubgistsipTriggers Githubgistsip(string connectionId) => new GithubgistsipTriggers(connectionId);
    }
}