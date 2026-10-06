//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Redmine
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RedmineActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        [WorkflowExpressionFactory(nameof(__BuildGetIssue))]
        public IBodyWorkflowAction<GetIssueResponse> GetIssue([WorkflowExpression] Func<string> issueId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIssueResponse> __BuildGetIssue(WorkflowExpression<string> issueId)
        {
            WorkflowExpression.Validate(issueId, nameof(issueId), required: true);
            return new DeferredBodyAction<GetIssueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/issues/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(issueId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetIssueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateIssue))]
        public IBodyWorkflowAction<string> UpdateIssue([WorkflowExpression] Func<string> issueId, [WorkflowExpression] Func<string> issueissuepriority = null, [WorkflowExpression] Func<issueissuetrackerInput> issueissuetracker = null, [WorkflowExpression] Func<issueissuestatusInput> issueissuestatus = null, [WorkflowExpression] Func<string> issueissuesubject = null, [WorkflowExpression] Func<string> issueissuedescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUpdateIssue(WorkflowExpression<string> issueId, WorkflowExpression<string> issueissuepriority = null, WorkflowExpression<issueissuetrackerInput> issueissuetracker = null, WorkflowExpression<issueissuestatusInput> issueissuestatus = null, WorkflowExpression<string> issueissuesubject = null, WorkflowExpression<string> issueissuedescription = null)
        {
            WorkflowExpression.Validate(issueId, nameof(issueId), required: true);
            WorkflowExpression.Validate(issueissuepriority, nameof(issueissuepriority), required: false);
            WorkflowExpression.Validate(issueissuetracker, nameof(issueissuetracker), required: false);
            WorkflowExpression.Validate(issueissuestatus, nameof(issueissuestatus), required: false);
            WorkflowExpression.Validate(issueissuesubject, nameof(issueissuesubject), required: false);
            WorkflowExpression.Validate(issueissuedescription, nameof(issueissuedescription), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/issues/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(issueId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var issue = new JObject();
                var issuepropCount = 0;
                var issueObject = new JObject();
                var issueObjectpropCount = 0;
                if (issueissuepriority != null)
                {
                    issueObject["priority_id"] = ExpressionConverter.ConvertO(issueissuepriority);
                    issueObjectpropCount++;
                }

                if (issueissuetracker != null)
                {
                    issueObject["tracker_id"] = ExpressionConverter.ConvertO(issueissuetracker);
                    issueObjectpropCount++;
                }

                if (issueissuestatus != null)
                {
                    issueObject["status_id"] = ExpressionConverter.ConvertO(issueissuestatus);
                    issueObjectpropCount++;
                }

                if (issueissuesubject != null)
                {
                    issueObject["subject"] = ExpressionConverter.ConvertO(issueissuesubject);
                    issueObjectpropCount++;
                }

                if (issueissuedescription != null)
                {
                    issueObject["description"] = ExpressionConverter.ConvertO(issueissuedescription);
                    issueObjectpropCount++;
                }

                if (issueObjectpropCount > 0)
                {
                    issue["issue"] = issueObject;
                    issuepropCount++;
                }

                if (issuepropCount > 0)
                {
                    callPayload.Body = issue;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        [WorkflowExpressionFactory(nameof(__BuildGetProject))]
        public IBodyWorkflowAction<GetProjectResponse> GetProject([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectResponse> __BuildGetProject(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers()
        {
            var apiCallPath = "/users.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        [WorkflowExpressionFactory(nameof(__BuildGetUser))]
        public IBodyWorkflowAction<GetUserResponse> GetUser([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUserResponse> __BuildGetUser(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<GetUserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserResponse>(callPayload);
            });
        }
    }

    public class RedmineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListProjectsResponse> OnNewProject(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/new_project_trigger/projects.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListProjectsResponse>(callPayload, recurrence: recurrence);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewIssue))]
        public IBodyWorkflowTrigger<ListIssuesResponse> OnNewIssue([WorkflowExpression] Func<string> projectId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ListIssuesResponse> __BuildOnNewIssue(WorkflowExpression<string> projectId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyTrigger<ListIssuesResponse>(() =>
            {
                var apiCallPath = "/new_issue_trigger/issues.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
                return new ApiConnectionTrigger<ListIssuesResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedIssue))]
        public IBodyWorkflowTrigger<ListIssuesResponse> OnUpdatedIssue([WorkflowExpression] Func<string> projectId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ListIssuesResponse> __BuildOnUpdatedIssue(WorkflowExpression<string> projectId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyTrigger<ListIssuesResponse>(() =>
            {
                var apiCallPath = "/resolved_issue_trigger/issues.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
                return new ApiConnectionTrigger<ListIssuesResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetIssueResponse
    {
        [JsonProperty("id")]
        public int IssueId { get; set; }

        [JsonProperty("project")]
        public GetIssueResponseProjectType Project { get; set; }

        [JsonProperty("tracker")]
        public GetIssueResponseTrackerType Tracker { get; set; }

        [JsonProperty("status")]
        public GetIssueResponseStatusType Status { get; set; }

        [JsonProperty("priority")]
        public GetIssueResponsePriorityType Priority { get; set; }

        [JsonProperty("author")]
        public GetIssueResponseAuthorType Author { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("done_ratio")]
        public int DoneRatio { get; set; }

        [JsonProperty("estimated_hours")]
        public double EstimatedHours { get; set; }

        [JsonProperty("total_estimated_hours")]
        public double TotalEstimatedHours { get; set; }

        [JsonProperty("spent_hours")]
        public double SpentHours { get; set; }

        [JsonProperty("total_spent_hours")]
        public double TotalSpentHours { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        public string UpdatedOn { get; set; }
    }

    public class GetIssueResponseProjectType
    {
        [JsonProperty("id")]
        public int ProjectId { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }
    }

    public class GetIssueResponseTrackerType
    {
        [JsonProperty("id")]
        public int TrackerId { get; set; }

        [JsonProperty("name")]
        public string Tracker { get; set; }
    }

    public class GetIssueResponseStatusType
    {
        [JsonProperty("id")]
        public int StatusId { get; set; }

        [JsonProperty("name")]
        public string Status { get; set; }
    }

    public class GetIssueResponsePriorityType
    {
        [JsonProperty("id")]
        public int PriorityId { get; set; }

        [JsonProperty("name")]
        public string Priority { get; set; }
    }

    public class GetIssueResponseAuthorType
    {
        [JsonProperty("id")]
        public int AuthorId { get; set; }

        [JsonProperty("name")]
        public string Author { get; set; }
    }

    public enum issueissuetrackerInput
    {
        Bug,
        Feature,
        Support
    }

    public enum issueissuestatusInput
    {
        New,
        [EnumMember(Value = "In Progress")]
        InProgress,
        Resolved,
        Feedback,
        Closed,
        Rejected
    }

    public class GetProjectResponse
    {
        [JsonProperty("id")]
        public int ProjectId { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("is_public")]
        public bool Public { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        public string UpdatedOn { get; set; }
    }

    public class ListUsersResponse
    {
        [JsonProperty("users")]
        public UserResponse[] Users { get; set; }
    }

    public class UserResponse
    {
        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("mail")]
        public string Email { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("last_login_on")]
        public string LastLogin { get; set; }
    }

    public class GetUserResponse
    {
        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("mail")]
        public string Email { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("last_login_on")]
        public string LastLogin { get; set; }

        [JsonProperty("api_key")]
        public string APIKey { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class ListProjectsResponse
    {
        [JsonProperty("projects")]
        public ProjectResponse[] Projects { get; set; }
    }

    public class ProjectResponse
    {
        [JsonProperty("id")]
        public int ProjectId { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("is_public")]
        public bool Public { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        public string UpdatedOn { get; set; }
    }

    public class ListIssuesResponse
    {
        [JsonProperty("issues")]
        public IssueResponse[] Issues { get; set; }
    }

    public class IssueResponse
    {
        [JsonProperty("id")]
        public int IssueId { get; set; }

        [JsonProperty("project")]
        public IssueResponseProjectType Project { get; set; }

        [JsonProperty("tracker")]
        public IssueResponseTrackerType Tracker { get; set; }

        [JsonProperty("status")]
        public IssueResponseStatusType Status { get; set; }

        [JsonProperty("priority")]
        public IssueResponsePriorityType Priority { get; set; }

        [JsonProperty("author")]
        public IssueResponseAuthorType Author { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("done_ratio")]
        public double DoneRatio { get; set; }

        [JsonProperty("estimated_hours")]
        public double EstimatedHours { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        public string UpdatedOn { get; set; }
    }

    public class IssueResponseProjectType
    {
        [JsonProperty("id")]
        public int ProjectId { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }
    }

    public class IssueResponseTrackerType
    {
        [JsonProperty("id")]
        public int TrackerId { get; set; }

        [JsonProperty("name")]
        public string Tracker { get; set; }
    }

    public class IssueResponseStatusType
    {
        [JsonProperty("id")]
        public int StatusId { get; set; }

        [JsonProperty("name")]
        public string Status { get; set; }
    }

    public class IssueResponsePriorityType
    {
        [JsonProperty("id")]
        public int PriorityId { get; set; }

        [JsonProperty("name")]
        public string Priority { get; set; }
    }

    public class IssueResponseAuthorType
    {
        [JsonProperty("id")]
        public int AuthorId { get; set; }

        [JsonProperty("name")]
        public string Author { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Redmine;

    public partial class WorkflowManagedActions
    {
        public RedmineActions Redmine(string connectionId) => new RedmineActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RedmineTriggers Redmine(string connectionId) => new RedmineTriggers(connectionId);
    }
}