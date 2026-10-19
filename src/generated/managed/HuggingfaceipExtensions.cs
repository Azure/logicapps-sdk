//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huggingfaceip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuggingfaceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<JToken> ModelID(Expression<Func<string>> modelId, Expression<Func<string>> bodyinputs, Expression<Func<string>> bodyquery = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var __workflow_modelId = WorkflowExpression.Compile(modelId, nameof(modelId), required: true);
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: false);
            var __workflow_bodyoptionsuseCache = WorkflowExpression.Compile(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            var __workflow_bodyoptionswaitForModel = WorkflowExpression.Compile(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_modelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                if (__workflow_bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
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
                if (__workflow_bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(__workflow_bodyoptionswaitForModel);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<FillMaskPostResponseItem[]> FillMask(Expression<Func<string>> bodyinputs, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            var __workflow_bodyoptionsuseCache = WorkflowExpression.Compile(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            var __workflow_bodyoptionswaitForModel = WorkflowExpression.Compile(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<FillMaskPostResponseItem[]>(() =>
            {
                var apiCallPath = "/bert-base-uncased";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(__workflow_bodyoptionswaitForModel);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<SummarizationPostResponseItem[]> Summarization(Expression<Func<string>> bodyinputs = null, Expression<Func<bool>> bodyparametersdoSample = null, Expression<Func<int>> bodyparametersminLength = null, Expression<Func<int>> bodyparametersmaxLength = null, Expression<Func<int>> bodyparameterstopK = null, Expression<Func<int>> bodyparameterstopP = null, Expression<Func<double>> bodyparameterstemperature = null, Expression<Func<double>> bodyparametersrepetitionPenalty = null, Expression<Func<double>> bodyparametersmaxTime = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: false);
            var __workflow_bodyparametersdoSample = WorkflowExpression.Compile(bodyparametersdoSample, nameof(bodyparametersdoSample), required: false);
            var __workflow_bodyparametersminLength = WorkflowExpression.Compile(bodyparametersminLength, nameof(bodyparametersminLength), required: false);
            var __workflow_bodyparametersmaxLength = WorkflowExpression.Compile(bodyparametersmaxLength, nameof(bodyparametersmaxLength), required: false);
            var __workflow_bodyparameterstopK = WorkflowExpression.Compile(bodyparameterstopK, nameof(bodyparameterstopK), required: false);
            var __workflow_bodyparameterstopP = WorkflowExpression.Compile(bodyparameterstopP, nameof(bodyparameterstopP), required: false);
            var __workflow_bodyparameterstemperature = WorkflowExpression.Compile(bodyparameterstemperature, nameof(bodyparameterstemperature), required: false);
            var __workflow_bodyparametersrepetitionPenalty = WorkflowExpression.Compile(bodyparametersrepetitionPenalty, nameof(bodyparametersrepetitionPenalty), required: false);
            var __workflow_bodyparametersmaxTime = WorkflowExpression.Compile(bodyparametersmaxTime, nameof(bodyparametersmaxTime), required: false);
            var __workflow_bodyoptionsuseCache = WorkflowExpression.Compile(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            var __workflow_bodyoptionswaitForModel = WorkflowExpression.Compile(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<SummarizationPostResponseItem[]>(() =>
            {
                var apiCallPath = "/facebook/bart-large-cnn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (__workflow_bodyparametersdoSample != null)
                {
                    parametersObject["do_sample"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdoSample);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersminLength != null)
                {
                    parametersObject["min_length"] = ExpressionConverter.ConvertO(__workflow_bodyparametersminLength);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmaxLength != null)
                {
                    parametersObject["max_length"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmaxLength);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstopK != null)
                {
                    parametersObject["top_k"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstopK);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstopP != null)
                {
                    parametersObject["top_p"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstopP);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstemperature != null)
                {
                    parametersObject["temperature"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstemperature);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersrepetitionPenalty != null)
                {
                    parametersObject["repetition_penalty"] = ExpressionConverter.ConvertO(__workflow_bodyparametersrepetitionPenalty);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmaxTime != null)
                {
                    parametersObject["max_time"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmaxTime);
                    parametersObjectpropCount++;
                }

                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(__workflow_bodyoptionswaitForModel);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<AnswerPostResponse> Answer(Expression<Func<string>> bodyinputsquestion = null, Expression<Func<string>> bodyinputscontext = null)
        {
            var __workflow_bodyinputsquestion = WorkflowExpression.Compile(bodyinputsquestion, nameof(bodyinputsquestion), required: false);
            var __workflow_bodyinputscontext = WorkflowExpression.Compile(bodyinputscontext, nameof(bodyinputscontext), required: false);
            return new DeferredBodyAction<AnswerPostResponse>(() =>
            {
                var apiCallPath = "/deepset/roberta-base-squad2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputsObject = new JObject();
                var inputsObjectpropCount = 0;
                if (__workflow_bodyinputsquestion != null)
                {
                    inputsObject["question"] = ExpressionConverter.ConvertO(__workflow_bodyinputsquestion);
                    inputsObjectpropCount++;
                }

                if (__workflow_bodyinputscontext != null)
                {
                    inputsObject["context"] = ExpressionConverter.ConvertO(__workflow_bodyinputscontext);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<double[]> SentenceSimilarity(Expression<Func<string>> bodyinputssourceSentence = null, Expression<Func<string[]>> bodyinputssentences = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var __workflow_bodyinputssourceSentence = WorkflowExpression.Compile(bodyinputssourceSentence, nameof(bodyinputssourceSentence), required: false);
            var __workflow_bodyinputssentences = WorkflowExpression.Compile(bodyinputssentences, nameof(bodyinputssentences), required: false);
            var __workflow_bodyoptionsuseCache = WorkflowExpression.Compile(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            var __workflow_bodyoptionswaitForModel = WorkflowExpression.Compile(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<double[]>(() =>
            {
                var apiCallPath = "/sentence-transformers/all-MiniLM-L6-v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputsObject = new JObject();
                var inputsObjectpropCount = 0;
                if (__workflow_bodyinputssourceSentence != null)
                {
                    inputsObject["source_sentence"] = ExpressionConverter.ConvertO(__workflow_bodyinputssourceSentence);
                    inputsObjectpropCount++;
                }

                if (__workflow_bodyinputssentences != null)
                {
                    inputsObject["sentences"] = ExpressionConverter.ConvertO(__workflow_bodyinputssentences);
                    inputsObjectpropCount++;
                }

                if (inputsObjectpropCount > 0)
                {
                    body["inputs"] = inputsObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(__workflow_bodyoptionswaitForModel);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TextClassificationPostResponseItemItem[][]> TextClassification(Expression<Func<string>> bodyinputs, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            var __workflow_bodyoptionsuseCache = WorkflowExpression.Compile(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            var __workflow_bodyoptionswaitForModel = WorkflowExpression.Compile(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<TextClassificationPostResponseItemItem[][]>(() =>
            {
                var apiCallPath = "/distilbert-base-uncased-finetuned-sst-2-english";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(__workflow_bodyoptionswaitForModel);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TextGenerationPostResponseItem[]> TextGeneration(Expression<Func<string>> bodyinputs = null, Expression<Func<bool>> bodyparametersdoSample = null, Expression<Func<int>> bodyparametersminLength = null, Expression<Func<int>> bodyparametersmaxLength = null, Expression<Func<int>> bodyparameterstopK = null, Expression<Func<int>> bodyparameterstopP = null, Expression<Func<double>> bodyparameterstemperature = null, Expression<Func<double>> bodyparametersrepetitionPenalty = null, Expression<Func<double>> bodyparametersmaxTime = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: false);
            var __workflow_bodyparametersdoSample = WorkflowExpression.Compile(bodyparametersdoSample, nameof(bodyparametersdoSample), required: false);
            var __workflow_bodyparametersminLength = WorkflowExpression.Compile(bodyparametersminLength, nameof(bodyparametersminLength), required: false);
            var __workflow_bodyparametersmaxLength = WorkflowExpression.Compile(bodyparametersmaxLength, nameof(bodyparametersmaxLength), required: false);
            var __workflow_bodyparameterstopK = WorkflowExpression.Compile(bodyparameterstopK, nameof(bodyparameterstopK), required: false);
            var __workflow_bodyparameterstopP = WorkflowExpression.Compile(bodyparameterstopP, nameof(bodyparameterstopP), required: false);
            var __workflow_bodyparameterstemperature = WorkflowExpression.Compile(bodyparameterstemperature, nameof(bodyparameterstemperature), required: false);
            var __workflow_bodyparametersrepetitionPenalty = WorkflowExpression.Compile(bodyparametersrepetitionPenalty, nameof(bodyparametersrepetitionPenalty), required: false);
            var __workflow_bodyparametersmaxTime = WorkflowExpression.Compile(bodyparametersmaxTime, nameof(bodyparametersmaxTime), required: false);
            var __workflow_bodyoptionsuseCache = WorkflowExpression.Compile(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            var __workflow_bodyoptionswaitForModel = WorkflowExpression.Compile(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<TextGenerationPostResponseItem[]>(() =>
            {
                var apiCallPath = "/gpt2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (__workflow_bodyparametersdoSample != null)
                {
                    parametersObject["do_sample"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdoSample);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersminLength != null)
                {
                    parametersObject["min_length"] = ExpressionConverter.ConvertO(__workflow_bodyparametersminLength);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmaxLength != null)
                {
                    parametersObject["max_length"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmaxLength);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstopK != null)
                {
                    parametersObject["top_k"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstopK);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstopP != null)
                {
                    parametersObject["top_p"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstopP);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstemperature != null)
                {
                    parametersObject["temperature"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstemperature);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersrepetitionPenalty != null)
                {
                    parametersObject["repetition_penalty"] = ExpressionConverter.ConvertO(__workflow_bodyparametersrepetitionPenalty);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmaxTime != null)
                {
                    parametersObject["max_time"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmaxTime);
                    parametersObjectpropCount++;
                }

                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(__workflow_bodyoptionswaitForModel);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TokenClassificationPostResponseItem[]> TokenClassification(Expression<Func<string>> bodyinputs, Expression<Func<string>> bodyparametersaggregationStrategy = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            var __workflow_bodyparametersaggregationStrategy = WorkflowExpression.Compile(bodyparametersaggregationStrategy, nameof(bodyparametersaggregationStrategy), required: false);
            var __workflow_bodyoptionsuseCache = WorkflowExpression.Compile(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            var __workflow_bodyoptionswaitForModel = WorkflowExpression.Compile(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<TokenClassificationPostResponseItem[]>(() =>
            {
                var apiCallPath = "/dbmdz/bert-large-cased-finetuned-conll03-english";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (__workflow_bodyparametersaggregationStrategy != null)
                {
                    parametersObject["aggregation_strategy"] = ExpressionConverter.ConvertO(__workflow_bodyparametersaggregationStrategy);
                    parametersObjectpropCount++;
                }

                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(__workflow_bodyoptionswaitForModel);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TranslationPostResponseItem[]> Translation(Expression<Func<string>> bodyinputs, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            var __workflow_bodyoptionsuseCache = WorkflowExpression.Compile(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            var __workflow_bodyoptionswaitForModel = WorkflowExpression.Compile(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<TranslationPostResponseItem[]>(() =>
            {
                var apiCallPath = "/t5-base";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(__workflow_bodyoptionswaitForModel);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<ZeroShotPostResponse> ZeroShot(Expression<Func<string>> bodyinputs = null, Expression<Func<string[]>> bodyparameterscandidateLabels = null, Expression<Func<bool>> bodyparametersmultiLabel = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: false);
            var __workflow_bodyparameterscandidateLabels = WorkflowExpression.Compile(bodyparameterscandidateLabels, nameof(bodyparameterscandidateLabels), required: false);
            var __workflow_bodyparametersmultiLabel = WorkflowExpression.Compile(bodyparametersmultiLabel, nameof(bodyparametersmultiLabel), required: false);
            var __workflow_bodyoptionsuseCache = WorkflowExpression.Compile(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            var __workflow_bodyoptionswaitForModel = WorkflowExpression.Compile(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<ZeroShotPostResponse>(() =>
            {
                var apiCallPath = "/facebook/bart-large-mnli";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (__workflow_bodyparameterscandidateLabels != null)
                {
                    parametersObject["candidate_labels"] = ExpressionConverter.ConvertO(__workflow_bodyparameterscandidateLabels);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmultiLabel != null)
                {
                    parametersObject["multi_label"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmultiLabel);
                    parametersObjectpropCount++;
                }

                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(__workflow_bodyoptionswaitForModel);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<ConversationalPostResponse> Conversational(Expression<Func<string[]>> bodyinputspastUserInputs = null, Expression<Func<string[]>> bodyinputsgeneratedResponses = null, Expression<Func<string>> bodyinputstext = null, Expression<Func<int>> bodyparametersminLength = null, Expression<Func<int>> bodyparametersmaxLength = null, Expression<Func<int>> bodyparameterstopK = null, Expression<Func<int>> bodyparameterstopP = null, Expression<Func<double>> bodyparameterstemperature = null, Expression<Func<double>> bodyparametersrepetitionPenalty = null, Expression<Func<double>> bodyparametersmaxTime = null, Expression<Func<bool>> bodyoptionsuseCache = null, Expression<Func<bool>> bodyoptionswaitForModel = null)
        {
            var __workflow_bodyinputspastUserInputs = WorkflowExpression.Compile(bodyinputspastUserInputs, nameof(bodyinputspastUserInputs), required: false);
            var __workflow_bodyinputsgeneratedResponses = WorkflowExpression.Compile(bodyinputsgeneratedResponses, nameof(bodyinputsgeneratedResponses), required: false);
            var __workflow_bodyinputstext = WorkflowExpression.Compile(bodyinputstext, nameof(bodyinputstext), required: false);
            var __workflow_bodyparametersminLength = WorkflowExpression.Compile(bodyparametersminLength, nameof(bodyparametersminLength), required: false);
            var __workflow_bodyparametersmaxLength = WorkflowExpression.Compile(bodyparametersmaxLength, nameof(bodyparametersmaxLength), required: false);
            var __workflow_bodyparameterstopK = WorkflowExpression.Compile(bodyparameterstopK, nameof(bodyparameterstopK), required: false);
            var __workflow_bodyparameterstopP = WorkflowExpression.Compile(bodyparameterstopP, nameof(bodyparameterstopP), required: false);
            var __workflow_bodyparameterstemperature = WorkflowExpression.Compile(bodyparameterstemperature, nameof(bodyparameterstemperature), required: false);
            var __workflow_bodyparametersrepetitionPenalty = WorkflowExpression.Compile(bodyparametersrepetitionPenalty, nameof(bodyparametersrepetitionPenalty), required: false);
            var __workflow_bodyparametersmaxTime = WorkflowExpression.Compile(bodyparametersmaxTime, nameof(bodyparametersmaxTime), required: false);
            var __workflow_bodyoptionsuseCache = WorkflowExpression.Compile(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            var __workflow_bodyoptionswaitForModel = WorkflowExpression.Compile(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<ConversationalPostResponse>(() =>
            {
                var apiCallPath = "/microsoft/DialoGPT-large";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputsObject = new JObject();
                var inputsObjectpropCount = 0;
                if (__workflow_bodyinputspastUserInputs != null)
                {
                    inputsObject["past_user_inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputspastUserInputs);
                    inputsObjectpropCount++;
                }

                if (__workflow_bodyinputsgeneratedResponses != null)
                {
                    inputsObject["generated_responses"] = ExpressionConverter.ConvertO(__workflow_bodyinputsgeneratedResponses);
                    inputsObjectpropCount++;
                }

                if (__workflow_bodyinputstext != null)
                {
                    inputsObject["text"] = ExpressionConverter.ConvertO(__workflow_bodyinputstext);
                    inputsObjectpropCount++;
                }

                if (inputsObjectpropCount > 0)
                {
                    body["inputs"] = inputsObject;
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (__workflow_bodyparametersminLength != null)
                {
                    parametersObject["min_length"] = ExpressionConverter.ConvertO(__workflow_bodyparametersminLength);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmaxLength != null)
                {
                    parametersObject["max_length"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmaxLength);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstopK != null)
                {
                    parametersObject["top_k"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstopK);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstopP != null)
                {
                    parametersObject["top_p"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstopP);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstemperature != null)
                {
                    parametersObject["temperature"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstemperature);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersrepetitionPenalty != null)
                {
                    parametersObject["repetition_penalty"] = ExpressionConverter.ConvertO(__workflow_bodyparametersrepetitionPenalty);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmaxTime != null)
                {
                    parametersObject["max_time"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmaxTime);
                    parametersObjectpropCount++;
                }

                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(__workflow_bodyoptionswaitForModel);
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
            });
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
