//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Simplesurvey
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SimplesurveyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simplesurvey")]
        public IBodyWorkflowAction<GetSurveysResponse> GetSurveys()
        {
            var apiCallPath = "/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSurveysResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simplesurvey")]
        public IBodyWorkflowAction<GetSurveyRespondentsDetailsResponse> GetSurveyRespondentsDetails(Expression<Func<string>> idProject, Expression<Func<string>> tableCode, Expression<Func<formatInput>> format, Expression<Func<string>> xSAKKey)
        {
            var apiCallPath = String.Format("/projects/{0}/data/{1}", ExpressionConverter.ConvertWithUrlEncoding(idProject, 1), ExpressionConverter.ConvertWithUrlEncoding(tableCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Headers["X-SAKKey"] = ExpressionConverter.Convert(xSAKKey);
            return new ApiConnectionAction<GetSurveyRespondentsDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simplesurvey")]
        public IBodyWorkflowAction<GetSurveyDataWarehouseReportResponse> GetSurveyDataWarehouseReport(Expression<Func<string>> idProject, Expression<Func<formatInput>> format, Expression<Func<string>> xSAKKey)
        {
            var apiCallPath = String.Format("/projects/{0}/dw/data", ExpressionConverter.ConvertWithUrlEncoding(idProject, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Headers["X-SAKKey"] = ExpressionConverter.Convert(xSAKKey);
            return new ApiConnectionAction<GetSurveyDataWarehouseReportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simplesurvey")]
        public IBodyWorkflowAction<GetSurveyStatsResponse> GetSurveyStats(Expression<Func<string>> idProject, Expression<Func<bool>> f, Expression<Func<string>> xSAKKey)
        {
            var apiCallPath = String.Format("/projects/{0}/stats", ExpressionConverter.ConvertWithUrlEncoding(idProject, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["f"] = ExpressionConverter.Convert(f);
            callPayload.Headers["X-SAKKey"] = ExpressionConverter.Convert(xSAKKey);
            return new ApiConnectionAction<GetSurveyStatsResponse>(callPayload);
        }
    }

    public class SimplesurveyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ResponseSubmitted(Expression<Func<string>> idProject, Expression<Func<int>> automationId, Expression<Func<string>> xSAKKey, Expression<Func<string>> bodyName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/events/{0}/automations/{1}/webhooks/register", ExpressionConverter.ConvertWithUrlEncoding(idProject, 1), ExpressionConverter.ConvertWithUrlEncoding(automationId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-SAKKey"] = ExpressionConverter.Convert(xSAKKey);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Name"] = ExpressionConverter.ConvertO(bodyName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger ResponseChanged(Expression<Func<string>> idProject, Expression<Func<int>> automationId, Expression<Func<string>> xSAKKey, Expression<Func<string>> bodyName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/events/{0}/automations/{1}/webhooks/register/cr", ExpressionConverter.ConvertWithUrlEncoding(idProject, 1), ExpressionConverter.ConvertWithUrlEncoding(automationId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-SAKKey"] = ExpressionConverter.Convert(xSAKKey);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Name"] = ExpressionConverter.ConvertO(bodyName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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

        [JsonProperty("respondentsTable_csv")]
        public string RespondentsTableCsv { get; set; }

        [JsonProperty("caseTable_csv")]
        public string CaseTableCsv { get; set; }

        [JsonProperty("variableTable_csv")]
        public string VariableTableCsv { get; set; }

        [JsonProperty("variableValueLabelTable_csv")]
        public string VariableValueLabelTableCsv { get; set; }

        [JsonProperty("genericFieldHeaderTable_csv")]
        public string GenericFieldHeaderTableCsv { get; set; }

        [JsonProperty("genericFieldDataTable_csv")]
        public string GenericFieldDataTableCsv { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
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

        [JsonProperty("lang_code")]
        public string LangCode { get; set; }

        [JsonProperty("lang_localized")]
        public string LangLocalized { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("score_auto")]
        public int ScoreAuto { get; set; }

        [JsonProperty("completion_time")]
        public int CompletionTime { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("state_localized")]
        public string StateLocalized { get; set; }
    }

    public class GetSurveyRespondentsDetailsResponseCaseTableTypeItem
    {
        [JsonProperty("respondent_id")]
        public string RespondentId { get; set; }

        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("variable_id")]
        public string VariableId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetSurveyRespondentsDetailsResponseVariableTableTypeItem
    {
        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("element_label")]
        public string ElementLabel { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("variable_id")]
        public string VariableId { get; set; }

        [JsonProperty("variable_label")]
        public string VariableLabel { get; set; }
    }

    public class GetSurveyRespondentsDetailsResponseVariableValueLabelTableTypeItem
    {
        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("variable_id")]
        public string VariableId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetSurveyRespondentsDetailsResponseGenericFieldHeaderTableTypeItem
    {
        [JsonProperty("generic_field_id")]
        public int GenericFieldId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
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

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSurveyDataWarehouseReportResponseDatawarehouseRptTypeItem
    {
        public string QuestionProgId { get; set; }
        public string Question { get; set; }
        public string Response { get; set; }
        public string SubQuestion { get; set; }
        public double Score { get; set; }

        [JsonProperty("Date_Time")]
        public string DateTime { get; set; }
        public string Status { get; set; }
        public int InternalID { get; set; }
        public string Language { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public int WeightedScore { get; set; }
        public string IPAddress { get; set; }
        public string InviteName { get; set; }
        public string Comment { get; set; }
    }

    public class GetSurveyStatsResponse
    {
        [JsonProperty("value")]
        public GetSurveyStatsResponseValueType Value { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSurveyStatsResponseValueType
    {
        public int AssignedCount { get; set; }
        public int AssignedContactCount { get; set; }
        public int AssignedDistributionListMemberCount { get; set; }
        public int AssignedNoInviteDeliveredCount { get; set; }
        public int EligibleContactCount { get; set; }
        public int InviteSentCount { get; set; }
        public int InviteBouncedCount { get; set; }
        public int InviteBounceRate { get; set; }
        public int InviteDeliveredCount { get; set; }
        public int InviteDeliveryRate { get; set; }
        public int InviteOpenedCount { get; set; }
        public int InviteOpenRate { get; set; }
        public int UnsubscribedCount { get; set; }
        public int UnsubscribeRate { get; set; }
        public int InviteDeliveredNoAccessCount { get; set; }
        public int EmptyCount { get; set; }
        public int EmptyPercentage { get; set; }
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

        [JsonProperty("CompletionTime_Avg")]
        public int CompletionTimeAvg { get; set; }

        [JsonProperty("CompletionTime_Med")]
        public int CompletionTimeMed { get; set; }
        public int OptInConfirmationCount { get; set; }
        public int EmailSentCount { get; set; }
        public string LastCompletedDate { get; set; }
        public string LastUpdatedDate { get; set; }
        public string CompletedCountPerDayString { get; set; }
        public int[][] CompletedCountPerDay { get; set; }
        public string CompletedCountPerMonthString { get; set; }
        public int[][] CompletedCountPerMonth { get; set; }
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