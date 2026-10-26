//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Alkymi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlkymiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedDatasetList, ApiConnectionActionConfiguration> DatasetsList()
        {
            return new DeferredBodyAction<PaginatedDatasetList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/datasets/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PaginatedDatasetList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedDatasetList, ApiConnectionActionConfiguration> DatasetsRetrieve(Expression<Func<string>> uuid)
        {
            var __workflow_uuid = WorkflowExpression.Compile(uuid, nameof(uuid), required: true);
            return new DeferredBodyAction<PaginatedDatasetList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/datasets/{0}/", __workflow_uuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PaginatedDatasetList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<DocumentsListResponse, ApiConnectionActionConfiguration> DocumentsList()
        {
            return new DeferredBodyAction<DocumentsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/documents/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<Document, ApiConnectionActionConfiguration> DocumentsRetrieve(Expression<Func<string>> uuid)
        {
            var __workflow_uuid = WorkflowExpression.Compile(uuid, nameof(uuid), required: true);
            return new DeferredBodyAction<Document, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/documents/{0}/", __workflow_uuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Document>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DocumentsDownloadOriginalRetrieve(Expression<Func<string>> uuid)
        {
            var __workflow_uuid = WorkflowExpression.Compile(uuid, nameof(uuid), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/documents/{0}/download_original/", __workflow_uuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DocumentsDownloadPdfRetrieve(Expression<Func<string>> uuid)
        {
            var __workflow_uuid = WorkflowExpression.Compile(uuid, nameof(uuid), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/documents/{0}/download_pdf/", __workflow_uuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedExecutionList, ApiConnectionActionConfiguration> ExecutionsList(Expression<Func<documentStatusInputItem[]>> documentStatus = null)
        {
            var __workflow_documentStatus = WorkflowExpression.Compile(documentStatus, nameof(documentStatus), required: false);
            return new DeferredBodyAction<PaginatedExecutionList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/executions/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_documentStatus != null)
                    callPayload.Queries["document_status"] = ExpressionConverter.Convert(__workflow_documentStatus);
                return new ApiConnectionAction<PaginatedExecutionList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<Execution, ApiConnectionActionConfiguration> ExecutionsRetrieve(Expression<Func<string>> uuid)
        {
            var __workflow_uuid = WorkflowExpression.Compile(uuid, nameof(uuid), required: true);
            return new DeferredBodyAction<Execution, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/executions/{0}/", __workflow_uuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Execution>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedPipelineConfigurationList, ApiConnectionActionConfiguration> PipelinesList()
        {
            return new DeferredBodyAction<PaginatedPipelineConfigurationList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/pipelines/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PaginatedPipelineConfigurationList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PipelineConfiguration, ApiConnectionActionConfiguration> PipelinesRetrieve(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<PipelineConfiguration, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/pipelines/{0}/", __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PipelineConfiguration>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedRecordList, ApiConnectionActionConfiguration> RecordsList(Expression<Func<string>> dataset = null, Expression<Func<documentStatusInputItem[]>> documentStatus = null, Expression<Func<string>> pipeline = null, Expression<Func<bool>> removed = null, Expression<Func<bool>> reviewed = null, Expression<Func<string>> schema = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: false);
            var __workflow_documentStatus = WorkflowExpression.Compile(documentStatus, nameof(documentStatus), required: false);
            var __workflow_pipeline = WorkflowExpression.Compile(pipeline, nameof(pipeline), required: false);
            var __workflow_removed = WorkflowExpression.Compile(removed, nameof(removed), required: false);
            var __workflow_reviewed = WorkflowExpression.Compile(reviewed, nameof(reviewed), required: false);
            var __workflow_schema = WorkflowExpression.Compile(schema, nameof(schema), required: false);
            return new DeferredBodyAction<PaginatedRecordList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/records/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(__workflow_dataset);
                if (__workflow_documentStatus != null)
                    callPayload.Queries["document_status"] = ExpressionConverter.Convert(__workflow_documentStatus);
                if (__workflow_pipeline != null)
                    callPayload.Queries["pipeline"] = ExpressionConverter.Convert(__workflow_pipeline);
                if (__workflow_removed != null)
                    callPayload.Queries["removed"] = ExpressionConverter.Convert(__workflow_removed);
                if (__workflow_reviewed != null)
                    callPayload.Queries["reviewed"] = ExpressionConverter.Convert(__workflow_reviewed);
                if (__workflow_schema != null)
                    callPayload.Queries["schema"] = ExpressionConverter.Convert(__workflow_schema);
                return new ApiConnectionAction<PaginatedRecordList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<Record, ApiConnectionActionConfiguration> RecordsRetrieve(Expression<Func<string>> uuid)
        {
            var __workflow_uuid = WorkflowExpression.Compile(uuid, nameof(uuid), required: true);
            return new DeferredBodyAction<Record, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/records/{0}/", __workflow_uuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Record>(callPayload);
            });
        }
    }

    public class AlkymiTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHookCreatedResponse, ApiConnectionTriggerConfiguration> EventListener(Expression<Func<EventListenerInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyTrigger<WebHookCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/webhooks/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebHookCreatedResponse>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class EventListenerInput
    {
        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Target { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("events")]
        public EventListenerInputEventsTypeItem[] Events { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventListenerInputEventsTypeItem
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