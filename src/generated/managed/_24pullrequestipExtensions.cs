//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._24pullrequestip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _24pullrequestipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "24pullrequestip")]
        public IBodyWorkflowAction<GetUsersResponseItem[]> GetUsers(Expression<Func<int>> page = null)
        {
            var apiCallPath = "/users.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            return new ApiConnectionAction<GetUsersResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "24pullrequestip")]
        public IBodyWorkflowAction<GetProjectsResponseItem[]> GetProjects()
        {
            var apiCallPath = "/projects.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetProjectsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "24pullrequestip")]
        public IBodyWorkflowAction<GetPullRequestsResponseItem[]> GetPullRequests()
        {
            var apiCallPath = "/pull_requests.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPullRequestsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "24pullrequestip")]
        public IBodyWorkflowAction<GetContributionsInfoResponse> GetContributionsInfo()
        {
            var apiCallPath = "/pull_requests/meta.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetContributionsInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "24pullrequestip")]
        public IBodyWorkflowAction<GetAllOrganisationsResponseItem[]> GetAllOrganisations()
        {
            var apiCallPath = "/organisations.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllOrganisationsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "24pullrequestip")]
        public IBodyWorkflowAction<GetUserResponse> GetUser(Expression<Func<string>> name)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/users/{0}.json", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "24pullrequestip")]
        public IBodyWorkflowAction<GetSpecificOrganisationResponse> GetSpecificOrganisation(Expression<Func<string>> organisation)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/organisations/{0}.json", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisation, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSpecificOrganisationResponse>(callPayload);
        }
    }

    public class _24pullrequestipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetUsersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("github_profile")]
        public string GithubProfile { get; set; }

        [JsonProperty("twitter_profile")]
        public string TwitterProfile { get; set; }

        [JsonProperty("contributions_count")]
        public int ContributionsCount { get; set; }

        [JsonProperty("organisations")]
        public GetUsersResponseItemOrganisationsTypeItem[] Organisations { get; set; }

        [JsonProperty("pull_requests")]
        public GetUsersResponseItemPullRequestsTypeItem[] PullRequests { get; set; }
    }

    public class GetUsersResponseItemOrganisationsTypeItem
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetUsersResponseItemPullRequestsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("issue_url")]
        public string IssueUrl { get; set; }

        [JsonProperty("repo_name")]
        public string RepoName { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GetProjectsResponseItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("github_url")]
        public string GithubUrl { get; set; }

        [JsonProperty("main_language")]
        public string MainLanguage { get; set; }
    }

    public class GetPullRequestsResponseItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("issue_url")]
        public string IssueUrl { get; set; }

        [JsonProperty("repo_name")]
        public string RepoName { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("user")]
        public GetPullRequestsResponseItemUserType User { get; set; }
    }

    public class GetPullRequestsResponseItemUserType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("github_profile")]
        public string GithubProfile { get; set; }

        [JsonProperty("twitter_profile")]
        public string TwitterProfile { get; set; }

        [JsonProperty("contributions_count")]
        public int ContributionsCount { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetContributionsInfoResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class GetAllOrganisationsResponseItem
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("users")]
        public GetAllOrganisationsResponseItemUsersTypeItem[] Users { get; set; }
    }

    public class GetAllOrganisationsResponseItemUsersTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("github_profile")]
        public string GithubProfile { get; set; }

        [JsonProperty("twitter_profile")]
        public string TwitterProfile { get; set; }

        [JsonProperty("contributions_count")]
        public int ContributionsCount { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("organisations")]
        public GetAllOrganisationsResponseItemUsersTypeItemOrganisationsTypeItem[] Organisations { get; set; }
    }

    public class GetAllOrganisationsResponseItemUsersTypeItemOrganisationsTypeItem
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetUserResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("github_profile")]
        public string GithubProfile { get; set; }

        [JsonProperty("twitter_profile")]
        public string TwitterProfile { get; set; }

        [JsonProperty("contributions_count")]
        public int ContributionsCount { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("organisations")]
        public GetUserResponseOrganisationsTypeItem[] Organisations { get; set; }

        [JsonProperty("pull_requests")]
        public GetUserResponsePullRequestsTypeItem[] PullRequests { get; set; }
    }

    public class GetUserResponseOrganisationsTypeItem
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetUserResponsePullRequestsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("issue_url")]
        public string IssueUrl { get; set; }

        [JsonProperty("repo_name")]
        public string RepoName { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GetSpecificOrganisationResponse
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("users")]
        public GetSpecificOrganisationResponseUsersTypeItem[] Users { get; set; }
    }

    public class GetSpecificOrganisationResponseUsersTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("github_profile")]
        public string GithubProfile { get; set; }

        [JsonProperty("twitter_profile")]
        public string TwitterProfile { get; set; }

        [JsonProperty("contributions_count")]
        public int ContributionsCount { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("organisations")]
        public GetSpecificOrganisationResponseUsersTypeItemOrganisationsTypeItem[] Organisations { get; set; }
    }

    public class GetSpecificOrganisationResponseUsersTypeItemOrganisationsTypeItem
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._24pullrequestip;

    public partial class WorkflowManagedActions
    {
        public _24pullrequestipActions _24pullrequestip(string connectionId) => new _24pullrequestipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _24pullrequestipTriggers _24pullrequestip(string connectionId) => new _24pullrequestipTriggers(connectionId);
    }
}