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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListAllContactsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction AddNewContact([WorkflowExpression] Func<int> bodycontactclientId = null, [WorkflowExpression] Func<string> bodycontactfirstName = null, [WorkflowExpression] Func<string> bodycontactlastName = null, [WorkflowExpression] Func<string> bodycontactemail = null, [WorkflowExpression] Func<string> bodycontactofficePhone = null, [WorkflowExpression] Func<string> bodycontactmobilePhone = null, [WorkflowExpression] Func<string> bodycontactfax = null, [WorkflowExpression] Func<string> bodycontacttitle = null)
        {
            SourceExpression.Validate(bodycontactclientId, nameof(bodycontactclientId), required: false);
            SourceExpression.Validate(bodycontactfirstName, nameof(bodycontactfirstName), required: false);
            SourceExpression.Validate(bodycontactlastName, nameof(bodycontactlastName), required: false);
            SourceExpression.Validate(bodycontactemail, nameof(bodycontactemail), required: false);
            SourceExpression.Validate(bodycontactofficePhone, nameof(bodycontactofficePhone), required: false);
            SourceExpression.Validate(bodycontactmobilePhone, nameof(bodycontactmobilePhone), required: false);
            SourceExpression.Validate(bodycontactfax, nameof(bodycontactfax), required: false);
            SourceExpression.Validate(bodycontacttitle, nameof(bodycontacttitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    contactObject["client_id"] = SourceExpressionConverter.ConvertToken(bodycontactclientId);
                    contactObjectpropCount++;
                }

                if (bodycontactfirstName != null)
                {
                    contactObject["first_name"] = SourceExpressionConverter.ConvertToken(bodycontactfirstName);
                    contactObjectpropCount++;
                }

                if (bodycontactlastName != null)
                {
                    contactObject["last_name"] = SourceExpressionConverter.ConvertToken(bodycontactlastName);
                    contactObjectpropCount++;
                }

                if (bodycontactemail != null)
                {
                    contactObject["email"] = SourceExpressionConverter.ConvertToken(bodycontactemail);
                    contactObjectpropCount++;
                }

                if (bodycontactofficePhone != null)
                {
                    contactObject["phone_office"] = SourceExpressionConverter.ConvertToken(bodycontactofficePhone);
                    contactObjectpropCount++;
                }

                if (bodycontactmobilePhone != null)
                {
                    contactObject["phone_mobile"] = SourceExpressionConverter.ConvertToken(bodycontactmobilePhone);
                    contactObjectpropCount++;
                }

                if (bodycontactfax != null)
                {
                    contactObject["fax"] = SourceExpressionConverter.ConvertToken(bodycontactfax);
                    contactObjectpropCount++;
                }

                if (bodycontacttitle != null)
                {
                    contactObject["title"] = SourceExpressionConverter.ConvertToken(bodycontacttitle);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<ListAllClientsResponseItem[]> ListAllClients()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/clients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListAllClientsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction AddNewClient([WorkflowExpression] Func<string> bodyclientname = null, [WorkflowExpression] Func<string> bodyclientcurrency = null, [WorkflowExpression] Func<string> bodyclientcurrencySymbol = null, [WorkflowExpression] Func<string> bodyclientdetails = null)
        {
            SourceExpression.Validate(bodyclientname, nameof(bodyclientname), required: false);
            SourceExpression.Validate(bodyclientcurrency, nameof(bodyclientcurrency), required: false);
            SourceExpression.Validate(bodyclientcurrencySymbol, nameof(bodyclientcurrencySymbol), required: false);
            SourceExpression.Validate(bodyclientdetails, nameof(bodyclientdetails), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    clientObject["name"] = SourceExpressionConverter.ConvertToken(bodyclientname);
                    clientObjectpropCount++;
                }

                if (bodyclientcurrency != null)
                {
                    clientObject["currency"] = SourceExpressionConverter.ConvertToken(bodyclientcurrency);
                    clientObjectpropCount++;
                }

                if (bodyclientcurrencySymbol != null)
                {
                    clientObject["currency_symbol"] = SourceExpressionConverter.ConvertToken(bodyclientcurrencySymbol);
                    clientObjectpropCount++;
                }

                if (bodyclientdetails != null)
                {
                    clientObject["details"] = SourceExpressionConverter.ConvertToken(bodyclientdetails);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction CreateUser([WorkflowExpression] Func<string> bodyuseremail = null, [WorkflowExpression] Func<bool> bodyuserisAdmin = null, [WorkflowExpression] Func<string> bodyuserfirstName = null, [WorkflowExpression] Func<string> bodyuserlastName = null, [WorkflowExpression] Func<bool> bodyuserisContractor = null, [WorkflowExpression] Func<string> bodyuserphone = null, [WorkflowExpression] Func<double> bodyuserhourlyRate = null, [WorkflowExpression] Func<string> bodyuserdepartment = null, [WorkflowExpression] Func<double> bodyusercostRate = null)
        {
            SourceExpression.Validate(bodyuseremail, nameof(bodyuseremail), required: false);
            SourceExpression.Validate(bodyuserisAdmin, nameof(bodyuserisAdmin), required: false);
            SourceExpression.Validate(bodyuserfirstName, nameof(bodyuserfirstName), required: false);
            SourceExpression.Validate(bodyuserlastName, nameof(bodyuserlastName), required: false);
            SourceExpression.Validate(bodyuserisContractor, nameof(bodyuserisContractor), required: false);
            SourceExpression.Validate(bodyuserphone, nameof(bodyuserphone), required: false);
            SourceExpression.Validate(bodyuserhourlyRate, nameof(bodyuserhourlyRate), required: false);
            SourceExpression.Validate(bodyuserdepartment, nameof(bodyuserdepartment), required: false);
            SourceExpression.Validate(bodyusercostRate, nameof(bodyusercostRate), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    userObject["email"] = SourceExpressionConverter.ConvertToken(bodyuseremail);
                    userObjectpropCount++;
                }

                if (bodyuserisAdmin != null)
                {
                    userObject["is_admin"] = SourceExpressionConverter.ConvertToken(bodyuserisAdmin);
                    userObjectpropCount++;
                }

                if (bodyuserfirstName != null)
                {
                    userObject["first_name"] = SourceExpressionConverter.ConvertToken(bodyuserfirstName);
                    userObjectpropCount++;
                }

                if (bodyuserlastName != null)
                {
                    userObject["last_name"] = SourceExpressionConverter.ConvertToken(bodyuserlastName);
                    userObjectpropCount++;
                }

                if (bodyuserisContractor != null)
                {
                    userObject["is_contractor"] = SourceExpressionConverter.ConvertToken(bodyuserisContractor);
                    userObjectpropCount++;
                }

                if (bodyuserphone != null)
                {
                    userObject["telephone"] = SourceExpressionConverter.ConvertToken(bodyuserphone);
                    userObjectpropCount++;
                }

                userObject["has_access_to_all_future_projects"] = false;
                userObjectpropCount++;
                if (bodyuserhourlyRate != null)
                {
                    userObject["default_hourly_rate"] = SourceExpressionConverter.ConvertToken(bodyuserhourlyRate);
                    userObjectpropCount++;
                }

                if (bodyuserdepartment != null)
                {
                    userObject["department"] = SourceExpressionConverter.ConvertToken(bodyuserdepartment);
                    userObjectpropCount++;
                }

                if (bodyusercostRate != null)
                {
                    userObject["cost_rate"] = SourceExpressionConverter.ConvertToken(bodyusercostRate);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> UpdateTimeEntry([WorkflowExpression] Func<string> dAYENTRYId, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodystartedDateTime = null, [WorkflowExpression] Func<string> bodyendedDateTime = null, [WorkflowExpression] Func<string> bodydate = null)
        {
            SourceExpression.Validate(dAYENTRYId, nameof(dAYENTRYId), required: true);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            SourceExpression.Validate(bodytaskId, nameof(bodytaskId), required: true);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodystartedDateTime, nameof(bodystartedDateTime), required: false);
            SourceExpression.Validate(bodyendedDateTime, nameof(bodyendedDateTime), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/daily/update/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dAYENTRYId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                bodypropCount++;
                body["task_id"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodystartedDateTime != null)
                {
                    body["started_at"] = SourceExpressionConverter.ConvertToken(bodystartedDateTime);
                    bodypropCount++;
                }

                if (bodyendedDateTime != null)
                {
                    body["ended_at"] = SourceExpressionConverter.ConvertToken(bodyendedDateTime);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["spent_at"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateTimeEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> CreateTimeEntry([WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<int> bodyhours = null, [WorkflowExpression] Func<string> bodydate = null)
        {
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            SourceExpression.Validate(bodytaskId, nameof(bodytaskId), required: true);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyhours, nameof(bodyhours), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/daily/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyhours != null)
                {
                    body["hours"] = SourceExpressionConverter.ConvertToken(bodyhours);
                    bodypropCount++;
                }

                bodypropCount++;
                body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                bodypropCount++;
                body["task_id"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                if (bodydate != null)
                {
                    body["spent_at"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateTimeEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<ListProjectsResponseItem[]> ListProjects()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/projects/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListProjectsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction DeleteTimeEntry([WorkflowExpression] Func<string> dAYENTRYId)
        {
            SourceExpression.Validate(dAYENTRYId, nameof(dAYENTRYId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/daily/delete/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dAYENTRYId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IWorkflowAction AddUserToProject([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<int> bodyuseruserId = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(bodyuseruserId, nameof(bodyuseruserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/user_assignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var userObject = new JObject();
                var userObjectpropCount = 0;
                if (bodyuseruserId != null)
                {
                    userObject["id"] = SourceExpressionConverter.ConvertToken(bodyuseruserId);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<UpdateTimeEntryResponse> GetTimeEntry([WorkflowExpression] Func<string> dAYENTRYId)
        {
            SourceExpression.Validate(dAYENTRYId, nameof(dAYENTRYId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/daily/show/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dAYENTRYId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateTimeEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<ListTasksResponseItem[]> ListTasks()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTasksResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harvest")]
        public IBodyWorkflowAction<GetUserByIdResponse> GetUser([WorkflowExpression] Func<string> uSERId)
        {
            SourceExpression.Validate(uSERId, nameof(uSERId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/people/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uSERId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetUserByIdResponse>(BuildSourceInput);
        }
    }

    public class HarvestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetUserByIdResponse[]> TrigNewUser(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/people";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<GetUserByIdResponse[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListAllClientsResponseItem[]> TrigNewClient(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/clients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListAllClientsResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListAllContactsResponseItem[]> TrigNewContact(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListAllContactsResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListProjectsResponseItem[]> TrigNewProject(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListProjectsResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetTimeEntriesForDayResponse> TrigNewTimeEntryToday([WorkflowExpression] Func<string> ofUser = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(ofUser, nameof(ofUser), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ofUser != null)
                    callPayload.Queries["of_user"] = SourceExpressionConverter.ConvertO(ofUser);
                return callPayload;
            }

            return new ApiConnectionTrigger<GetTimeEntriesForDayResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetTimeEntriesForDayResponse> TrigNewTimeEntry([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> ofUser = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(date, nameof(date), required: true);
            SourceExpression.Validate(ofUser, nameof(ofUser), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/daily/day/year";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (ofUser != null)
                    callPayload.Queries["of_user"] = SourceExpressionConverter.ConvertO(ofUser);
                return callPayload;
            }

            return new ApiConnectionTrigger<GetTimeEntriesForDayResponse>(BuildSourceInput, triggerName, recurrence);
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