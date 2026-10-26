//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Salesforce
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SalesforceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<TablesList, ApiConnectionActionConfiguration> GetTables()
        {
            return new DeferredBodyAction<TablesList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetItemByExternalId(Expression<Func<string>> table, Expression<Func<string>> externalIdField, Expression<Func<string>> externalId)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_externalIdField = WorkflowExpression.Compile(externalIdField, nameof(externalIdField), required: true);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/tables/{0}/externalIdFields/{1}/{2}", __workflow_table.WithUrlEncoding(2), __workflow_externalIdField.WithUrlEncoding(2), __workflow_externalId.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> GetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/tables/{0}/items", __workflow_table.WithUrlEncoding(2)));
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
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> GetItemsTableAccount(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/tables/account/items";
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
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> GetItemsTableUser(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/tables/user/items";
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
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> GetItemsTableCase(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/tables/case/items";
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
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> GetItemsTableOpportunity(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/tables/opportunity/items";
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
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> GetItemsTableProduct2(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/tables/product2/items";
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
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> GetItemsTableContact(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/tables/contact/items";
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
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ExecuteSoqlQuery(Expression<Func<ExecuteSoqlQueryInput>> queryParameters)
        {
            var __workflow_queryParameters = WorkflowExpression.Compile(queryParameters, nameof(queryParameters), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/soql/executesoqlquery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryParameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<GetAllJobsResponse, ApiConnectionActionConfiguration> GetAllJobs(Expression<Func<concurrenyModeInput>> concurrenyMode = null, Expression<Func<bool>> isPkChunkingEnabled = null, Expression<Func<jobTypeInput>> jobType = null, Expression<Func<string>> queryLocator = null)
        {
            var __workflow_concurrenyMode = WorkflowExpression.Compile(concurrenyMode, nameof(concurrenyMode), required: false);
            var __workflow_isPkChunkingEnabled = WorkflowExpression.Compile(isPkChunkingEnabled, nameof(isPkChunkingEnabled), required: false);
            var __workflow_jobType = WorkflowExpression.Compile(jobType, nameof(jobType), required: false);
            var __workflow_queryLocator = WorkflowExpression.Compile(queryLocator, nameof(queryLocator), required: false);
            return new DeferredBodyAction<GetAllJobsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codeless/jobs/ingest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_concurrenyMode != null)
                    callPayload.Queries["concurrenyMode"] = ExpressionConverter.Convert(__workflow_concurrenyMode);
                if (__workflow_isPkChunkingEnabled != null)
                    callPayload.Queries["isPkChunkingEnabled"] = ExpressionConverter.Convert(__workflow_isPkChunkingEnabled);
                callPayload.Queries["jobType"] = Convert.ToString("V2Ingest");
                if (__workflow_jobType != null)
                    callPayload.Queries["jobType"] = ExpressionConverter.Convert(__workflow_jobType);
                if (__workflow_queryLocator != null)
                    callPayload.Queries["queryLocator"] = ExpressionConverter.Convert(__workflow_queryLocator);
                return new ApiConnectionAction<GetAllJobsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UploadJobData(Expression<Func<string>> jobId, Expression<Func<string>> body)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/jobs/ingest/{0}/batches", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<CheckJobResponse, ApiConnectionActionConfiguration> GetJobInfo(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<CheckJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/jobs/ingest/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CheckJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JobInfo, ApiConnectionActionConfiguration> CloseJob(Expression<Func<string>> jobId, Expression<Func<CloseJobInput>> body)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JobInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/jobs/ingest/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JobInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteJob(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/jobs/ingest/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetJobRecordResults(Expression<Func<string>> jobId, Expression<Func<resultTypeInput>> resultType)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_resultType = WorkflowExpression.Compile(resultType, nameof(resultType), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/jobs/ingest/{0}/results", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resultType"] = ExpressionConverter.Convert(__workflow_resultType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<SOSLSearchQueryResponse, ApiConnectionActionConfiguration> ExecuteSOSLQuery(Expression<Func<string>> q)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            return new DeferredBodyAction<SOSLSearchQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codeless/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<SOSLSearchQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
        {
            var __workflow_uri = WorkflowExpression.Compile(uri, nameof(uri), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_customHeader1 = WorkflowExpression.Compile(customHeader1, nameof(customHeader1), required: false);
            var __workflow_customHeader2 = WorkflowExpression.Compile(customHeader2, nameof(customHeader2), required: false);
            var __workflow_customHeader3 = WorkflowExpression.Compile(customHeader3, nameof(customHeader3), required: false);
            var __workflow_customHeader4 = WorkflowExpression.Compile(customHeader4, nameof(customHeader4), required: false);
            var __workflow_customHeader5 = WorkflowExpression.Compile(customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codeless/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = ExpressionConverter.Convert(__workflow_uri);
                callPayload.Headers["Method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["ContentType"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(__workflow_customHeader1);
                if (__workflow_customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(__workflow_customHeader2);
                if (__workflow_customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(__workflow_customHeader3);
                if (__workflow_customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(__workflow_customHeader4);
                if (__workflow_customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(__workflow_customHeader5);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<MCPQueryResponse, ApiConnectionActionConfiguration> McpSalesforceManagement(Expression<Func<McpSalesforceManagementInput>> queryRequest = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mcp/SalesforceManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction<MCPQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<CreateJobResponse, ApiConnectionActionConfiguration> CreateJob(Expression<Func<CreateJobV2Input>> parameters)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<CreateJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bulk/createjob";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<CreateJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<string>> select = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/datasets/default/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> PatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item, Expression<Func<string>> select = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/datasets/default/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> PatchItemByExternalId(Expression<Func<string>> table, Expression<Func<string>> externalIdField, Expression<Func<string>> externalId, Expression<Func<object>> item)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_externalIdField = WorkflowExpression.Compile(externalIdField, nameof(externalIdField), required: true);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/datasets/default/tables/{0}/externalIdFields/{1}/{2}", __workflow_table.WithUrlEncoding(2), __workflow_externalIdField.WithUrlEncoding(2), __workflow_externalId.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> PostItem(Expression<Func<string>> table, Expression<Func<object>> item)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/datasets/default/tables/{0}/items", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class SalesforceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList, ApiConnectionTriggerConfiguration> OnNewItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyTrigger<ItemsList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/tables/{0}/onnewitems", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemsList, ApiConnectionTriggerConfiguration> OnUpdatedItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyTrigger<ItemsList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/tables/{0}/onupdateditems", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
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

    public class ExecuteSoqlQueryInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SOQLQuery { get; set; }

        [JsonProperty("parameters")]
        public JToken QueryParameters { get; set; }
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
        public string CreatedById { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("externalIdFieldName")]
        public string ExternalIdFieldName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobInfoColumnDelimiterType
    {
        BACKQUOTE,
        CARET,
        COMMA,
        PIPE,
        SEMICOLON,
        TAB
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobInfoConcurrencyModeType
    {
        Parallel,
        Serial
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobInfoJobTypeType
    {
        BigObjectInjest,
        Classic,
        V2Injest
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobInfoLineEndingType
    {
        LF,
        CRLF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobInfoStateType
    {
        Open,
        UploadComplete,
        Aborted,
        JobComplete,
        Failed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum concurrenyModeInput
    {
        BACKQUOTE,
        CARET,
        COMMA,
        PIPE,
        SEMICOLON,
        TAB
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string CreatedById { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("externalFieldName")]
        public string ExternalFieldName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CheckJobResponseColumnDelimiterType
    {
        BACKQUOTE,
        CARET,
        COMMA,
        PIPE,
        SEMICOLON,
        TAB
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CheckJobResponseConcurrencyModeType
    {
        Parallel,
        Serial
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CheckJobResponseJobTypeType
    {
        BigObjectInjest,
        Classic,
        V2Injest
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CheckJobResponseLineEndingType
    {
        LF,
        CRLF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CheckJobResponseStateType
    {
        Open,
        UploadComplete,
        Aborted,
        JobComplete,
        Failed
    }

    public class CloseJobInput
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public CloseJobInputStateType State { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CloseJobInputStateType
    {
        UploadComplete,
        Aborted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class McpSalesforceManagementInput
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
        public string ExternalIdFieldName { get; set; }

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

    public class CreateJobV2Input
    {
        [JsonProperty("object", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectEntity { get; set; }

        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateJobV2InputOperationType Operation { get; set; }

        [JsonProperty("columnDelimiter")]
        public string ColumnDelimiter { get; set; }

        [JsonProperty("externalIdFieldName")]
        public string ExternalIdFieldName { get; set; }

        [JsonProperty("lineEnding")]
        public string LineEnding { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateJobV2InputOperationType
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