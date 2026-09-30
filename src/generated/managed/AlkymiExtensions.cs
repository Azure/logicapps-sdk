//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Alkymi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlkymiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedDatasetList> DatasetsList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/datasets/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PaginatedDatasetList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedDatasetList> DatasetsRetrieve([WorkflowExpression] Func<string> uuid)
        {
            SourceExpression.Validate(uuid, nameof(uuid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/datasets/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uuid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PaginatedDatasetList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<DocumentsListResponse> DocumentsList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/documents/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<Document> DocumentsRetrieve([WorkflowExpression] Func<string> uuid)
        {
            SourceExpression.Validate(uuid, nameof(uuid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/documents/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uuid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Document>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<string> DocumentsDownloadOriginalRetrieve([WorkflowExpression] Func<string> uuid)
        {
            SourceExpression.Validate(uuid, nameof(uuid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/documents/{0}/download_original/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uuid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<string> DocumentsDownloadPdfRetrieve([WorkflowExpression] Func<string> uuid)
        {
            SourceExpression.Validate(uuid, nameof(uuid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/documents/{0}/download_pdf/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uuid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedExecutionList> ExecutionsList([WorkflowExpression] Func<documentStatusInputItem[]> documentStatus = null)
        {
            SourceExpression.Validate(documentStatus, nameof(documentStatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/executions/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (documentStatus != null)
                    callPayload.Queries["document_status"] = SourceExpressionConverter.ConvertO(documentStatus);
                return callPayload;
            }

            return new ApiConnectionAction<PaginatedExecutionList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<Execution> ExecutionsRetrieve([WorkflowExpression] Func<string> uuid)
        {
            SourceExpression.Validate(uuid, nameof(uuid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/executions/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uuid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Execution>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedPipelineConfigurationList> PipelinesList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/pipelines/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PaginatedPipelineConfigurationList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PipelineConfiguration> PipelinesRetrieve([WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/pipelines/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PipelineConfiguration>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedRecordList> RecordsList([WorkflowExpression] Func<string> dataset = null, [WorkflowExpression] Func<documentStatusInputItem[]> documentStatus = null, [WorkflowExpression] Func<string> pipeline = null, [WorkflowExpression] Func<bool> removed = null, [WorkflowExpression] Func<bool> reviewed = null, [WorkflowExpression] Func<string> schema = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: false);
            SourceExpression.Validate(documentStatus, nameof(documentStatus), required: false);
            SourceExpression.Validate(pipeline, nameof(pipeline), required: false);
            SourceExpression.Validate(removed, nameof(removed), required: false);
            SourceExpression.Validate(reviewed, nameof(reviewed), required: false);
            SourceExpression.Validate(schema, nameof(schema), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/records/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (dataset != null)
                    callPayload.Queries["dataset"] = SourceExpressionConverter.ConvertO(dataset);
                if (documentStatus != null)
                    callPayload.Queries["document_status"] = SourceExpressionConverter.ConvertO(documentStatus);
                if (pipeline != null)
                    callPayload.Queries["pipeline"] = SourceExpressionConverter.ConvertO(pipeline);
                if (removed != null)
                    callPayload.Queries["removed"] = SourceExpressionConverter.ConvertO(removed);
                if (reviewed != null)
                    callPayload.Queries["reviewed"] = SourceExpressionConverter.ConvertO(reviewed);
                if (schema != null)
                    callPayload.Queries["schema"] = SourceExpressionConverter.ConvertO(schema);
                return callPayload;
            }

            return new ApiConnectionAction<PaginatedRecordList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<Record> RecordsRetrieve([WorkflowExpression] Func<string> uuid)
        {
            SourceExpression.Validate(uuid, nameof(uuid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/records/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uuid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Record>(BuildSourceInput);
        }
    }

    public class AlkymiTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHookCreatedResponse> EventListener([WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<bodyeventsInputItem[]> bodyevents = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: false);
            SourceExpression.Validate(bodyevents, nameof(bodyevents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/webhooks/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["target"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodydisplayName != null)
                {
                    body["display_name"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodyevents != null)
                {
                    body["events"] = SourceExpressionConverter.ConvertToken(bodyevents);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHookCreatedResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class PaginatedDatasetList
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Dataset[] Results { get; set; }
    }

    public class Dataset
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pipeline")]
        public string Pipeline { get; set; }

        [JsonProperty("documents")]
        public string Documents { get; set; }

        [JsonProperty("records")]
        public string Records { get; set; }
    }

    public class DocumentsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Document[] Results { get; set; }
    }

    public class Document
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("removed")]
        public bool Removed { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("page_count")]
        public int PageCount { get; set; }

        [JsonProperty("pages")]
        public DocumentPagesTypeItem[] Pages { get; set; }

        [JsonProperty("dataset")]
        public string Dataset { get; set; }

        [JsonProperty("records")]
        public JToken[] Records { get; set; }

        [JsonProperty("pipeline_records")]
        public JToken PipelineRecords { get; set; }

        [JsonProperty("_s3_key")]
        public string S3Key { get; set; }

        [JsonProperty("_replaced_by")]
        public string ReplacedBy { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("watermark_removed")]
        public bool WatermarkRemoved { get; set; }
    }

    public class DocumentPagesTypeItem
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class PaginatedExecutionList
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Execution[] Results { get; set; }
    }

    public class Execution
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("reviewed")]
        public bool Reviewed { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("records")]
        public string[] Records { get; set; }

        [JsonProperty("pipeline_records")]
        public JToken PipelineRecords { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }
    }

    public enum documentStatusInputItem
    {
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "processing")]
        Processing,
        [EnumMember(Value = "uploaded")]
        Uploaded
    }

    public class PaginatedPipelineConfigurationList
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public PipelineConfiguration[] Results { get; set; }
    }

    public class PipelineConfiguration
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("records")]
        public string Records { get; set; }

        [JsonProperty("schemas")]
        public Schema[] Schemas { get; set; }
    }

    public class Schema
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("fields")]
        public SchemaField[] Fields { get; set; }
    }

    public class SchemaField
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("field_type")]
        public string FieldType { get; set; }

        [JsonProperty("sub_schema")]
        public string SubSchema { get; set; }
    }

    public class PaginatedRecordList
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Record[] Results { get; set; }
    }

    public class Record
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("document_uuid")]
        public string DocumentUuid { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("dataset")]
        public string Dataset { get; set; }

        [JsonProperty("pipeline")]
        public string Pipeline { get; set; }

        [JsonProperty("schema_name")]
        public string SchemaName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class WebHookCreatedResponse
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public enum bodyeventsInputItem
    {
        [EnumMember(Value = "on_execution_upload_start")]
        OnExecutionUploadStart,
        [EnumMember(Value = "on_execution_processing_start")]
        OnExecutionProcessingStart,
        [EnumMember(Value = "on_execution_processing_complete")]
        OnExecutionProcessingComplete,
        [EnumMember(Value = "on_execution_review_status_change")]
        OnExecutionReviewStatusChange,
        [EnumMember(Value = "on_execution_remove_status_change")]
        OnExecutionRemoveStatusChange,
        [EnumMember(Value = "on_execution_error")]
        OnExecutionError,
        [EnumMember(Value = "document_save")]
        DocumentSave,
        [EnumMember(Value = "record_create")]
        RecordCreate,
        [EnumMember(Value = "record_delete")]
        RecordDelete,
        [EnumMember(Value = "record_modified")]
        RecordModified
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Alkymi;

    public partial class WorkflowManagedActions
    {
        public AlkymiActions Alkymi(string connectionId) => new AlkymiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AlkymiTriggers Alkymi(string connectionId) => new AlkymiTriggers(connectionId);
    }
}