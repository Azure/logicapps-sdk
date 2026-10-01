//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Edenai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EdenaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<TextToSpeechResponse> TextToSpeech([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyoption = null, [WorkflowExpression] Func<double> bodyrate = null, [WorkflowExpression] Func<double> bodypitch = null, [WorkflowExpression] Func<double> bodyvolume = null, [WorkflowExpression] Func<string> bodyaudioFormat = null, [WorkflowExpression] Func<double> bodysamplingRate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/audio/text_to_speech";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "google, microsoft, lovoai, ibm, amazon";
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    if (bodylanguage != null)
                    {
                        body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    if (bodytext != null)
                    {
                        body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["text"] = "Hello, my name is Jane.";
                    bodypropCount++;
                }

                if (bodyoption != null)
                {
                    if (bodyoption != null)
                    {
                        body["option"] = SourceExpressionConverter.ConvertToken(bodyoption);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["option"] = "FEMALE";
                    bodypropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (bodyrate != null)
                {
                    if (bodyrate != null)
                    {
                        body["rate"] = SourceExpressionConverter.ConvertToken(bodyrate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["rate"] = 0;
                    bodypropCount++;
                }

                if (bodypitch != null)
                {
                    if (bodypitch != null)
                    {
                        body["pitch"] = SourceExpressionConverter.ConvertToken(bodypitch);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["pitch"] = 0;
                    bodypropCount++;
                }

                if (bodyvolume != null)
                {
                    if (bodyvolume != null)
                    {
                        body["volume"] = SourceExpressionConverter.ConvertToken(bodyvolume);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["volume"] = 0;
                    bodypropCount++;
                }

                if (bodyaudioFormat != null)
                {
                    if (bodyaudioFormat != null)
                    {
                        body["audio_format"] = SourceExpressionConverter.ConvertToken(bodyaudioFormat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["audio_format"] = "mp3";
                    bodypropCount++;
                }

                if (bodysamplingRate != null)
                {
                    if (bodysamplingRate != null)
                    {
                        body["sampling_rate"] = SourceExpressionConverter.ConvertToken(bodysamplingRate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["sampling_rate"] = 0;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TextToSpeechResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<TextGenerationResponse> TextGeneration([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<double> bodymaxTokens = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/text/generation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "openai, cohere";
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodytemperature != null)
                {
                    if (bodytemperature != null)
                    {
                        body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["temperature"] = 0.3;
                    bodypropCount++;
                }

                if (bodymaxTokens != null)
                {
                    if (bodymaxTokens != null)
                    {
                        body["max_tokens"] = SourceExpressionConverter.ConvertToken(bodymaxTokens);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_tokens"] = 250;
                    bodypropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TextGenerationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<ChatResponse> Chat([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodychatGlobalAction = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<double> bodymaxTokens = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/text/chat";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "openai";
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodychatGlobalAction != null)
                {
                    body["chat_global_action"] = SourceExpressionConverter.ConvertToken(bodychatGlobalAction);
                    bodypropCount++;
                }

                if (bodytemperature != null)
                {
                    if (bodytemperature != null)
                    {
                        body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["temperature"] = 0.3;
                    bodypropCount++;
                }

                if (bodymaxTokens != null)
                {
                    if (bodymaxTokens != null)
                    {
                        body["max_tokens"] = SourceExpressionConverter.ConvertToken(bodymaxTokens);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_tokens"] = 250;
                    bodypropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ChatResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<TopicExtractionResponse> TopicExtraction([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodytext = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/text/topic_extraction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "google, openai, ibm";
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    if (bodylanguage != null)
                    {
                        body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TopicExtractionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<KeywordExtractionResponse> KeywordExtraction([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodytext = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/text/keyword_extraction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "amazon, openai, microsoft, ibm, oneai, emvista";
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    if (bodylanguage != null)
                    {
                        body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<KeywordExtractionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<NamedEntityRecognitionResponse> NamedEntityRecognition([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodytext = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/text/named_entity_recognition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "amazon, google, openai, lettria, neuralspace, microsoft, ibm, oneai";
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    if (bodylanguage != null)
                    {
                        body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NamedEntityRecognitionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<ImageGenerationResponse> ImageGeneration([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyresolution = null, [WorkflowExpression] Func<double> bodynumImages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/image/generation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "stabilityai, openai, deepai";
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyresolution != null)
                {
                    if (bodyresolution != null)
                    {
                        body["resolution"] = SourceExpressionConverter.ConvertToken(bodyresolution);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["resolution"] = "512x512";
                    bodypropCount++;
                }

                if (bodynumImages != null)
                {
                    if (bodynumImages != null)
                    {
                        body["num_images"] = SourceExpressionConverter.ConvertToken(bodynumImages);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["num_images"] = 1;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImageGenerationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<TranslationResponse> Translation([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodysourceLanguage = null, [WorkflowExpression] Func<string> bodytargetLanguage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/translation/automatic_translation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "google, amazon, neuralspace, modernmt, phedone, deepl, openai, microsoft, ibm";
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodysourceLanguage != null)
                {
                    if (bodysourceLanguage != null)
                    {
                        body["source_language"] = SourceExpressionConverter.ConvertToken(bodysourceLanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["source_language"] = "en";
                    bodypropCount++;
                }

                if (bodytargetLanguage != null)
                {
                    if (bodytargetLanguage != null)
                    {
                        body["target_language"] = SourceExpressionConverter.ConvertToken(bodytargetLanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["target_language"] = "fr";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TranslationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<TextModerationResponse> TextModeration([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodytext = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/text/moderation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "microsoft, openai";
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    if (bodylanguage != null)
                    {
                        body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TextModerationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<SummarizationResponse> Summarization([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<double> bodyoutputSentences = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodylanguage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/text/summarize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "cohere, openai, microsoft, emvista, oneai, connexun";
                    bodypropCount++;
                }

                if (bodyoutputSentences != null)
                {
                    if (bodyoutputSentences != null)
                    {
                        body["output_sentences"] = SourceExpressionConverter.ConvertToken(bodyoutputSentences);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["output_sentences"] = 3;
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    if (bodylanguage != null)
                    {
                        body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SummarizationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<LanguageDetectionResponse> LanguageDetection([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<string> bodytext = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/translation/language_detection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "google, oneai, neuralspace, modernmt, amazon, ibm, openai, microsoft";
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LanguageDetectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<SentimentAnalysisResponse> SentimentAnalysis([WorkflowExpression] Func<string> bodyproviders = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodytext = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/text/sentiment_analysis";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproviders != null)
                {
                    if (bodyproviders != null)
                    {
                        body["providers"] = SourceExpressionConverter.ConvertToken(bodyproviders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["providers"] = "connexun, amazon, google, microsoft, oneai, emvista, openai, ibm, lettria";
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    if (bodylanguage != null)
                    {
                        body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SentimentAnalysisResponse>(BuildSourceInput);
        }
    }

    public class EdenaiTriggers([ConnectionName] string connectionId)
    {
    }

    public class TextToSpeechResponse
    {
        [JsonProperty("google")]
        public TextToSpeechResponseGoogleType Google { get; set; }

        [JsonProperty("microsoft")]
        public TextToSpeechResponseMicrosoftType Microsoft { get; set; }

        [JsonProperty("lovoai")]
        public TextToSpeechResponseLovoaiType Lovoai { get; set; }

        [JsonProperty("ibm")]
        public TextToSpeechResponseIbmType Ibm { get; set; }

        [JsonProperty("amazon")]
        public TextToSpeechResponseAmazonType Amazon { get; set; }
    }

    public class TextToSpeechResponseGoogleType
    {
        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("voice_type")]
        public double VoiceType { get; set; }

        [JsonProperty("audio_resource_url")]
        public string AudioResourceUrl { get; set; }
    }

    public class TextToSpeechResponseMicrosoftType
    {
        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("voice_type")]
        public double VoiceType { get; set; }

        [JsonProperty("audio_resource_url")]
        public string AudioResourceUrl { get; set; }
    }

    public class TextToSpeechResponseLovoaiType
    {
        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("voice_type")]
        public double VoiceType { get; set; }

        [JsonProperty("audio_resource_url")]
        public string AudioResourceUrl { get; set; }
    }

    public class TextToSpeechResponseIbmType
    {
        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("voice_type")]
        public double VoiceType { get; set; }

        [JsonProperty("audio_resource_url")]
        public string AudioResourceUrl { get; set; }
    }

    public class TextToSpeechResponseAmazonType
    {
        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("voice_type")]
        public double VoiceType { get; set; }

        [JsonProperty("audio_resource_url")]
        public string AudioResourceUrl { get; set; }
    }

    public class TextGenerationResponse
    {
        [JsonProperty("openai")]
        public TextGenerationResponseOpenaiType Openai { get; set; }

        [JsonProperty("cohere")]
        public TextGenerationResponseCohereType Cohere { get; set; }
    }

    public class TextGenerationResponseOpenaiType
    {
        [JsonProperty("generated_text")]
        public string GeneratedText { get; set; }
    }

    public class TextGenerationResponseCohereType
    {
        [JsonProperty("generated_text")]
        public string GeneratedText { get; set; }
    }

    public class ChatResponse
    {
        [JsonProperty("openai")]
        public ChatResponseOpenaiType Openai { get; set; }
    }

    public class ChatResponseOpenaiType
    {
        [JsonProperty("generated_text")]
        public string GeneratedText { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class TopicExtractionResponse
    {
        [JsonProperty("google")]
        public TopicExtractionResponseGoogleType Google { get; set; }

        [JsonProperty("openai")]
        public TopicExtractionResponseOpenaiType Openai { get; set; }

        [JsonProperty("ibm")]
        public TopicExtractionResponseIbmType Ibm { get; set; }
    }

    public class TopicExtractionResponseGoogleType
    {
        [JsonProperty("items")]
        public TopicExtractionResponseGoogleTypeItemsTypeItem[] Items { get; set; }
    }

    public class TopicExtractionResponseGoogleTypeItemsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class TopicExtractionResponseOpenaiType
    {
        [JsonProperty("items")]
        public TopicExtractionResponseOpenaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class TopicExtractionResponseOpenaiTypeItemsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class TopicExtractionResponseIbmType
    {
        [JsonProperty("items")]
        public TopicExtractionResponseIbmTypeItemsTypeItem[] Items { get; set; }
    }

    public class TopicExtractionResponseIbmTypeItemsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class KeywordExtractionResponse
    {
        [JsonProperty("amazon")]
        public KeywordExtractionResponseAmazonType Amazon { get; set; }

        [JsonProperty("openai")]
        public KeywordExtractionResponseOpenaiType Openai { get; set; }

        [JsonProperty("microsoft")]
        public KeywordExtractionResponseMicrosoftType Microsoft { get; set; }

        [JsonProperty("ibm")]
        public KeywordExtractionResponseIbmType Ibm { get; set; }

        [JsonProperty("oneai")]
        public KeywordExtractionResponseOneaiType Oneai { get; set; }

        [JsonProperty("emvista")]
        public KeywordExtractionResponseEmvistaType Emvista { get; set; }
    }

    public class KeywordExtractionResponseAmazonType
    {
        [JsonProperty("items")]
        public KeywordExtractionResponseAmazonTypeItemsTypeItem[] Items { get; set; }
    }

    public class KeywordExtractionResponseAmazonTypeItemsTypeItem
    {
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class KeywordExtractionResponseOpenaiType
    {
        [JsonProperty("items")]
        public KeywordExtractionResponseOpenaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class KeywordExtractionResponseOpenaiTypeItemsTypeItem
    {
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class KeywordExtractionResponseMicrosoftType
    {
        [JsonProperty("items")]
        public KeywordExtractionResponseMicrosoftTypeItemsTypeItem[] Items { get; set; }
    }

    public class KeywordExtractionResponseMicrosoftTypeItemsTypeItem
    {
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class KeywordExtractionResponseIbmType
    {
        [JsonProperty("items")]
        public KeywordExtractionResponseIbmTypeItemsTypeItem[] Items { get; set; }
    }

    public class KeywordExtractionResponseIbmTypeItemsTypeItem
    {
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class KeywordExtractionResponseOneaiType
    {
        [JsonProperty("items")]
        public KeywordExtractionResponseOneaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class KeywordExtractionResponseOneaiTypeItemsTypeItem
    {
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class KeywordExtractionResponseEmvistaType
    {
        [JsonProperty("items")]
        public KeywordExtractionResponseEmvistaTypeItemsTypeItem[] Items { get; set; }
    }

    public class KeywordExtractionResponseEmvistaTypeItemsTypeItem
    {
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class NamedEntityRecognitionResponse
    {
        [JsonProperty("amazon")]
        public NamedEntityRecognitionResponseAmazonType Amazon { get; set; }

        [JsonProperty("google")]
        public NamedEntityRecognitionResponseGoogleType Google { get; set; }

        [JsonProperty("openai")]
        public NamedEntityRecognitionResponseOpenaiType Openai { get; set; }

        [JsonProperty("lettria")]
        public NamedEntityRecognitionResponseLettriaType Lettria { get; set; }

        [JsonProperty("neuralspace")]
        public NamedEntityRecognitionResponseNeuralspaceType Neuralspace { get; set; }

        [JsonProperty("microsoft")]
        public NamedEntityRecognitionResponseMicrosoftType Microsoft { get; set; }

        [JsonProperty("ibm")]
        public NamedEntityRecognitionResponseIbmType Ibm { get; set; }

        [JsonProperty("oneai")]
        public NamedEntityRecognitionResponseOneaiType Oneai { get; set; }
    }

    public class NamedEntityRecognitionResponseAmazonType
    {
        [JsonProperty("items")]
        public NamedEntityRecognitionResponseAmazonTypeItemsTypeItem[] Items { get; set; }
    }

    public class NamedEntityRecognitionResponseAmazonTypeItemsTypeItem
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class NamedEntityRecognitionResponseGoogleType
    {
        [JsonProperty("items")]
        public NamedEntityRecognitionResponseGoogleTypeItemsTypeItem[] Items { get; set; }
    }

    public class NamedEntityRecognitionResponseGoogleTypeItemsTypeItem
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class NamedEntityRecognitionResponseOpenaiType
    {
        [JsonProperty("items")]
        public NamedEntityRecognitionResponseOpenaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class NamedEntityRecognitionResponseOpenaiTypeItemsTypeItem
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class NamedEntityRecognitionResponseLettriaType
    {
        [JsonProperty("items")]
        public NamedEntityRecognitionResponseLettriaTypeItemsTypeItem[] Items { get; set; }
    }

    public class NamedEntityRecognitionResponseLettriaTypeItemsTypeItem
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class NamedEntityRecognitionResponseNeuralspaceType
    {
        [JsonProperty("items")]
        public NamedEntityRecognitionResponseNeuralspaceTypeItemsTypeItem[] Items { get; set; }
    }

    public class NamedEntityRecognitionResponseNeuralspaceTypeItemsTypeItem
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class NamedEntityRecognitionResponseMicrosoftType
    {
        [JsonProperty("items")]
        public NamedEntityRecognitionResponseMicrosoftTypeItemsTypeItem[] Items { get; set; }
    }

    public class NamedEntityRecognitionResponseMicrosoftTypeItemsTypeItem
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class NamedEntityRecognitionResponseIbmType
    {
        [JsonProperty("items")]
        public NamedEntityRecognitionResponseIbmTypeItemsTypeItem[] Items { get; set; }
    }

    public class NamedEntityRecognitionResponseIbmTypeItemsTypeItem
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class NamedEntityRecognitionResponseOneaiType
    {
        [JsonProperty("items")]
        public NamedEntityRecognitionResponseOneaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class NamedEntityRecognitionResponseOneaiTypeItemsTypeItem
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importance")]
        public double Importance { get; set; }
    }

    public class ImageGenerationResponse
    {
        [JsonProperty("stabilityai")]
        public ImageGenerationResponseStabilityaiType Stabilityai { get; set; }

        [JsonProperty("openai")]
        public ImageGenerationResponseOpenaiType Openai { get; set; }

        [JsonProperty("deepai")]
        public ImageGenerationResponseDeepaiType Deepai { get; set; }
    }

    public class ImageGenerationResponseStabilityaiType
    {
        [JsonProperty("items")]
        public ImageGenerationResponseStabilityaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class ImageGenerationResponseStabilityaiTypeItemsTypeItem
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("image_resource_url")]
        public string ImageResourceUrl { get; set; }
    }

    public class ImageGenerationResponseOpenaiType
    {
        [JsonProperty("items")]
        public ImageGenerationResponseOpenaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class ImageGenerationResponseOpenaiTypeItemsTypeItem
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("image_resource_url")]
        public string ImageResourceUrl { get; set; }
    }

    public class ImageGenerationResponseDeepaiType
    {
        [JsonProperty("items")]
        public ImageGenerationResponseDeepaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class ImageGenerationResponseDeepaiTypeItemsTypeItem
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("image_resource_url")]
        public string ImageResourceUrl { get; set; }
    }

    public class TranslationResponse
    {
        [JsonProperty("google")]
        public TranslationResponseGoogleType Google { get; set; }

        [JsonProperty("amazon")]
        public TranslationResponseAmazonType Amazon { get; set; }

        [JsonProperty("neuralspace")]
        public TranslationResponseNeuralspaceType Neuralspace { get; set; }

        [JsonProperty("modernmt")]
        public TranslationResponseModernmtType Modernmt { get; set; }

        [JsonProperty("phedone")]
        public TranslationResponsePhedoneType Phedone { get; set; }

        [JsonProperty("deepl")]
        public TranslationResponseDeeplType Deepl { get; set; }

        [JsonProperty("openai")]
        public TranslationResponseOpenaiType Openai { get; set; }

        [JsonProperty("microsoft")]
        public TranslationResponseMicrosoftType Microsoft { get; set; }

        [JsonProperty("ibm")]
        public TranslationResponseIbmType Ibm { get; set; }
    }

    public class TranslationResponseGoogleType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class TranslationResponseAmazonType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class TranslationResponseNeuralspaceType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class TranslationResponseModernmtType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class TranslationResponsePhedoneType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class TranslationResponseDeeplType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class TranslationResponseOpenaiType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class TranslationResponseMicrosoftType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class TranslationResponseIbmType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class TextModerationResponse
    {
        [JsonProperty("microsoft")]
        public TextModerationResponseMicrosoftType Microsoft { get; set; }

        [JsonProperty("openai")]
        public TextModerationResponseOpenaiType Openai { get; set; }
    }

    public class TextModerationResponseMicrosoftType
    {
        [JsonProperty("nsfw_likelihood")]
        public double NsfwLikelihood { get; set; }

        [JsonProperty("items")]
        public TextModerationResponseMicrosoftTypeItemsTypeItem[] Items { get; set; }
    }

    public class TextModerationResponseMicrosoftTypeItemsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("likelihood")]
        public double Likelihood { get; set; }
    }

    public class TextModerationResponseOpenaiType
    {
        [JsonProperty("nsfw_likelihood")]
        public double NsfwLikelihood { get; set; }

        [JsonProperty("items")]
        public TextModerationResponseOpenaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class TextModerationResponseOpenaiTypeItemsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("likelihood")]
        public double Likelihood { get; set; }
    }

    public class SummarizationResponse
    {
        [JsonProperty("cohere")]
        public SummarizationResponseCohereType Cohere { get; set; }

        [JsonProperty("openai")]
        public SummarizationResponseOpenaiType Openai { get; set; }

        [JsonProperty("microsoft")]
        public SummarizationResponseMicrosoftType Microsoft { get; set; }

        [JsonProperty("emvista")]
        public SummarizationResponseEmvistaType Emvista { get; set; }

        [JsonProperty("oneai")]
        public SummarizationResponseOneaiType Oneai { get; set; }

        [JsonProperty("connexun")]
        public SummarizationResponseConnexunType Connexun { get; set; }
    }

    public class SummarizationResponseCohereType
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class SummarizationResponseOpenaiType
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class SummarizationResponseMicrosoftType
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class SummarizationResponseEmvistaType
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class SummarizationResponseOneaiType
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class SummarizationResponseConnexunType
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class LanguageDetectionResponse
    {
        [JsonProperty("google")]
        public LanguageDetectionResponseGoogleType Google { get; set; }

        [JsonProperty("oneai")]
        public LanguageDetectionResponseOneaiType Oneai { get; set; }

        [JsonProperty("neuralspace")]
        public LanguageDetectionResponseNeuralspaceType Neuralspace { get; set; }

        [JsonProperty("modernmt")]
        public LanguageDetectionResponseModernmtType Modernmt { get; set; }

        [JsonProperty("amazon")]
        public LanguageDetectionResponseAmazonType Amazon { get; set; }

        [JsonProperty("ibm")]
        public LanguageDetectionResponseIbmType Ibm { get; set; }

        [JsonProperty("openai")]
        public LanguageDetectionResponseOpenaiType Openai { get; set; }

        [JsonProperty("microsoft")]
        public LanguageDetectionResponseMicrosoftType Microsoft { get; set; }
    }

    public class LanguageDetectionResponseGoogleType
    {
        [JsonProperty("items")]
        public LanguageDetectionResponseGoogleTypeItemsTypeItem[] Items { get; set; }
    }

    public class LanguageDetectionResponseGoogleTypeItemsTypeItem
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class LanguageDetectionResponseOneaiType
    {
        [JsonProperty("items")]
        public LanguageDetectionResponseOneaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class LanguageDetectionResponseOneaiTypeItemsTypeItem
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class LanguageDetectionResponseNeuralspaceType
    {
        [JsonProperty("items")]
        public LanguageDetectionResponseNeuralspaceTypeItemsTypeItem[] Items { get; set; }
    }

    public class LanguageDetectionResponseNeuralspaceTypeItemsTypeItem
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class LanguageDetectionResponseModernmtType
    {
        [JsonProperty("items")]
        public LanguageDetectionResponseModernmtTypeItemsTypeItem[] Items { get; set; }
    }

    public class LanguageDetectionResponseModernmtTypeItemsTypeItem
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }
    }

    public class LanguageDetectionResponseAmazonType
    {
        [JsonProperty("items")]
        public LanguageDetectionResponseAmazonTypeItemsTypeItem[] Items { get; set; }
    }

    public class LanguageDetectionResponseAmazonTypeItemsTypeItem
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class LanguageDetectionResponseIbmType
    {
        [JsonProperty("items")]
        public LanguageDetectionResponseIbmTypeItemsTypeItem[] Items { get; set; }
    }

    public class LanguageDetectionResponseIbmTypeItemsTypeItem
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class LanguageDetectionResponseOpenaiType
    {
        [JsonProperty("items")]
        public LanguageDetectionResponseOpenaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class LanguageDetectionResponseOpenaiTypeItemsTypeItem
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class LanguageDetectionResponseMicrosoftType
    {
        [JsonProperty("items")]
        public LanguageDetectionResponseMicrosoftTypeItemsTypeItem[] Items { get; set; }
    }

    public class LanguageDetectionResponseMicrosoftTypeItemsTypeItem
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class SentimentAnalysisResponse
    {
        [JsonProperty("connexun")]
        public SentimentAnalysisResponseConnexunType Connexun { get; set; }

        [JsonProperty("amazon")]
        public SentimentAnalysisResponseAmazonType Amazon { get; set; }

        [JsonProperty("google")]
        public SentimentAnalysisResponseGoogleType Google { get; set; }

        [JsonProperty("microsoft")]
        public SentimentAnalysisResponseMicrosoftType Microsoft { get; set; }

        [JsonProperty("oneai")]
        public SentimentAnalysisResponseOneaiType Oneai { get; set; }

        [JsonProperty("emvista")]
        public SentimentAnalysisResponseEmvistaType Emvista { get; set; }

        [JsonProperty("openai")]
        public SentimentAnalysisResponseOpenaiType Openai { get; set; }

        [JsonProperty("ibm")]
        public SentimentAnalysisResponseIbmType Ibm { get; set; }

        [JsonProperty("lettria")]
        public SentimentAnalysisResponseLettriaType Lettria { get; set; }
    }

    public class SentimentAnalysisResponseConnexunType
    {
        [JsonProperty("general_sentiment")]
        public string GeneralSentiment { get; set; }

        [JsonProperty("general_sentiment_rate")]
        public double GeneralSentimentRate { get; set; }

        [JsonProperty("items")]
        public SentimentAnalysisResponseConnexunTypeItemsTypeItem[] Items { get; set; }
    }

    public class SentimentAnalysisResponseConnexunTypeItemsTypeItem
    {
        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("sentiment")]
        public string Sentiment { get; set; }

        [JsonProperty("sentiment_rate")]
        public double SentimentRate { get; set; }
    }

    public class SentimentAnalysisResponseAmazonType
    {
        [JsonProperty("general_sentiment")]
        public string GeneralSentiment { get; set; }

        [JsonProperty("general_sentiment_rate")]
        public double GeneralSentimentRate { get; set; }

        [JsonProperty("items")]
        public SentimentAnalysisResponseAmazonTypeItemsTypeItem[] Items { get; set; }
    }

    public class SentimentAnalysisResponseAmazonTypeItemsTypeItem
    {
        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("sentiment")]
        public string Sentiment { get; set; }

        [JsonProperty("sentiment_rate")]
        public double SentimentRate { get; set; }
    }

    public class SentimentAnalysisResponseGoogleType
    {
        [JsonProperty("general_sentiment")]
        public string GeneralSentiment { get; set; }

        [JsonProperty("general_sentiment_rate")]
        public double GeneralSentimentRate { get; set; }

        [JsonProperty("items")]
        public SentimentAnalysisResponseGoogleTypeItemsTypeItem[] Items { get; set; }
    }

    public class SentimentAnalysisResponseGoogleTypeItemsTypeItem
    {
        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("sentiment")]
        public string Sentiment { get; set; }

        [JsonProperty("sentiment_rate")]
        public double SentimentRate { get; set; }
    }

    public class SentimentAnalysisResponseMicrosoftType
    {
        [JsonProperty("general_sentiment")]
        public string GeneralSentiment { get; set; }

        [JsonProperty("general_sentiment_rate")]
        public double GeneralSentimentRate { get; set; }

        [JsonProperty("items")]
        public SentimentAnalysisResponseMicrosoftTypeItemsTypeItem[] Items { get; set; }
    }

    public class SentimentAnalysisResponseMicrosoftTypeItemsTypeItem
    {
        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("sentiment")]
        public string Sentiment { get; set; }

        [JsonProperty("sentiment_rate")]
        public double SentimentRate { get; set; }
    }

    public class SentimentAnalysisResponseOneaiType
    {
        [JsonProperty("general_sentiment")]
        public string GeneralSentiment { get; set; }

        [JsonProperty("general_sentiment_rate")]
        public double GeneralSentimentRate { get; set; }

        [JsonProperty("items")]
        public SentimentAnalysisResponseOneaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class SentimentAnalysisResponseOneaiTypeItemsTypeItem
    {
        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("sentiment")]
        public string Sentiment { get; set; }

        [JsonProperty("sentiment_rate")]
        public double SentimentRate { get; set; }
    }

    public class SentimentAnalysisResponseEmvistaType
    {
        [JsonProperty("general_sentiment")]
        public string GeneralSentiment { get; set; }

        [JsonProperty("general_sentiment_rate")]
        public double GeneralSentimentRate { get; set; }

        [JsonProperty("items")]
        public SentimentAnalysisResponseEmvistaTypeItemsTypeItem[] Items { get; set; }
    }

    public class SentimentAnalysisResponseEmvistaTypeItemsTypeItem
    {
        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("sentiment")]
        public string Sentiment { get; set; }

        [JsonProperty("sentiment_rate")]
        public double SentimentRate { get; set; }
    }

    public class SentimentAnalysisResponseOpenaiType
    {
        [JsonProperty("general_sentiment")]
        public string GeneralSentiment { get; set; }

        [JsonProperty("general_sentiment_rate")]
        public double GeneralSentimentRate { get; set; }

        [JsonProperty("items")]
        public SentimentAnalysisResponseOpenaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class SentimentAnalysisResponseOpenaiTypeItemsTypeItem
    {
        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("sentiment")]
        public string Sentiment { get; set; }

        [JsonProperty("sentiment_rate")]
        public double SentimentRate { get; set; }
    }

    public class SentimentAnalysisResponseIbmType
    {
        [JsonProperty("general_sentiment")]
        public string GeneralSentiment { get; set; }

        [JsonProperty("general_sentiment_rate")]
        public double GeneralSentimentRate { get; set; }

        [JsonProperty("items")]
        public SentimentAnalysisResponseIbmTypeItemsTypeItem[] Items { get; set; }
    }

    public class SentimentAnalysisResponseIbmTypeItemsTypeItem
    {
        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("sentiment")]
        public string Sentiment { get; set; }

        [JsonProperty("sentiment_rate")]
        public double SentimentRate { get; set; }
    }

    public class SentimentAnalysisResponseLettriaType
    {
        [JsonProperty("general_sentiment")]
        public string GeneralSentiment { get; set; }

        [JsonProperty("general_sentiment_rate")]
        public double GeneralSentimentRate { get; set; }

        [JsonProperty("items")]
        public SentimentAnalysisResponseLettriaTypeItemsTypeItem[] Items { get; set; }
    }

    public class SentimentAnalysisResponseLettriaTypeItemsTypeItem
    {
        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("sentiment")]
        public string Sentiment { get; set; }

        [JsonProperty("sentiment_rate")]
        public double SentimentRate { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Edenai;

    public partial class WorkflowManagedActions
    {
        public EdenaiActions Edenai(string connectionId) => new EdenaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EdenaiTriggers Edenai(string connectionId) => new EdenaiTriggers(connectionId);
    }
}