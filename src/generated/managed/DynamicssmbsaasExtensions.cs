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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildInvokeMCP(WorkflowExpression<string> bcenvironment, WorkflowExpression<string> configurationName, WorkflowExpression<string> company, WorkflowExpression<string> mcpSessionId = null, WorkflowExpression<string> queryRequestjsonrpc = null, WorkflowExpression<string> queryRequestid = null, WorkflowExpression<string> queryRequestmethod = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(configurationName, nameof(configurationName), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(mcpSessionId, nameof(mcpSessionId), required: false);
            WorkflowExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            WorkflowExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            WorkflowExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteItem(WorkflowExpression<string> bcenvironment, WorkflowExpression<string> company, WorkflowExpression<string> dataset, WorkflowExpression<string> table, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExecuteProcedure(WorkflowExpression<string> bcenvironment, WorkflowExpression<string> company, WorkflowExpression<string> dataset, WorkflowExpression<string> procedure, WorkflowExpression<object> parameters = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(procedure, nameof(procedure), required: true);
            WorkflowExpression.Validate(parameters, nameof(parameters), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAdaptiveCardV3Response> __BuildGetAdaptiveCard(WorkflowExpression<string> targeturl, WorkflowExpression<targetappInput> targetapp)
        {
            WorkflowExpression.Validate(targeturl, nameof(targeturl), required: true);
            WorkflowExpression.Validate(targetapp, nameof(targetapp), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetBlobFromNavigation(WorkflowExpression<string> bcenvironment, WorkflowExpression<string> company, WorkflowExpression<string> dataset, WorkflowExpression<string> blobnavigationpath, WorkflowExpression<object> pathParameters = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(blobnavigationpath, nameof(blobnavigationpath), required: true);
            WorkflowExpression.Validate(pathParameters, nameof(pathParameters), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompanyList> __BuildGetCompanies(WorkflowExpression<string> bcenvironment)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFirstItem(WorkflowExpression<string> bcenvironment, WorkflowExpression<string> company, WorkflowExpression<string> dataset, WorkflowExpression<string> table, WorkflowExpression<bodytypeOfOrderInput> bodytypeOfOrder = null, WorkflowExpression<string> bodyorderResultsBy = null, WorkflowExpression<bool> bodycontinueWithEmptyResultWhenNoRecordWasFound = null, WorkflowExpression<FilterGroup[]> bodyfilter = null, WorkflowExpression<bool> readOnlyConnection = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(bodytypeOfOrder, nameof(bodytypeOfOrder), required: false);
            WorkflowExpression.Validate(bodyorderResultsBy, nameof(bodyorderResultsBy), required: false);
            WorkflowExpression.Validate(bodycontinueWithEmptyResultWhenNoRecordWasFound, nameof(bodycontinueWithEmptyResultWhenNoRecordWasFound), required: false);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(readOnlyConnection, nameof(readOnlyConnection), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItem(WorkflowExpression<string> bcenvironment, WorkflowExpression<string> company, WorkflowExpression<string> dataset, WorkflowExpression<string> table, WorkflowExpression<string> id, WorkflowExpression<bool> readOnlyConnection = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(readOnlyConnection, nameof(readOnlyConnection), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsListV3> __BuildGetItems(WorkflowExpression<string> bcenvironment, WorkflowExpression<string> company, WorkflowExpression<string> dataset, WorkflowExpression<string> table, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<bool> readOnlyConnection = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(readOnlyConnection, nameof(readOnlyConnection), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUrlV3Response> __BuildGetUrl(WorkflowExpression<string> bcenvironment, WorkflowExpression<string> company, WorkflowExpression<string> page, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPatchBlobFromNavigation(WorkflowExpression<string> bcenvironment, WorkflowExpression<string> company, WorkflowExpression<string> dataset, WorkflowExpression<string> blobnavigationpath, WorkflowExpression<object> pathParameters = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(blobnavigationpath, nameof(blobnavigationpath), required: true);
            WorkflowExpression.Validate(pathParameters, nameof(pathParameters), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPatchItem(WorkflowExpression<string> bcenvironment, WorkflowExpression<string> company, WorkflowExpression<string> dataset, WorkflowExpression<string> table, WorkflowExpression<string> id, WorkflowExpression<object> item = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicssmbsaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPostItem(WorkflowExpression<string> bcenvironment, WorkflowExpression<string> company, WorkflowExpression<string> dataset, WorkflowExpression<string> table, WorkflowExpression<object> item = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: false);
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
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateBusinessEventSubscription([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> businessevent,[WorkflowExpression] Func<string> company = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> __BuildCreateBusinessEventSubscription(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> businessevent,WorkflowExpression<string> company = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(businessevent, nameof(businessevent), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: false);
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

                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateCustomerApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateCustomerApprovalWebHook([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> company,[WorkflowExpression] Func<string> subscriptionfirstCondition = null,[WorkflowExpression] Func<string> subscriptionfirstConditionIs = null,[WorkflowExpression] Func<string> subscriptionsecondCondition = null,[WorkflowExpression] Func<string> subscriptionsecondConditionIs = null,[WorkflowExpression] Func<string> subscriptionthirdCondition = null,[WorkflowExpression] Func<string> subscriptionthirdConditionIs = null,[WorkflowExpression] Func<string> subscriptionfourthCondition = null,[WorkflowExpression] Func<string> subscriptionfourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateCustomerApprovalWebHook(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> company,WorkflowExpression<string> subscriptionfirstCondition = null,WorkflowExpression<string> subscriptionfirstConditionIs = null,WorkflowExpression<string> subscriptionsecondCondition = null,WorkflowExpression<string> subscriptionsecondConditionIs = null,WorkflowExpression<string> subscriptionthirdCondition = null,WorkflowExpression<string> subscriptionthirdConditionIs = null,WorkflowExpression<string> subscriptionfourthCondition = null,WorkflowExpression<string> subscriptionfourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            WorkflowExpression.Validate(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            WorkflowExpression.Validate(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            WorkflowExpression.Validate(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            WorkflowExpression.Validate(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
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

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateGeneralJournalBatchApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalBatchApprovalWebHook([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> company,[WorkflowExpression] Func<string> subscriptionfirstCondition = null,[WorkflowExpression] Func<string> subscriptionfirstConditionIs = null,[WorkflowExpression] Func<string> subscriptionsecondCondition = null,[WorkflowExpression] Func<string> subscriptionsecondConditionIs = null,[WorkflowExpression] Func<string> subscriptionthirdCondition = null,[WorkflowExpression] Func<string> subscriptionthirdConditionIs = null,[WorkflowExpression] Func<string> subscriptionfourthCondition = null,[WorkflowExpression] Func<string> subscriptionfourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateGeneralJournalBatchApprovalWebHook(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> company,WorkflowExpression<string> subscriptionfirstCondition = null,WorkflowExpression<string> subscriptionfirstConditionIs = null,WorkflowExpression<string> subscriptionsecondCondition = null,WorkflowExpression<string> subscriptionsecondConditionIs = null,WorkflowExpression<string> subscriptionthirdCondition = null,WorkflowExpression<string> subscriptionthirdConditionIs = null,WorkflowExpression<string> subscriptionfourthCondition = null,WorkflowExpression<string> subscriptionfourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            WorkflowExpression.Validate(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            WorkflowExpression.Validate(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            WorkflowExpression.Validate(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            WorkflowExpression.Validate(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
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

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateGeneralJournalLineApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateGeneralJournalLineApprovalWebHook([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> company,[WorkflowExpression] Func<string> subscriptionfirstCondition = null,[WorkflowExpression] Func<string> subscriptionfirstConditionIs = null,[WorkflowExpression] Func<string> subscriptionsecondCondition = null,[WorkflowExpression] Func<string> subscriptionsecondConditionIs = null,[WorkflowExpression] Func<string> subscriptionthirdCondition = null,[WorkflowExpression] Func<string> subscriptionthirdConditionIs = null,[WorkflowExpression] Func<string> subscriptionfourthCondition = null,[WorkflowExpression] Func<string> subscriptionfourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateGeneralJournalLineApprovalWebHook(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> company,WorkflowExpression<string> subscriptionfirstCondition = null,WorkflowExpression<string> subscriptionfirstConditionIs = null,WorkflowExpression<string> subscriptionsecondCondition = null,WorkflowExpression<string> subscriptionsecondConditionIs = null,WorkflowExpression<string> subscriptionthirdCondition = null,WorkflowExpression<string> subscriptionthirdConditionIs = null,WorkflowExpression<string> subscriptionfourthCondition = null,WorkflowExpression<string> subscriptionfourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            WorkflowExpression.Validate(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            WorkflowExpression.Validate(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            WorkflowExpression.Validate(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            WorkflowExpression.Validate(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
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

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateItemApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateItemApprovalWebHook([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> company,[WorkflowExpression] Func<string> subscriptionfirstCondition = null,[WorkflowExpression] Func<string> subscriptionfirstConditionIs = null,[WorkflowExpression] Func<string> subscriptionsecondCondition = null,[WorkflowExpression] Func<string> subscriptionsecondConditionIs = null,[WorkflowExpression] Func<string> subscriptionthirdCondition = null,[WorkflowExpression] Func<string> subscriptionthirdConditionIs = null,[WorkflowExpression] Func<string> subscriptionfourthCondition = null,[WorkflowExpression] Func<string> subscriptionfourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateItemApprovalWebHook(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> company,WorkflowExpression<string> subscriptionfirstCondition = null,WorkflowExpression<string> subscriptionfirstConditionIs = null,WorkflowExpression<string> subscriptionsecondCondition = null,WorkflowExpression<string> subscriptionsecondConditionIs = null,WorkflowExpression<string> subscriptionthirdCondition = null,WorkflowExpression<string> subscriptionthirdConditionIs = null,WorkflowExpression<string> subscriptionfourthCondition = null,WorkflowExpression<string> subscriptionfourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            WorkflowExpression.Validate(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            WorkflowExpression.Validate(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            WorkflowExpression.Validate(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            WorkflowExpression.Validate(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
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

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateOnChangedItemsSubscription))]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnChangedItemsSubscription([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> company,[WorkflowExpression] Func<string> dataset,[WorkflowExpression] Func<string> table,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> __BuildCreateOnChangedItemsSubscription(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> company,WorkflowExpression<string> dataset,WorkflowExpression<string> table,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
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

                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateOnDeletedItemsSubscription))]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnDeletedItemsSubscription([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> company,[WorkflowExpression] Func<string> dataset,[WorkflowExpression] Func<string> table,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> __BuildCreateOnDeletedItemsSubscription(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> company,WorkflowExpression<string> dataset,WorkflowExpression<string> table,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
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

                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateOnNewItemsSubscription))]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnNewItemsSubscription([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> company,[WorkflowExpression] Func<string> dataset,[WorkflowExpression] Func<string> table,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> __BuildCreateOnNewItemsSubscription(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> company,WorkflowExpression<string> dataset,WorkflowExpression<string> table,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
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

                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateOnUpdatedItemsSubscription))]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> CreateOnUpdatedItemsSubscription([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> company,[WorkflowExpression] Func<string> dataset,[WorkflowExpression] Func<string> table,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ClientSubscriptionResponse> __BuildCreateOnUpdatedItemsSubscription(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> company,WorkflowExpression<string> dataset,WorkflowExpression<string> table,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
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

                return new ApiConnectionTrigger<ClientSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreatePurchaseDocumentApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreatePurchaseDocumentApprovalWebHook([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> company,[WorkflowExpression] Func<string> subscriptionheaderFirstCondition = null,[WorkflowExpression] Func<string> subscriptionheaderFirstConditionIs = null,[WorkflowExpression] Func<string> subscriptionheaderSecondCondition = null,[WorkflowExpression] Func<string> subscriptionheaderSecondConditionIs = null,[WorkflowExpression] Func<string> subscriptionheaderThirdCondition = null,[WorkflowExpression] Func<string> subscriptionheaderThirdConditionIs = null,[WorkflowExpression] Func<string> subscriptionheaderFourthCondition = null,[WorkflowExpression] Func<string> subscriptionheaderFourthConditionIs = null,[WorkflowExpression] Func<string> subscriptionlineFirstCondition = null,[WorkflowExpression] Func<string> subscriptionlineFirstConditionIs = null,[WorkflowExpression] Func<string> subscriptionlineSecondCondition = null,[WorkflowExpression] Func<string> subscriptionlineSecondConditionIs = null,[WorkflowExpression] Func<string> subscriptionlineThirdCondition = null,[WorkflowExpression] Func<string> subscriptionlineThirdConditionIs = null,[WorkflowExpression] Func<string> subscriptionlineFourthCondition = null,[WorkflowExpression] Func<string> subscriptionlineFourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreatePurchaseDocumentApprovalWebHook(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> company,WorkflowExpression<string> subscriptionheaderFirstCondition = null,WorkflowExpression<string> subscriptionheaderFirstConditionIs = null,WorkflowExpression<string> subscriptionheaderSecondCondition = null,WorkflowExpression<string> subscriptionheaderSecondConditionIs = null,WorkflowExpression<string> subscriptionheaderThirdCondition = null,WorkflowExpression<string> subscriptionheaderThirdConditionIs = null,WorkflowExpression<string> subscriptionheaderFourthCondition = null,WorkflowExpression<string> subscriptionheaderFourthConditionIs = null,WorkflowExpression<string> subscriptionlineFirstCondition = null,WorkflowExpression<string> subscriptionlineFirstConditionIs = null,WorkflowExpression<string> subscriptionlineSecondCondition = null,WorkflowExpression<string> subscriptionlineSecondConditionIs = null,WorkflowExpression<string> subscriptionlineThirdCondition = null,WorkflowExpression<string> subscriptionlineThirdConditionIs = null,WorkflowExpression<string> subscriptionlineFourthCondition = null,WorkflowExpression<string> subscriptionlineFourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(subscriptionheaderFirstCondition, nameof(subscriptionheaderFirstCondition), required: false);
            WorkflowExpression.Validate(subscriptionheaderFirstConditionIs, nameof(subscriptionheaderFirstConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionheaderSecondCondition, nameof(subscriptionheaderSecondCondition), required: false);
            WorkflowExpression.Validate(subscriptionheaderSecondConditionIs, nameof(subscriptionheaderSecondConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionheaderThirdCondition, nameof(subscriptionheaderThirdCondition), required: false);
            WorkflowExpression.Validate(subscriptionheaderThirdConditionIs, nameof(subscriptionheaderThirdConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionheaderFourthCondition, nameof(subscriptionheaderFourthCondition), required: false);
            WorkflowExpression.Validate(subscriptionheaderFourthConditionIs, nameof(subscriptionheaderFourthConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionlineFirstCondition, nameof(subscriptionlineFirstCondition), required: false);
            WorkflowExpression.Validate(subscriptionlineFirstConditionIs, nameof(subscriptionlineFirstConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionlineSecondCondition, nameof(subscriptionlineSecondCondition), required: false);
            WorkflowExpression.Validate(subscriptionlineSecondConditionIs, nameof(subscriptionlineSecondConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionlineThirdCondition, nameof(subscriptionlineThirdCondition), required: false);
            WorkflowExpression.Validate(subscriptionlineThirdConditionIs, nameof(subscriptionlineThirdConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionlineFourthCondition, nameof(subscriptionlineFourthCondition), required: false);
            WorkflowExpression.Validate(subscriptionlineFourthConditionIs, nameof(subscriptionlineFourthConditionIs), required: false);
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

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateSalesDocumentApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateSalesDocumentApprovalWebHook([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> company,[WorkflowExpression] Func<string> subscriptionheaderFirstCondition = null,[WorkflowExpression] Func<string> subscriptionheaderFirstConditionIs = null,[WorkflowExpression] Func<string> subscriptionheaderSecondCondition = null,[WorkflowExpression] Func<string> subscriptionheaderSecondConditionIs = null,[WorkflowExpression] Func<string> subscriptionheaderThirdCondition = null,[WorkflowExpression] Func<string> subscriptionheaderThirdConditionIs = null,[WorkflowExpression] Func<string> subscriptionheaderFourthCondition = null,[WorkflowExpression] Func<string> subscriptionheaderFourthConditionIs = null,[WorkflowExpression] Func<string> subscriptionlineFirstCondition = null,[WorkflowExpression] Func<string> subscriptionlineFirstConditionIs = null,[WorkflowExpression] Func<string> subscriptionlineSecondCondition = null,[WorkflowExpression] Func<string> subscriptionlineSecondConditionIs = null,[WorkflowExpression] Func<string> subscriptionlineThirdCondition = null,[WorkflowExpression] Func<string> subscriptionlineThirdConditionIs = null,[WorkflowExpression] Func<string> subscriptionlineFourthCondition = null,[WorkflowExpression] Func<string> subscriptionlineFourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateSalesDocumentApprovalWebHook(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> company,WorkflowExpression<string> subscriptionheaderFirstCondition = null,WorkflowExpression<string> subscriptionheaderFirstConditionIs = null,WorkflowExpression<string> subscriptionheaderSecondCondition = null,WorkflowExpression<string> subscriptionheaderSecondConditionIs = null,WorkflowExpression<string> subscriptionheaderThirdCondition = null,WorkflowExpression<string> subscriptionheaderThirdConditionIs = null,WorkflowExpression<string> subscriptionheaderFourthCondition = null,WorkflowExpression<string> subscriptionheaderFourthConditionIs = null,WorkflowExpression<string> subscriptionlineFirstCondition = null,WorkflowExpression<string> subscriptionlineFirstConditionIs = null,WorkflowExpression<string> subscriptionlineSecondCondition = null,WorkflowExpression<string> subscriptionlineSecondConditionIs = null,WorkflowExpression<string> subscriptionlineThirdCondition = null,WorkflowExpression<string> subscriptionlineThirdConditionIs = null,WorkflowExpression<string> subscriptionlineFourthCondition = null,WorkflowExpression<string> subscriptionlineFourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(subscriptionheaderFirstCondition, nameof(subscriptionheaderFirstCondition), required: false);
            WorkflowExpression.Validate(subscriptionheaderFirstConditionIs, nameof(subscriptionheaderFirstConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionheaderSecondCondition, nameof(subscriptionheaderSecondCondition), required: false);
            WorkflowExpression.Validate(subscriptionheaderSecondConditionIs, nameof(subscriptionheaderSecondConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionheaderThirdCondition, nameof(subscriptionheaderThirdCondition), required: false);
            WorkflowExpression.Validate(subscriptionheaderThirdConditionIs, nameof(subscriptionheaderThirdConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionheaderFourthCondition, nameof(subscriptionheaderFourthCondition), required: false);
            WorkflowExpression.Validate(subscriptionheaderFourthConditionIs, nameof(subscriptionheaderFourthConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionlineFirstCondition, nameof(subscriptionlineFirstCondition), required: false);
            WorkflowExpression.Validate(subscriptionlineFirstConditionIs, nameof(subscriptionlineFirstConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionlineSecondCondition, nameof(subscriptionlineSecondCondition), required: false);
            WorkflowExpression.Validate(subscriptionlineSecondConditionIs, nameof(subscriptionlineSecondConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionlineThirdCondition, nameof(subscriptionlineThirdCondition), required: false);
            WorkflowExpression.Validate(subscriptionlineThirdConditionIs, nameof(subscriptionlineThirdConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionlineFourthCondition, nameof(subscriptionlineFourthCondition), required: false);
            WorkflowExpression.Validate(subscriptionlineFourthConditionIs, nameof(subscriptionlineFourthConditionIs), required: false);
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

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateVendorApprovalWebHook))]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> CreateVendorApprovalWebHook([WorkflowExpression] Func<string> bcenvironment,[WorkflowExpression] Func<string> company,[WorkflowExpression] Func<string> subscriptionfirstCondition = null,[WorkflowExpression] Func<string> subscriptionfirstConditionIs = null,[WorkflowExpression] Func<string> subscriptionsecondCondition = null,[WorkflowExpression] Func<string> subscriptionsecondConditionIs = null,[WorkflowExpression] Func<string> subscriptionthirdCondition = null,[WorkflowExpression] Func<string> subscriptionthirdConditionIs = null,[WorkflowExpression] Func<string> subscriptionfourthCondition = null,[WorkflowExpression] Func<string> subscriptionfourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookSubscriptionResponse> __BuildCreateVendorApprovalWebHook(WorkflowExpression<string> bcenvironment,WorkflowExpression<string> company,WorkflowExpression<string> subscriptionfirstCondition = null,WorkflowExpression<string> subscriptionfirstConditionIs = null,WorkflowExpression<string> subscriptionsecondCondition = null,WorkflowExpression<string> subscriptionsecondConditionIs = null,WorkflowExpression<string> subscriptionthirdCondition = null,WorkflowExpression<string> subscriptionthirdConditionIs = null,WorkflowExpression<string> subscriptionfourthCondition = null,WorkflowExpression<string> subscriptionfourthConditionIs = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(subscriptionfirstCondition, nameof(subscriptionfirstCondition), required: false);
            WorkflowExpression.Validate(subscriptionfirstConditionIs, nameof(subscriptionfirstConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionsecondCondition, nameof(subscriptionsecondCondition), required: false);
            WorkflowExpression.Validate(subscriptionsecondConditionIs, nameof(subscriptionsecondConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionthirdCondition, nameof(subscriptionthirdCondition), required: false);
            WorkflowExpression.Validate(subscriptionthirdConditionIs, nameof(subscriptionthirdConditionIs), required: false);
            WorkflowExpression.Validate(subscriptionfourthCondition, nameof(subscriptionfourthCondition), required: false);
            WorkflowExpression.Validate(subscriptionfourthConditionIs, nameof(subscriptionfourthConditionIs), required: false);
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

                return new ApiConnectionTrigger<WebHookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
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