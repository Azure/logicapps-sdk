//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cosmobot
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CosmobotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<JToken> GetGlobalSettings()
        {
            var apiCallPath = "/global-settings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<AskQuestionResponse> AskQuestion([WorkflowExpression] Func<string> requestBodyquestion, [WorkflowExpression] Func<int> requestBodyscoreThreshold = null, [WorkflowExpression] Func<string> requestBodyuserEmail = null)
        {
            var apiCallPath = "/ask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["question"] = ExpressionConverter.ConvertO(requestBodyquestion);
            if (requestBodyscoreThreshold != null)
            {
                requestBody["scoreThreshold"] = ExpressionConverter.ConvertO(requestBodyscoreThreshold);
                requestBodypropCount++;
            }

            if (requestBodyuserEmail != null)
            {
                requestBody["userEmail"] = ExpressionConverter.ConvertO(requestBodyuserEmail);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<AskQuestionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<ParseTextResponse> ParseText([WorkflowExpression] Func<string> requestBodyinputText, [WorkflowExpression] Func<requestBodyoutputFormatInput> requestBodyoutputFormat)
        {
            var apiCallPath = "/parse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["inputText"] = ExpressionConverter.ConvertO(requestBodyinputText);
            requestBodypropCount++;
            requestBody["outputFormat"] = ExpressionConverter.ConvertO(requestBodyoutputFormat);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<ParseTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<TranslateResponse> Translate([WorkflowExpression] Func<string> requestBodytargetLanguageCode, [WorkflowExpression] Func<string> requestBodyinputText)
        {
            var apiCallPath = "/translate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["targetLanguageCode"] = ExpressionConverter.ConvertO(requestBodytargetLanguageCode);
            requestBodypropCount++;
            requestBody["inputText"] = ExpressionConverter.ConvertO(requestBodyinputText);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<TranslateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetAllTopicsResponse> GetAllTopics([WorkflowExpression] Func<string> filterByExpert = null)
        {
            var apiCallPath = "/get-all-topics";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filterByExpert != null)
                callPayload.Queries["filterByExpert"] = ExpressionConverter.Convert(filterByExpert);
            return new ApiConnectionAction<GetAllTopicsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetTopicResponse> GetTopic([WorkflowExpression] Func<string> topicName)
        {
            var apiCallPath = "/get-topic";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["topicName"] = ExpressionConverter.Convert(topicName);
            return new ApiConnectionAction<GetTopicResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetAllAnswersResponse> GetAllAnswers([WorkflowExpression] Func<string> filterByTopic = null, [WorkflowExpression] Func<string> filterByShortDescription = null, [WorkflowExpression] Func<string> filterByQuestionText = null, [WorkflowExpression] Func<string> filterByAnswerText = null)
        {
            var apiCallPath = "/get-all-answers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filterByTopic != null)
                callPayload.Queries["filterByTopic"] = ExpressionConverter.Convert(filterByTopic);
            if (filterByShortDescription != null)
                callPayload.Queries["filterByShortDescription"] = ExpressionConverter.Convert(filterByShortDescription);
            if (filterByQuestionText != null)
                callPayload.Queries["filterByQuestionText"] = ExpressionConverter.Convert(filterByQuestionText);
            if (filterByAnswerText != null)
                callPayload.Queries["filterByAnswerText"] = ExpressionConverter.Convert(filterByAnswerText);
            return new ApiConnectionAction<GetAllAnswersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetExpertsResponse> GetExperts([WorkflowExpression] Func<string> topic)
        {
            var apiCallPath = "/get-experts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["topic"] = ExpressionConverter.Convert(topic);
            return new ApiConnectionAction<GetExpertsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddExpert([WorkflowExpression] Func<string> requestBodytopic, [WorkflowExpression] Func<string> requestBodyexpertEmail)
        {
            var apiCallPath = "/add-expert";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["topic"] = ExpressionConverter.ConvertO(requestBodytopic);
            requestBodypropCount++;
            requestBody["expertEmail"] = ExpressionConverter.ConvertO(requestBodyexpertEmail);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction RemoveExpert([WorkflowExpression] Func<string> requestBodyexpertEmail, [WorkflowExpression] Func<string> requestBodytopic = null)
        {
            var apiCallPath = "/remove-expert";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["expertEmail"] = ExpressionConverter.ConvertO(requestBodyexpertEmail);
            if (requestBodytopic != null)
            {
                requestBody["topic"] = ExpressionConverter.ConvertO(requestBodytopic);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddTopic([WorkflowExpression] Func<string> requestBodyname, [WorkflowExpression] Func<string> requestBodydescription, [WorkflowExpression] Func<string[]> requestBodyexpertEmails)
        {
            var apiCallPath = "/add-topic";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["name"] = ExpressionConverter.ConvertO(requestBodyname);
            requestBodypropCount++;
            requestBody["description"] = ExpressionConverter.ConvertO(requestBodydescription);
            requestBodypropCount++;
            requestBody["expertEmails"] = ExpressionConverter.ConvertO(requestBodyexpertEmails);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction RenameTopic([WorkflowExpression] Func<string> requestBodyname, [WorkflowExpression] Func<string> requestBodynewName)
        {
            var apiCallPath = "/rename-topic";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["name"] = ExpressionConverter.ConvertO(requestBodyname);
            requestBodypropCount++;
            requestBody["newName"] = ExpressionConverter.ConvertO(requestBodynewName);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddAnswer([WorkflowExpression] Func<string> requestBodytopic, [WorkflowExpression] Func<string> requestBodyshortDescription, [WorkflowExpression] Func<string[]> requestBodyquestions, [WorkflowExpression] Func<string> requestBodyanswerText, [WorkflowExpression] Func<string> requestBodyuserEmail = null)
        {
            var apiCallPath = "/add-answer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["topic"] = ExpressionConverter.ConvertO(requestBodytopic);
            requestBodypropCount++;
            requestBody["shortDescription"] = ExpressionConverter.ConvertO(requestBodyshortDescription);
            requestBodypropCount++;
            requestBody["questions"] = ExpressionConverter.ConvertO(requestBodyquestions);
            requestBodypropCount++;
            requestBody["answerText"] = ExpressionConverter.ConvertO(requestBodyanswerText);
            if (requestBodyuserEmail != null)
            {
                requestBody["userEmail"] = ExpressionConverter.ConvertO(requestBodyuserEmail);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction EditAnswer([WorkflowExpression] Func<string> requestBodyshortDescription, [WorkflowExpression] Func<string> requestBodynewTopic = null, [WorkflowExpression] Func<string> requestBodynewShortDescription = null, [WorkflowExpression] Func<string[]> requestBodynewQuestions = null, [WorkflowExpression] Func<string> requestBodynewAnswerText = null, [WorkflowExpression] Func<string> requestBodyuserEmail = null)
        {
            var apiCallPath = "/edit-answer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["shortDescription"] = ExpressionConverter.ConvertO(requestBodyshortDescription);
            if (requestBodynewTopic != null)
            {
                requestBody["newTopic"] = ExpressionConverter.ConvertO(requestBodynewTopic);
                requestBodypropCount++;
            }

            if (requestBodynewShortDescription != null)
            {
                requestBody["newShortDescription"] = ExpressionConverter.ConvertO(requestBodynewShortDescription);
                requestBodypropCount++;
            }

            if (requestBodynewQuestions != null)
            {
                requestBody["newQuestions"] = ExpressionConverter.ConvertO(requestBodynewQuestions);
                requestBodypropCount++;
            }

            if (requestBodynewAnswerText != null)
            {
                requestBody["newAnswerText"] = ExpressionConverter.ConvertO(requestBodynewAnswerText);
                requestBodypropCount++;
            }

            if (requestBodyuserEmail != null)
            {
                requestBody["userEmail"] = ExpressionConverter.ConvertO(requestBodyuserEmail);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction DeleteAnswer([WorkflowExpression] Func<string> requestBodyshortDescription)
        {
            var apiCallPath = "/delete-answer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["shortDescription"] = ExpressionConverter.ConvertO(requestBodyshortDescription);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddSubAnswer([WorkflowExpression] Func<string> requestBodyshortDescription, [WorkflowExpression] Func<string> requestBodysubShortDescription, [WorkflowExpression] Func<string[]> requestBodysubQuestions, [WorkflowExpression] Func<string> requestBodysubAnswerText)
        {
            var apiCallPath = "/add-subanswer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["shortDescription"] = ExpressionConverter.ConvertO(requestBodyshortDescription);
            requestBodypropCount++;
            requestBody["subShortDescription"] = ExpressionConverter.ConvertO(requestBodysubShortDescription);
            requestBodypropCount++;
            requestBody["subQuestions"] = ExpressionConverter.ConvertO(requestBodysubQuestions);
            requestBodypropCount++;
            requestBody["subAnswerText"] = ExpressionConverter.ConvertO(requestBodysubAnswerText);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetOpenTicketsResponse> GetOpenTickets([WorkflowExpression] Func<int> filterByHoursSinceOpened = null, [WorkflowExpression] Func<int> filterByHoursSinceOpenedMax = null, [WorkflowExpression] Func<string> filterByTopic = null, [WorkflowExpression] Func<string> filterByExpertEmail = null)
        {
            var apiCallPath = "/get-tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filterByHoursSinceOpened != null)
                callPayload.Queries["filterByHoursSinceOpened"] = ExpressionConverter.Convert(filterByHoursSinceOpened);
            if (filterByHoursSinceOpenedMax != null)
                callPayload.Queries["filterByHoursSinceOpenedMax"] = ExpressionConverter.Convert(filterByHoursSinceOpenedMax);
            if (filterByTopic != null)
                callPayload.Queries["filterByTopic"] = ExpressionConverter.Convert(filterByTopic);
            if (filterByExpertEmail != null)
                callPayload.Queries["filterByExpertEmail"] = ExpressionConverter.Convert(filterByExpertEmail);
            return new ApiConnectionAction<GetOpenTicketsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<OpenTicketQuestionResponse> OpenTicketQuestion([WorkflowExpression] Func<string> requestBodyuserEmail, [WorkflowExpression] Func<string> requestBodyqueryText, [WorkflowExpression] Func<string> requestBodytopic = null)
        {
            var apiCallPath = "/open-ticket-question";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["userEmail"] = ExpressionConverter.ConvertO(requestBodyuserEmail);
            requestBodypropCount++;
            requestBody["queryText"] = ExpressionConverter.ConvertO(requestBodyqueryText);
            if (requestBodytopic != null)
            {
                requestBody["topic"] = ExpressionConverter.ConvertO(requestBodytopic);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<OpenTicketQuestionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<OpenTicketFeedbackResponse> OpenTicketFeedback([WorkflowExpression] Func<string> requestBodyuserEmail, [WorkflowExpression] Func<string> requestBodyqueryText, [WorkflowExpression] Func<string> requestBodyanswerShortDescription, [WorkflowExpression] Func<string> requestBodyfeedbackText)
        {
            var apiCallPath = "/open-ticket-feedback";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["userEmail"] = ExpressionConverter.ConvertO(requestBodyuserEmail);
            requestBodypropCount++;
            requestBody["queryText"] = ExpressionConverter.ConvertO(requestBodyqueryText);
            requestBodypropCount++;
            requestBody["answerShortDescription"] = ExpressionConverter.ConvertO(requestBodyanswerShortDescription);
            requestBodypropCount++;
            requestBody["feedbackText"] = ExpressionConverter.ConvertO(requestBodyfeedbackText);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<OpenTicketFeedbackResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction CloseTicket([WorkflowExpression] Func<string> requestBodyticketId, [WorkflowExpression] Func<string> requestBodyeditorEmail, [WorkflowExpression] Func<string> requestBodyeditorComment)
        {
            var apiCallPath = "/close-ticket";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["ticketId"] = ExpressionConverter.ConvertO(requestBodyticketId);
            requestBodypropCount++;
            requestBody["editorEmail"] = ExpressionConverter.ConvertO(requestBodyeditorEmail);
            requestBodypropCount++;
            requestBody["editorComment"] = ExpressionConverter.ConvertO(requestBodyeditorComment);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class CosmobotTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger OnNewTicket(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/new-ticket";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBody["url"] = "#{listCallbackUrl()}";
            requestBodypropCount++;
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger OnResolvedTicket(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/resolved-ticket";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBody["url"] = "#{listCallbackUrl()}";
            requestBodypropCount++;
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger OnUpdatedTicketTopic(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/updated-ticket-topic";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBody["url"] = "#{listCallbackUrl()}";
            requestBodypropCount++;
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger OnNewAnswer(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/new-answer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBody["url"] = "#{listCallbackUrl()}";
            requestBodypropCount++;
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger OnUpdateAnswer(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/update-answer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBody["url"] = "#{listCallbackUrl()}";
            requestBodypropCount++;
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger OnAskedQuestion(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/asked-question";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBody["url"] = "#{listCallbackUrl()}";
            requestBodypropCount++;
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class AskQuestionResponse
    {
        [JsonProperty("foundAnswer")]
        public bool FoundAnswer { get; set; }

        [JsonProperty("isSubAnswer")]
        public bool IsSubAnswer { get; set; }

        [JsonProperty("isTranslated")]
        public bool IsTranslated { get; set; }

        [JsonProperty("answer")]
        public Answer Answer { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
    }

    public class Answer
    {
        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("questions")]
        public string[] Questions { get; set; }

        [JsonProperty("answerText")]
        public string AnswerText { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }
    }

    public class ParseTextResponse
    {
        [JsonProperty("outputText")]
        public string OutputText { get; set; }
    }

    public enum requestBodyoutputFormatInput
    {
        [EnumMember(Value = "markdown")]
        Markdown,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "plain")]
        Plain
    }

    public class TranslateResponse
    {
        [JsonProperty("outputText")]
        public string OutputText { get; set; }
    }

    public class GetAllTopicsResponse
    {
        [JsonProperty("topics")]
        public string[] Topics { get; set; }
    }

    public class GetTopicResponse
    {
        [JsonProperty("topic")]
        public GetTopicResponseTopicType Topic { get; set; }
    }

    public class GetTopicResponseTopicType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetAllAnswersResponse
    {
        [JsonProperty("answers")]
        public Answer[] Answers { get; set; }
    }

    public class GetExpertsResponse
    {
        [JsonProperty("expertEmails")]
        public string[] ExpertEmails { get; set; }
    }

    public class GetOpenTicketsResponse
    {
        [JsonProperty("tickets")]
        public Ticket[] Tickets { get; set; }
    }

    public class Ticket
    {
        [JsonProperty("ticketId")]
        public string TicketId { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("ticketUrl")]
        public string TicketUrl { get; set; }

        [JsonProperty("requesterEmail")]
        public string RequesterEmail { get; set; }

        [JsonProperty("expertEmails")]
        public string[] ExpertEmails { get; set; }

        [JsonProperty("queryText")]
        public string QueryText { get; set; }

        [JsonProperty("feedbackText")]
        public string FeedbackText { get; set; }

        [JsonProperty("answerShortDescription")]
        public string AnswerShortDescription { get; set; }

        [JsonProperty("answerText")]
        public string AnswerText { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class OpenTicketQuestionResponse
    {
        [JsonProperty("ticket")]
        public Ticket Ticket { get; set; }
    }

    public class OpenTicketFeedbackResponse
    {
        [JsonProperty("ticket")]
        public Ticket Ticket { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cosmobot;

    public partial class WorkflowManagedActions
    {
        public CosmobotActions Cosmobot(string connectionId) => new CosmobotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CosmobotTriggers Cosmobot(string connectionId) => new CosmobotTriggers(connectionId);
    }
}