//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mongodb
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MongodbActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        [WorkflowExpressionFactory(nameof(__BuildInsertDocument))]
        public IBodyWorkflowAction<InsertDocumentResponse> InsertDocument([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertDocumentResponse> __BuildInsertDocument(WorkflowExpression<string> bodydataSource, WorkflowExpression<string> bodydatabase, WorkflowExpression<string> bodycollection)
        {
            WorkflowExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            WorkflowExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            WorkflowExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            return new DeferredBodyAction<InsertDocumentResponse>(() =>
            {
                var apiCallPath = "/action/insertOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(bodycollection);
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
        [WorkflowExpressionFactory(nameof(__BuildFindDocument))]
        public IBodyWorkflowAction<FindDocumentResponse> FindDocument([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindDocumentResponse> __BuildFindDocument(WorkflowExpression<string> bodydataSource, WorkflowExpression<string> bodydatabase, WorkflowExpression<string> bodycollection)
        {
            WorkflowExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            WorkflowExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            WorkflowExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            return new DeferredBodyAction<FindDocumentResponse>(() =>
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
                body["dataSource"] = ExpressionConverter.ConvertO(bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(bodycollection);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateDocument))]
        public IBodyWorkflowAction<UpdateDocumentResponse> UpdateDocument([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection, [WorkflowExpression] Func<bool> bodyupsert = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateDocumentResponse> __BuildUpdateDocument(WorkflowExpression<string> bodydataSource, WorkflowExpression<string> bodydatabase, WorkflowExpression<string> bodycollection, WorkflowExpression<bool> bodyupsert = null)
        {
            WorkflowExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            WorkflowExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            WorkflowExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            WorkflowExpression.Validate(bodyupsert, nameof(bodyupsert), required: false);
            return new DeferredBodyAction<UpdateDocumentResponse>(() =>
            {
                var apiCallPath = "/action/updateOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(bodycollection);
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

                if (bodyupsert != null)
                {
                    body["upsert"] = ExpressionConverter.ConvertO(bodyupsert);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocument))]
        public IBodyWorkflowAction<DeleteDocumentResponse> DeleteDocument([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteDocumentResponse> __BuildDeleteDocument(WorkflowExpression<string> bodydataSource, WorkflowExpression<string> bodydatabase, WorkflowExpression<string> bodycollection)
        {
            WorkflowExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            WorkflowExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            WorkflowExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            return new DeferredBodyAction<DeleteDocumentResponse>(() =>
            {
                var apiCallPath = "/action/deleteOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(bodycollection);
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
        [WorkflowExpressionFactory(nameof(__BuildInsertMultipleDocuments))]
        public IBodyWorkflowAction<InsertMultipleDocumentsResponse> InsertMultipleDocuments([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection, [WorkflowExpression] Func<JToken[]> bodydocuments)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertMultipleDocumentsResponse> __BuildInsertMultipleDocuments(WorkflowExpression<string> bodydataSource, WorkflowExpression<string> bodydatabase, WorkflowExpression<string> bodycollection, WorkflowExpression<JToken[]> bodydocuments)
        {
            WorkflowExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            WorkflowExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            WorkflowExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            WorkflowExpression.Validate(bodydocuments, nameof(bodydocuments), required: true);
            return new DeferredBodyAction<InsertMultipleDocumentsResponse>(() =>
            {
                var apiCallPath = "/action/insertMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(bodycollection);
                bodypropCount++;
                body["documents"] = ExpressionConverter.ConvertO(bodydocuments);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InsertMultipleDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        [WorkflowExpressionFactory(nameof(__BuildFindMultipleDocuments))]
        public IBodyWorkflowAction<FindMultipleDocumentsResponse> FindMultipleDocuments([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection, [WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<int> bodyskip = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindMultipleDocumentsResponse> __BuildFindMultipleDocuments(WorkflowExpression<string> bodydataSource, WorkflowExpression<string> bodydatabase, WorkflowExpression<string> bodycollection, WorkflowExpression<int> bodylimit = null, WorkflowExpression<int> bodyskip = null)
        {
            WorkflowExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            WorkflowExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            WorkflowExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyskip, nameof(bodyskip), required: false);
            return new DeferredBodyAction<FindMultipleDocumentsResponse>(() =>
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
                body["dataSource"] = ExpressionConverter.ConvertO(bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(bodycollection);
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

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyskip != null)
                {
                    body["skip"] = ExpressionConverter.ConvertO(bodyskip);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateMultipleDocuments))]
        public IBodyWorkflowAction<UpdateMultipleDocumentsResponse> UpdateMultipleDocuments([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection, [WorkflowExpression] Func<bool> bodyupsert = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateMultipleDocumentsResponse> __BuildUpdateMultipleDocuments(WorkflowExpression<string> bodydataSource, WorkflowExpression<string> bodydatabase, WorkflowExpression<string> bodycollection, WorkflowExpression<bool> bodyupsert = null)
        {
            WorkflowExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            WorkflowExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            WorkflowExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            WorkflowExpression.Validate(bodyupsert, nameof(bodyupsert), required: false);
            return new DeferredBodyAction<UpdateMultipleDocumentsResponse>(() =>
            {
                var apiCallPath = "/action/updateMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(bodycollection);
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

                if (bodyupsert != null)
                {
                    body["upsert"] = ExpressionConverter.ConvertO(bodyupsert);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteManyDocuments))]
        public IBodyWorkflowAction<DeleteManyDocumentsResponse> DeleteManyDocuments([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteManyDocumentsResponse> __BuildDeleteManyDocuments(WorkflowExpression<string> bodydataSource, WorkflowExpression<string> bodydatabase, WorkflowExpression<string> bodycollection)
        {
            WorkflowExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            WorkflowExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            WorkflowExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            return new DeferredBodyAction<DeleteManyDocumentsResponse>(() =>
            {
                var apiCallPath = "/action/deleteMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(bodycollection);
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
        [WorkflowExpressionFactory(nameof(__BuildRunAggregationPipeline))]
        public IBodyWorkflowAction<RunAggregationPipelineResponse> RunAggregationPipeline([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection, [WorkflowExpression] Func<JToken[]> bodypipeline)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunAggregationPipelineResponse> __BuildRunAggregationPipeline(WorkflowExpression<string> bodydataSource, WorkflowExpression<string> bodydatabase, WorkflowExpression<string> bodycollection, WorkflowExpression<JToken[]> bodypipeline)
        {
            WorkflowExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            WorkflowExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            WorkflowExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            WorkflowExpression.Validate(bodypipeline, nameof(bodypipeline), required: true);
            return new DeferredBodyAction<RunAggregationPipelineResponse>(() =>
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
                body["dataSource"] = ExpressionConverter.ConvertO(bodydataSource);
                bodypropCount++;
                body["database"] = ExpressionConverter.ConvertO(bodydatabase);
                bodypropCount++;
                body["collection"] = ExpressionConverter.ConvertO(bodycollection);
                bodypropCount++;
                body["pipeline"] = ExpressionConverter.ConvertO(bodypipeline);
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