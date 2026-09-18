//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Salesforce
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SalesforceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<TablesList> GetTables()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TablesList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> GetItemByExternalId([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> externalIdField, [WorkflowExpression] Func<string> externalId)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(externalIdField, nameof(externalIdField), required: true);
            SourceExpression.Validate(externalId, nameof(externalId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/externalIdFields/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalIdField, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalId, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
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
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableAccount([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/tables/account/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableUser([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/tables/user/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableCase([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/tables/case/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableOpportunity([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/tables/opportunity/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableProduct2([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/tables/product2/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableContact([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/tables/contact/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> ExecuteSoqlQuery([WorkflowExpression] Func<string> queryParameterssOQLQuery)
        {
            SourceExpression.Validate(queryParameterssOQLQuery, nameof(queryParameterssOQLQuery), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/soql/executesoqlquery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var queryParameters = new JObject();
                var queryParameterspropCount = 0;
                queryParameterspropCount++;
                queryParameters["query"] = SourceExpressionConverter.ConvertToken(queryParameterssOQLQuery);
                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (parametersObjectpropCount > 0)
                {
                    queryParameters["parameters"] = parametersObject;
                    queryParameterspropCount++;
                }

                if (queryParameterspropCount > 0)
                {
                    callPayload.Body = queryParameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<GetAllJobsResponse> GetAllJobs([WorkflowExpression] Func<concurrenyModeInput> concurrenyMode = null, [WorkflowExpression] Func<bool> isPkChunkingEnabled = null, [WorkflowExpression] Func<jobTypeInput> jobType = null, [WorkflowExpression] Func<string> queryLocator = null)
        {
            SourceExpression.Validate(concurrenyMode, nameof(concurrenyMode), required: false);
            SourceExpression.Validate(isPkChunkingEnabled, nameof(isPkChunkingEnabled), required: false);
            SourceExpression.Validate(jobType, nameof(jobType), required: false);
            SourceExpression.Validate(queryLocator, nameof(queryLocator), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codeless/jobs/ingest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (concurrenyMode != null)
                    callPayload.Queries["concurrenyMode"] = SourceExpressionConverter.Convert(concurrenyMode);
                if (isPkChunkingEnabled != null)
                    callPayload.Queries["isPkChunkingEnabled"] = SourceExpressionConverter.ConvertO(isPkChunkingEnabled);
                callPayload.Queries["jobType"] = Convert.ToString("V2Ingest");
                if (jobType != null)
                    callPayload.Queries["jobType"] = SourceExpressionConverter.Convert(jobType);
                if (queryLocator != null)
                    callPayload.Queries["queryLocator"] = SourceExpressionConverter.ConvertO(queryLocator);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllJobsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IWorkflowAction UploadJobData([WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}/batches", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<CheckJobResponse> GetJobInfo([WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CheckJobResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JobInfo> CloseJob([WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<bodystateInput> bodystate)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["state"] = SourceExpressionConverter.Convert(bodystate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JobInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IWorkflowAction DeleteJob([WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<string> GetJobRecordResults([WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<resultTypeInput> resultType)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            SourceExpression.Validate(resultType, nameof(resultType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}/results", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resultType"] = SourceExpressionConverter.Convert(resultType);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<SOSLSearchQueryResponse> ExecuteSOSLQuery([WorkflowExpression] Func<string> q)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codeless/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<SOSLSearchQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> customHeader1 = null, [WorkflowExpression] Func<string> customHeader2 = null, [WorkflowExpression] Func<string> customHeader3 = null, [WorkflowExpression] Func<string> customHeader4 = null, [WorkflowExpression] Func<string> customHeader5 = null)
        {
            SourceExpression.Validate(uri, nameof(uri), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(customHeader1, nameof(customHeader1), required: false);
            SourceExpression.Validate(customHeader2, nameof(customHeader2), required: false);
            SourceExpression.Validate(customHeader3, nameof(customHeader3), required: false);
            SourceExpression.Validate(customHeader4, nameof(customHeader4), required: false);
            SourceExpression.Validate(customHeader5, nameof(customHeader5), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codeless/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = SourceExpressionConverter.ConvertO(uri);
                callPayload.Headers["Method"] = SourceExpressionConverter.Convert(method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["ContentType"] = SourceExpressionConverter.ConvertO(contentType);
                if (customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = SourceExpressionConverter.ConvertO(customHeader1);
                if (customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = SourceExpressionConverter.ConvertO(customHeader2);
                if (customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = SourceExpressionConverter.ConvertO(customHeader3);
                if (customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = SourceExpressionConverter.ConvertO(customHeader4);
                if (customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = SourceExpressionConverter.ConvertO(customHeader5);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<MCPQueryResponse> McpSalesforceManagement([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            SourceExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            SourceExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            SourceExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mcp/SalesforceManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
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

            return new ApiConnectionAction<MCPQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<CreateJobResponse> CreateJob([WorkflowExpression] Func<string> parametersobject, [WorkflowExpression] Func<parametersoperationInput> parametersoperation, [WorkflowExpression] Func<string> parameterscolumnDelimiter = null, [WorkflowExpression] Func<string> parametersexternalIDFieldName = null, [WorkflowExpression] Func<string> parameterslineEnding = null, [WorkflowExpression] Func<string> parameterscontentType = null)
        {
            SourceExpression.Validate(parametersobject, nameof(parametersobject), required: true);
            SourceExpression.Validate(parametersoperation, nameof(parametersoperation), required: true);
            SourceExpression.Validate(parameterscolumnDelimiter, nameof(parameterscolumnDelimiter), required: false);
            SourceExpression.Validate(parametersexternalIDFieldName, nameof(parametersexternalIDFieldName), required: false);
            SourceExpression.Validate(parameterslineEnding, nameof(parameterslineEnding), required: false);
            SourceExpression.Validate(parameterscontentType, nameof(parameterscontentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bulk/createjob";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["object"] = SourceExpressionConverter.ConvertToken(parametersobject);
                parameterspropCount++;
                parameters["operation"] = SourceExpressionConverter.Convert(parametersoperation);
                if (parameterscolumnDelimiter != null)
                {
                    parameters["columnDelimiter"] = SourceExpressionConverter.ConvertToken(parameterscolumnDelimiter);
                    parameterspropCount++;
                }

                if (parametersexternalIDFieldName != null)
                {
                    parameters["externalIdFieldName"] = SourceExpressionConverter.ConvertToken(parametersexternalIDFieldName);
                    parameterspropCount++;
                }

                if (parameterslineEnding != null)
                {
                    parameters["lineEnding"] = SourceExpressionConverter.ConvertToken(parameterslineEnding);
                    parameterspropCount++;
                }

                if (parameterscontentType != null)
                {
                    parameters["contentType"] = SourceExpressionConverter.ConvertToken(parameterscontentType);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateJobResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/default/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/datasets/default/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> PatchItemByExternalId([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> externalIdField, [WorkflowExpression] Func<string> externalId, [WorkflowExpression] Func<object> item = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(externalIdField, nameof(externalIdField), required: true);
            SourceExpression.Validate(externalId, nameof(externalId), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/default/tables/{0}/externalIdFields/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalIdField, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalId, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/default/tables/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class SalesforceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> OnNewItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/onnewitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemsList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/onupdateditems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemsList>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class TablesList
    {
        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public JToken DynamicProperties { get; set; }
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class GetAllJobsResponse
    {
        [JsonProperty("done")]
        public bool Done { get; set; }

        [JsonProperty("records")]
        public JobInfo[] Records { get; set; }

        [JsonProperty("nextRecordUrl")]
        public string NextRecoredURL { get; set; }
    }

    public class JobInfo
    {
        [JsonProperty("apiVersion")]
        public double APIVersion { get; set; }

        [JsonProperty("columnDelimiter")]
        public JobInfoColumnDelimiterType ColumnDelimiter { get; set; }

        [JsonProperty("concurrencyMode")]
        public JobInfoConcurrencyModeType ConcurrencyMode { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentUrl")]
        public string ContentURL { get; set; }

        [JsonProperty("createdById")]
        public string CreatedByID { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("externalIdFieldName")]
        public string ExternalIDFieldName { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("jobType")]
        public JobInfoJobTypeType JobType { get; set; }

        [JsonProperty("lineEnding")]
        public JobInfoLineEndingType LineEnding { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("operation")]
        public JobInfoOperationType Operation { get; set; }

        [JsonProperty("state")]
        public JobInfoStateType State { get; set; }

        [JsonProperty("systemModstamp")]
        public string SystemModStamp { get; set; }
    }

    public enum JobInfoColumnDelimiterType
    {
        BACKQUOTE,
        CARET,
        COMMA,
        PIPE,
        SEMICOLON,
        TAB
    }

    public enum JobInfoConcurrencyModeType
    {
        Parallel,
        Serial
    }

    public enum JobInfoJobTypeType
    {
        BigObjectInjest,
        Classic,
        V2Injest
    }

    public enum JobInfoLineEndingType
    {
        LF,
        CRLF
    }

    public enum JobInfoOperationType
    {
        [EnumMember(Value = "insert")]
        Insert,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "update")]
        Update,
        [EnumMember(Value = "upsert")]
        Upsert
    }

    public enum JobInfoStateType
    {
        Open,
        UploadComplete,
        Aborted,
        JobComplete,
        Failed
    }

    public enum concurrenyModeInput
    {
        BACKQUOTE,
        CARET,
        COMMA,
        PIPE,
        SEMICOLON,
        TAB
    }

    public enum jobTypeInput
    {
        BigObjectInjest,
        Classic,
        V2Ingest
    }

    public class CheckJobResponse
    {
        [JsonProperty("apexProcessingTime")]
        public double APEXProcessingTime { get; set; }

        [JsonProperty("apiActiveProcessingTime")]
        public double APIActiveProcessingTime { get; set; }

        [JsonProperty("apiVersion")]
        public double APIVersion { get; set; }

        [JsonProperty("columnDelimiter")]
        public CheckJobResponseColumnDelimiterType ColumnDelimiter { get; set; }

        [JsonProperty("concurrencyMode")]
        public CheckJobResponseConcurrencyModeType ConcurrencyMode { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentUrl")]
        public string ContentURL { get; set; }

        [JsonProperty("createdById")]
        public string CreatedByID { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("externalFieldName")]
        public string ExternalFieldName { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("jobType")]
        public CheckJobResponseJobTypeType JobType { get; set; }

        [JsonProperty("lineEnding")]
        public CheckJobResponseLineEndingType LineEnding { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("operation")]
        public CheckJobResponseOperationType Operation { get; set; }

        [JsonProperty("retries")]
        public double Retries { get; set; }

        [JsonProperty("state")]
        public CheckJobResponseStateType State { get; set; }

        [JsonProperty("systemModStamp")]
        public string SystemModStamp { get; set; }

        [JsonProperty("totalProcessingTime")]
        public double TotalProcessingTime { get; set; }
    }

    public enum CheckJobResponseColumnDelimiterType
    {
        BACKQUOTE,
        CARET,
        COMMA,
        PIPE,
        SEMICOLON,
        TAB
    }

    public enum CheckJobResponseConcurrencyModeType
    {
        Parallel,
        Serial
    }

    public enum CheckJobResponseJobTypeType
    {
        BigObjectInjest,
        Classic,
        V2Injest
    }

    public enum CheckJobResponseLineEndingType
    {
        LF,
        CRLF
    }

    public enum CheckJobResponseOperationType
    {
        [EnumMember(Value = "insert")]
        Insert,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "update")]
        Update,
        [EnumMember(Value = "upsert")]
        Upsert
    }

    public enum CheckJobResponseStateType
    {
        Open,
        UploadComplete,
        Aborted,
        JobComplete,
        Failed
    }

    public enum bodystateInput
    {
        UploadComplete,
        Aborted
    }

    public enum resultTypeInput
    {
        Successful,
        Failed,
        Unprocessed
    }

    public class SOSLSearchQueryResponse
    {
        [JsonProperty("searchRecords")]
        public SearchRecordObject[] SearchRecords { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class SearchRecordObject
    {
        [JsonProperty("attributes")]
        public SearchRecordObjectAttributesType Attributes { get; set; }
        public string Id { get; set; }
    }

    public class SearchRecordObjectAttributesType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public enum methodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public class MCPQueryResponse
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

    public class CreateJobResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("operation")]
        public string Operation { get; set; }

        [JsonProperty("columnDelimiter")]
        public string ColumnDelimiter { get; set; }

        [JsonProperty("externalIdFieldName")]
        public string ExternalIDFieldName { get; set; }

        [JsonProperty("lineEnding")]
        public string LineEnding { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("apiVersion")]
        public double APIVersion { get; set; }

        [JsonProperty("concurrencyMode")]
        public string ConcurrencyMode { get; set; }

        [JsonProperty("contentUrl")]
        public string ContentUrl { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("jobType")]
        public string JobType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("systemModstamp")]
        public string SystemModstamp { get; set; }
    }

    public enum parametersoperationInput
    {
        [EnumMember(Value = "insert")]
        Insert,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "update")]
        Update,
        [EnumMember(Value = "upsert")]
        Upsert
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Salesforce;

    public partial class WorkflowManagedActions
    {
        public SalesforceActions Salesforce(string connectionId) => new SalesforceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SalesforceTriggers Salesforce(string connectionId) => new SalesforceTriggers(connectionId);
    }
}