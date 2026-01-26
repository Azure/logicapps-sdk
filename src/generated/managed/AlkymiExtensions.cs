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
            var apiCallPath = "/api/v2/datasets/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PaginatedDatasetList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedDatasetList> DatasetsRetrieve(Expression<Func<string>> uuid)
        {
            var apiCallPath = String.Format("/api/v2/datasets/{0}/", ExpressionConverter.ConvertWithUrlEncoding(uuid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PaginatedDatasetList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IWorkflowAction DocumentsCreate(Expression<Func<object>> file, Expression<Func<bool>> removed = null, Expression<Func<string>> dataset = null, Expression<Func<string>> subject = null, Expression<Func<string>> sender = null, Expression<Func<string>> folder = null, Expression<Func<string[]>> targets = null)
        {
            var apiCallPath = "/api/v2/documents/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<DocumentsListResponse> DocumentsList()
        {
            var apiCallPath = "/api/v2/documents/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<Document> DocumentsRetrieve(Expression<Func<string>> uuid)
        {
            var apiCallPath = String.Format("/api/v2/documents/{0}/", ExpressionConverter.ConvertWithUrlEncoding(uuid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Document>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<string> DocumentsDownloadOriginalRetrieve(Expression<Func<string>> uuid)
        {
            var apiCallPath = String.Format("/api/v2/documents/{0}/download_original/", ExpressionConverter.ConvertWithUrlEncoding(uuid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<string> DocumentsDownloadPdfRetrieve(Expression<Func<string>> uuid)
        {
            var apiCallPath = String.Format("/api/v2/documents/{0}/download_pdf/", ExpressionConverter.ConvertWithUrlEncoding(uuid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedExecutionList> ExecutionsList(Expression<Func<documentStatusInputItem[]>> documentStatus = null)
        {
            var apiCallPath = "/api/v2/executions/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (documentStatus != null)
                callPayload.Queries["document_status"] = ExpressionConverter.Convert(documentStatus);
            return new ApiConnectionAction<PaginatedExecutionList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<Execution> ExecutionsRetrieve(Expression<Func<string>> uuid)
        {
            var apiCallPath = String.Format("/api/v2/executions/{0}/", ExpressionConverter.ConvertWithUrlEncoding(uuid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Execution>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedPipelineConfigurationList> PipelinesList()
        {
            var apiCallPath = "/api/v2/pipelines/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PaginatedPipelineConfigurationList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PipelineConfiguration> PipelinesRetrieve(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/api/v2/pipelines/{0}/", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PipelineConfiguration>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<PaginatedRecordList> RecordsList(Expression<Func<string>> dataset = null, Expression<Func<documentStatusInputItem[]>> documentStatus = null, Expression<Func<string>> pipeline = null, Expression<Func<bool>> removed = null, Expression<Func<bool>> reviewed = null, Expression<Func<string>> schema = null)
        {
            var apiCallPath = "/api/v2/records/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (dataset != null)
                callPayload.Queries["dataset"] = ExpressionConverter.Convert(dataset);
            if (documentStatus != null)
                callPayload.Queries["document_status"] = ExpressionConverter.Convert(documentStatus);
            if (pipeline != null)
                callPayload.Queries["pipeline"] = ExpressionConverter.Convert(pipeline);
            if (removed != null)
                callPayload.Queries["removed"] = ExpressionConverter.Convert(removed);
            if (reviewed != null)
                callPayload.Queries["reviewed"] = ExpressionConverter.Convert(reviewed);
            if (schema != null)
                callPayload.Queries["schema"] = ExpressionConverter.Convert(schema);
            return new ApiConnectionAction<PaginatedRecordList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alkymi")]
        public IBodyWorkflowAction<Record> RecordsRetrieve(Expression<Func<string>> uuid)
        {
            var apiCallPath = String.Format("/api/v2/records/{0}/", ExpressionConverter.ConvertWithUrlEncoding(uuid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Record>(callPayload);
        }
    }

    public class AlkymiTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHookCreatedResponse> EventListener(Expression<Func<string>> bodydisplayName = null, Expression<Func<bodyeventsInputItem[]>> bodyevents = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/v2/webhooks/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["target"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodydisplayName != null)
            {
                body["display_name"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            if (bodyevents != null)
            {
                body["events"] = ExpressionConverter.ConvertO(bodyevents);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebHookCreatedResponse>(callPayload, triggerName, recurrence);
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