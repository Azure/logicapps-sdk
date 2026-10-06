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
        [WorkflowExpressionFactory(nameof(__BuildAskQuestion))]
        public IBodyWorkflowAction<AskQuestionResponse> AskQuestion([WorkflowExpression] Func<string> requestBodyquestion, [WorkflowExpression] Func<int> requestBodyscoreThreshold = null, [WorkflowExpression] Func<string> requestBodyuserEmail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AskQuestionResponse> __BuildAskQuestion(WorkflowExpression<string> requestBodyquestion, WorkflowExpression<int> requestBodyscoreThreshold = null, WorkflowExpression<string> requestBodyuserEmail = null)
        {
            WorkflowExpression.Validate(requestBodyquestion, nameof(requestBodyquestion), required: true);
            WorkflowExpression.Validate(requestBodyscoreThreshold, nameof(requestBodyscoreThreshold), required: false);
            WorkflowExpression.Validate(requestBodyuserEmail, nameof(requestBodyuserEmail), required: false);
            return new DeferredBodyAction<AskQuestionResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildParseText))]
        public IBodyWorkflowAction<ParseTextResponse> ParseText([WorkflowExpression] Func<string> requestBodyinputText, [WorkflowExpression] Func<requestBodyoutputFormatInput> requestBodyoutputFormat)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ParseTextResponse> __BuildParseText(WorkflowExpression<string> requestBodyinputText, WorkflowExpression<requestBodyoutputFormatInput> requestBodyoutputFormat)
        {
            WorkflowExpression.Validate(requestBodyinputText, nameof(requestBodyinputText), required: true);
            WorkflowExpression.Validate(requestBodyoutputFormat, nameof(requestBodyoutputFormat), required: true);
            return new DeferredBodyAction<ParseTextResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildTranslate))]
        public IBodyWorkflowAction<TranslateResponse> Translate([WorkflowExpression] Func<string> requestBodytargetLanguageCode, [WorkflowExpression] Func<string> requestBodyinputText)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TranslateResponse> __BuildTranslate(WorkflowExpression<string> requestBodytargetLanguageCode, WorkflowExpression<string> requestBodyinputText)
        {
            WorkflowExpression.Validate(requestBodytargetLanguageCode, nameof(requestBodytargetLanguageCode), required: true);
            WorkflowExpression.Validate(requestBodyinputText, nameof(requestBodyinputText), required: true);
            return new DeferredBodyAction<TranslateResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllTopics))]
        public IBodyWorkflowAction<GetAllTopicsResponse> GetAllTopics([WorkflowExpression] Func<string> filterByExpert = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllTopicsResponse> __BuildGetAllTopics(WorkflowExpression<string> filterByExpert = null)
        {
            WorkflowExpression.Validate(filterByExpert, nameof(filterByExpert), required: false);
            return new DeferredBodyAction<GetAllTopicsResponse>(() =>
            {
                var apiCallPath = "/get-all-topics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filterByExpert != null)
                    callPayload.Queries["filterByExpert"] = ExpressionConverter.Convert(filterByExpert);
                return new ApiConnectionAction<GetAllTopicsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildGetTopic))]
        public IBodyWorkflowAction<GetTopicResponse> GetTopic([WorkflowExpression] Func<string> topicName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTopicResponse> __BuildGetTopic(WorkflowExpression<string> topicName)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            return new DeferredBodyAction<GetTopicResponse>(() =>
            {
                var apiCallPath = "/get-topic";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["topicName"] = ExpressionConverter.Convert(topicName);
                return new ApiConnectionAction<GetTopicResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllAnswers))]
        public IBodyWorkflowAction<GetAllAnswersResponse> GetAllAnswers([WorkflowExpression] Func<string> filterByTopic = null, [WorkflowExpression] Func<string> filterByShortDescription = null, [WorkflowExpression] Func<string> filterByQuestionText = null, [WorkflowExpression] Func<string> filterByAnswerText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllAnswersResponse> __BuildGetAllAnswers(WorkflowExpression<string> filterByTopic = null, WorkflowExpression<string> filterByShortDescription = null, WorkflowExpression<string> filterByQuestionText = null, WorkflowExpression<string> filterByAnswerText = null)
        {
            WorkflowExpression.Validate(filterByTopic, nameof(filterByTopic), required: false);
            WorkflowExpression.Validate(filterByShortDescription, nameof(filterByShortDescription), required: false);
            WorkflowExpression.Validate(filterByQuestionText, nameof(filterByQuestionText), required: false);
            WorkflowExpression.Validate(filterByAnswerText, nameof(filterByAnswerText), required: false);
            return new DeferredBodyAction<GetAllAnswersResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildGetExperts))]
        public IBodyWorkflowAction<GetExpertsResponse> GetExperts([WorkflowExpression] Func<string> topic)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetExpertsResponse> __BuildGetExperts(WorkflowExpression<string> topic)
        {
            WorkflowExpression.Validate(topic, nameof(topic), required: true);
            return new DeferredBodyAction<GetExpertsResponse>(() =>
            {
                var apiCallPath = "/get-experts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["topic"] = ExpressionConverter.Convert(topic);
                return new ApiConnectionAction<GetExpertsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildAddExpert))]
        public IWorkflowAction AddExpert([WorkflowExpression] Func<string> requestBodytopic, [WorkflowExpression] Func<string> requestBodyexpertEmail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddExpert(WorkflowExpression<string> requestBodytopic, WorkflowExpression<string> requestBodyexpertEmail)
        {
            WorkflowExpression.Validate(requestBodytopic, nameof(requestBodytopic), required: true);
            WorkflowExpression.Validate(requestBodyexpertEmail, nameof(requestBodyexpertEmail), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveExpert))]
        public IWorkflowAction RemoveExpert([WorkflowExpression] Func<string> requestBodyexpertEmail, [WorkflowExpression] Func<string> requestBodytopic = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveExpert(WorkflowExpression<string> requestBodyexpertEmail, WorkflowExpression<string> requestBodytopic = null)
        {
            WorkflowExpression.Validate(requestBodyexpertEmail, nameof(requestBodyexpertEmail), required: true);
            WorkflowExpression.Validate(requestBodytopic, nameof(requestBodytopic), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildAddTopic))]
        public IWorkflowAction AddTopic([WorkflowExpression] Func<string> requestBodyname, [WorkflowExpression] Func<string> requestBodydescription, [WorkflowExpression] Func<string[]> requestBodyexpertEmails)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddTopic(WorkflowExpression<string> requestBodyname, WorkflowExpression<string> requestBodydescription, WorkflowExpression<string[]> requestBodyexpertEmails)
        {
            WorkflowExpression.Validate(requestBodyname, nameof(requestBodyname), required: true);
            WorkflowExpression.Validate(requestBodydescription, nameof(requestBodydescription), required: true);
            WorkflowExpression.Validate(requestBodyexpertEmails, nameof(requestBodyexpertEmails), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildRenameTopic))]
        public IWorkflowAction RenameTopic([WorkflowExpression] Func<string> requestBodyname, [WorkflowExpression] Func<string> requestBodynewName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenameTopic(WorkflowExpression<string> requestBodyname, WorkflowExpression<string> requestBodynewName)
        {
            WorkflowExpression.Validate(requestBodyname, nameof(requestBodyname), required: true);
            WorkflowExpression.Validate(requestBodynewName, nameof(requestBodynewName), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildAddAnswer))]
        public IWorkflowAction AddAnswer([WorkflowExpression] Func<string> requestBodytopic, [WorkflowExpression] Func<string> requestBodyshortDescription, [WorkflowExpression] Func<string[]> requestBodyquestions, [WorkflowExpression] Func<string> requestBodyanswerText, [WorkflowExpression] Func<string> requestBodyuserEmail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddAnswer(WorkflowExpression<string> requestBodytopic, WorkflowExpression<string> requestBodyshortDescription, WorkflowExpression<string[]> requestBodyquestions, WorkflowExpression<string> requestBodyanswerText, WorkflowExpression<string> requestBodyuserEmail = null)
        {
            WorkflowExpression.Validate(requestBodytopic, nameof(requestBodytopic), required: true);
            WorkflowExpression.Validate(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            WorkflowExpression.Validate(requestBodyquestions, nameof(requestBodyquestions), required: true);
            WorkflowExpression.Validate(requestBodyanswerText, nameof(requestBodyanswerText), required: true);
            WorkflowExpression.Validate(requestBodyuserEmail, nameof(requestBodyuserEmail), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildEditAnswer))]
        public IWorkflowAction EditAnswer([WorkflowExpression] Func<string> requestBodyshortDescription, [WorkflowExpression] Func<string> requestBodynewTopic = null, [WorkflowExpression] Func<string> requestBodynewShortDescription = null, [WorkflowExpression] Func<string[]> requestBodynewQuestions = null, [WorkflowExpression] Func<string> requestBodynewAnswerText = null, [WorkflowExpression] Func<string> requestBodyuserEmail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditAnswer(WorkflowExpression<string> requestBodyshortDescription, WorkflowExpression<string> requestBodynewTopic = null, WorkflowExpression<string> requestBodynewShortDescription = null, WorkflowExpression<string[]> requestBodynewQuestions = null, WorkflowExpression<string> requestBodynewAnswerText = null, WorkflowExpression<string> requestBodyuserEmail = null)
        {
            WorkflowExpression.Validate(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            WorkflowExpression.Validate(requestBodynewTopic, nameof(requestBodynewTopic), required: false);
            WorkflowExpression.Validate(requestBodynewShortDescription, nameof(requestBodynewShortDescription), required: false);
            WorkflowExpression.Validate(requestBodynewQuestions, nameof(requestBodynewQuestions), required: false);
            WorkflowExpression.Validate(requestBodynewAnswerText, nameof(requestBodynewAnswerText), required: false);
            WorkflowExpression.Validate(requestBodyuserEmail, nameof(requestBodyuserEmail), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAnswer))]
        public IWorkflowAction DeleteAnswer([WorkflowExpression] Func<string> requestBodyshortDescription)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteAnswer(WorkflowExpression<string> requestBodyshortDescription)
        {
            WorkflowExpression.Validate(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildAddSubAnswer))]
        public IWorkflowAction AddSubAnswer([WorkflowExpression] Func<string> requestBodyshortDescription, [WorkflowExpression] Func<string> requestBodysubShortDescription, [WorkflowExpression] Func<string[]> requestBodysubQuestions, [WorkflowExpression] Func<string> requestBodysubAnswerText)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddSubAnswer(WorkflowExpression<string> requestBodyshortDescription, WorkflowExpression<string> requestBodysubShortDescription, WorkflowExpression<string[]> requestBodysubQuestions, WorkflowExpression<string> requestBodysubAnswerText)
        {
            WorkflowExpression.Validate(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            WorkflowExpression.Validate(requestBodysubShortDescription, nameof(requestBodysubShortDescription), required: true);
            WorkflowExpression.Validate(requestBodysubQuestions, nameof(requestBodysubQuestions), required: true);
            WorkflowExpression.Validate(requestBodysubAnswerText, nameof(requestBodysubAnswerText), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildGetOpenTickets))]
        public IBodyWorkflowAction<GetOpenTicketsResponse> GetOpenTickets([WorkflowExpression] Func<int> filterByHoursSinceOpened = null, [WorkflowExpression] Func<int> filterByHoursSinceOpenedMax = null, [WorkflowExpression] Func<string> filterByTopic = null, [WorkflowExpression] Func<string> filterByExpertEmail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOpenTicketsResponse> __BuildGetOpenTickets(WorkflowExpression<int> filterByHoursSinceOpened = null, WorkflowExpression<int> filterByHoursSinceOpenedMax = null, WorkflowExpression<string> filterByTopic = null, WorkflowExpression<string> filterByExpertEmail = null)
        {
            WorkflowExpression.Validate(filterByHoursSinceOpened, nameof(filterByHoursSinceOpened), required: false);
            WorkflowExpression.Validate(filterByHoursSinceOpenedMax, nameof(filterByHoursSinceOpenedMax), required: false);
            WorkflowExpression.Validate(filterByTopic, nameof(filterByTopic), required: false);
            WorkflowExpression.Validate(filterByExpertEmail, nameof(filterByExpertEmail), required: false);
            return new DeferredBodyAction<GetOpenTicketsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildOpenTicketQuestion))]
        public IBodyWorkflowAction<OpenTicketQuestionResponse> OpenTicketQuestion([WorkflowExpression] Func<string> requestBodyuserEmail, [WorkflowExpression] Func<string> requestBodyqueryText, [WorkflowExpression] Func<string> requestBodytopic = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenTicketQuestionResponse> __BuildOpenTicketQuestion(WorkflowExpression<string> requestBodyuserEmail, WorkflowExpression<string> requestBodyqueryText, WorkflowExpression<string> requestBodytopic = null)
        {
            WorkflowExpression.Validate(requestBodyuserEmail, nameof(requestBodyuserEmail), required: true);
            WorkflowExpression.Validate(requestBodyqueryText, nameof(requestBodyqueryText), required: true);
            WorkflowExpression.Validate(requestBodytopic, nameof(requestBodytopic), required: false);
            return new DeferredBodyAction<OpenTicketQuestionResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildOpenTicketFeedback))]
        public IBodyWorkflowAction<OpenTicketFeedbackResponse> OpenTicketFeedback([WorkflowExpression] Func<string> requestBodyuserEmail, [WorkflowExpression] Func<string> requestBodyqueryText, [WorkflowExpression] Func<string> requestBodyanswerShortDescription, [WorkflowExpression] Func<string> requestBodyfeedbackText)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenTicketFeedbackResponse> __BuildOpenTicketFeedback(WorkflowExpression<string> requestBodyuserEmail, WorkflowExpression<string> requestBodyqueryText, WorkflowExpression<string> requestBodyanswerShortDescription, WorkflowExpression<string> requestBodyfeedbackText)
        {
            WorkflowExpression.Validate(requestBodyuserEmail, nameof(requestBodyuserEmail), required: true);
            WorkflowExpression.Validate(requestBodyqueryText, nameof(requestBodyqueryText), required: true);
            WorkflowExpression.Validate(requestBodyanswerShortDescription, nameof(requestBodyanswerShortDescription), required: true);
            WorkflowExpression.Validate(requestBodyfeedbackText, nameof(requestBodyfeedbackText), required: true);
            return new DeferredBodyAction<OpenTicketFeedbackResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [WorkflowExpressionFactory(nameof(__BuildCloseTicket))]
        public IWorkflowAction CloseTicket([WorkflowExpression] Func<string> requestBodyticketId, [WorkflowExpression] Func<string> requestBodyeditorEmail, [WorkflowExpression] Func<string> requestBodyeditorComment)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCloseTicket(WorkflowExpression<string> requestBodyticketId, WorkflowExpression<string> requestBodyeditorEmail, WorkflowExpression<string> requestBodyeditorComment)
        {
            WorkflowExpression.Validate(requestBodyticketId, nameof(requestBodyticketId), required: true);
            WorkflowExpression.Validate(requestBodyeditorEmail, nameof(requestBodyeditorEmail), required: true);
            WorkflowExpression.Validate(requestBodyeditorComment, nameof(requestBodyeditorComment), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
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