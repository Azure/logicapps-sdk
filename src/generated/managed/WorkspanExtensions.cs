//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workspan
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkspanActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<BulkloadOpportunityResponse> BulkloadOpportunity(Expression<Func<string>> integrationId, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<string>> columnDelimiter = null, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<object>> bulkloadOpportunityRequest = null)
        {
            var apiCallPath = "/bulk/v1/bulkload_opportunity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["integration_id"] = ExpressionConverter.Convert(integrationId);
            callPayload.Queries["content_type"] = Convert.ToString("csv");
            if (contentType != null)
                callPayload.Queries["content_type"] = ExpressionConverter.Convert(contentType);
            callPayload.Queries["column_delimiter"] = Convert.ToString(",");
            if (columnDelimiter != null)
                callPayload.Queries["column_delimiter"] = ExpressionConverter.Convert(columnDelimiter);
            callPayload.Headers["Content-Type"] = Convert.ToString("text/csv");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(bulkloadOpportunityRequest);
            return new ApiConnectionAction<BulkloadOpportunityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<BulkloadOpportunityResponse> BulkloadOpportunityFileAttachment(Expression<Func<string>> integrationId, Expression<Func<object>> file, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<bool>> hasHeaderRow = null)
        {
            var apiCallPath = "/bulk/v1/bulkload_opportunity/file";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["integration_id"] = ExpressionConverter.Convert(integrationId);
            callPayload.Queries["content_type"] = Convert.ToString("xlsx");
            if (contentType != null)
                callPayload.Queries["content_type"] = ExpressionConverter.Convert(contentType);
            callPayload.Queries["has_header_row"] = Convert.ToString(true);
            if (hasHeaderRow != null)
                callPayload.Queries["has_header_row"] = ExpressionConverter.Convert(hasHeaderRow);
            return new ApiConnectionAction<BulkloadOpportunityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<BulkloadResponse> BulkloadData(Expression<Func<string>> integrationId, Expression<Func<dataFormatInput>> dataFormat = null, Expression<Func<string>> columnDelimiter = null, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<object>> bulkloadRequest = null)
        {
            var apiCallPath = "/bulk/v1/bulkload";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["integration_id"] = ExpressionConverter.Convert(integrationId);
            callPayload.Queries["data_format"] = Convert.ToString("csv");
            if (dataFormat != null)
                callPayload.Queries["data_format"] = ExpressionConverter.Convert(dataFormat);
            callPayload.Queries["column_delimiter"] = Convert.ToString(",");
            if (columnDelimiter != null)
                callPayload.Queries["column_delimiter"] = ExpressionConverter.Convert(columnDelimiter);
            callPayload.Headers["Content-Type"] = Convert.ToString("text/csv");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(bulkloadRequest);
            return new ApiConnectionAction<BulkloadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<BulkloadResponse> BulkloadDataFileAttachment(Expression<Func<string>> integrationId, Expression<Func<object>> file, Expression<Func<dataFormatInput>> dataFormat = null)
        {
            var apiCallPath = "/bulk/v1/bulkload/file";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["integration_id"] = ExpressionConverter.Convert(integrationId);
            callPayload.Queries["data_format"] = Convert.ToString("xlsx");
            if (dataFormat != null)
                callPayload.Queries["data_format"] = ExpressionConverter.Convert(dataFormat);
            return new ApiConnectionAction<BulkloadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<BulkloadStatusResponse> GetBulkloadStatus(Expression<Func<string>> integrationId, Expression<Func<string>> executionId, Expression<Func<bool>> includeErrors = null, Expression<Func<double>> maxErrors = null)
        {
            var apiCallPath = String.Format("/bulk/v1/status/{0}", ExpressionConverter.ConvertWithUrlEncoding(integrationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["execution_id"] = ExpressionConverter.Convert(executionId);
            callPayload.Queries["include_errors"] = Convert.ToString(true);
            if (includeErrors != null)
                callPayload.Queries["include_errors"] = ExpressionConverter.Convert(includeErrors);
            callPayload.Queries["max_errors"] = Convert.ToString(5);
            if (maxErrors != null)
                callPayload.Queries["max_errors"] = ExpressionConverter.Convert(maxErrors);
            return new ApiConnectionAction<BulkloadStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<GetExternalIdResponse> GetExternalId(Expression<Func<string>> objectId)
        {
            var apiCallPath = String.Format("/app/v1/object/{0}/external_id", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetExternalIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<ExternalIdResponse> UpdateExternalId(Expression<Func<string>> objectId, Expression<Func<string>> requestBodyexternalId, Expression<Func<string>> requestBodyfieldName = null)
        {
            var apiCallPath = String.Format("/app/v1/object/{0}/external_id", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            if (requestBodyfieldName != null)
            {
                requestBody["field_name"] = ExpressionConverter.ConvertO(requestBodyfieldName);
                requestBodypropCount++;
            }

            requestBodypropCount++;
            requestBody["external_id"] = ExpressionConverter.ConvertO(requestBodyexternalId);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<ExternalIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<AuditResponse> ObjectAudit(Expression<Func<auditRequestBodyfieldNameInput>> auditRequestBodyfieldName, Expression<Func<auditRequestBodystatusCodeInput>> auditRequestBodystatusCode, Expression<Func<string>> auditRequestBodymessage, Expression<Func<string>> objectId, Expression<Func<string>> auditRequestBodyintegrationId = null, Expression<Func<string>> auditRequestBodyexternalId = null)
        {
            var apiCallPath = String.Format("/app/v1/object/{0}/audit", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var auditRequestBody = new JObject();
            var auditRequestBodypropCount = 0;
            auditRequestBodypropCount++;
            auditRequestBody["field_name"] = ExpressionConverter.ConvertO(auditRequestBodyfieldName);
            if (auditRequestBodyintegrationId != null)
            {
                auditRequestBody["integration_id"] = ExpressionConverter.ConvertO(auditRequestBodyintegrationId);
                auditRequestBodypropCount++;
            }

            if (auditRequestBodyexternalId != null)
            {
                auditRequestBody["external_id"] = ExpressionConverter.ConvertO(auditRequestBodyexternalId);
                auditRequestBodypropCount++;
            }

            auditRequestBodypropCount++;
            auditRequestBody["status_code"] = ExpressionConverter.ConvertO(auditRequestBodystatusCode);
            auditRequestBodypropCount++;
            auditRequestBody["message"] = ExpressionConverter.ConvertO(auditRequestBodymessage);
            if (auditRequestBodypropCount > 0)
            {
                callPayload.Body = auditRequestBody;
            }

            return new ApiConnectionAction<AuditResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<GetReportListResponse> GetReportList(Expression<Func<int>> bodypagenumber = null, Expression<Func<int>> bodypagesize = null)
        {
            var apiCallPath = "/report/v1/list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var pageObject = new JObject();
            var pageObjectpropCount = 0;
            if (bodypagenumber != null)
            {
                pageObject["number"] = ExpressionConverter.ConvertO(bodypagenumber);
                pageObjectpropCount++;
            }

            if (bodypagesize != null)
            {
                pageObject["size"] = ExpressionConverter.ConvertO(bodypagesize);
                pageObjectpropCount++;
            }

            if (pageObjectpropCount > 0)
            {
                body["page"] = pageObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetReportListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<ReportDataResponse> GetReportData(Expression<Func<int>> reportId, Expression<Func<int>> requestBodypagenumber, Expression<Func<int>> requestBodypagesize, Expression<Func<ReportFieldFilter[]>> requestBodyfiltersfieldFilters = null, Expression<Func<requestBodyfiltersopInput>> requestBodyfiltersop = null)
        {
            var apiCallPath = String.Format("/report/v1/{0}/data", ExpressionConverter.ConvertWithUrlEncoding(reportId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            var filtersObject = new JObject();
            var filtersObjectpropCount = 0;
            if (requestBodyfiltersfieldFilters != null)
            {
                filtersObject["fieldFilters"] = ExpressionConverter.ConvertO(requestBodyfiltersfieldFilters);
                filtersObjectpropCount++;
            }

            if (requestBodyfiltersop != null)
            {
                filtersObject["op"] = ExpressionConverter.ConvertO(requestBodyfiltersop);
                filtersObjectpropCount++;
            }

            if (filtersObjectpropCount > 0)
            {
                requestBody["filters"] = filtersObject;
                requestBodypropCount++;
            }

            var pageObject = new JObject();
            var pageObjectpropCount = 0;
            pageObjectpropCount++;
            pageObject["number"] = ExpressionConverter.ConvertO(requestBodypagenumber);
            pageObjectpropCount++;
            pageObject["size"] = ExpressionConverter.ConvertO(requestBodypagesize);
            if (pageObjectpropCount > 0)
            {
                requestBody["page"] = pageObject;
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<ReportDataResponse>(callPayload);
        }
    }

    public class WorkspanTriggers([ConnectionName] string connectionId)
    {
    }

    public class BulkloadOpportunityResponse
    {
        [JsonProperty("integration_id")]
        public string IntegrationId { get; set; }

        [JsonProperty("execution_id")]
        public string ExecutionId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public enum contentTypeInput
    {
        [EnumMember(Value = "text/csv")]
        TextCsv,
        [EnumMember(Value = "application/json")]
        ApplicationJson
    }

    public class BulkloadResponse
    {
        [JsonProperty("integration_id")]
        public string IntegrationId { get; set; }

        [JsonProperty("execution_id")]
        public string ExecutionId { get; set; }

        [JsonProperty("data_format")]
        public string DataFormat { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public enum dataFormatInput
    {
        [EnumMember(Value = "xlsx")]
        Xlsx,
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "json")]
        Json
    }

    public class BulkloadStatusResponse
    {
        [JsonProperty("integration_id")]
        public string IntegrationId { get; set; }

        [JsonProperty("execution_id")]
        public string ExecutionId { get; set; }

        [JsonProperty("status")]
        public BulkloadStatusResponseStatusType Status { get; set; }

        [JsonProperty("succcess_count")]
        public double SucccessCount { get; set; }

        [JsonProperty("error_count")]
        public double ErrorCount { get; set; }

        [JsonProperty("input_count")]
        public double InputCount { get; set; }

        [JsonProperty("skip_count")]
        public double SkipCount { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("include_errors")]
        public bool IncludeErrors { get; set; }

        [JsonProperty("errors")]
        public BulkloadStatusResponseErrorsTypeItem[] Errors { get; set; }
    }

    public enum BulkloadStatusResponseStatusType
    {
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "completed")]
        Completed
    }

    public class BulkloadStatusResponseErrorsTypeItem
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("data_row")]
        public string DataRow { get; set; }
    }

    public class GetExternalIdResponse
    {
        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("external_ids")]
        public GetExternalIdResponseExternalIdsTypeItem[] ExternalIds { get; set; }
    }

    public class GetExternalIdResponseExternalIdsTypeItem
    {
        [JsonProperty("field_name")]
        public string FieldName { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }

    public class ExternalIdResponse
    {
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("field_name")]
        public string FieldName { get; set; }
    }

    public class AuditResponse
    {
        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("field_name")]
        public string FieldName { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }
    }

    public enum auditRequestBodyfieldNameInput
    {
        [EnumMember(Value = "partner_center.integration_status")]
        PartnerCenterIntegrationStatus
    }

    public enum auditRequestBodystatusCodeInput
    {
        SCHEDULED,
        [EnumMember(Value = "CREATE_FAILED")]
        CREATEFAILED,
        [EnumMember(Value = "UPDATE_FAILED")]
        UPDATEFAILED,
        LINKED
    }

    public class GetReportListResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ReportDataResponse
    {
        [JsonProperty("endOfList")]
        public bool EndOfList { get; set; }

        [JsonProperty("results")]
        public JToken[] Results { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class ReportFieldFilter
    {
        [JsonProperty("colId")]
        public string ColId { get; set; }

        [JsonProperty("filter")]
        public ReportFilter Filter { get; set; }

        [JsonProperty("type")]
        public ReportFieldFilterTypeType Type { get; set; }
    }

    public class ReportFilter
    {
        [JsonProperty("negate")]
        public bool Negate { get; set; }

        [JsonProperty("op")]
        public ReportFilterOpType Op { get; set; }
    }

    public enum ReportFilterOpType
    {
        [EnumMember(Value = "EQUAL_TO")]
        EQUALTO,
        [EnumMember(Value = "IS_EMPTY")]
        ISEMPTY,
        CONTAIN,
        [EnumMember(Value = "START_WITH")]
        STARTWITH,
        [EnumMember(Value = "END_WITH")]
        ENDWITH,
        IN,
        [EnumMember(Value = "GREATER_THAN")]
        GREATERTHAN,
        [EnumMember(Value = "LESS_THAN")]
        LESSTHAN,
        [EnumMember(Value = "GREATER_THAN_OR_EQUAL_TO")]
        GREATERTHANOREQUALTO,
        [EnumMember(Value = "LESS_THAN_OR_EQUAL_TO")]
        LESSTHANOREQUALTO,
        BETWEEN,
        OFFSET
    }

    public enum ReportFieldFilterTypeType
    {
        TEXT,
        [EnumMember(Value = "TEXT_REPEATED")]
        TEXTREPEATED,
        [EnumMember(Value = "TEXT_PG_ARRAY")]
        TEXTPGARRAY,
        BOOLEAN,
        NUMBER,
        DECIMAL,
        DATE,
        [EnumMember(Value = "DATE_OFFSET")]
        DATEOFFSET,
        [EnumMember(Value = "DATE_TIME")]
        DATETIME,
        [EnumMember(Value = "DATE_TIME_OFFSET")]
        DATETIMEOFFSET,
        CURRENCY
    }

    public enum requestBodyfiltersopInput
    {
        AND,
        OR
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workspan;

    public partial class WorkflowManagedActions
    {
        public WorkspanActions Workspan(string connectionId) => new WorkspanActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorkspanTriggers Workspan(string connectionId) => new WorkspanTriggers(connectionId);
    }
}