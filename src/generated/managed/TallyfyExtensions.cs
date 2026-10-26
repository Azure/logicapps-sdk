//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tallyfy
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TallyfyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<GetUserTasksResponse, ApiConnectionActionConfiguration> GetUserTasks(Expression<Func<string>> org, Expression<Func<int>> userId, Expression<Func<string>> q = null, Expression<Func<statusInput>> status = null, Expression<Func<sortInput>> sort = null, Expression<Func<string>> tag = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<GetUserTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/users/{1}/tasks", __workflow_org.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_tag != null)
                    callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<GetUserTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<InviteUserToOrganizationResponse, ApiConnectionActionConfiguration> InviteUserToOrganization(Expression<Func<string>> org, Expression<Func<InviteUserToOrganizationInput>> body)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InviteUserToOrganizationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/users/invite", __workflow_org.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InviteUserToOrganizationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<CreateRunResponse, ApiConnectionActionConfiguration> CreateRun(Expression<Func<string>> org, Expression<Func<CreateRunInput>> body)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateRunResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/runs", __workflow_org.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CompletedOneOffTask(Expression<Func<string>> org, Expression<Func<CompletedOneOffTaskInput>> body)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/completed-tasks", __workflow_org.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ReopenOneOffTask(Expression<Func<string>> org, Expression<Func<string>> task)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/completed-tasks/{1}", __workflow_org.WithUrlEncoding(1), __workflow_task.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CompletedProcessTask(Expression<Func<string>> org, Expression<Func<string>> run, Expression<Func<CompletedProcessTaskInput>> body)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_run = WorkflowExpression.Compile(run, nameof(run), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/runs/{1}/completed-tasks", __workflow_org.WithUrlEncoding(1), __workflow_run.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ReopenProcessTask(Expression<Func<string>> org, Expression<Func<string>> run, Expression<Func<string>> task)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_run = WorkflowExpression.Compile(run, nameof(run), required: true);
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/runs/{1}/completed-tasks/{2}", __workflow_org.WithUrlEncoding(1), __workflow_run.WithUrlEncoding(1), __workflow_task.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CommentTask(Expression<Func<string>> org, Expression<Func<string>> task, Expression<Func<CommentTaskInput>> body)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/tasks/{1}/comment", __workflow_org.WithUrlEncoding(1), __workflow_task.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<CreateTaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<string>> org, Expression<Func<CreateTaskInput>> body)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/processes/micro-functions/organizations/{0}/tasks", __workflow_org.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EditTaskDeadline(Expression<Func<string>> org, Expression<Func<string>> task, Expression<Func<EditTaskDeadlineInput>> body)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/processes/micro-functions/organizations/{0}/tasks/{1}/edit-deadline", __workflow_org.WithUrlEncoding(1), __workflow_task.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> RemoveGuest(Expression<Func<string>> org, Expression<Func<string>> task, Expression<Func<string>> guest)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            var __workflow_guest = WorkflowExpression.Compile(guest, nameof(guest), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/processes/micro-functions/organizations/{0}/tasks/{1}/remove-guest/{2}", __workflow_org.WithUrlEncoding(1), __workflow_task.WithUrlEncoding(1), __workflow_guest.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> RemoveAssignee(Expression<Func<string>> org, Expression<Func<string>> task, Expression<Func<string>> member)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            var __workflow_member = WorkflowExpression.Compile(member, nameof(member), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/processes/micro-functions/organizations/{0}/tasks/{1}/remove-assignee/{2}", __workflow_org.WithUrlEncoding(1), __workflow_task.WithUrlEncoding(1), __workflow_member.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EditStepType(Expression<Func<string>> org, Expression<Func<string>> blueprint, Expression<Func<string>> step, Expression<Func<EditStepTypeInput>> body)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_blueprint = WorkflowExpression.Compile(blueprint, nameof(blueprint), required: true);
            var __workflow_step = WorkflowExpression.Compile(step, nameof(step), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/processes/micro-functions/organizations/{0}/blueprints/{1}/steps/{2}/edit-step-type", __workflow_org.WithUrlEncoding(1), __workflow_blueprint.WithUrlEncoding(1), __workflow_step.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class TallyfyTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetUserTasksResponse
    {
        [JsonProperty("data")]
        public GetUserTasksResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public GetUserTasksResponseMetaType Meta { get; set; }
    }

    public class GetUserTasksResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("run_id")]
        public string RunId { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("owners")]
        public GetUserTasksResponseDataTypeItemOwnersType Owners { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("archived_at")]
        public string ArchivedAt { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("starter_id")]
        public int StarterId { get; set; }

        [JsonProperty("completer_id")]
        public int CompleterId { get; set; }

        [JsonProperty("run_status")]
        public string RunStatus { get; set; }
    }

    public class GetUserTasksResponseDataTypeItemOwnersType
    {
        [JsonProperty("users")]
        public int[] Users { get; set; }

        [JsonProperty("guests")]
        public string[] Guests { get; set; }
    }

    public class GetUserTasksResponseMetaType
    {
        [JsonProperty("overdue_tasks")]
        public int OverdueTasks { get; set; }

        [JsonProperty("tasks_due_soon")]
        public int TasksDueSoon { get; set; }

        [JsonProperty("pagination")]
        public GetUserTasksResponseMetaTypePaginationType Pagination { get; set; }
    }

    public class GetUserTasksResponseMetaTypePaginationType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        [EnumMember(Value = "hasproblem")]
        Hasproblem,
        [EnumMember(Value = "overdue")]
        Overdue,
        [EnumMember(Value = "due_soon")]
        DueSoon,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "incomplete")]
        Incomplete,
        [EnumMember(Value = "inprogress")]
        Inprogress
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortInput
    {
        [EnumMember(Value = "deadline")]
        Deadline,
        [EnumMember(Value = "newest")]
        Newest,
        [EnumMember(Value = "problems")]
        Problems
    }

    public class InviteUserToOrganizationResponse
    {
        [JsonProperty("data")]
        public InviteUserToOrganizationResponseDataType Data { get; set; }
    }

    public class InviteUserToOrganizationResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("profile_pic")]
        public string ProfilePic { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("complete")]
        public bool Complete { get; set; }

        [JsonProperty("is_suspended")]
        public bool IsSuspended { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("last_login_at")]
        public string LastLoginAt { get; set; }

        [JsonProperty("support_user")]
        public bool SupportUser { get; set; }

        [JsonProperty("country")]
        public InviteUserToOrganizationResponseDataTypeCountryType Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("job_description")]
        public string JobDescription { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("UTC_offset")]
        public string UTCOffset { get; set; }

        [JsonProperty("last_accessed_at")]
        public string LastAccessedAt { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonProperty("disabled_at")]
        public string DisabledAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InviteUserToOrganizationResponseDataTypeCountryType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone_code")]
        public string PhoneCode { get; set; }

        [JsonProperty("iso2")]
        public string Iso2 { get; set; }
    }

    public class InviteUserToOrganizationInput
    {
        [JsonProperty("first_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public InviteUserToOrganizationInputRoleType Role { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteUserToOrganizationInputRoleType
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "admin")]
        Admin
    }

    public class CreateRunResponse
    {
        [JsonProperty("data")]
        public CreateRunResponseDataType Data { get; set; }
    }

    public class CreateRunResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("checklist_id")]
        public string ChecklistId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("progress")]
        public CreateRunResponseDataTypeProgressType Progress { get; set; }

        [JsonProperty("started_by")]
        public int StartedBy { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("prerun")]
        public CreateRunResponseDataTypePrerunTypeItem[] Prerun { get; set; }

        [JsonProperty("starred")]
        public bool Starred { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("archived_at")]
        public string ArchivedAt { get; set; }

        [JsonProperty("due_date_passed")]
        public bool DueDatePassed { get; set; }

        [JsonProperty("collaborators")]
        public int[] Collaborators { get; set; }

        [JsonProperty("due_soon")]
        public bool DueSoon { get; set; }

        [JsonProperty("max_task_deadline")]
        public string MaxTaskDeadline { get; set; }
    }

    public class CreateRunResponseDataTypeProgressType
    {
        [JsonProperty("complete")]
        public int Complete { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("percent")]
        public int Percent { get; set; }
    }

    public class CreateRunResponseDataTypePrerunTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("field_type")]
        public string FieldType { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("options")]
        public string Options { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRunInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("checklist_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChecklistId { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class CompletedOneOffTaskInput
    {
        [JsonProperty("task_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskId { get; set; }

        [JsonProperty("is_approved")]
        public bool? IsApproved { get; set; }
    }

    public class CompletedProcessTaskInput
    {
        [JsonProperty("task_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskId { get; set; }

        [JsonProperty("is_approved")]
        public bool? IsApproved { get; set; }
    }

    public class CommentTaskInput
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("label", DefaultValueHandling = DefaultValueHandling.Include)]
        public CommentTaskInputLabelType Label { get; set; } = CommentTaskInputLabelType.Comment;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommentTaskInputLabelType
    {
        [EnumMember(Value = "comment")]
        Comment,
        [EnumMember(Value = "problem")]
        Problem,
        [EnumMember(Value = "resolve")]
        Resolve
    }

    public class CreateTaskResponse
    {
        [JsonProperty("data")]
        public CreateTaskResponseDataType Data { get; set; }
    }

    public class CreateTaskResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
    }

    public class CreateTaskInput
    {
        [JsonProperty("owners")]
        public CreateTaskInputOwnersType Owners { get; set; }

        [JsonProperty("task_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTaskInputTaskTypeType TaskType { get; set; } = CreateTaskInputTaskTypeType.TaskObject;

        [JsonProperty("deadline", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Deadline { get; set; } = "addDays(utcNow(), 1, 'yyyy-MM-dd HH:mm:ss')";

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class CreateTaskInputOwnersType
    {
        [JsonProperty("users")]
        public int[] Users { get; set; }

        [JsonProperty("guests")]
        public string[] Guests { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTaskInputTaskTypeType
    {
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "approval")]
        Approval,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "expiring")]
        Expiring
    }

    public class EditTaskDeadlineInput
    {
        public string Deadline { get; set; }
    }

    public class EditStepTypeInput
    {
        [JsonProperty("stepType")]
        public EditStepTypeInputStepTypeType? StepType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EditStepTypeInputStepTypeType
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "any")]
        Any
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tallyfy;

    public partial class WorkflowManagedActions
    {
        public TallyfyActions Tallyfy(string connectionId) => new TallyfyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TallyfyTriggers Tallyfy(string connectionId) => new TallyfyTriggers(connectionId);
    }
}