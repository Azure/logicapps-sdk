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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["context"] = Convert.ToString("p-a");
                return callPayload;
            }

            return new ApiConnectionAction<GetSurveysResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simplesurvey")]
        public IBodyWorkflowAction<GetSurveyRespondentsDetailsResponse> GetSurveyRespondentsDetails([WorkflowExpression] Func<string> idProject, [WorkflowExpression] Func<string> tableCode, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> xSAKKey)
        {
            SourceExpression.Validate(idProject, nameof(idProject), required: true);
            SourceExpression.Validate(tableCode, nameof(tableCode), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(xSAKKey, nameof(xSAKKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/data/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idProject, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Headers["X-SAKKey"] = SourceExpressionConverter.ConvertO(xSAKKey);
                return callPayload;
            }

            return new ApiConnectionAction<GetSurveyRespondentsDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simplesurvey")]
        public IBodyWorkflowAction<GetSurveyDataWarehouseReportResponse> GetSurveyDataWarehouseReport([WorkflowExpression] Func<string> idProject, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> xSAKKey)
        {
            SourceExpression.Validate(idProject, nameof(idProject), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(xSAKKey, nameof(xSAKKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/dw/data", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idProject, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Headers["X-SAKKey"] = SourceExpressionConverter.ConvertO(xSAKKey);
                return callPayload;
            }

            return new ApiConnectionAction<GetSurveyDataWarehouseReportResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simplesurvey")]
        public IBodyWorkflowAction<GetSurveyStatsResponse> GetSurveyStats([WorkflowExpression] Func<string> idProject, [WorkflowExpression] Func<bool> f, [WorkflowExpression] Func<string> xSAKKey)
        {
            SourceExpression.Validate(idProject, nameof(idProject), required: true);
            SourceExpression.Validate(f, nameof(f), required: true);
            SourceExpression.Validate(xSAKKey, nameof(xSAKKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/stats", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idProject, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["f"] = SourceExpressionConverter.ConvertO(f);
                callPayload.Headers["X-SAKKey"] = SourceExpressionConverter.ConvertO(xSAKKey);
                return callPayload;
            }

            return new ApiConnectionAction<GetSurveyStatsResponse>(BuildSourceInput);
        }
    }

    public class SimplesurveyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ResponseSubmitted([WorkflowExpression] Func<string> idProject, [WorkflowExpression] Func<int> automationId, [WorkflowExpression] Func<string> xSAKKey, [WorkflowExpression] Func<string> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(idProject, nameof(idProject), required: true);
            SourceExpression.Validate(automationId, nameof(automationId), required: true);
            SourceExpression.Validate(xSAKKey, nameof(xSAKKey), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/events/{0}/automations/{1}/webhooks/register", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idProject, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(automationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-SAKKey"] = SourceExpressionConverter.ConvertO(xSAKKey);
                var body = new JObject();
                var bodypropCount = 0;
                body["CallbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger ResponseChanged([WorkflowExpression] Func<string> idProject, [WorkflowExpression] Func<int> automationId, [WorkflowExpression] Func<string> xSAKKey, [WorkflowExpression] Func<string> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(idProject, nameof(idProject), required: true);
            SourceExpression.Validate(automationId, nameof(automationId), required: true);
            SourceExpression.Validate(xSAKKey, nameof(xSAKKey), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/events/{0}/automations/{1}/webhooks/register/cr", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idProject, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(automationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-SAKKey"] = SourceExpressionConverter.ConvertO(xSAKKey);
                var body = new JObject();
                var bodypropCount = 0;
                body["CallbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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
        public int InternalID { get; set; }
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