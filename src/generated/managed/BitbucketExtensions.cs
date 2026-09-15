//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bitbucket
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BitbucketActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<IssueResponse> CreateIssue(Expression<Func<string>> account, Expression<Func<string>> slug, Expression<Func<string>> bodyissueTitle, Expression<Func<bodyissueTypeInput>> bodyissueType, Expression<Func<bodypriorityInput>> bodypriority, Expression<Func<string>> bodycontentdescription = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycomponentcomponent = null, Expression<Func<string>> bodymilestonemilestone = null, Expression<Func<string>> bodyversionversion = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/2.0/repositories/{0}/{1}/issues", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodyissueTitle);
            var contentObject = new JObject();
            var contentObjectpropCount = 0;
            if (bodycontentdescription != null)
            {
                contentObject["raw"] = CSharpExpressionConverter.ConvertToken(bodycontentdescription);
                contentObjectpropCount++;
            }

            if (contentObjectpropCount > 0)
            {
                body["content"] = contentObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["kind"] = CSharpExpressionConverter.Convert(bodyissueType);
            bodypropCount++;
            body["priority"] = CSharpExpressionConverter.Convert(bodypriority);
            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            var componentObject = new JObject();
            var componentObjectpropCount = 0;
            if (bodycomponentcomponent != null)
            {
                componentObject["name"] = CSharpExpressionConverter.ConvertToken(bodycomponentcomponent);
                componentObjectpropCount++;
            }

            if (componentObjectpropCount > 0)
            {
                body["component"] = componentObject;
                bodypropCount++;
            }

            var milestoneObject = new JObject();
            var milestoneObjectpropCount = 0;
            if (bodymilestonemilestone != null)
            {
                milestoneObject["name"] = CSharpExpressionConverter.ConvertToken(bodymilestonemilestone);
                milestoneObjectpropCount++;
            }

            if (milestoneObjectpropCount > 0)
            {
                body["milestone"] = milestoneObject;
                bodypropCount++;
            }

            var versionObject = new JObject();
            var versionObjectpropCount = 0;
            if (bodyversionversion != null)
            {
                versionObject["name"] = CSharpExpressionConverter.ConvertToken(bodyversionversion);
                versionObjectpropCount++;
            }

            if (versionObjectpropCount > 0)
            {
                body["version"] = versionObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IssueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<IssueResponse> GetIssueById(Expression<Func<string>> account, Expression<Func<string>> slug, Expression<Func<string>> issueId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/2.0/repositories/{0}/{1}/issues/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(issueId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IssueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<ApprovePullRequestResponse> ApprovePullRequest(Expression<Func<string>> account, Expression<Func<string>> slug, Expression<Func<string>> pullrequestId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/2.0/repositories/{0}/{1}/pullrequests/{2}/approve", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(pullrequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ApprovePullRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<DeclineOrMergePullRequestResponse> DeclinePullRequest(Expression<Func<string>> account, Expression<Func<string>> slug, Expression<Func<string>> pullrequestId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/2.0/repositories/{0}/{1}/pullrequests/{2}/decline", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(pullrequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeclineOrMergePullRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<DeclineOrMergePullRequestResponse> MergePullRequest(Expression<Func<string>> account, Expression<Func<string>> slug, Expression<Func<string>> pullrequestId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/2.0/repositories/{0}/{1}/pullrequests/{2}/merge", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(pullrequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeclineOrMergePullRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        public IBodyWorkflowAction<UserResponse> GetUserById(Expression<Func<string>> userId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/2.0/users/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserResponse>(callPayload);
        }
    }

    public class BitbucketTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListRepositoriesResponse> OnNewRepo(Expression<Func<string>> account, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/repository_created_trigger/2.0/repositories/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListRepositoriesResponse>(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CreateHookIssueCreated(Expression<Func<string>> account, Expression<Func<string>> slug, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/issue_created_webhook/2.0/repositories/{0}/{1}/hooks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CreateHookIssueUpdated(Expression<Func<string>> account, Expression<Func<string>> slug, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/issue_updated_webhook/2.0/repositories/{0}/{1}/hooks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CreateHookPullRequestApproved(Expression<Func<string>> account, Expression<Func<string>> slug, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/pullrequest_approved_webhook/2.0/repositories/{0}/{1}/hooks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CreateHookPullRequestCreated(Expression<Func<string>> account, Expression<Func<string>> slug, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/pullrequest_created_webhook/2.0/repositories/{0}/{1}/hooks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CreateHookPullRequestDeclined(Expression<Func<string>> account, Expression<Func<string>> slug, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/pullrequest_declined_webhook/2.0/repositories/{0}/{1}/hooks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CreateHookPullRequestMerged(Expression<Func<string>> account, Expression<Func<string>> slug, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/pullrequest_merged_webhook/2.0/repositories/{0}/{1}/hooks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CreateHookRepositoryPush(Expression<Func<string>> account, Expression<Func<string>> slug, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/repository_push_webhook/2.0/repositories/{0}/{1}/hooks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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

    public enum bodyissueTypeInput
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

    public enum bodypriorityInput
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

    public enum bodystatusInput
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