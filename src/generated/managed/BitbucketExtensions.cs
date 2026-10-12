//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bitbucket
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BitbucketActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        [WorkflowExpressionFactory(nameof(__BuildCreateIssue))]
        public IBodyWorkflowAction<IssueResponse> CreateIssue([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> bodyissueTitle, [WorkflowExpression] Func<bodyissueTypeInput> bodyissueType, [WorkflowExpression] Func<bodypriorityInput> bodypriority, [WorkflowExpression] Func<string> bodycontentdescription = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodycomponentcomponent = null, [WorkflowExpression] Func<string> bodymilestonemilestone = null, [WorkflowExpression] Func<string> bodyversionversion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IssueResponse> __BuildCreateIssue(WorkflowExpression<string> account, WorkflowExpression<string> slug, WorkflowExpression<string> bodyissueTitle, WorkflowExpression<bodyissueTypeInput> bodyissueType, WorkflowExpression<bodypriorityInput> bodypriority, WorkflowExpression<string> bodycontentdescription = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodycomponentcomponent = null, WorkflowExpression<string> bodymilestonemilestone = null, WorkflowExpression<string> bodyversionversion = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(bodyissueTitle, nameof(bodyissueTitle), required: true);
            WorkflowExpression.Validate(bodyissueType, nameof(bodyissueType), required: true);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: true);
            WorkflowExpression.Validate(bodycontentdescription, nameof(bodycontentdescription), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycomponentcomponent, nameof(bodycomponentcomponent), required: false);
            WorkflowExpression.Validate(bodymilestonemilestone, nameof(bodymilestonemilestone), required: false);
            WorkflowExpression.Validate(bodyversionversion, nameof(bodyversionversion), required: false);
            return new DeferredBodyAction<IssueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/2.0/repositories/{0}/{1}/issues", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodyissueTitle);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (bodycontentdescription != null)
                {
                    contentObject["raw"] = ExpressionConverter.ConvertO(bodycontentdescription);
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["kind"] = ExpressionConverter.ConvertO(bodyissueType);
                bodypropCount++;
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var componentObject = new JObject();
                var componentObjectpropCount = 0;
                if (bodycomponentcomponent != null)
                {
                    componentObject["name"] = ExpressionConverter.ConvertO(bodycomponentcomponent);
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
                    milestoneObject["name"] = ExpressionConverter.ConvertO(bodymilestonemilestone);
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
                    versionObject["name"] = ExpressionConverter.ConvertO(bodyversionversion);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        [WorkflowExpressionFactory(nameof(__BuildGetIssueById))]
        public IBodyWorkflowAction<IssueResponse> GetIssueById([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> issueId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IssueResponse> __BuildGetIssueById(WorkflowExpression<string> account, WorkflowExpression<string> slug, WorkflowExpression<string> issueId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(issueId, nameof(issueId), required: true);
            return new DeferredBodyAction<IssueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/2.0/repositories/{0}/{1}/issues/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(issueId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IssueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        [WorkflowExpressionFactory(nameof(__BuildApprovePullRequest))]
        public IBodyWorkflowAction<ApprovePullRequestResponse> ApprovePullRequest([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> pullrequestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApprovePullRequestResponse> __BuildApprovePullRequest(WorkflowExpression<string> account, WorkflowExpression<string> slug, WorkflowExpression<string> pullrequestId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(pullrequestId, nameof(pullrequestId), required: true);
            return new DeferredBodyAction<ApprovePullRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/2.0/repositories/{0}/{1}/pullrequests/{2}/approve", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(pullrequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApprovePullRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        [WorkflowExpressionFactory(nameof(__BuildDeclinePullRequest))]
        public IBodyWorkflowAction<DeclineOrMergePullRequestResponse> DeclinePullRequest([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> pullrequestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeclineOrMergePullRequestResponse> __BuildDeclinePullRequest(WorkflowExpression<string> account, WorkflowExpression<string> slug, WorkflowExpression<string> pullrequestId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(pullrequestId, nameof(pullrequestId), required: true);
            return new DeferredBodyAction<DeclineOrMergePullRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/2.0/repositories/{0}/{1}/pullrequests/{2}/decline", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(pullrequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeclineOrMergePullRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        [WorkflowExpressionFactory(nameof(__BuildMergePullRequest))]
        public IBodyWorkflowAction<DeclineOrMergePullRequestResponse> MergePullRequest([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> pullrequestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeclineOrMergePullRequestResponse> __BuildMergePullRequest(WorkflowExpression<string> account, WorkflowExpression<string> slug, WorkflowExpression<string> pullrequestId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(pullrequestId, nameof(pullrequestId), required: true);
            return new DeferredBodyAction<DeclineOrMergePullRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/2.0/repositories/{0}/{1}/pullrequests/{2}/merge", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(pullrequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeclineOrMergePullRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitbucket")]
        [WorkflowExpressionFactory(nameof(__BuildGetUserById))]
        public IBodyWorkflowAction<UserResponse> GetUserById([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserResponse> __BuildGetUserById(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/2.0/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }
    }

    public class BitbucketTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewRepo))]
        public IBodyWorkflowTrigger<ListRepositoriesResponse> OnNewRepo([WorkflowExpression] Func<string> account,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ListRepositoriesResponse> __BuildOnNewRepo(WorkflowExpression<string> account,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            return new DeferredBodyTrigger<ListRepositoriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/repository_created_trigger/2.0/repositories/{0}", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListRepositoriesResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateHookIssueCreated))]
        public IWorkflowTrigger CreateHookIssueCreated([WorkflowExpression] Func<string> account,[WorkflowExpression] Func<string> slug,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateHookIssueCreated(WorkflowExpression<string> account,WorkflowExpression<string> slug,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/issue_created_webhook/2.0/repositories/{0}/{1}/hooks", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateHookIssueUpdated))]
        public IWorkflowTrigger CreateHookIssueUpdated([WorkflowExpression] Func<string> account,[WorkflowExpression] Func<string> slug,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateHookIssueUpdated(WorkflowExpression<string> account,WorkflowExpression<string> slug,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/issue_updated_webhook/2.0/repositories/{0}/{1}/hooks", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateHookPullRequestApproved))]
        public IWorkflowTrigger CreateHookPullRequestApproved([WorkflowExpression] Func<string> account,[WorkflowExpression] Func<string> slug,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateHookPullRequestApproved(WorkflowExpression<string> account,WorkflowExpression<string> slug,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pullrequest_approved_webhook/2.0/repositories/{0}/{1}/hooks", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateHookPullRequestCreated))]
        public IWorkflowTrigger CreateHookPullRequestCreated([WorkflowExpression] Func<string> account,[WorkflowExpression] Func<string> slug,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateHookPullRequestCreated(WorkflowExpression<string> account,WorkflowExpression<string> slug,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pullrequest_created_webhook/2.0/repositories/{0}/{1}/hooks", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateHookPullRequestDeclined))]
        public IWorkflowTrigger CreateHookPullRequestDeclined([WorkflowExpression] Func<string> account,[WorkflowExpression] Func<string> slug,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateHookPullRequestDeclined(WorkflowExpression<string> account,WorkflowExpression<string> slug,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pullrequest_declined_webhook/2.0/repositories/{0}/{1}/hooks", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateHookPullRequestMerged))]
        public IWorkflowTrigger CreateHookPullRequestMerged([WorkflowExpression] Func<string> account,[WorkflowExpression] Func<string> slug,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateHookPullRequestMerged(WorkflowExpression<string> account,WorkflowExpression<string> slug,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pullrequest_merged_webhook/2.0/repositories/{0}/{1}/hooks", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateHookRepositoryPush))]
        public IWorkflowTrigger CreateHookRepositoryPush([WorkflowExpression] Func<string> account,[WorkflowExpression] Func<string> slug,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateHookRepositoryPush(WorkflowExpression<string> account,WorkflowExpression<string> slug,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/repository_push_webhook/2.0/repositories/{0}/{1}/hooks", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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