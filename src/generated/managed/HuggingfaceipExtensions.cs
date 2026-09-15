//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huggingfaceip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuggingfaceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<JToken> ModelID(Expression<Func<string>> modelId, Expression<Func<string>> bodyinputs, Expression<Func<string>> bodyquery = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
            var parametersObject = new JObject();
            var parametersObjectpropCount = 0;
            if (parametersObjectpropCount > 0)
            {
                body["parameters"] = parametersObject;
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            var tableObject = new JObject();
            var tableObjectpropCount = 0;
            if (tableObjectpropCount > 0)
            {
                body["table"] = tableObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsuseCache != null)
            {
                optionsObject["use_cache"] = CSharpExpressionConverter.ConvertToken(bodyoptionsuseCache);
                optionsObjectpropCount++;
            }

            if (bodyoptionswaitForModel != null)
            {
                optionsObject["wait_for_model"] = CSharpExpressionConverter.ConvertToken(bodyoptionswaitForModel);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<FillMaskPostResponseItem[]> FillMask(Expression<Func<string>> bodyinputs, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var apiCallPath = "/bert-base-uncased";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsuseCache != null)
            {
                optionsObject["use_cache"] = CSharpExpressionConverter.ConvertToken(bodyoptionsuseCache);
                optionsObjectpropCount++;
            }

            if (bodyoptionswaitForModel != null)
            {
                optionsObject["wait_for_model"] = CSharpExpressionConverter.ConvertToken(bodyoptionswaitForModel);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FillMaskPostResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<SummarizationPostResponseItem[]> Summarization(Expression<Func<string>> bodyinputs = null, Expression<Func<bool>> bodyparametersdoSample = null, Expression<Func<int>> bodyparametersminLength = null, Expression<Func<int>> bodyparametersmaxLength = null, Expression<Func<int>> bodyparameterstopK = null, Expression<Func<int>> bodyparameterstopP = null, Expression<Func<double>> bodyparameterstemperature = null, Expression<Func<double>> bodyparametersrepetitionPenalty = null, Expression<Func<double>> bodyparametersmaxTime = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var apiCallPath = "/facebook/bart-large-cnn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            var parametersObject = new JObject();
            var parametersObjectpropCount = 0;
            if (bodyparametersdoSample != null)
            {
                parametersObject["do_sample"] = CSharpExpressionConverter.ConvertToken(bodyparametersdoSample);
                parametersObjectpropCount++;
            }

            if (bodyparametersminLength != null)
            {
                parametersObject["min_length"] = CSharpExpressionConverter.ConvertToken(bodyparametersminLength);
                parametersObjectpropCount++;
            }

            if (bodyparametersmaxLength != null)
            {
                parametersObject["max_length"] = CSharpExpressionConverter.ConvertToken(bodyparametersmaxLength);
                parametersObjectpropCount++;
            }

            if (bodyparameterstopK != null)
            {
                parametersObject["top_k"] = CSharpExpressionConverter.ConvertToken(bodyparameterstopK);
                parametersObjectpropCount++;
            }

            if (bodyparameterstopP != null)
            {
                parametersObject["top_p"] = CSharpExpressionConverter.ConvertToken(bodyparameterstopP);
                parametersObjectpropCount++;
            }

            if (bodyparameterstemperature != null)
            {
                parametersObject["temperature"] = CSharpExpressionConverter.ConvertToken(bodyparameterstemperature);
                parametersObjectpropCount++;
            }

            if (bodyparametersrepetitionPenalty != null)
            {
                parametersObject["repetition_penalty"] = CSharpExpressionConverter.ConvertToken(bodyparametersrepetitionPenalty);
                parametersObjectpropCount++;
            }

            if (bodyparametersmaxTime != null)
            {
                parametersObject["max_time"] = CSharpExpressionConverter.ConvertToken(bodyparametersmaxTime);
                parametersObjectpropCount++;
            }

            if (parametersObjectpropCount > 0)
            {
                body["parameters"] = parametersObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsuseCache != null)
            {
                optionsObject["use_cache"] = CSharpExpressionConverter.ConvertToken(bodyoptionsuseCache);
                optionsObjectpropCount++;
            }

            if (bodyoptionswaitForModel != null)
            {
                optionsObject["wait_for_model"] = CSharpExpressionConverter.ConvertToken(bodyoptionswaitForModel);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SummarizationPostResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<AnswerPostResponse> Answer(Expression<Func<string>> bodyinputsquestion = null, Expression<Func<string>> bodyinputscontext = null)
        {
            var apiCallPath = "/deepset/roberta-base-squad2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var inputsObject = new JObject();
            var inputsObjectpropCount = 0;
            if (bodyinputsquestion != null)
            {
                inputsObject["question"] = CSharpExpressionConverter.ConvertToken(bodyinputsquestion);
                inputsObjectpropCount++;
            }

            if (bodyinputscontext != null)
            {
                inputsObject["context"] = CSharpExpressionConverter.ConvertToken(bodyinputscontext);
                inputsObjectpropCount++;
            }

            if (inputsObjectpropCount > 0)
            {
                body["inputs"] = inputsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AnswerPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<double[]> SentenceSimilarity(Expression<Func<string>> bodyinputssourceSentence = null, Expression<Func<string[]>> bodyinputssentences = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var apiCallPath = "/sentence-transformers/all-MiniLM-L6-v2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var inputsObject = new JObject();
            var inputsObjectpropCount = 0;
            if (bodyinputssourceSentence != null)
            {
                inputsObject["source_sentence"] = CSharpExpressionConverter.ConvertToken(bodyinputssourceSentence);
                inputsObjectpropCount++;
            }

            if (bodyinputssentences != null)
            {
                inputsObject["sentences"] = CSharpExpressionConverter.ConvertToken(bodyinputssentences);
                inputsObjectpropCount++;
            }

            if (inputsObjectpropCount > 0)
            {
                body["inputs"] = inputsObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsuseCache != null)
            {
                optionsObject["use_cache"] = CSharpExpressionConverter.ConvertToken(bodyoptionsuseCache);
                optionsObjectpropCount++;
            }

            if (bodyoptionswaitForModel != null)
            {
                optionsObject["wait_for_model"] = CSharpExpressionConverter.ConvertToken(bodyoptionswaitForModel);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<double[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TextClassificationPostResponseItemItem[][]> TextClassification(Expression<Func<string>> bodyinputs, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var apiCallPath = "/distilbert-base-uncased-finetuned-sst-2-english";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsuseCache != null)
            {
                optionsObject["use_cache"] = CSharpExpressionConverter.ConvertToken(bodyoptionsuseCache);
                optionsObjectpropCount++;
            }

            if (bodyoptionswaitForModel != null)
            {
                optionsObject["wait_for_model"] = CSharpExpressionConverter.ConvertToken(bodyoptionswaitForModel);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TextClassificationPostResponseItemItem[][]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TextGenerationPostResponseItem[]> TextGeneration(Expression<Func<string>> bodyinputs = null, Expression<Func<bool>> bodyparametersdoSample = null, Expression<Func<int>> bodyparametersminLength = null, Expression<Func<int>> bodyparametersmaxLength = null, Expression<Func<int>> bodyparameterstopK = null, Expression<Func<int>> bodyparameterstopP = null, Expression<Func<double>> bodyparameterstemperature = null, Expression<Func<double>> bodyparametersrepetitionPenalty = null, Expression<Func<double>> bodyparametersmaxTime = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var apiCallPath = "/gpt2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            var parametersObject = new JObject();
            var parametersObjectpropCount = 0;
            if (bodyparametersdoSample != null)
            {
                parametersObject["do_sample"] = CSharpExpressionConverter.ConvertToken(bodyparametersdoSample);
                parametersObjectpropCount++;
            }

            if (bodyparametersminLength != null)
            {
                parametersObject["min_length"] = CSharpExpressionConverter.ConvertToken(bodyparametersminLength);
                parametersObjectpropCount++;
            }

            if (bodyparametersmaxLength != null)
            {
                parametersObject["max_length"] = CSharpExpressionConverter.ConvertToken(bodyparametersmaxLength);
                parametersObjectpropCount++;
            }

            if (bodyparameterstopK != null)
            {
                parametersObject["top_k"] = CSharpExpressionConverter.ConvertToken(bodyparameterstopK);
                parametersObjectpropCount++;
            }

            if (bodyparameterstopP != null)
            {
                parametersObject["top_p"] = CSharpExpressionConverter.ConvertToken(bodyparameterstopP);
                parametersObjectpropCount++;
            }

            if (bodyparameterstemperature != null)
            {
                parametersObject["temperature"] = CSharpExpressionConverter.ConvertToken(bodyparameterstemperature);
                parametersObjectpropCount++;
            }

            if (bodyparametersrepetitionPenalty != null)
            {
                parametersObject["repetition_penalty"] = CSharpExpressionConverter.ConvertToken(bodyparametersrepetitionPenalty);
                parametersObjectpropCount++;
            }

            if (bodyparametersmaxTime != null)
            {
                parametersObject["max_time"] = CSharpExpressionConverter.ConvertToken(bodyparametersmaxTime);
                parametersObjectpropCount++;
            }

            if (parametersObjectpropCount > 0)
            {
                body["parameters"] = parametersObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsuseCache != null)
            {
                optionsObject["use_cache"] = CSharpExpressionConverter.ConvertToken(bodyoptionsuseCache);
                optionsObjectpropCount++;
            }

            if (bodyoptionswaitForModel != null)
            {
                optionsObject["wait_for_model"] = CSharpExpressionConverter.ConvertToken(bodyoptionswaitForModel);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TextGenerationPostResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TokenClassificationPostResponseItem[]> TokenClassification(Expression<Func<string>> bodyinputs, Expression<Func<string>> bodyparametersaggregationStrategy = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var apiCallPath = "/dbmdz/bert-large-cased-finetuned-conll03-english";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
            var parametersObject = new JObject();
            var parametersObjectpropCount = 0;
            if (bodyparametersaggregationStrategy != null)
            {
                parametersObject["aggregation_strategy"] = CSharpExpressionConverter.ConvertToken(bodyparametersaggregationStrategy);
                parametersObjectpropCount++;
            }

            if (parametersObjectpropCount > 0)
            {
                body["parameters"] = parametersObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsuseCache != null)
            {
                optionsObject["use_cache"] = CSharpExpressionConverter.ConvertToken(bodyoptionsuseCache);
                optionsObjectpropCount++;
            }

            if (bodyoptionswaitForModel != null)
            {
                optionsObject["wait_for_model"] = CSharpExpressionConverter.ConvertToken(bodyoptionswaitForModel);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TokenClassificationPostResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TranslationPostResponseItem[]> Translation(Expression<Func<string>> bodyinputs, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var apiCallPath = "/t5-base";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsuseCache != null)
            {
                optionsObject["use_cache"] = CSharpExpressionConverter.ConvertToken(bodyoptionsuseCache);
                optionsObjectpropCount++;
            }

            if (bodyoptionswaitForModel != null)
            {
                optionsObject["wait_for_model"] = CSharpExpressionConverter.ConvertToken(bodyoptionswaitForModel);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TranslationPostResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<ZeroShotPostResponse> ZeroShot(Expression<Func<string>> bodyinputs = null, Expression<Func<string[]>> bodyparameterscandidateLabels = null, Expression<Func<bool>> bodyparametersmultiLabel = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var apiCallPath = "/facebook/bart-large-mnli";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            var parametersObject = new JObject();
            var parametersObjectpropCount = 0;
            if (bodyparameterscandidateLabels != null)
            {
                parametersObject["candidate_labels"] = CSharpExpressionConverter.ConvertToken(bodyparameterscandidateLabels);
                parametersObjectpropCount++;
            }

            if (bodyparametersmultiLabel != null)
            {
                parametersObject["multi_label"] = CSharpExpressionConverter.ConvertToken(bodyparametersmultiLabel);
                parametersObjectpropCount++;
            }

            if (parametersObjectpropCount > 0)
            {
                body["parameters"] = parametersObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsuseCache != null)
            {
                optionsObject["use_cache"] = CSharpExpressionConverter.ConvertToken(bodyoptionsuseCache);
                optionsObjectpropCount++;
            }

            if (bodyoptionswaitForModel != null)
            {
                optionsObject["wait_for_model"] = CSharpExpressionConverter.ConvertToken(bodyoptionswaitForModel);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ZeroShotPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<ConversationalPostResponse> Conversational(Expression<Func<string[]>> bodyinputspastUserInputs = null, Expression<Func<string[]>> bodyinputsgeneratedResponses = null, Expression<Func<string>> bodyinputstext = null, Expression<Func<int>> bodyparametersminLength = null, Expression<Func<int>> bodyparametersmaxLength = null, Expression<Func<int>> bodyparameterstopK = null, Expression<Func<int>> bodyparameterstopP = null, Expression<Func<double>> bodyparameterstemperature = null, Expression<Func<double>> bodyparametersrepetitionPenalty = null, Expression<Func<double>> bodyparametersmaxTime = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var apiCallPath = "/microsoft/DialoGPT-large";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var inputsObject = new JObject();
            var inputsObjectpropCount = 0;
            if (bodyinputspastUserInputs != null)
            {
                inputsObject["past_user_inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputspastUserInputs);
                inputsObjectpropCount++;
            }

            if (bodyinputsgeneratedResponses != null)
            {
                inputsObject["generated_responses"] = CSharpExpressionConverter.ConvertToken(bodyinputsgeneratedResponses);
                inputsObjectpropCount++;
            }

            if (bodyinputstext != null)
            {
                inputsObject["text"] = CSharpExpressionConverter.ConvertToken(bodyinputstext);
                inputsObjectpropCount++;
            }

            if (inputsObjectpropCount > 0)
            {
                body["inputs"] = inputsObject;
                bodypropCount++;
            }

            var parametersObject = new JObject();
            var parametersObjectpropCount = 0;
            if (bodyparametersminLength != null)
            {
                parametersObject["min_length"] = CSharpExpressionConverter.ConvertToken(bodyparametersminLength);
                parametersObjectpropCount++;
            }

            if (bodyparametersmaxLength != null)
            {
                parametersObject["max_length"] = CSharpExpressionConverter.ConvertToken(bodyparametersmaxLength);
                parametersObjectpropCount++;
            }

            if (bodyparameterstopK != null)
            {
                parametersObject["top_k"] = CSharpExpressionConverter.ConvertToken(bodyparameterstopK);
                parametersObjectpropCount++;
            }

            if (bodyparameterstopP != null)
            {
                parametersObject["top_p"] = CSharpExpressionConverter.ConvertToken(bodyparameterstopP);
                parametersObjectpropCount++;
            }

            if (bodyparameterstemperature != null)
            {
                parametersObject["temperature"] = CSharpExpressionConverter.ConvertToken(bodyparameterstemperature);
                parametersObjectpropCount++;
            }

            if (bodyparametersrepetitionPenalty != null)
            {
                parametersObject["repetition_penalty"] = CSharpExpressionConverter.ConvertToken(bodyparametersrepetitionPenalty);
                parametersObjectpropCount++;
            }

            if (bodyparametersmaxTime != null)
            {
                parametersObject["max_time"] = CSharpExpressionConverter.ConvertToken(bodyparametersmaxTime);
                parametersObjectpropCount++;
            }

            if (parametersObjectpropCount > 0)
            {
                body["parameters"] = parametersObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsuseCache != null)
            {
                optionsObject["use_cache"] = CSharpExpressionConverter.ConvertToken(bodyoptionsuseCache);
                optionsObjectpropCount++;
            }

            if (bodyoptionswaitForModel != null)
            {
                optionsObject["wait_for_model"] = CSharpExpressionConverter.ConvertToken(bodyoptionswaitForModel);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConversationalPostResponse>(callPayload);
        }
    }

    public class HuggingfaceipTriggers([ConnectionName] string connectionId)
    {
    }

    public class FillMaskPostResponseItem
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("token")]
        public int Token { get; set; }

        [JsonProperty("token_str")]
        public string TokenStr { get; set; }

        [JsonProperty("sequence")]
        public string Sequence { get; set; }
    }

    public class SummarizationPostResponseItem
    {
        [JsonProperty("summary_text")]
        public string SummaryText { get; set; }
    }

    public class AnswerPostResponse
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }
    }

    public class TextClassificationPostResponseItemItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class TextGenerationPostResponseItem
    {
        [JsonProperty("generated_text")]
        public string GeneratedText { get; set; }
    }

    public class TokenClassificationPostResponseItem
    {
        [JsonProperty("entity_group")]
        public string EntityGroup { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }

    public class TranslationPostResponseItem
    {
        [JsonProperty("translation_text")]
        public string TranslationText { get; set; }
    }

    public class ZeroShotPostResponse
    {
        [JsonProperty("sequence")]
        public string Sequence { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("scores")]
        public double[] Scores { get; set; }
    }

    public class ConversationalPostResponse
    {
        [JsonProperty("generated_text")]
        public string GeneratedText { get; set; }

        [JsonProperty("conversation")]
        public ConversationalPostResponseConversationType Conversation { get; set; }
    }

    public class ConversationalPostResponseConversationType
    {
        [JsonProperty("past_user_inputs")]
        public string[] PastUserInputs { get; set; }

        [JsonProperty("generated_responses")]
        public string[] GeneratedResponses { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Huggingfaceip;

    public partial class WorkflowManagedActions
    {
        public HuggingfaceipActions Huggingfaceip(string connectionId) => new HuggingfaceipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HuggingfaceipTriggers Huggingfaceip(string connectionId) => new HuggingfaceipTriggers(connectionId);
    }
}