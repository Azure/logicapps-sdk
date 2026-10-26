//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicssmbsaas
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicssmbsaasActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InvokeMCP(Expression<Func<string>> bcenvironment, Expression<Func<string>> configurationName, Expression<Func<string>> company, Expression<Func<string>> mcpSessionId = null, Expression<Func<InvokeMCPInput>> queryRequest = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_configurationName = WorkflowExpression.Compile(configurationName, nameof(configurationName), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/configuration/{2}/mcp", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_configurationName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ExecuteProcedure(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> procedure, Expression<Func<object>> parameters)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_procedure = WorkflowExpression.Compile(procedure, nameof(procedure), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/procedures/{3}", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_procedure.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<GetAdaptiveCardV3Response, ApiConnectionActionConfiguration> GetAdaptiveCard(Expression<Func<string>> targeturl, Expression<Func<targetappInput>> targetapp)
        {
            var __workflow_targeturl = WorkflowExpression.Compile(targeturl, nameof(targeturl), required: true);
            var __workflow_targetapp = WorkflowExpression.Compile(targetapp, nameof(targetapp), required: true);
            return new DeferredBodyAction<GetAdaptiveCardV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/adaptivecard/forurl/{0}/forapp/{1}", __workflow_targeturl.WithUrlEncoding(2), __workflow_targetapp.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAdaptiveCardV3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetBlobFromNavigation(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> blobnavigationpath, Expression<Func<object>> pathParameters)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_blobnavigationpath = WorkflowExpression.Compile(blobnavigationpath, nameof(blobnavigationpath), required: true);
            var __workflow_pathParameters = WorkflowExpression.Compile(pathParameters, nameof(pathParameters), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokeget", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_blobnavigationpath.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_pathParameters);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<CompanyList, ApiConnectionActionConfiguration> GetCompanies(Expression<Func<string>> bcenvironment)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            return new DeferredBodyAction<CompanyList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies", __workflow_bcenvironment.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompanyList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetFirstItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<GetFirstItemV3Input>> body, Expression<Func<bool>> readOnlyConnection = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_readOnlyConnection = WorkflowExpression.Compile(readOnlyConnection, nameof(readOnlyConnection), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/first", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_readOnlyConnection != null)
                    callPayload.Queries["readOnlyConnection"] = ExpressionConverter.Convert(__workflow_readOnlyConnection);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<bool>> readOnlyConnection = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_readOnlyConnection = WorkflowExpression.Compile(readOnlyConnection, nameof(readOnlyConnection), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_readOnlyConnection != null)
                    callPayload.Queries["readOnlyConnection"] = ExpressionConverter.Convert(__workflow_readOnlyConnection);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<ItemsListV3, ApiConnectionActionConfiguration> GetItems(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> readOnlyConnection = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_readOnlyConnection = WorkflowExpression.Compile(readOnlyConnection, nameof(readOnlyConnection), required: false);
            return new DeferredBodyAction<ItemsListV3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_readOnlyConnection != null)
                    callPayload.Queries["readOnlyConnection"] = ExpressionConverter.Convert(__workflow_readOnlyConnection);
                return new ApiConnectionAction<ItemsListV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<GetUrlV3Response, ApiConnectionActionConfiguration> GetUrl(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> page, Expression<Func<string>> id)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetUrlV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/pages/{2}/items/{3}/url", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_page.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUrlV3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PatchBlobFromNavigation(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> blobnavigationpath, Expression<Func<object>> pathParameters)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_blobnavigationpath = WorkflowExpression.Compile(blobnavigationpath, nameof(blobnavigationpath), required: true);
            var __workflow_pathParameters = WorkflowExpression.Compile(pathParameters, nameof(pathParameters), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokepatch", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_blobnavigationpath.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_pathParameters);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> PatchItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> PostItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<object>> item)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class DynamicssmbsaasTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ClientSubscriptionResponse, ApiConnectionTriggerConfiguration> CreateBusinessEventSubscription(Expression<Func<string>> bcenvironment, Expression<Func<CreateBusinessEventSubscriptionV3Input>> subscription, Expression<Func<string>> businessevent, Expression<Func<string>> company = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            var __workflow_businessevent = WorkflowExpression.Compile(businessevent, nameof(businessevent), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: false);
            return new DeferredBodyTrigger<ClientSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/businessevents/{1}/subscriptions", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_businessevent.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = Convert.ToString("");
                if (__workflow_company != null)
                    callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration> CreateCustomerApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<CreateCustomerApprovalWebHookV3Input>> subscription, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/customerapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration> CreateGeneralJournalBatchApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<CreateGeneralJournalBatchApprovalWebHookV3Input>> subscription, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournalbatchapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration> CreateGeneralJournalLineApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<CreateGeneralJournalLineApprovalWebHookV3Input>> subscription, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournallineapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration> CreateItemApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<CreateItemApprovalWebHookV3Input>> subscription, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/itemapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse, ApiConnectionTriggerConfiguration> CreateOnChangedItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<CreateOnChangedItemsSubscriptionV3Input>> subscription, Expression<Func<string>> dataset, Expression<Func<string>> table, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onchangeditems/$subscriptions", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse, ApiConnectionTriggerConfiguration> CreateOnDeletedItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<CreateOnDeletedItemsSubscriptionV3Input>> subscription, Expression<Func<string>> dataset, Expression<Func<string>> table, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/ondeleteditems/$subscriptions", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse, ApiConnectionTriggerConfiguration> CreateOnNewItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<CreateOnNewItemsSubscriptionV3Input>> subscription, Expression<Func<string>> dataset, Expression<Func<string>> table, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onnewitems/$subscriptions", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse, ApiConnectionTriggerConfiguration> CreateOnUpdatedItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<CreateOnUpdatedItemsSubscriptionV3Input>> subscription, Expression<Func<string>> dataset, Expression<Func<string>> table, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onupdateditems/$subscriptions", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration> CreatePurchaseDocumentApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<CreatePurchaseDocumentApprovalWebHookV3Input>> subscription, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/purchasedocumentapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration> CreateSalesDocumentApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<CreateSalesDocumentApprovalWebHookV3Input>> subscription, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/salesdocumentapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration> CreateVendorApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<CreateVendorApprovalWebHookV3Input>> subscription, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/vendorapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class InvokeMCPInput
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }
    }

    public class GetAdaptiveCardV3Response
    {
        [JsonProperty("AdaptiveCardJsonString")]
        public string AdaptiveCard { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum targetappInput
    {
        Teams,
        Other
    }

    public class CompanyList
    {
        [JsonProperty("value")]
        public Company[] Value { get; set; }
    }

    public class Company
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        [JsonProperty("datasets")]
        public DataSet[] Datasets { get; set; }
    }

    public class DataSet
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }

        [JsonProperty("query")]
        public PassThroughNativeQuery[] Query { get; set; }
    }

    public class PassThroughNativeQuery
    {
        public string Language { get; set; }
    }

    public class GetFirstItemV3Input
    {
        [JsonProperty("Order")]
        public GetFirstItemV3InputTypeOfOrderType? TypeOfOrder { get; set; }

        [JsonProperty("OrderField")]
        public string OrderResultsBy { get; set; }

        [JsonProperty("NoThrowError", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ContinueWithEmptyResultWhenNoRecordWasFound { get; set; } = false;
        public FilterGroup[] Filter { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetFirstItemV3InputTypeOfOrderType
    {
        [EnumMember(Value = "ascending")]
        Ascending,
        [EnumMember(Value = "descending")]
        Descending
    }

    public class FilterGroup
    {
        [JsonProperty("FilterField")]
        public string OnThisField { get; set; }

        [JsonProperty("FilterOperator")]
        public FilterGroupOperatorType Operator { get; set; }

        [JsonProperty("FilterValue")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FilterGroupOperatorType
    {
        [EnumMember(Value = "equals")]
        Equals,
        [EnumMember(Value = "not equals")]
        NotEquals,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "less than")]
        LessThan,
        [EnumMember(Value = "greater than")]
        GreaterThan,
        [EnumMember(Value = "less than or equals")]
        LessThanOrEquals,
        [EnumMember(Value = "greater than or equals")]
        GreaterThanOrEquals
    }

    public class ItemsListV3
    {
        [JsonProperty("value")]
        public ItemV3[] Value { get; set; }
    }

    public class ItemV3
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class GetUrlV3Response
    {
        [JsonProperty("WebClientUrl")]
        public string WebClientURL { get; set; }
    }

    public class ClientSubscriptionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("notificationType")]
        public string NotificationType { get; set; }

        [JsonProperty("notificationUrl")]
        public string NotificationUrl { get; set; }

        [JsonProperty("renewInterval")]
        public string RenewInterval { get; set; }
    }

    public class CreateBusinessEventSubscriptionV3Input
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebHookSubscriptionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("notificationType")]
        public string NotificationType { get; set; }

        [JsonProperty("notificationUrl")]
        public string NotificationUrl { get; set; }
    }

    public class CreateCustomerApprovalWebHookV3Input
    {
        [JsonProperty("FirstConditionField")]
        public string FirstCondition { get; set; }

        [JsonProperty("FirstConditionFieldValue")]
        public string FirstConditionIs { get; set; }

        [JsonProperty("SecondConditionField")]
        public string SecondCondition { get; set; }

        [JsonProperty("SecondConditionFieldValue")]
        public string SecondConditionIs { get; set; }

        [JsonProperty("ThirdConditionField")]
        public string ThirdCondition { get; set; }

        [JsonProperty("ThirdConditionFieldValue")]
        public string ThirdConditionIs { get; set; }

        [JsonProperty("FourthConditionField")]
        public string FourthCondition { get; set; }

        [JsonProperty("FourthConditionFieldValue")]
        public string FourthConditionIs { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateGeneralJournalBatchApprovalWebHookV3Input
    {
        [JsonProperty("FirstConditionField")]
        public string FirstCondition { get; set; }

        [JsonProperty("FirstConditionFieldValue")]
        public string FirstConditionIs { get; set; }

        [JsonProperty("SecondConditionField")]
        public string SecondCondition { get; set; }

        [JsonProperty("SecondConditionFieldValue")]
        public string SecondConditionIs { get; set; }

        [JsonProperty("ThirdConditionField")]
        public string ThirdCondition { get; set; }

        [JsonProperty("ThirdConditionFieldValue")]
        public string ThirdConditionIs { get; set; }

        [JsonProperty("FourthConditionField")]
        public string FourthCondition { get; set; }

        [JsonProperty("FourthConditionFieldValue")]
        public string FourthConditionIs { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateGeneralJournalLineApprovalWebHookV3Input
    {
        [JsonProperty("FirstConditionField")]
        public string FirstCondition { get; set; }

        [JsonProperty("FirstConditionFieldValue")]
        public string FirstConditionIs { get; set; }

        [JsonProperty("SecondConditionField")]
        public string SecondCondition { get; set; }

        [JsonProperty("SecondConditionFieldValue")]
        public string SecondConditionIs { get; set; }

        [JsonProperty("ThirdConditionField")]
        public string ThirdCondition { get; set; }

        [JsonProperty("ThirdConditionFieldValue")]
        public string ThirdConditionIs { get; set; }

        [JsonProperty("FourthConditionField")]
        public string FourthCondition { get; set; }

        [JsonProperty("FourthConditionFieldValue")]
        public string FourthConditionIs { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateItemApprovalWebHookV3Input
    {
        [JsonProperty("FirstConditionField")]
        public string FirstCondition { get; set; }

        [JsonProperty("FirstConditionFieldValue")]
        public string FirstConditionIs { get; set; }

        [JsonProperty("SecondConditionField")]
        public string SecondCondition { get; set; }

        [JsonProperty("SecondConditionFieldValue")]
        public string SecondConditionIs { get; set; }

        [JsonProperty("ThirdConditionField")]
        public string ThirdCondition { get; set; }

        [JsonProperty("ThirdConditionFieldValue")]
        public string ThirdConditionIs { get; set; }

        [JsonProperty("FourthConditionField")]
        public string FourthCondition { get; set; }

        [JsonProperty("FourthConditionFieldValue")]
        public string FourthConditionIs { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateOnChangedItemsSubscriptionV3Input
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateOnDeletedItemsSubscriptionV3Input
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateOnNewItemsSubscriptionV3Input
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateOnUpdatedItemsSubscriptionV3Input
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreatePurchaseDocumentApprovalWebHookV3Input
    {
        [JsonProperty("HeaderFirstConditionField")]
        public string HeaderFirstCondition { get; set; }

        [JsonProperty("HeaderFirstConditionFieldValue")]
        public string HeaderFirstConditionIs { get; set; }

        [JsonProperty("HeaderSecondConditionField")]
        public string HeaderSecondCondition { get; set; }

        [JsonProperty("HeaderSecondConditionFieldValue")]
        public string HeaderSecondConditionIs { get; set; }

        [JsonProperty("HeaderThirdConditionField")]
        public string HeaderThirdCondition { get; set; }

        [JsonProperty("HeaderThirdConditionFieldValue")]
        public string HeaderThirdConditionIs { get; set; }

        [JsonProperty("HeaderFourthConditionField")]
        public string HeaderFourthCondition { get; set; }

        [JsonProperty("HeaderFourthConditionFieldValue")]
        public string HeaderFourthConditionIs { get; set; }

        [JsonProperty("LineFirstConditionField")]
        public string LineFirstCondition { get; set; }

        [JsonProperty("LineFirstConditionFieldValue")]
        public string LineFirstConditionIs { get; set; }

        [JsonProperty("LineSecondConditionField")]
        public string LineSecondCondition { get; set; }

        [JsonProperty("LineSecondConditionFieldValue")]
        public string LineSecondConditionIs { get; set; }

        [JsonProperty("LineThirdConditionField")]
        public string LineThirdCondition { get; set; }

        [JsonProperty("LineThirdConditionFieldValue")]
        public string LineThirdConditionIs { get; set; }

        [JsonProperty("LineFourthConditionField")]
        public string LineFourthCondition { get; set; }

        [JsonProperty("LineFourthConditionFieldValue")]
        public string LineFourthConditionIs { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateSalesDocumentApprovalWebHookV3Input
    {
        [JsonProperty("HeaderFirstConditionField")]
        public string HeaderFirstCondition { get; set; }

        [JsonProperty("HeaderFirstConditionFieldValue")]
        public string HeaderFirstConditionIs { get; set; }

        [JsonProperty("HeaderSecondConditionField")]
        public string HeaderSecondCondition { get; set; }

        [JsonProperty("HeaderSecondConditionFieldValue")]
        public string HeaderSecondConditionIs { get; set; }

        [JsonProperty("HeaderThirdConditionField")]
        public string HeaderThirdCondition { get; set; }

        [JsonProperty("HeaderThirdConditionFieldValue")]
        public string HeaderThirdConditionIs { get; set; }

        [JsonProperty("HeaderFourthConditionField")]
        public string HeaderFourthCondition { get; set; }

        [JsonProperty("HeaderFourthConditionFieldValue")]
        public string HeaderFourthConditionIs { get; set; }

        [JsonProperty("LineFirstConditionField")]
        public string LineFirstCondition { get; set; }

        [JsonProperty("LineFirstConditionFieldValue")]
        public string LineFirstConditionIs { get; set; }

        [JsonProperty("LineSecondConditionField")]
        public string LineSecondCondition { get; set; }

        [JsonProperty("LineSecondConditionFieldValue")]
        public string LineSecondConditionIs { get; set; }

        [JsonProperty("LineThirdConditionField")]
        public string LineThirdCondition { get; set; }

        [JsonProperty("LineThirdConditionFieldValue")]
        public string LineThirdConditionIs { get; set; }

        [JsonProperty("LineFourthConditionField")]
        public string LineFourthCondition { get; set; }

        [JsonProperty("LineFourthConditionFieldValue")]
        public string LineFourthConditionIs { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateVendorApprovalWebHookV3Input
    {
        [JsonProperty("FirstConditionField")]
        public string FirstCondition { get; set; }

        [JsonProperty("FirstConditionFieldValue")]
        public string FirstConditionIs { get; set; }

        [JsonProperty("SecondConditionField")]
        public string SecondCondition { get; set; }

        [JsonProperty("SecondConditionFieldValue")]
        public string SecondConditionIs { get; set; }

        [JsonProperty("ThirdConditionField")]
        public string ThirdCondition { get; set; }

        [JsonProperty("ThirdConditionFieldValue")]
        public string ThirdConditionIs { get; set; }

        [JsonProperty("FourthConditionField")]
        public string FourthCondition { get; set; }

        [JsonProperty("FourthConditionFieldValue")]
        public string FourthConditionIs { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicssmbsaas;

    public partial class WorkflowManagedActions
    {
        public DynamicssmbsaasActions Dynamicssmbsaas(string connectionId) => new DynamicssmbsaasActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DynamicssmbsaasTriggers Dynamicssmbsaas(string connectionId) => new DynamicssmbsaasTriggers(connectionId);
    }
}