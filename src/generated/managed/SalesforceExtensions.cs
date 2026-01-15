//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Salesforce
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SalesforceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<CreateJobResponse> CreateJobV2(Expression<Func<string>> parametersobject, Expression<Func<parametersoperationInput>> parametersoperation, Expression<Func<string>> parameterscolumnDelimiter = null, Expression<Func<string>> parametersexternalIDFieldName = null, Expression<Func<string>> parameterslineEnding = null, Expression<Func<string>> parameterscontentType = null)
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
        }

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
            var apiCallPath = String.Format("/datasets/default/tables/{0}/externalIdFields/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(externalIdField, 2), ExpressionConverter.ConvertWithUrlEncoding(externalId, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/datasets/default/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableAccount(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableUser(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableCase(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableOpportunity(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableProduct2(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<ItemsList> GetItemsTableContact(Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> ExecuteSoqlQuery(Expression<Func<string>> queryParameterssOQLQuery)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> PatchItemByExternalIdV2(Expression<Func<string>> table, Expression<Func<string>> externalIdField, Expression<Func<string>> externalId, Expression<Func<object>> item = null)
        {
            var apiCallPath = String.Format("/v2/datasets/default/tables/{0}/externalIdFields/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(externalIdField, 2), ExpressionConverter.ConvertWithUrlEncoding(externalId, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> PostItemV2(Expression<Func<string>> table, Expression<Func<object>> item = null)
        {
            var apiCallPath = String.Format("/v2/datasets/default/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> GetItemV2(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/v2/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> PatchItemV3(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/v3/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<GetAllJobsResponse> GetAllJobs(Expression<Func<concurrenyModeInput>> concurrenyMode = null, Expression<Func<bool>> isPkChunkingEnabled = null, Expression<Func<jobTypeInput>> jobType = null, Expression<Func<string>> queryLocator = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IWorkflowAction UploadJobData(Expression<Func<string>> jobId, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/codeless/jobs/ingest/{0}/batches", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<CheckJobResponse> GetJobInfo(Expression<Func<string>> jobId)
        {
            var apiCallPath = String.Format("/codeless/jobs/ingest/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CheckJobResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JobInfo> CloseJob(Expression<Func<string>> jobId, Expression<Func<bodystateInput>> bodystate)
        {
            var apiCallPath = String.Format("/codeless/jobs/ingest/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IWorkflowAction DeleteJob(Expression<Func<string>> jobId)
        {
            var apiCallPath = String.Format("/codeless/jobs/ingest/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<string> GetJobRecordResults(Expression<Func<string>> jobId, Expression<Func<resultTypeInput>> resultType)
        {
            var apiCallPath = String.Format("/codeless/jobs/ingest/{0}/results", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["resultType"] = ExpressionConverter.Convert(resultType);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<SOSLSearchQueryResponse> ExecuteSOSLQuery(Expression<Func<string>> q)
        {
            var apiCallPath = "/codeless/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<SOSLSearchQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "salesforce")]
        public IBodyWorkflowAction<MCPQueryResponse> McpSalesforceManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
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

            return new ApiConnectionAction<MCPQueryResponse>(callPayload);
        }
    }

    public class SalesforceTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<ItemsList> GetOnNewItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/datasets/default/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionTrigger<ItemsList>(callPayload);
        }

        public IOutputWorkflowTrigger<ItemsList> GetOnUpdatedItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/datasets/default/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionTrigger<ItemsList>(callPayload);
        }
    }

    public class CreateJobResponse
    {
        [JsonProperty("object")]
        public string Object { get; set; }

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
        public string Object { get; set; }

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
        public string Object { get; set; }

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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Salesforce;

    public partial class WorkflowManagedActions
    {
        public SalesforceActions Salesforce(string connectionId) => new SalesforceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SalesforceTriggers Salesforce(string connectionId) => new SalesforceTriggers(connectionId);
    }
}