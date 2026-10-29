//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kc
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientResult, ApiConnectionActionConfiguration> GetClients(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> partnerId = null, Expression<Func<bool>> isDebitClient = null, Expression<Func<string>> modifiedSince = null, Expression<Func<string>> groupCode = null, Expression<Func<int>> clientId = null, Expression<Func<bool>> isCustomField = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_partnerId = WorkflowExpression.Compile(partnerId, nameof(partnerId), required: false);
            var __workflow_isDebitClient = WorkflowExpression.Compile(isDebitClient, nameof(isDebitClient), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_groupCode = WorkflowExpression.Compile(groupCode, nameof(groupCode), required: false);
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: false);
            var __workflow_isCustomField = WorkflowExpression.Compile(isCustomField, nameof(isCustomField), required: false);
            return new DeferredBodyAction<ClientResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_partnerId != null)
                    callPayload.Queries["partnerId"] = ExpressionConverter.Convert(__workflow_partnerId);
                if (__workflow_isDebitClient != null)
                    callPayload.Queries["isDebitClient"] = ExpressionConverter.Convert(__workflow_isDebitClient);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                if (__workflow_groupCode != null)
                    callPayload.Queries["groupCode"] = ExpressionConverter.Convert(__workflow_groupCode);
                if (__workflow_clientId != null)
                    callPayload.Queries["clientId"] = ExpressionConverter.Convert(__workflow_clientId);
                if (__workflow_isCustomField != null)
                    callPayload.Queries["isCustomField"] = ExpressionConverter.Convert(__workflow_isCustomField);
                return new ApiConnectionAction<ClientResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateClients(Expression<Func<CreateClientsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientDetailsResult, ApiConnectionActionConfiguration> GetAClient(Expression<Func<int>> clientId, Expression<Func<bool>> isCustomField = null)
        {
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            var __workflow_isCustomField = WorkflowExpression.Compile(isCustomField, nameof(isCustomField), required: false);
            return new DeferredBodyAction<ClientDetailsResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/{0}", __workflow_clientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_isCustomField != null)
                    callPayload.Queries["isCustomField"] = ExpressionConverter.Convert(__workflow_isCustomField);
                return new ApiConnectionAction<ClientDetailsResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAClient(Expression<Func<int>> clientId, Expression<Func<UpdateAClientInput>> body)
        {
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/{0}", __workflow_clientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetClientsTags()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateClientGroup(Expression<Func<CreateClientGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/clientgroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateClientGroup(Expression<Func<string>> groupCode, Expression<Func<UpdateClientGroupInput>> body)
        {
            var __workflow_groupCode = WorkflowExpression.Compile(groupCode, nameof(groupCode), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/clientgroup/{0}", __workflow_groupCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<RelationshipsResult, ApiConnectionActionConfiguration> GetClientRelationships(Expression<Func<int>> clientId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<RelationshipsResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/{0}/relationships", __workflow_clientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<RelationshipsResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientDebtor, ApiConnectionActionConfiguration> GetClientsDebtor(Expression<Func<int>> clientId)
        {
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            return new DeferredBodyAction<ClientDebtor, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/{0}/DebtorClients", __workflow_clientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ClientDebtor>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ContactResult, ApiConnectionActionConfiguration> GetContacts(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> modifiedSince = null, Expression<Func<int>> contactId = null, Expression<Func<bool>> isClientId = null, Expression<Func<bool>> isCustomField = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_isClientId = WorkflowExpression.Compile(isClientId, nameof(isClientId), required: false);
            var __workflow_isCustomField = WorkflowExpression.Compile(isCustomField, nameof(isCustomField), required: false);
            return new DeferredBodyAction<ContactResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                if (__workflow_contactId != null)
                    callPayload.Queries["contactId"] = ExpressionConverter.Convert(__workflow_contactId);
                if (__workflow_isClientId != null)
                    callPayload.Queries["isClientId"] = ExpressionConverter.Convert(__workflow_isClientId);
                if (__workflow_isCustomField != null)
                    callPayload.Queries["isCustomField"] = ExpressionConverter.Convert(__workflow_isCustomField);
                return new ApiConnectionAction<ContactResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAContact(Expression<Func<int>> contactId, Expression<Func<UpdateAContactInput>> body)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<DivisionsResult, ApiConnectionActionConfiguration> GetDivisions(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> modifiedSince = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            return new DeferredBodyAction<DivisionsResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/divisions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                return new ApiConnectionAction<DivisionsResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<InvoiceDetailResult, ApiConnectionActionConfiguration> GetInvoices(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> isDraftInvoice = null, Expression<Func<bool>> includeInvoiceDetails = null, Expression<Func<string>> status = null, Expression<Func<string>> modifiedSince = null, Expression<Func<bool>> isDebitClient = null, Expression<Func<string>> clientname = null, Expression<Func<string>> clientcode = null, Expression<Func<string>> jobname = null, Expression<Func<string>> jobcode = null, Expression<Func<string>> billingEntityId = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_isDraftInvoice = WorkflowExpression.Compile(isDraftInvoice, nameof(isDraftInvoice), required: false);
            var __workflow_includeInvoiceDetails = WorkflowExpression.Compile(includeInvoiceDetails, nameof(includeInvoiceDetails), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_isDebitClient = WorkflowExpression.Compile(isDebitClient, nameof(isDebitClient), required: false);
            var __workflow_clientname = WorkflowExpression.Compile(clientname, nameof(clientname), required: false);
            var __workflow_clientcode = WorkflowExpression.Compile(clientcode, nameof(clientcode), required: false);
            var __workflow_jobname = WorkflowExpression.Compile(jobname, nameof(jobname), required: false);
            var __workflow_jobcode = WorkflowExpression.Compile(jobcode, nameof(jobcode), required: false);
            var __workflow_billingEntityId = WorkflowExpression.Compile(billingEntityId, nameof(billingEntityId), required: false);
            return new DeferredBodyAction<InvoiceDetailResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_isDraftInvoice != null)
                    callPayload.Queries["isDraftInvoice"] = ExpressionConverter.Convert(__workflow_isDraftInvoice);
                if (__workflow_includeInvoiceDetails != null)
                    callPayload.Queries["includeInvoiceDetails"] = ExpressionConverter.Convert(__workflow_includeInvoiceDetails);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                if (__workflow_isDebitClient != null)
                    callPayload.Queries["isDebitClient"] = ExpressionConverter.Convert(__workflow_isDebitClient);
                if (__workflow_clientname != null)
                    callPayload.Queries["clientname"] = ExpressionConverter.Convert(__workflow_clientname);
                if (__workflow_clientcode != null)
                    callPayload.Queries["clientcode"] = ExpressionConverter.Convert(__workflow_clientcode);
                if (__workflow_jobname != null)
                    callPayload.Queries["jobname"] = ExpressionConverter.Convert(__workflow_jobname);
                if (__workflow_jobcode != null)
                    callPayload.Queries["jobcode"] = ExpressionConverter.Convert(__workflow_jobcode);
                if (__workflow_billingEntityId != null)
                    callPayload.Queries["billingEntityId"] = ExpressionConverter.Convert(__workflow_billingEntityId);
                return new ApiConnectionAction<InvoiceDetailResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFirmCustomfields(Expression<Func<string>> context)
        {
            var __workflow_context = WorkflowExpression.Compile(context, nameof(context), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/custom-fields/{0}", __workflow_context.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateTimesheet(Expression<Func<CreateTimesheetInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/timesheet/logtime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetNonBillableTimesheetTypes()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/timesheet/non-billabletypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<UsersResult, ApiConnectionActionConfiguration> GetUsers(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> modifiedSince = null, Expression<Func<string>> rolename = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_rolename = WorkflowExpression.Compile(rolename, nameof(rolename), required: false);
            return new DeferredBodyAction<UsersResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                if (__workflow_rolename != null)
                    callPayload.Queries["rolename"] = ExpressionConverter.Convert(__workflow_rolename);
                return new ApiConnectionAction<UsersResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<Teams, ApiConnectionActionConfiguration> GetTeams()
        {
            return new DeferredBodyAction<Teams, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/teams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Teams>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobsResult, ApiConnectionActionConfiguration> GetJobs(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> partnerId = null, Expression<Func<string>> clientName = null, Expression<Func<string>> clientcode = null, Expression<Func<string>> modifiedSince = null, Expression<Func<bool>> isDebitClient = null, Expression<Func<bool>> isCustomField = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_partnerId = WorkflowExpression.Compile(partnerId, nameof(partnerId), required: false);
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: false);
            var __workflow_clientcode = WorkflowExpression.Compile(clientcode, nameof(clientcode), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_isDebitClient = WorkflowExpression.Compile(isDebitClient, nameof(isDebitClient), required: false);
            var __workflow_isCustomField = WorkflowExpression.Compile(isCustomField, nameof(isCustomField), required: false);
            return new DeferredBodyAction<JobsResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_partnerId != null)
                    callPayload.Queries["partnerId"] = ExpressionConverter.Convert(__workflow_partnerId);
                if (__workflow_clientName != null)
                    callPayload.Queries["clientName"] = ExpressionConverter.Convert(__workflow_clientName);
                if (__workflow_clientcode != null)
                    callPayload.Queries["clientcode"] = ExpressionConverter.Convert(__workflow_clientcode);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                if (__workflow_isDebitClient != null)
                    callPayload.Queries["isDebitClient"] = ExpressionConverter.Convert(__workflow_isDebitClient);
                if (__workflow_isCustomField != null)
                    callPayload.Queries["isCustomField"] = ExpressionConverter.Convert(__workflow_isCustomField);
                return new ApiConnectionAction<JobsResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateJobs(Expression<Func<CreateJobsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateJobStatuses(Expression<Func<UpdateJobStatusesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/statuses";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAJob(Expression<Func<int>> jobId, Expression<Func<UpdateAJobInput>> body)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workflows/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobType, ApiConnectionActionConfiguration> GetJobTypes()
        {
            return new DeferredBodyAction<JobType, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobTemplate, ApiConnectionActionConfiguration> GetJobTemplates()
        {
            return new DeferredBodyAction<JobTemplate, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobTemplate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobPriorityValues, ApiConnectionActionConfiguration> GetJobPriorities()
        {
            return new DeferredBodyAction<JobPriorityValues, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/priorities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobPriorityValues>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobTypeStatus, ApiConnectionActionConfiguration> GetJobTypeStatus()
        {
            return new DeferredBodyAction<JobTypeStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/jobtypestatus";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobTypeStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<GetClientGroupsResponse, ApiConnectionActionConfiguration> GetClientGroups(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> groupCode = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_groupCode = WorkflowExpression.Compile(groupCode, nameof(groupCode), required: false);
            return new DeferredBodyAction<GetClientGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/clientgroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_groupCode != null)
                    callPayload.Queries["groupCode"] = ExpressionConverter.Convert(__workflow_groupCode);
                return new ApiConnectionAction<GetClientGroupsResponse>(callPayload);
            });
        }
    }

    public class KcTriggers([ConnectionName] string connectionId)
    {
    }

    public class ClientResult
    {
        [JsonProperty("clients")]
        public Client[] Clients { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Client
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("email")]
        public EmailInfo[] Email { get; set; }

        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }

        [JsonProperty("division")]
        public Division Division { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("partner")]
        public Staff Partner { get; set; }

        [JsonProperty("manager")]
        public Staff Manager { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("acn")]
        public string Acn { get; set; }

        [JsonProperty("abn")]
        public string Abn { get; set; }

        [JsonProperty("tfn")]
        public string Tfn { get; set; }

        [JsonProperty("gstRegistered")]
        public bool GstRegistered { get; set; }

        [JsonProperty("taxClient")]
        public bool TaxClient { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("wip")]
        public string Wip { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }

        [JsonProperty("debtorClient")]
        public string DebtorClient { get; set; }

        [JsonProperty("clientBrefcode")]
        public string ClientBrefcode { get; set; }

        [JsonProperty("billercode")]
        public string Billercode { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }
    }

    public class EmailInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("favourite")]
        public bool Favourite { get; set; }

        [JsonProperty("feeSynergy")]
        public bool FeeSynergy { get; set; }
    }

    public class Phone
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("favourite")]
        public bool Favourite { get; set; }

        [JsonProperty("feeSynergy")]
        public bool FeeSynergy { get; set; }
    }

    public class Division
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Staff
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Contact
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("contactType")]
        public string ContactType { get; set; }

        [JsonProperty("email")]
        public EmailInfo[] Email { get; set; }

        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }
    }

    public class Address
    {
        [JsonProperty("addressType")]
        public string AddressType { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("careOf")]
        public string CareOf { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postCode")]
        public string PostCode { get; set; }
    }

    public class Group
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CustomField
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("total_records")]
        public int TotalRecords { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("page_Size")]
        public int PageSize { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("next_pageurl")]
        public string NextPageurl { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("prev_pageurl")]
        public string PrevPageurl { get; set; }
    }

    public class CreateClientsInput
    {
        [JsonProperty("entityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntityType { get; set; }

        [JsonProperty("clientCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ClientCode { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("trustName")]
        public string TrustName { get; set; }

        [JsonProperty("trustType")]
        public string TrustType { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("tradingName")]
        public string TradingName { get; set; }

        [JsonProperty("partnershipName")]
        public string PartnershipName { get; set; }

        [JsonProperty("smsfName")]
        public string SmsfName { get; set; }

        [JsonProperty("softwareType")]
        public string SoftwareType { get; set; }

        [JsonProperty("softwareName")]
        public string SoftwareName { get; set; }

        [JsonProperty("partnerId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PartnerId { get; set; }

        [JsonProperty("managerId")]
        public string ManagerId { get; set; }

        [JsonProperty("divisionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DivisionId { get; set; }

        [JsonProperty("prospect")]
        public bool? Prospect { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("dateofbirth")]
        public string Dateofbirth { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("email")]
        public EmailInfo[] Email { get; set; }

        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }

        [JsonProperty("linkedInProfileId")]
        public string LinkedInProfileId { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("annualReviewDate")]
        public string AnnualReviewDate { get; set; }

        [JsonProperty("formationDate")]
        public string FormationDate { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("salary")]
        public string Salary { get; set; }

        [JsonProperty("annualIncome")]
        public string AnnualIncome { get; set; }

        [JsonProperty("isTaxClient")]
        public bool? IsTaxClient { get; set; }

        [JsonProperty("isLodgeActivity")]
        public bool? IsLodgeActivity { get; set; }

        [JsonProperty("tfn")]
        public int? Tfn { get; set; }

        [JsonProperty("abn")]
        public int? Abn { get; set; }

        [JsonProperty("acn")]
        public int? Acn { get; set; }

        [JsonProperty("din")]
        public int? Din { get; set; }

        [JsonProperty("taxAgent")]
        public string TaxAgent { get; set; }

        [JsonProperty("gst")]
        public bool? Gst { get; set; }

        [JsonProperty("resident")]
        public bool? Resident { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankAccountName")]
        public string BankAccountName { get; set; }

        [JsonProperty("bankBSB")]
        public int? BankBSB { get; set; }

        [JsonProperty("bankAccountNumber")]
        public int? BankAccountNumber { get; set; }

        [JsonProperty("contactIds")]
        public ContactModel[] ContactIds { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }

        [JsonProperty("enumEntityTypes")]
        public EntityTypeNames? EnumEntityTypes { get; set; }

        [JsonProperty("enumTrustTypes")]
        public TrustTypes? EnumTrustTypes { get; set; }

        [JsonProperty("enumGender")]
        public GenderNames? EnumGender { get; set; }

        [JsonProperty("enumEmailTypes")]
        public EmailType? EnumEmailTypes { get; set; }

        [JsonProperty("enumPhoneTypes")]
        public PhoneType? EnumPhoneTypes { get; set; }

        [JsonProperty("enumContactTypes")]
        public ContactTypes? EnumContactTypes { get; set; }

        [JsonProperty("enumAddressTypes")]
        public AddressType? EnumAddressTypes { get; set; }
    }

    public class ContactModel
    {
        [JsonProperty("contactId")]
        public int ContactId { get; set; }

        [JsonProperty("contactType")]
        public string ContactType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntityTypeNames
    {
        [EnumMember(Value = "individual")]
        Individual,
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "trust")]
        Trust,
        [EnumMember(Value = "partnership")]
        Partnership,
        [EnumMember(Value = "smsf")]
        Smsf
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TrustTypes
    {
        [EnumMember(Value = "discretionary")]
        Discretionary,
        [EnumMember(Value = "hybrid")]
        Hybrid,
        [EnumMember(Value = "unit")]
        Unit
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenderNames
    {
        [EnumMember(Value = "male")]
        Male,
        [EnumMember(Value = "female")]
        Female
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EmailType
    {
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "work")]
        Work
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneType
    {
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "mobile")]
        Mobile
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContactTypes
    {
        [EnumMember(Value = "adviser")]
        Adviser,
        [EnumMember(Value = "accountant")]
        Accountant,
        [EnumMember(Value = "auditor")]
        Auditor,
        [EnumMember(Value = "bookkeeper")]
        Bookkeeper,
        [EnumMember(Value = "lawyer")]
        Lawyer,
        [EnumMember(Value = "real_estate_agent")]
        RealEstateAgent,
        [EnumMember(Value = "stockbroker")]
        Stockbroker,
        [EnumMember(Value = "tax_agent")]
        TaxAgent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressType
    {
        [EnumMember(Value = "physical")]
        Physical,
        [EnumMember(Value = "postal")]
        Postal
    }

    public class ClientDetailsResult
    {
        [JsonProperty("client")]
        public ClientDetails[] Client { get; set; }
    }

    public class ClientDetails
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("email")]
        public EmailInfo[] Email { get; set; }

        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }

        [JsonProperty("division")]
        public Division Division { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("partner")]
        public Staff Partner { get; set; }

        [JsonProperty("manager")]
        public Staff Manager { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("acn")]
        public string Acn { get; set; }

        [JsonProperty("abn")]
        public string Abn { get; set; }

        [JsonProperty("gstRegistered")]
        public bool GstRegistered { get; set; }

        [JsonProperty("taxClient")]
        public bool TaxClient { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("wip")]
        public string Wip { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }

        [JsonProperty("debtorClient")]
        public string DebtorClient { get; set; }

        [JsonProperty("clientBrefcode")]
        public string ClientBrefcode { get; set; }

        [JsonProperty("billercode")]
        public string Billercode { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }

        [JsonProperty("din")]
        public string Din { get; set; }

        [JsonProperty("tfn")]
        public string Tfn { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankAccountName")]
        public string BankAccountName { get; set; }

        [JsonProperty("bankBSB")]
        public string BankBSB { get; set; }

        [JsonProperty("bankAccountNumber")]
        public string BankAccountNumber { get; set; }
    }

    public class UpdateAClientInput
    {
        [JsonProperty("entityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntityType { get; set; }

        [JsonProperty("clientCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ClientCode { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("trustName")]
        public string TrustName { get; set; }

        [JsonProperty("trustType")]
        public string TrustType { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("tradingName")]
        public string TradingName { get; set; }

        [JsonProperty("partnershipName")]
        public string PartnershipName { get; set; }

        [JsonProperty("smsfName")]
        public string SmsfName { get; set; }

        [JsonProperty("softwareType")]
        public string SoftwareType { get; set; }

        [JsonProperty("softwareName")]
        public string SoftwareName { get; set; }

        [JsonProperty("partnerId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PartnerId { get; set; }

        [JsonProperty("managerId")]
        public string ManagerId { get; set; }

        [JsonProperty("divisionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DivisionId { get; set; }

        [JsonProperty("prospect")]
        public bool? Prospect { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("dateofbirth")]
        public string Dateofbirth { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("email")]
        public EmailInfo[] Email { get; set; }

        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }

        [JsonProperty("linkedInProfileId")]
        public string LinkedInProfileId { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("annualReviewDate")]
        public string AnnualReviewDate { get; set; }

        [JsonProperty("formationDate")]
        public string FormationDate { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("salary")]
        public string Salary { get; set; }

        [JsonProperty("annualIncome")]
        public string AnnualIncome { get; set; }

        [JsonProperty("isTaxClient")]
        public bool? IsTaxClient { get; set; }

        [JsonProperty("isLodgeActivity")]
        public bool? IsLodgeActivity { get; set; }

        [JsonProperty("tfn")]
        public int? Tfn { get; set; }

        [JsonProperty("abn")]
        public int? Abn { get; set; }

        [JsonProperty("acn")]
        public int? Acn { get; set; }

        [JsonProperty("din")]
        public int? Din { get; set; }

        [JsonProperty("taxAgent")]
        public string TaxAgent { get; set; }

        [JsonProperty("gst")]
        public bool? Gst { get; set; }

        [JsonProperty("resident")]
        public bool? Resident { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankAccountName")]
        public string BankAccountName { get; set; }

        [JsonProperty("bankBSB")]
        public int? BankBSB { get; set; }

        [JsonProperty("bankAccountNumber")]
        public int? BankAccountNumber { get; set; }

        [JsonProperty("contactIds")]
        public ContactModel[] ContactIds { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }

        [JsonProperty("enumEntityTypes")]
        public EntityTypeNames? EnumEntityTypes { get; set; }

        [JsonProperty("enumTrustTypes")]
        public TrustTypes? EnumTrustTypes { get; set; }

        [JsonProperty("enumGender")]
        public GenderNames? EnumGender { get; set; }

        [JsonProperty("enumEmailTypes")]
        public EmailType? EnumEmailTypes { get; set; }

        [JsonProperty("enumPhoneTypes")]
        public PhoneType? EnumPhoneTypes { get; set; }

        [JsonProperty("enumContactTypes")]
        public ContactTypes? EnumContactTypes { get; set; }

        [JsonProperty("enumAddressTypes")]
        public AddressType? EnumAddressTypes { get; set; }
    }

    public class CreateClientGroupInput
    {
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("partnerId")]
        public string PartnerId { get; set; }

        [JsonProperty("tags")]
        public int[] Tags { get; set; }

        [JsonProperty("groupClients")]
        public GroupClient[] GroupClients { get; set; }

        [JsonProperty("contactId")]
        public int? ContactId { get; set; }
    }

    public class GroupClient
    {
        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("isDebitorClient")]
        public bool IsDebitorClient { get; set; }

        [JsonProperty("relationIds")]
        public int[] RelationIds { get; set; }
    }

    public class UpdateClientGroupInput
    {
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("partnerId")]
        public string PartnerId { get; set; }

        [JsonProperty("tags")]
        public int[] Tags { get; set; }

        [JsonProperty("groupClients")]
        public GroupClient[] GroupClients { get; set; }

        [JsonProperty("contactId")]
        public int? ContactId { get; set; }
    }

    public class RelationshipsResult
    {
        [JsonProperty("relationships")]
        public Relationship[] Relationships { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Relationship
    {
        [JsonProperty("relationshipId")]
        public string RelationshipId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("units")]
        public int Units { get; set; }
    }

    public class ClientDebtor
    {
        [JsonProperty("debtorid")]
        public int Debtorid { get; set; }

        [JsonProperty("debtorname")]
        public string Debtorname { get; set; }

        [JsonProperty("groupCode")]
        public string GroupCode { get; set; }

        [JsonProperty("clientid")]
        public int Clientid { get; set; }

        [JsonProperty("clientType")]
        public string ClientType { get; set; }

        [JsonProperty("isSeflDebtor")]
        public bool IsSeflDebtor { get; set; }
    }

    public class ContactResult
    {
        [JsonProperty("contacts")]
        public ContactEntity[] Contacts { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class ContactEntity
    {
        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }

        [JsonProperty("email")]
        public EmailInfo[] Email { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("linkedInProfileID")]
        public string LinkedInProfileId { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("din")]
        public string Din { get; set; }

        [JsonProperty("contactId")]
        public int ContactId { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }
    }

    public class UpdateAContactInput
    {
        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }

        [JsonProperty("email")]
        public EmailInfo[] Email { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("linkedInProfileID")]
        public string LinkedInProfileId { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("din")]
        public string Din { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("isImportent")]
        public bool? IsImportent { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }

        [JsonProperty("enumAddressTypes")]
        public AddressType? EnumAddressTypes { get; set; }
    }

    public class DivisionsResult
    {
        [JsonProperty("divisions")]
        public Divisionext[] Divisions { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Divisionext
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("billingEntityName")]
        public string BillingEntityName { get; set; }

        [JsonProperty("billingEntityId")]
        public string BillingEntityId { get; set; }

        [JsonProperty("lastModifiedAt")]
        public string LastModifiedAt { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class InvoiceDetailResult
    {
        [JsonProperty("invoices")]
        public InvoiceDetails[] Invoices { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class InvoiceDetails
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("refNo")]
        public string RefNo { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due")]
        public string Due { get; set; }

        [JsonProperty("totalPayable")]
        public double TotalPayable { get; set; }

        [JsonProperty("gst")]
        public double Gst { get; set; }

        [JsonProperty("payment")]
        public double Payment { get; set; }

        [JsonProperty("creditNote")]
        public double CreditNote { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("debtorClientId")]
        public int DebtorClientId { get; set; }

        [JsonProperty("debtorClientCode")]
        public string DebtorClientCode { get; set; }

        [JsonProperty("debtorClientName")]
        public string DebtorClientName { get; set; }

        [JsonProperty("debtorBrefcode")]
        public string DebtorBrefcode { get; set; }

        [JsonProperty("billercode")]
        public string Billercode { get; set; }

        [JsonProperty("invoiceLines")]
        public InvoiceLines[] InvoiceLines { get; set; }

        [JsonProperty("invoiceJobs")]
        public JobInvoice[] InvoiceJobs { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class InvoiceLines
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("lineNumber")]
        public int LineNumber { get; set; }

        [JsonProperty("lineDescription")]
        public string LineDescription { get; set; }

        [JsonProperty("lineTotal")]
        public double LineTotal { get; set; }
    }

    public class JobInvoice
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("jobcode")]
        public string Jobcode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("wip")]
        public double Wip { get; set; }

        [JsonProperty("client")]
        public ClientSummary Client { get; set; }

        [JsonProperty("financialYear")]
        public string FinancialYear { get; set; }

        [JsonProperty("partner")]
        public Staff Partner { get; set; }

        [JsonProperty("manager")]
        public Staff Manager { get; set; }

        [JsonProperty("division")]
        public DivisionWithDetails Division { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("debtorClient")]
        public string DebtorClient { get; set; }

        [JsonProperty("invoiceid")]
        public int Invoiceid { get; set; }
    }

    public class ClientSummary
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DivisionWithDetails
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("billingEntityName")]
        public string BillingEntityName { get; set; }

        [JsonProperty("billingEntityId")]
        public string BillingEntityId { get; set; }

        [JsonProperty("lastModifiedAt")]
        public string LastModifiedAt { get; set; }
    }

    public class CreateTimesheetInput
    {
        [JsonProperty("isbillable")]
        public bool? Isbillable { get; set; }

        [JsonProperty("jobId")]
        public int? JobId { get; set; }

        [JsonProperty("taskId")]
        public int? TaskId { get; set; }

        [JsonProperty("nonbillableId")]
        public int? NonbillableId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("units")]
        public double? Units { get; set; }

        [JsonProperty("starttime")]
        public string Starttime { get; set; }

        [JsonProperty("rate")]
        public double? Rate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class UsersResult
    {
        [JsonProperty("users")]
        public UsersWithDetails[] Users { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class UsersWithDetails
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("email")]
        public EmailInfo Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phone")]
        public Phone Phone { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class Teams
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("groupMembers")]
        public GroupMember[] GroupMembers { get; set; }
    }

    public class GroupMember
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("memberId")]
        public string MemberId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }
    }

    public class JobsResult
    {
        [JsonProperty("jobs")]
        public Jobdetail[] Jobs { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Jobdetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("jobCode")]
        public string JobCode { get; set; }

        [JsonProperty("jobType")]
        public string JobType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("estimatedTime")]
        public double EstimatedTime { get; set; }

        [JsonProperty("wip")]
        public double Wip { get; set; }

        [JsonProperty("client")]
        public ClientSummary Client { get; set; }

        [JsonProperty("financialYear")]
        public string FinancialYear { get; set; }

        [JsonProperty("partner")]
        public Staff Partner { get; set; }

        [JsonProperty("manager")]
        public Staff Manager { get; set; }

        [JsonProperty("division")]
        public DivisionWithDetails Division { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("debtorClient")]
        public DebtorClient DebtorClient { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCategory")]
        public string StatusCategory { get; set; }

        [JsonProperty("statusOwner")]
        public UserDetail StatusOwner { get; set; }

        [JsonProperty("completedTask")]
        public int CompletedTask { get; set; }

        [JsonProperty("totalTask")]
        public int TotalTask { get; set; }

        [JsonProperty("tasks")]
        public TaskDetail[] Tasks { get; set; }

        [JsonProperty("assignees")]
        public UserDetail[] Assignees { get; set; }

        [JsonProperty("team")]
        public TaskDetail Team { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }
    }

    public class DebtorClient
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UserDetail
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TaskDetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateJobsInput
    {
        [JsonProperty("clientId")]
        public int? ClientId { get; set; }

        [JsonProperty("divisionId")]
        public int? DivisionId { get; set; }

        [JsonProperty("debtorclientId")]
        public int? DebtorclientId { get; set; }

        [JsonProperty("jobTypeId")]
        public int? JobTypeId { get; set; }

        [JsonProperty("jobCategory")]
        public string JobCategory { get; set; }

        [JsonProperty("jobName")]
        public string JobName { get; set; }

        [JsonProperty("financialYear")]
        public int? FinancialYear { get; set; }

        [JsonProperty("templateId")]
        public int? TemplateId { get; set; }

        [JsonProperty("managerId")]
        public string ManagerId { get; set; }

        [JsonProperty("partnerId")]
        public string PartnerId { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("estimateType")]
        public string EstimateType { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("billingMethod")]
        public string BillingMethod { get; set; }

        [JsonProperty("teamId")]
        public int? TeamId { get; set; }

        [JsonProperty("quoteAmount")]
        public double? QuoteAmount { get; set; }

        [JsonProperty("statusId")]
        public int? StatusId { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }

        [JsonProperty("enumJobCategoryTypes")]
        public JobCategory? EnumJobCategoryTypes { get; set; }

        [JsonProperty("enumEstimateTypes")]
        public EstimateType? EnumEstimateTypes { get; set; }

        [JsonProperty("enumBillingMethods")]
        public BillingMethod? EnumBillingMethods { get; set; }

        [JsonProperty("enumPriorityTypes")]
        public Priority? EnumPriorityTypes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobCategory
    {
        Workflow,
        Timesheet,
        WorkflowTimesheet,
        Disbursement,
        WorkflowDisbursement,
        TimesheetDisbursement,
        All
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EstimateType
    {
        Job,
        [EnumMember(Value = "Task")]
        TaskObject
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BillingMethod
    {
        TimeCost,
        Fixed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Priority
    {
        Critical,
        High,
        Medium,
        Low
    }

    public class UpdateJobStatusesInput
    {
        [JsonProperty("jobId")]
        public int? JobId { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusOwner")]
        public string StatusOwner { get; set; }
    }

    public class UpdateAJobInput
    {
        [JsonProperty("clientId")]
        public int? ClientId { get; set; }

        [JsonProperty("divisionId")]
        public int? DivisionId { get; set; }

        [JsonProperty("debtorclientId")]
        public int? DebtorclientId { get; set; }

        [JsonProperty("jobTypeId")]
        public int? JobTypeId { get; set; }

        [JsonProperty("jobCategory")]
        public string JobCategory { get; set; }

        [JsonProperty("jobName")]
        public string JobName { get; set; }

        [JsonProperty("financialYear")]
        public int? FinancialYear { get; set; }

        [JsonProperty("templateId")]
        public int? TemplateId { get; set; }

        [JsonProperty("managerId")]
        public string ManagerId { get; set; }

        [JsonProperty("partnerId")]
        public string PartnerId { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("estimateType")]
        public string EstimateType { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("billingMethod")]
        public string BillingMethod { get; set; }

        [JsonProperty("teamId")]
        public int? TeamId { get; set; }

        [JsonProperty("quoteAmount")]
        public double? QuoteAmount { get; set; }

        [JsonProperty("statusId")]
        public int? StatusId { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }

        [JsonProperty("enumJobCategoryTypes")]
        public JobCategory? EnumJobCategoryTypes { get; set; }

        [JsonProperty("enumEstimateTypes")]
        public EstimateType? EnumEstimateTypes { get; set; }

        [JsonProperty("enumBillingMethods")]
        public BillingMethod? EnumBillingMethods { get; set; }

        [JsonProperty("enumPriorityTypes")]
        public Priority? EnumPriorityTypes { get; set; }
    }

    public class JobType
    {
        [JsonProperty("jobTypeId")]
        public int JobTypeId { get; set; }

        [JsonProperty("jobTypeName")]
        public string JobTypeName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("divisionId")]
        public int DivisionId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class JobTemplate
    {
        [JsonProperty("templateId")]
        public int TemplateId { get; set; }

        [JsonProperty("templateName")]
        public string TemplateName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("estimateType")]
        public string EstimateType { get; set; }

        [JsonProperty("turnaround")]
        public int Turnaround { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class JobPriorityValues
    {
        [JsonProperty("jobPriorityId")]
        public int JobPriorityId { get; set; }

        [JsonProperty("jobPriorityName")]
        public string JobPriorityName { get; set; }
    }

    public class JobTypeStatus
    {
        [JsonProperty("jobTypeId")]
        public int JobTypeId { get; set; }

        [JsonProperty("statusId")]
        public int StatusId { get; set; }

        [JsonProperty("statusName")]
        public string StatusName { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
    }

    public class GetClientGroupsResponse
    {
        [JsonProperty("clientGroups")]
        public GetClientGroupsResponseClientGroupsTypeItem[] ClientGroups { get; set; }

        [JsonProperty("pagination")]
        public GetClientGroupsResponsePaginationType Pagination { get; set; }
    }

    public class GetClientGroupsResponseClientGroupsTypeItem
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("groupCode")]
        public string GroupCode { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("clients")]
        public GetClientGroupsResponseClientGroupsTypeItemClientsTypeItem[] Clients { get; set; }

        [JsonProperty("createdBY")]
        public string CreatedBY { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }
    }

    public class GetClientGroupsResponseClientGroupsTypeItemClientsTypeItem
    {
        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("clientname")]
        public string Clientname { get; set; }

        [JsonProperty("isDebtorClient")]
        public bool IsDebtorClient { get; set; }

        [JsonProperty("debtorClientId")]
        public int DebtorClientId { get; set; }
    }

    public class GetClientGroupsResponsePaginationType
    {
        [JsonProperty("total_records")]
        public int TotalRecords { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("page_Size")]
        public int PageSize { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("next_pageurl")]
        public string NextPageurl { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("prev_pageurl")]
        public string PrevPageurl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Kc;

    public partial class WorkflowManagedActions
    {
        public KcActions Kc(string connectionId) => new KcActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KcTriggers Kc(string connectionId) => new KcTriggers(connectionId);
    }
}