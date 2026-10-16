//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Surveymonkeycanada
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SurveymonkeycanadaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surveymonkeycanada")]
        public IBodyWorkflowAction<Survey> GetSurvey(Expression<Func<string>> surveyId)
        {
            var __workflow_surveyId = WorkflowExpression.Compile(surveyId, nameof(surveyId), required: true);
            return new DeferredBodyAction<Survey>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/surveys/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_surveyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Survey>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surveymonkeycanada")]
        public IBodyWorkflowAction<SurveyMessageResponse> SendMessage(Expression<Func<string>> surveyId, Expression<Func<string>> collectorId, Expression<Func<string>> messageId, Expression<Func<string>> bodyscheduledDate = null)
        {
            var __workflow_surveyId = WorkflowExpression.Compile(surveyId, nameof(surveyId), required: true);
            var __workflow_collectorId = WorkflowExpression.Compile(collectorId, nameof(collectorId), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_bodyscheduledDate = WorkflowExpression.Compile(bodyscheduledDate, nameof(bodyscheduledDate), required: false);
            return new DeferredBodyAction<SurveyMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/collectors/{0}/messages/{1}/send", ExpressionConverter.ConvertWithUrlEncoding(__workflow_collectorId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["surveyId"] = ExpressionConverter.Convert(__workflow_surveyId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyscheduledDate != null)
                {
                    body["scheduled_date"] = ExpressionConverter.ConvertO(__workflow_bodyscheduledDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SurveyMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surveymonkeycanada")]
        public IBodyWorkflowAction<GetResponseDetailsResponse> GetResponseDetails(Expression<Func<string>> surveyId, Expression<Func<string>> responseId, Expression<Func<string>> questionIds = null)
        {
            var __workflow_surveyId = WorkflowExpression.Compile(surveyId, nameof(surveyId), required: true);
            var __workflow_responseId = WorkflowExpression.Compile(responseId, nameof(responseId), required: true);
            var __workflow_questionIds = WorkflowExpression.Compile(questionIds, nameof(questionIds), required: false);
            return new DeferredBodyAction<GetResponseDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/actions1/surveys/{0}/responses/{1}/details", ExpressionConverter.ConvertWithUrlEncoding(__workflow_surveyId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_responseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["simple"] = Convert.ToString(true);
                if (__workflow_questionIds != null)
                    callPayload.Queries["question_ids"] = ExpressionConverter.Convert(__workflow_questionIds);
                return new ApiConnectionAction<GetResponseDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surveymonkeycanada")]
        public IBodyWorkflowAction<GetResponseDetailsNoPagesResponse> GetResponseDetailsNoPages(Expression<Func<string>> surveyId, Expression<Func<string>> responseId, Expression<Func<string>> questionIds = null)
        {
            var __workflow_surveyId = WorkflowExpression.Compile(surveyId, nameof(surveyId), required: true);
            var __workflow_responseId = WorkflowExpression.Compile(responseId, nameof(responseId), required: true);
            var __workflow_questionIds = WorkflowExpression.Compile(questionIds, nameof(questionIds), required: false);
            return new DeferredBodyAction<GetResponseDetailsNoPagesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/actions2/surveys/{0}/responses/{1}/details", ExpressionConverter.ConvertWithUrlEncoding(__workflow_surveyId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_responseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["simple"] = Convert.ToString(true);
                if (__workflow_questionIds != null)
                    callPayload.Queries["question_ids"] = ExpressionConverter.Convert(__workflow_questionIds);
                return new ApiConnectionAction<GetResponseDetailsNoPagesResponse>(callPayload);
            });
        }
    }

    public class SurveymonkeycanadaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewSurveysItem[]> OnSurveyCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger1/surveys";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NewSurveysItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<NewCollectorsItem[]> OnSurveyCollectorCreated(Expression<Func<string>> surveyId, FlowRecurrence recurrence = null)
        {
            var __workflow_surveyId = WorkflowExpression.Compile(surveyId, nameof(surveyId), required: true);
            return new DeferredBodyTrigger<NewCollectorsItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger2/surveys/{0}/collectors", ExpressionConverter.ConvertWithUrlEncoding(__workflow_surveyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<NewCollectorsItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<SurveyResponsesItem[]> OnNewResponseAddedCollector(Expression<Func<string>> surveyId, Expression<Func<string>> collectorId, FlowRecurrence recurrence = null)
        {
            var __workflow_surveyId = WorkflowExpression.Compile(surveyId, nameof(surveyId), required: true);
            var __workflow_collectorId = WorkflowExpression.Compile(collectorId, nameof(collectorId), required: true);
            return new DeferredBodyTrigger<SurveyResponsesItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger3/collectors/{0}/responses/bulk", ExpressionConverter.ConvertWithUrlEncoding(__workflow_collectorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["surveyId"] = ExpressionConverter.Convert(__workflow_surveyId);
                return new ApiConnectionTrigger<SurveyResponsesItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<SurveyResponsesItem[]> OnNewResponseAddedSurvey(Expression<Func<string>> surveyId, FlowRecurrence recurrence = null)
        {
            var __workflow_surveyId = WorkflowExpression.Compile(surveyId, nameof(surveyId), required: true);
            return new DeferredBodyTrigger<SurveyResponsesItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger4/surveys/{0}/responses/bulk", ExpressionConverter.ConvertWithUrlEncoding(__workflow_surveyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<SurveyResponsesItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<SurveyResponsesItem[]> OnNewResponseToQuestionAdded(Expression<Func<string>> surveyId, Expression<Func<string>> pageIds = null, Expression<Func<string>> questionIds = null, FlowRecurrence recurrence = null)
        {
            var __workflow_surveyId = WorkflowExpression.Compile(surveyId, nameof(surveyId), required: true);
            var __workflow_pageIds = WorkflowExpression.Compile(pageIds, nameof(pageIds), required: false);
            var __workflow_questionIds = WorkflowExpression.Compile(questionIds, nameof(questionIds), required: false);
            return new DeferredBodyTrigger<SurveyResponsesItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger5/surveys/{0}/responses/bulk", ExpressionConverter.ConvertWithUrlEncoding(__workflow_surveyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pageIds != null)
                    callPayload.Queries["page_ids"] = ExpressionConverter.Convert(__workflow_pageIds);
                if (__workflow_questionIds != null)
                    callPayload.Queries["question_ids"] = ExpressionConverter.Convert(__workflow_questionIds);
                return new ApiConnectionTrigger<SurveyResponsesItem[]>(callPayload, recurrence: recurrence);
            });
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Surveymonkeycanada;

    public partial class WorkflowManagedActions
    {
        public SurveymonkeycanadaActions Surveymonkeycanada(string connectionId) => new SurveymonkeycanadaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SurveymonkeycanadaTriggers Surveymonkeycanada(string connectionId) => new SurveymonkeycanadaTriggers(connectionId);
    }
}
