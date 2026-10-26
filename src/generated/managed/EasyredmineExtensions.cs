//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyredmine
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasyredmineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<GetIssueResponse, ApiConnectionActionConfiguration> CreateIssue(Expression<Func<CreateIssueInput>> issue)
        {
            var __workflow_issue = WorkflowExpression.Compile(issue, nameof(issue), required: true);
            return new DeferredBodyAction<GetIssueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/issues.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_issue);
                return new ApiConnectionAction<GetIssueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<GetIssueResponse, ApiConnectionActionConfiguration> GetIssue(Expression<Func<string>> issueId)
        {
            var __workflow_issueId = WorkflowExpression.Compile(issueId, nameof(issueId), required: true);
            return new DeferredBodyAction<GetIssueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/issues/{0}.json", __workflow_issueId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetIssueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UpdateIssue(Expression<Func<string>> issueId, Expression<Func<UpdateIssueInput>> issue)
        {
            var __workflow_issueId = WorkflowExpression.Compile(issueId, nameof(issueId), required: true);
            var __workflow_issue = WorkflowExpression.Compile(issue, nameof(issue), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/issues/{0}.json", __workflow_issueId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_issue);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<CreateProjectResponse, ApiConnectionActionConfiguration> CreateProject(Expression<Func<CreateProjectInput>> project)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<CreateProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/projects.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_project);
                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<ProjectResponse, ApiConnectionActionConfiguration> GetProject(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}.json", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<ListUsersResponse, ApiConnectionActionConfiguration> ListUsers()
        {
            return new DeferredBodyAction<ListUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<UserResponse, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}.json", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }
    }

    public class EasyredmineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListProjectsResponse, ApiConnectionTriggerConfiguration> OnNewProject(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListProjectsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/new_project_trigger/projects.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListProjectsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListIssuesResponse, ApiConnectionTriggerConfiguration> OnNewIssue(Expression<Func<string>> projectId, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyTrigger<ListIssuesResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/new_issue_trigger/issues.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionTrigger<ListIssuesResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListIssuesResponse, ApiConnectionTriggerConfiguration> OnUpdatedIssue(Expression<Func<string>> projectId, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyTrigger<ListIssuesResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/resolved_issue_trigger/issues.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionTrigger<ListIssuesResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetIssueResponse
    {
        [JsonProperty("id")]
        public int TaskId { get; set; }

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

        [JsonProperty("done_ratio")]
        public int DoneRatio { get; set; }

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

    public class CreateIssueInput
    {
        [JsonProperty("issue", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateIssueInputIssueType Issue { get; set; }
    }

    public class CreateIssueInputIssueType
    {
        [JsonProperty("project_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("priority_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PriorityId { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("estimated_hours")]
        public double? EstimatedHours { get; set; }
    }

    public class UpdateIssueInput
    {
        [JsonProperty("issue")]
        public UpdateIssueInputIssueType Issue { get; set; }
    }

    public class UpdateIssueInputIssueType
    {
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("priority_id")]
        public string PriorityId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status_id")]
        public UpdateIssueInputIssueTypeStatusType? Status { get; set; }

        [JsonProperty("assigned_to_id")]
        public string AssignToId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("estimated_hours")]
        public double? EstimatedHours { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateIssueInputIssueTypeStatusType
    {
        New,
        Estimated,
        Approved,
        Realisation,
        Consultation,
        [EnumMember(Value = "To check")]
        ToCheck,
        Passive,
        Done,
        Cancelled,
        [EnumMember(Value = "Sequence pending")]
        SequencePending
    }

    public class CreateProjectResponse
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

        [JsonProperty("author")]
        public CreateProjectResponseAuthorType Author { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        public string UpdatedOn { get; set; }
    }

    public class CreateProjectResponseAuthorType
    {
        [JsonProperty("id")]
        public int AuthorId { get; set; }

        [JsonProperty("name")]
        public string Author { get; set; }
    }

    public class CreateProjectInput
    {
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateProjectInputProjectType Project { get; set; }
    }

    public class CreateProjectInputProjectType
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("parent_id")]
        public string ParentProjectId { get; set; }

        [JsonProperty("is_public", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Public { get; set; } = false;

        [JsonProperty("inherit_members", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? InheritMembers { get; set; } = false;
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

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("author")]
        public ProjectResponseAuthorType Author { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        public string UpdatedOn { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }
    }

    public class ProjectResponseAuthorType
    {
        [JsonProperty("id")]
        public int AuthorId { get; set; }

        [JsonProperty("name")]
        public string Author { get; set; }
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

        [JsonProperty("api_key")]
        public string APIKey { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("easy_user_type")]
        public UserResponseEasyUserTypeType EasyUserType { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class UserResponseEasyUserTypeType
    {
        [JsonProperty("id")]
        public int UserTypeId { get; set; }

        [JsonProperty("name")]
        public string UserTypeName { get; set; }
    }

    public class ListProjectsResponse
    {
        [JsonProperty("projects")]
        public ProjectResponse[] Projects { get; set; }
    }

    public class ListIssuesResponse
    {
        [JsonProperty("issues")]
        public IssueResponse[] Issues { get; set; }
    }

    public class IssueResponse
    {
        [JsonProperty("id")]
        public int TaskId { get; set; }

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

        [JsonProperty("done_ratio")]
        public int DoneRatio { get; set; }

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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Easyredmine;

    public partial class WorkflowManagedActions
    {
        public EasyredmineActions Easyredmine(string connectionId) => new EasyredmineActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EasyredmineTriggers Easyredmine(string connectionId) => new EasyredmineTriggers(connectionId);
    }
}