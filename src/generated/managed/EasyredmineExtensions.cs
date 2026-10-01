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
        public IBodyWorkflowAction<GetIssueResponse> CreateIssue([WorkflowExpression] Func<string> issueissueprojectId = null, [WorkflowExpression] Func<string> issueissuepriorityId = null, [WorkflowExpression] Func<string> issueissuesubject = null, [WorkflowExpression] Func<string> issueissuedescription = null, [WorkflowExpression] Func<string> issueissuestartDate = null, [WorkflowExpression] Func<string> issueissuedueDate = null, [WorkflowExpression] Func<double> issueissueestimatedHours = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/issues.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var issue = new JObject();
                var issuepropCount = 0;
                var issueObject = new JObject();
                var issueObjectpropCount = 0;
                if (issueissueprojectId != null)
                {
                    issueObject["project_id"] = SourceExpressionConverter.ConvertToken(issueissueprojectId);
                    issueObjectpropCount++;
                }

                if (issueissuepriorityId != null)
                {
                    issueObject["priority_id"] = SourceExpressionConverter.ConvertToken(issueissuepriorityId);
                    issueObjectpropCount++;
                }

                if (issueissuesubject != null)
                {
                    issueObject["subject"] = SourceExpressionConverter.ConvertToken(issueissuesubject);
                    issueObjectpropCount++;
                }

                if (issueissuedescription != null)
                {
                    issueObject["description"] = SourceExpressionConverter.ConvertToken(issueissuedescription);
                    issueObjectpropCount++;
                }

                if (issueissuestartDate != null)
                {
                    issueObject["start_date"] = SourceExpressionConverter.ConvertToken(issueissuestartDate);
                    issueObjectpropCount++;
                }

                if (issueissuedueDate != null)
                {
                    issueObject["due_date"] = SourceExpressionConverter.ConvertToken(issueissuedueDate);
                    issueObjectpropCount++;
                }

                if (issueissueestimatedHours != null)
                {
                    issueObject["estimated_hours"] = SourceExpressionConverter.ConvertToken(issueissueestimatedHours);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetIssueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<GetIssueResponse> GetIssue([WorkflowExpression] Func<string> issueId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/issues/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(issueId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetIssueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<string> UpdateIssue([WorkflowExpression] Func<string> issueId, [WorkflowExpression] Func<string> issueissueprojectId = null, [WorkflowExpression] Func<string> issueissuepriorityId = null, [WorkflowExpression] Func<string> issueissuesubject = null, [WorkflowExpression] Func<string> issueissuedescription = null, [WorkflowExpression] Func<issueissuestatusInput> issueissuestatus = null, [WorkflowExpression] Func<string> issueissueassignToId = null, [WorkflowExpression] Func<string> issueissuestartDate = null, [WorkflowExpression] Func<string> issueissuedueDate = null, [WorkflowExpression] Func<double> issueissueestimatedHours = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/issues/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(issueId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var issue = new JObject();
                var issuepropCount = 0;
                var issueObject = new JObject();
                var issueObjectpropCount = 0;
                if (issueissueprojectId != null)
                {
                    issueObject["project_id"] = SourceExpressionConverter.ConvertToken(issueissueprojectId);
                    issueObjectpropCount++;
                }

                if (issueissuepriorityId != null)
                {
                    issueObject["priority_id"] = SourceExpressionConverter.ConvertToken(issueissuepriorityId);
                    issueObjectpropCount++;
                }

                if (issueissuesubject != null)
                {
                    issueObject["subject"] = SourceExpressionConverter.ConvertToken(issueissuesubject);
                    issueObjectpropCount++;
                }

                if (issueissuedescription != null)
                {
                    issueObject["description"] = SourceExpressionConverter.ConvertToken(issueissuedescription);
                    issueObjectpropCount++;
                }

                if (issueissuestatus != null)
                {
                    issueObject["status_id"] = SourceExpressionConverter.Convert(issueissuestatus);
                    issueObjectpropCount++;
                }

                if (issueissueassignToId != null)
                {
                    issueObject["assigned_to_id"] = SourceExpressionConverter.ConvertToken(issueissueassignToId);
                    issueObjectpropCount++;
                }

                if (issueissuestartDate != null)
                {
                    issueObject["start_date"] = SourceExpressionConverter.ConvertToken(issueissuestartDate);
                    issueObjectpropCount++;
                }

                if (issueissuedueDate != null)
                {
                    issueObject["due_date"] = SourceExpressionConverter.ConvertToken(issueissuedueDate);
                    issueObjectpropCount++;
                }

                if (issueissueestimatedHours != null)
                {
                    issueObject["estimated_hours"] = SourceExpressionConverter.ConvertToken(issueissueestimatedHours);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject([WorkflowExpression] Func<string> projectprojectname = null, [WorkflowExpression] Func<string> projectprojectidentifier = null, [WorkflowExpression] Func<string> projectprojectdescription = null, [WorkflowExpression] Func<string> projectprojecthomepage = null, [WorkflowExpression] Func<string> projectprojectparentProjectId = null, [WorkflowExpression] Func<bool> projectprojectPublic = null, [WorkflowExpression] Func<bool> projectprojectinheritMembers = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/projects.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var project = new JObject();
                var projectpropCount = 0;
                var projectObject = new JObject();
                var projectObjectpropCount = 0;
                if (projectprojectname != null)
                {
                    projectObject["name"] = SourceExpressionConverter.ConvertToken(projectprojectname);
                    projectObjectpropCount++;
                }

                if (projectprojectidentifier != null)
                {
                    projectObject["identifier"] = SourceExpressionConverter.ConvertToken(projectprojectidentifier);
                    projectObjectpropCount++;
                }

                if (projectprojectdescription != null)
                {
                    projectObject["description"] = SourceExpressionConverter.ConvertToken(projectprojectdescription);
                    projectObjectpropCount++;
                }

                if (projectprojecthomepage != null)
                {
                    projectObject["homepage"] = SourceExpressionConverter.ConvertToken(projectprojecthomepage);
                    projectObjectpropCount++;
                }

                if (projectprojectparentProjectId != null)
                {
                    projectObject["parent_id"] = SourceExpressionConverter.ConvertToken(projectprojectparentProjectId);
                    projectObjectpropCount++;
                }

                if (projectprojectPublic != null)
                {
                    if (projectprojectPublic != null)
                    {
                        projectObject["is_public"] = SourceExpressionConverter.ConvertToken(projectprojectPublic);
                        projectObjectpropCount++;
                    }

                    projectObjectpropCount++;
                }
                else
                {
                    projectObject["is_public"] = false;
                    projectObjectpropCount++;
                }

                if (projectprojectinheritMembers != null)
                {
                    if (projectprojectinheritMembers != null)
                    {
                        projectObject["inherit_members"] = SourceExpressionConverter.ConvertToken(projectprojectinheritMembers);
                        projectObjectpropCount++;
                    }

                    projectObjectpropCount++;
                }
                else
                {
                    projectObject["inherit_members"] = false;
                    projectObjectpropCount++;
                }

                if (projectObjectpropCount > 0)
                {
                    project["project"] = projectObject;
                    projectpropCount++;
                }

                if (projectpropCount > 0)
                {
                    callPayload.Body = project;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<ProjectResponse> GetProject([WorkflowExpression] Func<string> projectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListUsersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<UserResponse> GetUser([WorkflowExpression] Func<string> userId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserResponse>(BuildSourceInput);
        }
    }

    public class EasyredmineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListProjectsResponse> OnNewProject(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/new_project_trigger/projects.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListProjectsResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListIssuesResponse> OnNewIssue([WorkflowExpression] Func<string> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/new_issue_trigger/issues.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListIssuesResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListIssuesResponse> OnUpdatedIssue([WorkflowExpression] Func<string> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resolved_issue_trigger/issues.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListIssuesResponse>(BuildSourceInput, triggerName, recurrence);
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