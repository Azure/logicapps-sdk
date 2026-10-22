//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mongodb
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MongodbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<InsertDocumentResponse, ApiConnectionActionConfiguration> InsertDocument(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection)
        {
            var __workflow_bodydataSource = WorkflowExpression.Compile(bodydataSource, nameof(bodydataSource), required: true);
            var __workflow_bodydatabase = WorkflowExpression.Compile(bodydatabase, nameof(bodydatabase), required: true);
            var __workflow_bodycollection = WorkflowExpression.Compile(bodycollection, nameof(bodycollection), required: true);
            return new DeferredBodyAction<InsertDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/insertOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(__workflow_bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(__workflow_bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(__workflow_bodycollection);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InsertDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<FindDocumentResponse, ApiConnectionActionConfiguration> FindDocument(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection)
        {
            var __workflow_bodydataSource = WorkflowExpression.Compile(bodydataSource, nameof(bodydataSource), required: true);
            var __workflow_bodydatabase = WorkflowExpression.Compile(bodydatabase, nameof(bodydatabase), required: true);
            var __workflow_bodycollection = WorkflowExpression.Compile(bodycollection, nameof(bodycollection), required: true);
            return new DeferredBodyAction<FindDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/findOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(__workflow_bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(__workflow_bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(__workflow_bodycollection);
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (filterObjectpropCount > 0)
                {
                    body["filter"] = filterObject;
                    bodypropCount++;
                }

                var projectionObject = new JObject();
                var projectionObjectpropCount = 0;
                if (projectionObjectpropCount > 0)
                {
                    body["projection"] = projectionObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FindDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<UpdateDocumentResponse, ApiConnectionActionConfiguration> UpdateDocument(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection, Expression<Func<bool>> bodyupsert = null)
        {
            var __workflow_bodydataSource = WorkflowExpression.Compile(bodydataSource, nameof(bodydataSource), required: true);
            var __workflow_bodydatabase = WorkflowExpression.Compile(bodydatabase, nameof(bodydatabase), required: true);
            var __workflow_bodycollection = WorkflowExpression.Compile(bodycollection, nameof(bodycollection), required: true);
            var __workflow_bodyupsert = WorkflowExpression.Compile(bodyupsert, nameof(bodyupsert), required: false);
            return new DeferredBodyAction<UpdateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/updateOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(__workflow_bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(__workflow_bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(__workflow_bodycollection);
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (filterObjectpropCount > 0)
                {
                    body["filter"] = filterObject;
                    bodypropCount++;
                }

                var updateObject = new JObject();
                var updateObjectpropCount = 0;
                if (updateObjectpropCount > 0)
                {
                    body["update"] = updateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyupsert != null)
                {
                    body["upsert"] = ExpressionConverter.ConvertO(__workflow_bodyupsert);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<DeleteDocumentResponse, ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection)
        {
            var __workflow_bodydataSource = WorkflowExpression.Compile(bodydataSource, nameof(bodydataSource), required: true);
            var __workflow_bodydatabase = WorkflowExpression.Compile(bodydatabase, nameof(bodydatabase), required: true);
            var __workflow_bodycollection = WorkflowExpression.Compile(bodycollection, nameof(bodycollection), required: true);
            return new DeferredBodyAction<DeleteDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/deleteOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(__workflow_bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(__workflow_bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(__workflow_bodycollection);
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (filterObjectpropCount > 0)
                {
                    body["filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<InsertMultipleDocumentsResponse, ApiConnectionActionConfiguration> InsertMultipleDocuments(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection, Expression<Func<JToken[]>> bodydocuments)
        {
            var __workflow_bodydataSource = WorkflowExpression.Compile(bodydataSource, nameof(bodydataSource), required: true);
            var __workflow_bodydatabase = WorkflowExpression.Compile(bodydatabase, nameof(bodydatabase), required: true);
            var __workflow_bodycollection = WorkflowExpression.Compile(bodycollection, nameof(bodycollection), required: true);
            var __workflow_bodydocuments = WorkflowExpression.Compile(bodydocuments, nameof(bodydocuments), required: true);
            return new DeferredBodyAction<InsertMultipleDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/insertMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(__workflow_bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(__workflow_bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(__workflow_bodycollection);
                bodypropCount++;
                body["documents"] = ExpressionConverter.ConvertO(__workflow_bodydocuments);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InsertMultipleDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<FindMultipleDocumentsResponse, ApiConnectionActionConfiguration> FindMultipleDocuments(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection, Expression<Func<int>> bodylimit = null, Expression<Func<int>> bodyskip = null)
        {
            var __workflow_bodydataSource = WorkflowExpression.Compile(bodydataSource, nameof(bodydataSource), required: true);
            var __workflow_bodydatabase = WorkflowExpression.Compile(bodydatabase, nameof(bodydatabase), required: true);
            var __workflow_bodycollection = WorkflowExpression.Compile(bodycollection, nameof(bodycollection), required: true);
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            var __workflow_bodyskip = WorkflowExpression.Compile(bodyskip, nameof(bodyskip), required: false);
            return new DeferredBodyAction<FindMultipleDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(__workflow_bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(__workflow_bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(__workflow_bodycollection);
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (filterObjectpropCount > 0)
                {
                    body["filter"] = filterObject;
                    bodypropCount++;
                }

                var projectionObject = new JObject();
                var projectionObjectpropCount = 0;
                if (projectionObjectpropCount > 0)
                {
                    body["projection"] = projectionObject;
                    bodypropCount++;
                }

                var sortObject = new JObject();
                var sortObjectpropCount = 0;
                if (sortObjectpropCount > 0)
                {
                    body["sort"] = sortObject;
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                    bodypropCount++;
                }

                if (__workflow_bodyskip != null)
                {
                    body["skip"] = ExpressionConverter.ConvertO(__workflow_bodyskip);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FindMultipleDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<UpdateMultipleDocumentsResponse, ApiConnectionActionConfiguration> UpdateMultipleDocuments(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection, Expression<Func<bool>> bodyupsert = null)
        {
            var __workflow_bodydataSource = WorkflowExpression.Compile(bodydataSource, nameof(bodydataSource), required: true);
            var __workflow_bodydatabase = WorkflowExpression.Compile(bodydatabase, nameof(bodydatabase), required: true);
            var __workflow_bodycollection = WorkflowExpression.Compile(bodycollection, nameof(bodycollection), required: true);
            var __workflow_bodyupsert = WorkflowExpression.Compile(bodyupsert, nameof(bodyupsert), required: false);
            return new DeferredBodyAction<UpdateMultipleDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/updateMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(__workflow_bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(__workflow_bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(__workflow_bodycollection);
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (filterObjectpropCount > 0)
                {
                    body["filter"] = filterObject;
                    bodypropCount++;
                }

                var updateObject = new JObject();
                var updateObjectpropCount = 0;
                if (updateObjectpropCount > 0)
                {
                    body["update"] = updateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyupsert != null)
                {
                    body["upsert"] = ExpressionConverter.ConvertO(__workflow_bodyupsert);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateMultipleDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<DeleteManyDocumentsResponse, ApiConnectionActionConfiguration> DeleteManyDocuments(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection)
        {
            var __workflow_bodydataSource = WorkflowExpression.Compile(bodydataSource, nameof(bodydataSource), required: true);
            var __workflow_bodydatabase = WorkflowExpression.Compile(bodydatabase, nameof(bodydatabase), required: true);
            var __workflow_bodycollection = WorkflowExpression.Compile(bodycollection, nameof(bodycollection), required: true);
            return new DeferredBodyAction<DeleteManyDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/deleteMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(__workflow_bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(__workflow_bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(__workflow_bodycollection);
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (filterObjectpropCount > 0)
                {
                    body["filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteManyDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<RunAggregationPipelineResponse, ApiConnectionActionConfiguration> RunAggregationPipeline(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection, Expression<Func<JToken[]>> bodypipeline)
        {
            var __workflow_bodydataSource = WorkflowExpression.Compile(bodydataSource, nameof(bodydataSource), required: true);
            var __workflow_bodydatabase = WorkflowExpression.Compile(bodydatabase, nameof(bodydatabase), required: true);
            var __workflow_bodycollection = WorkflowExpression.Compile(bodycollection, nameof(bodycollection), required: true);
            var __workflow_bodypipeline = WorkflowExpression.Compile(bodypipeline, nameof(bodypipeline), required: true);
            return new DeferredBodyAction<RunAggregationPipelineResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/aggregate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(__workflow_bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(__workflow_bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(__workflow_bodycollection);
                bodypropCount++;
                body["pipeline"] = ExpressionConverter.ConvertO(__workflow_bodypipeline);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RunAggregationPipelineResponse>(callPayload);
            });
        }
    }

    public class MongodbTriggers([ConnectionName] string connectionId)
    {
    }

    public class InsertDocumentResponse
    {
        [JsonProperty("insertedId")]
        public string InsertedId { get; set; }
    }

    public class FindDocumentResponse
    {
        [JsonProperty("document")]
        public JToken Document { get; set; }
    }

    public class UpdateDocumentResponse
    {
        [JsonProperty("matchedCount")]
        public int MatchedCount { get; set; }

        [JsonProperty("modifiedCount")]
        public int ModifiedCount { get; set; }
    }

    public class DeleteDocumentResponse
    {
        [JsonProperty("deletedCount")]
        public int DeletedCount { get; set; }
    }

    public class InsertMultipleDocumentsResponse
    {
        [JsonProperty("insertedIds")]
        public string[] InsertedIds { get; set; }
    }

    public class FindMultipleDocumentsResponse
    {
        [JsonProperty("documents")]
        public JToken[] Documents { get; set; }
    }

    public class UpdateMultipleDocumentsResponse
    {
        [JsonProperty("matchedCount")]
        public int MatchedCount { get; set; }

        [JsonProperty("modifiedCount")]
        public int ModifiedCount { get; set; }
    }

    public class DeleteManyDocumentsResponse
    {
        [JsonProperty("deletedCount")]
        public int DeletedCount { get; set; }
    }

    public class RunAggregationPipelineResponse
    {
        [JsonProperty("documents")]
        public JToken[] Documents { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mongodb;

    public partial class WorkflowManagedActions
    {
        public MongodbActions Mongodb(string connectionId) => new MongodbActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MongodbTriggers Mongodb(string connectionId) => new MongodbTriggers(connectionId);
    }
}
