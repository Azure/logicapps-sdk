//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Harvest
{
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
        [WorkflowExpressionFactory(nameof(__BuildAddNewContact))]
        public IWorkflowAction AddNewContact([WorkflowExpression] Func<int> bodycontactclientId = null, [WorkflowExpression] Func<string> bodycontactfirstName = null, [WorkflowExpression] Func<string> bodycontactlastName = null, [WorkflowExpression] Func<string> bodycontactemail = null, [WorkflowExpression] Func<string> bodycontactofficePhone = null, [WorkflowExpression] Func<string> bodycontactmobilePhone = null, [WorkflowExpression] Func<string> bodycontactfax = null, [WorkflowExpression] Func<string> bodycontacttitle = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddNewContact(WorkflowValue<int> bodycontactclientId = null, WorkflowValue<string> bodycontactfirstName = null, WorkflowValue<string> bodycontactlastName = null, WorkflowValue<string> bodycontactemail = null, WorkflowValue<string> bodycontactofficePhone = null, WorkflowValue<string> bodycontactmobilePhone = null, WorkflowValue<string> bodycontactfax = null, WorkflowValue<string> bodycontacttitle = null)
        {
            WorkflowValue.Validate(bodycontactclientId, nameof(bodycontactclientId), required: false);
            WorkflowValue.Validate(bodycontactfirstName, nameof(bodycontactfirstName), required: false);
            WorkflowValue.Validate(bodycontactlastName, nameof(bodycontactlastName), required: false);
            WorkflowValue.Validate(bodycontactemail, nameof(bodycontactemail), required: false);
            WorkflowValue.Validate(bodycontactofficePhone, nameof(bodycontactofficePhone), required: false);
            WorkflowValue.Validate(bodycontactmobilePhone, nameof(bodycontactmobilePhone), required: false);
            WorkflowValue.Validate(bodycontactfax, nameof(bodycontactfax), required: false);
            WorkflowValue.Validate(bodycontacttitle, nameof(bodycontacttitle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                if (bodycontactclientId != null)
                {
                    contactObject["client_id"] = ExpressionConverter.ConvertO(bodycontactclientId);
                    contactObjectpropCount++;
                }

                if (bodycontactfirstName != null)
                {
                    contactObject["first_name"] = ExpressionConverter.ConvertO(bodycontactfirstName);
                    contactObjectpropCount++;
                }

                if (bodycontactlastName != null)
                {
                    contactObject["last_name"] = ExpressionConverter.ConvertO(bodycontactlastName);
                    contactObjectpropCount++;
                }

                if (bodycontactemail != null)
                {
                    contactObject["email"] = ExpressionConverter.ConvertO(bodycontactemail);
                    contactObjectpropCount++;
                }

                if (bodycontactofficePhone != null)
                {
                    contactObject["phone_office"] = ExpressionConverter.ConvertO(bodycontactofficePhone);
                    contactObjectpropCount++;
                }

                if (bodycontactmobilePhone != null)
                {
                    contactObject["phone_mobile"] = ExpressionConverter.ConvertO(bodycontactmobilePhone);
                    contactObjectpropCount++;
                }

                if (bodycontactfax != null)
                {
                    contactObject["fax"] = ExpressionConverter.ConvertO(bodycontactfax);
                    contactObjectpropCount++;
                }

                if (bodycontacttitle != null)
                {
                    contactObject["title"] = ExpressionConverter.ConvertO(bodycontacttitle);
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildAddNewClient))]
        public IWorkflowAction AddNewClient([WorkflowExpression] Func<string> bodyclientname = null, [WorkflowExpression] Func<string> bodyclientcurrency = null, [WorkflowExpression] Func<string> bodyclientcurrencySymbol = null, [WorkflowExpression] Func<string> bodyclientdetails = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddNewClient(WorkflowValue<string> bodyclientname = null, WorkflowValue<string> bodyclientcurrency = null, WorkflowValue<string> bodyclientcurrencySymbol = null, WorkflowValue<string> bodyclientdetails = null)
        {
            WorkflowValue.Validate(bodyclientname, nameof(bodyclientname), required: false);
            WorkflowValue.Validate(bodyclientcurrency, nameof(bodyclientcurrency), required: false);
            WorkflowValue.Validate(bodyclientcurrencySymbol, nameof(bodyclientcurrencySymbol), required: false);
            WorkflowValue.Validate(bodyclientdetails, nameof(bodyclientdetails), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/clients";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var clientObject = new JObject();
                var clientObjectpropCount = 0;
                if (bodyclientname != null)
                {
                    clientObject["name"] = ExpressionConverter.ConvertO(bodyclientname);
                    clientObjectpropCount++;
                }

                if (bodyclientcurrency != null)
                {
                    clientObject["currency"] = ExpressionConverter.ConvertO(bodyclientcurrency);
                    clientObjectpropCount++;
                }

                if (bodyclientcurrencySymbol != null)
                {
                    clientObject["currency_symbol"] = ExpressionConverter.ConvertO(bodyclientcurrencySymbol);
                    clientObjectpropCount++;
                }

                if (bodyclientdetails != null)
                {
                    clientObject["details"] = ExpressionConverter.ConvertO(bodyclientdetails);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        [WorkflowExpressionFactory(nameof(__BuildCreateUser))]
        public IWorkflowAction CreateUser([WorkflowExpression] Func<string> bodyuseremail = null, [WorkflowExpression] Func<bool> bodyuserisAdmin = null, [WorkflowExpression] Func<string> bodyuserfirstName = null, [WorkflowExpression] Func<string> bodyuserlastName = null, [WorkflowExpression] Func<bool> bodyuserisContractor = null, [WorkflowExpression] Func<string> bodyuserphone = null, [WorkflowExpression] Func<double> bodyuserhourlyRate = null, [WorkflowExpression] Func<string> bodyuserdepartment = null, [WorkflowExpression] Func<double> bodyusercostRate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateUser(WorkflowValue<string> bodyuseremail = null, WorkflowValue<bool> bodyuserisAdmin = null, WorkflowValue<string> bodyuserfirstName = null, WorkflowValue<string> bodyuserlastName = null, WorkflowValue<bool> bodyuserisContractor = null, WorkflowValue<string> bodyuserphone = null, WorkflowValue<double> bodyuserhourlyRate = null, WorkflowValue<string> bodyuserdepartment = null, WorkflowValue<double> bodyusercostRate = null)
        {
            WorkflowValue.Validate(bodyuseremail, nameof(bodyuseremail), required: false);
            WorkflowValue.Validate(bodyuserisAdmin, nameof(bodyuserisAdmin), required: false);
            WorkflowValue.Validate(bodyuserfirstName, nameof(bodyuserfirstName), required: false);
            WorkflowValue.Validate(bodyuserlastName, nameof(bodyuserlastName), required: false);
            WorkflowValue.Validate(bodyuserisContractor, nameof(bodyuserisContractor), required: false);
            WorkflowValue.Validate(bodyuserphone, nameof(bodyuserphone), required: false);
            WorkflowValue.Validate(bodyuserhourlyRate, nameof(bodyuserhourlyRate), required: false);
            WorkflowValue.Validate(bodyuserdepartment, nameof(bodyuserdepartment), required: false);
            WorkflowValue.Validate(bodyusercostRate, nameof(bodyusercostRate), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/people";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var userObject = new JObject();
                var userObjectpropCount = 0;
                if (bodyuseremail != null)
                {
                    userObject["email"] = ExpressionConverter.ConvertO(bodyuseremail);
                    userObjectpropCount++;
                }

                if (bodyuserisAdmin != null)
                {
                    userObject["is_admin"] = ExpressionConverter.ConvertO(bodyuserisAdmin);
                    userObjectpropCount++;
                }

                if (bodyuserfirstName != null)
                {
                    userObject["first_name"] = ExpressionConverter.ConvertO(bodyuserfirstName);
                    userObjectpropCount++;
                }

                if (bodyuserlastName != null)
                {
                    userObject["last_name"] = ExpressionConverter.ConvertO(bodyuserlastName);
                    userObjectpropCount++;
                }

                if (bodyuserisContractor != null)
                {
                    userObject["is_contractor"] = ExpressionConverter.ConvertO(bodyuserisContractor);
                    userObjectpropCount++;
                }

                if (bodyuserphone != null)
                {
                    userObject["telephone"] = ExpressionConverter.ConvertO(bodyuserphone);
                    userObjectpropCount++;
                }

                userObject["has_access_to_all_future_projects"] = false;
                userObjectpropCount++;
                if (bodyuserhourlyRate != null)
                {
                    userObject["default_hourly_rate"] = ExpressionConverter.ConvertO(bodyuserhourlyRate);
                    userObjectpropCount++;
                }

                if (bodyuserdepartment != null)
                {
                    userObject["department"] = ExpressionConverter.ConvertO(bodyuserdepartment);
                    userObjectpropCount++;
                }

                if (bodyusercostRate != null)
                {
                    userObject["cost_rate"] = ExpressionConverter.ConvertO(bodyusercostRate);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTimeEntry))]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> UpdateTimeEntry([WorkflowExpression] Func<string> dAYENTRYID, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodystartedDateTime = null, [WorkflowExpression] Func<string> bodyendedDateTime = null, [WorkflowExpression] Func<string> bodydate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> __BuildUpdateTimeEntry(WorkflowValue<string> dAYENTRYID, WorkflowValue<string> bodyprojectId, WorkflowValue<string> bodytaskId, WorkflowValue<string> bodynotes = null, WorkflowValue<string> bodystartedDateTime = null, WorkflowValue<string> bodyendedDateTime = null, WorkflowValue<string> bodydate = null)
        {
            WorkflowValue.Validate(dAYENTRYID, nameof(dAYENTRYID), required: true);
            WorkflowValue.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            WorkflowValue.Validate(bodytaskId, nameof(bodytaskId), required: true);
            WorkflowValue.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowValue.Validate(bodystartedDateTime, nameof(bodystartedDateTime), required: false);
            WorkflowValue.Validate(bodyendedDateTime, nameof(bodyendedDateTime), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            return new DeferredBodyAction<UpdateTimeEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/daily/update/{0}", ExpressionConverter.ConvertWithUrlEncoding(dAYENTRYID, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTimeEntry))]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> CreateTimeEntry([WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<int> bodyhours = null, [WorkflowExpression] Func<string> bodydate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> __BuildCreateTimeEntry(WorkflowValue<string> bodyprojectId, WorkflowValue<string> bodytaskId, WorkflowValue<string> bodynotes = null, WorkflowValue<int> bodyhours = null, WorkflowValue<string> bodydate = null)
        {
            WorkflowValue.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            WorkflowValue.Validate(bodytaskId, nameof(bodytaskId), required: true);
            WorkflowValue.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowValue.Validate(bodyhours, nameof(bodyhours), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            return new DeferredBodyAction<UpdateTimeEntryResponse>(() =>
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteTimeEntry))]
        public IWorkflowAction DeleteTimeEntry([WorkflowExpression] Func<string> dAYENTRYID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTimeEntry(WorkflowValue<string> dAYENTRYID)
        {
            WorkflowValue.Validate(dAYENTRYID, nameof(dAYENTRYID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/daily/delete/{0}", ExpressionConverter.ConvertWithUrlEncoding(dAYENTRYID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        [WorkflowExpressionFactory(nameof(__BuildAddUserToProject))]
        public IWorkflowAction AddUserToProject([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<int> bodyuseruserId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddUserToProject(WorkflowValue<string> projectId, WorkflowValue<int> bodyuseruserId = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(bodyuseruserId, nameof(bodyuseruserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/user_assignments", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var userObject = new JObject();
                var userObjectpropCount = 0;
                if (bodyuseruserId != null)
                {
                    userObject["id"] = ExpressionConverter.ConvertO(bodyuseruserId);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeEntry))]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> GetTimeEntry([WorkflowExpression] Func<string> dAYENTRYID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> __BuildGetTimeEntry(WorkflowValue<string> dAYENTRYID)
        {
            WorkflowValue.Validate(dAYENTRYID, nameof(dAYENTRYID), required: true);
            return new DeferredBodyAction<UpdateTimeEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/daily/show/{0}", ExpressionConverter.ConvertWithUrlEncoding(dAYENTRYID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UpdateTimeEntryResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildGetUser))]
        public IBodyWorkflowAction<GetUserByIDResponse> GetUser([WorkflowExpression] Func<string> uSERID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUserByIDResponse> __BuildGetUser(WorkflowValue<string> uSERID)
        {
            WorkflowValue.Validate(uSERID, nameof(uSERID), required: true);
            return new DeferredBodyAction<GetUserByIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/people/{0}", ExpressionConverter.ConvertWithUrlEncoding(uSERID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserByIDResponse>(callPayload);
            });
        }
    }

    public class HarvestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetUserByIDResponse[]> TrigNewUser(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/people";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetUserByIDResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListAllClientsResponseItem[]> TrigNewClient(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/clients";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListAllClientsResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListAllContactsResponseItem[]> TrigNewContact(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListAllContactsResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListProjectsResponseItem[]> TrigNewProject(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListProjectsResponseItem[]>(callPayload, triggerName, recurrence);
        }

        [WorkflowExpressionFactory(nameof(__BuildTrigNewTimeEntryToday))]
        public IBodyWorkflowTrigger<GetTimeEntriesForDayResponse> TrigNewTimeEntryToday([WorkflowExpression] Func<string> ofUser = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<GetTimeEntriesForDayResponse> __BuildTrigNewTimeEntryToday(WorkflowValue<string> ofUser = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(ofUser, nameof(ofUser), required: false);
            return new DeferredBodyTrigger<GetTimeEntriesForDayResponse>(() =>
            {
                var apiCallPath = "/trigger/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ofUser != null)
                    callPayload.Queries["of_user"] = ExpressionConverter.Convert(ofUser);
                return new ApiConnectionTrigger<GetTimeEntriesForDayResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTrigNewTimeEntry))]
        public IBodyWorkflowTrigger<GetTimeEntriesForDayResponse> TrigNewTimeEntry([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> ofUser = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<GetTimeEntriesForDayResponse> __BuildTrigNewTimeEntry(WorkflowValue<string> date, WorkflowValue<string> ofUser = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(date, nameof(date), required: true);
            WorkflowValue.Validate(ofUser, nameof(ofUser), required: false);
            return new DeferredBodyTrigger<GetTimeEntriesForDayResponse>(() =>
            {
                var apiCallPath = "/trigger/daily/day/year";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                if (ofUser != null)
                    callPayload.Queries["of_user"] = ExpressionConverter.Convert(ofUser);
                return new ApiConnectionTrigger<GetTimeEntriesForDayResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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
