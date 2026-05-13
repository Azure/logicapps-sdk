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
        public IBodyWorkflowAction<TextToSpeechResponse> TextToSpeech(Expression<Func<string>> bodyproviders = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyoption = null, Expression<Func<double>> bodyrate = null, Expression<Func<double>> bodypitch = null, Expression<Func<double>> bodyvolume = null, Expression<Func<string>> bodyaudioFormat = null, Expression<Func<double>> bodysamplingRate = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
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
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
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
                    body["option"] = ExpressionConverter.ConvertO(bodyoption);
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
                    body["rate"] = ExpressionConverter.ConvertO(bodyrate);
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
                    body["pitch"] = ExpressionConverter.ConvertO(bodypitch);
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
                    body["volume"] = ExpressionConverter.ConvertO(bodyvolume);
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
                    body["audio_format"] = ExpressionConverter.ConvertO(bodyaudioFormat);
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
                    body["sampling_rate"] = ExpressionConverter.ConvertO(bodysamplingRate);
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

            return new ApiConnectionAction<TextToSpeechResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<ExplicitContentDetectionResponse> ExplicitContentDetection(Expression<Func<string>> providers, Expression<Func<object>> file)
        {
            var apiCallPath = "/v2/image/explicit_content";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ExplicitContentDetectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<TextGenerationResponse> TextGeneration(Expression<Func<string>> bodyproviders = null, Expression<Func<string>> bodytext = null, Expression<Func<double>> bodytemperature = null, Expression<Func<double>> bodymaxTokens = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodytemperature != null)
            {
                if (bodytemperature != null)
                {
                    body["temperature"] = ExpressionConverter.ConvertO(bodytemperature);
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
                    body["max_tokens"] = ExpressionConverter.ConvertO(bodymaxTokens);
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

            return new ApiConnectionAction<TextGenerationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<ChatResponse> Chat(Expression<Func<string>> bodyproviders = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodychatGlobalAction = null, Expression<Func<double>> bodytemperature = null, Expression<Func<double>> bodymaxTokens = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodychatGlobalAction != null)
            {
                body["chat_global_action"] = ExpressionConverter.ConvertO(bodychatGlobalAction);
                bodypropCount++;
            }

            if (bodytemperature != null)
            {
                if (bodytemperature != null)
                {
                    body["temperature"] = ExpressionConverter.ConvertO(bodytemperature);
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
                    body["max_tokens"] = ExpressionConverter.ConvertO(bodymaxTokens);
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

            return new ApiConnectionAction<ChatResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<TopicExtractionResponse> TopicExtraction(Expression<Func<string>> bodyproviders = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodytext = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
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
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TopicExtractionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<KeywordExtractionResponse> KeywordExtraction(Expression<Func<string>> bodyproviders = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodytext = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
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
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<KeywordExtractionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<NamedEntityRecognitionResponse> NamedEntityRecognition(Expression<Func<string>> bodyproviders = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodytext = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
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
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NamedEntityRecognitionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<AnonymizationResponse> Anonymization(Expression<Func<string>> providers, Expression<Func<object>> file)
        {
            var apiCallPath = "/v2/image/anonymization";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AnonymizationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<FaceDetectionResponse> FaceDetection(Expression<Func<string>> providers, Expression<Func<object>> file)
        {
            var apiCallPath = "/v2/image/face_detection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FaceDetectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<ImageGenerationResponse> ImageGeneration(Expression<Func<string>> bodyproviders = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyresolution = null, Expression<Func<double>> bodynumImages = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodyresolution != null)
            {
                if (bodyresolution != null)
                {
                    body["resolution"] = ExpressionConverter.ConvertO(bodyresolution);
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
                    body["num_images"] = ExpressionConverter.ConvertO(bodynumImages);
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

            return new ApiConnectionAction<ImageGenerationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<TranslationResponse> Translation(Expression<Func<string>> bodyproviders = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodysourceLanguage = null, Expression<Func<string>> bodytargetLanguage = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodysourceLanguage != null)
            {
                if (bodysourceLanguage != null)
                {
                    body["source_language"] = ExpressionConverter.ConvertO(bodysourceLanguage);
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
                    body["target_language"] = ExpressionConverter.ConvertO(bodytargetLanguage);
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

            return new ApiConnectionAction<TranslationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<TextModerationResponse> TextModeration(Expression<Func<string>> bodyproviders = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodytext = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
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
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TextModerationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<SummarizationResponse> Summarization(Expression<Func<string>> bodyproviders = null, Expression<Func<double>> bodyoutputSentences = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodylanguage = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                    body["output_sentences"] = ExpressionConverter.ConvertO(bodyoutputSentences);
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
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                if (bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
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

            return new ApiConnectionAction<SummarizationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<LanguageDetectionResponse> LanguageDetection(Expression<Func<string>> bodyproviders = null, Expression<Func<string>> bodytext = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LanguageDetectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<SentimentAnalysisResponse> SentimentAnalysis(Expression<Func<string>> bodyproviders = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodytext = null)
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
                    body["providers"] = ExpressionConverter.ConvertO(bodyproviders);
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
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
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
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SentimentAnalysisResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<InvoiceParserResponse> InvoiceParser(Expression<Func<string>> providers, Expression<Func<string>> language, Expression<Func<object>> file)
        {
            var apiCallPath = "/v2/ocr/invoice_parser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<InvoiceParserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<ResumeParserResponse> ResumeParser(Expression<Func<string>> providers, Expression<Func<object>> file)
        {
            var apiCallPath = "/v2/ocr/resume_parser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResumeParserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<IdentityParserResponse> IdentityParser(Expression<Func<string>> providers, Expression<Func<object>> file)
        {
            var apiCallPath = "/v2/ocr/identity_parser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IdentityParserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edenai")]
        public IBodyWorkflowAction<ReceiptParserResponse> ReceiptParser(Expression<Func<string>> providers, Expression<Func<string>> language, Expression<Func<object>> file)
        {
            var apiCallPath = "/v2/ocr/receipt_parser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ReceiptParserResponse>(callPayload);
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

    public class ExplicitContentDetectionResponse
    {
        [JsonProperty("amazon")]
        public ExplicitContentDetectionResponseAmazonType Amazon { get; set; }

        [JsonProperty("google")]
        public ExplicitContentDetectionResponseGoogleType Google { get; set; }

        [JsonProperty("microsoft")]
        public ExplicitContentDetectionResponseMicrosoftType Microsoft { get; set; }

        [JsonProperty("sentisight")]
        public ExplicitContentDetectionResponseSentisightType Sentisight { get; set; }

        [JsonProperty("picpurify")]
        public ExplicitContentDetectionResponsePicpurifyType Picpurify { get; set; }

        [JsonProperty("api4ai")]
        public ExplicitContentDetectionResponseApi4aiType Api4ai { get; set; }

        [JsonProperty("clarifai")]
        public ExplicitContentDetectionResponseClarifaiType Clarifai { get; set; }
    }

    public class ExplicitContentDetectionResponseAmazonType
    {
        [JsonProperty("nsfw_likelihood")]
        public double NsfwLikelihood { get; set; }

        [JsonProperty("items")]
        public ExplicitContentDetectionResponseAmazonTypeItemsTypeItem[] Items { get; set; }
    }

    public class ExplicitContentDetectionResponseAmazonTypeItemsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("likelihood")]
        public double Likelihood { get; set; }
    }

    public class ExplicitContentDetectionResponseGoogleType
    {
        [JsonProperty("nsfw_likelihood")]
        public double NsfwLikelihood { get; set; }

        [JsonProperty("items")]
        public ExplicitContentDetectionResponseGoogleTypeItemsTypeItem[] Items { get; set; }
    }

    public class ExplicitContentDetectionResponseGoogleTypeItemsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("likelihood")]
        public double Likelihood { get; set; }
    }

    public class ExplicitContentDetectionResponseMicrosoftType
    {
        [JsonProperty("nsfw_likelihood")]
        public double NsfwLikelihood { get; set; }

        [JsonProperty("items")]
        public ExplicitContentDetectionResponseMicrosoftTypeItemsTypeItem[] Items { get; set; }
    }

    public class ExplicitContentDetectionResponseMicrosoftTypeItemsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("likelihood")]
        public double Likelihood { get; set; }
    }

    public class ExplicitContentDetectionResponseSentisightType
    {
        [JsonProperty("nsfw_likelihood")]
        public double NsfwLikelihood { get; set; }

        [JsonProperty("items")]
        public ExplicitContentDetectionResponseSentisightTypeItemsTypeItem[] Items { get; set; }
    }

    public class ExplicitContentDetectionResponseSentisightTypeItemsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("likelihood")]
        public double Likelihood { get; set; }
    }

    public class ExplicitContentDetectionResponsePicpurifyType
    {
        [JsonProperty("nsfw_likelihood")]
        public double NsfwLikelihood { get; set; }

        [JsonProperty("items")]
        public ExplicitContentDetectionResponsePicpurifyTypeItemsTypeItem[] Items { get; set; }
    }

    public class ExplicitContentDetectionResponsePicpurifyTypeItemsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("likelihood")]
        public double Likelihood { get; set; }
    }

    public class ExplicitContentDetectionResponseApi4aiType
    {
        [JsonProperty("nsfw_likelihood")]
        public double NsfwLikelihood { get; set; }

        [JsonProperty("items")]
        public ExplicitContentDetectionResponseApi4aiTypeItemsTypeItem[] Items { get; set; }
    }

    public class ExplicitContentDetectionResponseApi4aiTypeItemsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("likelihood")]
        public double Likelihood { get; set; }
    }

    public class ExplicitContentDetectionResponseClarifaiType
    {
        [JsonProperty("nsfw_likelihood")]
        public double NsfwLikelihood { get; set; }

        [JsonProperty("items")]
        public ExplicitContentDetectionResponseClarifaiTypeItemsTypeItem[] Items { get; set; }
    }

    public class ExplicitContentDetectionResponseClarifaiTypeItemsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("likelihood")]
        public double Likelihood { get; set; }
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

    public class AnonymizationResponse
    {
        [JsonProperty("api4ai")]
        public AnonymizationResponseApi4aiType Api4ai { get; set; }
    }

    public class AnonymizationResponseApi4aiType
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("items")]
        public AnonymizationResponseApi4aiTypeItemsTypeItem[] Items { get; set; }
    }

    public class AnonymizationResponseApi4aiTypeItemsTypeItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("bounding_boxes")]
        public AnonymizationResponseApi4aiTypeItemsTypeItemBoundingBoxesType BoundingBoxes { get; set; }
    }

    public class AnonymizationResponseApi4aiTypeItemsTypeItemBoundingBoxesType
    {
        [JsonProperty("x_max")]
        public double XMax { get; set; }

        [JsonProperty("x_min")]
        public double XMin { get; set; }

        [JsonProperty("y_max")]
        public double YMax { get; set; }

        [JsonProperty("y_min")]
        public double YMin { get; set; }
    }

    public class FaceDetectionResponse
    {
        [JsonProperty("amazon")]
        public FaceDetectionResponseAmazonType Amazon { get; set; }

        [JsonProperty("google")]
        public FaceDetectionResponseGoogleType Google { get; set; }

        [JsonProperty("clarifai")]
        public FaceDetectionResponseClarifaiType Clarifai { get; set; }
    }

    public class FaceDetectionResponseAmazonType
    {
        [JsonProperty("items")]
        public FaceDetectionResponseAmazonTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItem
    {
        [JsonProperty("accessories")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemAccessoriesType Accessories { get; set; }

        [JsonProperty("age")]
        public double Age { get; set; }

        [JsonProperty("bounding_box")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemBoundingBoxType BoundingBox { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("emotions")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemEmotionsType Emotions { get; set; }

        [JsonProperty("facial_hair")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemFacialHairType FacialHair { get; set; }

        [JsonProperty("features")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemFeaturesType Features { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("hair")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemHairType Hair { get; set; }

        [JsonProperty("landmarks")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemLandmarksType Landmarks { get; set; }

        [JsonProperty("makeup")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemMakeupType Makeup { get; set; }

        [JsonProperty("occlusions")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemOcclusionsType Occlusions { get; set; }

        [JsonProperty("poses")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemPosesType Poses { get; set; }

        [JsonProperty("quality")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemQualityType Quality { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemAccessoriesType
    {
        [JsonProperty("eyeglasses")]
        public double Eyeglasses { get; set; }

        [JsonProperty("face_mask")]
        public double FaceMask { get; set; }

        [JsonProperty("headwear")]
        public double Headwear { get; set; }

        [JsonProperty("reading_glasses")]
        public double ReadingGlasses { get; set; }

        [JsonProperty("sunglasses")]
        public double Sunglasses { get; set; }

        [JsonProperty("swimming_goggles")]
        public double SwimmingGoggles { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemBoundingBoxType
    {
        [JsonProperty("x_max")]
        public double XMax { get; set; }

        [JsonProperty("x_min")]
        public double XMin { get; set; }

        [JsonProperty("y_max")]
        public double YMax { get; set; }

        [JsonProperty("y_min")]
        public double YMin { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemEmotionsType
    {
        [JsonProperty("anger")]
        public int Anger { get; set; }

        [JsonProperty("calm")]
        public int Calm { get; set; }

        [JsonProperty("confusion")]
        public int Confusion { get; set; }

        [JsonProperty("contempt")]
        public int Contempt { get; set; }

        [JsonProperty("disgust")]
        public int Disgust { get; set; }

        [JsonProperty("fear")]
        public int Fear { get; set; }

        [JsonProperty("joy")]
        public int Joy { get; set; }

        [JsonProperty("neutral")]
        public int Neutral { get; set; }

        [JsonProperty("sorrow")]
        public int Sorrow { get; set; }

        [JsonProperty("surprise")]
        public int Surprise { get; set; }

        [JsonProperty("unknown")]
        public int Unknown { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemFacialHairType
    {
        [JsonProperty("beard")]
        public double Beard { get; set; }

        [JsonProperty("moustache")]
        public double Moustache { get; set; }

        [JsonProperty("sideburns")]
        public double Sideburns { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemFeaturesType
    {
        [JsonProperty("eyes_open")]
        public double EyesOpen { get; set; }

        [JsonProperty("mouth_open")]
        public double MouthOpen { get; set; }

        [JsonProperty("smile")]
        public double Smile { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemHairType
    {
        [JsonProperty("bald")]
        public double Bald { get; set; }

        [JsonProperty("hair_color")]
        public FaceDetectionResponseAmazonTypeItemsTypeItemHairTypeHairColorTypeItem[] HairColor { get; set; }

        [JsonProperty("invisible")]
        public bool Invisible { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemHairTypeHairColorTypeItem
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemLandmarksType
    {
        [JsonProperty("chin_gnathion")]
        public double[] ChinGnathion { get; set; }

        [JsonProperty("chin_left_gonion")]
        public double[] ChinLeftGonion { get; set; }

        [JsonProperty("chin_right_gonion")]
        public double[] ChinRightGonion { get; set; }

        [JsonProperty("forehead_glabella")]
        public double[] ForeheadGlabella { get; set; }

        [JsonProperty("left_cheek_center")]
        public double[] LeftCheekCenter { get; set; }

        [JsonProperty("left_ear_tragion")]
        public double[] LeftEarTragion { get; set; }

        [JsonProperty("left_eye")]
        public double[] LeftEye { get; set; }

        [JsonProperty("left_eye_bottom")]
        public double[] LeftEyeBottom { get; set; }

        [JsonProperty("left_eye_left")]
        public double[] LeftEyeLeft { get; set; }

        [JsonProperty("left_eye_right")]
        public double[] LeftEyeRight { get; set; }

        [JsonProperty("left_eye_top")]
        public double[] LeftEyeTop { get; set; }

        [JsonProperty("left_eyebrow_left")]
        public double[] LeftEyebrowLeft { get; set; }

        [JsonProperty("left_eyebrow_right")]
        public double[] LeftEyebrowRight { get; set; }

        [JsonProperty("left_eyebrow_top")]
        public double[] LeftEyebrowTop { get; set; }

        [JsonProperty("left_pupil")]
        public double[] LeftPupil { get; set; }

        [JsonProperty("mid_jawline_left")]
        public double[] MidJawlineLeft { get; set; }

        [JsonProperty("mid_jawline_right")]
        public double[] MidJawlineRight { get; set; }

        [JsonProperty("midpoint_between_eyes")]
        public double[] MidpointBetweenEyes { get; set; }

        [JsonProperty("mouth_bottom")]
        public double[] MouthBottom { get; set; }

        [JsonProperty("mouth_center")]
        public double[] MouthCenter { get; set; }

        [JsonProperty("mouth_left")]
        public double[] MouthLeft { get; set; }

        [JsonProperty("mouth_right")]
        public double[] MouthRight { get; set; }

        [JsonProperty("mouth_top")]
        public double[] MouthTop { get; set; }

        [JsonProperty("nose_bottom_center")]
        public double[] NoseBottomCenter { get; set; }

        [JsonProperty("nose_bottom_left")]
        public double[] NoseBottomLeft { get; set; }

        [JsonProperty("nose_bottom_right")]
        public double[] NoseBottomRight { get; set; }

        [JsonProperty("nose_left_alar_out_tip")]
        public double[] NoseLeftAlarOutTip { get; set; }

        [JsonProperty("nose_left_alar_top")]
        public double[] NoseLeftAlarTop { get; set; }

        [JsonProperty("nose_right_alar_out_tip")]
        public double[] NoseRightAlarOutTip { get; set; }

        [JsonProperty("nose_right_alar_top")]
        public double[] NoseRightAlarTop { get; set; }

        [JsonProperty("nose_root_left")]
        public double[] NoseRootLeft { get; set; }

        [JsonProperty("nose_root_right")]
        public double[] NoseRootRight { get; set; }

        [JsonProperty("nose_tip")]
        public double[] NoseTip { get; set; }

        [JsonProperty("right_cheek_center")]
        public double[] RightCheekCenter { get; set; }

        [JsonProperty("right_ear_tragion")]
        public double[] RightEarTragion { get; set; }

        [JsonProperty("right_eye")]
        public double[] RightEye { get; set; }

        [JsonProperty("right_eye_bottom")]
        public double[] RightEyeBottom { get; set; }

        [JsonProperty("right_eye_left")]
        public double[] RightEyeLeft { get; set; }

        [JsonProperty("right_eye_right")]
        public double[] RightEyeRight { get; set; }

        [JsonProperty("right_eye_top")]
        public double[] RightEyeTop { get; set; }

        [JsonProperty("right_eyebrow_left")]
        public double[] RightEyebrowLeft { get; set; }

        [JsonProperty("right_eyebrow_right")]
        public double[] RightEyebrowRight { get; set; }

        [JsonProperty("right_eyebrow_top")]
        public double[] RightEyebrowTop { get; set; }

        [JsonProperty("right_pupil")]
        public double[] RightPupil { get; set; }

        [JsonProperty("under_lip")]
        public double[] UnderLip { get; set; }

        [JsonProperty("under_lip_bottom")]
        public double[] UnderLipBottom { get; set; }

        [JsonProperty("under_lip_top")]
        public double[] UnderLipTop { get; set; }

        [JsonProperty("upper_jawline_left")]
        public double[] UpperJawlineLeft { get; set; }

        [JsonProperty("upper_jawline_right")]
        public double[] UpperJawlineRight { get; set; }

        [JsonProperty("upper_lip")]
        public double[] UpperLip { get; set; }

        [JsonProperty("upper_lip_bottom")]
        public double[] UpperLipBottom { get; set; }

        [JsonProperty("upper_lip_top")]
        public double[] UpperLipTop { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemMakeupType
    {
        [JsonProperty("eye_make")]
        public bool EyeMake { get; set; }

        [JsonProperty("lip_make")]
        public bool LipMake { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemOcclusionsType
    {
        [JsonProperty("eye_occluded")]
        public bool EyeOccluded { get; set; }

        [JsonProperty("forehead_occluded")]
        public bool ForeheadOccluded { get; set; }

        [JsonProperty("mouth_occluded")]
        public bool MouthOccluded { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemPosesType
    {
        [JsonProperty("pitch")]
        public double Pitch { get; set; }

        [JsonProperty("roll")]
        public double Roll { get; set; }

        [JsonProperty("yaw")]
        public double Yaw { get; set; }
    }

    public class FaceDetectionResponseAmazonTypeItemsTypeItemQualityType
    {
        [JsonProperty("blur")]
        public double Blur { get; set; }

        [JsonProperty("brightness")]
        public double Brightness { get; set; }

        [JsonProperty("exposure")]
        public double Exposure { get; set; }

        [JsonProperty("noise")]
        public double Noise { get; set; }

        [JsonProperty("sharpness")]
        public double Sharpness { get; set; }
    }

    public class FaceDetectionResponseGoogleType
    {
        [JsonProperty("items")]
        public FaceDetectionResponseGoogleTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItem
    {
        [JsonProperty("accessories")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemAccessoriesType Accessories { get; set; }

        [JsonProperty("age")]
        public double Age { get; set; }

        [JsonProperty("bounding_box")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemBoundingBoxType BoundingBox { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("emotions")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemEmotionsType Emotions { get; set; }

        [JsonProperty("facial_hair")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemFacialHairType FacialHair { get; set; }

        [JsonProperty("features")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemFeaturesType Features { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("hair")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemHairType Hair { get; set; }

        [JsonProperty("landmarks")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemLandmarksType Landmarks { get; set; }

        [JsonProperty("makeup")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemMakeupType Makeup { get; set; }

        [JsonProperty("occlusions")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemOcclusionsType Occlusions { get; set; }

        [JsonProperty("poses")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemPosesType Poses { get; set; }

        [JsonProperty("quality")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemQualityType Quality { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemAccessoriesType
    {
        [JsonProperty("eyeglasses")]
        public double Eyeglasses { get; set; }

        [JsonProperty("face_mask")]
        public double FaceMask { get; set; }

        [JsonProperty("headwear")]
        public double Headwear { get; set; }

        [JsonProperty("reading_glasses")]
        public double ReadingGlasses { get; set; }

        [JsonProperty("sunglasses")]
        public double Sunglasses { get; set; }

        [JsonProperty("swimming_goggles")]
        public double SwimmingGoggles { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemBoundingBoxType
    {
        [JsonProperty("x_max")]
        public double XMax { get; set; }

        [JsonProperty("x_min")]
        public double XMin { get; set; }

        [JsonProperty("y_max")]
        public double YMax { get; set; }

        [JsonProperty("y_min")]
        public double YMin { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemEmotionsType
    {
        [JsonProperty("anger")]
        public int Anger { get; set; }

        [JsonProperty("calm")]
        public int Calm { get; set; }

        [JsonProperty("confusion")]
        public int Confusion { get; set; }

        [JsonProperty("contempt")]
        public int Contempt { get; set; }

        [JsonProperty("disgust")]
        public int Disgust { get; set; }

        [JsonProperty("fear")]
        public int Fear { get; set; }

        [JsonProperty("joy")]
        public int Joy { get; set; }

        [JsonProperty("neutral")]
        public int Neutral { get; set; }

        [JsonProperty("sorrow")]
        public int Sorrow { get; set; }

        [JsonProperty("surprise")]
        public int Surprise { get; set; }

        [JsonProperty("unknown")]
        public int Unknown { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemFacialHairType
    {
        [JsonProperty("beard")]
        public double Beard { get; set; }

        [JsonProperty("moustache")]
        public double Moustache { get; set; }

        [JsonProperty("sideburns")]
        public double Sideburns { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemFeaturesType
    {
        [JsonProperty("eyes_open")]
        public double EyesOpen { get; set; }

        [JsonProperty("mouth_open")]
        public double MouthOpen { get; set; }

        [JsonProperty("smile")]
        public double Smile { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemHairType
    {
        [JsonProperty("bald")]
        public double Bald { get; set; }

        [JsonProperty("hair_color")]
        public FaceDetectionResponseGoogleTypeItemsTypeItemHairTypeHairColorTypeItem[] HairColor { get; set; }

        [JsonProperty("invisible")]
        public bool Invisible { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemHairTypeHairColorTypeItem
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemLandmarksType
    {
        [JsonProperty("chin_gnathion")]
        public double[] ChinGnathion { get; set; }

        [JsonProperty("chin_left_gonion")]
        public double[] ChinLeftGonion { get; set; }

        [JsonProperty("chin_right_gonion")]
        public double[] ChinRightGonion { get; set; }

        [JsonProperty("forehead_glabella")]
        public double[] ForeheadGlabella { get; set; }

        [JsonProperty("left_cheek_center")]
        public double[] LeftCheekCenter { get; set; }

        [JsonProperty("left_ear_tragion")]
        public double[] LeftEarTragion { get; set; }

        [JsonProperty("left_eye")]
        public double[] LeftEye { get; set; }

        [JsonProperty("left_eye_bottom")]
        public double[] LeftEyeBottom { get; set; }

        [JsonProperty("left_eye_left")]
        public double[] LeftEyeLeft { get; set; }

        [JsonProperty("left_eye_right")]
        public double[] LeftEyeRight { get; set; }

        [JsonProperty("left_eye_top")]
        public double[] LeftEyeTop { get; set; }

        [JsonProperty("left_eyebrow_left")]
        public double[] LeftEyebrowLeft { get; set; }

        [JsonProperty("left_eyebrow_right")]
        public double[] LeftEyebrowRight { get; set; }

        [JsonProperty("left_eyebrow_top")]
        public double[] LeftEyebrowTop { get; set; }

        [JsonProperty("left_pupil")]
        public double[] LeftPupil { get; set; }

        [JsonProperty("mid_jawline_left")]
        public double[] MidJawlineLeft { get; set; }

        [JsonProperty("mid_jawline_right")]
        public double[] MidJawlineRight { get; set; }

        [JsonProperty("midpoint_between_eyes")]
        public double[] MidpointBetweenEyes { get; set; }

        [JsonProperty("mouth_bottom")]
        public double[] MouthBottom { get; set; }

        [JsonProperty("mouth_center")]
        public double[] MouthCenter { get; set; }

        [JsonProperty("mouth_left")]
        public double[] MouthLeft { get; set; }

        [JsonProperty("mouth_right")]
        public double[] MouthRight { get; set; }

        [JsonProperty("mouth_top")]
        public double[] MouthTop { get; set; }

        [JsonProperty("nose_bottom_center")]
        public double[] NoseBottomCenter { get; set; }

        [JsonProperty("nose_bottom_left")]
        public double[] NoseBottomLeft { get; set; }

        [JsonProperty("nose_bottom_right")]
        public double[] NoseBottomRight { get; set; }

        [JsonProperty("nose_left_alar_out_tip")]
        public double[] NoseLeftAlarOutTip { get; set; }

        [JsonProperty("nose_left_alar_top")]
        public double[] NoseLeftAlarTop { get; set; }

        [JsonProperty("nose_right_alar_out_tip")]
        public double[] NoseRightAlarOutTip { get; set; }

        [JsonProperty("nose_right_alar_top")]
        public double[] NoseRightAlarTop { get; set; }

        [JsonProperty("nose_root_left")]
        public double[] NoseRootLeft { get; set; }

        [JsonProperty("nose_root_right")]
        public double[] NoseRootRight { get; set; }

        [JsonProperty("nose_tip")]
        public double[] NoseTip { get; set; }

        [JsonProperty("right_cheek_center")]
        public double[] RightCheekCenter { get; set; }

        [JsonProperty("right_ear_tragion")]
        public double[] RightEarTragion { get; set; }

        [JsonProperty("right_eye")]
        public double[] RightEye { get; set; }

        [JsonProperty("right_eye_bottom")]
        public double[] RightEyeBottom { get; set; }

        [JsonProperty("right_eye_left")]
        public double[] RightEyeLeft { get; set; }

        [JsonProperty("right_eye_right")]
        public double[] RightEyeRight { get; set; }

        [JsonProperty("right_eye_top")]
        public double[] RightEyeTop { get; set; }

        [JsonProperty("right_eyebrow_left")]
        public double[] RightEyebrowLeft { get; set; }

        [JsonProperty("right_eyebrow_right")]
        public double[] RightEyebrowRight { get; set; }

        [JsonProperty("right_eyebrow_top")]
        public double[] RightEyebrowTop { get; set; }

        [JsonProperty("right_pupil")]
        public double[] RightPupil { get; set; }

        [JsonProperty("under_lip")]
        public double[] UnderLip { get; set; }

        [JsonProperty("under_lip_bottom")]
        public double[] UnderLipBottom { get; set; }

        [JsonProperty("under_lip_top")]
        public double[] UnderLipTop { get; set; }

        [JsonProperty("upper_jawline_left")]
        public double[] UpperJawlineLeft { get; set; }

        [JsonProperty("upper_jawline_right")]
        public double[] UpperJawlineRight { get; set; }

        [JsonProperty("upper_lip")]
        public double[] UpperLip { get; set; }

        [JsonProperty("upper_lip_bottom")]
        public double[] UpperLipBottom { get; set; }

        [JsonProperty("upper_lip_top")]
        public double[] UpperLipTop { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemMakeupType
    {
        [JsonProperty("eye_make")]
        public bool EyeMake { get; set; }

        [JsonProperty("lip_make")]
        public bool LipMake { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemOcclusionsType
    {
        [JsonProperty("eye_occluded")]
        public bool EyeOccluded { get; set; }

        [JsonProperty("forehead_occluded")]
        public bool ForeheadOccluded { get; set; }

        [JsonProperty("mouth_occluded")]
        public bool MouthOccluded { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemPosesType
    {
        [JsonProperty("pitch")]
        public double Pitch { get; set; }

        [JsonProperty("roll")]
        public double Roll { get; set; }

        [JsonProperty("yaw")]
        public double Yaw { get; set; }
    }

    public class FaceDetectionResponseGoogleTypeItemsTypeItemQualityType
    {
        [JsonProperty("blur")]
        public double Blur { get; set; }

        [JsonProperty("brightness")]
        public double Brightness { get; set; }

        [JsonProperty("exposure")]
        public double Exposure { get; set; }

        [JsonProperty("noise")]
        public double Noise { get; set; }

        [JsonProperty("sharpness")]
        public double Sharpness { get; set; }
    }

    public class FaceDetectionResponseClarifaiType
    {
        [JsonProperty("items")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItem
    {
        [JsonProperty("accessories")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemAccessoriesType Accessories { get; set; }

        [JsonProperty("age")]
        public double Age { get; set; }

        [JsonProperty("bounding_box")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemBoundingBoxType BoundingBox { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("emotions")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemEmotionsType Emotions { get; set; }

        [JsonProperty("facial_hair")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemFacialHairType FacialHair { get; set; }

        [JsonProperty("features")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemFeaturesType Features { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("hair")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemHairType Hair { get; set; }

        [JsonProperty("landmarks")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemLandmarksType Landmarks { get; set; }

        [JsonProperty("makeup")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemMakeupType Makeup { get; set; }

        [JsonProperty("occlusions")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemOcclusionsType Occlusions { get; set; }

        [JsonProperty("poses")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemPosesType Poses { get; set; }

        [JsonProperty("quality")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemQualityType Quality { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemAccessoriesType
    {
        [JsonProperty("eyeglasses")]
        public double Eyeglasses { get; set; }

        [JsonProperty("face_mask")]
        public double FaceMask { get; set; }

        [JsonProperty("headwear")]
        public double Headwear { get; set; }

        [JsonProperty("reading_glasses")]
        public double ReadingGlasses { get; set; }

        [JsonProperty("sunglasses")]
        public double Sunglasses { get; set; }

        [JsonProperty("swimming_goggles")]
        public double SwimmingGoggles { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemBoundingBoxType
    {
        [JsonProperty("x_max")]
        public double XMax { get; set; }

        [JsonProperty("x_min")]
        public double XMin { get; set; }

        [JsonProperty("y_max")]
        public double YMax { get; set; }

        [JsonProperty("y_min")]
        public double YMin { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemEmotionsType
    {
        [JsonProperty("anger")]
        public int Anger { get; set; }

        [JsonProperty("calm")]
        public int Calm { get; set; }

        [JsonProperty("confusion")]
        public int Confusion { get; set; }

        [JsonProperty("contempt")]
        public int Contempt { get; set; }

        [JsonProperty("disgust")]
        public int Disgust { get; set; }

        [JsonProperty("fear")]
        public int Fear { get; set; }

        [JsonProperty("joy")]
        public int Joy { get; set; }

        [JsonProperty("neutral")]
        public int Neutral { get; set; }

        [JsonProperty("sorrow")]
        public int Sorrow { get; set; }

        [JsonProperty("surprise")]
        public int Surprise { get; set; }

        [JsonProperty("unknown")]
        public int Unknown { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemFacialHairType
    {
        [JsonProperty("beard")]
        public double Beard { get; set; }

        [JsonProperty("moustache")]
        public double Moustache { get; set; }

        [JsonProperty("sideburns")]
        public double Sideburns { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemFeaturesType
    {
        [JsonProperty("eyes_open")]
        public double EyesOpen { get; set; }

        [JsonProperty("mouth_open")]
        public double MouthOpen { get; set; }

        [JsonProperty("smile")]
        public double Smile { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemHairType
    {
        [JsonProperty("bald")]
        public double Bald { get; set; }

        [JsonProperty("hair_color")]
        public FaceDetectionResponseClarifaiTypeItemsTypeItemHairTypeHairColorTypeItem[] HairColor { get; set; }

        [JsonProperty("invisible")]
        public bool Invisible { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemHairTypeHairColorTypeItem
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemLandmarksType
    {
        [JsonProperty("chin_gnathion")]
        public double[] ChinGnathion { get; set; }

        [JsonProperty("chin_left_gonion")]
        public double[] ChinLeftGonion { get; set; }

        [JsonProperty("chin_right_gonion")]
        public double[] ChinRightGonion { get; set; }

        [JsonProperty("forehead_glabella")]
        public double[] ForeheadGlabella { get; set; }

        [JsonProperty("left_cheek_center")]
        public double[] LeftCheekCenter { get; set; }

        [JsonProperty("left_ear_tragion")]
        public double[] LeftEarTragion { get; set; }

        [JsonProperty("left_eye")]
        public double[] LeftEye { get; set; }

        [JsonProperty("left_eye_bottom")]
        public double[] LeftEyeBottom { get; set; }

        [JsonProperty("left_eye_left")]
        public double[] LeftEyeLeft { get; set; }

        [JsonProperty("left_eye_right")]
        public double[] LeftEyeRight { get; set; }

        [JsonProperty("left_eye_top")]
        public double[] LeftEyeTop { get; set; }

        [JsonProperty("left_eyebrow_left")]
        public double[] LeftEyebrowLeft { get; set; }

        [JsonProperty("left_eyebrow_right")]
        public double[] LeftEyebrowRight { get; set; }

        [JsonProperty("left_eyebrow_top")]
        public double[] LeftEyebrowTop { get; set; }

        [JsonProperty("left_pupil")]
        public double[] LeftPupil { get; set; }

        [JsonProperty("mid_jawline_left")]
        public double[] MidJawlineLeft { get; set; }

        [JsonProperty("mid_jawline_right")]
        public double[] MidJawlineRight { get; set; }

        [JsonProperty("midpoint_between_eyes")]
        public double[] MidpointBetweenEyes { get; set; }

        [JsonProperty("mouth_bottom")]
        public double[] MouthBottom { get; set; }

        [JsonProperty("mouth_center")]
        public double[] MouthCenter { get; set; }

        [JsonProperty("mouth_left")]
        public double[] MouthLeft { get; set; }

        [JsonProperty("mouth_right")]
        public double[] MouthRight { get; set; }

        [JsonProperty("mouth_top")]
        public double[] MouthTop { get; set; }

        [JsonProperty("nose_bottom_center")]
        public double[] NoseBottomCenter { get; set; }

        [JsonProperty("nose_bottom_left")]
        public double[] NoseBottomLeft { get; set; }

        [JsonProperty("nose_bottom_right")]
        public double[] NoseBottomRight { get; set; }

        [JsonProperty("nose_left_alar_out_tip")]
        public double[] NoseLeftAlarOutTip { get; set; }

        [JsonProperty("nose_left_alar_top")]
        public double[] NoseLeftAlarTop { get; set; }

        [JsonProperty("nose_right_alar_out_tip")]
        public double[] NoseRightAlarOutTip { get; set; }

        [JsonProperty("nose_right_alar_top")]
        public double[] NoseRightAlarTop { get; set; }

        [JsonProperty("nose_root_left")]
        public double[] NoseRootLeft { get; set; }

        [JsonProperty("nose_root_right")]
        public double[] NoseRootRight { get; set; }

        [JsonProperty("nose_tip")]
        public double[] NoseTip { get; set; }

        [JsonProperty("right_cheek_center")]
        public double[] RightCheekCenter { get; set; }

        [JsonProperty("right_ear_tragion")]
        public double[] RightEarTragion { get; set; }

        [JsonProperty("right_eye")]
        public double[] RightEye { get; set; }

        [JsonProperty("right_eye_bottom")]
        public double[] RightEyeBottom { get; set; }

        [JsonProperty("right_eye_left")]
        public double[] RightEyeLeft { get; set; }

        [JsonProperty("right_eye_right")]
        public double[] RightEyeRight { get; set; }

        [JsonProperty("right_eye_top")]
        public double[] RightEyeTop { get; set; }

        [JsonProperty("right_eyebrow_left")]
        public double[] RightEyebrowLeft { get; set; }

        [JsonProperty("right_eyebrow_right")]
        public double[] RightEyebrowRight { get; set; }

        [JsonProperty("right_eyebrow_top")]
        public double[] RightEyebrowTop { get; set; }

        [JsonProperty("right_pupil")]
        public double[] RightPupil { get; set; }

        [JsonProperty("under_lip")]
        public double[] UnderLip { get; set; }

        [JsonProperty("under_lip_bottom")]
        public double[] UnderLipBottom { get; set; }

        [JsonProperty("under_lip_top")]
        public double[] UnderLipTop { get; set; }

        [JsonProperty("upper_jawline_left")]
        public double[] UpperJawlineLeft { get; set; }

        [JsonProperty("upper_jawline_right")]
        public double[] UpperJawlineRight { get; set; }

        [JsonProperty("upper_lip")]
        public double[] UpperLip { get; set; }

        [JsonProperty("upper_lip_bottom")]
        public double[] UpperLipBottom { get; set; }

        [JsonProperty("upper_lip_top")]
        public double[] UpperLipTop { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemMakeupType
    {
        [JsonProperty("eye_make")]
        public bool EyeMake { get; set; }

        [JsonProperty("lip_make")]
        public bool LipMake { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemOcclusionsType
    {
        [JsonProperty("eye_occluded")]
        public bool EyeOccluded { get; set; }

        [JsonProperty("forehead_occluded")]
        public bool ForeheadOccluded { get; set; }

        [JsonProperty("mouth_occluded")]
        public bool MouthOccluded { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemPosesType
    {
        [JsonProperty("pitch")]
        public double Pitch { get; set; }

        [JsonProperty("roll")]
        public double Roll { get; set; }

        [JsonProperty("yaw")]
        public double Yaw { get; set; }
    }

    public class FaceDetectionResponseClarifaiTypeItemsTypeItemQualityType
    {
        [JsonProperty("blur")]
        public double Blur { get; set; }

        [JsonProperty("brightness")]
        public double Brightness { get; set; }

        [JsonProperty("exposure")]
        public double Exposure { get; set; }

        [JsonProperty("noise")]
        public double Noise { get; set; }

        [JsonProperty("sharpness")]
        public double Sharpness { get; set; }
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

    public class InvoiceParserResponse
    {
        [JsonProperty("amazon")]
        public InvoiceParserResponseAmazonType Amazon { get; set; }

        [JsonProperty("base64")]
        public InvoiceParserResponseBase64Type Base64 { get; set; }

        [JsonProperty("dataleon")]
        public InvoiceParserResponseDataleonType Dataleon { get; set; }

        [JsonProperty("mindee")]
        public InvoiceParserResponseMindeeType Mindee { get; set; }

        [JsonProperty("google")]
        public InvoiceParserResponseGoogleType Google { get; set; }

        [JsonProperty("affinda")]
        public InvoiceParserResponseAffindaType Affinda { get; set; }

        [JsonProperty("microsoft")]
        public InvoiceParserResponseMicrosoftType Microsoft { get; set; }

        [JsonProperty("veryfi")]
        public InvoiceParserResponseVeryfiType Veryfi { get; set; }
    }

    public class InvoiceParserResponseAmazonType
    {
        [JsonProperty("extracted_data")]
        public InvoiceParserResponseAmazonTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class InvoiceParserResponseAmazonTypeExtractedDataTypeItem
    {
        [JsonProperty("customer_information")]
        public InvoiceParserResponseAmazonTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public InvoiceParserResponseAmazonTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("amount_due")]
        public double AmountDue { get; set; }

        [JsonProperty("previous_unpaid_balance")]
        public double PreviousUnpaidBalance { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("taxes")]
        public InvoiceParserResponseAmazonTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_term")]
        public string PaymentTerm { get; set; }

        [JsonProperty("purchase_order")]
        public string PurchaseOrder { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        [JsonProperty("service_due_date")]
        public string ServiceDueDate { get; set; }

        [JsonProperty("locale")]
        public InvoiceParserResponseAmazonTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("bank_informations")]
        public InvoiceParserResponseAmazonTypeExtractedDataTypeItemBankInformationsType BankInformations { get; set; }

        [JsonProperty("item_lines")]
        public InvoiceParserResponseAmazonTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class InvoiceParserResponseAmazonTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_tax_id")]
        public string CustomerTaxId { get; set; }

        [JsonProperty("customer_mailing_address")]
        public string CustomerMailingAddress { get; set; }

        [JsonProperty("customer_billing_address")]
        public string CustomerBillingAddress { get; set; }

        [JsonProperty("customer_shipping_address")]
        public string CustomerShippingAddress { get; set; }

        [JsonProperty("customer_service_address")]
        public string CustomerServiceAddress { get; set; }

        [JsonProperty("customer_remittance_address")]
        public string CustomerRemittanceAddress { get; set; }
    }

    public class InvoiceParserResponseAmazonTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_email")]
        public string MerchantEmail { get; set; }

        [JsonProperty("merchant_fax")]
        public string MerchantFax { get; set; }

        [JsonProperty("merchant_website")]
        public string MerchantWebsite { get; set; }

        [JsonProperty("merchant_tax_id")]
        public string MerchantTaxId { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class InvoiceParserResponseAmazonTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class InvoiceParserResponseAmazonTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class InvoiceParserResponseAmazonTypeExtractedDataTypeItemBankInformationsType
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("bsb")]
        public string Bsb { get; set; }

        [JsonProperty("sort_code")]
        public string SortCode { get; set; }

        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("rooting_number")]
        public string RootingNumber { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }
    }

    public class InvoiceParserResponseAmazonTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("date_item")]
        public string DateItem { get; set; }

        [JsonProperty("tax_item")]
        public double TaxItem { get; set; }

        [JsonProperty("tax_rate")]
        public double TaxRate { get; set; }
    }

    public class InvoiceParserResponseBase64Type
    {
        [JsonProperty("extracted_data")]
        public InvoiceParserResponseBase64TypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class InvoiceParserResponseBase64TypeExtractedDataTypeItem
    {
        [JsonProperty("customer_information")]
        public InvoiceParserResponseBase64TypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public InvoiceParserResponseBase64TypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("amount_due")]
        public double AmountDue { get; set; }

        [JsonProperty("previous_unpaid_balance")]
        public double PreviousUnpaidBalance { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("taxes")]
        public InvoiceParserResponseBase64TypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_term")]
        public string PaymentTerm { get; set; }

        [JsonProperty("purchase_order")]
        public string PurchaseOrder { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        [JsonProperty("service_due_date")]
        public string ServiceDueDate { get; set; }

        [JsonProperty("locale")]
        public InvoiceParserResponseBase64TypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("bank_informations")]
        public InvoiceParserResponseBase64TypeExtractedDataTypeItemBankInformationsType BankInformations { get; set; }

        [JsonProperty("item_lines")]
        public InvoiceParserResponseBase64TypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class InvoiceParserResponseBase64TypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_tax_id")]
        public string CustomerTaxId { get; set; }

        [JsonProperty("customer_mailing_address")]
        public string CustomerMailingAddress { get; set; }

        [JsonProperty("customer_billing_address")]
        public string CustomerBillingAddress { get; set; }

        [JsonProperty("customer_shipping_address")]
        public string CustomerShippingAddress { get; set; }

        [JsonProperty("customer_service_address")]
        public string CustomerServiceAddress { get; set; }

        [JsonProperty("customer_remittance_address")]
        public string CustomerRemittanceAddress { get; set; }
    }

    public class InvoiceParserResponseBase64TypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_email")]
        public string MerchantEmail { get; set; }

        [JsonProperty("merchant_fax")]
        public string MerchantFax { get; set; }

        [JsonProperty("merchant_website")]
        public string MerchantWebsite { get; set; }

        [JsonProperty("merchant_tax_id")]
        public string MerchantTaxId { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class InvoiceParserResponseBase64TypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class InvoiceParserResponseBase64TypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class InvoiceParserResponseBase64TypeExtractedDataTypeItemBankInformationsType
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("bsb")]
        public string Bsb { get; set; }

        [JsonProperty("sort_code")]
        public string SortCode { get; set; }

        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("rooting_number")]
        public string RootingNumber { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }
    }

    public class InvoiceParserResponseBase64TypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("date_item")]
        public string DateItem { get; set; }

        [JsonProperty("tax_item")]
        public double TaxItem { get; set; }

        [JsonProperty("tax_rate")]
        public double TaxRate { get; set; }
    }

    public class InvoiceParserResponseDataleonType
    {
        [JsonProperty("extracted_data")]
        public InvoiceParserResponseDataleonTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class InvoiceParserResponseDataleonTypeExtractedDataTypeItem
    {
        [JsonProperty("customer_information")]
        public InvoiceParserResponseDataleonTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public InvoiceParserResponseDataleonTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("amount_due")]
        public double AmountDue { get; set; }

        [JsonProperty("previous_unpaid_balance")]
        public double PreviousUnpaidBalance { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("taxes")]
        public InvoiceParserResponseDataleonTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_term")]
        public string PaymentTerm { get; set; }

        [JsonProperty("purchase_order")]
        public string PurchaseOrder { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        [JsonProperty("service_due_date")]
        public string ServiceDueDate { get; set; }

        [JsonProperty("locale")]
        public InvoiceParserResponseDataleonTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("bank_informations")]
        public InvoiceParserResponseDataleonTypeExtractedDataTypeItemBankInformationsType BankInformations { get; set; }

        [JsonProperty("item_lines")]
        public InvoiceParserResponseDataleonTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class InvoiceParserResponseDataleonTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_tax_id")]
        public string CustomerTaxId { get; set; }

        [JsonProperty("customer_mailing_address")]
        public string CustomerMailingAddress { get; set; }

        [JsonProperty("customer_billing_address")]
        public string CustomerBillingAddress { get; set; }

        [JsonProperty("customer_shipping_address")]
        public string CustomerShippingAddress { get; set; }

        [JsonProperty("customer_service_address")]
        public string CustomerServiceAddress { get; set; }

        [JsonProperty("customer_remittance_address")]
        public string CustomerRemittanceAddress { get; set; }
    }

    public class InvoiceParserResponseDataleonTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_email")]
        public string MerchantEmail { get; set; }

        [JsonProperty("merchant_fax")]
        public string MerchantFax { get; set; }

        [JsonProperty("merchant_website")]
        public string MerchantWebsite { get; set; }

        [JsonProperty("merchant_tax_id")]
        public string MerchantTaxId { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class InvoiceParserResponseDataleonTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class InvoiceParserResponseDataleonTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class InvoiceParserResponseDataleonTypeExtractedDataTypeItemBankInformationsType
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("bsb")]
        public string Bsb { get; set; }

        [JsonProperty("sort_code")]
        public string SortCode { get; set; }

        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("rooting_number")]
        public string RootingNumber { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }
    }

    public class InvoiceParserResponseDataleonTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("date_item")]
        public string DateItem { get; set; }

        [JsonProperty("tax_item")]
        public double TaxItem { get; set; }

        [JsonProperty("tax_rate")]
        public double TaxRate { get; set; }
    }

    public class InvoiceParserResponseMindeeType
    {
        [JsonProperty("extracted_data")]
        public InvoiceParserResponseMindeeTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class InvoiceParserResponseMindeeTypeExtractedDataTypeItem
    {
        [JsonProperty("customer_information")]
        public InvoiceParserResponseMindeeTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public InvoiceParserResponseMindeeTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("amount_due")]
        public double AmountDue { get; set; }

        [JsonProperty("previous_unpaid_balance")]
        public double PreviousUnpaidBalance { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("taxes")]
        public InvoiceParserResponseMindeeTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_term")]
        public string PaymentTerm { get; set; }

        [JsonProperty("purchase_order")]
        public string PurchaseOrder { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        [JsonProperty("service_due_date")]
        public string ServiceDueDate { get; set; }

        [JsonProperty("locale")]
        public InvoiceParserResponseMindeeTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("bank_informations")]
        public InvoiceParserResponseMindeeTypeExtractedDataTypeItemBankInformationsType BankInformations { get; set; }

        [JsonProperty("item_lines")]
        public InvoiceParserResponseMindeeTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class InvoiceParserResponseMindeeTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_tax_id")]
        public string CustomerTaxId { get; set; }

        [JsonProperty("customer_mailing_address")]
        public string CustomerMailingAddress { get; set; }

        [JsonProperty("customer_billing_address")]
        public string CustomerBillingAddress { get; set; }

        [JsonProperty("customer_shipping_address")]
        public string CustomerShippingAddress { get; set; }

        [JsonProperty("customer_service_address")]
        public string CustomerServiceAddress { get; set; }

        [JsonProperty("customer_remittance_address")]
        public string CustomerRemittanceAddress { get; set; }
    }

    public class InvoiceParserResponseMindeeTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_email")]
        public string MerchantEmail { get; set; }

        [JsonProperty("merchant_fax")]
        public string MerchantFax { get; set; }

        [JsonProperty("merchant_website")]
        public string MerchantWebsite { get; set; }

        [JsonProperty("merchant_tax_id")]
        public string MerchantTaxId { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class InvoiceParserResponseMindeeTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class InvoiceParserResponseMindeeTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class InvoiceParserResponseMindeeTypeExtractedDataTypeItemBankInformationsType
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("bsb")]
        public string Bsb { get; set; }

        [JsonProperty("sort_code")]
        public string SortCode { get; set; }

        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("rooting_number")]
        public string RootingNumber { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }
    }

    public class InvoiceParserResponseMindeeTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("date_item")]
        public string DateItem { get; set; }

        [JsonProperty("tax_item")]
        public double TaxItem { get; set; }

        [JsonProperty("tax_rate")]
        public double TaxRate { get; set; }
    }

    public class InvoiceParserResponseGoogleType
    {
        [JsonProperty("extracted_data")]
        public InvoiceParserResponseGoogleTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class InvoiceParserResponseGoogleTypeExtractedDataTypeItem
    {
        [JsonProperty("customer_information")]
        public InvoiceParserResponseGoogleTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public InvoiceParserResponseGoogleTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("amount_due")]
        public double AmountDue { get; set; }

        [JsonProperty("previous_unpaid_balance")]
        public double PreviousUnpaidBalance { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("taxes")]
        public InvoiceParserResponseGoogleTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_term")]
        public string PaymentTerm { get; set; }

        [JsonProperty("purchase_order")]
        public string PurchaseOrder { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        [JsonProperty("service_due_date")]
        public string ServiceDueDate { get; set; }

        [JsonProperty("locale")]
        public InvoiceParserResponseGoogleTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("bank_informations")]
        public InvoiceParserResponseGoogleTypeExtractedDataTypeItemBankInformationsType BankInformations { get; set; }

        [JsonProperty("item_lines")]
        public InvoiceParserResponseGoogleTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class InvoiceParserResponseGoogleTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_tax_id")]
        public string CustomerTaxId { get; set; }

        [JsonProperty("customer_mailing_address")]
        public string CustomerMailingAddress { get; set; }

        [JsonProperty("customer_billing_address")]
        public string CustomerBillingAddress { get; set; }

        [JsonProperty("customer_shipping_address")]
        public string CustomerShippingAddress { get; set; }

        [JsonProperty("customer_service_address")]
        public string CustomerServiceAddress { get; set; }

        [JsonProperty("customer_remittance_address")]
        public string CustomerRemittanceAddress { get; set; }
    }

    public class InvoiceParserResponseGoogleTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_email")]
        public string MerchantEmail { get; set; }

        [JsonProperty("merchant_fax")]
        public string MerchantFax { get; set; }

        [JsonProperty("merchant_website")]
        public string MerchantWebsite { get; set; }

        [JsonProperty("merchant_tax_id")]
        public string MerchantTaxId { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class InvoiceParserResponseGoogleTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class InvoiceParserResponseGoogleTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class InvoiceParserResponseGoogleTypeExtractedDataTypeItemBankInformationsType
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("bsb")]
        public string Bsb { get; set; }

        [JsonProperty("sort_code")]
        public string SortCode { get; set; }

        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("rooting_number")]
        public string RootingNumber { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }
    }

    public class InvoiceParserResponseGoogleTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("date_item")]
        public string DateItem { get; set; }

        [JsonProperty("tax_item")]
        public double TaxItem { get; set; }

        [JsonProperty("tax_rate")]
        public double TaxRate { get; set; }
    }

    public class InvoiceParserResponseAffindaType
    {
        [JsonProperty("extracted_data")]
        public InvoiceParserResponseAffindaTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class InvoiceParserResponseAffindaTypeExtractedDataTypeItem
    {
        [JsonProperty("customer_information")]
        public InvoiceParserResponseAffindaTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public InvoiceParserResponseAffindaTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("amount_due")]
        public double AmountDue { get; set; }

        [JsonProperty("previous_unpaid_balance")]
        public double PreviousUnpaidBalance { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("taxes")]
        public InvoiceParserResponseAffindaTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_term")]
        public string PaymentTerm { get; set; }

        [JsonProperty("purchase_order")]
        public string PurchaseOrder { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        [JsonProperty("service_due_date")]
        public string ServiceDueDate { get; set; }

        [JsonProperty("locale")]
        public InvoiceParserResponseAffindaTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("bank_informations")]
        public InvoiceParserResponseAffindaTypeExtractedDataTypeItemBankInformationsType BankInformations { get; set; }

        [JsonProperty("item_lines")]
        public InvoiceParserResponseAffindaTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class InvoiceParserResponseAffindaTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_tax_id")]
        public string CustomerTaxId { get; set; }

        [JsonProperty("customer_mailing_address")]
        public string CustomerMailingAddress { get; set; }

        [JsonProperty("customer_billing_address")]
        public string CustomerBillingAddress { get; set; }

        [JsonProperty("customer_shipping_address")]
        public string CustomerShippingAddress { get; set; }

        [JsonProperty("customer_service_address")]
        public string CustomerServiceAddress { get; set; }

        [JsonProperty("customer_remittance_address")]
        public string CustomerRemittanceAddress { get; set; }
    }

    public class InvoiceParserResponseAffindaTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_email")]
        public string MerchantEmail { get; set; }

        [JsonProperty("merchant_fax")]
        public string MerchantFax { get; set; }

        [JsonProperty("merchant_website")]
        public string MerchantWebsite { get; set; }

        [JsonProperty("merchant_tax_id")]
        public string MerchantTaxId { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class InvoiceParserResponseAffindaTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class InvoiceParserResponseAffindaTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class InvoiceParserResponseAffindaTypeExtractedDataTypeItemBankInformationsType
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("bsb")]
        public string Bsb { get; set; }

        [JsonProperty("sort_code")]
        public string SortCode { get; set; }

        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("rooting_number")]
        public string RootingNumber { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }
    }

    public class InvoiceParserResponseAffindaTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("date_item")]
        public string DateItem { get; set; }

        [JsonProperty("tax_item")]
        public double TaxItem { get; set; }

        [JsonProperty("tax_rate")]
        public double TaxRate { get; set; }
    }

    public class InvoiceParserResponseMicrosoftType
    {
        [JsonProperty("extracted_data")]
        public InvoiceParserResponseMicrosoftTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class InvoiceParserResponseMicrosoftTypeExtractedDataTypeItem
    {
        [JsonProperty("customer_information")]
        public InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("amount_due")]
        public double AmountDue { get; set; }

        [JsonProperty("previous_unpaid_balance")]
        public double PreviousUnpaidBalance { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("taxes")]
        public InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_term")]
        public string PaymentTerm { get; set; }

        [JsonProperty("purchase_order")]
        public string PurchaseOrder { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        [JsonProperty("service_due_date")]
        public string ServiceDueDate { get; set; }

        [JsonProperty("locale")]
        public InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("bank_informations")]
        public InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemBankInformationsType BankInformations { get; set; }

        [JsonProperty("item_lines")]
        public InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_tax_id")]
        public string CustomerTaxId { get; set; }

        [JsonProperty("customer_mailing_address")]
        public string CustomerMailingAddress { get; set; }

        [JsonProperty("customer_billing_address")]
        public string CustomerBillingAddress { get; set; }

        [JsonProperty("customer_shipping_address")]
        public string CustomerShippingAddress { get; set; }

        [JsonProperty("customer_service_address")]
        public string CustomerServiceAddress { get; set; }

        [JsonProperty("customer_remittance_address")]
        public string CustomerRemittanceAddress { get; set; }
    }

    public class InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_email")]
        public string MerchantEmail { get; set; }

        [JsonProperty("merchant_fax")]
        public string MerchantFax { get; set; }

        [JsonProperty("merchant_website")]
        public string MerchantWebsite { get; set; }

        [JsonProperty("merchant_tax_id")]
        public string MerchantTaxId { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemBankInformationsType
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("bsb")]
        public string Bsb { get; set; }

        [JsonProperty("sort_code")]
        public string SortCode { get; set; }

        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("rooting_number")]
        public string RootingNumber { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }
    }

    public class InvoiceParserResponseMicrosoftTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("date_item")]
        public string DateItem { get; set; }

        [JsonProperty("tax_item")]
        public double TaxItem { get; set; }

        [JsonProperty("tax_rate")]
        public double TaxRate { get; set; }
    }

    public class InvoiceParserResponseVeryfiType
    {
        [JsonProperty("extracted_data")]
        public InvoiceParserResponseVeryfiTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class InvoiceParserResponseVeryfiTypeExtractedDataTypeItem
    {
        [JsonProperty("customer_information")]
        public InvoiceParserResponseVeryfiTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public InvoiceParserResponseVeryfiTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("amount_due")]
        public double AmountDue { get; set; }

        [JsonProperty("previous_unpaid_balance")]
        public double PreviousUnpaidBalance { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("taxes")]
        public InvoiceParserResponseVeryfiTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_term")]
        public string PaymentTerm { get; set; }

        [JsonProperty("purchase_order")]
        public string PurchaseOrder { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        [JsonProperty("service_due_date")]
        public string ServiceDueDate { get; set; }

        [JsonProperty("locale")]
        public InvoiceParserResponseVeryfiTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("bank_informations")]
        public InvoiceParserResponseVeryfiTypeExtractedDataTypeItemBankInformationsType BankInformations { get; set; }

        [JsonProperty("item_lines")]
        public InvoiceParserResponseVeryfiTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class InvoiceParserResponseVeryfiTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_tax_id")]
        public string CustomerTaxId { get; set; }

        [JsonProperty("customer_mailing_address")]
        public string CustomerMailingAddress { get; set; }

        [JsonProperty("customer_billing_address")]
        public string CustomerBillingAddress { get; set; }

        [JsonProperty("customer_shipping_address")]
        public string CustomerShippingAddress { get; set; }

        [JsonProperty("customer_service_address")]
        public string CustomerServiceAddress { get; set; }

        [JsonProperty("customer_remittance_address")]
        public string CustomerRemittanceAddress { get; set; }
    }

    public class InvoiceParserResponseVeryfiTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_email")]
        public string MerchantEmail { get; set; }

        [JsonProperty("merchant_fax")]
        public string MerchantFax { get; set; }

        [JsonProperty("merchant_website")]
        public string MerchantWebsite { get; set; }

        [JsonProperty("merchant_tax_id")]
        public string MerchantTaxId { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class InvoiceParserResponseVeryfiTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class InvoiceParserResponseVeryfiTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class InvoiceParserResponseVeryfiTypeExtractedDataTypeItemBankInformationsType
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("bsb")]
        public string Bsb { get; set; }

        [JsonProperty("sort_code")]
        public string SortCode { get; set; }

        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("rooting_number")]
        public string RootingNumber { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }
    }

    public class InvoiceParserResponseVeryfiTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("date_item")]
        public string DateItem { get; set; }

        [JsonProperty("tax_item")]
        public double TaxItem { get; set; }

        [JsonProperty("tax_rate")]
        public double TaxRate { get; set; }
    }

    public class ResumeParserResponse
    {
        [JsonProperty("hireability")]
        public ResumeParserResponseHireabilityType Hireability { get; set; }

        [JsonProperty("affinda")]
        public ResumeParserResponseAffindaType Affinda { get; set; }
    }

    public class ResumeParserResponseHireabilityType
    {
        [JsonProperty("extracted_data")]
        public ResumeParserResponseHireabilityTypeExtractedDataType ExtractedData { get; set; }
    }

    public class ResumeParserResponseHireabilityTypeExtractedDataType
    {
        [JsonProperty("personal_infos")]
        public ResumeParserResponseHireabilityTypeExtractedDataTypePersonalInfosType PersonalInfos { get; set; }

        [JsonProperty("education")]
        public ResumeParserResponseHireabilityTypeExtractedDataTypeEducationType Education { get; set; }

        [JsonProperty("work_experience")]
        public ResumeParserResponseHireabilityTypeExtractedDataTypeWorkExperienceType WorkExperience { get; set; }

        [JsonProperty("languages")]
        public JToken[] Languages { get; set; }

        [JsonProperty("skills")]
        public ResumeParserResponseHireabilityTypeExtractedDataTypeSkillsTypeItem[] Skills { get; set; }

        [JsonProperty("certifications")]
        public JToken[] Certifications { get; set; }

        [JsonProperty("courses")]
        public JToken[] Courses { get; set; }

        [JsonProperty("publications")]
        public JToken[] Publications { get; set; }

        [JsonProperty("interests")]
        public JToken[] Interests { get; set; }
    }

    public class ResumeParserResponseHireabilityTypeExtractedDataTypePersonalInfosType
    {
        [JsonProperty("name")]
        public ResumeParserResponseHireabilityTypeExtractedDataTypePersonalInfosTypeNameType Name { get; set; }

        [JsonProperty("address")]
        public ResumeParserResponseHireabilityTypeExtractedDataTypePersonalInfosTypeAddressType Address { get; set; }

        [JsonProperty("self_summary")]
        public string SelfSummary { get; set; }

        [JsonProperty("objective")]
        public string Objective { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("place_of_birth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("phones")]
        public JToken[] Phones { get; set; }

        [JsonProperty("mails")]
        public string[] Mails { get; set; }

        [JsonProperty("urls")]
        public JToken[] Urls { get; set; }

        [JsonProperty("fax")]
        public JToken[] Fax { get; set; }

        [JsonProperty("current_profession")]
        public string CurrentProfession { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("martial_status")]
        public string MartialStatus { get; set; }

        [JsonProperty("current_salary")]
        public string CurrentSalary { get; set; }
    }

    public class ResumeParserResponseHireabilityTypeExtractedDataTypePersonalInfosTypeNameType
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("raw_name")]
        public string RawName { get; set; }

        [JsonProperty("middle")]
        public string Middle { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("sufix")]
        public string Sufix { get; set; }
    }

    public class ResumeParserResponseHireabilityTypeExtractedDataTypePersonalInfosTypeAddressType
    {
        [JsonProperty("formatted_location")]
        public string FormattedLocation { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("raw_input_location")]
        public string RawInputLocation { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("street_number")]
        public string StreetNumber { get; set; }

        [JsonProperty("appartment_number")]
        public string AppartmentNumber { get; set; }
    }

    public class ResumeParserResponseHireabilityTypeExtractedDataTypeEducationType
    {
        [JsonProperty("total_years_education")]
        public string TotalYearsEducation { get; set; }

        [JsonProperty("entries")]
        public JToken[] Entries { get; set; }
    }

    public class ResumeParserResponseHireabilityTypeExtractedDataTypeWorkExperienceType
    {
        [JsonProperty("total_years_experience")]
        public string TotalYearsExperience { get; set; }

        [JsonProperty("entries")]
        public ResumeParserResponseHireabilityTypeExtractedDataTypeWorkExperienceTypeEntriesTypeItem[] Entries { get; set; }
    }

    public class ResumeParserResponseHireabilityTypeExtractedDataTypeWorkExperienceTypeEntriesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("location")]
        public ResumeParserResponseHireabilityTypeExtractedDataTypeWorkExperienceTypeEntriesTypeItemLocationType Location { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }
    }

    public class ResumeParserResponseHireabilityTypeExtractedDataTypeWorkExperienceTypeEntriesTypeItemLocationType
    {
        [JsonProperty("formatted_location")]
        public string FormattedLocation { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("raw_input_location")]
        public string RawInputLocation { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("street_number")]
        public string StreetNumber { get; set; }

        [JsonProperty("appartment_number")]
        public string AppartmentNumber { get; set; }
    }

    public class ResumeParserResponseHireabilityTypeExtractedDataTypeSkillsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ResumeParserResponseAffindaType
    {
        [JsonProperty("extracted_data")]
        public ResumeParserResponseAffindaTypeExtractedDataType ExtractedData { get; set; }
    }

    public class ResumeParserResponseAffindaTypeExtractedDataType
    {
        [JsonProperty("personal_infos")]
        public ResumeParserResponseAffindaTypeExtractedDataTypePersonalInfosType PersonalInfos { get; set; }

        [JsonProperty("education")]
        public ResumeParserResponseAffindaTypeExtractedDataTypeEducationType Education { get; set; }

        [JsonProperty("work_experience")]
        public ResumeParserResponseAffindaTypeExtractedDataTypeWorkExperienceType WorkExperience { get; set; }

        [JsonProperty("languages")]
        public JToken[] Languages { get; set; }

        [JsonProperty("skills")]
        public ResumeParserResponseAffindaTypeExtractedDataTypeSkillsTypeItem[] Skills { get; set; }

        [JsonProperty("certifications")]
        public JToken[] Certifications { get; set; }

        [JsonProperty("courses")]
        public JToken[] Courses { get; set; }

        [JsonProperty("publications")]
        public JToken[] Publications { get; set; }

        [JsonProperty("interests")]
        public JToken[] Interests { get; set; }
    }

    public class ResumeParserResponseAffindaTypeExtractedDataTypePersonalInfosType
    {
        [JsonProperty("name")]
        public ResumeParserResponseAffindaTypeExtractedDataTypePersonalInfosTypeNameType Name { get; set; }

        [JsonProperty("address")]
        public ResumeParserResponseAffindaTypeExtractedDataTypePersonalInfosTypeAddressType Address { get; set; }

        [JsonProperty("self_summary")]
        public string SelfSummary { get; set; }

        [JsonProperty("objective")]
        public string Objective { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("place_of_birth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("phones")]
        public JToken[] Phones { get; set; }

        [JsonProperty("mails")]
        public string[] Mails { get; set; }

        [JsonProperty("urls")]
        public JToken[] Urls { get; set; }

        [JsonProperty("fax")]
        public JToken[] Fax { get; set; }

        [JsonProperty("current_profession")]
        public string CurrentProfession { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("martial_status")]
        public string MartialStatus { get; set; }

        [JsonProperty("current_salary")]
        public string CurrentSalary { get; set; }
    }

    public class ResumeParserResponseAffindaTypeExtractedDataTypePersonalInfosTypeNameType
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("raw_name")]
        public string RawName { get; set; }

        [JsonProperty("middle")]
        public string Middle { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("sufix")]
        public string Sufix { get; set; }
    }

    public class ResumeParserResponseAffindaTypeExtractedDataTypePersonalInfosTypeAddressType
    {
        [JsonProperty("formatted_location")]
        public string FormattedLocation { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("raw_input_location")]
        public string RawInputLocation { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("street_number")]
        public string StreetNumber { get; set; }

        [JsonProperty("appartment_number")]
        public string AppartmentNumber { get; set; }
    }

    public class ResumeParserResponseAffindaTypeExtractedDataTypeEducationType
    {
        [JsonProperty("total_years_education")]
        public string TotalYearsEducation { get; set; }

        [JsonProperty("entries")]
        public JToken[] Entries { get; set; }
    }

    public class ResumeParserResponseAffindaTypeExtractedDataTypeWorkExperienceType
    {
        [JsonProperty("total_years_experience")]
        public string TotalYearsExperience { get; set; }

        [JsonProperty("entries")]
        public ResumeParserResponseAffindaTypeExtractedDataTypeWorkExperienceTypeEntriesTypeItem[] Entries { get; set; }
    }

    public class ResumeParserResponseAffindaTypeExtractedDataTypeWorkExperienceTypeEntriesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("location")]
        public ResumeParserResponseAffindaTypeExtractedDataTypeWorkExperienceTypeEntriesTypeItemLocationType Location { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }
    }

    public class ResumeParserResponseAffindaTypeExtractedDataTypeWorkExperienceTypeEntriesTypeItemLocationType
    {
        [JsonProperty("formatted_location")]
        public string FormattedLocation { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("raw_input_location")]
        public string RawInputLocation { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("street_number")]
        public string StreetNumber { get; set; }

        [JsonProperty("appartment_number")]
        public string AppartmentNumber { get; set; }
    }

    public class ResumeParserResponseAffindaTypeExtractedDataTypeSkillsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class IdentityParserResponse
    {
        [JsonProperty("amazon")]
        public IdentityParserResponseAmazonType Amazon { get; set; }

        [JsonProperty("base64")]
        public IdentityParserResponseBase64Type Base64 { get; set; }

        [JsonProperty("mindee")]
        public IdentityParserResponseMindeeType Mindee { get; set; }

        [JsonProperty("microsoft")]
        public IdentityParserResponseMicrosoftType Microsoft { get; set; }
    }

    public class IdentityParserResponseAmazonType
    {
        [JsonProperty("extracted_data")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItem
    {
        [JsonProperty("last_name")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemLastNameType LastName { get; set; }

        [JsonProperty("given_names")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemGivenNamesTypeItem[] GivenNames { get; set; }

        [JsonProperty("birth_place")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemBirthPlaceType BirthPlace { get; set; }

        [JsonProperty("birth_date")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemBirthDateType BirthDate { get; set; }

        [JsonProperty("issuance_date")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemIssuanceDateType IssuanceDate { get; set; }

        [JsonProperty("expire_date")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemExpireDateType ExpireDate { get; set; }

        [JsonProperty("document_id")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemDocumentIdType DocumentId { get; set; }

        [JsonProperty("issuing_state")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemIssuingStateType IssuingState { get; set; }

        [JsonProperty("address")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemAddressType Address { get; set; }

        [JsonProperty("age")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemAgeType Age { get; set; }

        [JsonProperty("country")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemCountryType Country { get; set; }

        [JsonProperty("document_type")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemDocumentTypeType DocumentType { get; set; }

        [JsonProperty("gender")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemGenderType Gender { get; set; }

        [JsonProperty("image_signature")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemImageSignatureTypeItem[] ImageSignature { get; set; }

        [JsonProperty("mrz")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemMrzType Mrz { get; set; }

        [JsonProperty("nationality")]
        public IdentityParserResponseAmazonTypeExtractedDataTypeItemNationalityType Nationality { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemLastNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemGivenNamesTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemBirthPlaceType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemBirthDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemIssuanceDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemExpireDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemDocumentIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemIssuingStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemAddressType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemAgeType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alpha2")]
        public string Alpha2 { get; set; }

        [JsonProperty("alpha3")]
        public string Alpha3 { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemDocumentTypeType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemGenderType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemImageSignatureTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemMrzType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseAmazonTypeExtractedDataTypeItemNationalityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64Type
    {
        [JsonProperty("extracted_data")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItem
    {
        [JsonProperty("last_name")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemLastNameType LastName { get; set; }

        [JsonProperty("given_names")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemGivenNamesTypeItem[] GivenNames { get; set; }

        [JsonProperty("birth_place")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemBirthPlaceType BirthPlace { get; set; }

        [JsonProperty("birth_date")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemBirthDateType BirthDate { get; set; }

        [JsonProperty("issuance_date")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemIssuanceDateType IssuanceDate { get; set; }

        [JsonProperty("expire_date")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemExpireDateType ExpireDate { get; set; }

        [JsonProperty("document_id")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemDocumentIdType DocumentId { get; set; }

        [JsonProperty("issuing_state")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemIssuingStateType IssuingState { get; set; }

        [JsonProperty("address")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemAddressType Address { get; set; }

        [JsonProperty("age")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemAgeType Age { get; set; }

        [JsonProperty("country")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemCountryType Country { get; set; }

        [JsonProperty("document_type")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemDocumentTypeType DocumentType { get; set; }

        [JsonProperty("gender")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemGenderType Gender { get; set; }

        [JsonProperty("image_signature")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemImageSignatureTypeItem[] ImageSignature { get; set; }

        [JsonProperty("mrz")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemMrzType Mrz { get; set; }

        [JsonProperty("nationality")]
        public IdentityParserResponseBase64TypeExtractedDataTypeItemNationalityType Nationality { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemLastNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemGivenNamesTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemBirthPlaceType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemBirthDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemIssuanceDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemExpireDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemDocumentIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemIssuingStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemAddressType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemAgeType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alpha2")]
        public string Alpha2 { get; set; }

        [JsonProperty("alpha3")]
        public string Alpha3 { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemDocumentTypeType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemGenderType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemImageSignatureTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemMrzType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseBase64TypeExtractedDataTypeItemNationalityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeType
    {
        [JsonProperty("extracted_data")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItem
    {
        [JsonProperty("last_name")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemLastNameType LastName { get; set; }

        [JsonProperty("given_names")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemGivenNamesTypeItem[] GivenNames { get; set; }

        [JsonProperty("birth_place")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemBirthPlaceType BirthPlace { get; set; }

        [JsonProperty("birth_date")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemBirthDateType BirthDate { get; set; }

        [JsonProperty("issuance_date")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemIssuanceDateType IssuanceDate { get; set; }

        [JsonProperty("expire_date")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemExpireDateType ExpireDate { get; set; }

        [JsonProperty("document_id")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemDocumentIdType DocumentId { get; set; }

        [JsonProperty("issuing_state")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemIssuingStateType IssuingState { get; set; }

        [JsonProperty("address")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemAddressType Address { get; set; }

        [JsonProperty("age")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemAgeType Age { get; set; }

        [JsonProperty("country")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemCountryType Country { get; set; }

        [JsonProperty("document_type")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemDocumentTypeType DocumentType { get; set; }

        [JsonProperty("gender")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemGenderType Gender { get; set; }

        [JsonProperty("image_signature")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemImageSignatureTypeItem[] ImageSignature { get; set; }

        [JsonProperty("mrz")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemMrzType Mrz { get; set; }

        [JsonProperty("nationality")]
        public IdentityParserResponseMindeeTypeExtractedDataTypeItemNationalityType Nationality { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemLastNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemGivenNamesTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemBirthPlaceType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemBirthDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemIssuanceDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemExpireDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemDocumentIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemIssuingStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemAddressType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemAgeType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alpha2")]
        public string Alpha2 { get; set; }

        [JsonProperty("alpha3")]
        public string Alpha3 { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemDocumentTypeType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemGenderType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemImageSignatureTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemMrzType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMindeeTypeExtractedDataTypeItemNationalityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftType
    {
        [JsonProperty("extracted_data")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItem
    {
        [JsonProperty("last_name")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemLastNameType LastName { get; set; }

        [JsonProperty("given_names")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemGivenNamesTypeItem[] GivenNames { get; set; }

        [JsonProperty("birth_place")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemBirthPlaceType BirthPlace { get; set; }

        [JsonProperty("birth_date")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemBirthDateType BirthDate { get; set; }

        [JsonProperty("issuance_date")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemIssuanceDateType IssuanceDate { get; set; }

        [JsonProperty("expire_date")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemExpireDateType ExpireDate { get; set; }

        [JsonProperty("document_id")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemDocumentIdType DocumentId { get; set; }

        [JsonProperty("issuing_state")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemIssuingStateType IssuingState { get; set; }

        [JsonProperty("address")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemAddressType Address { get; set; }

        [JsonProperty("age")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemAgeType Age { get; set; }

        [JsonProperty("country")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemCountryType Country { get; set; }

        [JsonProperty("document_type")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemDocumentTypeType DocumentType { get; set; }

        [JsonProperty("gender")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemGenderType Gender { get; set; }

        [JsonProperty("image_signature")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemImageSignatureTypeItem[] ImageSignature { get; set; }

        [JsonProperty("mrz")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemMrzType Mrz { get; set; }

        [JsonProperty("nationality")]
        public IdentityParserResponseMicrosoftTypeExtractedDataTypeItemNationalityType Nationality { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemLastNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemGivenNamesTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemBirthPlaceType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemBirthDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemIssuanceDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemExpireDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemDocumentIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemIssuingStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemAddressType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemAgeType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alpha2")]
        public string Alpha2 { get; set; }

        [JsonProperty("alpha3")]
        public string Alpha3 { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemDocumentTypeType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemGenderType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemImageSignatureTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemMrzType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class IdentityParserResponseMicrosoftTypeExtractedDataTypeItemNationalityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class ReceiptParserResponse
    {
        [JsonProperty("base64")]
        public ReceiptParserResponseBase64Type Base64 { get; set; }

        [JsonProperty("dataleon")]
        public ReceiptParserResponseDataleonType Dataleon { get; set; }

        [JsonProperty("microsoft")]
        public ReceiptParserResponseMicrosoftType Microsoft { get; set; }

        [JsonProperty("google")]
        public ReceiptParserResponseGoogleType Google { get; set; }

        [JsonProperty("tabscanner")]
        public ReceiptParserResponseTabscannerType Tabscanner { get; set; }

        [JsonProperty("mindee")]
        public ReceiptParserResponseMindeeType Mindee { get; set; }

        [JsonProperty("veryfi")]
        public ReceiptParserResponseVeryfiType Veryfi { get; set; }
    }

    public class ReceiptParserResponseBase64Type
    {
        [JsonProperty("extracted_data")]
        public ReceiptParserResponseBase64TypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class ReceiptParserResponseBase64TypeExtractedDataTypeItem
    {
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("barcodes")]
        public JToken[] Barcodes { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("customer_information")]
        public ReceiptParserResponseBase64TypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public ReceiptParserResponseBase64TypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("payment_information")]
        public ReceiptParserResponseBase64TypeExtractedDataTypeItemPaymentInformationType PaymentInformation { get; set; }

        [JsonProperty("locale")]
        public ReceiptParserResponseBase64TypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("taxes")]
        public ReceiptParserResponseBase64TypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("receipt_infos")]
        public ReceiptParserResponseBase64TypeExtractedDataTypeItemReceiptInfosType ReceiptInfos { get; set; }

        [JsonProperty("item_lines")]
        public ReceiptParserResponseBase64TypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class ReceiptParserResponseBase64TypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }
    }

    public class ReceiptParserResponseBase64TypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_url")]
        public string MerchantUrl { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class ReceiptParserResponseBase64TypeExtractedDataTypeItemPaymentInformationType
    {
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("card_number")]
        public string CardNumber { get; set; }

        [JsonProperty("cash")]
        public string Cash { get; set; }

        [JsonProperty("tip")]
        public string Tip { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("change")]
        public string Change { get; set; }
    }

    public class ReceiptParserResponseBase64TypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ReceiptParserResponseBase64TypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("taxes")]
        public double Taxes { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class ReceiptParserResponseBase64TypeExtractedDataTypeItemReceiptInfosType
    {
        [JsonProperty("payment_code")]
        public string PaymentCode { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }
    }

    public class ReceiptParserResponseBase64TypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
    }

    public class ReceiptParserResponseDataleonType
    {
        [JsonProperty("extracted_data")]
        public ReceiptParserResponseDataleonTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class ReceiptParserResponseDataleonTypeExtractedDataTypeItem
    {
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("barcodes")]
        public JToken[] Barcodes { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("customer_information")]
        public ReceiptParserResponseDataleonTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public ReceiptParserResponseDataleonTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("payment_information")]
        public ReceiptParserResponseDataleonTypeExtractedDataTypeItemPaymentInformationType PaymentInformation { get; set; }

        [JsonProperty("locale")]
        public ReceiptParserResponseDataleonTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("taxes")]
        public ReceiptParserResponseDataleonTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("receipt_infos")]
        public ReceiptParserResponseDataleonTypeExtractedDataTypeItemReceiptInfosType ReceiptInfos { get; set; }

        [JsonProperty("item_lines")]
        public ReceiptParserResponseDataleonTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class ReceiptParserResponseDataleonTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }
    }

    public class ReceiptParserResponseDataleonTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_url")]
        public string MerchantUrl { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class ReceiptParserResponseDataleonTypeExtractedDataTypeItemPaymentInformationType
    {
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("card_number")]
        public string CardNumber { get; set; }

        [JsonProperty("cash")]
        public string Cash { get; set; }

        [JsonProperty("tip")]
        public string Tip { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("change")]
        public string Change { get; set; }
    }

    public class ReceiptParserResponseDataleonTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ReceiptParserResponseDataleonTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("taxes")]
        public double Taxes { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class ReceiptParserResponseDataleonTypeExtractedDataTypeItemReceiptInfosType
    {
        [JsonProperty("payment_code")]
        public string PaymentCode { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }
    }

    public class ReceiptParserResponseDataleonTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
    }

    public class ReceiptParserResponseMicrosoftType
    {
        [JsonProperty("extracted_data")]
        public ReceiptParserResponseMicrosoftTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class ReceiptParserResponseMicrosoftTypeExtractedDataTypeItem
    {
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("barcodes")]
        public JToken[] Barcodes { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("customer_information")]
        public ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("payment_information")]
        public ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemPaymentInformationType PaymentInformation { get; set; }

        [JsonProperty("locale")]
        public ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("taxes")]
        public ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("receipt_infos")]
        public ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemReceiptInfosType ReceiptInfos { get; set; }

        [JsonProperty("item_lines")]
        public ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }
    }

    public class ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_url")]
        public string MerchantUrl { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemPaymentInformationType
    {
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("card_number")]
        public string CardNumber { get; set; }

        [JsonProperty("cash")]
        public string Cash { get; set; }

        [JsonProperty("tip")]
        public string Tip { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("change")]
        public string Change { get; set; }
    }

    public class ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("taxes")]
        public double Taxes { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemReceiptInfosType
    {
        [JsonProperty("payment_code")]
        public string PaymentCode { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }
    }

    public class ReceiptParserResponseMicrosoftTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
    }

    public class ReceiptParserResponseGoogleType
    {
        [JsonProperty("extracted_data")]
        public ReceiptParserResponseGoogleTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class ReceiptParserResponseGoogleTypeExtractedDataTypeItem
    {
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("barcodes")]
        public JToken[] Barcodes { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("customer_information")]
        public ReceiptParserResponseGoogleTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public ReceiptParserResponseGoogleTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("payment_information")]
        public ReceiptParserResponseGoogleTypeExtractedDataTypeItemPaymentInformationType PaymentInformation { get; set; }

        [JsonProperty("locale")]
        public ReceiptParserResponseGoogleTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("taxes")]
        public ReceiptParserResponseGoogleTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("receipt_infos")]
        public ReceiptParserResponseGoogleTypeExtractedDataTypeItemReceiptInfosType ReceiptInfos { get; set; }

        [JsonProperty("item_lines")]
        public ReceiptParserResponseGoogleTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class ReceiptParserResponseGoogleTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }
    }

    public class ReceiptParserResponseGoogleTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_url")]
        public string MerchantUrl { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class ReceiptParserResponseGoogleTypeExtractedDataTypeItemPaymentInformationType
    {
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("card_number")]
        public string CardNumber { get; set; }

        [JsonProperty("cash")]
        public string Cash { get; set; }

        [JsonProperty("tip")]
        public string Tip { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("change")]
        public string Change { get; set; }
    }

    public class ReceiptParserResponseGoogleTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ReceiptParserResponseGoogleTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("taxes")]
        public double Taxes { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class ReceiptParserResponseGoogleTypeExtractedDataTypeItemReceiptInfosType
    {
        [JsonProperty("payment_code")]
        public string PaymentCode { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }
    }

    public class ReceiptParserResponseGoogleTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
    }

    public class ReceiptParserResponseTabscannerType
    {
        [JsonProperty("extracted_data")]
        public ReceiptParserResponseTabscannerTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class ReceiptParserResponseTabscannerTypeExtractedDataTypeItem
    {
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("barcodes")]
        public JToken[] Barcodes { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("customer_information")]
        public ReceiptParserResponseTabscannerTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public ReceiptParserResponseTabscannerTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("payment_information")]
        public ReceiptParserResponseTabscannerTypeExtractedDataTypeItemPaymentInformationType PaymentInformation { get; set; }

        [JsonProperty("locale")]
        public ReceiptParserResponseTabscannerTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("taxes")]
        public ReceiptParserResponseTabscannerTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("receipt_infos")]
        public ReceiptParserResponseTabscannerTypeExtractedDataTypeItemReceiptInfosType ReceiptInfos { get; set; }

        [JsonProperty("item_lines")]
        public ReceiptParserResponseTabscannerTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class ReceiptParserResponseTabscannerTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }
    }

    public class ReceiptParserResponseTabscannerTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_url")]
        public string MerchantUrl { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class ReceiptParserResponseTabscannerTypeExtractedDataTypeItemPaymentInformationType
    {
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("card_number")]
        public string CardNumber { get; set; }

        [JsonProperty("cash")]
        public string Cash { get; set; }

        [JsonProperty("tip")]
        public string Tip { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("change")]
        public string Change { get; set; }
    }

    public class ReceiptParserResponseTabscannerTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ReceiptParserResponseTabscannerTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("taxes")]
        public double Taxes { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class ReceiptParserResponseTabscannerTypeExtractedDataTypeItemReceiptInfosType
    {
        [JsonProperty("payment_code")]
        public string PaymentCode { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }
    }

    public class ReceiptParserResponseTabscannerTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
    }

    public class ReceiptParserResponseMindeeType
    {
        [JsonProperty("extracted_data")]
        public ReceiptParserResponseMindeeTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class ReceiptParserResponseMindeeTypeExtractedDataTypeItem
    {
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("barcodes")]
        public JToken[] Barcodes { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("customer_information")]
        public ReceiptParserResponseMindeeTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public ReceiptParserResponseMindeeTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("payment_information")]
        public ReceiptParserResponseMindeeTypeExtractedDataTypeItemPaymentInformationType PaymentInformation { get; set; }

        [JsonProperty("locale")]
        public ReceiptParserResponseMindeeTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("taxes")]
        public ReceiptParserResponseMindeeTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("receipt_infos")]
        public ReceiptParserResponseMindeeTypeExtractedDataTypeItemReceiptInfosType ReceiptInfos { get; set; }

        [JsonProperty("item_lines")]
        public ReceiptParserResponseMindeeTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class ReceiptParserResponseMindeeTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }
    }

    public class ReceiptParserResponseMindeeTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_url")]
        public string MerchantUrl { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class ReceiptParserResponseMindeeTypeExtractedDataTypeItemPaymentInformationType
    {
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("card_number")]
        public string CardNumber { get; set; }

        [JsonProperty("cash")]
        public string Cash { get; set; }

        [JsonProperty("tip")]
        public string Tip { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("change")]
        public string Change { get; set; }
    }

    public class ReceiptParserResponseMindeeTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ReceiptParserResponseMindeeTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("taxes")]
        public double Taxes { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class ReceiptParserResponseMindeeTypeExtractedDataTypeItemReceiptInfosType
    {
        [JsonProperty("payment_code")]
        public string PaymentCode { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }
    }

    public class ReceiptParserResponseMindeeTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
    }

    public class ReceiptParserResponseVeryfiType
    {
        [JsonProperty("extracted_data")]
        public ReceiptParserResponseVeryfiTypeExtractedDataTypeItem[] ExtractedData { get; set; }
    }

    public class ReceiptParserResponseVeryfiTypeExtractedDataTypeItem
    {
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_total")]
        public double InvoiceTotal { get; set; }

        [JsonProperty("invoice_subtotal")]
        public double InvoiceSubtotal { get; set; }

        [JsonProperty("barcodes")]
        public JToken[] Barcodes { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("customer_information")]
        public ReceiptParserResponseVeryfiTypeExtractedDataTypeItemCustomerInformationType CustomerInformation { get; set; }

        [JsonProperty("merchant_information")]
        public ReceiptParserResponseVeryfiTypeExtractedDataTypeItemMerchantInformationType MerchantInformation { get; set; }

        [JsonProperty("payment_information")]
        public ReceiptParserResponseVeryfiTypeExtractedDataTypeItemPaymentInformationType PaymentInformation { get; set; }

        [JsonProperty("locale")]
        public ReceiptParserResponseVeryfiTypeExtractedDataTypeItemLocaleType Locale { get; set; }

        [JsonProperty("taxes")]
        public ReceiptParserResponseVeryfiTypeExtractedDataTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("receipt_infos")]
        public ReceiptParserResponseVeryfiTypeExtractedDataTypeItemReceiptInfosType ReceiptInfos { get; set; }

        [JsonProperty("item_lines")]
        public ReceiptParserResponseVeryfiTypeExtractedDataTypeItemItemLinesTypeItem[] ItemLines { get; set; }
    }

    public class ReceiptParserResponseVeryfiTypeExtractedDataTypeItemCustomerInformationType
    {
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }
    }

    public class ReceiptParserResponseVeryfiTypeExtractedDataTypeItemMerchantInformationType
    {
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("merchant_address")]
        public string MerchantAddress { get; set; }

        [JsonProperty("merchant_phone")]
        public string MerchantPhone { get; set; }

        [JsonProperty("merchant_url")]
        public string MerchantUrl { get; set; }

        [JsonProperty("merchant_siret")]
        public string MerchantSiret { get; set; }

        [JsonProperty("merchant_siren")]
        public string MerchantSiren { get; set; }
    }

    public class ReceiptParserResponseVeryfiTypeExtractedDataTypeItemPaymentInformationType
    {
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("card_number")]
        public string CardNumber { get; set; }

        [JsonProperty("cash")]
        public string Cash { get; set; }

        [JsonProperty("tip")]
        public string Tip { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("change")]
        public string Change { get; set; }
    }

    public class ReceiptParserResponseVeryfiTypeExtractedDataTypeItemLocaleType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ReceiptParserResponseVeryfiTypeExtractedDataTypeItemTaxesTypeItem
    {
        [JsonProperty("taxes")]
        public double Taxes { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class ReceiptParserResponseVeryfiTypeExtractedDataTypeItemReceiptInfosType
    {
        [JsonProperty("payment_code")]
        public string PaymentCode { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }
    }

    public class ReceiptParserResponseVeryfiTypeExtractedDataTypeItemItemLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
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