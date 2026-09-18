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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/global-settings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<AskQuestionResponse> AskQuestion([WorkflowExpression] Func<string> requestBodyquestion, [WorkflowExpression] Func<int> requestBodyscoreThreshold = null, [WorkflowExpression] Func<string> requestBodyuserEmail = null)
        {
            SourceExpression.Validate(requestBodyquestion, nameof(requestBodyquestion), required: true);
            SourceExpression.Validate(requestBodyscoreThreshold, nameof(requestBodyscoreThreshold), required: false);
            SourceExpression.Validate(requestBodyuserEmail, nameof(requestBodyuserEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["question"] = SourceExpressionConverter.ConvertToken(requestBodyquestion);
                if (requestBodyscoreThreshold != null)
                {
                    requestBody["scoreThreshold"] = SourceExpressionConverter.ConvertToken(requestBodyscoreThreshold);
                    requestBodypropCount++;
                }

                if (requestBodyuserEmail != null)
                {
                    requestBody["userEmail"] = SourceExpressionConverter.ConvertToken(requestBodyuserEmail);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AskQuestionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<ParseTextResponse> ParseText([WorkflowExpression] Func<string> requestBodyinputText, [WorkflowExpression] Func<requestBodyoutputFormatInput> requestBodyoutputFormat)
        {
            SourceExpression.Validate(requestBodyinputText, nameof(requestBodyinputText), required: true);
            SourceExpression.Validate(requestBodyoutputFormat, nameof(requestBodyoutputFormat), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/parse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["inputText"] = SourceExpressionConverter.ConvertToken(requestBodyinputText);
                requestBodypropCount++;
                requestBody["outputFormat"] = SourceExpressionConverter.Convert(requestBodyoutputFormat);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ParseTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<TranslateResponse> Translate([WorkflowExpression] Func<string> requestBodytargetLanguageCode, [WorkflowExpression] Func<string> requestBodyinputText)
        {
            SourceExpression.Validate(requestBodytargetLanguageCode, nameof(requestBodytargetLanguageCode), required: true);
            SourceExpression.Validate(requestBodyinputText, nameof(requestBodyinputText), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["targetLanguageCode"] = SourceExpressionConverter.ConvertToken(requestBodytargetLanguageCode);
                requestBodypropCount++;
                requestBody["inputText"] = SourceExpressionConverter.ConvertToken(requestBodyinputText);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TranslateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetAllTopicsResponse> GetAllTopics([WorkflowExpression] Func<string> filterByExpert = null)
        {
            SourceExpression.Validate(filterByExpert, nameof(filterByExpert), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/get-all-topics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filterByExpert != null)
                    callPayload.Queries["filterByExpert"] = SourceExpressionConverter.ConvertO(filterByExpert);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllTopicsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetTopicResponse> GetTopic([WorkflowExpression] Func<string> topicName)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/get-topic";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["topicName"] = SourceExpressionConverter.ConvertO(topicName);
                return callPayload;
            }

            return new ApiConnectionAction<GetTopicResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetAllAnswersResponse> GetAllAnswers([WorkflowExpression] Func<string> filterByTopic = null, [WorkflowExpression] Func<string> filterByShortDescription = null, [WorkflowExpression] Func<string> filterByQuestionText = null, [WorkflowExpression] Func<string> filterByAnswerText = null)
        {
            SourceExpression.Validate(filterByTopic, nameof(filterByTopic), required: false);
            SourceExpression.Validate(filterByShortDescription, nameof(filterByShortDescription), required: false);
            SourceExpression.Validate(filterByQuestionText, nameof(filterByQuestionText), required: false);
            SourceExpression.Validate(filterByAnswerText, nameof(filterByAnswerText), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/get-all-answers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filterByTopic != null)
                    callPayload.Queries["filterByTopic"] = SourceExpressionConverter.ConvertO(filterByTopic);
                if (filterByShortDescription != null)
                    callPayload.Queries["filterByShortDescription"] = SourceExpressionConverter.ConvertO(filterByShortDescription);
                if (filterByQuestionText != null)
                    callPayload.Queries["filterByQuestionText"] = SourceExpressionConverter.ConvertO(filterByQuestionText);
                if (filterByAnswerText != null)
                    callPayload.Queries["filterByAnswerText"] = SourceExpressionConverter.ConvertO(filterByAnswerText);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllAnswersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetExpertsResponse> GetExperts([WorkflowExpression] Func<string> topic)
        {
            SourceExpression.Validate(topic, nameof(topic), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/get-experts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["topic"] = SourceExpressionConverter.ConvertO(topic);
                return callPayload;
            }

            return new ApiConnectionAction<GetExpertsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddExpert([WorkflowExpression] Func<string> requestBodytopic, [WorkflowExpression] Func<string> requestBodyexpertEmail)
        {
            SourceExpression.Validate(requestBodytopic, nameof(requestBodytopic), required: true);
            SourceExpression.Validate(requestBodyexpertEmail, nameof(requestBodyexpertEmail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/add-expert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["topic"] = SourceExpressionConverter.ConvertToken(requestBodytopic);
                requestBodypropCount++;
                requestBody["expertEmail"] = SourceExpressionConverter.ConvertToken(requestBodyexpertEmail);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction RemoveExpert([WorkflowExpression] Func<string> requestBodyexpertEmail, [WorkflowExpression] Func<string> requestBodytopic = null)
        {
            SourceExpression.Validate(requestBodyexpertEmail, nameof(requestBodyexpertEmail), required: true);
            SourceExpression.Validate(requestBodytopic, nameof(requestBodytopic), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/remove-expert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["expertEmail"] = SourceExpressionConverter.ConvertToken(requestBodyexpertEmail);
                if (requestBodytopic != null)
                {
                    requestBody["topic"] = SourceExpressionConverter.ConvertToken(requestBodytopic);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddTopic([WorkflowExpression] Func<string> requestBodyname, [WorkflowExpression] Func<string> requestBodydescription, [WorkflowExpression] Func<string[]> requestBodyexpertEmails)
        {
            SourceExpression.Validate(requestBodyname, nameof(requestBodyname), required: true);
            SourceExpression.Validate(requestBodydescription, nameof(requestBodydescription), required: true);
            SourceExpression.Validate(requestBodyexpertEmails, nameof(requestBodyexpertEmails), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/add-topic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["name"] = SourceExpressionConverter.ConvertToken(requestBodyname);
                requestBodypropCount++;
                requestBody["description"] = SourceExpressionConverter.ConvertToken(requestBodydescription);
                requestBodypropCount++;
                requestBody["expertEmails"] = SourceExpressionConverter.ConvertToken(requestBodyexpertEmails);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction RenameTopic([WorkflowExpression] Func<string> requestBodyname, [WorkflowExpression] Func<string> requestBodynewName)
        {
            SourceExpression.Validate(requestBodyname, nameof(requestBodyname), required: true);
            SourceExpression.Validate(requestBodynewName, nameof(requestBodynewName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rename-topic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["name"] = SourceExpressionConverter.ConvertToken(requestBodyname);
                requestBodypropCount++;
                requestBody["newName"] = SourceExpressionConverter.ConvertToken(requestBodynewName);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddAnswer([WorkflowExpression] Func<string> requestBodytopic, [WorkflowExpression] Func<string> requestBodyshortDescription, [WorkflowExpression] Func<string[]> requestBodyquestions, [WorkflowExpression] Func<string> requestBodyanswerText, [WorkflowExpression] Func<string> requestBodyuserEmail = null)
        {
            SourceExpression.Validate(requestBodytopic, nameof(requestBodytopic), required: true);
            SourceExpression.Validate(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            SourceExpression.Validate(requestBodyquestions, nameof(requestBodyquestions), required: true);
            SourceExpression.Validate(requestBodyanswerText, nameof(requestBodyanswerText), required: true);
            SourceExpression.Validate(requestBodyuserEmail, nameof(requestBodyuserEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/add-answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["topic"] = SourceExpressionConverter.ConvertToken(requestBodytopic);
                requestBodypropCount++;
                requestBody["shortDescription"] = SourceExpressionConverter.ConvertToken(requestBodyshortDescription);
                requestBodypropCount++;
                requestBody["questions"] = SourceExpressionConverter.ConvertToken(requestBodyquestions);
                requestBodypropCount++;
                requestBody["answerText"] = SourceExpressionConverter.ConvertToken(requestBodyanswerText);
                if (requestBodyuserEmail != null)
                {
                    requestBody["userEmail"] = SourceExpressionConverter.ConvertToken(requestBodyuserEmail);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction EditAnswer([WorkflowExpression] Func<string> requestBodyshortDescription, [WorkflowExpression] Func<string> requestBodynewTopic = null, [WorkflowExpression] Func<string> requestBodynewShortDescription = null, [WorkflowExpression] Func<string[]> requestBodynewQuestions = null, [WorkflowExpression] Func<string> requestBodynewAnswerText = null, [WorkflowExpression] Func<string> requestBodyuserEmail = null)
        {
            SourceExpression.Validate(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            SourceExpression.Validate(requestBodynewTopic, nameof(requestBodynewTopic), required: false);
            SourceExpression.Validate(requestBodynewShortDescription, nameof(requestBodynewShortDescription), required: false);
            SourceExpression.Validate(requestBodynewQuestions, nameof(requestBodynewQuestions), required: false);
            SourceExpression.Validate(requestBodynewAnswerText, nameof(requestBodynewAnswerText), required: false);
            SourceExpression.Validate(requestBodyuserEmail, nameof(requestBodyuserEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/edit-answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["shortDescription"] = SourceExpressionConverter.ConvertToken(requestBodyshortDescription);
                if (requestBodynewTopic != null)
                {
                    requestBody["newTopic"] = SourceExpressionConverter.ConvertToken(requestBodynewTopic);
                    requestBodypropCount++;
                }

                if (requestBodynewShortDescription != null)
                {
                    requestBody["newShortDescription"] = SourceExpressionConverter.ConvertToken(requestBodynewShortDescription);
                    requestBodypropCount++;
                }

                if (requestBodynewQuestions != null)
                {
                    requestBody["newQuestions"] = SourceExpressionConverter.ConvertToken(requestBodynewQuestions);
                    requestBodypropCount++;
                }

                if (requestBodynewAnswerText != null)
                {
                    requestBody["newAnswerText"] = SourceExpressionConverter.ConvertToken(requestBodynewAnswerText);
                    requestBodypropCount++;
                }

                if (requestBodyuserEmail != null)
                {
                    requestBody["userEmail"] = SourceExpressionConverter.ConvertToken(requestBodyuserEmail);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction DeleteAnswer([WorkflowExpression] Func<string> requestBodyshortDescription)
        {
            SourceExpression.Validate(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/delete-answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["shortDescription"] = SourceExpressionConverter.ConvertToken(requestBodyshortDescription);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction AddSubAnswer([WorkflowExpression] Func<string> requestBodyshortDescription, [WorkflowExpression] Func<string> requestBodysubShortDescription, [WorkflowExpression] Func<string[]> requestBodysubQuestions, [WorkflowExpression] Func<string> requestBodysubAnswerText)
        {
            SourceExpression.Validate(requestBodyshortDescription, nameof(requestBodyshortDescription), required: true);
            SourceExpression.Validate(requestBodysubShortDescription, nameof(requestBodysubShortDescription), required: true);
            SourceExpression.Validate(requestBodysubQuestions, nameof(requestBodysubQuestions), required: true);
            SourceExpression.Validate(requestBodysubAnswerText, nameof(requestBodysubAnswerText), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/add-subanswer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["shortDescription"] = SourceExpressionConverter.ConvertToken(requestBodyshortDescription);
                requestBodypropCount++;
                requestBody["subShortDescription"] = SourceExpressionConverter.ConvertToken(requestBodysubShortDescription);
                requestBodypropCount++;
                requestBody["subQuestions"] = SourceExpressionConverter.ConvertToken(requestBodysubQuestions);
                requestBodypropCount++;
                requestBody["subAnswerText"] = SourceExpressionConverter.ConvertToken(requestBodysubAnswerText);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<GetOpenTicketsResponse> GetOpenTickets([WorkflowExpression] Func<int> filterByHoursSinceOpened = null, [WorkflowExpression] Func<int> filterByHoursSinceOpenedMax = null, [WorkflowExpression] Func<string> filterByTopic = null, [WorkflowExpression] Func<string> filterByExpertEmail = null)
        {
            SourceExpression.Validate(filterByHoursSinceOpened, nameof(filterByHoursSinceOpened), required: false);
            SourceExpression.Validate(filterByHoursSinceOpenedMax, nameof(filterByHoursSinceOpenedMax), required: false);
            SourceExpression.Validate(filterByTopic, nameof(filterByTopic), required: false);
            SourceExpression.Validate(filterByExpertEmail, nameof(filterByExpertEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/get-tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filterByHoursSinceOpened != null)
                    callPayload.Queries["filterByHoursSinceOpened"] = SourceExpressionConverter.ConvertO(filterByHoursSinceOpened);
                if (filterByHoursSinceOpenedMax != null)
                    callPayload.Queries["filterByHoursSinceOpenedMax"] = SourceExpressionConverter.ConvertO(filterByHoursSinceOpenedMax);
                if (filterByTopic != null)
                    callPayload.Queries["filterByTopic"] = SourceExpressionConverter.ConvertO(filterByTopic);
                if (filterByExpertEmail != null)
                    callPayload.Queries["filterByExpertEmail"] = SourceExpressionConverter.ConvertO(filterByExpertEmail);
                return callPayload;
            }

            return new ApiConnectionAction<GetOpenTicketsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<OpenTicketQuestionResponse> OpenTicketQuestion([WorkflowExpression] Func<string> requestBodyuserEmail, [WorkflowExpression] Func<string> requestBodyqueryText, [WorkflowExpression] Func<string> requestBodytopic = null)
        {
            SourceExpression.Validate(requestBodyuserEmail, nameof(requestBodyuserEmail), required: true);
            SourceExpression.Validate(requestBodyqueryText, nameof(requestBodyqueryText), required: true);
            SourceExpression.Validate(requestBodytopic, nameof(requestBodytopic), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/open-ticket-question";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["userEmail"] = SourceExpressionConverter.ConvertToken(requestBodyuserEmail);
                requestBodypropCount++;
                requestBody["queryText"] = SourceExpressionConverter.ConvertToken(requestBodyqueryText);
                if (requestBodytopic != null)
                {
                    requestBody["topic"] = SourceExpressionConverter.ConvertToken(requestBodytopic);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpenTicketQuestionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IBodyWorkflowAction<OpenTicketFeedbackResponse> OpenTicketFeedback([WorkflowExpression] Func<string> requestBodyuserEmail, [WorkflowExpression] Func<string> requestBodyqueryText, [WorkflowExpression] Func<string> requestBodyanswerShortDescription, [WorkflowExpression] Func<string> requestBodyfeedbackText)
        {
            SourceExpression.Validate(requestBodyuserEmail, nameof(requestBodyuserEmail), required: true);
            SourceExpression.Validate(requestBodyqueryText, nameof(requestBodyqueryText), required: true);
            SourceExpression.Validate(requestBodyanswerShortDescription, nameof(requestBodyanswerShortDescription), required: true);
            SourceExpression.Validate(requestBodyfeedbackText, nameof(requestBodyfeedbackText), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/open-ticket-feedback";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["userEmail"] = SourceExpressionConverter.ConvertToken(requestBodyuserEmail);
                requestBodypropCount++;
                requestBody["queryText"] = SourceExpressionConverter.ConvertToken(requestBodyqueryText);
                requestBodypropCount++;
                requestBody["answerShortDescription"] = SourceExpressionConverter.ConvertToken(requestBodyanswerShortDescription);
                requestBodypropCount++;
                requestBody["feedbackText"] = SourceExpressionConverter.ConvertToken(requestBodyfeedbackText);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpenTicketFeedbackResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cosmobot")]
        public IWorkflowAction CloseTicket([WorkflowExpression] Func<string> requestBodyticketId, [WorkflowExpression] Func<string> requestBodyeditorEmail, [WorkflowExpression] Func<string> requestBodyeditorComment)
        {
            SourceExpression.Validate(requestBodyticketId, nameof(requestBodyticketId), required: true);
            SourceExpression.Validate(requestBodyeditorEmail, nameof(requestBodyeditorEmail), required: true);
            SourceExpression.Validate(requestBodyeditorComment, nameof(requestBodyeditorComment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/close-ticket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["ticketId"] = SourceExpressionConverter.ConvertToken(requestBodyticketId);
                requestBodypropCount++;
                requestBody["editorEmail"] = SourceExpressionConverter.ConvertToken(requestBodyeditorEmail);
                requestBodypropCount++;
                requestBody["editorComment"] = SourceExpressionConverter.ConvertToken(requestBodyeditorComment);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class CosmobotTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger OnNewTicket(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OnResolvedTicket(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OnUpdatedTicketTopic(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OnNewAnswer(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OnUpdateAnswer(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OnAskedQuestion(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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