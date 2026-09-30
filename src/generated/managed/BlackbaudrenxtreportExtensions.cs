//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtreport
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudrenxtreportActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtreport")]
        public IBodyWorkflowAction<ReportApiReportInstanceCollection> ListReportIntances([WorkflowExpression] Func<int> reportType, [WorkflowExpression] Func<bool> onlyOwnedReports = null)
        {
            SourceExpression.Validate(reportType, nameof(reportType), required: true);
            SourceExpression.Validate(onlyOwnedReports, nameof(onlyOwnedReports), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/rxr-mngmt/reports/{0}/reportinstances", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(reportType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (onlyOwnedReports != null)
                    callPayload.Queries["only_owned_reports"] = SourceExpressionConverter.ConvertO(onlyOwnedReports);
                return callPayload;
            }

            return new ApiConnectionAction<ReportApiReportInstanceCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtreport")]
        public IBodyWorkflowAction<ReportApiExecuteReportResponse> StartReportExecutionJob([WorkflowExpression] Func<int> bodyreportType, [WorkflowExpression] Func<int> bodyexecutionParametersreportInstance = null, [WorkflowExpression] Func<bodyexecutionParametersoutputFormatInput> bodyexecutionParametersoutputFormat = null, [WorkflowExpression] Func<int> bodyexecutionParameterstimeZoneOffset = null, [WorkflowExpression] Func<bodyexecutionParametersanonymousOptionInput> bodyexecutionParametersanonymousOption = null)
        {
            SourceExpression.Validate(bodyreportType, nameof(bodyreportType), required: true);
            SourceExpression.Validate(bodyexecutionParametersreportInstance, nameof(bodyexecutionParametersreportInstance), required: false);
            SourceExpression.Validate(bodyexecutionParametersoutputFormat, nameof(bodyexecutionParametersoutputFormat), required: false);
            SourceExpression.Validate(bodyexecutionParameterstimeZoneOffset, nameof(bodyexecutionParameterstimeZoneOffset), required: false);
            SourceExpression.Validate(bodyexecutionParametersanonymousOption, nameof(bodyexecutionParametersanonymousOption), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rxr-mngmt/reports/executereport";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["report_type_id"] = SourceExpressionConverter.ConvertToken(bodyreportType);
                var executionParametersObject = new JObject();
                var executionParametersObjectpropCount = 0;
                if (bodyexecutionParametersreportInstance != null)
                {
                    executionParametersObject["report_instance_id"] = SourceExpressionConverter.ConvertToken(bodyexecutionParametersreportInstance);
                    executionParametersObjectpropCount++;
                }

                if (bodyexecutionParametersoutputFormat != null)
                {
                    if (bodyexecutionParametersoutputFormat != null)
                    {
                        executionParametersObject["output_format"] = SourceExpressionConverter.Convert(bodyexecutionParametersoutputFormat);
                        executionParametersObjectpropCount++;
                    }

                    executionParametersObjectpropCount++;
                }
                else
                {
                    executionParametersObject["output_format"] = "CSV";
                    executionParametersObjectpropCount++;
                }

                if (bodyexecutionParameterstimeZoneOffset != null)
                {
                    executionParametersObject["time_zone_offset_in_minutes"] = SourceExpressionConverter.ConvertToken(bodyexecutionParameterstimeZoneOffset);
                    executionParametersObjectpropCount++;
                }

                if (bodyexecutionParametersanonymousOption != null)
                {
                    executionParametersObject["anonymous_option"] = SourceExpressionConverter.Convert(bodyexecutionParametersanonymousOption);
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
                return callPayload;
            }

            return new ApiConnectionAction<ReportApiExecuteReportResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtreport")]
        public IBodyWorkflowAction<ReportApiReportJobCollection> ListReportJobs()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rxr-mngmt/reports/reportjobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ReportApiReportJobCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtreport")]
        public IBodyWorkflowAction<ReportApiReportExecutionJob> GetReportJobStatus([WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/rxr-mngmt/reports/reportjobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ReportApiReportExecutionJob>(BuildSourceInput);
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
        public string ID { get; set; }

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
        public string CreatedByUserID { get; set; }

        [JsonProperty("added_by_user_name")]
        public string CreatedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateChanged { get; set; }

        [JsonProperty("modified_by")]
        public string ChangedByUserID { get; set; }

        [JsonProperty("modified_by_user_name")]
        public string ChangedBy { get; set; }
    }

    public class ReportApiExecuteReportResponse
    {
        [JsonProperty("job_ids")]
        public string[] JobIDs { get; set; }
    }

    public enum bodyexecutionParametersoutputFormatInput
    {
        PDF,
        CSV
    }

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
        public string ID { get; set; }

        [JsonProperty("report_type_id")]
        public int ReportTypeID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

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

    public enum ReportApiReportJobOutputFormatType
    {
        PDF,
        CSV
    }

    public class ReportApiReportExecutionJob
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("status")]
        public ReportApiReportExecutionJobStatusType Status { get; set; }

        [JsonProperty("report_view")]
        public ReportApiReportExecutionJobReportInstanceType ReportInstance { get; set; }

        [JsonProperty("sas_uri")]
        public string ReportResultsURI { get; set; }
    }

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
        public int ID { get; set; }

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