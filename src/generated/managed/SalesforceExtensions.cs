//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Salesforce
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SalesforceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<TablesList> GetTables()
        {
            var apiCallPath = "/datasets/default/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> GetItemByExternalId(Expression<Func<string>> table, Expression<Func<string>> externalIdField, Expression<Func<string>> externalId)
        {
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_externalIdField = externalIdField == null ? null : WorkflowExpression.Compile(externalIdField);
            WorkflowExpression.Validate(__workflow_externalIdField, nameof(externalIdField), required: true);
            var __workflow_externalId = externalId == null ? null : WorkflowExpression.Compile(externalId);
            WorkflowExpression.Validate(__workflow_externalId, nameof(externalId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/externalIdFields/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_externalIdField, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_externalId, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
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
        public IBodyWorkflowAction<ItemsList> GetItemsTableAccount(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
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
        public IBodyWorkflowAction<ItemsList> GetItemsTableUser(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
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
        public IBodyWorkflowAction<ItemsList> GetItemsTableCase(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
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
        public IBodyWorkflowAction<ItemsList> GetItemsTableOpportunity(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
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
        public IBodyWorkflowAction<ItemsList> GetItemsTableProduct2(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
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
        public IBodyWorkflowAction<ItemsList> GetItemsTableContact(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
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
        public IWorkflowAction DeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> ExecuteSoqlQuery(Expression<Func<string>> queryParameterssOQLQuery)
        {
            var __workflow_queryParameterssOQLQuery = queryParameterssOQLQuery == null ? null : WorkflowExpression.Compile(queryParameterssOQLQuery);
            WorkflowExpression.Validate(__workflow_queryParameterssOQLQuery, nameof(queryParameterssOQLQuery), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/soql/executesoqlquery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var queryParameters = new JObject();
                var queryParameterspropCount = 0;
                queryParameterspropCount++;
                queryParameters["query"] = ExpressionConverter.ConvertO(__workflow_queryParameterssOQLQuery);
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

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<GetAllJobsResponse> GetAllJobs(Expression<Func<concurrenyModeInput>> concurrenyMode = null, Expression<Func<bool>> isPkChunkingEnabled = null, Expression<Func<jobTypeInput>> jobType = null, Expression<Func<string>> queryLocator = null)
        {
            var __workflow_concurrenyMode = concurrenyMode == null ? null : WorkflowExpression.Compile(concurrenyMode);
            WorkflowExpression.Validate(__workflow_concurrenyMode, nameof(concurrenyMode), required: false);
            var __workflow_isPkChunkingEnabled = isPkChunkingEnabled == null ? null : WorkflowExpression.Compile(isPkChunkingEnabled);
            WorkflowExpression.Validate(__workflow_isPkChunkingEnabled, nameof(isPkChunkingEnabled), required: false);
            var __workflow_jobType = jobType == null ? null : WorkflowExpression.Compile(jobType);
            WorkflowExpression.Validate(__workflow_jobType, nameof(jobType), required: false);
            var __workflow_queryLocator = queryLocator == null ? null : WorkflowExpression.Compile(queryLocator);
            WorkflowExpression.Validate(__workflow_queryLocator, nameof(queryLocator), required: false);
            return new DeferredBodyAction<GetAllJobsResponse>(() =>
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
        public IWorkflowAction UploadJobData(Expression<Func<string>> jobId, Expression<Func<string>> body = null)
        {
            var __workflow_jobId = jobId == null ? null : WorkflowExpression.Compile(jobId);
            WorkflowExpression.Validate(__workflow_jobId, nameof(jobId), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}/batches", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jobId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<CheckJobResponse> GetJobInfo(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = jobId == null ? null : WorkflowExpression.Compile(jobId);
            WorkflowExpression.Validate(__workflow_jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<CheckJobResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CheckJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JobInfo> CloseJob(Expression<Func<string>> jobId, Expression<Func<bodystateInput>> bodystate)
        {
            var __workflow_jobId = jobId == null ? null : WorkflowExpression.Compile(jobId);
            WorkflowExpression.Validate(__workflow_jobId, nameof(jobId), required: true);
            var __workflow_bodystate = bodystate == null ? null : WorkflowExpression.Compile(bodystate);
            WorkflowExpression.Validate(__workflow_bodystate, nameof(bodystate), required: true);
            return new DeferredBodyAction<JobInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jobId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JobInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IWorkflowAction DeleteJob(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = jobId == null ? null : WorkflowExpression.Compile(jobId);
            WorkflowExpression.Validate(__workflow_jobId, nameof(jobId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jobId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<string> GetJobRecordResults(Expression<Func<string>> jobId, Expression<Func<resultTypeInput>> resultType)
        {
            var __workflow_jobId = jobId == null ? null : WorkflowExpression.Compile(jobId);
            WorkflowExpression.Validate(__workflow_jobId, nameof(jobId), required: true);
            var __workflow_resultType = resultType == null ? null : WorkflowExpression.Compile(resultType);
            WorkflowExpression.Validate(__workflow_resultType, nameof(resultType), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}/results", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resultType"] = ExpressionConverter.Convert(__workflow_resultType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<SOSLSearchQueryResponse> ExecuteSOSLQuery(Expression<Func<string>> q)
        {
            var __workflow_q = q == null ? null : WorkflowExpression.Compile(q);
            WorkflowExpression.Validate(__workflow_q, nameof(q), required: true);
            return new DeferredBodyAction<SOSLSearchQueryResponse>(() =>
            {
                var apiCallPath = "/codeless/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<SOSLSearchQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
        {
            var __workflow_uri = uri == null ? null : WorkflowExpression.Compile(uri);
            WorkflowExpression.Validate(__workflow_uri, nameof(uri), required: true);
            var __workflow_method = method == null ? null : WorkflowExpression.Compile(method);
            WorkflowExpression.Validate(__workflow_method, nameof(method), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            var __workflow_customHeader1 = customHeader1 == null ? null : WorkflowExpression.Compile(customHeader1);
            WorkflowExpression.Validate(__workflow_customHeader1, nameof(customHeader1), required: false);
            var __workflow_customHeader2 = customHeader2 == null ? null : WorkflowExpression.Compile(customHeader2);
            WorkflowExpression.Validate(__workflow_customHeader2, nameof(customHeader2), required: false);
            var __workflow_customHeader3 = customHeader3 == null ? null : WorkflowExpression.Compile(customHeader3);
            WorkflowExpression.Validate(__workflow_customHeader3, nameof(customHeader3), required: false);
            var __workflow_customHeader4 = customHeader4 == null ? null : WorkflowExpression.Compile(customHeader4);
            WorkflowExpression.Validate(__workflow_customHeader4, nameof(customHeader4), required: false);
            var __workflow_customHeader5 = customHeader5 == null ? null : WorkflowExpression.Compile(customHeader5);
            WorkflowExpression.Validate(__workflow_customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<MCPQueryResponse> McpSalesforceManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequestjsonrpc = queryRequestjsonrpc == null ? null : WorkflowExpression.Compile(queryRequestjsonrpc);
            WorkflowExpression.Validate(__workflow_queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = queryRequestid == null ? null : WorkflowExpression.Compile(queryRequestid);
            WorkflowExpression.Validate(__workflow_queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = queryRequestmethod == null ? null : WorkflowExpression.Compile(queryRequestmethod);
            WorkflowExpression.Validate(__workflow_queryRequestmethod, nameof(queryRequestmethod), required: false);
            var __workflow_sessionId = sessionId == null ? null : WorkflowExpression.Compile(sessionId);
            WorkflowExpression.Validate(__workflow_sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse>(() =>
            {
                var apiCallPath = "/mcp/SalesforceManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
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

                return new ApiConnectionAction<MCPQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<CreateJobResponse> CreateJob(Expression<Func<string>> parametersobject, Expression<Func<parametersoperationInput>> parametersoperation, Expression<Func<string>> parameterscolumnDelimiter = null, Expression<Func<string>> parametersexternalIDFieldName = null, Expression<Func<string>> parameterslineEnding = null, Expression<Func<string>> parameterscontentType = null)
        {
            var __workflow_parametersobject = parametersobject == null ? null : WorkflowExpression.Compile(parametersobject);
            WorkflowExpression.Validate(__workflow_parametersobject, nameof(parametersobject), required: true);
            var __workflow_parametersoperation = parametersoperation == null ? null : WorkflowExpression.Compile(parametersoperation);
            WorkflowExpression.Validate(__workflow_parametersoperation, nameof(parametersoperation), required: true);
            var __workflow_parameterscolumnDelimiter = parameterscolumnDelimiter == null ? null : WorkflowExpression.Compile(parameterscolumnDelimiter);
            WorkflowExpression.Validate(__workflow_parameterscolumnDelimiter, nameof(parameterscolumnDelimiter), required: false);
            var __workflow_parametersexternalIDFieldName = parametersexternalIDFieldName == null ? null : WorkflowExpression.Compile(parametersexternalIDFieldName);
            WorkflowExpression.Validate(__workflow_parametersexternalIDFieldName, nameof(parametersexternalIDFieldName), required: false);
            var __workflow_parameterslineEnding = parameterslineEnding == null ? null : WorkflowExpression.Compile(parameterslineEnding);
            WorkflowExpression.Validate(__workflow_parameterslineEnding, nameof(parameterslineEnding), required: false);
            var __workflow_parameterscontentType = parameterscontentType == null ? null : WorkflowExpression.Compile(parameterscontentType);
            WorkflowExpression.Validate(__workflow_parameterscontentType, nameof(parameterscontentType), required: false);
            return new DeferredBodyAction<CreateJobResponse>(() =>
            {
                var apiCallPath = "/bulk/createjob";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["object"] = ExpressionConverter.ConvertO(__workflow_parametersobject);
                parameterspropCount++;
                parameters["operation"] = ExpressionConverter.ConvertO(__workflow_parametersoperation);
                if (__workflow_parameterscolumnDelimiter != null)
                {
                    parameters["columnDelimiter"] = ExpressionConverter.ConvertO(__workflow_parameterscolumnDelimiter);
                    parameterspropCount++;
                }

                if (__workflow_parametersexternalIDFieldName != null)
                {
                    parameters["externalIdFieldName"] = ExpressionConverter.ConvertO(__workflow_parametersexternalIDFieldName);
                    parameterspropCount++;
                }

                if (__workflow_parameterslineEnding != null)
                {
                    parameters["lineEnding"] = ExpressionConverter.ConvertO(__workflow_parameterslineEnding);
                    parameterspropCount++;
                }

                if (__workflow_parameterscontentType != null)
                {
                    parameters["contentType"] = ExpressionConverter.ConvertO(__workflow_parameterscontentType);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction<CreateJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<string>> select = null)
        {
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> PatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item = null, Expression<Func<string>> select = null)
        {
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> PatchItemByExternalId(Expression<Func<string>> table, Expression<Func<string>> externalIdField, Expression<Func<string>> externalId, Expression<Func<object>> item = null)
        {
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_externalIdField = externalIdField == null ? null : WorkflowExpression.Compile(externalIdField);
            WorkflowExpression.Validate(__workflow_externalIdField, nameof(externalIdField), required: true);
            var __workflow_externalId = externalId == null ? null : WorkflowExpression.Compile(externalId);
            WorkflowExpression.Validate(__workflow_externalId, nameof(externalId), required: true);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/default/tables/{0}/externalIdFields/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_externalIdField, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_externalId, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> PostItem(Expression<Func<string>> table, Expression<Func<object>> item = null)
        {
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/default/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class SalesforceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> OnNewItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
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

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystateInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
