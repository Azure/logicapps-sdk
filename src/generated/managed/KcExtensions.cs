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
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateClients(Expression<Func<CreateClientsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
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
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateAClient(Expression<Func<int>> clientId, Expression<Func<CreateClientsBodyInput>> body)
        {
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/{0}", __workflow_clientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<TagModel[], ApiConnectionActionConfiguration> GetClientsTags()
        {
            return new DeferredBodyAction<TagModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateClientGroup(Expression<Func<CreateClientGroupBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/clientgroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateClientGroup(Expression<Func<string>> groupCode, Expression<Func<CreateClientGroupBodyInput>> body)
        {
            var __workflow_groupCode = WorkflowExpression.Compile(groupCode, nameof(groupCode), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/clientgroup/{0}", __workflow_groupCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
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
        public IBodyWorkflowAction<ClientDebtor[], ApiConnectionActionConfiguration> GetClientsDebtor(Expression<Func<int>> clientId)
        {
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            return new DeferredBodyAction<ClientDebtor[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/{0}/debtorclients", __workflow_clientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ClientDebtor[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<SalutationInfo[], ApiConnectionActionConfiguration> GetClientSalutations()
        {
            return new DeferredBodyAction<SalutationInfo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/salutations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SalutationInfo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<TitleInfo[], ApiConnectionActionConfiguration> GetClientTitles()
        {
            return new DeferredBodyAction<TitleInfo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/titles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TitleInfo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientGroupResult, ApiConnectionActionConfiguration> GetClientGroups(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> groupCode = null, Expression<Func<string>> clientCode = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_groupCode = WorkflowExpression.Compile(groupCode, nameof(groupCode), required: false);
            var __workflow_clientCode = WorkflowExpression.Compile(clientCode, nameof(clientCode), required: false);
            return new DeferredBodyAction<ClientGroupResult, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_clientCode != null)
                    callPayload.Queries["clientCode"] = ExpressionConverter.Convert(__workflow_clientCode);
                return new ApiConnectionAction<ClientGroupResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientSummary[], ApiConnectionActionConfiguration> GetValidClientsForGrouping()
        {
            return new DeferredBodyAction<ClientSummary[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/GetValidClientsForGrouping";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ClientSummary[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientContacts[], ApiConnectionActionConfiguration> GetValidContactsForClients()
        {
            return new DeferredBodyAction<ClientContacts[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/GetValidContactsforClients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ClientContacts[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> GetClientIndustries()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/industries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ContactsInfoResult, ApiConnectionActionConfiguration> GetClientCommunicationContacts(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> modifiedSince = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            return new DeferredBodyAction<ContactsInfoResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/communicationcontacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                return new ApiConnectionAction<ContactsInfoResult>(callPayload);
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
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateContacts(Expression<Func<CreateContactsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateAContact(Expression<Func<int>> contactId, Expression<Func<CreateContactsBodyInput>> body)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
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
        public IBodyWorkflowAction<TaxTypes[], ApiConnectionActionConfiguration> GetInvoiceTaxTypes()
        {
            return new DeferredBodyAction<TaxTypes[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/invoices/taxtypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaxTypes[]>(callPayload);
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
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateNonBillableTimesheetType(Expression<Func<CreateNonBillableTimesheetTypeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/timesheet/nonbillable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateNonBillableTimesheetType(Expression<Func<int>> id, Expression<Func<UpdateNonBillableTimesheetTypeBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/timesheet/nonbillable/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateJobType(Expression<Func<CreateJobTypeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/workflows/jobtype";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateJobType(Expression<Func<int>> id, Expression<Func<CreateJobTypeBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/workflows/jobtype/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateJobTypeStatuses(Expression<Func<int>> jobtypeId, Expression<Func<JobStatusModel[]>> body)
        {
            var __workflow_jobtypeId = WorkflowExpression.Compile(jobtypeId, nameof(jobtypeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/workflows/jobtypestatus/{0}", __workflow_jobtypeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<StatusCatagory[], ApiConnectionActionConfiguration> GetJobStatusCategories()
        {
            return new DeferredBodyAction<StatusCatagory[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/workflows/jobStatusCategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusCatagory[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobType[], ApiConnectionActionConfiguration> GetJobTypes()
        {
            return new DeferredBodyAction<JobType[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/workflows/jobtypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobType[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobTemplate[], ApiConnectionActionConfiguration> GetJobTemplates()
        {
            return new DeferredBodyAction<JobTemplate[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/workflows/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobTemplate[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateJobTemplate(Expression<Func<CreateJobTemplateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/workflows/templates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobPriority[], ApiConnectionActionConfiguration> GetJobPriorities()
        {
            return new DeferredBodyAction<JobPriority[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/workflows/priorities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobPriority[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobTypeStatus[], ApiConnectionActionConfiguration> GetJobTypeStatus()
        {
            return new DeferredBodyAction<JobTypeStatus[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/workflows/jobtypestatus";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobTypeStatus[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<CompositeTemplateTaskGroupViewModel[], ApiConnectionActionConfiguration> GetTemplateTaskGroups(Expression<Func<int>> templateId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<CompositeTemplateTaskGroupViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/workflows/template/{0}/taskgroups", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompositeTemplateTaskGroupViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<CompositeTemplateTaskGroupViewModel[], ApiConnectionActionConfiguration> GetTemplateTaskGroupTasks(Expression<Func<int>> templateId, Expression<Func<int>> taskgroupId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_taskgroupId = WorkflowExpression.Compile(taskgroupId, nameof(taskgroupId), required: true);
            return new DeferredBodyAction<CompositeTemplateTaskGroupViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/workflows/template/{0}/taskgroups/{1}/tasks", __workflow_templateId.WithUrlEncoding(1), __workflow_taskgroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompositeTemplateTaskGroupViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateJobPriority(Expression<Func<string>> priorityName)
        {
            var __workflow_priorityName = WorkflowExpression.Compile(priorityName, nameof(priorityName), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/workflows/priority/{0}", __workflow_priorityName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateJobPriority(Expression<Func<int>> priorityId, Expression<Func<string>> priorityName)
        {
            var __workflow_priorityId = WorkflowExpression.Compile(priorityId, nameof(priorityId), required: true);
            var __workflow_priorityName = WorkflowExpression.Compile(priorityName, nameof(priorityName), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/workflows/priority/{0}/{1}", __workflow_priorityId.WithUrlEncoding(1), __workflow_priorityName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateTemplateTask(Expression<Func<CreateTemplateTaskBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/workflows/template/taskgroups/Tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateTemplateTask(Expression<Func<int>> taskId, Expression<Func<CreateTemplateTaskBodyInput>> body)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/workflows/template/taskgroups/tasks/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<EmailType[], ApiConnectionActionConfiguration> GetEmailTypes()
        {
            return new DeferredBodyAction<EmailType[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/clients/emailTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EmailType[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<PhoneType[], ApiConnectionActionConfiguration> GetPhoneTypes()
        {
            return new DeferredBodyAction<PhoneType[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/clients/phoneTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PhoneType[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<Country[], ApiConnectionActionConfiguration> GetCountries()
        {
            return new DeferredBodyAction<Country[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/clients/Countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Country[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateTaskType(Expression<Func<CreateTaskTypeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/workflows/tasktypes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateTaskType(Expression<Func<int>> tasktypeId, Expression<Func<CreateTaskTypeBodyInput>> body)
        {
            var __workflow_tasktypeId = WorkflowExpression.Compile(tasktypeId, nameof(tasktypeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/workflows/tasktypes/{0}", __workflow_tasktypeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateJobTemplate(Expression<Func<int>> templateId, Expression<Func<UpdateJobTemplateBodyInput>> body)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/workflows/templates/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateTemplateTaskGroup(Expression<Func<int>> templateId, Expression<Func<string>> taskgroupname)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_taskgroupname = WorkflowExpression.Compile(taskgroupname, nameof(taskgroupname), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/workflows/templates/{0}/taskgroups/{1}", __workflow_templateId.WithUrlEncoding(1), __workflow_taskgroupname.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateTemplateTaskGroup(Expression<Func<int>> templateId, Expression<Func<int>> taskgroupId, Expression<Func<string>> taskgroupname)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_taskgroupId = WorkflowExpression.Compile(taskgroupId, nameof(taskgroupId), required: true);
            var __workflow_taskgroupname = WorkflowExpression.Compile(taskgroupname, nameof(taskgroupname), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/workflows/templates/{0}/taskgroups/{1}/{2}", __workflow_templateId.WithUrlEncoding(1), __workflow_taskgroupId.WithUrlEncoding(1), __workflow_taskgroupname.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<Leave[], ApiConnectionActionConfiguration> GetNonBillableTimesheetTypes()
        {
            return new DeferredBodyAction<Leave[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/timesheet/non-billabletypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Leave[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<PostJobLogTimeResponse[], ApiConnectionActionConfiguration> CreateTimesheet(Expression<Func<JobLogTime[]>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostJobLogTimeResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/timesheet/logtime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostJobLogTimeResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<TimeSheetResult, ApiConnectionActionConfiguration> GetTimesheets(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> status = null, Expression<Func<int>> jobId = null, Expression<Func<int>> taskId = null, Expression<Func<int>> clientId = null, Expression<Func<string>> fromDate = null, Expression<Func<string>> toDate = null, Expression<Func<bool>> isbillable = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: false);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: false);
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: false);
            var __workflow_fromDate = WorkflowExpression.Compile(fromDate, nameof(fromDate), required: false);
            var __workflow_toDate = WorkflowExpression.Compile(toDate, nameof(toDate), required: false);
            var __workflow_isbillable = WorkflowExpression.Compile(isbillable, nameof(isbillable), required: false);
            return new DeferredBodyAction<TimeSheetResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/timesheet/logtimes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_jobId != null)
                    callPayload.Queries["jobId"] = ExpressionConverter.Convert(__workflow_jobId);
                if (__workflow_taskId != null)
                    callPayload.Queries["taskId"] = ExpressionConverter.Convert(__workflow_taskId);
                if (__workflow_clientId != null)
                    callPayload.Queries["clientId"] = ExpressionConverter.Convert(__workflow_clientId);
                if (__workflow_fromDate != null)
                    callPayload.Queries["fromDate"] = ExpressionConverter.Convert(__workflow_fromDate);
                if (__workflow_toDate != null)
                    callPayload.Queries["toDate"] = ExpressionConverter.Convert(__workflow_toDate);
                if (__workflow_isbillable != null)
                    callPayload.Queries["isbillable"] = ExpressionConverter.Convert(__workflow_isbillable);
                return new ApiConnectionAction<TimeSheetResult>(callPayload);
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
        public IBodyWorkflowAction<Teams[], ApiConnectionActionConfiguration> GetTeams()
        {
            return new DeferredBodyAction<Teams[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/teams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Teams[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<Roledetails[], ApiConnectionActionConfiguration> GetUserRoles()
        {
            return new DeferredBodyAction<Roledetails[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/roles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Roledetails[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<UserModel[], ApiConnectionActionConfiguration> GetClientAreaPartners()
        {
            return new DeferredBodyAction<UserModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/client/area/partners";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<UserModel[], ApiConnectionActionConfiguration> GetClientAreaManagers()
        {
            return new DeferredBodyAction<UserModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/client/area/managers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<UserModel[], ApiConnectionActionConfiguration> GetJobAreaPartners()
        {
            return new DeferredBodyAction<UserModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/job/area/partners";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<UserModel[], ApiConnectionActionConfiguration> GetJobAreaManagers()
        {
            return new DeferredBodyAction<UserModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/job/area/managers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserModel[]>(callPayload);
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
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateJobs(Expression<Func<CreateJobsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateJobStatus(Expression<Func<int>> jobId, Expression<Func<UpdateJobStatusBodyInput>> body)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workflows/jobs/{0}/status", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobData[], ApiConnectionActionConfiguration> GetAJob(Expression<Func<int>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<JobData[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workflows/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobData[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateAJob(Expression<Func<int>> jobId, Expression<Func<CreateJobsBodyInput>> body)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workflows/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateJobTaskGroup(Expression<Func<int>> jobId, Expression<Func<string>> taskgroupname)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_taskgroupname = WorkflowExpression.Compile(taskgroupname, nameof(taskgroupname), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workflows/jobs/{0}/taskgroup/{1}", __workflow_jobId.WithUrlEncoding(1), __workflow_taskgroupname.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateJobTaskGroup(Expression<Func<int>> jobId, Expression<Func<int>> taskgroupId, Expression<Func<string>> taskgroupname)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_taskgroupId = WorkflowExpression.Compile(taskgroupId, nameof(taskgroupId), required: true);
            var __workflow_taskgroupname = WorkflowExpression.Compile(taskgroupname, nameof(taskgroupname), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workflows/jobs/{0}/taskgroup/{1}/{2}", __workflow_jobId.WithUrlEncoding(1), __workflow_taskgroupId.WithUrlEncoding(1), __workflow_taskgroupname.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientProfileTaskGroupData[], ApiConnectionActionConfiguration> GetJobTaskGroups(Expression<Func<int>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<ClientProfileTaskGroupData[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workflows/jobs/{0}/taskgroups", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ClientProfileTaskGroupData[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientProfileTask[], ApiConnectionActionConfiguration> GetJobTaskGroupTasks(Expression<Func<int>> jobId, Expression<Func<int>> taskgroupId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_taskgroupId = WorkflowExpression.Compile(taskgroupId, nameof(taskgroupId), required: true);
            return new DeferredBodyAction<ClientProfileTask[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workflows/jobs/{0}/taskgroups/{1}/tasks", __workflow_jobId.WithUrlEncoding(1), __workflow_taskgroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ClientProfileTask[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> CreateJobTasks(Expression<Func<CreateJobTasksBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/jobs/taskgroups/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ResponseMessage, ApiConnectionActionConfiguration> UpdateJobTask(Expression<Func<int>> taskId, Expression<Func<CreateJobTasksBodyInput>> body)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResponseMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workflows/jobs/taskgroups/tasks/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResponseMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<TasksResult, ApiConnectionActionConfiguration> GetTasks(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> status = null, Expression<Func<string>> assigneeId = null, Expression<Func<int>> daysUntilDue = null, Expression<Func<int>> jobId = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_assigneeId = WorkflowExpression.Compile(assigneeId, nameof(assigneeId), required: false);
            var __workflow_daysUntilDue = WorkflowExpression.Compile(daysUntilDue, nameof(daysUntilDue), required: false);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: false);
            return new DeferredBodyAction<TasksResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_assigneeId != null)
                    callPayload.Queries["assigneeId"] = ExpressionConverter.Convert(__workflow_assigneeId);
                if (__workflow_daysUntilDue != null)
                    callPayload.Queries["daysUntilDue"] = ExpressionConverter.Convert(__workflow_daysUntilDue);
                if (__workflow_jobId != null)
                    callPayload.Queries["jobId"] = ExpressionConverter.Convert(__workflow_jobId);
                return new ApiConnectionAction<TasksResult>(callPayload);
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

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("mailingName")]
        public string MailingName { get; set; }

        [JsonProperty("tradingAs")]
        public string TradingAs { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("email")]
        public GetAClientEmailInfoResponse[] Email { get; set; }

        [JsonProperty("phone")]
        public GetAClientPhoneResponse[] Phone { get; set; }

        [JsonProperty("division")]
        public Division Division { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("partner")]
        public Staff Partner { get; set; }

        [JsonProperty("manager")]
        public Staff Manager { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("addresses")]
        public GetAClientAddressResponse[] Addresses { get; set; }

        [JsonProperty("acn")]
        public string Acn { get; set; }

        [JsonProperty("abn")]
        public string Abn { get; set; }

        [JsonProperty("tfn")]
        public string Tfn { get; set; }

        [JsonProperty("din")]
        public string Din { get; set; }

        [JsonProperty("gstRegistered")]
        public bool GstRegistered { get; set; }

        [JsonProperty("taxClient")]
        public bool TaxClient { get; set; }

        [JsonProperty("isProspect")]
        public bool IsProspect { get; set; }

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

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("trustType")]
        public string TrustType { get; set; }

        [JsonProperty("dateOfDeath")]
        public string DateOfDeath { get; set; }

        [JsonProperty("formationDate")]
        public string FormationDate { get; set; }

        [JsonProperty("annualReviewDate")]
        public string AnnualReviewDate { get; set; }

        [JsonProperty("deRegistrationDate")]
        public string DeRegistrationDate { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("customFields")]
        public GetAClientCustomFieldResponse[] CustomFields { get; set; }
    }

    public class GetAClientEmailInfoResponse
    {
        [JsonProperty("typeId")]
        public int TypeId { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("preferred")]
        public bool Preferred { get; set; }

        [JsonProperty("favourite")]
        public bool Favourite { get; set; }
    }

    public class GetAClientPhoneResponse
    {
        [JsonProperty("typeId")]
        public int TypeId { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("countryId")]
        public int CountryId { get; set; }

        [JsonProperty("isdCode")]
        public int IsdCode { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("preferred")]
        public bool Preferred { get; set; }

        [JsonProperty("favourite")]
        public bool Favourite { get; set; }
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

        [JsonProperty("contextType")]
        public int ContextType { get; set; }

        [JsonProperty("email")]
        public GetAClientEmailInfoResponse[] Email { get; set; }

        [JsonProperty("phone")]
        public GetAClientPhoneResponse[] Phone { get; set; }
    }

    public class GetAClientAddressResponse
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

    public class Tag
    {
        [JsonProperty("tagId")]
        public int TagId { get; set; }

        [JsonProperty("tagName")]
        public string TagName { get; set; }
    }

    public class GetAClientCustomFieldResponse
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

    public class ResponseMessage
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("currentDate")]
        public string CurrentDate { get; set; }
    }

    public class CreateClientsBodyInput
    {
        public CreateClientsBodyInput(string entityType, string clientCode, string partnerId, int divisionId)
        {
            this.EntityType = entityType;
            this.ClientCode = clientCode;
            this.PartnerId = partnerId;
            this.DivisionId = divisionId;
        }

        [JsonProperty("entityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntityType { get; set; }

        [JsonProperty("clientCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ClientCode { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

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

        [JsonProperty("dateofBirth")]
        public string DateofBirth { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("dateOfDeath")]
        public string DateOfDeath { get; set; }

        [JsonProperty("deRegistrationDate")]
        public string DeRegistrationDate { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("email")]
        public CreateClientsEmailInfo[] Email { get; set; }

        [JsonProperty("phone")]
        public CreateClientsPhone[] Phone { get; set; }

        [JsonProperty("linkedInProfileId")]
        public string LinkedInProfileId { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("annualReviewDate")]
        public string AnnualReviewDate { get; set; }

        [JsonProperty("formationDate")]
        public string FormationDate { get; set; }

        [JsonProperty("addresses")]
        public CreateClientsAddress[] Addresses { get; set; }

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
        public string Tfn { get; set; }

        [JsonProperty("abn")]
        public string Abn { get; set; }

        [JsonProperty("acn")]
        public string Acn { get; set; }

        [JsonProperty("din")]
        public string Din { get; set; }

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
        public string BankBSB { get; set; }

        [JsonProperty("bankAccountNumber")]
        public string BankAccountNumber { get; set; }

        [JsonProperty("customFields")]
        public CreateClientsCustomField[] CustomFields { get; set; }

        [JsonProperty("mailingName")]
        public string MailingName { get; set; }

        [JsonProperty("tagIds")]
        public int[] TagIds { get; set; }

        [JsonProperty("clientBrefcode")]
        public string ClientBrefcode { get; set; }

        [JsonProperty("enumEntityTypes")]
        public EntityTypeNames? EnumEntityTypes { get; set; }

        [JsonProperty("enumTrustTypes")]
        public TrustTypes? EnumTrustTypes { get; set; }

        [JsonProperty("enumGender")]
        public GenderNames? EnumGender { get; set; }

        [JsonProperty("enumContactTypes")]
        public ContactTypes? EnumContactTypes { get; set; }

        [JsonProperty("enumAddressTypes")]
        public AddressType? EnumAddressTypes { get; set; }
    }

    public class CreateClientsEmailInfo
    {
        [JsonProperty("typeId")]
        public int? TypeId { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("preferred")]
        public bool? Preferred { get; set; }

        [JsonProperty("favourite")]
        public bool? Favourite { get; set; }
    }

    public class CreateClientsPhone
    {
        [JsonProperty("typeId")]
        public int? TypeId { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("countryId")]
        public int? CountryId { get; set; }

        [JsonProperty("isdCode")]
        public int? IsdCode { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("preferred")]
        public bool? Preferred { get; set; }

        [JsonProperty("favourite")]
        public bool? Favourite { get; set; }
    }

    public class CreateClientsAddress
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

    public class CreateClientsCustomField
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
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
        Female,
        [EnumMember(Value = "unspecified")]
        Unspecified
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

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("mailingName")]
        public string MailingName { get; set; }

        [JsonProperty("tradingAs")]
        public string TradingAs { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("email")]
        public GetAClientEmailInfoResponse[] Email { get; set; }

        [JsonProperty("phone")]
        public GetAClientPhoneResponse[] Phone { get; set; }

        [JsonProperty("division")]
        public Division Division { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("partner")]
        public Staff Partner { get; set; }

        [JsonProperty("manager")]
        public Staff Manager { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("addresses")]
        public GetAClientAddressResponse[] Addresses { get; set; }

        [JsonProperty("acn")]
        public string Acn { get; set; }

        [JsonProperty("abn")]
        public string Abn { get; set; }

        [JsonProperty("gstRegistered")]
        public bool GstRegistered { get; set; }

        [JsonProperty("taxClient")]
        public bool TaxClient { get; set; }

        [JsonProperty("isProspect")]
        public bool IsProspect { get; set; }

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

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("trustType")]
        public string TrustType { get; set; }

        [JsonProperty("dateOfDeath")]
        public string DateOfDeath { get; set; }

        [JsonProperty("formationDate")]
        public string FormationDate { get; set; }

        [JsonProperty("annualReviewDate")]
        public string AnnualReviewDate { get; set; }

        [JsonProperty("deRegistrationDate")]
        public string DeRegistrationDate { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("customFields")]
        public GetAClientCustomFieldResponse[] CustomFields { get; set; }

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

    public class TagModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class CreateClientGroupBodyInput
    {
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("tags")]
        public int[] Tags { get; set; }

        [JsonProperty("groupClients")]
        public CreateClientGroupGroupClient[] GroupClients { get; set; }

        [JsonProperty("contactId")]
        public int? ContactId { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }
    }

    public class CreateClientGroupGroupClient
    {
        [JsonProperty("clientId")]
        public int? ClientId { get; set; }

        [JsonProperty("isDebitorClient")]
        public bool? IsDebitorClient { get; set; }

        [JsonProperty("relationIds")]
        public int[] RelationIds { get; set; }
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

    public class SalutationInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }
    }

    public class TitleInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ClientGroupResult
    {
        [JsonProperty("clientGroups")]
        public GroupClients[] ClientGroups { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class GroupClients
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("groupCode")]
        public string GroupCode { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("contact")]
        public GroupContact Contact { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("clients")]
        public GetClientGroupsGroupClientResponse[] Clients { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }
    }

    public class GroupContact
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contextType")]
        public int ContextType { get; set; }
    }

    public class GetClientGroupsGroupClientResponse
    {
        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("clientCode")]
        public string ClientCode { get; set; }

        [JsonProperty("clientname")]
        public string Clientname { get; set; }

        [JsonProperty("isDebtorClient")]
        public bool IsDebtorClient { get; set; }

        [JsonProperty("debtorClientId")]
        public int DebtorClientId { get; set; }
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

    public class ClientContacts
    {
        [JsonProperty("clientid")]
        public int Clientid { get; set; }

        [JsonProperty("contactid")]
        public int Contactid { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }
    }

    public class ContactsInfoResult
    {
        [JsonProperty("communicationcontacts")]
        public ContactsInfo[] Communicationcontacts { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class ContactsInfo
    {
        [JsonProperty("contactId")]
        public int ContactId { get; set; }

        [JsonProperty("contextType")]
        public int ContextType { get; set; }

        [JsonProperty("systemId")]
        public string SystemId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("weburl")]
        public string Weburl { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
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

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("email")]
        public GetAClientEmailInfoResponse[] Email { get; set; }

        [JsonProperty("phone")]
        public GetAClientPhoneResponse[] Phone { get; set; }

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

        [JsonProperty("dateOfDeath")]
        public string DateOfDeath { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("addresses")]
        public GetAClientAddressResponse[] Addresses { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("customFields")]
        public GetAClientCustomFieldResponse[] CustomFields { get; set; }
    }

    public class CreateContactsBodyInput
    {
        public CreateContactsBodyInput(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("email")]
        public CreateClientsEmailInfo[] Email { get; set; }

        [JsonProperty("phone")]
        public CreateClientsPhone[] Phone { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("linkedInProfileID")]
        public string LinkedInProfileId { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("dateOfDeath")]
        public string DateOfDeath { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("din")]
        public string Din { get; set; }

        [JsonProperty("isImportent")]
        public bool? IsImportent { get; set; }

        [JsonProperty("addresses")]
        public CreateClientsAddress[] Addresses { get; set; }

        [JsonProperty("customFields")]
        public CreateClientsCustomField[] CustomFields { get; set; }

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

        [JsonProperty("taxName")]
        public string TaxName { get; set; }

        [JsonProperty("taxRate")]
        public double TaxRate { get; set; }

        [JsonProperty("gst")]
        public double Gst { get; set; }

        [JsonProperty("payment")]
        public double Payment { get; set; }

        [JsonProperty("creditNote")]
        public double CreditNote { get; set; }

        [JsonProperty("creditAdjustment")]
        public double CreditAdjustment { get; set; }

        [JsonProperty("feeReversal")]
        public double FeeReversal { get; set; }

        [JsonProperty("badDebt")]
        public double BadDebt { get; set; }

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

        [JsonProperty("mailingName")]
        public string MailingName { get; set; }

        [JsonProperty("clientMailingName")]
        public string ClientMailingName { get; set; }

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

        [JsonProperty("templateName")]
        public string TemplateName { get; set; }
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

    public class TaxTypes
    {
        [JsonProperty("taxId")]
        public int TaxId { get; set; }

        [JsonProperty("taxName")]
        public string TaxName { get; set; }

        [JsonProperty("taxRate")]
        public double TaxRate { get; set; }

        [JsonProperty("effectiveFrom")]
        public string EffectiveFrom { get; set; }

        [JsonProperty("effectiveTo")]
        public string EffectiveTo { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class CreateNonBillableTimesheetTypeBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UpdateNonBillableTimesheetTypeBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CreateJobTypeBodyInput
    {
        [JsonProperty("jobTypeName")]
        public string JobTypeName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("divisionId")]
        public int? DivisionId { get; set; }

        [JsonProperty("defaultTemplate")]
        public int? DefaultTemplate { get; set; }

        [JsonProperty("debtorJobCategory")]
        public string DebtorJobCategory { get; set; }

        [JsonProperty("relatedJobCategory")]
        public string RelatedJobCategory { get; set; }

        [JsonProperty("lstJobstatus")]
        public JobStatusModel[] LstJobstatus { get; set; }

        [JsonProperty("enumJobCategoryTypes")]
        public JobCategory? EnumJobCategoryTypes { get; set; }
    }

    public class JobStatusModel
    {
        [JsonProperty("statusId")]
        public int? StatusId { get; set; }

        [JsonProperty("statusCatId")]
        public int? StatusCatId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("statusName")]
        public string StatusName { get; set; }
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

    public class StatusCatagory
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
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

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

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

        [JsonProperty("jobTypeId")]
        public int JobTypeId { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class CreateJobTemplateBodyInput
    {
        [JsonProperty("templateName")]
        public string TemplateName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("estimateType")]
        public string EstimateType { get; set; }

        [JsonProperty("jobTypeId")]
        public int? JobTypeId { get; set; }

        [JsonProperty("turnaround")]
        public int? Turnaround { get; set; }
    }

    public class JobPriority
    {
        [JsonProperty("jobPriorityId")]
        public int JobPriorityId { get; set; }

        [JsonProperty("jobPriorityName")]
        public string JobPriorityName { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
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

    public class CompositeTemplateTaskGroupViewModel
    {
        [JsonProperty("taskGroup")]
        public TaskTemplateGroupList TaskGroup { get; set; }

        [JsonProperty("tasks")]
        public TaskTemplateViewDetailModel[] Tasks { get; set; }
    }

    public class TaskTemplateGroupList
    {
        [JsonProperty("templateId")]
        public int TemplateId { get; set; }

        [JsonProperty("taskgroupId")]
        public int TaskgroupId { get; set; }

        [JsonProperty("taskGroupName")]
        public string TaskGroupName { get; set; }

        [JsonProperty("createdBY")]
        public string CreatedBY { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }
    }

    public class TaskTemplateViewDetailModel
    {
        [JsonProperty("taskId")]
        public int TaskId { get; set; }

        [JsonProperty("taskgroupId")]
        public int TaskgroupId { get; set; }

        [JsonProperty("taskType")]
        public string TaskType { get; set; }

        [JsonProperty("taskTypeId")]
        public int TaskTypeId { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("keyFlag")]
        public string KeyFlag { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }

        [JsonProperty("roleId")]
        public int RoleId { get; set; }

        [JsonProperty("templateId")]
        public int TemplateId { get; set; }

        [JsonProperty("unit")]
        public int Unit { get; set; }

        [JsonProperty("rolesUnits")]
        public GetTemplateTaskGroupTasksRoleUnitResponse[] RolesUnits { get; set; }

        [JsonProperty("taskMembers")]
        public string[] TaskMembers { get; set; }

        [JsonProperty("taskCategory")]
        public GetJobTaskGroupTasksTaskCategoryResponse TaskCategory { get; set; }

        [JsonProperty("taskDependencyCount")]
        public int TaskDependencyCount { get; set; }

        [JsonProperty("startAfterDays")]
        public int StartAfterDays { get; set; }

        [JsonProperty("dueAfterDays")]
        public int DueAfterDays { get; set; }
    }

    public class GetTemplateTaskGroupTasksRoleUnitResponse
    {
        [JsonProperty("roleId")]
        public int RoleId { get; set; }

        [JsonProperty("unit")]
        public int Unit { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetJobTaskGroupTasksTaskCategoryResponse
    {
        Workflow,
        Timesheet,
        WorkflowTimesheet,
        NonBillable,
        WorkflowNonBillable
    }

    public class CreateTemplateTaskBodyInput
    {
        [JsonProperty("templateId")]
        public int? TemplateId { get; set; }

        [JsonProperty("taskgroupId")]
        public int? TaskgroupId { get; set; }

        [JsonProperty("taskTypeId")]
        public int? TaskTypeId { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("rolesUnits")]
        public CreateTemplateTaskRoleUnit[] RolesUnits { get; set; }

        [JsonProperty("taskCategory")]
        public string TaskCategory { get; set; }

        [JsonProperty("startAfterDays")]
        public int? StartAfterDays { get; set; }

        [JsonProperty("dueAfterDays")]
        public int? DueAfterDays { get; set; }
    }

    public class CreateTemplateTaskRoleUnit
    {
        [JsonProperty("roleId")]
        public int? RoleId { get; set; }

        [JsonProperty("unit")]
        public int? Unit { get; set; }
    }

    public class EmailType
    {
        [JsonProperty("emailTypeId")]
        public int EmailTypeId { get; set; }

        [JsonProperty("emailTypeName")]
        public string EmailTypeName { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class PhoneType
    {
        [JsonProperty("phoneTypeId")]
        public int PhoneTypeId { get; set; }

        [JsonProperty("phoneTypeName")]
        public string PhoneTypeName { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class Country
    {
        [JsonProperty("countryId")]
        public int CountryId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isdCode")]
        public int IsdCode { get; set; }
    }

    public class CreateTaskTypeBodyInput
    {
        [JsonProperty("taskType")]
        public string TaskType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("taskCategory")]
        public string TaskCategory { get; set; }

        [JsonProperty("enumTaskCategory")]
        public CreateTaskTypeTaskCategory? EnumTaskCategory { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTaskTypeTaskCategory
    {
        Workflow,
        Timesheet,
        WorkflowTimesheet,
        NonBillable,
        WorkflowNonBillable
    }

    public class UpdateJobTemplateBodyInput
    {
        [JsonProperty("templateName")]
        public string TemplateName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("jobTypeId")]
        public int? JobTypeId { get; set; }

        [JsonProperty("turnaround")]
        public int? Turnaround { get; set; }
    }

    public class Leave
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class PostJobLogTimeResponse
    {
        [JsonProperty("isbillable")]
        public bool Isbillable { get; set; }

        [JsonProperty("jobId")]
        public int JobId { get; set; }

        [JsonProperty("taskId")]
        public int TaskId { get; set; }

        [JsonProperty("nonbillableId")]
        public int NonbillableId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("starttime")]
        public string Starttime { get; set; }

        [JsonProperty("units")]
        public double Units { get; set; }

        [JsonProperty("timeSheetTime")]
        public string TimeSheetTime { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rowNumber")]
        public int RowNumber { get; set; }

        [JsonProperty("logTimeId")]
        public int LogTimeId { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class JobLogTime
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

        [JsonProperty("starttime")]
        public string Starttime { get; set; }

        [JsonProperty("units")]
        public double? Units { get; set; }

        [JsonProperty("timeSheetTime")]
        public string TimeSheetTime { get; set; }

        [JsonProperty("rate")]
        public double? Rate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class TimeSheetResult
    {
        [JsonProperty("timeSheets")]
        public TimeSheetLogs[] TimeSheets { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class TimeSheetLogs
    {
        [JsonProperty("isbillable")]
        public bool Isbillable { get; set; }

        [JsonProperty("jobId")]
        public int JobId { get; set; }

        [JsonProperty("taskId")]
        public int TaskId { get; set; }

        [JsonProperty("nonbillableId")]
        public int NonbillableId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("starttime")]
        public string Starttime { get; set; }

        [JsonProperty("units")]
        public double Units { get; set; }

        [JsonProperty("timeSheetTime")]
        public string TimeSheetTime { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("logTimeId")]
        public int LogTimeId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
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

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public GetAClientEmailInfoResponse Email { get; set; }

        [JsonProperty("phone")]
        public GetAClientPhoneResponse Phone { get; set; }

        [JsonProperty("address")]
        public GetAClientAddressResponse Address { get; set; }

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

    public class Roledetails
    {
        [JsonProperty("roleId")]
        public int RoleId { get; set; }

        [JsonProperty("accountingFirmId")]
        public int AccountingFirmId { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("defaultRoleName")]
        public string DefaultRoleName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isSystem")]
        public bool IsSystem { get; set; }
    }

    public class UserModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
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

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

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
        public GetAClientCustomFieldResponse[] CustomFields { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
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

    public class CreateJobsBodyInput
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
        public CreateClientsCustomField[] CustomFields { get; set; }

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

    public class UpdateJobStatusBodyInput
    {
        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusOwner")]
        public string StatusOwner { get; set; }
    }

    public class JobData
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

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

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
        public GetAClientCustomFieldResponse[] CustomFields { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("templateId")]
        public int TemplateId { get; set; }

        [JsonProperty("jobTypeId")]
        public int JobTypeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("jobCategory")]
        public string JobCategory { get; set; }

        [JsonProperty("estimateType")]
        public string EstimateType { get; set; }

        [JsonProperty("billingMethod")]
        public string BillingMethod { get; set; }

        [JsonProperty("statusId")]
        public int StatusId { get; set; }

        [JsonProperty("quoteAmount")]
        public double QuoteAmount { get; set; }
    }

    public class ClientProfileTaskGroupData
    {
        [JsonProperty("taskGroupId")]
        public int TaskGroupId { get; set; }

        [JsonProperty("jobId")]
        public int JobId { get; set; }

        [JsonProperty("taskGroupName")]
        public string TaskGroupName { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }

        [JsonProperty("taskCount")]
        public int TaskCount { get; set; }

        [JsonProperty("isTaskAllCheck")]
        public bool IsTaskAllCheck { get; set; }

        [JsonProperty("isSubTaskAllCheck")]
        public bool IsSubTaskAllCheck { get; set; }

        [JsonProperty("tasks")]
        public ClientProfileTask[] Tasks { get; set; }

        [JsonProperty("statusCount")]
        public StatusCount StatusCount { get; set; }

        [JsonProperty("assignees")]
        public string Assignees { get; set; }
    }

    public class ClientProfileTask
    {
        [JsonProperty("taskId")]
        public int TaskId { get; set; }

        [JsonProperty("taskGroupId")]
        public int TaskGroupId { get; set; }

        [JsonProperty("taskTitle")]
        public string TaskTitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("assignee")]
        public string Assignee { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("contextId")]
        public int ContextId { get; set; }

        [JsonProperty("contextType")]
        public string ContextType { get; set; }

        [JsonProperty("reminders")]
        public string Reminders { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }

        [JsonProperty("jobTypeId")]
        public int JobTypeId { get; set; }

        [JsonProperty("taskType")]
        public int TaskType { get; set; }

        [JsonProperty("unit")]
        public int Unit { get; set; }

        [JsonProperty("totalUnit")]
        public int TotalUnit { get; set; }

        [JsonProperty("roleId")]
        public int RoleId { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("assigneeUserDetails")]
        public TaskAssigneeUserDetails[] AssigneeUserDetails { get; set; }

        [JsonProperty("isChecked")]
        public bool IsChecked { get; set; }

        [JsonProperty("documentsCount")]
        public int DocumentsCount { get; set; }

        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("taskCategory")]
        public GetJobTaskGroupTasksTaskCategoryResponse TaskCategory { get; set; }

        [JsonProperty("taskDependencyCount")]
        public int TaskDependencyCount { get; set; }
    }

    public class TaskAssigneeUserDetails
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("taskId")]
        public int TaskId { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("unit")]
        public int Unit { get; set; }

        [JsonProperty("totalUnit")]
        public int TotalUnit { get; set; }

        [JsonProperty("isFirstUserForRole")]
        public bool IsFirstUserForRole { get; set; }

        [JsonProperty("roleId")]
        public int RoleId { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }
    }

    public class StatusCount
    {
        [JsonProperty("notStartedCount")]
        public int NotStartedCount { get; set; }

        [JsonProperty("inProgressCount")]
        public int InProgressCount { get; set; }

        [JsonProperty("onHoldCount")]
        public int OnHoldCount { get; set; }

        [JsonProperty("reviewCount")]
        public int ReviewCount { get; set; }

        [JsonProperty("completedCount")]
        public int CompletedCount { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }

    public class CreateJobTasksBodyInput
    {
        [JsonProperty("jobId")]
        public int? JobId { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("taskTypeId")]
        public int? TaskTypeId { get; set; }

        [JsonProperty("taskgroupId")]
        public int? TaskgroupId { get; set; }

        [JsonProperty("taskAssignees")]
        public Assigneeuser[] TaskAssignees { get; set; }

        [JsonProperty("taskCategory")]
        public string TaskCategory { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }
    }

    public class Assigneeuser
    {
        [JsonProperty("taskLevelRoleId")]
        public int? TaskLevelRoleId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("unit")]
        public int? Unit { get; set; }
    }

    public class TasksResult
    {
        [JsonProperty("tasks")]
        public TaskModel[] Tasks { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class TaskModel
    {
        [JsonProperty("taskId")]
        public int TaskId { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("jobId")]
        public int JobId { get; set; }

        [JsonProperty("jobName")]
        public string JobName { get; set; }

        [JsonProperty("jobManager")]
        public Staff JobManager { get; set; }

        [JsonProperty("jobPartner")]
        public Staff JobPartner { get; set; }

        [JsonProperty("jobClient")]
        public ClientInfo JobClient { get; set; }

        [JsonProperty("jobDebtor")]
        public ClientInfo JobDebtor { get; set; }

        [JsonProperty("jobDivision")]
        public EntityInfo JobDivision { get; set; }

        [JsonProperty("assignees")]
        public Staff[] Assignees { get; set; }

        [JsonProperty("taskType")]
        public string TaskType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("daysUntilDue")]
        public string DaysUntilDue { get; set; }

        [JsonProperty("taskCategory")]
        public string TaskCategory { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class ClientInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class EntityInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
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