//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Salesforce
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
        [WorkflowExpressionFactory(nameof(__BuildGetItemByExternalId))]
        public IBodyWorkflowAction<JToken> GetItemByExternalId([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> externalIdField, [WorkflowExpression] Func<string> externalId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItemByExternalId(WorkflowExpression<string> table, WorkflowExpression<string> externalIdField, WorkflowExpression<string> externalId)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(externalIdField, nameof(externalIdField), required: true);
            WorkflowExpression.Validate(externalId, nameof(externalId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/externalIdFields/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(externalIdField, 2), ExpressionConverter.ConvertWithUrlEncoding(externalId, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetItems))]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItems(WorkflowExpression<string> table, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemsTableAccount))]
        public IBodyWorkflowAction<ItemsList> GetItemsTableAccount([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItemsTableAccount(WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = "/datasets/default/tables/account/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemsTableUser))]
        public IBodyWorkflowAction<ItemsList> GetItemsTableUser([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItemsTableUser(WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = "/datasets/default/tables/user/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemsTableCase))]
        public IBodyWorkflowAction<ItemsList> GetItemsTableCase([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItemsTableCase(WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = "/datasets/default/tables/case/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemsTableOpportunity))]
        public IBodyWorkflowAction<ItemsList> GetItemsTableOpportunity([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItemsTableOpportunity(WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = "/datasets/default/tables/opportunity/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemsTableProduct2))]
        public IBodyWorkflowAction<ItemsList> GetItemsTableProduct2([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItemsTableProduct2(WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = "/datasets/default/tables/product2/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemsTableContact))]
        public IBodyWorkflowAction<ItemsList> GetItemsTableContact([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItemsTableContact(WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = "/datasets/default/tables/contact/items";
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
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteItem))]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteItem(WorkflowExpression<string> table, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteSoqlQuery))]
        public IBodyWorkflowAction<JToken> ExecuteSoqlQuery([WorkflowExpression] Func<string> queryParameterssOQLQuery)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExecuteSoqlQuery(WorkflowExpression<string> queryParameterssOQLQuery)
        {
            WorkflowExpression.Validate(queryParameterssOQLQuery, nameof(queryParameterssOQLQuery), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/soql/executesoqlquery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var queryParameters = new JObject();
                var queryParameterspropCount = 0;
                queryParameterspropCount++;
                queryParameters["query"] = ExpressionConverter.ConvertO(queryParameterssOQLQuery);
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
        [WorkflowExpressionFactory(nameof(__BuildGetAllJobs))]
        public IBodyWorkflowAction<GetAllJobsResponse> GetAllJobs([WorkflowExpression] Func<concurrenyModeInput> concurrenyMode = null, [WorkflowExpression] Func<bool> isPkChunkingEnabled = null, [WorkflowExpression] Func<jobTypeInput> jobType = null, [WorkflowExpression] Func<string> queryLocator = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllJobsResponse> __BuildGetAllJobs(WorkflowExpression<concurrenyModeInput> concurrenyMode = null, WorkflowExpression<bool> isPkChunkingEnabled = null, WorkflowExpression<jobTypeInput> jobType = null, WorkflowExpression<string> queryLocator = null)
        {
            WorkflowExpression.Validate(concurrenyMode, nameof(concurrenyMode), required: false);
            WorkflowExpression.Validate(isPkChunkingEnabled, nameof(isPkChunkingEnabled), required: false);
            WorkflowExpression.Validate(jobType, nameof(jobType), required: false);
            WorkflowExpression.Validate(queryLocator, nameof(queryLocator), required: false);
            return new DeferredBodyAction<GetAllJobsResponse>(() =>
            {
                var apiCallPath = "/codeless/jobs/ingest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (concurrenyMode != null)
                    callPayload.Queries["concurrenyMode"] = ExpressionConverter.Convert(concurrenyMode);
                if (isPkChunkingEnabled != null)
                    callPayload.Queries["isPkChunkingEnabled"] = ExpressionConverter.Convert(isPkChunkingEnabled);
                callPayload.Queries["jobType"] = Convert.ToString("V2Ingest");
                if (jobType != null)
                    callPayload.Queries["jobType"] = ExpressionConverter.Convert(jobType);
                if (queryLocator != null)
                    callPayload.Queries["queryLocator"] = ExpressionConverter.Convert(queryLocator);
                return new ApiConnectionAction<GetAllJobsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildUploadJobData))]
        public IWorkflowAction UploadJobData([WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUploadJobData(WorkflowExpression<string> jobId, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}/batches", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetJobInfo))]
        public IBodyWorkflowAction<CheckJobResponse> GetJobInfo([WorkflowExpression] Func<string> jobId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckJobResponse> __BuildGetJobInfo(WorkflowExpression<string> jobId)
        {
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<CheckJobResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CheckJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildCloseJob))]
        public IBodyWorkflowAction<JobInfo> CloseJob([WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<bodystateInput> bodystate)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JobInfo> __BuildCloseJob(WorkflowExpression<string> jobId, WorkflowExpression<bodystateInput> bodystate)
        {
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: true);
            return new DeferredBodyAction<JobInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(bodystate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JobInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteJob))]
        public IWorkflowAction DeleteJob([WorkflowExpression] Func<string> jobId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteJob(WorkflowExpression<string> jobId)
        {
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetJobRecordResults))]
        public IBodyWorkflowAction<string> GetJobRecordResults([WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<resultTypeInput> resultType)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetJobRecordResults(WorkflowExpression<string> jobId, WorkflowExpression<resultTypeInput> resultType)
        {
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            WorkflowExpression.Validate(resultType, nameof(resultType), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/jobs/ingest/{0}/results", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resultType"] = ExpressionConverter.Convert(resultType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteSOSLQuery))]
        public IBodyWorkflowAction<SOSLSearchQueryResponse> ExecuteSOSLQuery([WorkflowExpression] Func<string> q)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SOSLSearchQueryResponse> __BuildExecuteSOSLQuery(WorkflowExpression<string> q)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            return new DeferredBodyAction<SOSLSearchQueryResponse>(() =>
            {
                var apiCallPath = "/codeless/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                return new ApiConnectionAction<SOSLSearchQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildHttpRequest))]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> customHeader1 = null, [WorkflowExpression] Func<string> customHeader2 = null, [WorkflowExpression] Func<string> customHeader3 = null, [WorkflowExpression] Func<string> customHeader4 = null, [WorkflowExpression] Func<string> customHeader5 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildHttpRequest(WorkflowExpression<string> uri, WorkflowExpression<methodInput> method, WorkflowExpression<string> body = null, WorkflowExpression<string> contentType = null, WorkflowExpression<string> customHeader1 = null, WorkflowExpression<string> customHeader2 = null, WorkflowExpression<string> customHeader3 = null, WorkflowExpression<string> customHeader4 = null, WorkflowExpression<string> customHeader5 = null)
        {
            WorkflowExpression.Validate(uri, nameof(uri), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(customHeader1, nameof(customHeader1), required: false);
            WorkflowExpression.Validate(customHeader2, nameof(customHeader2), required: false);
            WorkflowExpression.Validate(customHeader3, nameof(customHeader3), required: false);
            WorkflowExpression.Validate(customHeader4, nameof(customHeader4), required: false);
            WorkflowExpression.Validate(customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/codeless/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = ExpressionConverter.Convert(uri);
                callPayload.Headers["Method"] = ExpressionConverter.Convert(method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["ContentType"] = ExpressionConverter.Convert(contentType);
                if (customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(customHeader1);
                if (customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(customHeader2);
                if (customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(customHeader3);
                if (customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(customHeader4);
                if (customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(customHeader5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildMcpSalesforceManagement))]
        public IBodyWorkflowAction<MCPQueryResponse> McpSalesforceManagement([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MCPQueryResponse> __BuildMcpSalesforceManagement(WorkflowExpression<string> queryRequestjsonrpc = null, WorkflowExpression<string> queryRequestid = null, WorkflowExpression<string> queryRequestmethod = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            WorkflowExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            WorkflowExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse>(() =>
            {
                var apiCallPath = "/mcp/SalesforceManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
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

                return new ApiConnectionAction<MCPQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildCreateJob))]
        public IBodyWorkflowAction<CreateJobResponse> CreateJob([WorkflowExpression] Func<string> parametersobject, [WorkflowExpression] Func<parametersoperationInput> parametersoperation, [WorkflowExpression] Func<string> parameterscolumnDelimiter = null, [WorkflowExpression] Func<string> parametersexternalIDFieldName = null, [WorkflowExpression] Func<string> parameterslineEnding = null, [WorkflowExpression] Func<string> parameterscontentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateJobResponse> __BuildCreateJob(WorkflowExpression<string> parametersobject, WorkflowExpression<parametersoperationInput> parametersoperation, WorkflowExpression<string> parameterscolumnDelimiter = null, WorkflowExpression<string> parametersexternalIDFieldName = null, WorkflowExpression<string> parameterslineEnding = null, WorkflowExpression<string> parameterscontentType = null)
        {
            WorkflowExpression.Validate(parametersobject, nameof(parametersobject), required: true);
            WorkflowExpression.Validate(parametersoperation, nameof(parametersoperation), required: true);
            WorkflowExpression.Validate(parameterscolumnDelimiter, nameof(parameterscolumnDelimiter), required: false);
            WorkflowExpression.Validate(parametersexternalIDFieldName, nameof(parametersexternalIDFieldName), required: false);
            WorkflowExpression.Validate(parameterslineEnding, nameof(parameterslineEnding), required: false);
            WorkflowExpression.Validate(parameterscontentType, nameof(parameterscontentType), required: false);
            return new DeferredBodyAction<CreateJobResponse>(() =>
            {
                var apiCallPath = "/bulk/createjob";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["object"] = ExpressionConverter.ConvertO(parametersobject);
                parameterspropCount++;
                parameters["operation"] = ExpressionConverter.ConvertO(parametersoperation);
                if (parameterscolumnDelimiter != null)
                {
                    parameters["columnDelimiter"] = ExpressionConverter.ConvertO(parameterscolumnDelimiter);
                    parameterspropCount++;
                }

                if (parametersexternalIDFieldName != null)
                {
                    parameters["externalIdFieldName"] = ExpressionConverter.ConvertO(parametersexternalIDFieldName);
                    parameterspropCount++;
                }

                if (parameterslineEnding != null)
                {
                    parameters["lineEnding"] = ExpressionConverter.ConvertO(parameterslineEnding);
                    parameterspropCount++;
                }

                if (parameterscontentType != null)
                {
                    parameters["contentType"] = ExpressionConverter.ConvertO(parameterscontentType);
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
        [WorkflowExpressionFactory(nameof(__BuildGetItem))]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItem(WorkflowExpression<string> table, WorkflowExpression<string> id, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildPatchItem))]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPatchItem(WorkflowExpression<string> table, WorkflowExpression<string> id, WorkflowExpression<object> item = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildPatchItemByExternalId))]
        public IBodyWorkflowAction<JToken> PatchItemByExternalId([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> externalIdField, [WorkflowExpression] Func<string> externalId, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPatchItemByExternalId(WorkflowExpression<string> table, WorkflowExpression<string> externalIdField, WorkflowExpression<string> externalId, WorkflowExpression<object> item = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(externalIdField, nameof(externalIdField), required: true);
            WorkflowExpression.Validate(externalId, nameof(externalId), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/default/tables/{0}/externalIdFields/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(externalIdField, 2), ExpressionConverter.ConvertWithUrlEncoding(externalId, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [WorkflowExpressionFactory(nameof(__BuildPostItem))]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPostItem(WorkflowExpression<string> table, WorkflowExpression<object> item = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/default/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class SalesforceTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewItems))]
        public IBodyWorkflowTrigger<ItemsList> OnNewItems([WorkflowExpression] Func<string> table,[WorkflowExpression] Func<string> filter = null,[WorkflowExpression] Func<string> orderby = null,[WorkflowExpression] Func<string> select = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ItemsList> __BuildOnNewItems(WorkflowExpression<string> table,WorkflowExpression<string> filter = null,WorkflowExpression<string> orderby = null,WorkflowExpression<string> select = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedItems))]
        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems([WorkflowExpression] Func<string> table,[WorkflowExpression] Func<string> filter = null,[WorkflowExpression] Func<string> orderby = null,[WorkflowExpression] Func<string> select = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ItemsList> __BuildOnUpdatedItems(WorkflowExpression<string> table,WorkflowExpression<string> filter = null,WorkflowExpression<string> orderby = null,WorkflowExpression<string> select = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
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