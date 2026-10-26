//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtimport
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudrenxtimportActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiImportJobSummaryCollection, ApiConnectionActionConfiguration> ListImportJobs(Expression<Func<statusInput>> status = null, Expression<Func<int>> limit = null, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<ImportApiImportJobSummaryCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/import/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuation_token"] = ExpressionConverter.Convert(__workflow_continuationToken);
                return new ApiConnectionAction<ImportApiImportJobSummaryCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiCreateImportJobResponse, ApiConnectionActionConfiguration> CreateImportJob(Expression<Func<CreateImportJobInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ImportApiCreateImportJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/import/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImportApiCreateImportJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiImportJob, ApiConnectionActionConfiguration> GetImportJob(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<ImportApiImportJob, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/import/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ImportApiImportJob>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteImportJob(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/import/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditImportJob(Expression<Func<string>> jobId, Expression<Func<EditImportJobInput>> body)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/import/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiImportJobExceptionFileDownloadInfo, ApiConnectionActionConfiguration> GetImportJobExceptionFileDownloadUri(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<ImportApiImportJobExceptionFileDownloadInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/import/jobs/{0}/exceptionfiledownloadinfo", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ImportApiImportJobExceptionFileDownloadInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiImportJobFileUploadInfo, ApiConnectionActionConfiguration> GetImportJobFileUploadUri(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<ImportApiImportJobFileUploadInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/import/jobs/{0}/uploaduri", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ImportApiImportJobFileUploadInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtimport")]
        public IBodyWorkflowAction<ImportApiStartImportJobResponse, ApiConnectionActionConfiguration> StartImportJob(Expression<Func<StartImportJobInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ImportApiStartImportJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/import/jobs/start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImportApiStartImportJobResponse>(callPayload);
            });
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
        public string Id { get; set; }

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
        public string AddedById { get; set; }

        [JsonProperty("date_added")]
        public string DateCreated { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string Id { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImportApiMappingValidationMessageMessageTypeType
    {
        Error,
        Warning
    }

    public class CreateImportJobInput
    {
        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("header_row")]
        public string HeaderRow { get; set; }
    }

    public class ImportApiImportJob
    {
        [JsonProperty("id")]
        public string Id { get; set; }

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
        public string AddedById { get; set; }

        [JsonProperty("date_added")]
        public string DateCreated { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class EditImportJobInput
    {
        [JsonProperty("file_name")]
        public string FileName { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class StartImportJobInput
    {
        [JsonProperty("job_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JobId { get; set; }
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