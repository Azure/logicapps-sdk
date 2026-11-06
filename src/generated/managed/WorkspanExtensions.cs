//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workspan
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkspanActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<BulkloadOpportunityResponse, ApiConnectionActionConfiguration> BulkloadOpportunity(Expression<Func<string>> integrationId, Expression<Func<BulkloadOpportunityContentTypeInput>> contentType = null, Expression<Func<string>> columnDelimiter = null, Expression<Func<BulkloadDataContentTypeInput>> contentType2 = null, Expression<Func<object>> bulkloadOpportunityRequest = null)
        {
            var __workflow_integrationId = WorkflowExpression.Compile(integrationId, nameof(integrationId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_columnDelimiter = WorkflowExpression.Compile(columnDelimiter, nameof(columnDelimiter), required: false);
            var __workflow_contentType2 = WorkflowExpression.Compile(contentType2, nameof(contentType2), required: false);
            var __workflow_bulkloadOpportunityRequest = WorkflowExpression.Compile(bulkloadOpportunityRequest, nameof(bulkloadOpportunityRequest), required: false);
            return new DeferredBodyAction<BulkloadOpportunityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bulk/v1/bulkload_opportunity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["integration_id"] = ExpressionConverter.Convert(__workflow_integrationId);
                callPayload.Queries["content_type"] = Convert.ToString("csv");
                if (__workflow_contentType != null)
                    callPayload.Queries["content_type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Queries["column_delimiter"] = Convert.ToString(",");
                if (__workflow_columnDelimiter != null)
                    callPayload.Queries["column_delimiter"] = ExpressionConverter.Convert(__workflow_columnDelimiter);
                callPayload.Headers["Content-Type"] = Convert.ToString("text/csv");
                if (__workflow_contentType2 != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType2);
                if (__workflow_bulkloadOpportunityRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_bulkloadOpportunityRequest);
                return new ApiConnectionAction<BulkloadOpportunityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<BulkloadResponse, ApiConnectionActionConfiguration> BulkloadData(Expression<Func<string>> integrationId, Expression<Func<DataFormatInput>> dataFormat = null, Expression<Func<string>> columnDelimiter = null, Expression<Func<BulkloadDataContentTypeInput>> contentType = null, Expression<Func<object>> bulkloadRequest = null)
        {
            var __workflow_integrationId = WorkflowExpression.Compile(integrationId, nameof(integrationId), required: true);
            var __workflow_dataFormat = WorkflowExpression.Compile(dataFormat, nameof(dataFormat), required: false);
            var __workflow_columnDelimiter = WorkflowExpression.Compile(columnDelimiter, nameof(columnDelimiter), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_bulkloadRequest = WorkflowExpression.Compile(bulkloadRequest, nameof(bulkloadRequest), required: false);
            return new DeferredBodyAction<BulkloadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bulk/v1/bulkload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["integration_id"] = ExpressionConverter.Convert(__workflow_integrationId);
                callPayload.Queries["data_format"] = Convert.ToString("csv");
                if (__workflow_dataFormat != null)
                    callPayload.Queries["data_format"] = ExpressionConverter.Convert(__workflow_dataFormat);
                callPayload.Queries["column_delimiter"] = Convert.ToString(",");
                if (__workflow_columnDelimiter != null)
                    callPayload.Queries["column_delimiter"] = ExpressionConverter.Convert(__workflow_columnDelimiter);
                callPayload.Headers["Content-Type"] = Convert.ToString("text/csv");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_bulkloadRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_bulkloadRequest);
                return new ApiConnectionAction<BulkloadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<BulkloadStatusResponse, ApiConnectionActionConfiguration> GetBulkloadStatus(Expression<Func<string>> integrationId, Expression<Func<string>> executionId, Expression<Func<bool>> includeErrors = null, Expression<Func<double>> maxErrors = null)
        {
            var __workflow_integrationId = WorkflowExpression.Compile(integrationId, nameof(integrationId), required: true);
            var __workflow_executionId = WorkflowExpression.Compile(executionId, nameof(executionId), required: true);
            var __workflow_includeErrors = WorkflowExpression.Compile(includeErrors, nameof(includeErrors), required: false);
            var __workflow_maxErrors = WorkflowExpression.Compile(maxErrors, nameof(maxErrors), required: false);
            return new DeferredBodyAction<BulkloadStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bulk/v1/status/{0}", __workflow_integrationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["execution_id"] = ExpressionConverter.Convert(__workflow_executionId);
                callPayload.Queries["include_errors"] = Convert.ToString(true);
                if (__workflow_includeErrors != null)
                    callPayload.Queries["include_errors"] = ExpressionConverter.Convert(__workflow_includeErrors);
                callPayload.Queries["max_errors"] = Convert.ToString(5);
                if (__workflow_maxErrors != null)
                    callPayload.Queries["max_errors"] = ExpressionConverter.Convert(__workflow_maxErrors);
                return new ApiConnectionAction<BulkloadStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<GetExternalIdResponse, ApiConnectionActionConfiguration> GetExternalId(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<GetExternalIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/app/v1/object/{0}/external_id", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetExternalIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<ExternalIdResponse, ApiConnectionActionConfiguration> UpdateExternalId(Expression<Func<string>> objectId, Expression<Func<UpdateExternalIdRequestBodyInput>> requestBody = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<ExternalIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/app/v1/object/{0}/external_id", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<ExternalIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<AuditResponse, ApiConnectionActionConfiguration> ObjectAudit(Expression<Func<AuditRequestBodyInput>> auditRequestBody, Expression<Func<string>> objectId)
        {
            var __workflow_auditRequestBody = WorkflowExpression.Compile(auditRequestBody, nameof(auditRequestBody), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<AuditResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/app/v1/object/{0}/audit", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_auditRequestBody);
                return new ApiConnectionAction<AuditResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<GetReportListResponse, ApiConnectionActionConfiguration> GetReportList(Expression<Func<BodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetReportListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/report/v1/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetReportListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<ReportDataResponse, ApiConnectionActionConfiguration> GetReportData(Expression<Func<int>> reportId, Expression<Func<GetReportDataRequestBodyInput>> requestBody = null)
        {
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<ReportDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/report/v1/{0}/data", __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<ReportDataResponse>(callPayload);
            });
        }
    }

    public class WorkspanTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SubscribeResp, ApiConnectionPollingTriggerConfiguration> Subscribe(Expression<Func<SubscribeSubscribeBodyInput>> subscribeBody)
        {
            var __workflow_subscribeBody = WorkflowExpression.Compile(subscribeBody, nameof(subscribeBody), required: true);
            return new DeferredBodyTrigger<SubscribeResp, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/event/v1/subscriber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscribeBody);
                return new ApiConnectionPollingTrigger<SubscribeResp>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<SubscribeResp, ApiConnectionPollingTriggerConfiguration> SubscribeObjectEvent(Expression<Func<SubscribeObjectEventSubscribeBodyInput>> subscribeBody)
        {
            var __workflow_subscribeBody = WorkflowExpression.Compile(subscribeBody, nameof(subscribeBody), required: true);
            return new DeferredBodyTrigger<SubscribeResp, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/event/v1/subscriber/object_integration_event";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscribeBody);
                return new ApiConnectionPollingTrigger<SubscribeResp>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<SubscribeResp, ApiConnectionPollingTriggerConfiguration> SubmitToPartnerCenterObjectEvent(Expression<Func<SubmitToPartnerCenterObjectEventSubscribeBodyInput>> subscribeBody)
        {
            var __workflow_subscribeBody = WorkflowExpression.Compile(subscribeBody, nameof(subscribeBody), required: true);
            return new DeferredBodyTrigger<SubscribeResp, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/event/v1/subscriber/submit_to_partner_center";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscribeBody);
                return new ApiConnectionPollingTrigger<SubscribeResp>(callPayload);
            });
        }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkloadOpportunityContentTypeInput
    {
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "json")]
        Json
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkloadDataContentTypeInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DataFormatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "csv")]
        Csv
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class UpdateExternalIdRequestBodyInput
    {
        [JsonProperty("field_name")]
        public string FieldName { get; set; }

        [JsonProperty("external_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExternalId { get; set; }
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

    public class AuditRequestBodyInput
    {
        [JsonProperty("field_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public AuditRequestBodyInputFieldNameType FieldName { get; set; }

        [JsonProperty("integration_id")]
        public string IntegrationId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("status_code", DefaultValueHandling = DefaultValueHandling.Include)]
        public AuditRequestBodyInputStatusCodeType StatusCode { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AuditRequestBodyInputFieldNameType
    {
        [EnumMember(Value = "partner_center.integration_status")]
        PartnerCenterIntegrationStatus
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AuditRequestBodyInputStatusCodeType
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

    public class BodyInput
    {
        [JsonProperty("page")]
        public BodyInputPageType Page { get; set; }
    }

    public class BodyInputPageType
    {
        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }
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

    public class GetReportDataRequestBodyInput
    {
        [JsonProperty("filters")]
        public ReportFilterContainer Filters { get; set; }

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReportPageDto Page { get; set; } = new ReportPageDto();
    }

    public class ReportFilterContainer
    {
        [JsonProperty("fieldFilters")]
        public ReportFieldFilter[] FieldFilters { get; set; }

        [JsonProperty("op")]
        public ReportFilterContainerOpType? Op { get; set; }
    }

    public class ReportFieldFilter
    {
        [JsonProperty("colId")]
        public string ColId { get; set; }

        [JsonProperty("filter")]
        public ReportFilter Filter { get; set; }

        [JsonProperty("type")]
        public ReportFieldFilterTypeType? Type { get; set; }
    }

    public class ReportFilter
    {
        [JsonProperty("negate")]
        public bool? Negate { get; set; }

        [JsonProperty("op")]
        public ReportFilterOpType? Op { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReportFilterContainerOpType
    {
        AND,
        OR
    }

    public class ReportPageDto
    {
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Number { get; set; } = 0;

        [JsonProperty("size", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Size { get; set; } = 500;
    }

    public class SubscribeResp
    {
        [JsonProperty("subscriber_id")]
        public string SubscriberId { get; set; }
    }

    public class SubscribeSubscribeBodyInput
    {
        [JsonProperty("webhook_settings", DefaultValueHandling = DefaultValueHandling.Include)]
        public SubscribeBodyInputWebhookSettingsType WebhookSettings { get; set; } = new SubscribeBodyInputWebhookSettingsType();

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventName { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SubscriberName { get; set; }

        [JsonProperty("object_ids")]
        public string[] WorkSpanObjectId { get; set; }

        [JsonProperty("filters")]
        public string Filters { get; set; }

        [JsonProperty("subscriber_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubscriberType { get; set; } = "webhook";
    }

    public class SubscribeBodyInputWebhookSettingsType
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURL { get; set; } = "#{listCallbackUrl()}";
    }

    public class SubscribeObjectEventSubscribeBodyInput
    {
        [JsonProperty("subscriber_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubscriberType { get; set; } = "webhook";

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        public SubscribeBodyInputSubscribeToObjectEventsTypeItem[] SubscribeToObjectEvents { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("integration_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SelectIntegrationConfiguredInWorkSpan { get; set; }

        [JsonProperty("object_ids")]
        public string[] ObjectIds { get; set; }

        [JsonProperty("filters")]
        public string Filters { get; set; }

        [JsonProperty("webhook_settings", DefaultValueHandling = DefaultValueHandling.Include)]
        public SubscribeBodyInputWebhookSettingsType WebhookSettings { get; set; } = new SubscribeBodyInputWebhookSettingsType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SubscribeBodyInputSubscribeToObjectEventsTypeItem
    {
        [EnumMember(Value = "object.all")]
        ObjectAll,
        [EnumMember(Value = "object.create")]
        ObjectCreate,
        [EnumMember(Value = "object.update")]
        ObjectUpdate,
        [EnumMember(Value = "object.delete")]
        ObjectDelete,
        [EnumMember(Value = "object.stage_change")]
        ObjectStageChange,
        [EnumMember(Value = "object.partner_center_referral_submit")]
        ObjectPartnerCenterReferralSubmit,
        [EnumMember(Value = "report.submit")]
        ReportSubmit
    }

    public class SubmitToPartnerCenterObjectEventSubscribeBodyInput
    {
        [JsonProperty("subscriber_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubscriberType { get; set; } = "webhook";

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubmitToPartnerCenterEvent { get; set; } = "object.partner_center_referral_submit";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("integration_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SelectIntegrationConfiguredInWorkSpan { get; set; }

        [JsonProperty("webhook_settings", DefaultValueHandling = DefaultValueHandling.Include)]
        public SubscribeBodyInputWebhookSettingsType WebhookSettings { get; set; } = new SubscribeBodyInputWebhookSettingsType();
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