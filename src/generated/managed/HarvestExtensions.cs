//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Harvest
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HarvestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<ListAllContactsResponseItem[]> ListAllContacts()
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListAllContactsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<ListAllClientsResponseItem[]> ListAllClients()
        {
            var apiCallPath = "/clients";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListAllClientsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> UpdateTimeEntry(Expression<Func<string>> dAYENTRYID, Expression<Func<string>> bodyprojectId, Expression<Func<string>> bodytaskId, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodystartedDateTime = null, Expression<Func<string>> bodyendedDateTime = null, Expression<Func<string>> bodydate = null)
        {
            var apiCallPath = String.Format("/daily/update/{0}", ExpressionConverter.ConvertWithUrlEncoding(dAYENTRYID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
            bodypropCount++;
            body["task_id"] = ExpressionConverter.ConvertO(bodytaskId);
            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodystartedDateTime != null)
            {
                body["started_at"] = ExpressionConverter.ConvertO(bodystartedDateTime);
                bodypropCount++;
            }

            if (bodyendedDateTime != null)
            {
                body["ended_at"] = ExpressionConverter.ConvertO(bodyendedDateTime);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["spent_at"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateTimeEntryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> CreateTimeEntry(Expression<Func<string>> bodyprojectId, Expression<Func<string>> bodytaskId, Expression<Func<string>> bodynotes = null, Expression<Func<int>> bodyhours = null, Expression<Func<string>> bodydate = null)
        {
            var apiCallPath = "/daily/add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyhours != null)
            {
                body["hours"] = ExpressionConverter.ConvertO(bodyhours);
                bodypropCount++;
            }

            bodypropCount++;
            body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
            bodypropCount++;
            body["task_id"] = ExpressionConverter.ConvertO(bodytaskId);
            if (bodydate != null)
            {
                body["spent_at"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateTimeEntryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<ListProjectsResponseItem[]> ListProjects()
        {
            var apiCallPath = "/projects/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListProjectsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction DeleteTimeEntry(Expression<Func<string>> dAYENTRYID)
        {
            var apiCallPath = String.Format("/daily/delete/{0}", ExpressionConverter.ConvertWithUrlEncoding(dAYENTRYID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> GetTimeEntry(Expression<Func<string>> dAYENTRYID)
        {
            var apiCallPath = String.Format("/daily/show/{0}", ExpressionConverter.ConvertWithUrlEncoding(dAYENTRYID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UpdateTimeEntryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<ListTasksResponseItem[]> ListTasks()
        {
            var apiCallPath = "/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTasksResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<GetUserByIDResponse> GetUser(Expression<Func<string>> uSERID)
        {
            var apiCallPath = String.Format("/people/{0}", ExpressionConverter.ConvertWithUrlEncoding(uSERID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUserByIDResponse>(callPayload);
        }
    }

    public class HarvestTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<GetUserByIDResponse[]> TrigNewUser()
        {
            var apiCallPath = "/trigger/people";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetUserByIDResponse[]>(callPayload);
        }

        public IOutputWorkflowTrigger<ListAllClientsResponseItem[]> TrigNewClient()
        {
            var apiCallPath = "/trigger/clients";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListAllClientsResponseItem[]>(callPayload);
        }

        public IOutputWorkflowTrigger<ListAllContactsResponseItem[]> TrigNewContact()
        {
            var apiCallPath = "/trigger/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListAllContactsResponseItem[]>(callPayload);
        }

        public IOutputWorkflowTrigger<ListProjectsResponseItem[]> TrigNewProject()
        {
            var apiCallPath = "/trigger/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListProjectsResponseItem[]>(callPayload);
        }

        public IOutputWorkflowTrigger<GetTimeEntriesForDayResponse> TrigNewTimeEntryToday(Expression<Func<string>> ofUser = null)
        {
            var apiCallPath = "/trigger/daily";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ofUser != null)
                callPayload.Queries["of_user"] = ExpressionConverter.Convert(ofUser);
            return new ApiConnectionTrigger<GetTimeEntriesForDayResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<GetTimeEntriesForDayResponse> TrigNewTimeEntry(Expression<Func<string>> date, Expression<Func<string>> ofUser = null)
        {
            var apiCallPath = "/trigger/daily/day/year";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["date"] = ExpressionConverter.Convert(date);
            if (ofUser != null)
                callPayload.Queries["of_user"] = ExpressionConverter.Convert(ofUser);
            return new ApiConnectionTrigger<GetTimeEntriesForDayResponse>(callPayload);
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

    public class GetUserByIDResponse
    {
        [JsonProperty("user")]
        public GetUserByIDResponseUserType User { get; set; }
    }

    public class GetUserByIDResponseUserType
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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