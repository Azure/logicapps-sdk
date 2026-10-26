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
        public IBodyWorkflowAction<InsertDocumentResponse, ApiConnectionActionConfiguration> InsertDocument(Expression<Func<InsertDocumentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InsertDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/insertOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InsertDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<FindDocumentResponse, ApiConnectionActionConfiguration> FindDocument(Expression<Func<FindDocumentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FindDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/findOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FindDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<UpdateDocumentResponse, ApiConnectionActionConfiguration> UpdateDocument(Expression<Func<UpdateDocumentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/updateOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<DeleteDocumentResponse, ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<DeleteDocumentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeleteDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/deleteOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<InsertMultipleDocumentsResponse, ApiConnectionActionConfiguration> InsertMultipleDocuments(Expression<Func<InsertMultipleDocumentsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InsertMultipleDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/insertMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InsertMultipleDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<FindMultipleDocumentsResponse, ApiConnectionActionConfiguration> FindMultipleDocuments(Expression<Func<FindMultipleDocumentsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FindMultipleDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FindMultipleDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<UpdateMultipleDocumentsResponse, ApiConnectionActionConfiguration> UpdateMultipleDocuments(Expression<Func<UpdateMultipleDocumentsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateMultipleDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/updateMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateMultipleDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<DeleteManyDocumentsResponse, ApiConnectionActionConfiguration> DeleteManyDocuments(Expression<Func<DeleteManyDocumentsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeleteManyDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/deleteMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteManyDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<RunAggregationPipelineResponse, ApiConnectionActionConfiguration> RunAggregationPipeline(Expression<Func<RunAggregationPipelineInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RunAggregationPipelineResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/aggregate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class InsertDocumentInput
    {
        [JsonProperty("dataSource", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataSource { get; set; }

        [JsonProperty("database", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Database { get; set; }

        [JsonProperty("collection", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Collection { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Document { get; set; }
    }

    public class FindDocumentResponse
    {
        [JsonProperty("document")]
        public JToken Document { get; set; }
    }

    public class FindDocumentInput
    {
        [JsonProperty("dataSource", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataSource { get; set; }

        [JsonProperty("database", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Database { get; set; }

        [JsonProperty("collection", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Collection { get; set; }

        [JsonProperty("filter")]
        public JToken Filter { get; set; }

        [JsonProperty("projection")]
        public JToken Projection { get; set; }
    }

    public class UpdateDocumentResponse
    {
        [JsonProperty("matchedCount")]
        public int MatchedCount { get; set; }

        [JsonProperty("modifiedCount")]
        public int ModifiedCount { get; set; }
    }

    public class UpdateDocumentInput
    {
        [JsonProperty("dataSource", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataSource { get; set; }

        [JsonProperty("database", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Database { get; set; }

        [JsonProperty("collection", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Collection { get; set; }

        [JsonProperty("filter", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Filter { get; set; }

        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Update { get; set; }

        [JsonProperty("upsert")]
        public bool? Upsert { get; set; }
    }

    public class DeleteDocumentResponse
    {
        [JsonProperty("deletedCount")]
        public int DeletedCount { get; set; }
    }

    public class DeleteDocumentInput
    {
        [JsonProperty("dataSource", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataSource { get; set; }

        [JsonProperty("database", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Database { get; set; }

        [JsonProperty("collection", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Collection { get; set; }

        [JsonProperty("filter", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Filter { get; set; }
    }

    public class InsertMultipleDocumentsResponse
    {
        [JsonProperty("insertedIds")]
        public string[] InsertedIds { get; set; }
    }

    public class InsertMultipleDocumentsInput
    {
        [JsonProperty("dataSource", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataSource { get; set; }

        [JsonProperty("database", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Database { get; set; }

        [JsonProperty("collection", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Collection { get; set; }

        [JsonProperty("documents", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Documents { get; set; }
    }

    public class FindMultipleDocumentsResponse
    {
        [JsonProperty("documents")]
        public JToken[] Documents { get; set; }
    }

    public class FindMultipleDocumentsInput
    {
        [JsonProperty("dataSource", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataSource { get; set; }

        [JsonProperty("database", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Database { get; set; }

        [JsonProperty("collection", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Collection { get; set; }

        [JsonProperty("filter")]
        public JToken Filter { get; set; }

        [JsonProperty("projection")]
        public JToken Projection { get; set; }

        [JsonProperty("sort")]
        public JToken Sort { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("skip")]
        public int? Skip { get; set; }
    }

    public class UpdateMultipleDocumentsResponse
    {
        [JsonProperty("matchedCount")]
        public int MatchedCount { get; set; }

        [JsonProperty("modifiedCount")]
        public int ModifiedCount { get; set; }
    }

    public class UpdateMultipleDocumentsInput
    {
        [JsonProperty("dataSource", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataSource { get; set; }

        [JsonProperty("database", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Database { get; set; }

        [JsonProperty("collection", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Collection { get; set; }

        [JsonProperty("filter", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Filter { get; set; }

        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Update { get; set; }

        [JsonProperty("upsert")]
        public bool? Upsert { get; set; }
    }

    public class DeleteManyDocumentsResponse
    {
        [JsonProperty("deletedCount")]
        public int DeletedCount { get; set; }
    }

    public class DeleteManyDocumentsInput
    {
        [JsonProperty("dataSource", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataSource { get; set; }

        [JsonProperty("database", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Database { get; set; }

        [JsonProperty("collection", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Collection { get; set; }

        [JsonProperty("filter", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Filter { get; set; }
    }

    public class RunAggregationPipelineResponse
    {
        [JsonProperty("documents")]
        public JToken[] Documents { get; set; }
    }

    public class RunAggregationPipelineInput
    {
        [JsonProperty("dataSource", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataSource { get; set; }

        [JsonProperty("database", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Database { get; set; }

        [JsonProperty("collection", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Collection { get; set; }

        [JsonProperty("pipeline", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Pipeline { get; set; }
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