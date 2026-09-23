//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicssmbsaas
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicssmbsaasActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> InvokeMCP([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> configurationName, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> mcpSessionId = null, [WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IWorkflowAction DeleteItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> procedure, [WorkflowExpression] Func<object> parameters = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/procedures/{3}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(procedure, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(parameters);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<GetAdaptiveCardV3Response> GetAdaptiveCard([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> targeturl, [WorkflowExpression] Func<targetappInput> targetapp)
        {
            var apiCallPath = String.Format("/v3/adaptivecard/forurl/{0}/forapp/{1}", ExpressionConverter.ConvertWithUrlEncoding(targeturl, 2), ExpressionConverter.ConvertWithUrlEncoding(targetapp, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAdaptiveCardV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<string> GetBlobFromNavigation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> blobnavigationpath, [WorkflowExpression] Func<object> pathParameters = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokeget", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(blobnavigationpath, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(pathParameters);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<CompanyList> GetCompanies([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CompanyList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> GetFirstItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<bodytypeOfOrderInput> bodytypeOfOrder = null, [WorkflowExpression] Func<string> bodyorderResultsBy = null, [WorkflowExpression] Func<bool> bodycontinueWithEmptyResultWhenNoRecordWasFound = null, [WorkflowExpression] Func<FilterGroup[]> bodyfilter = null, [WorkflowExpression] Func<bool> readOnlyConnection = null)
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
                if (bodycontinueWithEmptyResultWhenNoRecordWasFound != null)
                {
                    body["NoThrowError"] = ExpressionConverter.ConvertO(bodycontinueWithEmptyResultWhenNoRecordWasFound);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["NoThrowError"] = false;
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
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> readOnlyConnection = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (readOnlyConnection != null)
                callPayload.Queries["readOnlyConnection"] = ExpressionConverter.Convert(readOnlyConnection);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<ItemsListV3> GetItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> readOnlyConnection = null)
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
        public IBodyWorkflowAction<GetUrlV3Response> GetUrl([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> page, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/pages/{2}/items/{3}/url", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(page, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUrlV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IWorkflowAction PatchBlobFromNavigation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> blobnavigationpath, [WorkflowExpression] Func<object> pathParameters = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokepatch", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(blobnavigationpath, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(pathParameters);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> item = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class DynamicssmbsaasTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateBusinessEventSubscription([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> businessevent, [WorkflowExpression] Func<string> company = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/businessevents/{1}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(businessevent, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = Convert.ToString("");
            if (company != null)
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "#{listCallbackUrl()}";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateCustomerApprovalWebHook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
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

            subscription["NotificationUrl"] = "#{listCallbackUrl()}";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalBatchApprovalWebHook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
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

            subscription["NotificationUrl"] = "#{listCallbackUrl()}";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalLineApprovalWebHook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
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

            subscription["NotificationUrl"] = "#{listCallbackUrl()}";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateItemApprovalWebHook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
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

            subscription["NotificationUrl"] = "#{listCallbackUrl()}";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnChangedItemsSubscription([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onchangeditems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnDeletedItemsSubscription([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/ondeleteditems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnNewItemsSubscription([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onnewitems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnUpdatedItemsSubscription([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onupdateditems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreatePurchaseDocumentApprovalWebHook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> subscriptionheaderFirstCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderSecondCondition = null, [WorkflowExpression] Func<string> subscriptionheaderSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderThirdCondition = null, [WorkflowExpression] Func<string> subscriptionheaderThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderFourthCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFourthConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFirstCondition = null, [WorkflowExpression] Func<string> subscriptionlineFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineSecondCondition = null, [WorkflowExpression] Func<string> subscriptionlineSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineThirdCondition = null, [WorkflowExpression] Func<string> subscriptionlineThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFourthCondition = null, [WorkflowExpression] Func<string> subscriptionlineFourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
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

            subscription["NotificationUrl"] = "#{listCallbackUrl()}";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateSalesDocumentApprovalWebHook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> subscriptionheaderFirstCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderSecondCondition = null, [WorkflowExpression] Func<string> subscriptionheaderSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderThirdCondition = null, [WorkflowExpression] Func<string> subscriptionheaderThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderFourthCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFourthConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFirstCondition = null, [WorkflowExpression] Func<string> subscriptionlineFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineSecondCondition = null, [WorkflowExpression] Func<string> subscriptionlineSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineThirdCondition = null, [WorkflowExpression] Func<string> subscriptionlineThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFourthCondition = null, [WorkflowExpression] Func<string> subscriptionlineFourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
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

            subscription["NotificationUrl"] = "#{listCallbackUrl()}";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateVendorApprovalWebHook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> bcenvironment, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
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

            subscription["NotificationUrl"] = "#{listCallbackUrl()}";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
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