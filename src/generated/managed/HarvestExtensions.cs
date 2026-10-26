//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Harvest
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HarvestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<ListAllContactsResponseItem[], ApiConnectionActionConfiguration> ListAllContacts()
        {
            return new DeferredBodyAction<ListAllContactsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListAllContactsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddNewContact(Expression<Func<AddNewContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<ListAllClientsResponseItem[], ApiConnectionActionConfiguration> ListAllClients()
        {
            return new DeferredBodyAction<ListAllClientsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/clients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListAllClientsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddNewClient(Expression<Func<AddNewClientInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/clients";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateUser(Expression<Func<CreateUserInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/people";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse, ApiConnectionActionConfiguration> UpdateTimeEntry(Expression<Func<string>> dAYENTRYId, Expression<Func<UpdateTimeEntryInput>> body)
        {
            var __workflow_dAYENTRYId = WorkflowExpression.Compile(dAYENTRYId, nameof(dAYENTRYId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateTimeEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/daily/update/{0}", __workflow_dAYENTRYId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTimeEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse, ApiConnectionActionConfiguration> CreateTimeEntry(Expression<Func<CreateTimeEntryInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateTimeEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/daily/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTimeEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<ListProjectsResponseItem[], ApiConnectionActionConfiguration> ListProjects()
        {
            return new DeferredBodyAction<ListProjectsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/projects/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListProjectsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTimeEntry(Expression<Func<string>> dAYENTRYId)
        {
            var __workflow_dAYENTRYId = WorkflowExpression.Compile(dAYENTRYId, nameof(dAYENTRYId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/daily/delete/{0}", __workflow_dAYENTRYId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddUserToProject(Expression<Func<string>> projectId, Expression<Func<AddUserToProjectInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/user_assignments", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse, ApiConnectionActionConfiguration> GetTimeEntry(Expression<Func<string>> dAYENTRYId)
        {
            var __workflow_dAYENTRYId = WorkflowExpression.Compile(dAYENTRYId, nameof(dAYENTRYId), required: true);
            return new DeferredBodyAction<UpdateTimeEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/daily/show/{0}", __workflow_dAYENTRYId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UpdateTimeEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<ListTasksResponseItem[], ApiConnectionActionConfiguration> ListTasks()
        {
            return new DeferredBodyAction<ListTasksResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListTasksResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<GetUserByIdResponse, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> uSERId)
        {
            var __workflow_uSERId = WorkflowExpression.Compile(uSERId, nameof(uSERId), required: true);
            return new DeferredBodyAction<GetUserByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/people/{0}", __workflow_uSERId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserByIdResponse>(callPayload);
            });
        }
    }

    public class HarvestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetUserByIdResponse[], ApiConnectionTriggerConfiguration> TrigNewUser(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<GetUserByIdResponse[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/people";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<GetUserByIdResponse[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListAllClientsResponseItem[], ApiConnectionTriggerConfiguration> TrigNewClient(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListAllClientsResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/clients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListAllClientsResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListAllContactsResponseItem[], ApiConnectionTriggerConfiguration> TrigNewContact(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListAllContactsResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListAllContactsResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListProjectsResponseItem[], ApiConnectionTriggerConfiguration> TrigNewProject(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListProjectsResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListProjectsResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetTimeEntriesForDayResponse, ApiConnectionTriggerConfiguration> TrigNewTimeEntryToday(Expression<Func<string>> ofUser = null, FlowRecurrence recurrence = null)
        {
            var __workflow_ofUser = WorkflowExpression.Compile(ofUser, nameof(ofUser), required: false);
            return new DeferredBodyTrigger<GetTimeEntriesForDayResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ofUser != null)
                    callPayload.Queries["of_user"] = ExpressionConverter.Convert(__workflow_ofUser);
                return new ApiConnectionTrigger<GetTimeEntriesForDayResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetTimeEntriesForDayResponse, ApiConnectionTriggerConfiguration> TrigNewTimeEntry(Expression<Func<string>> date, Expression<Func<string>> ofUser = null, FlowRecurrence recurrence = null)
        {
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: true);
            var __workflow_ofUser = WorkflowExpression.Compile(ofUser, nameof(ofUser), required: false);
            return new DeferredBodyTrigger<GetTimeEntriesForDayResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/daily/day/year";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_ofUser != null)
                    callPayload.Queries["of_user"] = ExpressionConverter.Convert(__workflow_ofUser);
                return new ApiConnectionTrigger<GetTimeEntriesForDayResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ListAllContactsResponseItem
    {
        [JsonProperty("contact")]
        public ListAllContactsResponseItemContactType Contact { get; set; }
    }

    public class ListAllContactsResponseItemContactType
    {
        [JsonProperty("id")]
        public int ContactId { get; set; }

        [JsonProperty("client_id")]
        public int ClientId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone_office")]
        public string OfficePhone { get; set; }

        [JsonProperty("phone_mobile")]
        public string MobilePhone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDateTime { get; set; }
    }

    public class AddNewContactInput
    {
        [JsonProperty("contact", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddNewContactInputContactType Contact { get; set; }
    }

    public class AddNewContactInputContactType
    {
        [JsonProperty("client_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ClientId { get; set; }

        [JsonProperty("first_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone_office")]
        public string OfficePhone { get; set; }

        [JsonProperty("phone_mobile")]
        public string MobilePhone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ListAllClientsResponseItem
    {
        [JsonProperty("client")]
        public ListAllClientsResponseItemClientType Client { get; set; }
    }

    public class ListAllClientsResponseItemClientType
    {
        [JsonProperty("id")]
        public int ClientId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("cache_version")]
        public int CacheVersion { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("statement_key")]
        public string StatementKey { get; set; }

        [JsonProperty("default_invoice_kind")]
        public string DefaultInvoiceKind { get; set; }

        [JsonProperty("default_invoice_timeframe")]
        public string DefaultInvoiceTimeframe { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("last_invoice_kind")]
        public string LastInvoiceKind { get; set; }
    }

    public class AddNewClientInput
    {
        [JsonProperty("client", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddNewClientInputClientType Client { get; set; }
    }

    public class AddNewClientInputClientType
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }
    }

    public class CreateUserInput
    {
        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateUserInputUserType User { get; set; }
    }

    public class CreateUserInputUserType
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("is_admin")]
        public bool? IsAdmin { get; set; }

        [JsonProperty("first_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("is_contractor")]
        public bool? IsContractor { get; set; }

        [JsonProperty("telephone")]
        public string Phone { get; set; }

        [JsonProperty("has_access_to_all_future_projects", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool HasAccessToAllFutureProjects { get; set; } = false;

        [JsonProperty("default_hourly_rate")]
        public double? HourlyRate { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("cost_rate")]
        public double? CostRate { get; set; }
    }

    public class UpdateTimeEntryResponse
    {
        [JsonProperty("id")]
        public int TimeEntryId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("spent_at")]
        public string Date { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("task_id")]
        public string TaskId { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("task")]
        public string TaskObject { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("hours_without_timer")]
        public double HoursWithoutTimer { get; set; }

        [JsonProperty("hours")]
        public double Hours { get; set; }
    }

    public class UpdateTimeEntryInput
    {
        [JsonProperty("project_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("task_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("started_at")]
        public string StartedDateTime { get; set; }

        [JsonProperty("ended_at")]
        public string EndedDateTime { get; set; }

        [JsonProperty("spent_at")]
        public string Date { get; set; }
    }

    public class CreateTimeEntryInput
    {
        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("hours")]
        public int? Hours { get; set; }

        [JsonProperty("project_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("task_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskId { get; set; }

        [JsonProperty("spent_at")]
        public string Date { get; set; }
    }

    public class ListProjectsResponseItem
    {
        [JsonProperty("project")]
        public ListProjectsResponseItemProjectType Project { get; set; }
    }

    public class ListProjectsResponseItemProjectType
    {
        [JsonProperty("id")]
        public int ProjectId { get; set; }

        [JsonProperty("client_id")]
        public int ClientId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("active")]
        public bool IsActive { get; set; }

        [JsonProperty("billable")]
        public bool IsBillable { get; set; }

        [JsonProperty("bill_by")]
        public string BillBy { get; set; }

        [JsonProperty("hourly_rate")]
        public double HourlyRate { get; set; }

        [JsonProperty("budget")]
        public double Budget { get; set; }

        [JsonProperty("budget_by")]
        public string BudgetBy { get; set; }

        [JsonProperty("notify_when_over_budget")]
        public bool NotifyWhenOverBudget { get; set; }

        [JsonProperty("over_budget_notification_percentage")]
        public double OverBudgetNotificationPercentage { get; set; }

        [JsonProperty("over_budget_notified_at")]
        public string OverBudgetNotifiedAt { get; set; }

        [JsonProperty("show_budget_to_all")]
        public bool ShowBudgetToAll { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("starts_on")]
        public string StartDate { get; set; }

        [JsonProperty("ends_on")]
        public string EndDate { get; set; }

        [JsonProperty("estimate")]
        public double Estimate { get; set; }

        [JsonProperty("estimate_by")]
        public string EstimatedBy { get; set; }

        [JsonProperty("hint_earliest_record_at")]
        public string EarliestRecordDate { get; set; }

        [JsonProperty("hint_latest_record_at")]
        public string LatestRecordDate { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("cost_budget")]
        public double CostBudget { get; set; }

        [JsonProperty("cost_budget_include_expenses")]
        public bool CostBudgetIncludesExpenses { get; set; }
    }

    public class AddUserToProjectInput
    {
        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddUserToProjectInputUserType User { get; set; }
    }

    public class AddUserToProjectInputUserType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UserId { get; set; }
    }

    public class ListTasksResponseItem
    {
        [JsonProperty("task")]
        public ListTasksResponseItemTaskObjectType TaskObject { get; set; }
    }

    public class ListTasksResponseItemTaskObjectType
    {
        [JsonProperty("id")]
        public int TaskId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("billable_by_default")]
        public bool Internal { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("default_hourly_rate")]
        public double DefaultHourlyRate { get; set; }

        [JsonProperty("deactivated")]
        public bool Deactivated { get; set; }
    }

    public class GetUserByIdResponse
    {
        [JsonProperty("user")]
        public GetUserByIdResponseUserType User { get; set; }
    }

    public class GetUserByIdResponseUserType
    {
        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("is_contractor")]
        public bool IsContractor { get; set; }

        [JsonProperty("telephone")]
        public string Phone { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("has_access_to_all_future_projects")]
        public bool HasAccessToAllFutureProjects { get; set; }

        [JsonProperty("default_hourly_rate")]
        public double HourlyRate { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("wants_newsletter")]
        public bool NewsletterSubscription { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("cost_rate")]
        public double CostRate { get; set; }

        [JsonProperty("weekly_capacity")]
        public int WeeklyCapacity { get; set; }
    }

    public class GetTimeEntriesForDayResponse
    {
        [JsonProperty("day_entries")]
        public GetTimeEntriesForDayResponseDayEntriesTypeItem[] DayEntries { get; set; }

        [JsonProperty("for_day")]
        public string ForDay { get; set; }
    }

    public class GetTimeEntriesForDayResponseDayEntriesTypeItem
    {
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("project")]
        public string ProjectName { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("spent_at")]
        public string Date { get; set; }

        [JsonProperty("task_id")]
        public string TaskId { get; set; }

        [JsonProperty("task")]
        public string TaskObject { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("id")]
        public int TimeEntryId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("started_at")]
        public string StartedDateTime { get; set; }

        [JsonProperty("ended_at")]
        public string EndedDateTime { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("hours_without_timer")]
        public double HoursWithoutTimer { get; set; }

        [JsonProperty("hours")]
        public double Hours { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Harvest;

    public partial class WorkflowManagedActions
    {
        public HarvestActions Harvest(string connectionId) => new HarvestActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HarvestTriggers Harvest(string connectionId) => new HarvestTriggers(connectionId);
    }
}