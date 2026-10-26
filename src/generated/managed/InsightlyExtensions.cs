//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Insightly
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InsightlyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListTasksResponse, ApiConnectionActionConfiguration> ListTasks()
        {
            return new DeferredBodyAction<ListTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> UpdateTask(Expression<Func<string>> id, Expression<Func<UpdateTaskInput>> updatedTask)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_updatedTask = WorkflowExpression.Compile(updatedTask, nameof(updatedTask), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Tasks";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updatedTask);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> AddTask(Expression<Func<AddTaskInput>> newTask)
        {
            var __workflow_newTask = WorkflowExpression.Compile(newTask, nameof(newTask), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newTask);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListProjectsResponse, ApiConnectionActionConfiguration> ListProjects()
        {
            return new DeferredBodyAction<ListProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Project, ApiConnectionActionConfiguration> UpdateProject(Expression<Func<string>> id, Expression<Func<UpdateProjectInput>> updatedProject)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_updatedProject = WorkflowExpression.Compile(updatedProject, nameof(updatedProject), required: true);
            return new DeferredBodyAction<Project, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Projects";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updatedProject);
                return new ApiConnectionAction<Project>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Project, ApiConnectionActionConfiguration> AddProject(Expression<Func<AddProjectInput>> newProject)
        {
            var __workflow_newProject = WorkflowExpression.Compile(newProject, nameof(newProject), required: true);
            return new DeferredBodyAction<Project, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newProject);
                return new ApiConnectionAction<Project>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListLeadsResponse, ApiConnectionActionConfiguration> ListLeads()
        {
            return new DeferredBodyAction<ListLeadsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListLeadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Lead, ApiConnectionActionConfiguration> UpdateLead(Expression<Func<string>> id, Expression<Func<UpdateLeadInput>> updatedLead)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_updatedLead = WorkflowExpression.Compile(updatedLead, nameof(updatedLead), required: true);
            return new DeferredBodyAction<Lead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Leads";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updatedLead);
                return new ApiConnectionAction<Lead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Lead, ApiConnectionActionConfiguration> AddLead(Expression<Func<AddLeadInput>> newLead)
        {
            var __workflow_newLead = WorkflowExpression.Compile(newLead, nameof(newLead), required: true);
            return new DeferredBodyAction<Lead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Leads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newLead);
                return new ApiConnectionAction<Lead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListContactsResponse, ApiConnectionActionConfiguration> ListContacts()
        {
            return new DeferredBodyAction<ListContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Contact, ApiConnectionActionConfiguration> UpdateContact(Expression<Func<string>> id, Expression<Func<UpdateContactInput>> updatedContact)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_updatedContact = WorkflowExpression.Compile(updatedContact, nameof(updatedContact), required: true);
            return new DeferredBodyAction<Contact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Contacts";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updatedContact);
                return new ApiConnectionAction<Contact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Contact, ApiConnectionActionConfiguration> AddContact(Expression<Func<AddContactInput>> newContact)
        {
            var __workflow_newContact = WorkflowExpression.Compile(newContact, nameof(newContact), required: true);
            return new DeferredBodyAction<Contact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newContact);
                return new ApiConnectionAction<Contact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListUsersResponse, ApiConnectionActionConfiguration> ListUsers()
        {
            return new DeferredBodyAction<ListUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteTask(Expression<Func<int>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Tasks/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FollowTask(Expression<Func<int>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Tasks/{0}/Follow", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteProject(Expression<Func<int>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Projects/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteLead(Expression<Func<int>> leadId)
        {
            var __workflow_leadId = WorkflowExpression.Compile(leadId, nameof(leadId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Leads/{0}", __workflow_leadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteContact(Expression<Func<int>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<OrganizationInfo, ApiConnectionActionConfiguration> AddOrganization(Expression<Func<AddOrganizationInput>> newOrganization)
        {
            var __workflow_newOrganization = WorkflowExpression.Compile(newOrganization, nameof(newOrganization), required: true);
            return new DeferredBodyAction<OrganizationInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Organisations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newOrganization);
                return new ApiConnectionAction<OrganizationInfo>(callPayload);
            });
        }
    }

    public class InsightlyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration> OnTaskAssignedToMe(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger1/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListTasksResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration> OnTaskCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger2/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListTasksResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration> OnTaskUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger3/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListTasksResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListProjectsResponse, ApiConnectionTriggerConfiguration> OnProjectCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListProjectsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger2/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListProjectsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListProjectsResponse, ApiConnectionTriggerConfiguration> OnProjectUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListProjectsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger3/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListProjectsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Lead, ApiConnectionTriggerConfiguration> OnLeadCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<Lead, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger1/Leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<Lead>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Lead, ApiConnectionTriggerConfiguration> OnLeadUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<Lead, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger2/Leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<Lead>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListContactsResponse, ApiConnectionTriggerConfiguration> OnContactCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListContactsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger1/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListContactsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListContactsResponse, ApiConnectionTriggerConfiguration> OnContactUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListContactsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger2/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListContactsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListEventsResponse, ApiConnectionTriggerConfiguration> OnEventCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListEventsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger1/Events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListEventsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListEventsResponse, ApiConnectionTriggerConfiguration> OnEventUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListEventsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger2/Events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListEventsResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ListTasksResponse
    {
        [JsonProperty("tasks")]
        public TaskObject[] Tasks { get; set; }
    }

    public class TaskObject
    {
        [JsonProperty("TASK_ID")]
        public int TaskId { get; set; }

        [JsonProperty("TITLE")]
        public string TaskTitle { get; set; }

        [JsonProperty("DUE_DATE")]
        public string DueDateTime { get; set; }

        [JsonProperty("CATEGORY_ID")]
        public int CategoryId { get; set; }

        [JsonProperty("COMPLETED_DATE_UTC")]
        public string CompletedDateTime { get; set; }

        [JsonProperty("COMPLETED")]
        public bool IsCompleted { get; set; }

        [JsonProperty("DETAILS")]
        public string TaskDetails { get; set; }

        [JsonProperty("STATUS")]
        public TaskObjectTaskStatusType TaskStatus { get; set; }

        [JsonProperty("PRIORITY")]
        public int TaskPriority { get; set; }

        [JsonProperty("START_DATE")]
        public string StartDateTime { get; set; }

        [JsonProperty("PROJECT_ID")]
        public int ProjectId { get; set; }

        [JsonProperty("OPPORTUNITY_ID")]
        public int OpportunityId { get; set; }

        [JsonProperty("MILESTONE_ID")]
        public int MilestoneId { get; set; }

        [JsonProperty("PIPELINE_ID")]
        public int PipelineId { get; set; }

        [JsonProperty("STAGE_ID")]
        public int StageId { get; set; }

        [JsonProperty("PERCENT_COMPLETE")]
        public int PercentageComplete { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int TaskOwner { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID")]
        public int AssignedTo { get; set; }

        [JsonProperty("PUBLICLY_VISIBLE")]
        public bool IsTaskVisible { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("ASSIGNED_BY_USER_ID")]
        public int AssignedByUserId { get; set; }

        [JsonProperty("PARENT_TASK_ID")]
        public int ParentTaskId { get; set; }

        [JsonProperty("OWNER_VISIBLE")]
        public bool IsOwnerVisible { get; set; }

        [JsonProperty("ASSIGNED_TEAM_ID")]
        public int AssignedTeamId { get; set; }

        [JsonProperty("ASSIGNED_DATE_UTC")]
        public string AssignedDateTime { get; set; }

        [JsonProperty("REMINDER_DATE_UTC")]
        public string ReminderDateTime { get; set; }

        [JsonProperty("REMINDER_SENT")]
        public bool IsReminderSent { get; set; }

        [JsonProperty("RECURRENCE")]
        public string Recurrence { get; set; }

        [JsonProperty("CAN_EDIT")]
        public bool CanEdit { get; set; }

        [JsonProperty("CAN_DELETE")]
        public bool CanDelete { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskObjectTaskStatusType
    {
        Completed,
        Deferred,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Not Started")]
        NotStarted,
        Waiting
    }

    public class UpdateTaskInput
    {
        [JsonProperty("TITLE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskTitle { get; set; }

        [JsonProperty("DUE_DATE")]
        public string DueDateTime { get; set; }

        [JsonProperty("COMPLETED", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsCompleted { get; set; }

        [JsonProperty("DETAILS")]
        public string TaskDetails { get; set; }

        [JsonProperty("STATUS", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateTaskInputTaskStatusType TaskStatus { get; set; }

        [JsonProperty("PRIORITY")]
        public int? TaskPriority { get; set; }

        [JsonProperty("PUBLICLY_VISIBLE", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsTaskVisible { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTaskInputTaskStatusType
    {
        Completed,
        Deferred,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Not Started")]
        NotStarted,
        Waiting
    }

    public class AddTaskInput
    {
        [JsonProperty("TITLE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskTitle { get; set; }

        [JsonProperty("DUE_DATE")]
        public string DueDateTime { get; set; }

        [JsonProperty("COMPLETED", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsCompleted { get; set; }

        [JsonProperty("DETAILS")]
        public string TaskDetails { get; set; }

        [JsonProperty("STATUS", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddTaskInputTaskStatusType TaskStatus { get; set; }

        [JsonProperty("PRIORITY")]
        public int? TaskPriority { get; set; }

        [JsonProperty("PUBLICLY_VISIBLE", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsTaskVisible { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddTaskInputTaskStatusType
    {
        Completed,
        Deferred,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Not Started")]
        NotStarted,
        Waiting
    }

    public class ListProjectsResponse
    {
        [JsonProperty("projects")]
        public Project[] Projects { get; set; }
    }

    public class Project
    {
        [JsonProperty("PROJECT_ID")]
        public int ProjectId { get; set; }

        [JsonProperty("PROJECT_NAME")]
        public string ProjectName { get; set; }

        [JsonProperty("STATUS")]
        public string ProjectStatus { get; set; }

        [JsonProperty("PROJECT_DETAILS")]
        public string ProjectDetails { get; set; }

        [JsonProperty("IMAGE_URL")]
        public string ImageURL { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public string ProjectVisible { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("STARTED_DATE")]
        public string StartedDateTime { get; set; }

        [JsonProperty("COMPLETED_DATE")]
        public string CompletedDateTime { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int ProjectOwner { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID")]
        public int AssignedTo { get; set; }

        [JsonProperty("OPPORTUNITY_ID")]
        public int OpportunityId { get; set; }

        [JsonProperty("PIPELINE_ID")]
        public int PipelineId { get; set; }

        [JsonProperty("STAGE_ID")]
        public int StageId { get; set; }

        [JsonProperty("CATEGORY_ID")]
        public int CategoryId { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int VisibleUserIDs { get; set; }

        [JsonProperty("CAN_EDIT")]
        public bool CanEdit { get; set; }

        [JsonProperty("CAN_DELETE")]
        public bool CanDelete { get; set; }
    }

    public class UpdateProjectInput
    {
        [JsonProperty("PROJECT_NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectName { get; set; }

        [JsonProperty("PROJECT_DETAILS")]
        public string ProjectDetails { get; set; }

        [JsonProperty("STATUS", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateProjectInputProjectStatusType ProjectStatus { get; set; }

        [JsonProperty("IMAGE_URL")]
        public string ImageURL { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public UpdateProjectInputProjectVisibilityType? ProjectVisibility { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int? VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int? VisibleUserIDs { get; set; }

        [JsonProperty("OPPORTUNITY_ID")]
        public int? OpportunityId { get; set; }

        [JsonProperty("PIPELINE_ID")]
        public int? PipelineId { get; set; }

        [JsonProperty("STAGE_ID")]
        public int? StageId { get; set; }

        [JsonProperty("TAGS")]
        public Tag[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateProjectInputProjectStatusType
    {
        Completed,
        Deferred,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Not Started")]
        NotStarted,
        Abandoned,
        Cancelled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateProjectInputProjectVisibilityType
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class Tag
    {
        [JsonProperty("TAG_NAME")]
        public string TagName { get; set; }
    }

    public class AddProjectInput
    {
        [JsonProperty("PROJECT_NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectName { get; set; }

        [JsonProperty("PROJECT_DETAILS")]
        public string ProjectDetails { get; set; }

        [JsonProperty("STATUS", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddProjectInputProjectStatusType ProjectStatus { get; set; }

        [JsonProperty("IMAGE_URL")]
        public string ImageURL { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public AddProjectInputProjectVisibilityType? ProjectVisibility { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int? VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int? VisibleUserIDs { get; set; }

        [JsonProperty("OPPORTUNITY_ID")]
        public int? OpportunityId { get; set; }

        [JsonProperty("PIPELINE_ID")]
        public int? PipelineId { get; set; }

        [JsonProperty("STAGE_ID")]
        public int? StageId { get; set; }

        [JsonProperty("TAGS")]
        public Tag[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddProjectInputProjectStatusType
    {
        Completed,
        Deferred,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Not Started")]
        NotStarted,
        Abandoned,
        Cancelled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddProjectInputProjectVisibilityType
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class ListLeadsResponse
    {
        [JsonProperty("leads")]
        public Lead[] Leads { get; set; }
    }

    public class Lead
    {
        [JsonProperty("LEAD_ID")]
        public int LeadId { get; set; }

        [JsonProperty("SALUTATION")]
        public string Salutation { get; set; }

        [JsonProperty("TITLE")]
        public string Title { get; set; }

        [JsonProperty("FIRST_NAME")]
        public string FirstName { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LEAD_DESCRIPTION")]
        public string LeadDescription { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("CONVERTED_DATE_UTC")]
        public string ConvertedDateTime { get; set; }

        [JsonProperty("LEAD_STATUS_ID")]
        public int LeadStatusId { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public string LeadVisibility { get; set; }

        [JsonProperty("ORGANIZATION_NAME")]
        public string OrganizationName { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }

        [JsonProperty("MOBILE_PHONE_NUMBER")]
        public string MobilePhoneNumber { get; set; }

        [JsonProperty("EMAIL_ADDRESS")]
        public string EmailAddress { get; set; }

        [JsonProperty("CONVERTED")]
        public bool IsConverted { get; set; }

        [JsonProperty("WEBSITE_URL")]
        public string WebsiteURL { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int LeadOwner { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID")]
        public int LeadResponsible { get; set; }

        [JsonProperty("EMPLOYEE_COUNT")]
        public int LeadEmployeeCount { get; set; }

        [JsonProperty("LEAD_RATING")]
        public int LeadRating { get; set; }

        [JsonProperty("INDUSTRY")]
        public string Industry { get; set; }

        [JsonProperty("ADDRESS_STREET")]
        public string AddressStreet { get; set; }

        [JsonProperty("ADDRESS_CITY")]
        public string AddressCity { get; set; }

        [JsonProperty("ADDRESS_STATE")]
        public string AddressState { get; set; }

        [JsonProperty("ADDRESS_POSTCODE")]
        public string AddressPostcode { get; set; }

        [JsonProperty("ADDRESS_COUNTRY")]
        public string AddressCountry { get; set; }

        [JsonProperty("FAX_NUMBER")]
        public string FaxNumber { get; set; }

        [JsonProperty("CONVERTED_CONTACT_ID")]
        public int ConvertedContactId { get; set; }

        [JsonProperty("CONVERTED_ORGANIZATION_ID")]
        public int ConvertedOrganizationId { get; set; }

        [JsonProperty("CONVERTED_OPPORTUNITY_ID")]
        public int ConvertedOpportunityId { get; set; }

        [JsonProperty("LEAD_SOURCE_ID")]
        public int LeadSourceId { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int VisibleUserIDs { get; set; }

        [JsonProperty("IMAGE_URL")]
        public string ImageURL { get; set; }

        [JsonProperty("CAN_EDIT")]
        public bool CanEdit { get; set; }

        [JsonProperty("CAN_DELETE")]
        public bool CanDelete { get; set; }
    }

    public class UpdateLeadInput
    {
        [JsonProperty("TITLE")]
        public string Title { get; set; }

        [JsonProperty("FIRST_NAME")]
        public string FirstName { get; set; }

        [JsonProperty("LAST_NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("LEAD_DESCRIPTION")]
        public string LeadDescription { get; set; }

        [JsonProperty("CONVERTED_DATE_UTC")]
        public string ConvertedDateTime { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public UpdateLeadInputLeadVisibilityType? LeadVisibility { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int? VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int? VisibleUserIDs { get; set; }

        [JsonProperty("ORGANIZATION_NAME")]
        public string OrganizationName { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }

        [JsonProperty("MOBILE_PHONE_NUMBER")]
        public string MobilePhoneNumber { get; set; }

        [JsonProperty("EMAIL_ADDRESS")]
        public string EmailAddress { get; set; }

        [JsonProperty("CONVERTED")]
        public bool? IsConverted { get; set; }

        [JsonProperty("WEBSITE_URL")]
        public string WebsiteURL { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int? LeadOwner { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID")]
        public int? LeadResponsible { get; set; }

        [JsonProperty("EMPLOYEE_COUNT")]
        public int? LeadEmployeeCount { get; set; }

        [JsonProperty("LEAD_RATING")]
        public int? LeadRating { get; set; }

        [JsonProperty("INDUSTRY")]
        public string Industry { get; set; }

        [JsonProperty("TAGS")]
        public Tag[] Tag { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateLeadInputLeadVisibilityType
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class AddLeadInput
    {
        [JsonProperty("TITLE")]
        public string Title { get; set; }

        [JsonProperty("FIRST_NAME")]
        public string FirstName { get; set; }

        [JsonProperty("LAST_NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("LEAD_DESCRIPTION")]
        public string LeadDescription { get; set; }

        [JsonProperty("CONVERTED_DATE_UTC")]
        public string ConvertedDateTime { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public AddLeadInputLeadVisibilityType? LeadVisibility { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int? VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int? VisibleUserIDs { get; set; }

        [JsonProperty("ORGANIZATION_NAME")]
        public string OrganizationName { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }

        [JsonProperty("MOBILE_PHONE_NUMBER")]
        public string MobilePhoneNumber { get; set; }

        [JsonProperty("EMAIL_ADDRESS")]
        public string EmailAddress { get; set; }

        [JsonProperty("CONVERTED")]
        public bool? IsConverted { get; set; }

        [JsonProperty("WEBSITE_URL")]
        public string WebsiteURL { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int? LeadOwner { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID")]
        public int? LeadResponsible { get; set; }

        [JsonProperty("EMPLOYEE_COUNT")]
        public int? LeadEmployeeCount { get; set; }

        [JsonProperty("LEAD_RATING")]
        public int? LeadRating { get; set; }

        [JsonProperty("INDUSTRY")]
        public string Industry { get; set; }

        [JsonProperty("TAGS")]
        public Tag[] Tag { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddLeadInputLeadVisibilityType
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class ListContactsResponse
    {
        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }
    }

    public class Contact
    {
        [JsonProperty("ADDRESS_WORK")]
        public ContactAddressWorkType AddressWork { get; set; }

        [JsonProperty("ADDRESS_HOME")]
        public ContactAddressHomeType AddressHome { get; set; }

        [JsonProperty("ADDRESS_POSTAL")]
        public ContactAddressPostalType AddressPostal { get; set; }

        [JsonProperty("ADDRESS_PRIMARY")]
        public ContactAddressPrimaryType AddressPrimary { get; set; }

        [JsonProperty("ADDRESS_OTHER")]
        public ContactAddressOtherType AddressOther { get; set; }

        [JsonProperty("EMAIL_WORK")]
        public string EmailWork { get; set; }

        [JsonProperty("EMAIL_HOME")]
        public string EmailHome { get; set; }

        [JsonProperty("EMAIL_PERSONAL")]
        public string EmailPersonal { get; set; }

        [JsonProperty("EMAIL_OTHER")]
        public string EmailOther { get; set; }

        [JsonProperty("PHONE_WORK")]
        public string PhoneWork { get; set; }

        [JsonProperty("PHONE_HOME")]
        public string PhoneHome { get; set; }

        [JsonProperty("PHONE_MOBILE")]
        public string PhoneMobile { get; set; }

        [JsonProperty("PHONE_OTHER")]
        public string PhoneOther { get; set; }

        [JsonProperty("CONTACT_ID")]
        public int ContactId { get; set; }

        [JsonProperty("SALUTATION")]
        public string Salutation { get; set; }

        [JsonProperty("FIRST_NAME")]
        public string FirstName { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("IMAGE_URL")]
        public string ImageURL { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public string ContactVisibility { get; set; }

        [JsonProperty("BACKGROUND")]
        public string Background { get; set; }

        [JsonProperty("DEFAULT_LINKED_ORGANISATION")]
        public int DefaultLinkedOrganization { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int OwnerUserId { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int VisibleUserIDs { get; set; }

        [JsonProperty("CAN_EDIT")]
        public bool CanEdit { get; set; }

        [JsonProperty("CAN_DELETE")]
        public bool CanDelete { get; set; }

        [JsonProperty("SOCIAL_LINKEDIN")]
        public string SocialLinkedIn { get; set; }

        [JsonProperty("SOCIAL_FACEBOOK")]
        public string SocialFacebook { get; set; }

        [JsonProperty("SOCIAL_TWITTER")]
        public string SocialTwitter { get; set; }
    }

    public class ContactAddressWorkType
    {
        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }
    }

    public class ContactAddressHomeType
    {
        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }
    }

    public class ContactAddressPostalType
    {
        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }
    }

    public class ContactAddressPrimaryType
    {
        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }
    }

    public class ContactAddressOtherType
    {
        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }
    }

    public class UpdateContactInput
    {
        [JsonProperty("SALUTATION")]
        public string Salutation { get; set; }

        [JsonProperty("FIRST_NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("LAST_NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("BACKGROUND")]
        public string Background { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public UpdateContactInputContactVisibilityType? ContactVisibility { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int? VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int? VisibleUserIDs { get; set; }

        [JsonProperty("CONTACTINFOS")]
        public ContactInfo[] ContactInformation { get; set; }

        [JsonProperty("TAGS")]
        public Tag[] Tag { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateContactInputContactVisibilityType
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class ContactInfo
    {
        [JsonProperty("CONTACT_INFO_ID")]
        public int ContactInfoId { get; set; }

        [JsonProperty("TYPE")]
        public ContactInfoTypeType Type { get; set; }

        [JsonProperty("SUBTYPE")]
        public string SubType { get; set; }

        [JsonProperty("LABEL")]
        public string Label { get; set; }

        [JsonProperty("DETAIL")]
        public string Detail { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContactInfoTypeType
    {
        Phone,
        Email,
        Social,
        Website
    }

    public class AddContactInput
    {
        [JsonProperty("SALUTATION")]
        public string Salutation { get; set; }

        [JsonProperty("FIRST_NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("LAST_NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("BACKGROUND")]
        public string Background { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public AddContactInputContactVisibilityType? ContactVisibility { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int? VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int? VisibleUserIDs { get; set; }

        [JsonProperty("CONTACTINFOS")]
        public ContactInfo[] ContactInformation { get; set; }

        [JsonProperty("TAGS")]
        public Tag[] Tag { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddContactInputContactVisibilityType
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class ListUsersResponse
    {
        [JsonProperty("users")]
        public User[] Users { get; set; }
    }

    public class User
    {
        [JsonProperty("USER_ID")]
        public int UserId { get; set; }

        [JsonProperty("CONTACT_ID")]
        public int ContactId { get; set; }

        [JsonProperty("FIRST_NAME")]
        public string FirstName { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("EMAIL_ADDRESS")]
        public string EmailAddress { get; set; }

        [JsonProperty("TIMEZONE_ID")]
        public string TimeZoneId { get; set; }

        [JsonProperty("EMAIL_DROPBOX_IDENTIFIER")]
        public string EmailDropboxId { get; set; }

        [JsonProperty("EMAIL_DROPBOX_ADDRESS")]
        public string EmailDropboxAddress { get; set; }

        [JsonProperty("ADMINISTRATOR")]
        public bool IsAdministrator { get; set; }

        [JsonProperty("ACCOUNT_OWNER")]
        public bool IsAccountOwner { get; set; }

        [JsonProperty("ACTIVE")]
        public bool IsActive { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("USER_CURRENCY")]
        public string UserCurrency { get; set; }

        [JsonProperty("CONTACT_DISPLAY")]
        public string ContactDisplay { get; set; }

        [JsonProperty("CONTACT_ORDER")]
        public string ContactOrder { get; set; }

        [JsonProperty("TASK_WEEK_START")]
        public int TaskWeekStart { get; set; }

        [JsonProperty("INSTANCE_ID")]
        public int InstanceId { get; set; }
    }

    public class OrganizationInfo
    {
        [JsonProperty("ORGANISATION_ID")]
        public int OrganizationId { get; set; }

        [JsonProperty("ORGANISATION_BACKGROUND")]
        public string OrganizationBackground { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string OrganizationName { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int OrganizationOwner { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public string OrganizationVisibility { get; set; }

        [JsonProperty("ADDRESSES")]
        public Address[] Organization { get; set; }

        [JsonProperty("CONTACTINFOS")]
        public ContactInfo[] ContactInformation { get; set; }

        [JsonProperty("BACKGROUND")]
        public string Background { get; set; }

        [JsonProperty("IMAGE_URL")]
        public string ImageURL { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int VisibleUserIDs { get; set; }
    }

    public class Address
    {
        [JsonProperty("ADDRESS_ID")]
        public int AddressId { get; set; }

        [JsonProperty("ADDRESS_TYPE")]
        public string AddressType { get; set; }

        [JsonProperty("STREET")]
        public string AddressStreet { get; set; }

        [JsonProperty("CITY")]
        public string AddressCity { get; set; }

        [JsonProperty("STATE")]
        public string AddressState { get; set; }

        [JsonProperty("POSTCODE")]
        public string AddressPostcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string AddressCountry { get; set; }
    }

    public class AddOrganizationInput
    {
        [JsonProperty("ORGANISATION_NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganizationName { get; set; }

        [JsonProperty("ORGANISATION_BACKGROUND")]
        public string OrganizationBackground { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public AddOrganizationInputOrganizationVisibilityType? OrganizationVisibility { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int? VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int? VisibleUserIDs { get; set; }

        [JsonProperty("ADDRESSES")]
        public Address[] OrganizationAddress { get; set; }

        [JsonProperty("CONTACTINFOS")]
        public ContactInfo[] ContactInformation { get; set; }

        [JsonProperty("TAGS")]
        public Tag[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrganizationInputOrganizationVisibilityType
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class ListEventsResponse
    {
        [JsonProperty("events")]
        public Event[] Events { get; set; }
    }

    public class Event
    {
        [JsonProperty("EVENT_ID")]
        public int EventId { get; set; }

        [JsonProperty("TITLE")]
        public string Title { get; set; }

        [JsonProperty("START_DATE_UTC")]
        public string StartDateTime { get; set; }

        [JsonProperty("END_DATE_UTC")]
        public string EndDateTime { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int OwnerUserId { get; set; }

        [JsonProperty("REMINDER_SENT")]
        public bool IsReminderSent { get; set; }

        [JsonProperty("ALL_DAY")]
        public bool IsAllDayEvent { get; set; }

        [JsonProperty("PUBLICLY_VISIBLE")]
        public bool IsEventVisible { get; set; }

        [JsonProperty("CAN_EDIT")]
        public bool CanEdit { get; set; }

        [JsonProperty("CAN_DELETE")]
        public bool CanDelete { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Insightly;

    public partial class WorkflowManagedActions
    {
        public InsightlyActions Insightly(string connectionId) => new InsightlyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InsightlyTriggers Insightly(string connectionId) => new InsightlyTriggers(connectionId);
    }
}