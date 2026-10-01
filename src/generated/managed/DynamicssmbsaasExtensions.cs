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
        public IBodyWorkflowAction<JToken> InvokeMCP([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> configurationName, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> mcpSessionId = null, [WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/configuration/{2}/mcp", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = SourceExpressionConverter.ConvertO(mcpSessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = SourceExpressionConverter.ConvertToken(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = SourceExpressionConverter.ConvertToken(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = SourceExpressionConverter.ConvertToken(queryRequestmethod);
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
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> procedure, [WorkflowExpression] Func<object> parameters = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/procedures/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(procedure, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(parameters);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<GetAdaptiveCardV3Response> GetAdaptiveCard([WorkflowExpression] Func<string> targeturl, [WorkflowExpression] Func<targetappInput> targetapp)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/adaptivecard/forurl/{0}/forapp/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(targeturl, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(targetapp, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAdaptiveCardV3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<string> GetBlobFromNavigation([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> blobnavigationpath, [WorkflowExpression] Func<object> pathParameters = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokeget", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blobnavigationpath, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(pathParameters);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<CompanyList> GetCompanies([WorkflowExpression] Func<string> bcenvironment)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CompanyList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> GetFirstItem([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<bodytypeOfOrderInput> bodytypeOfOrder = null, [WorkflowExpression] Func<string> bodyorderResultsBy = null, [WorkflowExpression] Func<bool> bodycontinueWithEmptyResultWhenNoRecordWasFound = null, [WorkflowExpression] Func<FilterGroup[]> bodyfilter = null, [WorkflowExpression] Func<bool> readOnlyConnection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/first", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (readOnlyConnection != null)
                    callPayload.Queries["readOnlyConnection"] = SourceExpressionConverter.ConvertO(readOnlyConnection);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytypeOfOrder != null)
                {
                    body["Order"] = SourceExpressionConverter.Convert(bodytypeOfOrder);
                    bodypropCount++;
                }

                if (bodyorderResultsBy != null)
                {
                    body["OrderField"] = SourceExpressionConverter.ConvertToken(bodyorderResultsBy);
                    bodypropCount++;
                }

                if (bodycontinueWithEmptyResultWhenNoRecordWasFound != null)
                {
                    if (bodycontinueWithEmptyResultWhenNoRecordWasFound != null)
                    {
                        body["NoThrowError"] = SourceExpressionConverter.ConvertToken(bodycontinueWithEmptyResultWhenNoRecordWasFound);
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
                    body["Filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> readOnlyConnection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (readOnlyConnection != null)
                    callPayload.Queries["readOnlyConnection"] = SourceExpressionConverter.ConvertO(readOnlyConnection);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<ItemsListV3> GetItems([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> readOnlyConnection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (readOnlyConnection != null)
                    callPayload.Queries["readOnlyConnection"] = SourceExpressionConverter.ConvertO(readOnlyConnection);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsListV3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<GetUrlV3Response> GetUrl([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> page, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/pages/{2}/items/{3}/url", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(page, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetUrlV3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IWorkflowAction PatchBlobFromNavigation([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> blobnavigationpath, [WorkflowExpression] Func<object> pathParameters = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokepatch", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blobnavigationpath, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(pathParameters);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> item = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class DynamicssmbsaasTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateBusinessEventSubscription([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> businessevent, [WorkflowExpression] Func<string> company = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/businessevents/{1}/subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(businessevent, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = Convert.ToString("");
                if (company != null)
                    callPayload.Queries["company"] = SourceExpressionConverter.ConvertO(company);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateCustomerApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/customerapproval", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (subscriptionfirstCondition != null)
                {
                    subscription["FirstConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionfirstCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionfirstConditionIs != null)
                {
                    subscription["FirstConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionfirstConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionsecondCondition != null)
                {
                    subscription["SecondConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionsecondCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionsecondConditionIs != null)
                {
                    subscription["SecondConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionsecondConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionthirdCondition != null)
                {
                    subscription["ThirdConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionthirdCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionthirdConditionIs != null)
                {
                    subscription["ThirdConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionthirdConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionfourthCondition != null)
                {
                    subscription["FourthConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionfourthCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionfourthConditionIs != null)
                {
                    subscription["FourthConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionfourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalBatchApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournalbatchapproval", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (subscriptionfirstCondition != null)
                {
                    subscription["FirstConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionfirstCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionfirstConditionIs != null)
                {
                    subscription["FirstConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionfirstConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionsecondCondition != null)
                {
                    subscription["SecondConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionsecondCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionsecondConditionIs != null)
                {
                    subscription["SecondConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionsecondConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionthirdCondition != null)
                {
                    subscription["ThirdConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionthirdCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionthirdConditionIs != null)
                {
                    subscription["ThirdConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionthirdConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionfourthCondition != null)
                {
                    subscription["FourthConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionfourthCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionfourthConditionIs != null)
                {
                    subscription["FourthConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionfourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalLineApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournallineapproval", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (subscriptionfirstCondition != null)
                {
                    subscription["FirstConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionfirstCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionfirstConditionIs != null)
                {
                    subscription["FirstConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionfirstConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionsecondCondition != null)
                {
                    subscription["SecondConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionsecondCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionsecondConditionIs != null)
                {
                    subscription["SecondConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionsecondConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionthirdCondition != null)
                {
                    subscription["ThirdConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionthirdCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionthirdConditionIs != null)
                {
                    subscription["ThirdConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionthirdConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionfourthCondition != null)
                {
                    subscription["FourthConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionfourthCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionfourthConditionIs != null)
                {
                    subscription["FourthConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionfourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateItemApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/itemapproval", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (subscriptionfirstCondition != null)
                {
                    subscription["FirstConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionfirstCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionfirstConditionIs != null)
                {
                    subscription["FirstConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionfirstConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionsecondCondition != null)
                {
                    subscription["SecondConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionsecondCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionsecondConditionIs != null)
                {
                    subscription["SecondConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionsecondConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionthirdCondition != null)
                {
                    subscription["ThirdConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionthirdCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionthirdConditionIs != null)
                {
                    subscription["ThirdConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionthirdConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionfourthCondition != null)
                {
                    subscription["FourthConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionfourthCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionfourthConditionIs != null)
                {
                    subscription["FourthConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionfourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnChangedItemsSubscription([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onchangeditems/$subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnDeletedItemsSubscription([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/ondeleteditems/$subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnNewItemsSubscription([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onnewitems/$subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnUpdatedItemsSubscription([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onupdateditems/$subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ClientSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreatePurchaseDocumentApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionheaderFirstCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderSecondCondition = null, [WorkflowExpression] Func<string> subscriptionheaderSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderThirdCondition = null, [WorkflowExpression] Func<string> subscriptionheaderThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderFourthCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFourthConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFirstCondition = null, [WorkflowExpression] Func<string> subscriptionlineFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineSecondCondition = null, [WorkflowExpression] Func<string> subscriptionlineSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineThirdCondition = null, [WorkflowExpression] Func<string> subscriptionlineThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFourthCondition = null, [WorkflowExpression] Func<string> subscriptionlineFourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/purchasedocumentapproval", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (subscriptionheaderFirstCondition != null)
                {
                    subscription["HeaderFirstConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionheaderFirstCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderFirstConditionIs != null)
                {
                    subscription["HeaderFirstConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionheaderFirstConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderSecondCondition != null)
                {
                    subscription["HeaderSecondConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionheaderSecondCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderSecondConditionIs != null)
                {
                    subscription["HeaderSecondConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionheaderSecondConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderThirdCondition != null)
                {
                    subscription["HeaderThirdConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionheaderThirdCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderThirdConditionIs != null)
                {
                    subscription["HeaderThirdConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionheaderThirdConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderFourthCondition != null)
                {
                    subscription["HeaderFourthConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionheaderFourthCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderFourthConditionIs != null)
                {
                    subscription["HeaderFourthConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionheaderFourthConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionlineFirstCondition != null)
                {
                    subscription["LineFirstConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionlineFirstCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionlineFirstConditionIs != null)
                {
                    subscription["LineFirstConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionlineFirstConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionlineSecondCondition != null)
                {
                    subscription["LineSecondConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionlineSecondCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionlineSecondConditionIs != null)
                {
                    subscription["LineSecondConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionlineSecondConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionlineThirdCondition != null)
                {
                    subscription["LineThirdConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionlineThirdCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionlineThirdConditionIs != null)
                {
                    subscription["LineThirdConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionlineThirdConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionlineFourthCondition != null)
                {
                    subscription["LineFourthConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionlineFourthCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionlineFourthConditionIs != null)
                {
                    subscription["LineFourthConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionlineFourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateSalesDocumentApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionheaderFirstCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderSecondCondition = null, [WorkflowExpression] Func<string> subscriptionheaderSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderThirdCondition = null, [WorkflowExpression] Func<string> subscriptionheaderThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderFourthCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFourthConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFirstCondition = null, [WorkflowExpression] Func<string> subscriptionlineFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineSecondCondition = null, [WorkflowExpression] Func<string> subscriptionlineSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineThirdCondition = null, [WorkflowExpression] Func<string> subscriptionlineThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFourthCondition = null, [WorkflowExpression] Func<string> subscriptionlineFourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/salesdocumentapproval", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (subscriptionheaderFirstCondition != null)
                {
                    subscription["HeaderFirstConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionheaderFirstCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderFirstConditionIs != null)
                {
                    subscription["HeaderFirstConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionheaderFirstConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderSecondCondition != null)
                {
                    subscription["HeaderSecondConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionheaderSecondCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderSecondConditionIs != null)
                {
                    subscription["HeaderSecondConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionheaderSecondConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderThirdCondition != null)
                {
                    subscription["HeaderThirdConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionheaderThirdCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderThirdConditionIs != null)
                {
                    subscription["HeaderThirdConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionheaderThirdConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderFourthCondition != null)
                {
                    subscription["HeaderFourthConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionheaderFourthCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionheaderFourthConditionIs != null)
                {
                    subscription["HeaderFourthConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionheaderFourthConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionlineFirstCondition != null)
                {
                    subscription["LineFirstConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionlineFirstCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionlineFirstConditionIs != null)
                {
                    subscription["LineFirstConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionlineFirstConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionlineSecondCondition != null)
                {
                    subscription["LineSecondConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionlineSecondCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionlineSecondConditionIs != null)
                {
                    subscription["LineSecondConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionlineSecondConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionlineThirdCondition != null)
                {
                    subscription["LineThirdConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionlineThirdCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionlineThirdConditionIs != null)
                {
                    subscription["LineThirdConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionlineThirdConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionlineFourthCondition != null)
                {
                    subscription["LineFourthConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionlineFourthCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionlineFourthConditionIs != null)
                {
                    subscription["LineFourthConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionlineFourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateVendorApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/vendorapproval", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bcenvironment, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(company, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (subscriptionfirstCondition != null)
                {
                    subscription["FirstConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionfirstCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionfirstConditionIs != null)
                {
                    subscription["FirstConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionfirstConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionsecondCondition != null)
                {
                    subscription["SecondConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionsecondCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionsecondConditionIs != null)
                {
                    subscription["SecondConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionsecondConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionthirdCondition != null)
                {
                    subscription["ThirdConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionthirdCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionthirdConditionIs != null)
                {
                    subscription["ThirdConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionthirdConditionIs);
                    subscriptionpropCount++;
                }

                if (subscriptionfourthCondition != null)
                {
                    subscription["FourthConditionField"] = SourceExpressionConverter.ConvertToken(subscriptionfourthCondition);
                    subscriptionpropCount++;
                }

                if (subscriptionfourthConditionIs != null)
                {
                    subscription["FourthConditionFieldValue"] = SourceExpressionConverter.ConvertToken(subscriptionfourthConditionIs);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
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