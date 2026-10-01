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
        public IBodyWorkflowAction<BulkloadOpportunityResponse> BulkloadOpportunity([WorkflowExpression] Func<string> integrationId, [WorkflowExpression] Func<contentTypeInput> contentType = null, [WorkflowExpression] Func<string> columnDelimiter = null, [WorkflowExpression] Func<contentType2Input> contentType2 = null, [WorkflowExpression] Func<object> bulkloadOpportunityRequest = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bulk/v1/bulkload_opportunity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["integration_id"] = SourceExpressionConverter.ConvertO(integrationId);
                callPayload.Queries["content_type"] = Convert.ToString("csv");
                if (contentType != null)
                    callPayload.Queries["content_type"] = SourceExpressionConverter.Convert(contentType);
                callPayload.Queries["column_delimiter"] = Convert.ToString(",");
                if (columnDelimiter != null)
                    callPayload.Queries["column_delimiter"] = SourceExpressionConverter.ConvertO(columnDelimiter);
                callPayload.Headers["Content-Type"] = Convert.ToString("text/csv");
                if (contentType2 != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.Convert(contentType2);
                callPayload.Body = SourceExpressionConverter.ConvertToken(bulkloadOpportunityRequest);
                return callPayload;
            }

            return new ApiConnectionAction<BulkloadOpportunityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<BulkloadResponse> BulkloadData([WorkflowExpression] Func<string> integrationId, [WorkflowExpression] Func<dataFormatInput> dataFormat = null, [WorkflowExpression] Func<string> columnDelimiter = null, [WorkflowExpression] Func<contentTypeInput> contentType = null, [WorkflowExpression] Func<object> bulkloadRequest = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bulk/v1/bulkload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["integration_id"] = SourceExpressionConverter.ConvertO(integrationId);
                callPayload.Queries["data_format"] = Convert.ToString("csv");
                if (dataFormat != null)
                    callPayload.Queries["data_format"] = SourceExpressionConverter.Convert(dataFormat);
                callPayload.Queries["column_delimiter"] = Convert.ToString(",");
                if (columnDelimiter != null)
                    callPayload.Queries["column_delimiter"] = SourceExpressionConverter.ConvertO(columnDelimiter);
                callPayload.Headers["Content-Type"] = Convert.ToString("text/csv");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.Convert(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(bulkloadRequest);
                return callPayload;
            }

            return new ApiConnectionAction<BulkloadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<BulkloadStatusResponse> GetBulkloadStatus([WorkflowExpression] Func<string> integrationId, [WorkflowExpression] Func<string> executionId, [WorkflowExpression] Func<bool> includeErrors = null, [WorkflowExpression] Func<double> maxErrors = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bulk/v1/status/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(integrationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["execution_id"] = SourceExpressionConverter.ConvertO(executionId);
                callPayload.Queries["include_errors"] = Convert.ToString(true);
                if (includeErrors != null)
                    callPayload.Queries["include_errors"] = SourceExpressionConverter.ConvertO(includeErrors);
                callPayload.Queries["max_errors"] = Convert.ToString(5);
                if (maxErrors != null)
                    callPayload.Queries["max_errors"] = SourceExpressionConverter.ConvertO(maxErrors);
                return callPayload;
            }

            return new ApiConnectionAction<BulkloadStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<GetExternalIdResponse> GetExternalId([WorkflowExpression] Func<string> objectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/app/v1/object/{0}/external_id", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetExternalIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<ExternalIdResponse> UpdateExternalId([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> requestBodyexternalId, [WorkflowExpression] Func<string> requestBodyfieldName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/app/v1/object/{0}/external_id", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodyfieldName != null)
                {
                    requestBody["field_name"] = SourceExpressionConverter.ConvertToken(requestBodyfieldName);
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["external_id"] = SourceExpressionConverter.ConvertToken(requestBodyexternalId);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExternalIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<AuditResponse> ObjectAudit([WorkflowExpression] Func<auditRequestBodyfieldNameInput> auditRequestBodyfieldName, [WorkflowExpression] Func<auditRequestBodystatusCodeInput> auditRequestBodystatusCode, [WorkflowExpression] Func<string> auditRequestBodymessage, [WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> auditRequestBodyintegrationId = null, [WorkflowExpression] Func<string> auditRequestBodyexternalId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/app/v1/object/{0}/audit", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var auditRequestBody = new JObject();
                var auditRequestBodypropCount = 0;
                auditRequestBodypropCount++;
                auditRequestBody["field_name"] = SourceExpressionConverter.Convert(auditRequestBodyfieldName);
                if (auditRequestBodyintegrationId != null)
                {
                    auditRequestBody["integration_id"] = SourceExpressionConverter.ConvertToken(auditRequestBodyintegrationId);
                    auditRequestBodypropCount++;
                }

                if (auditRequestBodyexternalId != null)
                {
                    auditRequestBody["external_id"] = SourceExpressionConverter.ConvertToken(auditRequestBodyexternalId);
                    auditRequestBodypropCount++;
                }

                auditRequestBodypropCount++;
                auditRequestBody["status_code"] = SourceExpressionConverter.Convert(auditRequestBodystatusCode);
                auditRequestBodypropCount++;
                auditRequestBody["message"] = SourceExpressionConverter.ConvertToken(auditRequestBodymessage);
                if (auditRequestBodypropCount > 0)
                {
                    callPayload.Body = auditRequestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AuditResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<GetReportListResponse> GetReportList([WorkflowExpression] Func<int> bodypagenumber = null, [WorkflowExpression] Func<int> bodypagesize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    pageObject["number"] = SourceExpressionConverter.ConvertToken(bodypagenumber);
                    pageObjectpropCount++;
                }

                if (bodypagesize != null)
                {
                    pageObject["size"] = SourceExpressionConverter.ConvertToken(bodypagesize);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetReportListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workspan")]
        public IBodyWorkflowAction<ReportDataResponse> GetReportData([WorkflowExpression] Func<int> reportId, [WorkflowExpression] Func<int> requestBodypagenumber, [WorkflowExpression] Func<int> requestBodypagesize, [WorkflowExpression] Func<ReportFieldFilter[]> requestBodyfiltersfieldFilters = null, [WorkflowExpression] Func<requestBodyfiltersopInput> requestBodyfiltersop = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/report/v1/{0}/data", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(reportId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                var filtersObject = new JObject();
                var filtersObjectpropCount = 0;
                if (requestBodyfiltersfieldFilters != null)
                {
                    filtersObject["fieldFilters"] = SourceExpressionConverter.ConvertToken(requestBodyfiltersfieldFilters);
                    filtersObjectpropCount++;
                }

                if (requestBodyfiltersop != null)
                {
                    filtersObject["op"] = SourceExpressionConverter.Convert(requestBodyfiltersop);
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
                pageObject["number"] = SourceExpressionConverter.ConvertToken(requestBodypagenumber);
                pageObjectpropCount++;
                pageObject["size"] = SourceExpressionConverter.ConvertToken(requestBodypagesize);
                if (pageObjectpropCount > 0)
                {
                    requestBody["page"] = pageObject;
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReportDataResponse>(BuildSourceInput);
        }
    }

    public class WorkspanTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SubscribeResp> Subscribe([WorkflowExpression] Func<string> subscribeBodyeventName, [WorkflowExpression] Func<string> subscribeBodysubscriberName, [WorkflowExpression] Func<string[]> subscribeBodyworkSpanObjectId = null, [WorkflowExpression] Func<string> subscribeBodyfilterExampleStageInClosedWonLostANDSalesDetailsPartnerP1 = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/event/v1/subscriber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscribeBody = new JObject();
                var subscribeBodypropCount = 0;
                var webhookSettingsObject = new JObject();
                var webhookSettingsObjectpropCount = 0;
                webhookSettingsObject["callback_url"] = "#{listCallbackUrl()}";
                webhookSettingsObjectpropCount++;
                if (webhookSettingsObjectpropCount > 0)
                {
                    subscribeBody["webhook_settings"] = webhookSettingsObject;
                    subscribeBodypropCount++;
                }

                subscribeBodypropCount++;
                subscribeBody["event"] = SourceExpressionConverter.ConvertToken(subscribeBodyeventName);
                subscribeBodypropCount++;
                subscribeBody["name"] = SourceExpressionConverter.ConvertToken(subscribeBodysubscriberName);
                if (subscribeBodyworkSpanObjectId != null)
                {
                    subscribeBody["object_ids"] = SourceExpressionConverter.ConvertToken(subscribeBodyworkSpanObjectId);
                    subscribeBodypropCount++;
                }

                if (subscribeBodyfilterExampleStageInClosedWonLostANDSalesDetailsPartnerP1 != null)
                {
                    subscribeBody["filters"] = SourceExpressionConverter.ConvertToken(subscribeBodyfilterExampleStageInClosedWonLostANDSalesDetailsPartnerP1);
                    subscribeBodypropCount++;
                }

                subscribeBody["subscriber_type"] = "webhook";
                subscribeBodypropCount++;
                if (subscribeBodypropCount > 0)
                {
                    callPayload.Body = subscribeBody;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<SubscribeResp>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SubscribeResp> SubscribeObjectEvent([WorkflowExpression] Func<subscribeBodysubscribeToObjectEventsInputItem[]> subscribeBodysubscribeToObjectEvents, [WorkflowExpression] Func<string> subscribeBodyname, [WorkflowExpression] Func<string> subscribeBodyselectIntegrationConfiguredInWorkSpan, [WorkflowExpression] Func<string[]> subscribeBodyobjectIds = null, [WorkflowExpression] Func<string> subscribeBodyfilterExampleStageInClosedWonLostANDSalesDetailsPartnerP1 = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/event/v1/subscriber/object_integration_event";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscribeBody = new JObject();
                var subscribeBodypropCount = 0;
                subscribeBody["subscriber_type"] = "webhook";
                subscribeBodypropCount++;
                subscribeBodypropCount++;
                subscribeBody["event"] = SourceExpressionConverter.ConvertToken(subscribeBodysubscribeToObjectEvents);
                subscribeBodypropCount++;
                subscribeBody["name"] = SourceExpressionConverter.ConvertToken(subscribeBodyname);
                subscribeBodypropCount++;
                subscribeBody["integration_id"] = SourceExpressionConverter.ConvertToken(subscribeBodyselectIntegrationConfiguredInWorkSpan);
                if (subscribeBodyobjectIds != null)
                {
                    subscribeBody["object_ids"] = SourceExpressionConverter.ConvertToken(subscribeBodyobjectIds);
                    subscribeBodypropCount++;
                }

                if (subscribeBodyfilterExampleStageInClosedWonLostANDSalesDetailsPartnerP1 != null)
                {
                    subscribeBody["filters"] = SourceExpressionConverter.ConvertToken(subscribeBodyfilterExampleStageInClosedWonLostANDSalesDetailsPartnerP1);
                    subscribeBodypropCount++;
                }

                var webhookSettingsObject = new JObject();
                var webhookSettingsObjectpropCount = 0;
                webhookSettingsObject["callback_url"] = "#{listCallbackUrl()}";
                webhookSettingsObjectpropCount++;
                if (webhookSettingsObjectpropCount > 0)
                {
                    subscribeBody["webhook_settings"] = webhookSettingsObject;
                    subscribeBodypropCount++;
                }

                if (subscribeBodypropCount > 0)
                {
                    callPayload.Body = subscribeBody;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<SubscribeResp>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SubscribeResp> SubmitToPartnerCenterObjectEvent([WorkflowExpression] Func<string> subscribeBodyname, [WorkflowExpression] Func<string> subscribeBodyselectIntegrationConfiguredInWorkSpan, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/event/v1/subscriber/submit_to_partner_center";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscribeBody = new JObject();
                var subscribeBodypropCount = 0;
                subscribeBody["subscriber_type"] = "webhook";
                subscribeBodypropCount++;
                subscribeBody["event"] = "object.partner_center_referral_submit";
                subscribeBodypropCount++;
                subscribeBodypropCount++;
                subscribeBody["name"] = SourceExpressionConverter.ConvertToken(subscribeBodyname);
                subscribeBodypropCount++;
                subscribeBody["integration_id"] = SourceExpressionConverter.ConvertToken(subscribeBodyselectIntegrationConfiguredInWorkSpan);
                var webhookSettingsObject = new JObject();
                var webhookSettingsObjectpropCount = 0;
                webhookSettingsObject["callback_url"] = "#{listCallbackUrl()}";
                webhookSettingsObjectpropCount++;
                if (webhookSettingsObjectpropCount > 0)
                {
                    subscribeBody["webhook_settings"] = webhookSettingsObject;
                    subscribeBodypropCount++;
                }

                if (subscribeBodypropCount > 0)
                {
                    callPayload.Body = subscribeBody;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<SubscribeResp>(BuildSourceInput, triggerName, recurrence);
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

    public enum contentTypeInput
    {
        [EnumMember(Value = "text/csv")]
        TextCsv,
        [EnumMember(Value = "application/json")]
        ApplicationJson
    }

    public enum contentType2Input
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

    public class SubscribeResp
    {
        [JsonProperty("subscriber_id")]
        public string SubscriberId { get; set; }
    }

    public enum subscribeBodysubscribeToObjectEventsInputItem
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