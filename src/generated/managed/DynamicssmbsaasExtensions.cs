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
        [WorkflowExpressionFactory(nameof(__BuildInvokeMCP))]
        public IBodyWorkflowAction<JToken> InvokeMCP([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> configurationName, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> mcpSessionId = null, [WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildInvokeMCP(WorkflowValue<string> bcenvironment, WorkflowValue<string> configurationName, WorkflowValue<string> company, WorkflowValue<string> mcpSessionId = null, WorkflowValue<string> queryRequestjsonrpc = null, WorkflowValue<string> queryRequestid = null, WorkflowValue<string> queryRequestmethod = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(configurationName, nameof(configurationName), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(mcpSessionId, nameof(mcpSessionId), required: false);
            WorkflowValue.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            WorkflowValue.Validate(queryRequestid, nameof(queryRequestid), required: false);
            WorkflowValue.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/configuration/{2}/mcp", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(configurationName, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteItem))]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteItem(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteProcedure))]
        public IBodyWorkflowAction<JToken> ExecuteProcedure([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> procedure, [WorkflowExpression] Func<object> parameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExecuteProcedure(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> procedure, WorkflowValue<object> parameters = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(procedure, nameof(procedure), required: true);
            WorkflowValue.Validate(parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/procedures/{3}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(procedure, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildGetAdaptiveCard))]
        public IBodyWorkflowAction<GetAdaptiveCardV3Response> GetAdaptiveCard([WorkflowExpression] Func<string> targeturl, [WorkflowExpression] Func<targetappInput> targetapp)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAdaptiveCardV3Response> __BuildGetAdaptiveCard(WorkflowValue<string> targeturl, WorkflowValue<targetappInput> targetapp)
        {
            WorkflowValue.Validate(targeturl, nameof(targeturl), required: true);
            WorkflowValue.Validate(targetapp, nameof(targetapp), required: true);
            return new DeferredBodyAction<GetAdaptiveCardV3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/adaptivecard/forurl/{0}/forapp/{1}", ExpressionConverter.ConvertWithUrlEncoding(targeturl, 2), ExpressionConverter.ConvertWithUrlEncoding(targetapp, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAdaptiveCardV3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildGetBlobFromNavigation))]
        public IBodyWorkflowAction<string> GetBlobFromNavigation([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> blobnavigationpath, [WorkflowExpression] Func<object> pathParameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetBlobFromNavigation(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> blobnavigationpath, WorkflowValue<object> pathParameters = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(blobnavigationpath, nameof(blobnavigationpath), required: true);
            WorkflowValue.Validate(pathParameters, nameof(pathParameters), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokeget", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(blobnavigationpath, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(pathParameters);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompanies))]
        public IBodyWorkflowAction<CompanyList> GetCompanies([WorkflowExpression] Func<string> bcenvironment)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompanyList> __BuildGetCompanies(WorkflowValue<string> bcenvironment)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            return new DeferredBodyAction<CompanyList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompanyList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildGetFirstItem))]
        public IBodyWorkflowAction<JToken> GetFirstItem([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<bodytypeOfOrderInput> bodytypeOfOrder = null, [WorkflowExpression] Func<string> bodyorderResultsBy = null, [WorkflowExpression] Func<bool> bodycontinueWithEmptyResultWhenNoRecordWasFound = null, [WorkflowExpression] Func<FilterGroup[]> bodyfilter = null, [WorkflowExpression] Func<bool> readOnlyConnection = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFirstItem(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<bodytypeOfOrderInput> bodytypeOfOrder = null, WorkflowValue<string> bodyorderResultsBy = null, WorkflowValue<bool> bodycontinueWithEmptyResultWhenNoRecordWasFound = null, WorkflowValue<FilterGroup[]> bodyfilter = null, WorkflowValue<bool> readOnlyConnection = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(bodytypeOfOrder, nameof(bodytypeOfOrder), required: false);
            WorkflowValue.Validate(bodyorderResultsBy, nameof(bodyorderResultsBy), required: false);
            WorkflowValue.Validate(bodycontinueWithEmptyResultWhenNoRecordWasFound, nameof(bodycontinueWithEmptyResultWhenNoRecordWasFound), required: false);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(readOnlyConnection, nameof(readOnlyConnection), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/first", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildGetItem))]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> readOnlyConnection = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItem(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> id, WorkflowValue<bool> readOnlyConnection = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(readOnlyConnection, nameof(readOnlyConnection), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (readOnlyConnection != null)
                    callPayload.Queries["readOnlyConnection"] = ExpressionConverter.Convert(readOnlyConnection);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildGetItems))]
        public IBodyWorkflowAction<ItemsListV3> GetItems([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> readOnlyConnection = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsListV3> __BuildGetItems(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> filter = null, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<int> skip = null, WorkflowValue<bool> readOnlyConnection = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(readOnlyConnection, nameof(readOnlyConnection), required: false);
            return new DeferredBodyAction<ItemsListV3>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildGetUrl))]
        public IBodyWorkflowAction<GetUrlV3Response> GetUrl([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> page, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUrlV3Response> __BuildGetUrl(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> page, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(page, nameof(page), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetUrlV3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/pages/{2}/items/{3}/url", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(page, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUrlV3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildPatchBlobFromNavigation))]
        public IWorkflowAction PatchBlobFromNavigation([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> blobnavigationpath, [WorkflowExpression] Func<object> pathParameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPatchBlobFromNavigation(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> blobnavigationpath, WorkflowValue<object> pathParameters = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(blobnavigationpath, nameof(blobnavigationpath), required: true);
            WorkflowValue.Validate(pathParameters, nameof(pathParameters), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/blobnavigationpaths/{3}/invokepatch", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(blobnavigationpath, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(pathParameters);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildPatchItem))]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPatchItem(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> id, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items/{4}", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [WorkflowExpressionFactory(nameof(__BuildPostItem))]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPostItem(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/items", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class DynamicssmbsaasTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildCreateBusinessEventSubscription))]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateBusinessEventSubscription([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> businessevent, [WorkflowExpression] Func<string> company = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> __BuildCreateBusinessEventSubscription(WorkflowValue<string> bcenvironment, WorkflowValue<string> businessevent, WorkflowValue<string> company = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(businessevent, nameof(businessevent), required: true);
            WorkflowValue.Validate(company, nameof(company), required: false);
            return new DeferredBodyTrigger<ClientSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/businessevents/{1}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(businessevent, 2));
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateCustomerApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateCustomerApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateCustomerApprovalWebHook(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> subscriptionfirstCondition = null, WorkflowValue<string> subscriptionfirstConditionIs = null, WorkflowValue<string> subscriptionsecondCondition = null, WorkflowValue<string> subscriptionsecondConditionIs = null, WorkflowValue<string> subscriptionthirdCondition = null, WorkflowValue<string> subscriptionthirdConditionIs = null, WorkflowValue<string> subscriptionfourthCondition = null, WorkflowValue<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            WorkflowValue.Validate(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            WorkflowValue.Validate(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            WorkflowValue.Validate(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            WorkflowValue.Validate(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            WorkflowValue.Validate(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            WorkflowValue.Validate(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            WorkflowValue.Validate(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/customerapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateGeneralJournalBatchApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalBatchApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateGeneralJournalBatchApprovalWebHook(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> subscriptionfirstCondition = null, WorkflowValue<string> subscriptionfirstConditionIs = null, WorkflowValue<string> subscriptionsecondCondition = null, WorkflowValue<string> subscriptionsecondConditionIs = null, WorkflowValue<string> subscriptionthirdCondition = null, WorkflowValue<string> subscriptionthirdConditionIs = null, WorkflowValue<string> subscriptionfourthCondition = null, WorkflowValue<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            WorkflowValue.Validate(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            WorkflowValue.Validate(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            WorkflowValue.Validate(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            WorkflowValue.Validate(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            WorkflowValue.Validate(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            WorkflowValue.Validate(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            WorkflowValue.Validate(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournalbatchapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateGeneralJournalLineApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalLineApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateGeneralJournalLineApprovalWebHook(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> subscriptionfirstCondition = null, WorkflowValue<string> subscriptionfirstConditionIs = null, WorkflowValue<string> subscriptionsecondCondition = null, WorkflowValue<string> subscriptionsecondConditionIs = null, WorkflowValue<string> subscriptionthirdCondition = null, WorkflowValue<string> subscriptionthirdConditionIs = null, WorkflowValue<string> subscriptionfourthCondition = null, WorkflowValue<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            WorkflowValue.Validate(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            WorkflowValue.Validate(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            WorkflowValue.Validate(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            WorkflowValue.Validate(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            WorkflowValue.Validate(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            WorkflowValue.Validate(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            WorkflowValue.Validate(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/generaljournallineapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateItemApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateItemApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateItemApprovalWebHook(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> subscriptionfirstCondition = null, WorkflowValue<string> subscriptionfirstConditionIs = null, WorkflowValue<string> subscriptionsecondCondition = null, WorkflowValue<string> subscriptionsecondConditionIs = null, WorkflowValue<string> subscriptionthirdCondition = null, WorkflowValue<string> subscriptionthirdConditionIs = null, WorkflowValue<string> subscriptionfourthCondition = null, WorkflowValue<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            WorkflowValue.Validate(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            WorkflowValue.Validate(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            WorkflowValue.Validate(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            WorkflowValue.Validate(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            WorkflowValue.Validate(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            WorkflowValue.Validate(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            WorkflowValue.Validate(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/itemapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateOnChangedItemsSubscription))]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnChangedItemsSubscription([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> __BuildCreateOnChangedItemsSubscription(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onchangeditems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateOnDeletedItemsSubscription))]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnDeletedItemsSubscription([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> __BuildCreateOnDeletedItemsSubscription(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/ondeleteditems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateOnNewItemsSubscription))]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnNewItemsSubscription([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> __BuildCreateOnNewItemsSubscription(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onnewitems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateOnUpdatedItemsSubscription))]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnUpdatedItemsSubscription([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> __BuildCreateOnUpdatedItemsSubscription(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> dataset, WorkflowValue<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            return new DeferredBodyTrigger<ClientSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/datasets/{2}/tables/{3}/onupdateditems/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2), ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreatePurchaseDocumentApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreatePurchaseDocumentApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionheaderFirstCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderSecondCondition = null, [WorkflowExpression] Func<string> subscriptionheaderSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderThirdCondition = null, [WorkflowExpression] Func<string> subscriptionheaderThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderFourthCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFourthConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFirstCondition = null, [WorkflowExpression] Func<string> subscriptionlineFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineSecondCondition = null, [WorkflowExpression] Func<string> subscriptionlineSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineThirdCondition = null, [WorkflowExpression] Func<string> subscriptionlineThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFourthCondition = null, [WorkflowExpression] Func<string> subscriptionlineFourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreatePurchaseDocumentApprovalWebHook(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> subscriptionheaderFirstCondition = null, WorkflowValue<string> subscriptionheaderFirstConditionIs = null, WorkflowValue<string> subscriptionheaderSecondCondition = null, WorkflowValue<string> subscriptionheaderSecondConditionIs = null, WorkflowValue<string> subscriptionheaderThirdCondition = null, WorkflowValue<string> subscriptionheaderThirdConditionIs = null, WorkflowValue<string> subscriptionheaderFourthCondition = null, WorkflowValue<string> subscriptionheaderFourthConditionIs = null, WorkflowValue<string> subscriptionlineFirstCondition = null, WorkflowValue<string> subscriptionlineFirstConditionIs = null, WorkflowValue<string> subscriptionlineSecondCondition = null, WorkflowValue<string> subscriptionlineSecondConditionIs = null, WorkflowValue<string> subscriptionlineThirdCondition = null, WorkflowValue<string> subscriptionlineThirdConditionIs = null, WorkflowValue<string> subscriptionlineFourthCondition = null, WorkflowValue<string> subscriptionlineFourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(subscriptionheaderFirstCondition, nameof(subscriptionheaderFirstCondition), required: false);
            WorkflowValue.Validate(subscriptionheaderFirstConditionIs, nameof(subscriptionheaderFirstConditionIs), required: false);
            WorkflowValue.Validate(subscriptionheaderSecondCondition, nameof(subscriptionheaderSecondCondition), required: false);
            WorkflowValue.Validate(subscriptionheaderSecondConditionIs, nameof(subscriptionheaderSecondConditionIs), required: false);
            WorkflowValue.Validate(subscriptionheaderThirdCondition, nameof(subscriptionheaderThirdCondition), required: false);
            WorkflowValue.Validate(subscriptionheaderThirdConditionIs, nameof(subscriptionheaderThirdConditionIs), required: false);
            WorkflowValue.Validate(subscriptionheaderFourthCondition, nameof(subscriptionheaderFourthCondition), required: false);
            WorkflowValue.Validate(subscriptionheaderFourthConditionIs, nameof(subscriptionheaderFourthConditionIs), required: false);
            WorkflowValue.Validate(subscriptionlineFirstCondition, nameof(subscriptionlineFirstCondition), required: false);
            WorkflowValue.Validate(subscriptionlineFirstConditionIs, nameof(subscriptionlineFirstConditionIs), required: false);
            WorkflowValue.Validate(subscriptionlineSecondCondition, nameof(subscriptionlineSecondCondition), required: false);
            WorkflowValue.Validate(subscriptionlineSecondConditionIs, nameof(subscriptionlineSecondConditionIs), required: false);
            WorkflowValue.Validate(subscriptionlineThirdCondition, nameof(subscriptionlineThirdCondition), required: false);
            WorkflowValue.Validate(subscriptionlineThirdConditionIs, nameof(subscriptionlineThirdConditionIs), required: false);
            WorkflowValue.Validate(subscriptionlineFourthCondition, nameof(subscriptionlineFourthCondition), required: false);
            WorkflowValue.Validate(subscriptionlineFourthConditionIs, nameof(subscriptionlineFourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/purchasedocumentapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateSalesDocumentApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateSalesDocumentApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionheaderFirstCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderSecondCondition = null, [WorkflowExpression] Func<string> subscriptionheaderSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderThirdCondition = null, [WorkflowExpression] Func<string> subscriptionheaderThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionheaderFourthCondition = null, [WorkflowExpression] Func<string> subscriptionheaderFourthConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFirstCondition = null, [WorkflowExpression] Func<string> subscriptionlineFirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineSecondCondition = null, [WorkflowExpression] Func<string> subscriptionlineSecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineThirdCondition = null, [WorkflowExpression] Func<string> subscriptionlineThirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionlineFourthCondition = null, [WorkflowExpression] Func<string> subscriptionlineFourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateSalesDocumentApprovalWebHook(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> subscriptionheaderFirstCondition = null, WorkflowValue<string> subscriptionheaderFirstConditionIs = null, WorkflowValue<string> subscriptionheaderSecondCondition = null, WorkflowValue<string> subscriptionheaderSecondConditionIs = null, WorkflowValue<string> subscriptionheaderThirdCondition = null, WorkflowValue<string> subscriptionheaderThirdConditionIs = null, WorkflowValue<string> subscriptionheaderFourthCondition = null, WorkflowValue<string> subscriptionheaderFourthConditionIs = null, WorkflowValue<string> subscriptionlineFirstCondition = null, WorkflowValue<string> subscriptionlineFirstConditionIs = null, WorkflowValue<string> subscriptionlineSecondCondition = null, WorkflowValue<string> subscriptionlineSecondConditionIs = null, WorkflowValue<string> subscriptionlineThirdCondition = null, WorkflowValue<string> subscriptionlineThirdConditionIs = null, WorkflowValue<string> subscriptionlineFourthCondition = null, WorkflowValue<string> subscriptionlineFourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(subscriptionheaderFirstCondition, nameof(subscriptionheaderFirstCondition), required: false);
            WorkflowValue.Validate(subscriptionheaderFirstConditionIs, nameof(subscriptionheaderFirstConditionIs), required: false);
            WorkflowValue.Validate(subscriptionheaderSecondCondition, nameof(subscriptionheaderSecondCondition), required: false);
            WorkflowValue.Validate(subscriptionheaderSecondConditionIs, nameof(subscriptionheaderSecondConditionIs), required: false);
            WorkflowValue.Validate(subscriptionheaderThirdCondition, nameof(subscriptionheaderThirdCondition), required: false);
            WorkflowValue.Validate(subscriptionheaderThirdConditionIs, nameof(subscriptionheaderThirdConditionIs), required: false);
            WorkflowValue.Validate(subscriptionheaderFourthCondition, nameof(subscriptionheaderFourthCondition), required: false);
            WorkflowValue.Validate(subscriptionheaderFourthConditionIs, nameof(subscriptionheaderFourthConditionIs), required: false);
            WorkflowValue.Validate(subscriptionlineFirstCondition, nameof(subscriptionlineFirstCondition), required: false);
            WorkflowValue.Validate(subscriptionlineFirstConditionIs, nameof(subscriptionlineFirstConditionIs), required: false);
            WorkflowValue.Validate(subscriptionlineSecondCondition, nameof(subscriptionlineSecondCondition), required: false);
            WorkflowValue.Validate(subscriptionlineSecondConditionIs, nameof(subscriptionlineSecondConditionIs), required: false);
            WorkflowValue.Validate(subscriptionlineThirdCondition, nameof(subscriptionlineThirdCondition), required: false);
            WorkflowValue.Validate(subscriptionlineThirdConditionIs, nameof(subscriptionlineThirdConditionIs), required: false);
            WorkflowValue.Validate(subscriptionlineFourthCondition, nameof(subscriptionlineFourthCondition), required: false);
            WorkflowValue.Validate(subscriptionlineFourthConditionIs, nameof(subscriptionlineFourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/salesdocumentapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateVendorApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateVendorApprovalWebHook([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> subscriptionfirstCondition = null, [WorkflowExpression] Func<string> subscriptionfirstConditionIs = null, [WorkflowExpression] Func<string> subscriptionsecondCondition = null, [WorkflowExpression] Func<string> subscriptionsecondConditionIs = null, [WorkflowExpression] Func<string> subscriptionthirdCondition = null, [WorkflowExpression] Func<string> subscriptionthirdConditionIs = null, [WorkflowExpression] Func<string> subscriptionfourthCondition = null, [WorkflowExpression] Func<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateVendorApprovalWebHook(WorkflowValue<string> bcenvironment, WorkflowValue<string> company, WorkflowValue<string> subscriptionfirstCondition = null, WorkflowValue<string> subscriptionfirstConditionIs = null, WorkflowValue<string> subscriptionsecondCondition = null, WorkflowValue<string> subscriptionsecondConditionIs = null, WorkflowValue<string> subscriptionthirdCondition = null, WorkflowValue<string> subscriptionthirdConditionIs = null, WorkflowValue<string> subscriptionfourthCondition = null, WorkflowValue<string> subscriptionfourthConditionIs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            WorkflowValue.Validate(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            WorkflowValue.Validate(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            WorkflowValue.Validate(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            WorkflowValue.Validate(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            WorkflowValue.Validate(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            WorkflowValue.Validate(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            WorkflowValue.Validate(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
            return new DeferredBodyTrigger<WebHookSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/bcenvironments/{0}/companies/{1}/webhook/v1/vendorapproval", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 2), ExpressionConverter.ConvertWithUrlEncoding(company, 2));
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
            }, triggerName);
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
