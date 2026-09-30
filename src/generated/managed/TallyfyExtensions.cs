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
        public IBodyWorkflowAction<GetUserTasksResponse> GetUserTasks([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<int> userId, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(q, nameof(q), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(tag, nameof(tag), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/users/{1}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                if (tag != null)
                    callPayload.Queries["tag"] = SourceExpressionConverter.ConvertO(tag);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<GetUserTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<InviteUserToOrganizationResponse> InviteUserToOrganization([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<bodyroleInput> bodyrole)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodyrole, nameof(bodyrole), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/users/invite", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
                body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                bodypropCount++;
                body["role"] = SourceExpressionConverter.Convert(bodyrole);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InviteUserToOrganizationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<CreateRunResponse> CreateRun([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodychecklistId, [WorkflowExpression] Func<string> bodysummary = null)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodychecklistId, nameof(bodychecklistId), required: true);
            SourceExpression.Validate(bodysummary, nameof(bodysummary), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/runs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["checklist_id"] = SourceExpressionConverter.ConvertToken(bodychecklistId);
                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateRunResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> CompletedOneOffTask([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<bool> bodyisApproved = null)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(bodytaskId, nameof(bodytaskId), required: true);
            SourceExpression.Validate(bodyisApproved, nameof(bodyisApproved), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/completed-tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["task_id"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                if (bodyisApproved != null)
                {
                    body["is_approved"] = SourceExpressionConverter.ConvertToken(bodyisApproved);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> ReopenOneOffTask([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> task)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(task, nameof(task), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/completed-tasks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(task, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> CompletedProcessTask([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> run, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<bool> bodyisApproved = null)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(run, nameof(run), required: true);
            SourceExpression.Validate(bodytaskId, nameof(bodytaskId), required: true);
            SourceExpression.Validate(bodyisApproved, nameof(bodyisApproved), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/runs/{1}/completed-tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(run, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["task_id"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                if (bodyisApproved != null)
                {
                    body["is_approved"] = SourceExpressionConverter.ConvertToken(bodyisApproved);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> ReopenProcessTask([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> run, [WorkflowExpression] Func<string> task)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(run, nameof(run), required: true);
            SourceExpression.Validate(task, nameof(task), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/runs/{1}/completed-tasks/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(run, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(task, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> CommentTask([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> task, [WorkflowExpression] Func<string> bodycontent, [WorkflowExpression] Func<bodylabelInput> bodylabel)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(task, nameof(task), required: true);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: true);
            SourceExpression.Validate(bodylabel, nameof(bodylabel), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/tasks/{1}/comment", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(task, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                bodypropCount++;
                body["label"] = SourceExpressionConverter.Convert(bodylabel);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType, [WorkflowExpression] Func<string> bodydeadline, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<int[]> bodyownersusers = null, [WorkflowExpression] Func<string[]> bodyownersguests = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(bodytaskType, nameof(bodytaskType), required: true);
            SourceExpression.Validate(bodydeadline, nameof(bodydeadline), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyownersusers, nameof(bodyownersusers), required: false);
            SourceExpression.Validate(bodyownersguests, nameof(bodyownersguests), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/processes/micro-functions/organizations/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var ownersObject = new JObject();
                var ownersObjectpropCount = 0;
                if (bodyownersusers != null)
                {
                    ownersObject["users"] = SourceExpressionConverter.ConvertToken(bodyownersusers);
                    ownersObjectpropCount++;
                }

                if (bodyownersguests != null)
                {
                    ownersObject["guests"] = SourceExpressionConverter.ConvertToken(bodyownersguests);
                    ownersObjectpropCount++;
                }

                if (ownersObjectpropCount > 0)
                {
                    body["owners"] = ownersObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["task_type"] = SourceExpressionConverter.Convert(bodytaskType);
                bodypropCount++;
                body["deadline"] = SourceExpressionConverter.ConvertToken(bodydeadline);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> EditTaskDeadline([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> task, [WorkflowExpression] Func<string> bodydeadline = null)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(task, nameof(task), required: true);
            SourceExpression.Validate(bodydeadline, nameof(bodydeadline), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/processes/micro-functions/organizations/{0}/tasks/{1}/edit-deadline", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(task, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydeadline != null)
                {
                    body["Deadline"] = SourceExpressionConverter.ConvertToken(bodydeadline);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> RemoveGuest([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> task, [WorkflowExpression] Func<string> guest)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(task, nameof(task), required: true);
            SourceExpression.Validate(guest, nameof(guest), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/processes/micro-functions/organizations/{0}/tasks/{1}/remove-guest/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(task, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(guest, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> RemoveAssignee([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> task, [WorkflowExpression] Func<string> member)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(task, nameof(task), required: true);
            SourceExpression.Validate(member, nameof(member), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/processes/micro-functions/organizations/{0}/tasks/{1}/remove-assignee/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(task, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(member, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tallyfy")]
        public IBodyWorkflowAction<JToken> EditStepType([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> blueprint, [WorkflowExpression] Func<string> step, [WorkflowExpression] Func<bodystepTypeInput> bodystepType = null)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(blueprint, nameof(blueprint), required: true);
            SourceExpression.Validate(step, nameof(step), required: true);
            SourceExpression.Validate(bodystepType, nameof(bodystepType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/processes/micro-functions/organizations/{0}/blueprints/{1}/steps/{2}/edit-step-type", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(org, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blueprint, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(step, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystepType != null)
                {
                    body["stepType"] = SourceExpressionConverter.Convert(bodystepType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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