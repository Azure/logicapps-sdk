//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyredmine
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasyredmineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<GetIssueResponse> GetIssue(Expression<Func<string>> issueId)
        {
            var apiCallPath = String.Format("/issues/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(issueId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetIssueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<string> UpdateIssue(Expression<Func<string>> issueId, Expression<Func<string>> issueissueprojectID = null, Expression<Func<string>> issueissuepriorityID = null, Expression<Func<string>> issueissuesubject = null, Expression<Func<string>> issueissuedescription = null, Expression<Func<issueissuestatusInput>> issueissuestatus = null, Expression<Func<string>> issueissueassignToID = null, Expression<Func<string>> issueissuestartDate = null, Expression<Func<string>> issueissuedueDate = null, Expression<Func<double>> issueissueestimatedHours = null)
        {
            var apiCallPath = String.Format("/issues/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(issueId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var issue = new JObject();
            var issuepropCount = 0;
            var issueObject = new JObject();
            var issueObjectpropCount = 0;
            if (issueissueprojectID != null)
            {
                issueObject["project_id"] = ExpressionConverter.ConvertO(issueissueprojectID);
                issueObjectpropCount++;
            }

            if (issueissuepriorityID != null)
            {
                issueObject["priority_id"] = ExpressionConverter.ConvertO(issueissuepriorityID);
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

            if (issueissuestatus != null)
            {
                issueObject["status_id"] = ExpressionConverter.ConvertO(issueissuestatus);
                issueObjectpropCount++;
            }

            if (issueissueassignToID != null)
            {
                issueObject["assigned_to_id"] = ExpressionConverter.ConvertO(issueissueassignToID);
                issueObjectpropCount++;
            }

            if (issueissuestartDate != null)
            {
                issueObject["start_date"] = ExpressionConverter.ConvertO(issueissuestartDate);
                issueObjectpropCount++;
            }

            if (issueissuedueDate != null)
            {
                issueObject["due_date"] = ExpressionConverter.ConvertO(issueissuedueDate);
                issueObjectpropCount++;
            }

            if (issueissueestimatedHours != null)
            {
                issueObject["estimated_hours"] = ExpressionConverter.ConvertO(issueissueestimatedHours);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<ProjectResponse> GetProject(Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/projects/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers()
        {
            var apiCallPath = "/users.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<UserResponse> GetUser(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/users/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserResponse>(callPayload);
        }
    }

    public class EasyredmineTriggers([ConnectionName] string connectionId)
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
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionTrigger<ListIssuesResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListIssuesResponse> OnUpdatedIssue(Expression<Func<string>> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/resolved_issue_trigger/issues.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionTrigger<ListIssuesResponse>(callPayload, triggerName, recurrence);
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

    public enum issueissuestatusInput
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

    public class ProjectResponse
    {
        [JsonProperty("id")]
        public int ProjectID { get; set; }

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