//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtreport
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudrenxtreportActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtreport")]
        public IBodyWorkflowAction<ReportApiReportInstanceCollection, ApiConnectionActionConfiguration> ListReportIntances(Expression<Func<int>> reportType, Expression<Func<bool>> onlyOwnedReports = null)
        {
            var __workflow_reportType = WorkflowExpression.Compile(reportType, nameof(reportType), required: true);
            var __workflow_onlyOwnedReports = WorkflowExpression.Compile(onlyOwnedReports, nameof(onlyOwnedReports), required: false);
            return new DeferredBodyAction<ReportApiReportInstanceCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/rxr-mngmt/reports/{0}/reportinstances", __workflow_reportType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_onlyOwnedReports != null)
                    callPayload.Queries["only_owned_reports"] = ExpressionConverter.Convert(__workflow_onlyOwnedReports);
                return new ApiConnectionAction<ReportApiReportInstanceCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtreport")]
        public IBodyWorkflowAction<ReportApiExecuteReportResponse, ApiConnectionActionConfiguration> StartReportExecutionJob(Expression<Func<int>> bodyreportType, Expression<Func<int>> bodyexecutionParametersreportInstance = null, Expression<Func<bodyexecutionParametersoutputFormatInput>> bodyexecutionParametersoutputFormat = null, Expression<Func<int>> bodyexecutionParameterstimeZoneOffset = null, Expression<Func<bodyexecutionParametersanonymousOptionInput>> bodyexecutionParametersanonymousOption = null)
        {
            var __workflow_bodyreportType = WorkflowExpression.Compile(bodyreportType, nameof(bodyreportType), required: true);
            var __workflow_bodyexecutionParametersreportInstance = WorkflowExpression.Compile(bodyexecutionParametersreportInstance, nameof(bodyexecutionParametersreportInstance), required: false);
            var __workflow_bodyexecutionParametersoutputFormat = WorkflowExpression.Compile(bodyexecutionParametersoutputFormat, nameof(bodyexecutionParametersoutputFormat), required: false);
            var __workflow_bodyexecutionParameterstimeZoneOffset = WorkflowExpression.Compile(bodyexecutionParameterstimeZoneOffset, nameof(bodyexecutionParameterstimeZoneOffset), required: false);
            var __workflow_bodyexecutionParametersanonymousOption = WorkflowExpression.Compile(bodyexecutionParametersanonymousOption, nameof(bodyexecutionParametersanonymousOption), required: false);
            return new DeferredBodyAction<ReportApiExecuteReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/rxr-mngmt/reports/executereport";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["report_type_id"] = ExpressionConverter.ConvertO(__workflow_bodyreportType);
                var executionParametersObject = new JObject();
                var executionParametersObjectpropCount = 0;
                if (__workflow_bodyexecutionParametersreportInstance != null)
                {
                    executionParametersObject["report_instance_id"] = ExpressionConverter.ConvertO(__workflow_bodyexecutionParametersreportInstance);
                    executionParametersObjectpropCount++;
                }

                if (__workflow_bodyexecutionParametersoutputFormat != null)
                {
                    if (__workflow_bodyexecutionParametersoutputFormat != null)
                    {
                        executionParametersObject["output_format"] = ExpressionConverter.ConvertO(__workflow_bodyexecutionParametersoutputFormat);
                        executionParametersObjectpropCount++;
                    }

                    executionParametersObjectpropCount++;
                }
                else
                {
                    executionParametersObject["output_format"] = "CSV";
                    executionParametersObjectpropCount++;
                }

                if (__workflow_bodyexecutionParameterstimeZoneOffset != null)
                {
                    executionParametersObject["time_zone_offset_in_minutes"] = ExpressionConverter.ConvertO(__workflow_bodyexecutionParameterstimeZoneOffset);
                    executionParametersObjectpropCount++;
                }

                if (__workflow_bodyexecutionParametersanonymousOption != null)
                {
                    executionParametersObject["anonymous_option"] = ExpressionConverter.ConvertO(__workflow_bodyexecutionParametersanonymousOption);
                    executionParametersObjectpropCount++;
                }

                if (executionParametersObjectpropCount > 0)
                {
                    body["execution_parameters"] = executionParametersObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReportApiExecuteReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtreport")]
        public IBodyWorkflowAction<ReportApiReportJobCollection, ApiConnectionActionConfiguration> ListReportJobs()
        {
            return new DeferredBodyAction<ReportApiReportJobCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/rxr-mngmt/reports/reportjobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ReportApiReportJobCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtreport")]
        public IBodyWorkflowAction<ReportApiReportExecutionJob, ApiConnectionActionConfiguration> GetReportJobStatus(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<ReportApiReportExecutionJob, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/rxr-mngmt/reports/reportjobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ReportApiReportExecutionJob>(callPayload);
            });
        }
    }

    public class BlackbaudrenxtreportTriggers([ConnectionName] string connectionId)
    {
    }

    public class ReportApiReportInstanceCollection
    {
        [JsonProperty("items")]
        public ReportApiReportInstance[] Items { get; set; }
    }

    public class ReportApiReportInstance
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("others_may_modify")]
        public bool OthersCanModify { get; set; }

        [JsonProperty("others_may_execute")]
        public bool OthersCanExecute { get; set; }

        [JsonProperty("date_last_run")]
        public string LastRun { get; set; }

        [JsonProperty("processing_time")]
        public string ProcessingTime { get; set; }

        [JsonProperty("date_added")]
        public string DateCreated { get; set; }

        [JsonProperty("added_by")]
        public string CreatedByUserId { get; set; }

        [JsonProperty("added_by_user_name")]
        public string CreatedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateChanged { get; set; }

        [JsonProperty("modified_by")]
        public string ChangedByUserId { get; set; }

        [JsonProperty("modified_by_user_name")]
        public string ChangedBy { get; set; }
    }

    public class ReportApiExecuteReportResponse
    {
        [JsonProperty("job_ids")]
        public string[] JobIDs { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyexecutionParametersoutputFormatInput
    {
        PDF,
        CSV
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyexecutionParametersanonymousOptionInput
    {
        UseAnonymous,
        UseAsterisk
    }

    public class ReportApiReportJobCollection
    {
        [JsonProperty("items")]
        public ReportApiReportJob[] Items { get; set; }
    }

    public class ReportApiReportJob
    {
        [JsonProperty("job_id")]
        public string Id { get; set; }

        [JsonProperty("report_type_id")]
        public int ReportTypeId { get; set; }

        [JsonProperty("report_type_name")]
        public string ReportTypeName { get; set; }

        [JsonProperty("report_name")]
        public string ReportName { get; set; }

        [JsonProperty("report_view")]
        public ReportApiReportJobReportInstanceType ReportInstance { get; set; }

        [JsonProperty("status")]
        public ReportApiReportJobStatusType Status { get; set; }

        [JsonProperty("scheduled")]
        public bool IsScheduled { get; set; }

        [JsonProperty("output_format")]
        public ReportApiReportJobOutputFormatType OutputFormat { get; set; }

        [JsonProperty("total_processing_time")]
        public string TotalProcessingTime { get; set; }

        [JsonProperty("total_processing_time_caption")]
        public string TotalProcessingTimeCaption { get; set; }

        [JsonProperty("date_added")]
        public string DateCreated { get; set; }

        [JsonProperty("date_completed")]
        public string DateCompleted { get; set; }
    }

    public class ReportApiReportJobReportInstanceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReportApiReportJobStatusType
    {
        Created,
        DataProcessing,
        DataProcessed,
        PdfProcessing,
        PdfProcessed,
        Completed,
        Canceled,
        Failed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReportApiReportJobOutputFormatType
    {
        PDF,
        CSV
    }

    public class ReportApiReportExecutionJob
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public ReportApiReportExecutionJobStatusType Status { get; set; }

        [JsonProperty("report_view")]
        public ReportApiReportExecutionJobReportInstanceType ReportInstance { get; set; }

        [JsonProperty("sas_uri")]
        public string ReportResultsURI { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReportApiReportExecutionJobStatusType
    {
        Created,
        DataProcessing,
        DataProcessed,
        PdfProcessing,
        PdfProcessed,
        Completed,
        Canceled,
        Failed
    }

    public class ReportApiReportExecutionJobReportInstanceType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtreport;

    public partial class WorkflowManagedActions
    {
        public BlackbaudrenxtreportActions Blackbaudrenxtreport(string connectionId) => new BlackbaudrenxtreportActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudrenxtreportTriggers Blackbaudrenxtreport(string connectionId) => new BlackbaudrenxtreportTriggers(connectionId);
    }
}