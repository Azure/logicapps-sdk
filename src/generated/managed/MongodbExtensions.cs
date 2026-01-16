//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mongodb
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MongodbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<InsertDocumentResponse> InsertDocument(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<FindDocumentResponse> FindDocument(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<UpdateDocumentResponse> UpdateDocument(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection, Expression<Func<bool>> bodyupsert = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<DeleteDocumentResponse> DeleteDocument(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<InsertMultipleDocumentsResponse> InsertMultipleDocuments(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection, Expression<Func<JToken[]>> bodydocuments)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<FindMultipleDocumentsResponse> FindMultipleDocuments(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection, Expression<Func<int>> bodylimit = null, Expression<Func<int>> bodyskip = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<UpdateMultipleDocumentsResponse> UpdateMultipleDocuments(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection, Expression<Func<bool>> bodyupsert = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<DeleteManyDocumentsResponse> DeleteManyDocuments(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<RunAggregationPipelineResponse> RunAggregationPipeline(Expression<Func<string>> bodydataSource, Expression<Func<string>> bodydatabase, Expression<Func<string>> bodycollection, Expression<Func<JToken[]>> bodypipeline)
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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