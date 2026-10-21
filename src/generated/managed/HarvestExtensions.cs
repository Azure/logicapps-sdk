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
        public IBodyWorkflowAction<ListAllContactsResponseItem[]> ListAllContacts()
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListAllContactsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction AddNewContact(Expression<Func<int>> bodycontactclientId = null, Expression<Func<string>> bodycontactfirstName = null, Expression<Func<string>> bodycontactlastName = null, Expression<Func<string>> bodycontactemail = null, Expression<Func<string>> bodycontactofficePhone = null, Expression<Func<string>> bodycontactmobilePhone = null, Expression<Func<string>> bodycontactfax = null, Expression<Func<string>> bodycontacttitle = null)
        {
            var __workflow_bodycontactclientId = WorkflowExpression.Compile(bodycontactclientId, nameof(bodycontactclientId), required: false);
            var __workflow_bodycontactfirstName = WorkflowExpression.Compile(bodycontactfirstName, nameof(bodycontactfirstName), required: false);
            var __workflow_bodycontactlastName = WorkflowExpression.Compile(bodycontactlastName, nameof(bodycontactlastName), required: false);
            var __workflow_bodycontactemail = WorkflowExpression.Compile(bodycontactemail, nameof(bodycontactemail), required: false);
            var __workflow_bodycontactofficePhone = WorkflowExpression.Compile(bodycontactofficePhone, nameof(bodycontactofficePhone), required: false);
            var __workflow_bodycontactmobilePhone = WorkflowExpression.Compile(bodycontactmobilePhone, nameof(bodycontactmobilePhone), required: false);
            var __workflow_bodycontactfax = WorkflowExpression.Compile(bodycontactfax, nameof(bodycontactfax), required: false);
            var __workflow_bodycontacttitle = WorkflowExpression.Compile(bodycontacttitle, nameof(bodycontacttitle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                if (__workflow_bodycontactclientId != null)
                {
                    contactObject["client_id"] = ExpressionConverter.ConvertO(__workflow_bodycontactclientId);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactfirstName != null)
                {
                    contactObject["first_name"] = ExpressionConverter.ConvertO(__workflow_bodycontactfirstName);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactlastName != null)
                {
                    contactObject["last_name"] = ExpressionConverter.ConvertO(__workflow_bodycontactlastName);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactemail != null)
                {
                    contactObject["email"] = ExpressionConverter.ConvertO(__workflow_bodycontactemail);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactofficePhone != null)
                {
                    contactObject["phone_office"] = ExpressionConverter.ConvertO(__workflow_bodycontactofficePhone);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactmobilePhone != null)
                {
                    contactObject["phone_mobile"] = ExpressionConverter.ConvertO(__workflow_bodycontactmobilePhone);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactfax != null)
                {
                    contactObject["fax"] = ExpressionConverter.ConvertO(__workflow_bodycontactfax);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontacttitle != null)
                {
                    contactObject["title"] = ExpressionConverter.ConvertO(__workflow_bodycontacttitle);
                    contactObjectpropCount++;
                }

                if (contactObjectpropCount > 0)
                {
                    body["contact"] = contactObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
        public IWorkflowAction AddNewClient(Expression<Func<string>> bodyclientname = null, Expression<Func<string>> bodyclientcurrency = null, Expression<Func<string>> bodyclientcurrencySymbol = null, Expression<Func<string>> bodyclientdetails = null)
        {
            var __workflow_bodyclientname = WorkflowExpression.Compile(bodyclientname, nameof(bodyclientname), required: false);
            var __workflow_bodyclientcurrency = WorkflowExpression.Compile(bodyclientcurrency, nameof(bodyclientcurrency), required: false);
            var __workflow_bodyclientcurrencySymbol = WorkflowExpression.Compile(bodyclientcurrencySymbol, nameof(bodyclientcurrencySymbol), required: false);
            var __workflow_bodyclientdetails = WorkflowExpression.Compile(bodyclientdetails, nameof(bodyclientdetails), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/clients";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var clientObject = new JObject();
                var clientObjectpropCount = 0;
                if (__workflow_bodyclientname != null)
                {
                    clientObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyclientname);
                    clientObjectpropCount++;
                }

                if (__workflow_bodyclientcurrency != null)
                {
                    clientObject["currency"] = ExpressionConverter.ConvertO(__workflow_bodyclientcurrency);
                    clientObjectpropCount++;
                }

                if (__workflow_bodyclientcurrencySymbol != null)
                {
                    clientObject["currency_symbol"] = ExpressionConverter.ConvertO(__workflow_bodyclientcurrencySymbol);
                    clientObjectpropCount++;
                }

                if (__workflow_bodyclientdetails != null)
                {
                    clientObject["details"] = ExpressionConverter.ConvertO(__workflow_bodyclientdetails);
                    clientObjectpropCount++;
                }

                if (clientObjectpropCount > 0)
                {
                    body["client"] = clientObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction CreateUser(Expression<Func<string>> bodyuseremail = null, Expression<Func<bool>> bodyuserisAdmin = null, Expression<Func<string>> bodyuserfirstName = null, Expression<Func<string>> bodyuserlastName = null, Expression<Func<bool>> bodyuserisContractor = null, Expression<Func<string>> bodyuserphone = null, Expression<Func<double>> bodyuserhourlyRate = null, Expression<Func<string>> bodyuserdepartment = null, Expression<Func<double>> bodyusercostRate = null)
        {
            var __workflow_bodyuseremail = WorkflowExpression.Compile(bodyuseremail, nameof(bodyuseremail), required: false);
            var __workflow_bodyuserisAdmin = WorkflowExpression.Compile(bodyuserisAdmin, nameof(bodyuserisAdmin), required: false);
            var __workflow_bodyuserfirstName = WorkflowExpression.Compile(bodyuserfirstName, nameof(bodyuserfirstName), required: false);
            var __workflow_bodyuserlastName = WorkflowExpression.Compile(bodyuserlastName, nameof(bodyuserlastName), required: false);
            var __workflow_bodyuserisContractor = WorkflowExpression.Compile(bodyuserisContractor, nameof(bodyuserisContractor), required: false);
            var __workflow_bodyuserphone = WorkflowExpression.Compile(bodyuserphone, nameof(bodyuserphone), required: false);
            var __workflow_bodyuserhourlyRate = WorkflowExpression.Compile(bodyuserhourlyRate, nameof(bodyuserhourlyRate), required: false);
            var __workflow_bodyuserdepartment = WorkflowExpression.Compile(bodyuserdepartment, nameof(bodyuserdepartment), required: false);
            var __workflow_bodyusercostRate = WorkflowExpression.Compile(bodyusercostRate, nameof(bodyusercostRate), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/people";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var userObject = new JObject();
                var userObjectpropCount = 0;
                if (__workflow_bodyuseremail != null)
                {
                    userObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyuseremail);
                    userObjectpropCount++;
                }

                if (__workflow_bodyuserisAdmin != null)
                {
                    userObject["is_admin"] = ExpressionConverter.ConvertO(__workflow_bodyuserisAdmin);
                    userObjectpropCount++;
                }

                if (__workflow_bodyuserfirstName != null)
                {
                    userObject["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyuserfirstName);
                    userObjectpropCount++;
                }

                if (__workflow_bodyuserlastName != null)
                {
                    userObject["last_name"] = ExpressionConverter.ConvertO(__workflow_bodyuserlastName);
                    userObjectpropCount++;
                }

                if (__workflow_bodyuserisContractor != null)
                {
                    userObject["is_contractor"] = ExpressionConverter.ConvertO(__workflow_bodyuserisContractor);
                    userObjectpropCount++;
                }

                if (__workflow_bodyuserphone != null)
                {
                    userObject["telephone"] = ExpressionConverter.ConvertO(__workflow_bodyuserphone);
                    userObjectpropCount++;
                }

                userObject["has_access_to_all_future_projects"] = false;
                userObjectpropCount++;
                if (__workflow_bodyuserhourlyRate != null)
                {
                    userObject["default_hourly_rate"] = ExpressionConverter.ConvertO(__workflow_bodyuserhourlyRate);
                    userObjectpropCount++;
                }

                if (__workflow_bodyuserdepartment != null)
                {
                    userObject["department"] = ExpressionConverter.ConvertO(__workflow_bodyuserdepartment);
                    userObjectpropCount++;
                }

                if (__workflow_bodyusercostRate != null)
                {
                    userObject["cost_rate"] = ExpressionConverter.ConvertO(__workflow_bodyusercostRate);
                    userObjectpropCount++;
                }

                if (userObjectpropCount > 0)
                {
                    body["user"] = userObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> UpdateTimeEntry(Expression<Func<string>> dAYENTRYID, Expression<Func<string>> bodyprojectId, Expression<Func<string>> bodytaskId, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodystartedDateTime = null, Expression<Func<string>> bodyendedDateTime = null, Expression<Func<string>> bodydate = null)
        {
            var __workflow_dAYENTRYID = WorkflowExpression.Compile(dAYENTRYID, nameof(dAYENTRYID), required: true);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: true);
            var __workflow_bodytaskId = WorkflowExpression.Compile(bodytaskId, nameof(bodytaskId), required: true);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodystartedDateTime = WorkflowExpression.Compile(bodystartedDateTime, nameof(bodystartedDateTime), required: false);
            var __workflow_bodyendedDateTime = WorkflowExpression.Compile(bodyendedDateTime, nameof(bodyendedDateTime), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            return new DeferredBodyAction<UpdateTimeEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/daily/update/{0}", __workflow_dAYENTRYID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                bodypropCount++;
                body["task_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskId);
                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodystartedDateTime != null)
                {
                    body["started_at"] = ExpressionConverter.ConvertO(__workflow_bodystartedDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendedDateTime != null)
                {
                    body["ended_at"] = ExpressionConverter.ConvertO(__workflow_bodyendedDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["spent_at"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateTimeEntryResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> CreateTimeEntry(Expression<Func<string>> bodyprojectId, Expression<Func<string>> bodytaskId, Expression<Func<string>> bodynotes = null, Expression<Func<int>> bodyhours = null, Expression<Func<string>> bodydate = null)
        {
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: true);
            var __workflow_bodytaskId = WorkflowExpression.Compile(bodytaskId, nameof(bodytaskId), required: true);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyhours = WorkflowExpression.Compile(bodyhours, nameof(bodyhours), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            return new DeferredBodyAction<UpdateTimeEntryResponse>(() =>
            {
                var apiCallPath = "/daily/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyhours != null)
                {
                    body["hours"] = ExpressionConverter.ConvertO(__workflow_bodyhours);
                    bodypropCount++;
                }

                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                bodypropCount++;
                body["task_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskId);
                if (__workflow_bodydate != null)
                {
                    body["spent_at"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateTimeEntryResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
            var __workflow_dAYENTRYID = WorkflowExpression.Compile(dAYENTRYID, nameof(dAYENTRYID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/daily/delete/{0}", __workflow_dAYENTRYID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction AddUserToProject(Expression<Func<string>> projectId, Expression<Func<int>> bodyuseruserId = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_bodyuseruserId = WorkflowExpression.Compile(bodyuseruserId, nameof(bodyuseruserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/user_assignments", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var userObject = new JObject();
                var userObjectpropCount = 0;
                if (__workflow_bodyuseruserId != null)
                {
                    userObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyuseruserId);
                    userObjectpropCount++;
                }

                if (userObjectpropCount > 0)
                {
                    body["user"] = userObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> GetTimeEntry(Expression<Func<string>> dAYENTRYID)
        {
            var __workflow_dAYENTRYID = WorkflowExpression.Compile(dAYENTRYID, nameof(dAYENTRYID), required: true);
            return new DeferredBodyAction<UpdateTimeEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/daily/show/{0}", __workflow_dAYENTRYID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UpdateTimeEntryResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
            var __workflow_uSERID = WorkflowExpression.Compile(uSERID, nameof(uSERID), required: true);
            return new DeferredBodyAction<GetUserByIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/people/{0}", __workflow_uSERID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserByIDResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class HarvestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetUserByIDResponse[]> TrigNewUser(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/people";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetUserByIDResponse[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<ListAllClientsResponseItem[]> TrigNewClient(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/clients";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListAllClientsResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<ListAllContactsResponseItem[]> TrigNewContact(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListAllContactsResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<ListProjectsResponseItem[]> TrigNewProject(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListProjectsResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<GetTimeEntriesForDayResponse> TrigNewTimeEntryToday(Expression<Func<string>> ofUser = null, FlowRecurrence recurrence = null)
        {
            var __workflow_ofUser = WorkflowExpression.Compile(ofUser, nameof(ofUser), required: false);
            return new DeferredBodyTrigger<GetTimeEntriesForDayResponse>(() =>
            {
                var apiCallPath = "/trigger/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ofUser != null)
                    callPayload.Queries["of_user"] = ExpressionConverter.Convert(__workflow_ofUser);
                return new ApiConnectionTrigger<GetTimeEntriesForDayResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<GetTimeEntriesForDayResponse> TrigNewTimeEntry(Expression<Func<string>> date, Expression<Func<string>> ofUser = null, FlowRecurrence recurrence = null)
        {
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: true);
            var __workflow_ofUser = WorkflowExpression.Compile(ofUser, nameof(ofUser), required: false);
            return new DeferredBodyTrigger<GetTimeEntriesForDayResponse>(() =>
            {
                var apiCallPath = "/trigger/daily/day/year";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_ofUser != null)
                    callPayload.Queries["of_user"] = ExpressionConverter.Convert(__workflow_ofUser);
                return new ApiConnectionTrigger<GetTimeEntriesForDayResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
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
