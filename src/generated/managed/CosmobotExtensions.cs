//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cosmobot
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CosmobotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetGlobalSettings()
        {
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/global-settings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<AskQuestionResponse, ApiConnectionActionConfiguration> AskQuestion(Expression<Func<AskQuestionInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<AskQuestionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<AskQuestionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<ParseTextResponse, ApiConnectionActionConfiguration> ParseText(Expression<Func<ParseTextInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<ParseTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/parse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<ParseTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<TranslateResponse, ApiConnectionActionConfiguration> Translate(Expression<Func<TranslateInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<TranslateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<TranslateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetAllTopicsResponse, ApiConnectionActionConfiguration> GetAllTopics(Expression<Func<string>> filterByExpert = null)
        {
            var __workflow_filterByExpert = WorkflowExpression.Compile(filterByExpert, nameof(filterByExpert), required: false);
            return new DeferredBodyAction<GetAllTopicsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get-all-topics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filterByExpert != null)
                    callPayload.Queries["filterByExpert"] = ExpressionConverter.Convert(__workflow_filterByExpert);
                return new ApiConnectionAction<GetAllTopicsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetTopicResponse, ApiConnectionActionConfiguration> GetTopic(Expression<Func<string>> topicName)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            return new DeferredBodyAction<GetTopicResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get-topic";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["topicName"] = ExpressionConverter.Convert(__workflow_topicName);
                return new ApiConnectionAction<GetTopicResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetAllAnswersResponse, ApiConnectionActionConfiguration> GetAllAnswers(Expression<Func<string>> filterByTopic = null, Expression<Func<string>> filterByShortDescription = null, Expression<Func<string>> filterByQuestionText = null, Expression<Func<string>> filterByAnswerText = null)
        {
            var __workflow_filterByTopic = WorkflowExpression.Compile(filterByTopic, nameof(filterByTopic), required: false);
            var __workflow_filterByShortDescription = WorkflowExpression.Compile(filterByShortDescription, nameof(filterByShortDescription), required: false);
            var __workflow_filterByQuestionText = WorkflowExpression.Compile(filterByQuestionText, nameof(filterByQuestionText), required: false);
            var __workflow_filterByAnswerText = WorkflowExpression.Compile(filterByAnswerText, nameof(filterByAnswerText), required: false);
            return new DeferredBodyAction<GetAllAnswersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get-all-answers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filterByTopic != null)
                    callPayload.Queries["filterByTopic"] = ExpressionConverter.Convert(__workflow_filterByTopic);
                if (__workflow_filterByShortDescription != null)
                    callPayload.Queries["filterByShortDescription"] = ExpressionConverter.Convert(__workflow_filterByShortDescription);
                if (__workflow_filterByQuestionText != null)
                    callPayload.Queries["filterByQuestionText"] = ExpressionConverter.Convert(__workflow_filterByQuestionText);
                if (__workflow_filterByAnswerText != null)
                    callPayload.Queries["filterByAnswerText"] = ExpressionConverter.Convert(__workflow_filterByAnswerText);
                return new ApiConnectionAction<GetAllAnswersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetExpertsResponse, ApiConnectionActionConfiguration> GetExperts(Expression<Func<string>> topic)
        {
            var __workflow_topic = WorkflowExpression.Compile(topic, nameof(topic), required: true);
            return new DeferredBodyAction<GetExpertsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get-experts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["topic"] = ExpressionConverter.Convert(__workflow_topic);
                return new ApiConnectionAction<GetExpertsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddExpert(Expression<Func<AddExpertInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-expert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveExpert(Expression<Func<RemoveExpertInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/remove-expert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddTopic(Expression<Func<AddTopicInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-topic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RenameTopic(Expression<Func<RenameTopicInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/rename-topic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddAnswer(Expression<Func<AddAnswerInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditAnswer(Expression<Func<EditAnswerInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/edit-answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAnswer(Expression<Func<DeleteAnswerInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/delete-answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddSubAnswer(Expression<Func<AddSubAnswerInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-subanswer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetOpenTicketsResponse, ApiConnectionActionConfiguration> GetOpenTickets(Expression<Func<int>> filterByHoursSinceOpened = null, Expression<Func<int>> filterByHoursSinceOpenedMax = null, Expression<Func<string>> filterByTopic = null, Expression<Func<string>> filterByExpertEmail = null)
        {
            var __workflow_filterByHoursSinceOpened = WorkflowExpression.Compile(filterByHoursSinceOpened, nameof(filterByHoursSinceOpened), required: false);
            var __workflow_filterByHoursSinceOpenedMax = WorkflowExpression.Compile(filterByHoursSinceOpenedMax, nameof(filterByHoursSinceOpenedMax), required: false);
            var __workflow_filterByTopic = WorkflowExpression.Compile(filterByTopic, nameof(filterByTopic), required: false);
            var __workflow_filterByExpertEmail = WorkflowExpression.Compile(filterByExpertEmail, nameof(filterByExpertEmail), required: false);
            return new DeferredBodyAction<GetOpenTicketsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get-tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filterByHoursSinceOpened != null)
                    callPayload.Queries["filterByHoursSinceOpened"] = ExpressionConverter.Convert(__workflow_filterByHoursSinceOpened);
                if (__workflow_filterByHoursSinceOpenedMax != null)
                    callPayload.Queries["filterByHoursSinceOpenedMax"] = ExpressionConverter.Convert(__workflow_filterByHoursSinceOpenedMax);
                if (__workflow_filterByTopic != null)
                    callPayload.Queries["filterByTopic"] = ExpressionConverter.Convert(__workflow_filterByTopic);
                if (__workflow_filterByExpertEmail != null)
                    callPayload.Queries["filterByExpertEmail"] = ExpressionConverter.Convert(__workflow_filterByExpertEmail);
                return new ApiConnectionAction<GetOpenTicketsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<OpenTicketQuestionResponse, ApiConnectionActionConfiguration> OpenTicketQuestion(Expression<Func<OpenTicketQuestionInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<OpenTicketQuestionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/open-ticket-question";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<OpenTicketQuestionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<OpenTicketFeedbackResponse, ApiConnectionActionConfiguration> OpenTicketFeedback(Expression<Func<OpenTicketFeedbackInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<OpenTicketFeedbackResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/open-ticket-feedback";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<OpenTicketFeedbackResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CloseTicket(Expression<Func<CloseTicketInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/close-ticket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CosmobotTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> OnNewTicket(Expression<Func<OnNewTicketInput>> requestBody, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/new-ticket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> OnResolvedTicket(Expression<Func<OnResolvedTicketInput>> requestBody, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/resolved-ticket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> OnUpdatedTicketTopic(Expression<Func<OnUpdatedTicketTopicInput>> requestBody, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/updated-ticket-topic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> OnNewAnswer(Expression<Func<OnNewAnswerInput>> requestBody, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/new-answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> OnUpdateAnswer(Expression<Func<OnUpdateAnswerInput>> requestBody, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/update-answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> OnAskedQuestion(Expression<Func<OnAskedQuestionInput>> requestBody, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/asked-question";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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

    public class AskQuestionInput
    {
        [JsonProperty("question", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Question { get; set; }

        [JsonProperty("scoreThreshold")]
        public int? ScoreThreshold { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }
    }

    public class ParseTextResponse
    {
        [JsonProperty("outputText")]
        public string OutputText { get; set; }
    }

    public class ParseTextInput
    {
        [JsonProperty("inputText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputText { get; set; }

        [JsonProperty("outputFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParseTextInputOutputFormatType OutputFormat { get; set; } = ParseTextInputOutputFormatType.Markdown;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParseTextInputOutputFormatType
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

    public class TranslateInput
    {
        [JsonProperty("targetLanguageCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetLanguageCode { get; set; }

        [JsonProperty("inputText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputText { get; set; }
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

    public class AddExpertInput
    {
        [JsonProperty("topic", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Topic { get; set; }

        [JsonProperty("expertEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExpertEmail { get; set; }
    }

    public class RemoveExpertInput
    {
        [JsonProperty("expertEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExpertEmail { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }
    }

    public class AddTopicInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("expertEmails", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ExpertEmails { get; set; }
    }

    public class RenameTopicInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("newName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewName { get; set; }
    }

    public class AddAnswerInput
    {
        [JsonProperty("topic", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Topic { get; set; }

        [JsonProperty("shortDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShortDescription { get; set; }

        [JsonProperty("questions", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Questions { get; set; }

        [JsonProperty("answerText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AnswerText { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }
    }

    public class EditAnswerInput
    {
        [JsonProperty("shortDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShortDescription { get; set; }

        [JsonProperty("newTopic")]
        public string NewTopic { get; set; }

        [JsonProperty("newShortDescription")]
        public string NewShortDescription { get; set; }

        [JsonProperty("newQuestions")]
        public string[] NewQuestions { get; set; }

        [JsonProperty("newAnswerText")]
        public string NewAnswerText { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }
    }

    public class DeleteAnswerInput
    {
        [JsonProperty("shortDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShortDescription { get; set; }
    }

    public class AddSubAnswerInput
    {
        [JsonProperty("shortDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShortDescription { get; set; }

        [JsonProperty("subShortDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SubShortDescription { get; set; }

        [JsonProperty("subQuestions", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] SubQuestions { get; set; }

        [JsonProperty("subAnswerText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SubAnswerText { get; set; }
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

    public class OpenTicketQuestionInput
    {
        [JsonProperty("userEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserEmail { get; set; }

        [JsonProperty("queryText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string QueryText { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }
    }

    public class OpenTicketFeedbackResponse
    {
        [JsonProperty("ticket")]
        public Ticket Ticket { get; set; }
    }

    public class OpenTicketFeedbackInput
    {
        [JsonProperty("userEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserEmail { get; set; }

        [JsonProperty("queryText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string QueryText { get; set; }

        [JsonProperty("answerShortDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AnswerShortDescription { get; set; }

        [JsonProperty("feedbackText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeedbackText { get; set; }
    }

    public class CloseTicketInput
    {
        [JsonProperty("ticketId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketId { get; set; }

        [JsonProperty("editorEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EditorEmail { get; set; }

        [JsonProperty("editorComment", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EditorComment { get; set; }
    }

    public class OnNewTicketInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class OnResolvedTicketInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class OnUpdatedTicketTopicInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class OnNewAnswerInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class OnUpdateAnswerInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class OnAskedQuestionInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
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