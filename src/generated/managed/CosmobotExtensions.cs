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
            var __workflow_requestBodyquestion = WorkflowExpression.Compile(requestBodyquestion, nameof(requestBodyquestion), required: true);
            var __workflow_requestBodyscoreThreshold = WorkflowExpression.Compile(requestBodyscoreThreshold, nameof(requestBodyscoreThreshold), required: false);
            var __workflow_requestBodyuserEmail = WorkflowExpression.Compile(requestBodyuserEmail, nameof(requestBodyuserEmail), required: false);
            return new DeferredBodyAction<AskQuestionResponse>(() =>
            {
                var apiCallPath = "/ask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["question"] = ExpressionConverter.ConvertO(__workflow_requestBodyquestion);
                if (__workflow_requestBodyscoreThreshold != null)
                {
                    requestBody["scoreThreshold"] = ExpressionConverter.ConvertO(__workflow_requestBodyscoreThreshold);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyuserEmail != null)
                {
                    requestBody["userEmail"] = ExpressionConverter.ConvertO(__workflow_requestBodyuserEmail);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<AskQuestionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<ParseTextResponse> ParseText(Expression<Func<string>> requestBodyinputText, Expression<Func<requestBodyoutputFormatInput>> requestBodyoutputFormat)
        {
            var __workflow_requestBodyinputText = WorkflowExpression.Compile(requestBodyinputText, nameof(requestBodyinputText), required: true);
            var __workflow_requestBodyoutputFormat = WorkflowExpression.Compile(requestBodyoutputFormat, nameof(requestBodyoutputFormat), required: true);
            return new DeferredBodyAction<ParseTextResponse>(() =>
            {
                var apiCallPath = "/parse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["inputText"] = ExpressionConverter.ConvertO(__workflow_requestBodyinputText);
                requestBodypropCount++;
                requestBody["outputFormat"] = ExpressionConverter.ConvertO(__workflow_requestBodyoutputFormat);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<ParseTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<TranslateResponse> Translate(Expression<Func<string>> requestBodytargetLanguageCode, Expression<Func<string>> requestBodyinputText)
        {
            var __workflow_requestBodytargetLanguageCode = WorkflowExpression.Compile(requestBodytargetLanguageCode, nameof(requestBodytargetLanguageCode), required: true);
            var __workflow_requestBodyinputText = WorkflowExpression.Compile(requestBodyinputText, nameof(requestBodyinputText), required: true);
            return new DeferredBodyAction<TranslateResponse>(() =>
            {
                var apiCallPath = "/translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["targetLanguageCode"] = ExpressionConverter.ConvertO(__workflow_requestBodytargetLanguageCode);
                requestBodypropCount++;
                requestBody["inputText"] = ExpressionConverter.ConvertO(__workflow_requestBodyinputText);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<TranslateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetAllTopicsResponse> GetAllTopics(Expression<Func<string>> filterByExpert = null)
        {
            var __workflow_filterByExpert = WorkflowExpression.Compile(filterByExpert, nameof(filterByExpert), required: false);
            return new DeferredBodyAction<GetAllTopicsResponse>(() =>
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
        public IBodyWorkflowAction<GetTopicResponse> GetTopic(Expression<Func<string>> topicName)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            return new DeferredBodyAction<GetTopicResponse>(() =>
            {
                var apiCallPath = "/get-topic";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["topicName"] = ExpressionConverter.Convert(__workflow_topicName);
                return new ApiConnectionAction<GetTopicResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetAllAnswersResponse> GetAllAnswers(Expression<Func<string>> filterByTopic = null, Expression<Func<string>> filterByShortDescription = null, Expression<Func<string>> filterByQuestionText = null, Expression<Func<string>> filterByAnswerText = null)
        {
            var __workflow_filterByTopic = WorkflowExpression.Compile(filterByTopic, nameof(filterByTopic), required: false);
            var __workflow_filterByShortDescription = WorkflowExpression.Compile(filterByShortDescription, nameof(filterByShortDescription), required: false);
            var __workflow_filterByQuestionText = WorkflowExpression.Compile(filterByQuestionText, nameof(filterByQuestionText), required: false);
            var __workflow_filterByAnswerText = WorkflowExpression.Compile(filterByAnswerText, nameof(filterByAnswerText), required: false);
            return new DeferredBodyAction<GetAllAnswersResponse>(() =>
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
        public IBodyWorkflowAction<GetExpertsResponse> GetExperts(Expression<Func<string>> topic)
        {
            var __workflow_topic = WorkflowExpression.Compile(topic, nameof(topic), required: true);
            return new DeferredBodyAction<GetExpertsResponse>(() =>
            {
                var apiCallPath = "/get-experts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["topic"] = ExpressionConverter.Convert(__workflow_topic);
                return new ApiConnectionAction<GetExpertsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddExpert(Expression<Func<string>> requestBodytopic, Expression<Func<string>> requestBodyexpertEmail)
        {
            var __workflow_requestBodytopic = WorkflowExpression.Compile(requestBodytopic, nameof(requestBodytopic), required: true);
            var __workflow_requestBodyexpertEmail = WorkflowExpression.Compile(requestBodyexpertEmail, nameof(requestBodyexpertEmail), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/add-expert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["topic"] = ExpressionConverter.ConvertO(__workflow_requestBodytopic);
                requestBodypropCount++;
                requestBody["expertEmail"] = ExpressionConverter.ConvertO(__workflow_requestBodyexpertEmail);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction RemoveExpert(Expression<Func<string>> requestBodyexpertEmail, Expression<Func<string>> requestBodytopic = null)
        {
            var __workflow_requestBodyexpertEmail = WorkflowExpression.Compile(requestBodyexpertEmail, nameof(requestBodyexpertEmail), required: true);
            var __workflow_requestBodytopic = WorkflowExpression.Compile(requestBodytopic, nameof(requestBodytopic), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/remove-expert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["expertEmail"] = ExpressionConverter.ConvertO(__workflow_requestBodyexpertEmail);
                if (__workflow_requestBodytopic != null)
                {
                    requestBody["topic"] = ExpressionConverter.ConvertO(__workflow_requestBodytopic);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddTopic(Expression<Func<string>> requestBodyname, Expression<Func<string>> requestBodydescription, Expression<Func<string[]>> requestBodyexpertEmails)
        {
            var __workflow_requestBodyname = WorkflowExpression.Compile(requestBodyname, nameof(requestBodyname), required: true);
            var __workflow_requestBodydescription = WorkflowExpression.Compile(requestBodydescription, nameof(requestBodydescription), required: true);
            var __workflow_requestBodyexpertEmails = WorkflowExpression.Compile(requestBodyexpertEmails, nameof(requestBodyexpertEmails), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/add-topic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["name"] = ExpressionConverter.ConvertO(__workflow_requestBodyname);
                requestBodypropCount++;
                requestBody["description"] = ExpressionConverter.ConvertO(__workflow_requestBodydescription);
                requestBodypropCount++;
                requestBody["expertEmails"] = ExpressionConverter.ConvertO(__workflow_requestBodyexpertEmails);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction RenameTopic(Expression<Func<string>> requestBodyname, Expression<Func<string>> requestBodynewName)
        {
            var __workflow_requestBodyname = WorkflowExpression.Compile(requestBodyname, nameof(requestBodyname), required: true);
            var __workflow_requestBodynewName = WorkflowExpression.Compile(requestBodynewName, nameof(requestBodynewName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/rename-topic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["name"] = ExpressionConverter.ConvertO(__workflow_requestBodyname);
                requestBodypropCount++;
                requestBody["newName"] = ExpressionConverter.ConvertO(__workflow_requestBodynewName);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddAnswer(Expression<Func<string>> requestBodytopic, Expression<Func<string>> requestBodyshortDescription, Expression<Func<string[]>> requestBodyquestions, Expression<Func<string>> requestBodyanswerText, Expression<Func<string>> requestBodyuserEmail = null)
        {
            var __workflow_requestBodytopic = WorkflowExpression.Compile(requestBodytopic, nameof(requestBodytopic), required: true);
            var __workflow_requestBodyshortDescription = WorkflowExpression.Compile(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            var __workflow_requestBodyquestions = WorkflowExpression.Compile(requestBodyquestions, nameof(requestBodyquestions), required: true);
            var __workflow_requestBodyanswerText = WorkflowExpression.Compile(requestBodyanswerText, nameof(requestBodyanswerText), required: true);
            var __workflow_requestBodyuserEmail = WorkflowExpression.Compile(requestBodyuserEmail, nameof(requestBodyuserEmail), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/add-answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["topic"] = ExpressionConverter.ConvertO(__workflow_requestBodytopic);
                requestBodypropCount++;
                requestBody["shortDescription"] = ExpressionConverter.ConvertO(__workflow_requestBodyshortDescription);
                requestBodypropCount++;
                requestBody["questions"] = ExpressionConverter.ConvertO(__workflow_requestBodyquestions);
                requestBodypropCount++;
                requestBody["answerText"] = ExpressionConverter.ConvertO(__workflow_requestBodyanswerText);
                if (__workflow_requestBodyuserEmail != null)
                {
                    requestBody["userEmail"] = ExpressionConverter.ConvertO(__workflow_requestBodyuserEmail);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction EditAnswer(Expression<Func<string>> requestBodyshortDescription, Expression<Func<string>> requestBodynewTopic = null, Expression<Func<string>> requestBodynewShortDescription = null, Expression<Func<string[]>> requestBodynewQuestions = null, Expression<Func<string>> requestBodynewAnswerText = null, Expression<Func<string>> requestBodyuserEmail = null)
        {
            var __workflow_requestBodyshortDescription = WorkflowExpression.Compile(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            var __workflow_requestBodynewTopic = WorkflowExpression.Compile(requestBodynewTopic, nameof(requestBodynewTopic), required: false);
            var __workflow_requestBodynewShortDescription = WorkflowExpression.Compile(requestBodynewShortDescription, nameof(requestBodynewShortDescription), required: false);
            var __workflow_requestBodynewQuestions = WorkflowExpression.Compile(requestBodynewQuestions, nameof(requestBodynewQuestions), required: false);
            var __workflow_requestBodynewAnswerText = WorkflowExpression.Compile(requestBodynewAnswerText, nameof(requestBodynewAnswerText), required: false);
            var __workflow_requestBodyuserEmail = WorkflowExpression.Compile(requestBodyuserEmail, nameof(requestBodyuserEmail), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/edit-answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["shortDescription"] = ExpressionConverter.ConvertO(__workflow_requestBodyshortDescription);
                if (__workflow_requestBodynewTopic != null)
                {
                    requestBody["newTopic"] = ExpressionConverter.ConvertO(__workflow_requestBodynewTopic);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodynewShortDescription != null)
                {
                    requestBody["newShortDescription"] = ExpressionConverter.ConvertO(__workflow_requestBodynewShortDescription);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodynewQuestions != null)
                {
                    requestBody["newQuestions"] = ExpressionConverter.ConvertO(__workflow_requestBodynewQuestions);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodynewAnswerText != null)
                {
                    requestBody["newAnswerText"] = ExpressionConverter.ConvertO(__workflow_requestBodynewAnswerText);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyuserEmail != null)
                {
                    requestBody["userEmail"] = ExpressionConverter.ConvertO(__workflow_requestBodyuserEmail);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction DeleteAnswer(Expression<Func<string>> requestBodyshortDescription)
        {
            var __workflow_requestBodyshortDescription = WorkflowExpression.Compile(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/delete-answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["shortDescription"] = ExpressionConverter.ConvertO(__workflow_requestBodyshortDescription);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddSubAnswer(Expression<Func<string>> requestBodyshortDescription, Expression<Func<string>> requestBodysubShortDescription, Expression<Func<string[]>> requestBodysubQuestions, Expression<Func<string>> requestBodysubAnswerText)
        {
            var __workflow_requestBodyshortDescription = WorkflowExpression.Compile(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            var __workflow_requestBodysubShortDescription = WorkflowExpression.Compile(requestBodysubShortDescription, nameof(requestBodysubShortDescription), required: true);
            var __workflow_requestBodysubQuestions = WorkflowExpression.Compile(requestBodysubQuestions, nameof(requestBodysubQuestions), required: true);
            var __workflow_requestBodysubAnswerText = WorkflowExpression.Compile(requestBodysubAnswerText, nameof(requestBodysubAnswerText), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/add-subanswer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["shortDescription"] = ExpressionConverter.ConvertO(__workflow_requestBodyshortDescription);
                requestBodypropCount++;
                requestBody["subShortDescription"] = ExpressionConverter.ConvertO(__workflow_requestBodysubShortDescription);
                requestBodypropCount++;
                requestBody["subQuestions"] = ExpressionConverter.ConvertO(__workflow_requestBodysubQuestions);
                requestBodypropCount++;
                requestBody["subAnswerText"] = ExpressionConverter.ConvertO(__workflow_requestBodysubAnswerText);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetOpenTicketsResponse> GetOpenTickets(Expression<Func<int>> filterByHoursSinceOpened = null, Expression<Func<int>> filterByHoursSinceOpenedMax = null, Expression<Func<string>> filterByTopic = null, Expression<Func<string>> filterByExpertEmail = null)
        {
            var __workflow_filterByHoursSinceOpened = WorkflowExpression.Compile(filterByHoursSinceOpened, nameof(filterByHoursSinceOpened), required: false);
            var __workflow_filterByHoursSinceOpenedMax = WorkflowExpression.Compile(filterByHoursSinceOpenedMax, nameof(filterByHoursSinceOpenedMax), required: false);
            var __workflow_filterByTopic = WorkflowExpression.Compile(filterByTopic, nameof(filterByTopic), required: false);
            var __workflow_filterByExpertEmail = WorkflowExpression.Compile(filterByExpertEmail, nameof(filterByExpertEmail), required: false);
            return new DeferredBodyAction<GetOpenTicketsResponse>(() =>
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
        public IBodyWorkflowAction<OpenTicketQuestionResponse> OpenTicketQuestion(Expression<Func<string>> requestBodyuserEmail, Expression<Func<string>> requestBodyqueryText, Expression<Func<string>> requestBodytopic = null)
        {
            var __workflow_requestBodyuserEmail = WorkflowExpression.Compile(requestBodyuserEmail, nameof(requestBodyuserEmail), required: true);
            var __workflow_requestBodyqueryText = WorkflowExpression.Compile(requestBodyqueryText, nameof(requestBodyqueryText), required: true);
            var __workflow_requestBodytopic = WorkflowExpression.Compile(requestBodytopic, nameof(requestBodytopic), required: false);
            return new DeferredBodyAction<OpenTicketQuestionResponse>(() =>
            {
                var apiCallPath = "/open-ticket-question";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["userEmail"] = ExpressionConverter.ConvertO(__workflow_requestBodyuserEmail);
                requestBodypropCount++;
                requestBody["queryText"] = ExpressionConverter.ConvertO(__workflow_requestBodyqueryText);
                if (__workflow_requestBodytopic != null)
                {
                    requestBody["topic"] = ExpressionConverter.ConvertO(__workflow_requestBodytopic);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<OpenTicketQuestionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<OpenTicketFeedbackResponse> OpenTicketFeedback(Expression<Func<string>> requestBodyuserEmail, Expression<Func<string>> requestBodyqueryText, Expression<Func<string>> requestBodyanswerShortDescription, Expression<Func<string>> requestBodyfeedbackText)
        {
            var __workflow_requestBodyuserEmail = WorkflowExpression.Compile(requestBodyuserEmail, nameof(requestBodyuserEmail), required: true);
            var __workflow_requestBodyqueryText = WorkflowExpression.Compile(requestBodyqueryText, nameof(requestBodyqueryText), required: true);
            var __workflow_requestBodyanswerShortDescription = WorkflowExpression.Compile(requestBodyanswerShortDescription, nameof(requestBodyanswerShortDescription), required: true);
            var __workflow_requestBodyfeedbackText = WorkflowExpression.Compile(requestBodyfeedbackText, nameof(requestBodyfeedbackText), required: true);
            return new DeferredBodyAction<OpenTicketFeedbackResponse>(() =>
            {
                var apiCallPath = "/open-ticket-feedback";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["userEmail"] = ExpressionConverter.ConvertO(__workflow_requestBodyuserEmail);
                requestBodypropCount++;
                requestBody["queryText"] = ExpressionConverter.ConvertO(__workflow_requestBodyqueryText);
                requestBodypropCount++;
                requestBody["answerShortDescription"] = ExpressionConverter.ConvertO(__workflow_requestBodyanswerShortDescription);
                requestBodypropCount++;
                requestBody["feedbackText"] = ExpressionConverter.ConvertO(__workflow_requestBodyfeedbackText);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<OpenTicketFeedbackResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction CloseTicket(Expression<Func<string>> requestBodyticketId, Expression<Func<string>> requestBodyeditorEmail, Expression<Func<string>> requestBodyeditorComment)
        {
            var __workflow_requestBodyticketId = WorkflowExpression.Compile(requestBodyticketId, nameof(requestBodyticketId), required: true);
            var __workflow_requestBodyeditorEmail = WorkflowExpression.Compile(requestBodyeditorEmail, nameof(requestBodyeditorEmail), required: true);
            var __workflow_requestBodyeditorComment = WorkflowExpression.Compile(requestBodyeditorComment, nameof(requestBodyeditorComment), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/close-ticket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["ticketId"] = ExpressionConverter.ConvertO(__workflow_requestBodyticketId);
                requestBodypropCount++;
                requestBody["editorEmail"] = ExpressionConverter.ConvertO(__workflow_requestBodyeditorEmail);
                requestBodypropCount++;
                requestBody["editorComment"] = ExpressionConverter.ConvertO(__workflow_requestBodyeditorComment);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CosmobotTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger OnNewTicket(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger OnResolvedTicket(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger OnUpdatedTicketTopic(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger OnNewAnswer(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger OnUpdateAnswer(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger OnAskedQuestion(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
