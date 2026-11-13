//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bitbucket
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BitbucketActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<IssueResponse, ApiConnectionActionConfiguration> CreateIssue(Expression<Func<string>> account, Expression<Func<string>> slug, Expression<Func<CreateIssueBodyInput>> body)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<IssueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/2.0/repositories/{0}/{1}/issues", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IssueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<IssueResponse, ApiConnectionActionConfiguration> GetIssueById(Expression<Func<string>> account, Expression<Func<string>> slug, Expression<Func<string>> issueId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            var __workflow_issueId = WorkflowExpression.Compile(issueId, nameof(issueId), required: true);
            return new DeferredBodyAction<IssueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/2.0/repositories/{0}/{1}/issues/{2}", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1), __workflow_issueId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IssueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<ApprovePullRequestResponse, ApiConnectionActionConfiguration> ApprovePullRequest(Expression<Func<string>> account, Expression<Func<string>> slug, Expression<Func<string>> pullrequestId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            var __workflow_pullrequestId = WorkflowExpression.Compile(pullrequestId, nameof(pullrequestId), required: true);
            return new DeferredBodyAction<ApprovePullRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/2.0/repositories/{0}/{1}/pullrequests/{2}/approve", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1), __workflow_pullrequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApprovePullRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<DeclineOrMergePullRequestResponse, ApiConnectionActionConfiguration> DeclinePullRequest(Expression<Func<string>> account, Expression<Func<string>> slug, Expression<Func<string>> pullrequestId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            var __workflow_pullrequestId = WorkflowExpression.Compile(pullrequestId, nameof(pullrequestId), required: true);
            return new DeferredBodyAction<DeclineOrMergePullRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/2.0/repositories/{0}/{1}/pullrequests/{2}/decline", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1), __workflow_pullrequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeclineOrMergePullRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<DeclineOrMergePullRequestResponse, ApiConnectionActionConfiguration> MergePullRequest(Expression<Func<string>> account, Expression<Func<string>> slug, Expression<Func<string>> pullrequestId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            var __workflow_pullrequestId = WorkflowExpression.Compile(pullrequestId, nameof(pullrequestId), required: true);
            return new DeferredBodyAction<DeclineOrMergePullRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/2.0/repositories/{0}/{1}/pullrequests/{2}/merge", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1), __workflow_pullrequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeclineOrMergePullRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<UserResponse, ApiConnectionActionConfiguration> GetUserById(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/2.0/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }
    }

    public class BitbucketTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListRepositoriesResponse, ApiConnectionPollingTriggerConfiguration> OnNewRepo(Expression<Func<string>> account)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            return new DeferredBodyTrigger<ListRepositoriesResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repository_created_trigger/2.0/repositories/{0}", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionPollingTrigger<ListRepositoriesResponse>(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateHookIssueCreated(Expression<Func<string>> account, Expression<Func<string>> slug)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/issue_created_webhook/2.0/repositories/{0}/{1}/hooks", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateHookIssueCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateHookIssueUpdated(Expression<Func<string>> account, Expression<Func<string>> slug)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/issue_updated_webhook/2.0/repositories/{0}/{1}/hooks", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateHookIssueCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateHookPullRequestApproved(Expression<Func<string>> account, Expression<Func<string>> slug)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pullrequest_approved_webhook/2.0/repositories/{0}/{1}/hooks", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateHookIssueCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateHookPullRequestCreated(Expression<Func<string>> account, Expression<Func<string>> slug)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pullrequest_created_webhook/2.0/repositories/{0}/{1}/hooks", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateHookIssueCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateHookPullRequestDeclined(Expression<Func<string>> account, Expression<Func<string>> slug)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pullrequest_declined_webhook/2.0/repositories/{0}/{1}/hooks", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateHookIssueCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateHookPullRequestMerged(Expression<Func<string>> account, Expression<Func<string>> slug)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pullrequest_merged_webhook/2.0/repositories/{0}/{1}/hooks", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateHookIssueCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateHookRepositoryPush(Expression<Func<string>> account, Expression<Func<string>> slug)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repository_push_webhook/2.0/repositories/{0}/{1}/hooks", __workflow_account.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateHookIssueCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class IssueResponse
    {
        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("repository")]
        public IssueResponseRepositoryType Repository { get; set; }

        [JsonProperty("reporter")]
        public IssueResponseReporterType Reporter { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("component")]
        public IssueResponseComponentType Component { get; set; }

        [JsonProperty("votes")]
        public int Votes { get; set; }

        [JsonProperty("watches")]
        public int Watches { get; set; }

        [JsonProperty("content")]
        public IssueResponseDescriptionType Description { get; set; }

        [JsonProperty("assignee")]
        public string Assignee { get; set; }

        [JsonProperty("state")]
        public string Status { get; set; }

        [JsonProperty("version")]
        public IssueResponseVersionType Version { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("milestone")]
        public IssueResponseMilestoneType Milestone { get; set; }

        [JsonProperty("updated_on")]
        public string UpdatedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int IssueId { get; set; }
    }

    public class IssueResponseRepositoryType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }
    }

    public class IssueResponseReporterType
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }
    }

    public class IssueResponseComponentType
    {
        [JsonProperty("name")]
        public string Component { get; set; }
    }

    public class IssueResponseDescriptionType
    {
        [JsonProperty("raw")]
        public string Text { get; set; }

        [JsonProperty("markup")]
        public string Markup { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }
    }

    public class IssueResponseVersionType
    {
        [JsonProperty("name")]
        public string Version { get; set; }
    }

    public class IssueResponseMilestoneType
    {
        [JsonProperty("name")]
        public string Milestone { get; set; }
    }

    public class CreateIssueBodyInput
    {
        public CreateIssueBodyInput(string issueTitle, BodyInputIssueTypeType issueType, BodyInputPriorityType priority)
        {
            this.IssueTitle = issueTitle;
            this.IssueType = issueType;
            this.Priority = priority;
        }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IssueTitle { get; set; }

        [JsonProperty("content")]
        public BodyInputContentType Content { get; set; }

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputIssueTypeType IssueType { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPriorityType Priority { get; set; }

        [JsonProperty("status")]
        public BodyInputStatusType? Status { get; set; }

        [JsonProperty("component")]
        public BodyInputComponentType Component { get; set; }

        [JsonProperty("milestone")]
        public BodyInputMilestoneType Milestone { get; set; }

        [JsonProperty("version")]
        public BodyInputVersionType Version { get; set; }
    }

    public class BodyInputContentType
    {
        [JsonProperty("raw")]
        public string Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputIssueTypeType
    {
        [EnumMember(Value = "bug")]
        Bug,
        [EnumMember(Value = "enhancement")]
        Enhancement,
        [EnumMember(Value = "proposal")]
        Proposal,
        [EnumMember(Value = "task")]
        TaskObject
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPriorityType
    {
        [EnumMember(Value = "trivial")]
        Trivial,
        [EnumMember(Value = "minor")]
        Minor,
        [EnumMember(Value = "major")]
        Major,
        [EnumMember(Value = "critical")]
        Critical,
        [EnumMember(Value = "blocker")]
        Blocker
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputStatusType
    {
        [EnumMember(Value = "new")]
        New,
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "resolved")]
        Resolved,
        [EnumMember(Value = "on hold")]
        OnHold,
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "duplicate")]
        Duplicate,
        [EnumMember(Value = "wontfix")]
        Wontfix
    }

    public class BodyInputComponentType
    {
        [JsonProperty("name")]
        public string Component { get; set; }
    }

    public class BodyInputMilestoneType
    {
        [JsonProperty("name")]
        public string Milestone { get; set; }
    }

    public class BodyInputVersionType
    {
        [JsonProperty("name")]
        public string Version { get; set; }
    }

    public class ApprovePullRequestResponse
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user")]
        public ApprovePullRequestResponseApproverType Approver { get; set; }

        [JsonProperty("approved")]
        public bool IsApproved { get; set; }
    }

    public class ApprovePullRequestResponseApproverType
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("display_name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }
    }

    public class DeclineOrMergePullRequestResponse
    {
        [JsonProperty("merge_commit")]
        public DeclineOrMergePullRequestResponseMergeCommitType MergeCommit { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("destination")]
        public DeclineOrMergePullRequestResponseDestinationType Destination { get; set; }

        [JsonProperty("state")]
        public string Status { get; set; }

        [JsonProperty("closed_by")]
        public DeclineOrMergePullRequestResponseClosedByType ClosedBy { get; set; }

        [JsonProperty("source")]
        public DeclineOrMergePullRequestResponseSourceType Source { get; set; }

        [JsonProperty("author")]
        public DeclineOrMergePullRequestResponseAuthorType Author { get; set; }

        [JsonProperty("created_on")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("updated_on")]
        public string UpdatedOn { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("task_count")]
        public int TaskCount { get; set; }
    }

    public class DeclineOrMergePullRequestResponseMergeCommitType
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class DeclineOrMergePullRequestResponseDestinationType
    {
        [JsonProperty("branch")]
        public DeclineOrMergePullRequestResponseDestinationTypeBranchType Branch { get; set; }

        [JsonProperty("commit")]
        public DeclineOrMergePullRequestResponseDestinationTypeCommitType Commit { get; set; }

        [JsonProperty("repository")]
        public DeclineOrMergePullRequestResponseDestinationTypeRepositoryType Repository { get; set; }
    }

    public class DeclineOrMergePullRequestResponseDestinationTypeBranchType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DeclineOrMergePullRequestResponseDestinationTypeCommitType
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class DeclineOrMergePullRequestResponseDestinationTypeRepositoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DeclineOrMergePullRequestResponseClosedByType
    {
        [JsonProperty("username")]
        public string ClosedByUsername { get; set; }

        [JsonProperty("display_name")]
        public string ClosedByName { get; set; }

        [JsonProperty("type")]
        public string UserType { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }
    }

    public class DeclineOrMergePullRequestResponseSourceType
    {
        [JsonProperty("branch")]
        public DeclineOrMergePullRequestResponseSourceTypeBranchType Branch { get; set; }

        [JsonProperty("commit")]
        public DeclineOrMergePullRequestResponseSourceTypeCommitType Commit { get; set; }

        [JsonProperty("repository")]
        public DeclineOrMergePullRequestResponseSourceTypeRepositoryType Repository { get; set; }
    }

    public class DeclineOrMergePullRequestResponseSourceTypeBranchType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DeclineOrMergePullRequestResponseSourceTypeCommitType
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class DeclineOrMergePullRequestResponseSourceTypeRepositoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DeclineOrMergePullRequestResponseAuthorType
    {
        [JsonProperty("display_name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }
    }

    public class UserResponse
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }
    }

    public class ListRepositoriesResponse
    {
        [JsonProperty("values")]
        public ListRepositoriesResponseValuesTypeItem[] Values { get; set; }
    }

    public class ListRepositoriesResponseValuesTypeItem
    {
        [JsonProperty("scm")]
        public string SCM { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("has_wiki")]
        public bool HasWiki { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fork_policy")]
        public string ForkPolicy { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("created_on")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("has_issues")]
        public bool HasIssueTracker { get; set; }

        [JsonProperty("owner")]
        public ListRepositoriesResponseValuesTypeItemOwnerType Owner { get; set; }

        [JsonProperty("updated_on")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ListRepositoriesResponseValuesTypeItemOwnerType
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("display_name")]
        public string Name { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }
    }

    public class CreateHookIssueCreatedBodyInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bitbucket;

    public partial class WorkflowManagedActions
    {
        public BitbucketActions Bitbucket(string connectionId) => new BitbucketActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BitbucketTriggers Bitbucket(string connectionId) => new BitbucketTriggers(connectionId);
    }
}