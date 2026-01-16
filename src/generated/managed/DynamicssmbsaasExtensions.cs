//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicssmbsaas
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicssmbsaasActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<GetAdaptiveCardV3Response> GetAdaptiveCardV3(Expression<Func<string>> targeturl, Expression<Func<targetappInput>> targetapp)
        {
            var apiCallPath = String.Format("/v3/adaptivecard/forurl/{0}/forapp/{1}", ExpressionConverter.ConvertWithUrlEncoding(targeturl, 2), ExpressionConverter.ConvertWithUrlEncoding(targetapp, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAdaptiveCardV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<CompanyList> GetCompaniesV3(Expression<Func<string>> bcenvironment)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CompanyList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> InvokeMCP(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> configurationName, Expression<Func<string>> mcpSessionId = null, Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/configuration/{2}/mcp", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(configurationName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mcpSessionId != null)
                callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(mcpSessionId);
            var queryRequest = new JObject();
            var queryRequestpropCount = 0;
            if (queryRequestjsonrpc != null)
            {
                queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(queryRequestjsonrpc);
                queryRequestpropCount++;
            }

            if (queryRequestid != null)
            {
                queryRequest["id"] = ExpressionConverter.ConvertO(queryRequestid);
                queryRequestpropCount++;
            }

            if (queryRequestmethod != null)
            {
                queryRequest["method"] = ExpressionConverter.ConvertO(queryRequestmethod);
                queryRequestpropCount++;
            }

            var paramsObject = new JObject();
            var paramsObjectpropCount = 0;
            if (paramsObjectpropCount > 0)
            {
                queryRequest["params"] = paramsObject;
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<string> GetBlobFromNavigationV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> blobnavigationpath, Expression<Func<object>> pathParameters = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokeget", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(blobnavigationpath, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(pathParameters);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IWorkflowAction PatchBlobFromNavigationV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> blobnavigationpath, Expression<Func<object>> pathParameters = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokepatch", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(blobnavigationpath, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(pathParameters);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> ExecuteProcedureV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> procedure, Expression<Func<object>> parameters = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/procedures/{3}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(procedure, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(parameters);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<ItemsListV3> GetItemsV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> readOnlyConnection = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (readOnlyConnection != null)
                callPayload.Queries["readOnlyConnection"] = ExpressionConverter.Convert(readOnlyConnection);
            return new ApiConnectionAction<ItemsListV3>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> PostItemV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<object>> item = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> GetItemV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<bool>> readOnlyConnection = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (readOnlyConnection != null)
                callPayload.Queries["readOnlyConnection"] = ExpressionConverter.Convert(readOnlyConnection);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IWorkflowAction DeleteItemV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> PatchItemV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> GetFirstItemV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<bodytypeOfOrderInput>> bodytypeOfOrder = null, Expression<Func<string>> bodyorderResultsBy = null, Expression<Func<bool>> bodycontinueWithEmptyResultWhenNoRecordWasFound = null, Expression<Func<FilterGroup[]>> bodyfilter = null, Expression<Func<bool>> readOnlyConnection = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/first", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (readOnlyConnection != null)
                callPayload.Queries["readOnlyConnection"] = ExpressionConverter.Convert(readOnlyConnection);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytypeOfOrder != null)
            {
                body["Order"] = ExpressionConverter.ConvertO(bodytypeOfOrder);
                bodypropCount++;
            }

            if (bodyorderResultsBy != null)
            {
                body["OrderField"] = ExpressionConverter.ConvertO(bodyorderResultsBy);
                bodypropCount++;
            }

            if (bodycontinueWithEmptyResultWhenNoRecordWasFound != null)
            {
                body["NoThrowError"] = ExpressionConverter.ConvertO(bodycontinueWithEmptyResultWhenNoRecordWasFound);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["Filter"] = ExpressionConverter.ConvertO(bodyfilter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<GetUrlV3Response> GetUrlV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> page, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/pages/{2}/items/{3}/url", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(page, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUrlV3Response>(callPayload);
        }
    }

    public class DynamicssmbsaasTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<ClientSubscriptionResponse> CreateBusinessEventSubscriptionV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> businessevent, Expression<Func<string>> company = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/businessevents/{1}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(businessevent, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = Convert.ToString("");
            if (company != null)
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<ClientSubscriptionResponse> CreateOnChangedItemsSubscriptionV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onchangeditems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<ClientSubscriptionResponse> CreateOnDeletedItemsSubscriptionV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/ondeleteditems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<ClientSubscriptionResponse> CreateOnNewItemsSubscriptionV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onnewitems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<ClientSubscriptionResponse> CreateOnUpdatedItemsSubscriptionV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onupdateditems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WebHookSubscriptionResponse> CreateCustomerApprovalWebHookV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/customerapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionfirstCondition != null)
            {
                subscription["FirstConditionField"] = ExpressionConverter.ConvertO(subscriptionfirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfirstConditionIs != null)
            {
                subscription["FirstConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionfirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionsecondCondition != null)
            {
                subscription["SecondConditionField"] = ExpressionConverter.ConvertO(subscriptionsecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionsecondConditionIs != null)
            {
                subscription["SecondConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionsecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionthirdCondition != null)
            {
                subscription["ThirdConditionField"] = ExpressionConverter.ConvertO(subscriptionthirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionthirdConditionIs != null)
            {
                subscription["ThirdConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionthirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionfourthCondition != null)
            {
                subscription["FourthConditionField"] = ExpressionConverter.ConvertO(subscriptionfourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfourthConditionIs != null)
            {
                subscription["FourthConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionfourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalBatchApprovalWebHookV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournalbatchapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionfirstCondition != null)
            {
                subscription["FirstConditionField"] = ExpressionConverter.ConvertO(subscriptionfirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfirstConditionIs != null)
            {
                subscription["FirstConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionfirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionsecondCondition != null)
            {
                subscription["SecondConditionField"] = ExpressionConverter.ConvertO(subscriptionsecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionsecondConditionIs != null)
            {
                subscription["SecondConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionsecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionthirdCondition != null)
            {
                subscription["ThirdConditionField"] = ExpressionConverter.ConvertO(subscriptionthirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionthirdConditionIs != null)
            {
                subscription["ThirdConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionthirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionfourthCondition != null)
            {
                subscription["FourthConditionField"] = ExpressionConverter.ConvertO(subscriptionfourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfourthConditionIs != null)
            {
                subscription["FourthConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionfourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalLineApprovalWebHookV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournallineapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionfirstCondition != null)
            {
                subscription["FirstConditionField"] = ExpressionConverter.ConvertO(subscriptionfirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfirstConditionIs != null)
            {
                subscription["FirstConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionfirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionsecondCondition != null)
            {
                subscription["SecondConditionField"] = ExpressionConverter.ConvertO(subscriptionsecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionsecondConditionIs != null)
            {
                subscription["SecondConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionsecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionthirdCondition != null)
            {
                subscription["ThirdConditionField"] = ExpressionConverter.ConvertO(subscriptionthirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionthirdConditionIs != null)
            {
                subscription["ThirdConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionthirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionfourthCondition != null)
            {
                subscription["FourthConditionField"] = ExpressionConverter.ConvertO(subscriptionfourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfourthConditionIs != null)
            {
                subscription["FourthConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionfourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WebHookSubscriptionResponse> CreateItemApprovalWebHookV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/itemapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionfirstCondition != null)
            {
                subscription["FirstConditionField"] = ExpressionConverter.ConvertO(subscriptionfirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfirstConditionIs != null)
            {
                subscription["FirstConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionfirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionsecondCondition != null)
            {
                subscription["SecondConditionField"] = ExpressionConverter.ConvertO(subscriptionsecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionsecondConditionIs != null)
            {
                subscription["SecondConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionsecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionthirdCondition != null)
            {
                subscription["ThirdConditionField"] = ExpressionConverter.ConvertO(subscriptionthirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionthirdConditionIs != null)
            {
                subscription["ThirdConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionthirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionfourthCondition != null)
            {
                subscription["FourthConditionField"] = ExpressionConverter.ConvertO(subscriptionfourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfourthConditionIs != null)
            {
                subscription["FourthConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionfourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WebHookSubscriptionResponse> CreatePurchaseDocumentApprovalWebHookV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionheaderFirstCondition = null, Expression<Func<string>> subscriptionheaderFirstConditionIs = null, Expression<Func<string>> subscriptionheaderSecondCondition = null, Expression<Func<string>> subscriptionheaderSecondConditionIs = null, Expression<Func<string>> subscriptionheaderThirdCondition = null, Expression<Func<string>> subscriptionheaderThirdConditionIs = null, Expression<Func<string>> subscriptionheaderFourthCondition = null, Expression<Func<string>> subscriptionheaderFourthConditionIs = null, Expression<Func<string>> subscriptionlineFirstCondition = null, Expression<Func<string>> subscriptionlineFirstConditionIs = null, Expression<Func<string>> subscriptionlineSecondCondition = null, Expression<Func<string>> subscriptionlineSecondConditionIs = null, Expression<Func<string>> subscriptionlineThirdCondition = null, Expression<Func<string>> subscriptionlineThirdConditionIs = null, Expression<Func<string>> subscriptionlineFourthCondition = null, Expression<Func<string>> subscriptionlineFourthConditionIs = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/purchasedocumentapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionheaderFirstCondition != null)
            {
                subscription["HeaderFirstConditionField"] = ExpressionConverter.ConvertO(subscriptionheaderFirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFirstConditionIs != null)
            {
                subscription["HeaderFirstConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionheaderFirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderSecondCondition != null)
            {
                subscription["HeaderSecondConditionField"] = ExpressionConverter.ConvertO(subscriptionheaderSecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderSecondConditionIs != null)
            {
                subscription["HeaderSecondConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionheaderSecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderThirdCondition != null)
            {
                subscription["HeaderThirdConditionField"] = ExpressionConverter.ConvertO(subscriptionheaderThirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderThirdConditionIs != null)
            {
                subscription["HeaderThirdConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionheaderThirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFourthCondition != null)
            {
                subscription["HeaderFourthConditionField"] = ExpressionConverter.ConvertO(subscriptionheaderFourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFourthConditionIs != null)
            {
                subscription["HeaderFourthConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionheaderFourthConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineFirstCondition != null)
            {
                subscription["LineFirstConditionField"] = ExpressionConverter.ConvertO(subscriptionlineFirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineFirstConditionIs != null)
            {
                subscription["LineFirstConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionlineFirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineSecondCondition != null)
            {
                subscription["LineSecondConditionField"] = ExpressionConverter.ConvertO(subscriptionlineSecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineSecondConditionIs != null)
            {
                subscription["LineSecondConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionlineSecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineThirdCondition != null)
            {
                subscription["LineThirdConditionField"] = ExpressionConverter.ConvertO(subscriptionlineThirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineThirdConditionIs != null)
            {
                subscription["LineThirdConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionlineThirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineFourthCondition != null)
            {
                subscription["LineFourthConditionField"] = ExpressionConverter.ConvertO(subscriptionlineFourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineFourthConditionIs != null)
            {
                subscription["LineFourthConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionlineFourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WebHookSubscriptionResponse> CreateSalesDocumentApprovalWebHookV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionheaderFirstCondition = null, Expression<Func<string>> subscriptionheaderFirstConditionIs = null, Expression<Func<string>> subscriptionheaderSecondCondition = null, Expression<Func<string>> subscriptionheaderSecondConditionIs = null, Expression<Func<string>> subscriptionheaderThirdCondition = null, Expression<Func<string>> subscriptionheaderThirdConditionIs = null, Expression<Func<string>> subscriptionheaderFourthCondition = null, Expression<Func<string>> subscriptionheaderFourthConditionIs = null, Expression<Func<string>> subscriptionlineFirstCondition = null, Expression<Func<string>> subscriptionlineFirstConditionIs = null, Expression<Func<string>> subscriptionlineSecondCondition = null, Expression<Func<string>> subscriptionlineSecondConditionIs = null, Expression<Func<string>> subscriptionlineThirdCondition = null, Expression<Func<string>> subscriptionlineThirdConditionIs = null, Expression<Func<string>> subscriptionlineFourthCondition = null, Expression<Func<string>> subscriptionlineFourthConditionIs = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/salesdocumentapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionheaderFirstCondition != null)
            {
                subscription["HeaderFirstConditionField"] = ExpressionConverter.ConvertO(subscriptionheaderFirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFirstConditionIs != null)
            {
                subscription["HeaderFirstConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionheaderFirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderSecondCondition != null)
            {
                subscription["HeaderSecondConditionField"] = ExpressionConverter.ConvertO(subscriptionheaderSecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderSecondConditionIs != null)
            {
                subscription["HeaderSecondConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionheaderSecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderThirdCondition != null)
            {
                subscription["HeaderThirdConditionField"] = ExpressionConverter.ConvertO(subscriptionheaderThirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderThirdConditionIs != null)
            {
                subscription["HeaderThirdConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionheaderThirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFourthCondition != null)
            {
                subscription["HeaderFourthConditionField"] = ExpressionConverter.ConvertO(subscriptionheaderFourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFourthConditionIs != null)
            {
                subscription["HeaderFourthConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionheaderFourthConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineFirstCondition != null)
            {
                subscription["LineFirstConditionField"] = ExpressionConverter.ConvertO(subscriptionlineFirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineFirstConditionIs != null)
            {
                subscription["LineFirstConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionlineFirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineSecondCondition != null)
            {
                subscription["LineSecondConditionField"] = ExpressionConverter.ConvertO(subscriptionlineSecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineSecondConditionIs != null)
            {
                subscription["LineSecondConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionlineSecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineThirdCondition != null)
            {
                subscription["LineThirdConditionField"] = ExpressionConverter.ConvertO(subscriptionlineThirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineThirdConditionIs != null)
            {
                subscription["LineThirdConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionlineThirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineFourthCondition != null)
            {
                subscription["LineFourthConditionField"] = ExpressionConverter.ConvertO(subscriptionlineFourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineFourthConditionIs != null)
            {
                subscription["LineFourthConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionlineFourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WebHookSubscriptionResponse> CreateVendorApprovalWebHookV3(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/vendorapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionfirstCondition != null)
            {
                subscription["FirstConditionField"] = ExpressionConverter.ConvertO(subscriptionfirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfirstConditionIs != null)
            {
                subscription["FirstConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionfirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionsecondCondition != null)
            {
                subscription["SecondConditionField"] = ExpressionConverter.ConvertO(subscriptionsecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionsecondConditionIs != null)
            {
                subscription["SecondConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionsecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionthirdCondition != null)
            {
                subscription["ThirdConditionField"] = ExpressionConverter.ConvertO(subscriptionthirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionthirdConditionIs != null)
            {
                subscription["ThirdConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionthirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionfourthCondition != null)
            {
                subscription["FourthConditionField"] = ExpressionConverter.ConvertO(subscriptionfourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfourthConditionIs != null)
            {
                subscription["FourthConditionFieldValue"] = ExpressionConverter.ConvertO(subscriptionfourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload);
        }
    }

    public class GetAdaptiveCardV3Response
    {
        [JsonProperty("AdaptiveCardJsonString")]
        public string AdaptiveCard { get; set; }
    }

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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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