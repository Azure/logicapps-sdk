//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyredmine
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasyredmineActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        [WorkflowExpressionFactory(nameof(__BuildCreateIssue))]
        public IBodyWorkflowAction<GetIssueResponse> CreateIssue([WorkflowExpression] Func<string> issueissueprojectID = null, [WorkflowExpression] Func<string> issueissuepriorityID = null, [WorkflowExpression] Func<string> issueissuesubject = null, [WorkflowExpression] Func<string> issueissuedescription = null, [WorkflowExpression] Func<string> issueissuestartDate = null, [WorkflowExpression] Func<string> issueissuedueDate = null, [WorkflowExpression] Func<double> issueissueestimatedHours = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIssueResponse> __BuildCreateIssue(WorkflowExpression<string> issueissueprojectID = null, WorkflowExpression<string> issueissuepriorityID = null, WorkflowExpression<string> issueissuesubject = null, WorkflowExpression<string> issueissuedescription = null, WorkflowExpression<string> issueissuestartDate = null, WorkflowExpression<string> issueissuedueDate = null, WorkflowExpression<double> issueissueestimatedHours = null)
        {
            WorkflowExpression.Validate(issueissueprojectID, nameof(issueissueprojectID), required: false);
            WorkflowExpression.Validate(issueissuepriorityID, nameof(issueissuepriorityID), required: false);
            WorkflowExpression.Validate(issueissuesubject, nameof(issueissuesubject), required: false);
            WorkflowExpression.Validate(issueissuedescription, nameof(issueissuedescription), required: false);
            WorkflowExpression.Validate(issueissuestartDate, nameof(issueissuestartDate), required: false);
            WorkflowExpression.Validate(issueissuedueDate, nameof(issueissuedueDate), required: false);
            WorkflowExpression.Validate(issueissueestimatedHours, nameof(issueissueestimatedHours), required: false);
            return new DeferredBodyAction<GetIssueResponse>(() =>
            {
                var apiCallPath = "/issues.json";
                var apiCallHttpMethod = "post";
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

                return new ApiConnectionAction<GetIssueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        [WorkflowExpressionFactory(nameof(__BuildGetIssue))]
        public IBodyWorkflowAction<GetIssueResponse> GetIssue([WorkflowExpression] Func<string> issueId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateIssue))]
        public IBodyWorkflowAction<string> UpdateIssue([WorkflowExpression] Func<string> issueId, [WorkflowExpression] Func<string> issueissueprojectID = null, [WorkflowExpression] Func<string> issueissuepriorityID = null, [WorkflowExpression] Func<string> issueissuesubject = null, [WorkflowExpression] Func<string> issueissuedescription = null, [WorkflowExpression] Func<issueissuestatusInput> issueissuestatus = null, [WorkflowExpression] Func<string> issueissueassignToID = null, [WorkflowExpression] Func<string> issueissuestartDate = null, [WorkflowExpression] Func<string> issueissuedueDate = null, [WorkflowExpression] Func<double> issueissueestimatedHours = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUpdateIssue(WorkflowExpression<string> issueId, WorkflowExpression<string> issueissueprojectID = null, WorkflowExpression<string> issueissuepriorityID = null, WorkflowExpression<string> issueissuesubject = null, WorkflowExpression<string> issueissuedescription = null, WorkflowExpression<issueissuestatusInput> issueissuestatus = null, WorkflowExpression<string> issueissueassignToID = null, WorkflowExpression<string> issueissuestartDate = null, WorkflowExpression<string> issueissuedueDate = null, WorkflowExpression<double> issueissueestimatedHours = null)
        {
            WorkflowExpression.Validate(issueId, nameof(issueId), required: true);
            WorkflowExpression.Validate(issueissueprojectID, nameof(issueissueprojectID), required: false);
            WorkflowExpression.Validate(issueissuepriorityID, nameof(issueissuepriorityID), required: false);
            WorkflowExpression.Validate(issueissuesubject, nameof(issueissuesubject), required: false);
            WorkflowExpression.Validate(issueissuedescription, nameof(issueissuedescription), required: false);
            WorkflowExpression.Validate(issueissuestatus, nameof(issueissuestatus), required: false);
            WorkflowExpression.Validate(issueissueassignToID, nameof(issueissueassignToID), required: false);
            WorkflowExpression.Validate(issueissuestartDate, nameof(issueissuestartDate), required: false);
            WorkflowExpression.Validate(issueissuedueDate, nameof(issueissuedueDate), required: false);
            WorkflowExpression.Validate(issueissueestimatedHours, nameof(issueissueestimatedHours), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/issues/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(issueId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        [WorkflowExpressionFactory(nameof(__BuildCreateProject))]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject([WorkflowExpression] Func<string> projectprojectname = null, [WorkflowExpression] Func<string> projectprojectidentifier = null, [WorkflowExpression] Func<string> projectprojectdescription = null, [WorkflowExpression] Func<string> projectprojecthomepage = null, [WorkflowExpression] Func<string> projectprojectparentProjectID = null, [WorkflowExpression] Func<bool> projectprojectpublic = null, [WorkflowExpression] Func<bool> projectprojectinheritMembers = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateProjectResponse> __BuildCreateProject(WorkflowExpression<string> projectprojectname = null, WorkflowExpression<string> projectprojectidentifier = null, WorkflowExpression<string> projectprojectdescription = null, WorkflowExpression<string> projectprojecthomepage = null, WorkflowExpression<string> projectprojectparentProjectID = null, WorkflowExpression<bool> projectprojectpublic = null, WorkflowExpression<bool> projectprojectinheritMembers = null)
        {
            WorkflowExpression.Validate(projectprojectname, nameof(projectprojectname), required: false);
            WorkflowExpression.Validate(projectprojectidentifier, nameof(projectprojectidentifier), required: false);
            WorkflowExpression.Validate(projectprojectdescription, nameof(projectprojectdescription), required: false);
            WorkflowExpression.Validate(projectprojecthomepage, nameof(projectprojecthomepage), required: false);
            WorkflowExpression.Validate(projectprojectparentProjectID, nameof(projectprojectparentProjectID), required: false);
            WorkflowExpression.Validate(projectprojectpublic, nameof(projectprojectpublic), required: false);
            WorkflowExpression.Validate(projectprojectinheritMembers, nameof(projectprojectinheritMembers), required: false);
            return new DeferredBodyAction<CreateProjectResponse>(() =>
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
                    projectObject["name"] = ExpressionConverter.ConvertO(projectprojectname);
                    projectObjectpropCount++;
                }

                if (projectprojectidentifier != null)
                {
                    projectObject["identifier"] = ExpressionConverter.ConvertO(projectprojectidentifier);
                    projectObjectpropCount++;
                }

                if (projectprojectdescription != null)
                {
                    projectObject["description"] = ExpressionConverter.ConvertO(projectprojectdescription);
                    projectObjectpropCount++;
                }

                if (projectprojecthomepage != null)
                {
                    projectObject["homepage"] = ExpressionConverter.ConvertO(projectprojecthomepage);
                    projectObjectpropCount++;
                }

                if (projectprojectparentProjectID != null)
                {
                    projectObject["parent_id"] = ExpressionConverter.ConvertO(projectprojectparentProjectID);
                    projectObjectpropCount++;
                }

                if (projectprojectpublic != null)
                {
                    if (projectprojectpublic != null)
                    {
                        projectObject["is_public"] = ExpressionConverter.ConvertO(projectprojectpublic);
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
                        projectObject["inherit_members"] = ExpressionConverter.ConvertO(projectprojectinheritMembers);
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

                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        [WorkflowExpressionFactory(nameof(__BuildGetProject))]
        public IBodyWorkflowAction<ProjectResponse> GetProject([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectResponse> __BuildGetProject(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildGetUser))]
        public IBodyWorkflowAction<UserResponse> GetUser([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserResponse> __BuildGetUser(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }
    }

    public class EasyredmineTriggers([ConnectionName] string connectionId)
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