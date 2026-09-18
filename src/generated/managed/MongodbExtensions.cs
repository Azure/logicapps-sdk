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
        public IBodyWorkflowAction<InsertDocumentResponse> InsertDocument([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection)
        {
            SourceExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            SourceExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            SourceExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/action/insertOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = SourceExpressionConverter.ConvertToken(bodydataSource);
                bodypropCount++;
                body["database"] = SourceExpressionConverter.ConvertToken(bodydatabase);
                bodypropCount++;
                body["collection"] = SourceExpressionConverter.ConvertToken(bodycollection);
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
                return callPayload;
            }

            return new ApiConnectionAction<InsertDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<FindDocumentResponse> FindDocument([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection)
        {
            SourceExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            SourceExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            SourceExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            ApiConnectionActionInput BuildSourceInput()
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
                body["dataSource"] = SourceExpressionConverter.ConvertToken(bodydataSource);
                bodypropCount++;
                body["database"] = SourceExpressionConverter.ConvertToken(bodydatabase);
                bodypropCount++;
                body["collection"] = SourceExpressionConverter.ConvertToken(bodycollection);
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
                return callPayload;
            }

            return new ApiConnectionAction<FindDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<UpdateDocumentResponse> UpdateDocument([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection, [WorkflowExpression] Func<bool> bodyupsert = null)
        {
            SourceExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            SourceExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            SourceExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            SourceExpression.Validate(bodyupsert, nameof(bodyupsert), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/action/updateOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = SourceExpressionConverter.ConvertToken(bodydataSource);
                bodypropCount++;
                body["database"] = SourceExpressionConverter.ConvertToken(bodydatabase);
                bodypropCount++;
                body["collection"] = SourceExpressionConverter.ConvertToken(bodycollection);
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
                    body["upsert"] = SourceExpressionConverter.ConvertToken(bodyupsert);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<DeleteDocumentResponse> DeleteDocument([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection)
        {
            SourceExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            SourceExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            SourceExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/action/deleteOne";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = SourceExpressionConverter.ConvertToken(bodydataSource);
                bodypropCount++;
                body["database"] = SourceExpressionConverter.ConvertToken(bodydatabase);
                bodypropCount++;
                body["collection"] = SourceExpressionConverter.ConvertToken(bodycollection);
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
                return callPayload;
            }

            return new ApiConnectionAction<DeleteDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<InsertMultipleDocumentsResponse> InsertMultipleDocuments([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection, [WorkflowExpression] Func<JToken[]> bodydocuments)
        {
            SourceExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            SourceExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            SourceExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            SourceExpression.Validate(bodydocuments, nameof(bodydocuments), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/action/insertMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = SourceExpressionConverter.ConvertToken(bodydataSource);
                bodypropCount++;
                body["database"] = SourceExpressionConverter.ConvertToken(bodydatabase);
                bodypropCount++;
                body["collection"] = SourceExpressionConverter.ConvertToken(bodycollection);
                bodypropCount++;
                body["documents"] = SourceExpressionConverter.ConvertToken(bodydocuments);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertMultipleDocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<FindMultipleDocumentsResponse> FindMultipleDocuments([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection, [WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<int> bodyskip = null)
        {
            SourceExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            SourceExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            SourceExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            SourceExpression.Validate(bodyskip, nameof(bodyskip), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                body["dataSource"] = SourceExpressionConverter.ConvertToken(bodydataSource);
                bodypropCount++;
                body["database"] = SourceExpressionConverter.ConvertToken(bodydatabase);
                bodypropCount++;
                body["collection"] = SourceExpressionConverter.ConvertToken(bodycollection);
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
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodyskip != null)
                {
                    body["skip"] = SourceExpressionConverter.ConvertToken(bodyskip);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FindMultipleDocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<UpdateMultipleDocumentsResponse> UpdateMultipleDocuments([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection, [WorkflowExpression] Func<bool> bodyupsert = null)
        {
            SourceExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            SourceExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            SourceExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            SourceExpression.Validate(bodyupsert, nameof(bodyupsert), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/action/updateMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = SourceExpressionConverter.ConvertToken(bodydataSource);
                bodypropCount++;
                body["database"] = SourceExpressionConverter.ConvertToken(bodydatabase);
                bodypropCount++;
                body["collection"] = SourceExpressionConverter.ConvertToken(bodycollection);
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
                    body["upsert"] = SourceExpressionConverter.ConvertToken(bodyupsert);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateMultipleDocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<DeleteManyDocumentsResponse> DeleteManyDocuments([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection)
        {
            SourceExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            SourceExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            SourceExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/action/deleteMany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Control-Request-Headers"] = Convert.ToString("*");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dataSource"] = SourceExpressionConverter.ConvertToken(bodydataSource);
                bodypropCount++;
                body["database"] = SourceExpressionConverter.ConvertToken(bodydatabase);
                bodypropCount++;
                body["collection"] = SourceExpressionConverter.ConvertToken(bodycollection);
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
                return callPayload;
            }

            return new ApiConnectionAction<DeleteManyDocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mongodb")]
        public IBodyWorkflowAction<RunAggregationPipelineResponse> RunAggregationPipeline([WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodydatabase, [WorkflowExpression] Func<string> bodycollection, [WorkflowExpression] Func<JToken[]> bodypipeline)
        {
            SourceExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            SourceExpression.Validate(bodydatabase, nameof(bodydatabase), required: true);
            SourceExpression.Validate(bodycollection, nameof(bodycollection), required: true);
            SourceExpression.Validate(bodypipeline, nameof(bodypipeline), required: true);
            ApiConnectionActionInput BuildSourceInput()
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
                body["dataSource"] = SourceExpressionConverter.ConvertToken(bodydataSource);
                bodypropCount++;
                body["database"] = SourceExpressionConverter.ConvertToken(bodydatabase);
                bodypropCount++;
                body["collection"] = SourceExpressionConverter.ConvertToken(bodycollection);
                bodypropCount++;
                body["pipeline"] = SourceExpressionConverter.ConvertToken(bodypipeline);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RunAggregationPipelineResponse>(BuildSourceInput);
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