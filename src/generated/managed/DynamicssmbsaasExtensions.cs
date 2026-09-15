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
        public IBodyWorkflowAction<JToken> InvokeMCP(Expression<Func<string>> bcenvironment, Expression<Func<string>> configurationName, Expression<Func<string>> company, Expression<Func<string>> mcpSessionId = null, Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/configuration/{2}/mcp", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mcpSessionId != null)
                callPayload.Headers["Mcp-Session-Id"] = CSharpExpressionConverter.ConvertO(mcpSessionId);
            var queryRequest = new JObject();
            var queryRequestpropCount = 0;
            if (queryRequestjsonrpc != null)
            {
                queryRequest["jsonrpc"] = CSharpExpressionConverter.ConvertToken(queryRequestjsonrpc);
                queryRequestpropCount++;
            }

            if (queryRequestid != null)
            {
                queryRequest["id"] = CSharpExpressionConverter.ConvertToken(queryRequestid);
                queryRequestpropCount++;
            }

            if (queryRequestmethod != null)
            {
                queryRequest["method"] = CSharpExpressionConverter.ConvertToken(queryRequestmethod);
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
        public IWorkflowAction DeleteItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> procedure, Expression<Func<object>> parameters = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/procedures/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(procedure, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(parameters);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<GetAdaptiveCardV3Response> GetAdaptiveCard(Expression<Func<string>> targeturl, Expression<Func<targetappInput>> targetapp)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/adaptivecard/forurl/{0}/forapp/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(targeturl, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(targetapp, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAdaptiveCardV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<string> GetBlobFromNavigation(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> blobnavigationpath, Expression<Func<object>> pathParameters = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokeget", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(blobnavigationpath, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(pathParameters);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<CompanyList> GetCompanies(Expression<Func<string>> bcenvironment)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CompanyList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> GetFirstItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<bodytypeOfOrderInput>> bodytypeOfOrder = null, Expression<Func<string>> bodyorderResultsBy = null, Expression<Func<bool>> bodycontinueWithEmptyResultWhenNoRecordWasFound = null, Expression<Func<FilterGroup[]>> bodyfilter = null, Expression<Func<bool>> readOnlyConnection = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/first", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (readOnlyConnection != null)
                callPayload.Queries["readOnlyConnection"] = CSharpExpressionConverter.ConvertO(readOnlyConnection);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytypeOfOrder != null)
            {
                body["Order"] = CSharpExpressionConverter.Convert(bodytypeOfOrder);
                bodypropCount++;
            }

            if (bodyorderResultsBy != null)
            {
                body["OrderField"] = CSharpExpressionConverter.ConvertToken(bodyorderResultsBy);
                bodypropCount++;
            }

            if (bodycontinueWithEmptyResultWhenNoRecordWasFound != null)
            {
                if (bodycontinueWithEmptyResultWhenNoRecordWasFound != null)
                {
                    body["NoThrowError"] = CSharpExpressionConverter.ConvertToken(bodycontinueWithEmptyResultWhenNoRecordWasFound);
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
                body["Filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<bool>> readOnlyConnection = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (readOnlyConnection != null)
                callPayload.Queries["readOnlyConnection"] = CSharpExpressionConverter.ConvertO(readOnlyConnection);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<ItemsListV3> GetItems(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> readOnlyConnection = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (readOnlyConnection != null)
                callPayload.Queries["readOnlyConnection"] = CSharpExpressionConverter.ConvertO(readOnlyConnection);
            return new ApiConnectionAction<ItemsListV3>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<GetUrlV3Response> GetUrl(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> page, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/pages/{2}/items/{3}/url", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(page, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUrlV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IWorkflowAction PatchBlobFromNavigation(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> blobnavigationpath, Expression<Func<object>> pathParameters = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokepatch", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(blobnavigationpath, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(pathParameters);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> PatchItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> PostItem(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<object>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class DynamicssmbsaasTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateBusinessEventSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> businessevent, Expression<Func<string>> company = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/businessevents/{1}/subscriptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(businessevent, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = Convert.ToString("");
            if (company != null)
                callPayload.Queries["company"] = CSharpExpressionConverter.ConvertO(company);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateCustomerApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/customerapproval", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionfirstCondition != null)
            {
                subscription["FirstConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionfirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfirstConditionIs != null)
            {
                subscription["FirstConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionfirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionsecondCondition != null)
            {
                subscription["SecondConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionsecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionsecondConditionIs != null)
            {
                subscription["SecondConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionsecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionthirdCondition != null)
            {
                subscription["ThirdConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionthirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionthirdConditionIs != null)
            {
                subscription["ThirdConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionthirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionfourthCondition != null)
            {
                subscription["FourthConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionfourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfourthConditionIs != null)
            {
                subscription["FourthConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionfourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalBatchApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournalbatchapproval", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionfirstCondition != null)
            {
                subscription["FirstConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionfirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfirstConditionIs != null)
            {
                subscription["FirstConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionfirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionsecondCondition != null)
            {
                subscription["SecondConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionsecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionsecondConditionIs != null)
            {
                subscription["SecondConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionsecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionthirdCondition != null)
            {
                subscription["ThirdConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionthirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionthirdConditionIs != null)
            {
                subscription["ThirdConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionthirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionfourthCondition != null)
            {
                subscription["FourthConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionfourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfourthConditionIs != null)
            {
                subscription["FourthConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionfourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalLineApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournallineapproval", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionfirstCondition != null)
            {
                subscription["FirstConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionfirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfirstConditionIs != null)
            {
                subscription["FirstConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionfirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionsecondCondition != null)
            {
                subscription["SecondConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionsecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionsecondConditionIs != null)
            {
                subscription["SecondConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionsecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionthirdCondition != null)
            {
                subscription["ThirdConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionthirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionthirdConditionIs != null)
            {
                subscription["ThirdConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionthirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionfourthCondition != null)
            {
                subscription["FourthConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionfourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfourthConditionIs != null)
            {
                subscription["FourthConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionfourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateItemApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/itemapproval", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionfirstCondition != null)
            {
                subscription["FirstConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionfirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfirstConditionIs != null)
            {
                subscription["FirstConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionfirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionsecondCondition != null)
            {
                subscription["SecondConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionsecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionsecondConditionIs != null)
            {
                subscription["SecondConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionsecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionthirdCondition != null)
            {
                subscription["ThirdConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionthirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionthirdConditionIs != null)
            {
                subscription["ThirdConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionthirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionfourthCondition != null)
            {
                subscription["FourthConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionfourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfourthConditionIs != null)
            {
                subscription["FourthConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionfourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnChangedItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onchangeditems/$subscriptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnDeletedItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/ondeleteditems/$subscriptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnNewItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onnewitems/$subscriptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnUpdatedItemsSubscription(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> dataset, Expression<Func<string>> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onupdateditems/$subscriptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreatePurchaseDocumentApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionheaderFirstCondition = null, Expression<Func<string>> subscriptionheaderFirstConditionIs = null, Expression<Func<string>> subscriptionheaderSecondCondition = null, Expression<Func<string>> subscriptionheaderSecondConditionIs = null, Expression<Func<string>> subscriptionheaderThirdCondition = null, Expression<Func<string>> subscriptionheaderThirdConditionIs = null, Expression<Func<string>> subscriptionheaderFourthCondition = null, Expression<Func<string>> subscriptionheaderFourthConditionIs = null, Expression<Func<string>> subscriptionlineFirstCondition = null, Expression<Func<string>> subscriptionlineFirstConditionIs = null, Expression<Func<string>> subscriptionlineSecondCondition = null, Expression<Func<string>> subscriptionlineSecondConditionIs = null, Expression<Func<string>> subscriptionlineThirdCondition = null, Expression<Func<string>> subscriptionlineThirdConditionIs = null, Expression<Func<string>> subscriptionlineFourthCondition = null, Expression<Func<string>> subscriptionlineFourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/purchasedocumentapproval", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionheaderFirstCondition != null)
            {
                subscription["HeaderFirstConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderFirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFirstConditionIs != null)
            {
                subscription["HeaderFirstConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderFirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderSecondCondition != null)
            {
                subscription["HeaderSecondConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderSecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderSecondConditionIs != null)
            {
                subscription["HeaderSecondConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderSecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderThirdCondition != null)
            {
                subscription["HeaderThirdConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderThirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderThirdConditionIs != null)
            {
                subscription["HeaderThirdConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderThirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFourthCondition != null)
            {
                subscription["HeaderFourthConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderFourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFourthConditionIs != null)
            {
                subscription["HeaderFourthConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderFourthConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineFirstCondition != null)
            {
                subscription["LineFirstConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionlineFirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineFirstConditionIs != null)
            {
                subscription["LineFirstConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionlineFirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineSecondCondition != null)
            {
                subscription["LineSecondConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionlineSecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineSecondConditionIs != null)
            {
                subscription["LineSecondConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionlineSecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineThirdCondition != null)
            {
                subscription["LineThirdConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionlineThirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineThirdConditionIs != null)
            {
                subscription["LineThirdConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionlineThirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineFourthCondition != null)
            {
                subscription["LineFourthConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionlineFourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineFourthConditionIs != null)
            {
                subscription["LineFourthConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionlineFourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateSalesDocumentApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionheaderFirstCondition = null, Expression<Func<string>> subscriptionheaderFirstConditionIs = null, Expression<Func<string>> subscriptionheaderSecondCondition = null, Expression<Func<string>> subscriptionheaderSecondConditionIs = null, Expression<Func<string>> subscriptionheaderThirdCondition = null, Expression<Func<string>> subscriptionheaderThirdConditionIs = null, Expression<Func<string>> subscriptionheaderFourthCondition = null, Expression<Func<string>> subscriptionheaderFourthConditionIs = null, Expression<Func<string>> subscriptionlineFirstCondition = null, Expression<Func<string>> subscriptionlineFirstConditionIs = null, Expression<Func<string>> subscriptionlineSecondCondition = null, Expression<Func<string>> subscriptionlineSecondConditionIs = null, Expression<Func<string>> subscriptionlineThirdCondition = null, Expression<Func<string>> subscriptionlineThirdConditionIs = null, Expression<Func<string>> subscriptionlineFourthCondition = null, Expression<Func<string>> subscriptionlineFourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/salesdocumentapproval", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionheaderFirstCondition != null)
            {
                subscription["HeaderFirstConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderFirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFirstConditionIs != null)
            {
                subscription["HeaderFirstConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderFirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderSecondCondition != null)
            {
                subscription["HeaderSecondConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderSecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderSecondConditionIs != null)
            {
                subscription["HeaderSecondConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderSecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderThirdCondition != null)
            {
                subscription["HeaderThirdConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderThirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderThirdConditionIs != null)
            {
                subscription["HeaderThirdConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderThirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFourthCondition != null)
            {
                subscription["HeaderFourthConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderFourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionheaderFourthConditionIs != null)
            {
                subscription["HeaderFourthConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionheaderFourthConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineFirstCondition != null)
            {
                subscription["LineFirstConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionlineFirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineFirstConditionIs != null)
            {
                subscription["LineFirstConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionlineFirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineSecondCondition != null)
            {
                subscription["LineSecondConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionlineSecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineSecondConditionIs != null)
            {
                subscription["LineSecondConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionlineSecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineThirdCondition != null)
            {
                subscription["LineThirdConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionlineThirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineThirdConditionIs != null)
            {
                subscription["LineThirdConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionlineThirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionlineFourthCondition != null)
            {
                subscription["LineFourthConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionlineFourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionlineFourthConditionIs != null)
            {
                subscription["LineFourthConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionlineFourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateVendorApprovalWebHook(Expression<Func<string>> bcenvironment, Expression<Func<string>> company, Expression<Func<string>> subscriptionfirstCondition = null, Expression<Func<string>> subscriptionfirstConditionIs = null, Expression<Func<string>> subscriptionsecondCondition = null, Expression<Func<string>> subscriptionsecondConditionIs = null, Expression<Func<string>> subscriptionthirdCondition = null, Expression<Func<string>> subscriptionthirdConditionIs = null, Expression<Func<string>> subscriptionfourthCondition = null, Expression<Func<string>> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/vendorapproval", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            if (subscriptionfirstCondition != null)
            {
                subscription["FirstConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionfirstCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfirstConditionIs != null)
            {
                subscription["FirstConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionfirstConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionsecondCondition != null)
            {
                subscription["SecondConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionsecondCondition);
                subscriptionpropCount++;
            }

            if (subscriptionsecondConditionIs != null)
            {
                subscription["SecondConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionsecondConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionthirdCondition != null)
            {
                subscription["ThirdConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionthirdCondition);
                subscriptionpropCount++;
            }

            if (subscriptionthirdConditionIs != null)
            {
                subscription["ThirdConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionthirdConditionIs);
                subscriptionpropCount++;
            }

            if (subscriptionfourthCondition != null)
            {
                subscription["FourthConditionField"] = CSharpExpressionConverter.ConvertToken(subscriptionfourthCondition);
                subscriptionpropCount++;
            }

            if (subscriptionfourthConditionIs != null)
            {
                subscription["FourthConditionFieldValue"] = CSharpExpressionConverter.ConvertToken(subscriptionfourthConditionIs);
                subscriptionpropCount++;
            }

            subscription["NotificationUrl"] = "@listCallbackUrl()";
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