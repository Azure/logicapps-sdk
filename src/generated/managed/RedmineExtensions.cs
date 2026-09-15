//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Redmine
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RedmineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        public IBodyWorkflowAction<GetIssueResponse> GetIssue(Expression<Func<string>> issueId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/issues/{0}.json", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(issueId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetIssueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        public IBodyWorkflowAction<string> UpdateIssue(Expression<Func<string>> issueId, Expression<Func<string>> issueissuepriority = null, Expression<Func<issueissuetrackerInput>> issueissuetracker = null, Expression<Func<issueissuestatusInput>> issueissuestatus = null, Expression<Func<string>> issueissuesubject = null, Expression<Func<string>> issueissuedescription = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/issues/{0}.json", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(issueId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var issue = new JObject();
            var issuepropCount = 0;
            var issueObject = new JObject();
            var issueObjectpropCount = 0;
            if (issueissuepriority != null)
            {
                issueObject["priority_id"] = CSharpExpressionConverter.ConvertToken(issueissuepriority);
                issueObjectpropCount++;
            }

            if (issueissuetracker != null)
            {
                issueObject["tracker_id"] = CSharpExpressionConverter.Convert(issueissuetracker);
                issueObjectpropCount++;
            }

            if (issueissuestatus != null)
            {
                issueObject["status_id"] = CSharpExpressionConverter.Convert(issueissuestatus);
                issueObjectpropCount++;
            }

            if (issueissuesubject != null)
            {
                issueObject["subject"] = CSharpExpressionConverter.ConvertToken(issueissuesubject);
                issueObjectpropCount++;
            }

            if (issueissuedescription != null)
            {
                issueObject["description"] = CSharpExpressionConverter.ConvertToken(issueissuedescription);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redmine")]
        public IBodyWorkflowAction<GetProjectResponse> GetProject(Expression<Func<string>> projectId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/projects/{0}.json", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetProjectResponse>(callPayload);
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
        public IBodyWorkflowAction<GetUserResponse> GetUser(Expression<Func<string>> userId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/users/{0}.json", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUserResponse>(callPayload);
        }
    }

    public class RedmineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListProjectsResponse> OnNewProject(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/new_project_trigger/projects.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListProjectsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListIssuesResponse> OnNewIssue(Expression<Func<string>> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/new_issue_trigger/issues.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project_id"] = CSharpExpressionConverter.ConvertO(projectId);
            return new ApiConnectionTrigger<ListIssuesResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListIssuesResponse> OnUpdatedIssue(Expression<Func<string>> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/resolved_issue_trigger/issues.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project_id"] = CSharpExpressionConverter.ConvertO(projectId);
            return new ApiConnectionTrigger<ListIssuesResponse>(callPayload, triggerName, recurrence);
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