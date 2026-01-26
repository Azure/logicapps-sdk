//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tallyfy
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TallyfyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<GetUserTasksResponse> GetUserTasks(Expression<Func<string>> org, Expression<Func<int>> userId, Expression<Func<string>> q = null, Expression<Func<statusInput>> status = null, Expression<Func<sortInput>> sort = null, Expression<Func<string>> tag = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/organizations/{0}/users/{1}/tasks", ExpressionConverter.ConvertWithUrlEncoding(org, 1), ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (tag != null)
                callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<GetUserTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<InviteUserToOrganizationResponse> InviteUserToOrganization(Expression<Func<string>> org, Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodymessage, Expression<Func<bodyroleInput>> bodyrole)
        {
            var apiCallPath = String.Format("/organizations/{0}/users/invite", ExpressionConverter.ConvertWithUrlEncoding(org, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
            bodypropCount++;
            body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            bodypropCount++;
            body["message"] = ExpressionConverter.ConvertO(bodymessage);
            bodypropCount++;
            body["role"] = ExpressionConverter.ConvertO(bodyrole);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<InviteUserToOrganizationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<CreateRunResponse> CreateRun(Expression<Func<string>> org, Expression<Func<string>> bodyname, Expression<Func<string>> bodychecklistId, Expression<Func<string>> bodysummary = null)
        {
            var apiCallPath = String.Format("/organizations/{0}/runs", ExpressionConverter.ConvertWithUrlEncoding(org, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["checklist_id"] = ExpressionConverter.ConvertO(bodychecklistId);
            if (bodysummary != null)
            {
                body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateRunResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> CompletedOneOffTask(Expression<Func<string>> org, Expression<Func<string>> bodytaskId, Expression<Func<bool>> bodyisApproved = null)
        {
            var apiCallPath = String.Format("/organizations/{0}/completed-tasks", ExpressionConverter.ConvertWithUrlEncoding(org, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["task_id"] = ExpressionConverter.ConvertO(bodytaskId);
            if (bodyisApproved != null)
            {
                body["is_approved"] = ExpressionConverter.ConvertO(bodyisApproved);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> ReopenOneOffTask(Expression<Func<string>> org, Expression<Func<string>> task)
        {
            var apiCallPath = String.Format("/organizations/{0}/completed-tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(org, 1), ExpressionConverter.ConvertWithUrlEncoding(task, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> CompletedProcessTask(Expression<Func<string>> org, Expression<Func<string>> run, Expression<Func<string>> bodytaskId, Expression<Func<bool>> bodyisApproved = null)
        {
            var apiCallPath = String.Format("/organizations/{0}/runs/{1}/completed-tasks", ExpressionConverter.ConvertWithUrlEncoding(org, 1), ExpressionConverter.ConvertWithUrlEncoding(run, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["task_id"] = ExpressionConverter.ConvertO(bodytaskId);
            if (bodyisApproved != null)
            {
                body["is_approved"] = ExpressionConverter.ConvertO(bodyisApproved);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> ReopenProcessTask(Expression<Func<string>> org, Expression<Func<string>> run, Expression<Func<string>> task)
        {
            var apiCallPath = String.Format("/organizations/{0}/runs/{1}/completed-tasks/{2}", ExpressionConverter.ConvertWithUrlEncoding(org, 1), ExpressionConverter.ConvertWithUrlEncoding(run, 1), ExpressionConverter.ConvertWithUrlEncoding(task, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> CommentTask(Expression<Func<string>> org, Expression<Func<string>> task, Expression<Func<string>> bodycontent, Expression<Func<bodylabelInput>> bodylabel)
        {
            var apiCallPath = String.Format("/organizations/{0}/tasks/{1}/comment", ExpressionConverter.ConvertWithUrlEncoding(org, 1), ExpressionConverter.ConvertWithUrlEncoding(task, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["content"] = ExpressionConverter.ConvertO(bodycontent);
            bodypropCount++;
            body["label"] = ExpressionConverter.ConvertO(bodylabel);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> org, Expression<Func<bodytaskTypeInput>> bodytaskType, Expression<Func<string>> bodydeadline, Expression<Func<string>> bodyname, Expression<Func<int[]>> bodyownersusers = null, Expression<Func<string[]>> bodyownersguests = null, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = String.Format("/processes/micro-functions/organizations/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(org, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var ownersObject = new JObject();
            var ownersObjectpropCount = 0;
            if (bodyownersusers != null)
            {
                ownersObject["users"] = ExpressionConverter.ConvertO(bodyownersusers);
                ownersObjectpropCount++;
            }

            if (bodyownersguests != null)
            {
                ownersObject["guests"] = ExpressionConverter.ConvertO(bodyownersguests);
                ownersObjectpropCount++;
            }

            if (ownersObjectpropCount > 0)
            {
                body["owners"] = ownersObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["task_type"] = ExpressionConverter.ConvertO(bodytaskType);
            bodypropCount++;
            body["deadline"] = ExpressionConverter.ConvertO(bodydeadline);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> EditTaskDeadline(Expression<Func<string>> org, Expression<Func<string>> task, Expression<Func<string>> bodyDeadline = null)
        {
            var apiCallPath = String.Format("/processes/micro-functions/organizations/{0}/tasks/{1}/edit-deadline", ExpressionConverter.ConvertWithUrlEncoding(org, 1), ExpressionConverter.ConvertWithUrlEncoding(task, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDeadline != null)
            {
                body["Deadline"] = ExpressionConverter.ConvertO(bodyDeadline);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> RemoveGuest(Expression<Func<string>> org, Expression<Func<string>> task, Expression<Func<string>> guest)
        {
            var apiCallPath = String.Format("/processes/micro-functions/organizations/{0}/tasks/{1}/remove-guest/{2}", ExpressionConverter.ConvertWithUrlEncoding(org, 1), ExpressionConverter.ConvertWithUrlEncoding(task, 1), ExpressionConverter.ConvertWithUrlEncoding(guest, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> RemoveAssignee(Expression<Func<string>> org, Expression<Func<string>> task, Expression<Func<string>> member)
        {
            var apiCallPath = String.Format("/processes/micro-functions/organizations/{0}/tasks/{1}/remove-assignee/{2}", ExpressionConverter.ConvertWithUrlEncoding(org, 1), ExpressionConverter.ConvertWithUrlEncoding(task, 1), ExpressionConverter.ConvertWithUrlEncoding(member, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> EditStepType(Expression<Func<string>> org, Expression<Func<string>> blueprint, Expression<Func<string>> step, Expression<Func<bodystepTypeInput>> bodystepType = null)
        {
            var apiCallPath = String.Format("/processes/micro-functions/organizations/{0}/blueprints/{1}/steps/{2}/edit-step-type", ExpressionConverter.ConvertWithUrlEncoding(org, 1), ExpressionConverter.ConvertWithUrlEncoding(blueprint, 1), ExpressionConverter.ConvertWithUrlEncoding(step, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystepType != null)
            {
                body["stepType"] = ExpressionConverter.ConvertO(bodystepType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
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

    public enum bodyroleInput
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

    public enum bodylabelInput
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

    public enum bodytaskTypeInput
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

    public enum bodystepTypeInput
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