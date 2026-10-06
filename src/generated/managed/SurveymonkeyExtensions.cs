//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Surveymonkey
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SurveymonkeyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surveymonkey")]
        public IBodyWorkflowAction<Survey> GetSurvey([WorkflowExpression] Func<string> surveyId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/surveys/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(surveyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Survey>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surveymonkey")]
        public IBodyWorkflowAction<SurveyMessageResponse> SendMessage([WorkflowExpression] Func<string> surveyId, [WorkflowExpression] Func<string> collectorId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> bodyscheduledDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/collectors/{0}/messages/{1}/send", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectorId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["surveyId"] = SourceExpressionConverter.ConvertO(surveyId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyscheduledDate != null)
                {
                    body["scheduled_date"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SurveyMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surveymonkey")]
        public IBodyWorkflowAction<GetResponseDetailsResponse> GetResponseDetails([WorkflowExpression] Func<string> surveyId, [WorkflowExpression] Func<string> responseId, [WorkflowExpression] Func<string> questionIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/actions1/surveys/{0}/responses/{1}/details", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(surveyId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(responseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["simple"] = Convert.ToString(true);
                if (questionIds != null)
                    callPayload.Queries["question_ids"] = SourceExpressionConverter.ConvertO(questionIds);
                return callPayload;
            }

            return new ApiConnectionAction<GetResponseDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surveymonkey")]
        public IBodyWorkflowAction<GetResponseDetailsNoPagesResponse> GetResponseDetailsNoPages([WorkflowExpression] Func<string> surveyId, [WorkflowExpression] Func<string> responseId, [WorkflowExpression] Func<string> questionIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/actions2/surveys/{0}/responses/{1}/details", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(surveyId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(responseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["simple"] = Convert.ToString(true);
                if (questionIds != null)
                    callPayload.Queries["question_ids"] = SourceExpressionConverter.ConvertO(questionIds);
                return callPayload;
            }

            return new ApiConnectionAction<GetResponseDetailsNoPagesResponse>(BuildSourceInput);
        }
    }

    public class SurveymonkeyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewSurveysItem[]> OnSurveyCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger1/surveys";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<NewSurveysItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewCollectorsItem[]> OnSurveyCollectorCreated([WorkflowExpression] Func<string> surveyId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger2/surveys/{0}/collectors", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(surveyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<NewCollectorsItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SurveyResponsesItem[]> OnNewResponseAddedCollector([WorkflowExpression] Func<string> surveyId, [WorkflowExpression] Func<string> collectorId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger3/collectors/{0}/responses/bulk", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["surveyId"] = SourceExpressionConverter.ConvertO(surveyId);
                return callPayload;
            }

            return new ApiConnectionTrigger<SurveyResponsesItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SurveyResponsesItem[]> OnNewResponseAddedSurvey([WorkflowExpression] Func<string> surveyId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger4/surveys/{0}/responses/bulk", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(surveyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<SurveyResponsesItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SurveyResponsesItem[]> OnNewResponseToQuestionAdded([WorkflowExpression] Func<string> surveyId, [WorkflowExpression] Func<string> pageIds = null, [WorkflowExpression] Func<string> questionIds = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger5/surveys/{0}/responses/bulk", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(surveyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageIds != null)
                    callPayload.Queries["page_ids"] = SourceExpressionConverter.ConvertO(pageIds);
                if (questionIds != null)
                    callPayload.Queries["question_ids"] = SourceExpressionConverter.ConvertO(questionIds);
                return callPayload;
            }

            return new ApiConnectionTrigger<SurveyResponsesItem[]>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class Survey
    {
        [JsonProperty("response_count")]
        public int ResponseCount { get; set; }

        [JsonProperty("page_count")]
        public int PageCount { get; set; }

        [JsonProperty("id")]
        public string SurveyID { get; set; }

        [JsonProperty("question_count")]
        public int QuestionCount { get; set; }

        [JsonProperty("category")]
        public string SurveyCategory { get; set; }

        [JsonProperty("preview")]
        public string PreviewUrl { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("date_modified")]
        public string ModifiedDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("analyze_url")]
        public string AnalyzeUrl { get; set; }

        [JsonProperty("summary_url")]
        public string SummaryUrl { get; set; }

        [JsonProperty("date_created")]
        public string CreatedDate { get; set; }

        [JsonProperty("collect_url")]
        public string CollectUrl { get; set; }

        [JsonProperty("edit_url")]
        public string EditUrl { get; set; }
    }

    public class SurveyMessageResponse
    {
        [JsonProperty("is_scheduled")]
        public string Link { get; set; }

        [JsonProperty("scheduled_date")]
        public string ScheduledDate { get; set; }

        [JsonProperty("body")]
        public string MessageBody { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }

        [JsonProperty("recipient_status")]
        public string States { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetResponseDetailsResponse
    {
        [JsonProperty("id")]
        public string ResponseID { get; set; }

        [JsonProperty("recipient_id")]
        public string RecipientID { get; set; }

        [JsonProperty("collection_mode")]
        public string CollectionMode { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("custom_value")]
        public string CustomValue { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("collector_id")]
        public string CollectorId { get; set; }

        [JsonProperty("survey_id")]
        public string SurveyId { get; set; }

        [JsonProperty("edit_url")]
        public string EditUrl { get; set; }

        [JsonProperty("analyze_url")]
        public string AnalyzeUrl { get; set; }

        [JsonProperty("total_time")]
        public int TotalTime { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
        public string RawResponseData { get; set; }
    }

    public class GetResponseDetailsNoPagesResponse
    {
        [JsonProperty("id")]
        public string ResponseID { get; set; }

        [JsonProperty("recipient_id")]
        public string RecipientID { get; set; }

        [JsonProperty("collection_mode")]
        public string CollectionMode { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("custom_value")]
        public string CustomValue { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("collector_id")]
        public string CollectorId { get; set; }

        [JsonProperty("survey_id")]
        public string SurveyId { get; set; }

        [JsonProperty("edit_url")]
        public string EditUrl { get; set; }

        [JsonProperty("analyze_url")]
        public string AnalyzeUrl { get; set; }

        [JsonProperty("total_time")]
        public int TotalTime { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("questions")]
        public GetResponseDetailsNoPagesResponseQuestionsTypeItem[] Questions { get; set; }
    }

    public class GetResponseDetailsNoPagesResponseQuestionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("answers")]
        public GetResponseDetailsNoPagesResponseQuestionsTypeItemAnswersTypeItem[] Answers { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("heading")]
        public string Heading { get; set; }
    }

    public class GetResponseDetailsNoPagesResponseQuestionsTypeItemAnswersTypeItem
    {
        [JsonProperty("tag_data")]
        public JToken[] TagData { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("simple_text")]
        public string SimpleText { get; set; }
    }

    public class NewSurveysItem
    {
        [JsonProperty("href")]
        public string Link { get; set; }

        [JsonProperty("id")]
        public string SurveyID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class NewCollectorsItem
    {
        [JsonProperty("href")]
        public string Link { get; set; }

        [JsonProperty("id")]
        public string CollectorID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SurveyResponsesItem
    {
        [JsonProperty("total_time")]
        public int TimeSpent { get; set; }

        [JsonProperty("href")]
        public string Link { get; set; }

        [JsonProperty("ip_address")]
        public string IPAddress { get; set; }

        [JsonProperty("id")]
        public string ResponseID { get; set; }

        [JsonProperty("date_modified")]
        public string ModifiedDate { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("custom_value")]
        public string CustomValue { get; set; }

        [JsonProperty("analyze_url")]
        public string AnalyzeUrl { get; set; }

        [JsonProperty("recipient_id")]
        public string RecipientID { get; set; }

        [JsonProperty("collector_id")]
        public string CollectorID { get; set; }

        [JsonProperty("date_created")]
        public string CreatedDate { get; set; }

        [JsonProperty("survey_id")]
        public string SurveyID { get; set; }

        [JsonProperty("collection_mode")]
        public string CollectionMode { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("logic_path")]
        public JToken LogicPath { get; set; }

        [JsonProperty("metadata")]
        public SurveyResponsesItemMetadataType Metadata { get; set; }

        [JsonProperty("page_path")]
        public JToken[] PagePath { get; set; }

        [JsonProperty("pages")]
        public SurveyResponsesItemPagesTypeItem[] Pages { get; set; }

        [JsonProperty("edit_url")]
        public string EditUrl { get; set; }
    }

    public class SurveyResponsesItemMetadataType
    {
        [JsonProperty("contact")]
        public JToken Contact { get; set; }
    }

    public class SurveyResponsesItemPagesTypeItem
    {
        [JsonProperty("id")]
        public string PageID { get; set; }

        [JsonProperty("questions")]
        public SurveyResponsesItemPagesTypeItemQuestionsTypeItem[] Questions { get; set; }
    }

    public class SurveyResponsesItemPagesTypeItemQuestionsTypeItem
    {
        [JsonProperty("id")]
        public string QuestionID { get; set; }

        [JsonProperty("answers")]
        public SurveyResponsesItemPagesTypeItemQuestionsTypeItemAnswersTypeItem[] Answers { get; set; }
    }

    public class SurveyResponsesItemPagesTypeItemQuestionsTypeItemAnswersTypeItem
    {
        [JsonProperty("choice_id")]
        public string ChoiceID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Surveymonkey;

    public partial class WorkflowManagedActions
    {
        public SurveymonkeyActions Surveymonkey(string connectionId) => new SurveymonkeyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SurveymonkeyTriggers Surveymonkey(string connectionId) => new SurveymonkeyTriggers(connectionId);
    }
}