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
        public IBodyWorkflowAction<BaseGist[]> GistsList([WorkflowExpression] Func<string> since = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                callPayload.Queries["per_page"] = Convert.ToString(30);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<BaseGist[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistSimple> GistsCreate([WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyPublic = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                var filesObject = new JObject();
                var filesObjectpropCount = 0;
                if (filesObjectpropCount > 0)
                {
                    body["files"] = filesObject;
                    bodypropCount++;
                }

                if (bodyPublic != null)
                {
                    if (bodyPublic != null)
                    {
                        body["public"] = SourceExpressionConverter.ConvertToken(bodyPublic);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["public"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GistSimple>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<BaseGist[]> GistsListPublic([WorkflowExpression] Func<string> since = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gists/public";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                callPayload.Queries["per_page"] = Convert.ToString(30);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<BaseGist[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<BaseGist[]> GistsListStarred([WorkflowExpression] Func<string> since = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gists/starred";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                callPayload.Queries["per_page"] = Convert.ToString(30);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<BaseGist[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistSimple> GistsGet([WorkflowExpression] Func<string> gistId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GistSimple>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IWorkflowAction GistsDelete([WorkflowExpression] Func<string> gistId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistSimple> GistsUpdate([WorkflowExpression] Func<string> gistId, [WorkflowExpression] Func<string> bodydescription)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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
                return callPayload;
            }

            return new ApiConnectionAction<GistSimple>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistComment[]> GistsListComments([WorkflowExpression] Func<string> gistId, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["per_page"] = Convert.ToString(30);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<GistComment[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistComment> GistsCreateComment([WorkflowExpression] Func<string> gistId, [WorkflowExpression] Func<string> bodybody)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GistComment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistComment> GistsGetComment([WorkflowExpression] Func<string> gistId, [WorkflowExpression] Func<int> commentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/comments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(commentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GistComment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IWorkflowAction GistsDeleteComment([WorkflowExpression] Func<string> gistId, [WorkflowExpression] Func<int> commentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/comments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(commentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistComment> GistsUpdateComment([WorkflowExpression] Func<string> gistId, [WorkflowExpression] Func<int> commentId, [WorkflowExpression] Func<string> bodybody)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/comments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(commentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GistComment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistCommit[]> GistsListCommits([WorkflowExpression] Func<string> gistId, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/commits", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["per_page"] = Convert.ToString(30);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<GistCommit[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistSimple[]> GistsListForks([WorkflowExpression] Func<string> gistId, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/forks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["per_page"] = Convert.ToString(30);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<GistSimple[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<BaseGist> GistsFork([WorkflowExpression] Func<string> gistId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/forks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BaseGist>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IWorkflowAction GistsCheckIsStarred([WorkflowExpression] Func<string> gistId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/star", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IWorkflowAction GistsUnstar([WorkflowExpression] Func<string> gistId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/star", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IWorkflowAction GistsStar([WorkflowExpression] Func<string> gistId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/star", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubgistsip")]
        public IBodyWorkflowAction<GistSimple> GistsGetRevision([WorkflowExpression] Func<string> gistId, [WorkflowExpression] Func<string> sha)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gists/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(gistId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sha, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GistSimple>(BuildSourceInput);
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