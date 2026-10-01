//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtimport
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudrenxtimportActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiImportJobSummaryCollection> ListImportJobs([WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/import/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (continuationToken != null)
                    callPayload.Queries["continuation_token"] = SourceExpressionConverter.ConvertO(continuationToken);
                return callPayload;
            }

            return new ApiConnectionAction<ImportApiImportJobSummaryCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiCreateImportJobResponse> CreateImportJob([WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyheaderRow = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/import/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyheaderRow != null)
                {
                    body["header_row"] = SourceExpressionConverter.ConvertToken(bodyheaderRow);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImportApiCreateImportJobResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiImportJob> GetImportJob([WorkflowExpression] Func<string> jobId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/import/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ImportApiImportJob>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IWorkflowAction DeleteImportJob([WorkflowExpression] Func<string> jobId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/import/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IWorkflowAction EditImportJob([WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<string> bodyfileName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/import/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiImportJobExceptionFileDownloadInfo> GetImportJobExceptionFileDownloadUri([WorkflowExpression] Func<string> jobId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/import/jobs/{0}/exceptionfiledownloadinfo", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ImportApiImportJobExceptionFileDownloadInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiImportJobFileUploadInfo> GetImportJobFileUploadUri([WorkflowExpression] Func<string> jobId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/import/jobs/{0}/uploaduri", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ImportApiImportJobFileUploadInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiStartImportJobResponse> StartImportJob([WorkflowExpression] Func<string> bodyjobId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/import/jobs/start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["job_id"] = SourceExpressionConverter.ConvertToken(bodyjobId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImportApiStartImportJobResponse>(BuildSourceInput);
        }
    }

    public class BlackbaudrenxtimportTriggers([ConnectionName] string connectionId)
    {
    }

    public class ImportApiImportJobSummaryCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("continuation_token")]
        public string ContinuationToken { get; set; }

        [JsonProperty("jobs")]
        public ImportApiImportJobSummary[] Jobs { get; set; }
    }

    public class ImportApiImportJobSummary
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("start_date")]
        public string DateStarted { get; set; }

        [JsonProperty("end_date")]
        public string DateCompleted { get; set; }

        [JsonProperty("run_duration")]
        public int RunDuration { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("rows_processed")]
        public int RowsProcessed { get; set; }

        [JsonProperty("rows_committed")]
        public int RowsCommitted { get; set; }

        [JsonProperty("rows_rejected")]
        public int RowsRejected { get; set; }

        [JsonProperty("exception_count")]
        public int ExceptionCount { get; set; }

        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        [JsonProperty("status")]
        public ImportApiImportJobSummaryStatusType Status { get; set; }

        [JsonProperty("added_by")]
        public string AddedByID { get; set; }

        [JsonProperty("date_added")]
        public string DateCreated { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ImportApiImportJobSummaryStatusType
    {
        Pending,
        Enqueued,
        Starting,
        Running,
        Completed,
        CompletedWithExceptions,
        Failed
    }

    public enum statusInput
    {
        Pending,
        Enqueued,
        Starting,
        Running,
        Completed,
        CompletedWithExceptions,
        Failed
    }

    public class ImportApiCreateImportJobResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("file_upload_uri")]
        public string FileUploadURI { get; set; }

        [JsonProperty("field_mappings")]
        public ImportApiFieldMapping[] FieldMappings { get; set; }

        [JsonProperty("mapping_validation_messages")]
        public ImportApiMappingValidationMessage[] MappingValidationMessages { get; set; }
    }

    public class ImportApiFieldMapping
    {
        [JsonProperty("source_field")]
        public string SourceField { get; set; }

        [JsonProperty("target_field")]
        public string TargetField { get; set; }
    }

    public class ImportApiMappingValidationMessage
    {
        [JsonProperty("record_mapping")]
        public string RecordMapping { get; set; }

        [JsonProperty("target_field")]
        public string TargetField { get; set; }

        [JsonProperty("message_type")]
        public ImportApiMappingValidationMessageMessageTypeType MessageType { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("file_fields")]
        public string[] FileFields { get; set; }
    }

    public enum ImportApiMappingValidationMessageMessageTypeType
    {
        Error,
        Warning
    }

    public class ImportApiImportJob
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("start_date")]
        public string DateStarted { get; set; }

        [JsonProperty("end_date")]
        public string DateCompleted { get; set; }

        [JsonProperty("run_duration")]
        public int RunDuration { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("rows_processed")]
        public int RowsProcessed { get; set; }

        [JsonProperty("rows_committed")]
        public int RowsCommitted { get; set; }

        [JsonProperty("rows_rejected")]
        public int RowsRejected { get; set; }

        [JsonProperty("exception_count")]
        public int ExceptionCount { get; set; }

        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        [JsonProperty("status")]
        public ImportApiImportJobStatusType Status { get; set; }

        [JsonProperty("added_by")]
        public string AddedByID { get; set; }

        [JsonProperty("date_added")]
        public string DateCreated { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ImportApiImportJobStatusType
    {
        Pending,
        Enqueued,
        Starting,
        Running,
        Completed,
        CompletedWithExceptions,
        Failed
    }

    public class ImportApiImportJobExceptionFileDownloadInfo
    {
        [JsonProperty("file_download_uri")]
        public string FileDownloadURI { get; set; }
    }

    public class ImportApiImportJobFileUploadInfo
    {
        [JsonProperty("file_upload_uri")]
        public string FileUploadURI { get; set; }
    }

    public class ImportApiStartImportJobResponse
    {
        [JsonProperty("status")]
        public ImportApiStartImportJobResponseStatusType Status { get; set; }
    }

    public enum ImportApiStartImportJobResponseStatusType
    {
        Pending,
        Enqueued,
        Starting,
        Running,
        Completed,
        CompletedWithExceptions,
        Failed
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtimport;

    public partial class WorkflowManagedActions
    {
        public BlackbaudrenxtimportActions Blackbaudrenxtimport(string connectionId) => new BlackbaudrenxtimportActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudrenxtimportTriggers Blackbaudrenxtimport(string connectionId) => new BlackbaudrenxtimportTriggers(connectionId);
    }
}