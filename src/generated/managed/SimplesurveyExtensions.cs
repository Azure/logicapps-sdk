//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Simplesurvey
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SimplesurveyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simplesurvey")]
        public IBodyWorkflowAction<GetSurveysResponse, ApiConnectionActionConfiguration> GetSurveys()
        {
            return new DeferredBodyAction<GetSurveysResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["context"] = Convert.ToString("p-a");
                return new ApiConnectionAction<GetSurveysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simplesurvey")]
        public IBodyWorkflowAction<GetSurveyRespondentsDetailsResponse, ApiConnectionActionConfiguration> GetSurveyRespondentsDetails(Expression<Func<string>> idProject, Expression<Func<string>> tableCode, Expression<Func<formatInput>> format, Expression<Func<string>> xSAKKey)
        {
            var __workflow_idProject = WorkflowExpression.Compile(idProject, nameof(idProject), required: true);
            var __workflow_tableCode = WorkflowExpression.Compile(tableCode, nameof(tableCode), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_xSAKKey = WorkflowExpression.Compile(xSAKKey, nameof(xSAKKey), required: true);
            return new DeferredBodyAction<GetSurveyRespondentsDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/data/{1}", __workflow_idProject.WithUrlEncoding(1), __workflow_tableCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Headers["X-SAKKey"] = ExpressionConverter.Convert(__workflow_xSAKKey);
                return new ApiConnectionAction<GetSurveyRespondentsDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simplesurvey")]
        public IBodyWorkflowAction<GetSurveyDataWarehouseReportResponse, ApiConnectionActionConfiguration> GetSurveyDataWarehouseReport(Expression<Func<string>> idProject, Expression<Func<formatInput>> format, Expression<Func<string>> xSAKKey)
        {
            var __workflow_idProject = WorkflowExpression.Compile(idProject, nameof(idProject), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_xSAKKey = WorkflowExpression.Compile(xSAKKey, nameof(xSAKKey), required: true);
            return new DeferredBodyAction<GetSurveyDataWarehouseReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/dw/data", __workflow_idProject.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Headers["X-SAKKey"] = ExpressionConverter.Convert(__workflow_xSAKKey);
                return new ApiConnectionAction<GetSurveyDataWarehouseReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simplesurvey")]
        public IBodyWorkflowAction<GetSurveyStatsResponse, ApiConnectionActionConfiguration> GetSurveyStats(Expression<Func<string>> idProject, Expression<Func<bool>> f, Expression<Func<string>> xSAKKey)
        {
            var __workflow_idProject = WorkflowExpression.Compile(idProject, nameof(idProject), required: true);
            var __workflow_f = WorkflowExpression.Compile(f, nameof(f), required: true);
            var __workflow_xSAKKey = WorkflowExpression.Compile(xSAKKey, nameof(xSAKKey), required: true);
            return new DeferredBodyAction<GetSurveyStatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/stats", __workflow_idProject.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["f"] = ExpressionConverter.Convert(__workflow_f);
                callPayload.Headers["X-SAKKey"] = ExpressionConverter.Convert(__workflow_xSAKKey);
                return new ApiConnectionAction<GetSurveyStatsResponse>(callPayload);
            });
        }
    }

    public class SimplesurveyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ResponseSubmitted(Expression<Func<string>> idProject, Expression<Func<int>> automationId, Expression<Func<string>> xSAKKey, Expression<Func<ResponseSubmittedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_idProject = WorkflowExpression.Compile(idProject, nameof(idProject), required: true);
            var __workflow_automationId = WorkflowExpression.Compile(automationId, nameof(automationId), required: true);
            var __workflow_xSAKKey = WorkflowExpression.Compile(xSAKKey, nameof(xSAKKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/events/{0}/automations/{1}/webhooks/register", __workflow_idProject.WithUrlEncoding(1), __workflow_automationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-SAKKey"] = ExpressionConverter.Convert(__workflow_xSAKKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ResponseChanged(Expression<Func<string>> idProject, Expression<Func<int>> automationId, Expression<Func<string>> xSAKKey, Expression<Func<ResponseChangedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_idProject = WorkflowExpression.Compile(idProject, nameof(idProject), required: true);
            var __workflow_automationId = WorkflowExpression.Compile(automationId, nameof(automationId), required: true);
            var __workflow_xSAKKey = WorkflowExpression.Compile(xSAKKey, nameof(xSAKKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/events/{0}/automations/{1}/webhooks/register/cr", __workflow_idProject.WithUrlEncoding(1), __workflow_automationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-SAKKey"] = ExpressionConverter.Convert(__workflow_xSAKKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetSurveysResponse
    {
        [JsonProperty("value")]
        public GetSurveysResponseValueTypeItem[] Value { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errormsg")]
        public string Errormsg { get; set; }

        [JsonProperty("errordetails")]
        public string Errordetails { get; set; }

        [JsonProperty("errorcode")]
        public string Errorcode { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }
    }

    public class GetSurveysResponseValueTypeItem
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sharedKey")]
        public string SharedKey { get; set; }
    }

    public class GetSurveyRespondentsDetailsResponse
    {
        [JsonProperty("respondentsTable")]
        public GetSurveyRespondentsDetailsResponseRespondentsTableTypeItem[] RespondentsTable { get; set; }

        [JsonProperty("caseTable")]
        public GetSurveyRespondentsDetailsResponseCaseTableTypeItem[] CaseTable { get; set; }

        [JsonProperty("variableTable")]
        public GetSurveyRespondentsDetailsResponseVariableTableTypeItem[] VariableTable { get; set; }

        [JsonProperty("variableValueLabelTable")]
        public GetSurveyRespondentsDetailsResponseVariableValueLabelTableTypeItem[] VariableValueLabelTable { get; set; }

        [JsonProperty("genericFieldHeaderTable")]
        public GetSurveyRespondentsDetailsResponseGenericFieldHeaderTableTypeItem[] GenericFieldHeaderTable { get; set; }

        [JsonProperty("genericFieldDataTable")]
        public GetSurveyRespondentsDetailsResponseGenericFieldDataTableTypeItem[] GenericFieldDataTable { get; set; }

        [JsonProperty("genericFieldDataTable_csv")]
        public string GenericFieldDataTableCsv { get; set; }

        [JsonProperty("genericFieldHeaderTable_csv")]
        public string GenericFieldHeaderTableCsv { get; set; }

        [JsonProperty("respondentsTable_csv")]
        public string RespondentsTableCsv { get; set; }

        [JsonProperty("caseTable_csv")]
        public string CaseTableCsv { get; set; }

        [JsonProperty("variableTable_csv")]
        public string VariableTableCsv { get; set; }

        [JsonProperty("variableValueLabelTable_csv")]
        public string VariableValueLabelTableCsv { get; set; }
    }

    public class GetSurveyRespondentsDetailsResponseRespondentsTableTypeItem
    {
        [JsonProperty("respondent_id")]
        public string RespondentId { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("internal_id")]
        public int InternalId { get; set; }

        [JsonProperty("info1")]
        public string Info1 { get; set; }

        [JsonProperty("info2")]
        public string Info2 { get; set; }

        [JsonProperty("info3")]
        public string Info3 { get; set; }

        [JsonProperty("info4")]
        public string Info4 { get; set; }

        [JsonProperty("info5")]
        public string Info5 { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("is_mobile")]
        public bool IsMobile { get; set; }

        [JsonProperty("referer_url")]
        public string RefererUrl { get; set; }

        [JsonProperty("confirmation_number")]
        public string ConfirmationNumber { get; set; }

        [JsonProperty("created_date_utc")]
        public string CreatedDateUtc { get; set; }

        [JsonProperty("first_answer_date_utc")]
        public string FirstAnswerDateUtc { get; set; }

        [JsonProperty("last_answer_date_utc")]
        public string LastAnswerDateUtc { get; set; }

        [JsonProperty("submitted_date_utc")]
        public string SubmittedDateUtc { get; set; }

        [JsonProperty("last_savecont_date_utc")]
        public string LastSavecontDateUtc { get; set; }

        [JsonProperty("lang_code")]
        public string LangCode { get; set; }

        [JsonProperty("lang_localized")]
        public string LangLocalized { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("score_auto")]
        public double ScoreAuto { get; set; }

        [JsonProperty("score_manual")]
        public double ScoreManual { get; set; }

        [JsonProperty("completion_time")]
        public int CompletionTime { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("state_localized")]
        public string StateLocalized { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("workspace")]
        public string Workspace { get; set; }

        [JsonProperty("collector_code")]
        public string CollectorCode { get; set; }

        [JsonProperty("pin")]
        public string Pin { get; set; }
    }

    public class GetSurveyRespondentsDetailsResponseCaseTableTypeItem
    {
        [JsonProperty("respondent_id")]
        public string RespondentId { get; set; }

        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("variable_id")]
        public string VariableId { get; set; }

        [JsonProperty("column_id")]
        public string ColumnId { get; set; }

        [JsonProperty("sub_element")]
        public int SubElement { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetSurveyRespondentsDetailsResponseVariableTableTypeItem
    {
        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("variable_id")]
        public string VariableId { get; set; }

        [JsonProperty("column_id")]
        public string ColumnId { get; set; }

        [JsonProperty("sub_element")]
        public int SubElement { get; set; }

        [JsonProperty("element_label")]
        public string ElementLabel { get; set; }

        [JsonProperty("variable_label")]
        public string VariableLabel { get; set; }

        [JsonProperty("column_label")]
        public string ColumnLabel { get; set; }

        [JsonProperty("sub_element_label")]
        public string SubElementLabel { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetSurveyRespondentsDetailsResponseVariableValueLabelTableTypeItem
    {
        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("variable_id")]
        public string VariableId { get; set; }

        [JsonProperty("column_id")]
        public string ColumnId { get; set; }

        [JsonProperty("sub_element")]
        public int SubElement { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetSurveyRespondentsDetailsResponseGenericFieldHeaderTableTypeItem
    {
        [JsonProperty("generic_field_id")]
        public int GenericFieldId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetSurveyRespondentsDetailsResponseGenericFieldDataTableTypeItem
    {
        [JsonProperty("generic_field_id")]
        public int GenericFieldId { get; set; }

        [JsonProperty("respondent_id")]
        public string RespondentId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        JSON,
        CSV
    }

    public class GetSurveyDataWarehouseReportResponse
    {
        public GetSurveyDataWarehouseReportResponseDatawarehouseRptTypeItem[] DatawarehouseRpt { get; set; }

        [JsonProperty("DatawarehouseRpt_csv")]
        public string DatawarehouseRptCsv { get; set; }
    }

    public class GetSurveyDataWarehouseReportResponseDatawarehouseRptTypeItem
    {
        public string QuestionProgId { get; set; }
        public string Question { get; set; }
        public string Response { get; set; }
        public string Comment { get; set; }
        public string SubQuestion { get; set; }
        public double Score { get; set; }

        [JsonProperty("Date_Time")]
        public string DateTime { get; set; }
        public string Status { get; set; }

        [JsonProperty("InternalID")]
        public int InternalId { get; set; }
        public string Language { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string Location { get; set; }
        public string GETVariables { get; set; }
        public string Referrer { get; set; }
        public double WeightedScore { get; set; }
        public string IPAddress { get; set; }
        public string BrowserName { get; set; }
        public string OperatingSystem { get; set; }
        public string InviteCode { get; set; }
        public string InviteEmail { get; set; }
        public string InviteName { get; set; }
        public string Collector { get; set; }
    }

    public class GetSurveyStatsResponse
    {
        public int AssignedCount { get; set; }
        public int AssignedContactCount { get; set; }
        public int AssignedDistributionListMemberCount { get; set; }
        public int AssignedNoInviteDeliveredCount { get; set; }
        public int EligibleContactCount { get; set; }
        public int InviteSentCount { get; set; }
        public int InviteBouncedCount { get; set; }
        public double InviteBounceRate { get; set; }
        public int InviteDeliveredCount { get; set; }
        public double InviteDeliveryRate { get; set; }
        public int InviteOpenedCount { get; set; }
        public double InviteOpenRate { get; set; }
        public int UnsubscribedCount { get; set; }
        public double UnsubscribeRate { get; set; }
        public int InviteDeliveredNoAccessCount { get; set; }
        public int EmptyCount { get; set; }
        public double EmptyPercentage { get; set; }
        public int AccessedCount { get; set; }
        public int RespondedCount { get; set; }
        public int InProgressCount { get; set; }
        public int CompletedCount { get; set; }
        public int ClosedCount { get; set; }
        public double InProgressPercentage { get; set; }
        public double CompletedPercentage { get; set; }
        public double ClosedPercentage { get; set; }

        [JsonProperty("CompletionRate_CompletedOverResponded")]
        public double CompletionRateCompletedOverResponded { get; set; }

        [JsonProperty("CompletionRate_CompletedOverAccessed")]
        public double CompletionRateCompletedOverAccessed { get; set; }

        [JsonProperty("ResponseRate_RespondedOverAssigned")]
        public double ResponseRateRespondedOverAssigned { get; set; }

        [JsonProperty("ResponseRate_CompletedOverAssigned")]
        public double ResponseRateCompletedOverAssigned { get; set; }

        [JsonProperty("ResponseRate_RespondedOverInvited")]
        public double ResponseRateRespondedOverInvited { get; set; }

        [JsonProperty("ResponseRate_CompletedOverInvited")]
        public double ResponseRateCompletedOverInvited { get; set; }

        [JsonProperty("CompletionTime_Avg")]
        public int CompletionTimeAvg { get; set; }

        [JsonProperty("CompletionTime_Med")]
        public int CompletionTimeMed { get; set; }
        public int OptInConfirmationCount { get; set; }
        public int EmailSentCount { get; set; }
        public int SMSSentCount { get; set; }
        public string LastCompletedDate { get; set; }
        public string LastUpdatedDate { get; set; }
        public string CompletedCountPerDayString { get; set; }
        public GetSurveyStatsResponseCompletedCountPerDayTypeItem[] CompletedCountPerDay { get; set; }
        public string CompletedCountPerMonthString { get; set; }
        public GetSurveyStatsResponseCompletedCountPerMonthTypeItem[] CompletedCountPerMonth { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSurveyStatsResponseCompletedCountPerDayTypeItem
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetSurveyStatsResponseCompletedCountPerMonthTypeItem
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class ResponseSubmittedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ResponseChangedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Simplesurvey;

    public partial class WorkflowManagedActions
    {
        public SimplesurveyActions Simplesurvey(string connectionId) => new SimplesurveyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SimplesurveyTriggers Simplesurvey(string connectionId) => new SimplesurveyTriggers(connectionId);
    }
}