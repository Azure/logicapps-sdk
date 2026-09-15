//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cosmobot
{
    using System.Linq.Expressions;
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
        public IBodyWorkflowAction<AskQuestionResponse> AskQuestion(Expression<Func<string>> requestBodyquestion, Expression<Func<int>> requestBodyscoreThreshold = null, Expression<Func<string>> requestBodyuserEmail = null)
        {
            var apiCallPath = "/ask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["question"] = CSharpExpressionConverter.ConvertToken(requestBodyquestion);
            if (requestBodyscoreThreshold != null)
            {
                requestBody["scoreThreshold"] = CSharpExpressionConverter.ConvertToken(requestBodyscoreThreshold);
                requestBodypropCount++;
            }

            if (requestBodyuserEmail != null)
            {
                requestBody["userEmail"] = CSharpExpressionConverter.ConvertToken(requestBodyuserEmail);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<AskQuestionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<ParseTextResponse> ParseText(Expression<Func<string>> requestBodyinputText, Expression<Func<requestBodyoutputFormatInput>> requestBodyoutputFormat)
        {
            var apiCallPath = "/parse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["inputText"] = CSharpExpressionConverter.ConvertToken(requestBodyinputText);
            requestBodypropCount++;
            requestBody["outputFormat"] = CSharpExpressionConverter.Convert(requestBodyoutputFormat);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<ParseTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<TranslateResponse> Translate(Expression<Func<string>> requestBodytargetLanguageCode, Expression<Func<string>> requestBodyinputText)
        {
            var apiCallPath = "/translate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["targetLanguageCode"] = CSharpExpressionConverter.ConvertToken(requestBodytargetLanguageCode);
            requestBodypropCount++;
            requestBody["inputText"] = CSharpExpressionConverter.ConvertToken(requestBodyinputText);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<TranslateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetAllTopicsResponse> GetAllTopics(Expression<Func<string>> filterByExpert = null)
        {
            var apiCallPath = "/get-all-topics";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filterByExpert != null)
                callPayload.Queries["filterByExpert"] = CSharpExpressionConverter.ConvertO(filterByExpert);
            return new ApiConnectionAction<GetAllTopicsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetTopicResponse> GetTopic(Expression<Func<string>> topicName)
        {
            var apiCallPath = "/get-topic";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["topicName"] = CSharpExpressionConverter.ConvertO(topicName);
            return new ApiConnectionAction<GetTopicResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetAllAnswersResponse> GetAllAnswers(Expression<Func<string>> filterByTopic = null, Expression<Func<string>> filterByShortDescription = null, Expression<Func<string>> filterByQuestionText = null, Expression<Func<string>> filterByAnswerText = null)
        {
            var apiCallPath = "/get-all-answers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filterByTopic != null)
                callPayload.Queries["filterByTopic"] = CSharpExpressionConverter.ConvertO(filterByTopic);
            if (filterByShortDescription != null)
                callPayload.Queries["filterByShortDescription"] = CSharpExpressionConverter.ConvertO(filterByShortDescription);
            if (filterByQuestionText != null)
                callPayload.Queries["filterByQuestionText"] = CSharpExpressionConverter.ConvertO(filterByQuestionText);
            if (filterByAnswerText != null)
                callPayload.Queries["filterByAnswerText"] = CSharpExpressionConverter.ConvertO(filterByAnswerText);
            return new ApiConnectionAction<GetAllAnswersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetExpertsResponse> GetExperts(Expression<Func<string>> topic)
        {
            var apiCallPath = "/get-experts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["topic"] = CSharpExpressionConverter.ConvertO(topic);
            return new ApiConnectionAction<GetExpertsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddExpert(Expression<Func<string>> requestBodytopic, Expression<Func<string>> requestBodyexpertEmail)
        {
            var apiCallPath = "/add-expert";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["topic"] = CSharpExpressionConverter.ConvertToken(requestBodytopic);
            requestBodypropCount++;
            requestBody["expertEmail"] = CSharpExpressionConverter.ConvertToken(requestBodyexpertEmail);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction RemoveExpert(Expression<Func<string>> requestBodyexpertEmail, Expression<Func<string>> requestBodytopic = null)
        {
            var apiCallPath = "/remove-expert";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["expertEmail"] = CSharpExpressionConverter.ConvertToken(requestBodyexpertEmail);
            if (requestBodytopic != null)
            {
                requestBody["topic"] = CSharpExpressionConverter.ConvertToken(requestBodytopic);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddTopic(Expression<Func<string>> requestBodyname, Expression<Func<string>> requestBodydescription, Expression<Func<string[]>> requestBodyexpertEmails)
        {
            var apiCallPath = "/add-topic";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["name"] = CSharpExpressionConverter.ConvertToken(requestBodyname);
            requestBodypropCount++;
            requestBody["description"] = CSharpExpressionConverter.ConvertToken(requestBodydescription);
            requestBodypropCount++;
            requestBody["expertEmails"] = CSharpExpressionConverter.ConvertToken(requestBodyexpertEmails);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction RenameTopic(Expression<Func<string>> requestBodyname, Expression<Func<string>> requestBodynewName)
        {
            var apiCallPath = "/rename-topic";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["name"] = CSharpExpressionConverter.ConvertToken(requestBodyname);
            requestBodypropCount++;
            requestBody["newName"] = CSharpExpressionConverter.ConvertToken(requestBodynewName);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddAnswer(Expression<Func<string>> requestBodytopic, Expression<Func<string>> requestBodyshortDescription, Expression<Func<string[]>> requestBodyquestions, Expression<Func<string>> requestBodyanswerText, Expression<Func<string>> requestBodyuserEmail = null)
        {
            var apiCallPath = "/add-answer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["topic"] = CSharpExpressionConverter.ConvertToken(requestBodytopic);
            requestBodypropCount++;
            requestBody["shortDescription"] = CSharpExpressionConverter.ConvertToken(requestBodyshortDescription);
            requestBodypropCount++;
            requestBody["questions"] = CSharpExpressionConverter.ConvertToken(requestBodyquestions);
            requestBodypropCount++;
            requestBody["answerText"] = CSharpExpressionConverter.ConvertToken(requestBodyanswerText);
            if (requestBodyuserEmail != null)
            {
                requestBody["userEmail"] = CSharpExpressionConverter.ConvertToken(requestBodyuserEmail);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction EditAnswer(Expression<Func<string>> requestBodyshortDescription, Expression<Func<string>> requestBodynewTopic = null, Expression<Func<string>> requestBodynewShortDescription = null, Expression<Func<string[]>> requestBodynewQuestions = null, Expression<Func<string>> requestBodynewAnswerText = null, Expression<Func<string>> requestBodyuserEmail = null)
        {
            var apiCallPath = "/edit-answer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["shortDescription"] = CSharpExpressionConverter.ConvertToken(requestBodyshortDescription);
            if (requestBodynewTopic != null)
            {
                requestBody["newTopic"] = CSharpExpressionConverter.ConvertToken(requestBodynewTopic);
                requestBodypropCount++;
            }

            if (requestBodynewShortDescription != null)
            {
                requestBody["newShortDescription"] = CSharpExpressionConverter.ConvertToken(requestBodynewShortDescription);
                requestBodypropCount++;
            }

            if (requestBodynewQuestions != null)
            {
                requestBody["newQuestions"] = CSharpExpressionConverter.ConvertToken(requestBodynewQuestions);
                requestBodypropCount++;
            }

            if (requestBodynewAnswerText != null)
            {
                requestBody["newAnswerText"] = CSharpExpressionConverter.ConvertToken(requestBodynewAnswerText);
                requestBodypropCount++;
            }

            if (requestBodyuserEmail != null)
            {
                requestBody["userEmail"] = CSharpExpressionConverter.ConvertToken(requestBodyuserEmail);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction DeleteAnswer(Expression<Func<string>> requestBodyshortDescription)
        {
            var apiCallPath = "/delete-answer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["shortDescription"] = CSharpExpressionConverter.ConvertToken(requestBodyshortDescription);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddSubAnswer(Expression<Func<string>> requestBodyshortDescription, Expression<Func<string>> requestBodysubShortDescription, Expression<Func<string[]>> requestBodysubQuestions, Expression<Func<string>> requestBodysubAnswerText)
        {
            var apiCallPath = "/add-subanswer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["shortDescription"] = CSharpExpressionConverter.ConvertToken(requestBodyshortDescription);
            requestBodypropCount++;
            requestBody["subShortDescription"] = CSharpExpressionConverter.ConvertToken(requestBodysubShortDescription);
            requestBodypropCount++;
            requestBody["subQuestions"] = CSharpExpressionConverter.ConvertToken(requestBodysubQuestions);
            requestBodypropCount++;
            requestBody["subAnswerText"] = CSharpExpressionConverter.ConvertToken(requestBodysubAnswerText);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetOpenTicketsResponse> GetOpenTickets(Expression<Func<int>> filterByHoursSinceOpened = null, Expression<Func<int>> filterByHoursSinceOpenedMax = null, Expression<Func<string>> filterByTopic = null, Expression<Func<string>> filterByExpertEmail = null)
        {
            var apiCallPath = "/get-tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filterByHoursSinceOpened != null)
                callPayload.Queries["filterByHoursSinceOpened"] = CSharpExpressionConverter.ConvertO(filterByHoursSinceOpened);
            if (filterByHoursSinceOpenedMax != null)
                callPayload.Queries["filterByHoursSinceOpenedMax"] = CSharpExpressionConverter.ConvertO(filterByHoursSinceOpenedMax);
            if (filterByTopic != null)
                callPayload.Queries["filterByTopic"] = CSharpExpressionConverter.ConvertO(filterByTopic);
            if (filterByExpertEmail != null)
                callPayload.Queries["filterByExpertEmail"] = CSharpExpressionConverter.ConvertO(filterByExpertEmail);
            return new ApiConnectionAction<GetOpenTicketsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<OpenTicketQuestionResponse> OpenTicketQuestion(Expression<Func<string>> requestBodyuserEmail, Expression<Func<string>> requestBodyqueryText, Expression<Func<string>> requestBodytopic = null)
        {
            var apiCallPath = "/open-ticket-question";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["userEmail"] = CSharpExpressionConverter.ConvertToken(requestBodyuserEmail);
            requestBodypropCount++;
            requestBody["queryText"] = CSharpExpressionConverter.ConvertToken(requestBodyqueryText);
            if (requestBodytopic != null)
            {
                requestBody["topic"] = CSharpExpressionConverter.ConvertToken(requestBodytopic);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<OpenTicketQuestionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<OpenTicketFeedbackResponse> OpenTicketFeedback(Expression<Func<string>> requestBodyuserEmail, Expression<Func<string>> requestBodyqueryText, Expression<Func<string>> requestBodyanswerShortDescription, Expression<Func<string>> requestBodyfeedbackText)
        {
            var apiCallPath = "/open-ticket-feedback";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["userEmail"] = CSharpExpressionConverter.ConvertToken(requestBodyuserEmail);
            requestBodypropCount++;
            requestBody["queryText"] = CSharpExpressionConverter.ConvertToken(requestBodyqueryText);
            requestBodypropCount++;
            requestBody["answerShortDescription"] = CSharpExpressionConverter.ConvertToken(requestBodyanswerShortDescription);
            requestBodypropCount++;
            requestBody["feedbackText"] = CSharpExpressionConverter.ConvertToken(requestBodyfeedbackText);
            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<OpenTicketFeedbackResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction CloseTicket(Expression<Func<string>> requestBodyticketId, Expression<Func<string>> requestBodyeditorEmail, Expression<Func<string>> requestBodyeditorComment)
        {
            var apiCallPath = "/close-ticket";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["ticketId"] = CSharpExpressionConverter.ConvertToken(requestBodyticketId);
            requestBodypropCount++;
            requestBody["editorEmail"] = CSharpExpressionConverter.ConvertToken(requestBodyeditorEmail);
            requestBodypropCount++;
            requestBody["editorComment"] = CSharpExpressionConverter.ConvertToken(requestBodyeditorComment);
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
            requestBody["url"] = "@listCallbackUrl()";
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
            requestBody["url"] = "@listCallbackUrl()";
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
            requestBody["url"] = "@listCallbackUrl()";
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
            requestBody["url"] = "@listCallbackUrl()";
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
            requestBody["url"] = "@listCallbackUrl()";
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
            requestBody["url"] = "@listCallbackUrl()";
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