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
        public IBodyWorkflowAction<JToken> InvokeMCP(Expression<Func<string>> bcenvironment, Expression<Func<string>> configurationName, Expression<Func<string>> company, Expression<Func<string>> mcpSessionId = null, Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_configurationName = WorkflowExpression.Compile(configurationName, nameof(configurationName), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/configuration/{2}/mcp", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_configurationName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (__workflow_queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(__workflow_queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(__workflow_queryRequestid);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(__workflow_queryRequestmethod);
                    queryRequestpropCount++;
                }

                var @paramsObject = new JObject();
                var @paramsObjectpropCount = 0;
                if (@paramsObjectpropCount > 0)
                {
                    queryRequest["params"] = @paramsObject;
                    queryRequestpropCount++;
                }

                var resultObject = new JObject();
                var resultObjectpropCount = 0;
                if (resultObjectpropCount > 0)
                {
                    queryRequest["result"] = resultObject;
                    queryRequestpropCount++;
                }

                var errorObject = new JObject();
                var errorObjectpropCount = 0;
                if (errorObjectpropCount > 0)
                {
                    queryRequest["error"] = errorObject;
                    queryRequestpropCount++;
                }

                if (queryRequestpropCount > 0)
                {
                    callPayload.Body = queryRequest;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> procedure, Expression<Func<object>> parameters = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_procedure = WorkflowExpression.Compile(procedure, nameof(procedure), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/procedures/{3}", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_procedure.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<GetAdaptiveCardV3Response> GetAdaptiveCard(Expression<Func<string>> targeturl, Expression<Func<targetappInput>> targetapp)
        {
            var __workflow_targeturl = WorkflowExpression.Compile(targeturl, nameof(targeturl), required: true);
            var __workflow_targetapp = WorkflowExpression.Compile(targetapp, nameof(targetapp), required: true);
            return new DeferredBodyAction<GetAdaptiveCardV3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/adaptivecard/forurl/{0}/forapp/{1}", __workflow_targeturl.WithUrlEncoding(2), __workflow_targetapp.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAdaptiveCardV3Response>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<string> GetBlobFromNavigation(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> blobnavigationpath, Expression<Func<object>> pathParameters = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_blobnavigationpath = WorkflowExpression.Compile(blobnavigationpath, nameof(blobnavigationpath), required: true);
            var __workflow_pathParameters = WorkflowExpression.Compile(pathParameters, nameof(pathParameters), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokeget", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_blobnavigationpath.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_pathParameters);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<CompanyList> GetCompanies(Expression<Func<string>> bcenvironment)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            return new DeferredBodyAction<CompanyList>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies", __workflow_bcenvironment.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompanyList>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> GetFirstItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<bodytypeOfOrderInput>> bodytypeOfOrder = null, Expression<Func<string>> bodyorderResultsBy = null, Expression<Func<bool>> bodycontinueWithEmptyResultWhenNoRecordWasFound = null, Expression<Func<FilterGroup[]>> bodyfilter = null, Expression<Func<bool>> readOnlyConnection = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_bodytypeOfOrder = WorkflowExpression.Compile(bodytypeOfOrder, nameof(bodytypeOfOrder), required: false);
            var __workflow_bodyorderResultsBy = WorkflowExpression.Compile(bodyorderResultsBy, nameof(bodyorderResultsBy), required: false);
            var __workflow_bodycontinueWithEmptyResultWhenNoRecordWasFound = WorkflowExpression.Compile(bodycontinueWithEmptyResultWhenNoRecordWasFound, nameof(bodycontinueWithEmptyResultWhenNoRecordWasFound), required: false);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_readOnlyConnection = WorkflowExpression.Compile(readOnlyConnection, nameof(readOnlyConnection), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/first", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_readOnlyConnection != null)
                    callPayload.Queries["readOnlyConnection"] = ExpressionConverter.Convert(__workflow_readOnlyConnection);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytypeOfOrder != null)
                {
                    body["Order"] = ExpressionConverter.ConvertO(__workflow_bodytypeOfOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyorderResultsBy != null)
                {
                    body["OrderField"] = ExpressionConverter.ConvertO(__workflow_bodyorderResultsBy);
                    bodypropCount++;
                }

                if (__workflow_bodycontinueWithEmptyResultWhenNoRecordWasFound != null)
                {
                    if (__workflow_bodycontinueWithEmptyResultWhenNoRecordWasFound != null)
                    {
                        body["NoThrowError"] = ExpressionConverter.ConvertO(__workflow_bodycontinueWithEmptyResultWhenNoRecordWasFound);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["NoThrowError"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyfilter != null)
                {
                    body["Filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<bool>> readOnlyConnection = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_readOnlyConnection = WorkflowExpression.Compile(readOnlyConnection, nameof(readOnlyConnection), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_readOnlyConnection != null)
                    callPayload.Queries["readOnlyConnection"] = ExpressionConverter.Convert(__workflow_readOnlyConnection);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<ItemsListV3> GetItems(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> readOnlyConnection = null)
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
            return new DeferredBodyAction<ItemsListV3>(() =>
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<GetUrlV3Response> GetUrl(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> page, Expression<Func<string>> id)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetUrlV3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/pages/{2}/items/{3}/url", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_page.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUrlV3Response>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IWorkflowAction PatchBlobFromNavigation(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> blobnavigationpath, Expression<Func<object>> pathParameters = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_blobnavigationpath = WorkflowExpression.Compile(blobnavigationpath, nameof(blobnavigationpath), required: true);
            var __workflow_pathParameters = WorkflowExpression.Compile(pathParameters, nameof(pathParameters), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokepatch", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_blobnavigationpath.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_pathParameters);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> PatchItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> PostItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<object>> item = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class DynamicssmbsaasTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateBusinessEventSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> businessevent, Expression<Func<string>> company = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_businessevent = WorkflowExpression.Compile(businessevent, nameof(businessevent), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: false);
            return new DeferredBodyTrigger<ClientSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/businessevents/{1}/subscriptions", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_businessevent.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = Convert.ToString("");
                if (__workflow_company != null)
                    callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateCustomerApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscriptionfirstCondition = WorkflowExpression.Compile(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            var __workflow_subscriptionfirstConditionIs = WorkflowExpression.Compile(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            var __workflow_subscriptionsecondCondition = WorkflowExpression.Compile(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            var __workflow_subscriptionsecondConditionIs = WorkflowExpression.Compile(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            var __workflow_subscriptionthirdCondition = WorkflowExpression.Compile(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            var __workflow_subscriptionthirdConditionIs = WorkflowExpression.Compile(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            var __workflow_subscriptionfourthCondition = WorkflowExpression.Compile(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            var __workflow_subscriptionfourthConditionIs = WorkflowExpression.Compile(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/customerapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (__workflow_subscriptionfirstCondition != null)
                {
                    subscription["FirstConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionfirstCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfirstConditionIs != null)
                {
                    subscription["FirstConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionfirstConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionsecondCondition != null)
                {
                    subscription["SecondConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionsecondCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionsecondConditionIs != null)
                {
                    subscription["SecondConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionsecondConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionthirdCondition != null)
                {
                    subscription["ThirdConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionthirdCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionthirdConditionIs != null)
                {
                    subscription["ThirdConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionthirdConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfourthCondition != null)
                {
                    subscription["FourthConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionfourthCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfourthConditionIs != null)
                {
                    subscription["FourthConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionfourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalBatchApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscriptionfirstCondition = WorkflowExpression.Compile(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            var __workflow_subscriptionfirstConditionIs = WorkflowExpression.Compile(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            var __workflow_subscriptionsecondCondition = WorkflowExpression.Compile(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            var __workflow_subscriptionsecondConditionIs = WorkflowExpression.Compile(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            var __workflow_subscriptionthirdCondition = WorkflowExpression.Compile(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            var __workflow_subscriptionthirdConditionIs = WorkflowExpression.Compile(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            var __workflow_subscriptionfourthCondition = WorkflowExpression.Compile(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            var __workflow_subscriptionfourthConditionIs = WorkflowExpression.Compile(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournalbatchapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (__workflow_subscriptionfirstCondition != null)
                {
                    subscription["FirstConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionfirstCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfirstConditionIs != null)
                {
                    subscription["FirstConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionfirstConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionsecondCondition != null)
                {
                    subscription["SecondConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionsecondCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionsecondConditionIs != null)
                {
                    subscription["SecondConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionsecondConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionthirdCondition != null)
                {
                    subscription["ThirdConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionthirdCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionthirdConditionIs != null)
                {
                    subscription["ThirdConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionthirdConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfourthCondition != null)
                {
                    subscription["FourthConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionfourthCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfourthConditionIs != null)
                {
                    subscription["FourthConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionfourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalLineApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscriptionfirstCondition = WorkflowExpression.Compile(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            var __workflow_subscriptionfirstConditionIs = WorkflowExpression.Compile(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            var __workflow_subscriptionsecondCondition = WorkflowExpression.Compile(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            var __workflow_subscriptionsecondConditionIs = WorkflowExpression.Compile(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            var __workflow_subscriptionthirdCondition = WorkflowExpression.Compile(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            var __workflow_subscriptionthirdConditionIs = WorkflowExpression.Compile(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            var __workflow_subscriptionfourthCondition = WorkflowExpression.Compile(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            var __workflow_subscriptionfourthConditionIs = WorkflowExpression.Compile(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournallineapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (__workflow_subscriptionfirstCondition != null)
                {
                    subscription["FirstConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionfirstCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfirstConditionIs != null)
                {
                    subscription["FirstConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionfirstConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionsecondCondition != null)
                {
                    subscription["SecondConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionsecondCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionsecondConditionIs != null)
                {
                    subscription["SecondConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionsecondConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionthirdCondition != null)
                {
                    subscription["ThirdConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionthirdCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionthirdConditionIs != null)
                {
                    subscription["ThirdConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionthirdConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfourthCondition != null)
                {
                    subscription["FourthConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionfourthCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfourthConditionIs != null)
                {
                    subscription["FourthConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionfourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateItemApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscriptionfirstCondition = WorkflowExpression.Compile(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            var __workflow_subscriptionfirstConditionIs = WorkflowExpression.Compile(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            var __workflow_subscriptionsecondCondition = WorkflowExpression.Compile(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            var __workflow_subscriptionsecondConditionIs = WorkflowExpression.Compile(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            var __workflow_subscriptionthirdCondition = WorkflowExpression.Compile(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            var __workflow_subscriptionthirdConditionIs = WorkflowExpression.Compile(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            var __workflow_subscriptionfourthCondition = WorkflowExpression.Compile(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            var __workflow_subscriptionfourthConditionIs = WorkflowExpression.Compile(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/itemapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (__workflow_subscriptionfirstCondition != null)
                {
                    subscription["FirstConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionfirstCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfirstConditionIs != null)
                {
                    subscription["FirstConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionfirstConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionsecondCondition != null)
                {
                    subscription["SecondConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionsecondCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionsecondConditionIs != null)
                {
                    subscription["SecondConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionsecondConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionthirdCondition != null)
                {
                    subscription["ThirdConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionthirdCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionthirdConditionIs != null)
                {
                    subscription["ThirdConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionthirdConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfourthCondition != null)
                {
                    subscription["FourthConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionfourthCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfourthConditionIs != null)
                {
                    subscription["FourthConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionfourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnChangedItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onchangeditems/$subscriptions", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnDeletedItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/ondeleteditems/$subscriptions", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnNewItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onnewitems/$subscriptions", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnUpdatedItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onupdateditems/$subscriptions", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2), __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreatePurchaseDocumentApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionheaderFirstCondition = null, Expression<Func<string>> subscriptionheaderFirstConditionIs = null, Expression<Func<string>> subscriptionheaderSecondCondition = null, Expression<Func<string>> subscriptionheaderSecondConditionIs = null, Expression<Func<string>> subscriptionheaderThirdCondition = null, Expression<Func<string>> subscriptionheaderThirdConditionIs = null, Expression<Func<string>> subscriptionheaderFourthCondition = null, Expression<Func<string>> subscriptionheaderFourthConditionIs = null, Expression<Func<string>> subscriptionlineFirstCondition = null, Expression<Func<string>> subscriptionlineFirstConditionIs = null, Expression<Func<string>> subscriptionlineSecondCondition = null, Expression<Func<string>> subscriptionlineSecondConditionIs = null, Expression<Func<string>> subscriptionlineThirdCondition = null, Expression<Func<string>> subscriptionlineThirdConditionIs = null, Expression<Func<string>> subscriptionlineFourthCondition = null, Expression<Func<string>> subscriptionlineFourthConditionIs = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscriptionheaderFirstCondition = WorkflowExpression.Compile(subscriptionheaderFirstCondition, nameof(subscriptionheaderFirstCondition), required: false);
            var __workflow_subscriptionheaderFirstConditionIs = WorkflowExpression.Compile(subscriptionheaderFirstConditionIs, nameof(subscriptionheaderFirstConditionIs), required: false);
            var __workflow_subscriptionheaderSecondCondition = WorkflowExpression.Compile(subscriptionheaderSecondCondition, nameof(subscriptionheaderSecondCondition), required: false);
            var __workflow_subscriptionheaderSecondConditionIs = WorkflowExpression.Compile(subscriptionheaderSecondConditionIs, nameof(subscriptionheaderSecondConditionIs), required: false);
            var __workflow_subscriptionheaderThirdCondition = WorkflowExpression.Compile(subscriptionheaderThirdCondition, nameof(subscriptionheaderThirdCondition), required: false);
            var __workflow_subscriptionheaderThirdConditionIs = WorkflowExpression.Compile(subscriptionheaderThirdConditionIs, nameof(subscriptionheaderThirdConditionIs), required: false);
            var __workflow_subscriptionheaderFourthCondition = WorkflowExpression.Compile(subscriptionheaderFourthCondition, nameof(subscriptionheaderFourthCondition), required: false);
            var __workflow_subscriptionheaderFourthConditionIs = WorkflowExpression.Compile(subscriptionheaderFourthConditionIs, nameof(subscriptionheaderFourthConditionIs), required: false);
            var __workflow_subscriptionlineFirstCondition = WorkflowExpression.Compile(subscriptionlineFirstCondition, nameof(subscriptionlineFirstCondition), required: false);
            var __workflow_subscriptionlineFirstConditionIs = WorkflowExpression.Compile(subscriptionlineFirstConditionIs, nameof(subscriptionlineFirstConditionIs), required: false);
            var __workflow_subscriptionlineSecondCondition = WorkflowExpression.Compile(subscriptionlineSecondCondition, nameof(subscriptionlineSecondCondition), required: false);
            var __workflow_subscriptionlineSecondConditionIs = WorkflowExpression.Compile(subscriptionlineSecondConditionIs, nameof(subscriptionlineSecondConditionIs), required: false);
            var __workflow_subscriptionlineThirdCondition = WorkflowExpression.Compile(subscriptionlineThirdCondition, nameof(subscriptionlineThirdCondition), required: false);
            var __workflow_subscriptionlineThirdConditionIs = WorkflowExpression.Compile(subscriptionlineThirdConditionIs, nameof(subscriptionlineThirdConditionIs), required: false);
            var __workflow_subscriptionlineFourthCondition = WorkflowExpression.Compile(subscriptionlineFourthCondition, nameof(subscriptionlineFourthCondition), required: false);
            var __workflow_subscriptionlineFourthConditionIs = WorkflowExpression.Compile(subscriptionlineFourthConditionIs, nameof(subscriptionlineFourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/purchasedocumentapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (__workflow_subscriptionheaderFirstCondition != null)
                {
                    subscription["HeaderFirstConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderFirstCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderFirstConditionIs != null)
                {
                    subscription["HeaderFirstConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderFirstConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderSecondCondition != null)
                {
                    subscription["HeaderSecondConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderSecondCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderSecondConditionIs != null)
                {
                    subscription["HeaderSecondConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderSecondConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderThirdCondition != null)
                {
                    subscription["HeaderThirdConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderThirdCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderThirdConditionIs != null)
                {
                    subscription["HeaderThirdConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderThirdConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderFourthCondition != null)
                {
                    subscription["HeaderFourthConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderFourthCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderFourthConditionIs != null)
                {
                    subscription["HeaderFourthConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderFourthConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineFirstCondition != null)
                {
                    subscription["LineFirstConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineFirstCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineFirstConditionIs != null)
                {
                    subscription["LineFirstConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineFirstConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineSecondCondition != null)
                {
                    subscription["LineSecondConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineSecondCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineSecondConditionIs != null)
                {
                    subscription["LineSecondConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineSecondConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineThirdCondition != null)
                {
                    subscription["LineThirdConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineThirdCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineThirdConditionIs != null)
                {
                    subscription["LineThirdConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineThirdConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineFourthCondition != null)
                {
                    subscription["LineFourthConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineFourthCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineFourthConditionIs != null)
                {
                    subscription["LineFourthConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineFourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateSalesDocumentApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionheaderFirstCondition = null, Expression<Func<string>> subscriptionheaderFirstConditionIs = null, Expression<Func<string>> subscriptionheaderSecondCondition = null, Expression<Func<string>> subscriptionheaderSecondConditionIs = null, Expression<Func<string>> subscriptionheaderThirdCondition = null, Expression<Func<string>> subscriptionheaderThirdConditionIs = null, Expression<Func<string>> subscriptionheaderFourthCondition = null, Expression<Func<string>> subscriptionheaderFourthConditionIs = null, Expression<Func<string>> subscriptionlineFirstCondition = null, Expression<Func<string>> subscriptionlineFirstConditionIs = null, Expression<Func<string>> subscriptionlineSecondCondition = null, Expression<Func<string>> subscriptionlineSecondConditionIs = null, Expression<Func<string>> subscriptionlineThirdCondition = null, Expression<Func<string>> subscriptionlineThirdConditionIs = null, Expression<Func<string>> subscriptionlineFourthCondition = null, Expression<Func<string>> subscriptionlineFourthConditionIs = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscriptionheaderFirstCondition = WorkflowExpression.Compile(subscriptionheaderFirstCondition, nameof(subscriptionheaderFirstCondition), required: false);
            var __workflow_subscriptionheaderFirstConditionIs = WorkflowExpression.Compile(subscriptionheaderFirstConditionIs, nameof(subscriptionheaderFirstConditionIs), required: false);
            var __workflow_subscriptionheaderSecondCondition = WorkflowExpression.Compile(subscriptionheaderSecondCondition, nameof(subscriptionheaderSecondCondition), required: false);
            var __workflow_subscriptionheaderSecondConditionIs = WorkflowExpression.Compile(subscriptionheaderSecondConditionIs, nameof(subscriptionheaderSecondConditionIs), required: false);
            var __workflow_subscriptionheaderThirdCondition = WorkflowExpression.Compile(subscriptionheaderThirdCondition, nameof(subscriptionheaderThirdCondition), required: false);
            var __workflow_subscriptionheaderThirdConditionIs = WorkflowExpression.Compile(subscriptionheaderThirdConditionIs, nameof(subscriptionheaderThirdConditionIs), required: false);
            var __workflow_subscriptionheaderFourthCondition = WorkflowExpression.Compile(subscriptionheaderFourthCondition, nameof(subscriptionheaderFourthCondition), required: false);
            var __workflow_subscriptionheaderFourthConditionIs = WorkflowExpression.Compile(subscriptionheaderFourthConditionIs, nameof(subscriptionheaderFourthConditionIs), required: false);
            var __workflow_subscriptionlineFirstCondition = WorkflowExpression.Compile(subscriptionlineFirstCondition, nameof(subscriptionlineFirstCondition), required: false);
            var __workflow_subscriptionlineFirstConditionIs = WorkflowExpression.Compile(subscriptionlineFirstConditionIs, nameof(subscriptionlineFirstConditionIs), required: false);
            var __workflow_subscriptionlineSecondCondition = WorkflowExpression.Compile(subscriptionlineSecondCondition, nameof(subscriptionlineSecondCondition), required: false);
            var __workflow_subscriptionlineSecondConditionIs = WorkflowExpression.Compile(subscriptionlineSecondConditionIs, nameof(subscriptionlineSecondConditionIs), required: false);
            var __workflow_subscriptionlineThirdCondition = WorkflowExpression.Compile(subscriptionlineThirdCondition, nameof(subscriptionlineThirdCondition), required: false);
            var __workflow_subscriptionlineThirdConditionIs = WorkflowExpression.Compile(subscriptionlineThirdConditionIs, nameof(subscriptionlineThirdConditionIs), required: false);
            var __workflow_subscriptionlineFourthCondition = WorkflowExpression.Compile(subscriptionlineFourthCondition, nameof(subscriptionlineFourthCondition), required: false);
            var __workflow_subscriptionlineFourthConditionIs = WorkflowExpression.Compile(subscriptionlineFourthConditionIs, nameof(subscriptionlineFourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/salesdocumentapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (__workflow_subscriptionheaderFirstCondition != null)
                {
                    subscription["HeaderFirstConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderFirstCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderFirstConditionIs != null)
                {
                    subscription["HeaderFirstConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderFirstConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderSecondCondition != null)
                {
                    subscription["HeaderSecondConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderSecondCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderSecondConditionIs != null)
                {
                    subscription["HeaderSecondConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderSecondConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderThirdCondition != null)
                {
                    subscription["HeaderThirdConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderThirdCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderThirdConditionIs != null)
                {
                    subscription["HeaderThirdConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderThirdConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderFourthCondition != null)
                {
                    subscription["HeaderFourthConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderFourthCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionheaderFourthConditionIs != null)
                {
                    subscription["HeaderFourthConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionheaderFourthConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineFirstCondition != null)
                {
                    subscription["LineFirstConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineFirstCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineFirstConditionIs != null)
                {
                    subscription["LineFirstConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineFirstConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineSecondCondition != null)
                {
                    subscription["LineSecondConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineSecondCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineSecondConditionIs != null)
                {
                    subscription["LineSecondConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineSecondConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineThirdCondition != null)
                {
                    subscription["LineThirdConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineThirdCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineThirdConditionIs != null)
                {
                    subscription["LineThirdConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineThirdConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineFourthCondition != null)
                {
                    subscription["LineFourthConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineFourthCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionlineFourthConditionIs != null)
                {
                    subscription["LineFourthConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionlineFourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateVendorApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_subscriptionfirstCondition = WorkflowExpression.Compile(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            var __workflow_subscriptionfirstConditionIs = WorkflowExpression.Compile(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            var __workflow_subscriptionsecondCondition = WorkflowExpression.Compile(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            var __workflow_subscriptionsecondConditionIs = WorkflowExpression.Compile(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            var __workflow_subscriptionthirdCondition = WorkflowExpression.Compile(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            var __workflow_subscriptionthirdConditionIs = WorkflowExpression.Compile(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            var __workflow_subscriptionfourthCondition = WorkflowExpression.Compile(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            var __workflow_subscriptionfourthConditionIs = WorkflowExpression.Compile(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/vendorapproval", __workflow_bcenvironment.WithUrlEncoding(2), __workflow_company.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (__workflow_subscriptionfirstCondition != null)
                {
                    subscription["FirstConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionfirstCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfirstConditionIs != null)
                {
                    subscription["FirstConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionfirstConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionsecondCondition != null)
                {
                    subscription["SecondConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionsecondCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionsecondConditionIs != null)
                {
                    subscription["SecondConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionsecondConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionthirdCondition != null)
                {
                    subscription["ThirdConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionthirdCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionthirdConditionIs != null)
                {
                    subscription["ThirdConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionthirdConditionIs);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfourthCondition != null)
                {
                    subscription["FourthConditionField"] = ExpressionConverter.ConvertO(__workflow_subscriptionfourthCondition);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionfourthConditionIs != null)
                {
                    subscription["FourthConditionFieldValue"] = ExpressionConverter.ConvertO(__workflow_subscriptionfourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeOfOrderInput
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
