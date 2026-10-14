//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyredmine
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EasyredmineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<GetIssueResponse> CreateIssue(Expression<Func<string>> issueissueprojectID = null, Expression<Func<string>> issueissuepriorityID = null, Expression<Func<string>> issueissuesubject = null, Expression<Func<string>> issueissuedescription = null, Expression<Func<string>> issueissuestartDate = null, Expression<Func<string>> issueissuedueDate = null, Expression<Func<double>> issueissueestimatedHours = null)
        {
            var __workflow_issueissueprojectID = issueissueprojectID == null ? null : WorkflowExpression.Compile(issueissueprojectID);
            WorkflowExpression.Validate(__workflow_issueissueprojectID, nameof(issueissueprojectID), required: false);
            var __workflow_issueissuepriorityID = issueissuepriorityID == null ? null : WorkflowExpression.Compile(issueissuepriorityID);
            WorkflowExpression.Validate(__workflow_issueissuepriorityID, nameof(issueissuepriorityID), required: false);
            var __workflow_issueissuesubject = issueissuesubject == null ? null : WorkflowExpression.Compile(issueissuesubject);
            WorkflowExpression.Validate(__workflow_issueissuesubject, nameof(issueissuesubject), required: false);
            var __workflow_issueissuedescription = issueissuedescription == null ? null : WorkflowExpression.Compile(issueissuedescription);
            WorkflowExpression.Validate(__workflow_issueissuedescription, nameof(issueissuedescription), required: false);
            var __workflow_issueissuestartDate = issueissuestartDate == null ? null : WorkflowExpression.Compile(issueissuestartDate);
            WorkflowExpression.Validate(__workflow_issueissuestartDate, nameof(issueissuestartDate), required: false);
            var __workflow_issueissuedueDate = issueissuedueDate == null ? null : WorkflowExpression.Compile(issueissuedueDate);
            WorkflowExpression.Validate(__workflow_issueissuedueDate, nameof(issueissuedueDate), required: false);
            var __workflow_issueissueestimatedHours = issueissueestimatedHours == null ? null : WorkflowExpression.Compile(issueissueestimatedHours);
            WorkflowExpression.Validate(__workflow_issueissueestimatedHours, nameof(issueissueestimatedHours), required: false);
            return new DeferredBodyAction<GetIssueResponse>(() =>
            {
                var apiCallPath = "/issues.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var issue = new JObject();
                var issuepropCount = 0;
                var issueObject = new JObject();
                var issueObjectpropCount = 0;
                if (__workflow_issueissueprojectID != null)
                {
                    issueObject["project_id"] = ExpressionConverter.ConvertO(__workflow_issueissueprojectID);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissuepriorityID != null)
                {
                    issueObject["priority_id"] = ExpressionConverter.ConvertO(__workflow_issueissuepriorityID);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissuesubject != null)
                {
                    issueObject["subject"] = ExpressionConverter.ConvertO(__workflow_issueissuesubject);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissuedescription != null)
                {
                    issueObject["description"] = ExpressionConverter.ConvertO(__workflow_issueissuedescription);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissuestartDate != null)
                {
                    issueObject["start_date"] = ExpressionConverter.ConvertO(__workflow_issueissuestartDate);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissuedueDate != null)
                {
                    issueObject["due_date"] = ExpressionConverter.ConvertO(__workflow_issueissuedueDate);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissueestimatedHours != null)
                {
                    issueObject["estimated_hours"] = ExpressionConverter.ConvertO(__workflow_issueissueestimatedHours);
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
        public IBodyWorkflowAction<GetIssueResponse> GetIssue(Expression<Func<string>> issueId)
        {
            var __workflow_issueId = issueId == null ? null : WorkflowExpression.Compile(issueId);
            WorkflowExpression.Validate(__workflow_issueId, nameof(issueId), required: true);
            return new DeferredBodyAction<GetIssueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/issues/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_issueId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetIssueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyredmine")]
        public IBodyWorkflowAction<string> UpdateIssue(Expression<Func<string>> issueId, Expression<Func<string>> issueissueprojectID = null, Expression<Func<string>> issueissuepriorityID = null, Expression<Func<string>> issueissuesubject = null, Expression<Func<string>> issueissuedescription = null, Expression<Func<issueissuestatusInput>> issueissuestatus = null, Expression<Func<string>> issueissueassignToID = null, Expression<Func<string>> issueissuestartDate = null, Expression<Func<string>> issueissuedueDate = null, Expression<Func<double>> issueissueestimatedHours = null)
        {
            var __workflow_issueId = issueId == null ? null : WorkflowExpression.Compile(issueId);
            WorkflowExpression.Validate(__workflow_issueId, nameof(issueId), required: true);
            var __workflow_issueissueprojectID = issueissueprojectID == null ? null : WorkflowExpression.Compile(issueissueprojectID);
            WorkflowExpression.Validate(__workflow_issueissueprojectID, nameof(issueissueprojectID), required: false);
            var __workflow_issueissuepriorityID = issueissuepriorityID == null ? null : WorkflowExpression.Compile(issueissuepriorityID);
            WorkflowExpression.Validate(__workflow_issueissuepriorityID, nameof(issueissuepriorityID), required: false);
            var __workflow_issueissuesubject = issueissuesubject == null ? null : WorkflowExpression.Compile(issueissuesubject);
            WorkflowExpression.Validate(__workflow_issueissuesubject, nameof(issueissuesubject), required: false);
            var __workflow_issueissuedescription = issueissuedescription == null ? null : WorkflowExpression.Compile(issueissuedescription);
            WorkflowExpression.Validate(__workflow_issueissuedescription, nameof(issueissuedescription), required: false);
            var __workflow_issueissuestatus = issueissuestatus == null ? null : WorkflowExpression.Compile(issueissuestatus);
            WorkflowExpression.Validate(__workflow_issueissuestatus, nameof(issueissuestatus), required: false);
            var __workflow_issueissueassignToID = issueissueassignToID == null ? null : WorkflowExpression.Compile(issueissueassignToID);
            WorkflowExpression.Validate(__workflow_issueissueassignToID, nameof(issueissueassignToID), required: false);
            var __workflow_issueissuestartDate = issueissuestartDate == null ? null : WorkflowExpression.Compile(issueissuestartDate);
            WorkflowExpression.Validate(__workflow_issueissuestartDate, nameof(issueissuestartDate), required: false);
            var __workflow_issueissuedueDate = issueissuedueDate == null ? null : WorkflowExpression.Compile(issueissuedueDate);
            WorkflowExpression.Validate(__workflow_issueissuedueDate, nameof(issueissuedueDate), required: false);
            var __workflow_issueissueestimatedHours = issueissueestimatedHours == null ? null : WorkflowExpression.Compile(issueissueestimatedHours);
            WorkflowExpression.Validate(__workflow_issueissueestimatedHours, nameof(issueissueestimatedHours), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/issues/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_issueId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var issue = new JObject();
                var issuepropCount = 0;
                var issueObject = new JObject();
                var issueObjectpropCount = 0;
                if (__workflow_issueissueprojectID != null)
                {
                    issueObject["project_id"] = ExpressionConverter.ConvertO(__workflow_issueissueprojectID);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissuepriorityID != null)
                {
                    issueObject["priority_id"] = ExpressionConverter.ConvertO(__workflow_issueissuepriorityID);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissuesubject != null)
                {
                    issueObject["subject"] = ExpressionConverter.ConvertO(__workflow_issueissuesubject);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissuedescription != null)
                {
                    issueObject["description"] = ExpressionConverter.ConvertO(__workflow_issueissuedescription);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissuestatus != null)
                {
                    issueObject["status_id"] = ExpressionConverter.ConvertO(__workflow_issueissuestatus);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissueassignToID != null)
                {
                    issueObject["assigned_to_id"] = ExpressionConverter.ConvertO(__workflow_issueissueassignToID);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissuestartDate != null)
                {
                    issueObject["start_date"] = ExpressionConverter.ConvertO(__workflow_issueissuestartDate);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissuedueDate != null)
                {
                    issueObject["due_date"] = ExpressionConverter.ConvertO(__workflow_issueissuedueDate);
                    issueObjectpropCount++;
                }

                if (__workflow_issueissueestimatedHours != null)
                {
                    issueObject["estimated_hours"] = ExpressionConverter.ConvertO(__workflow_issueissueestimatedHours);
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
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject(Expression<Func<string>> projectprojectname = null, Expression<Func<string>> projectprojectidentifier = null, Expression<Func<string>> projectprojectdescription = null, Expression<Func<string>> projectprojecthomepage = null, Expression<Func<string>> projectprojectparentProjectID = null, Expression<Func<bool>> projectprojectpublic = null, Expression<Func<bool>> projectprojectinheritMembers = null)
        {
            var __workflow_projectprojectname = projectprojectname == null ? null : WorkflowExpression.Compile(projectprojectname);
            WorkflowExpression.Validate(__workflow_projectprojectname, nameof(projectprojectname), required: false);
            var __workflow_projectprojectidentifier = projectprojectidentifier == null ? null : WorkflowExpression.Compile(projectprojectidentifier);
            WorkflowExpression.Validate(__workflow_projectprojectidentifier, nameof(projectprojectidentifier), required: false);
            var __workflow_projectprojectdescription = projectprojectdescription == null ? null : WorkflowExpression.Compile(projectprojectdescription);
            WorkflowExpression.Validate(__workflow_projectprojectdescription, nameof(projectprojectdescription), required: false);
            var __workflow_projectprojecthomepage = projectprojecthomepage == null ? null : WorkflowExpression.Compile(projectprojecthomepage);
            WorkflowExpression.Validate(__workflow_projectprojecthomepage, nameof(projectprojecthomepage), required: false);
            var __workflow_projectprojectparentProjectID = projectprojectparentProjectID == null ? null : WorkflowExpression.Compile(projectprojectparentProjectID);
            WorkflowExpression.Validate(__workflow_projectprojectparentProjectID, nameof(projectprojectparentProjectID), required: false);
            var __workflow_projectprojectpublic = projectprojectpublic == null ? null : WorkflowExpression.Compile(projectprojectpublic);
            WorkflowExpression.Validate(__workflow_projectprojectpublic, nameof(projectprojectpublic), required: false);
            var __workflow_projectprojectinheritMembers = projectprojectinheritMembers == null ? null : WorkflowExpression.Compile(projectprojectinheritMembers);
            WorkflowExpression.Validate(__workflow_projectprojectinheritMembers, nameof(projectprojectinheritMembers), required: false);
            return new DeferredBodyAction<CreateProjectResponse>(() =>
            {
                var apiCallPath = "/projects.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var project = new JObject();
                var projectpropCount = 0;
                var projectObject = new JObject();
                var projectObjectpropCount = 0;
                if (__workflow_projectprojectname != null)
                {
                    projectObject["name"] = ExpressionConverter.ConvertO(__workflow_projectprojectname);
                    projectObjectpropCount++;
                }

                if (__workflow_projectprojectidentifier != null)
                {
                    projectObject["identifier"] = ExpressionConverter.ConvertO(__workflow_projectprojectidentifier);
                    projectObjectpropCount++;
                }

                if (__workflow_projectprojectdescription != null)
                {
                    projectObject["description"] = ExpressionConverter.ConvertO(__workflow_projectprojectdescription);
                    projectObjectpropCount++;
                }

                if (__workflow_projectprojecthomepage != null)
                {
                    projectObject["homepage"] = ExpressionConverter.ConvertO(__workflow_projectprojecthomepage);
                    projectObjectpropCount++;
                }

                if (__workflow_projectprojectparentProjectID != null)
                {
                    projectObject["parent_id"] = ExpressionConverter.ConvertO(__workflow_projectprojectparentProjectID);
                    projectObjectpropCount++;
                }

                if (__workflow_projectprojectpublic != null)
                {
                    if (__workflow_projectprojectpublic != null)
                    {
                        projectObject["is_public"] = ExpressionConverter.ConvertO(__workflow_projectprojectpublic);
                        projectObjectpropCount++;
                    }

                    projectObjectpropCount++;
                }
                else
                {
                    projectObject["is_public"] = false;
                    projectObjectpropCount++;
                }

                if (__workflow_projectprojectinheritMembers != null)
                {
                    if (__workflow_projectprojectinheritMembers != null)
                    {
                        projectObject["inherit_members"] = ExpressionConverter.ConvertO(__workflow_projectprojectinheritMembers);
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
        public IBodyWorkflowAction<ProjectResponse> GetProject(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
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
        public IBodyWorkflowAction<UserResponse> GetUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = userId == null ? null : WorkflowExpression.Compile(userId);
            WorkflowExpression.Validate(__workflow_userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_userId, 1));
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

        public IBodyWorkflowTrigger<ListIssuesResponse> OnNewIssue(Expression<Func<string>> projectId, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            return new DeferredBodyTrigger<ListIssuesResponse>(() =>
            {
                var apiCallPath = "/new_issue_trigger/issues.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionTrigger<ListIssuesResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListIssuesResponse> OnUpdatedIssue(Expression<Func<string>> projectId, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            return new DeferredBodyTrigger<ListIssuesResponse>(() =>
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
