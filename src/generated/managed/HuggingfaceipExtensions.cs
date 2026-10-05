//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huggingfaceip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuggingfaceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        [WorkflowExpressionFactory(nameof(__BuildModelID))]
        public IBodyWorkflowAction<JToken> ModelID([WorkflowExpression] Func<string> modelId, [WorkflowExpression] Func<string> bodyinputs, [WorkflowExpression] Func<string> bodyquery = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildModelID(WorkflowValue<string> modelId, WorkflowValue<string> bodyinputs, WorkflowValue<string> bodyquery = null, WorkflowValue<bool> bodyoptionsuseCache = null, WorkflowValue<bool> bodyoptionswaitForModel = null)
        {
            WorkflowValue.Validate(modelId, nameof(modelId), required: true);
            WorkflowValue.Validate(bodyinputs, nameof(bodyinputs), required: true);
            WorkflowValue.Validate(bodyquery, nameof(bodyquery), required: false);
            WorkflowValue.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            WorkflowValue.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}", ExpressionConverter.ConvertWithUrlEncoding(modelId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
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
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(bodyoptionswaitForModel);
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
        [WorkflowExpressionFactory(nameof(__BuildFillMask))]
        public IBodyWorkflowAction<FillMaskPostResponseItem[]> FillMask([WorkflowExpression] Func<string> bodyinputs, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FillMaskPostResponseItem[]> __BuildFillMask(WorkflowValue<string> bodyinputs, WorkflowValue<bool> bodyoptionsuseCache = null, WorkflowValue<bool> bodyoptionswaitForModel = null)
        {
            WorkflowValue.Validate(bodyinputs, nameof(bodyinputs), required: true);
            WorkflowValue.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            WorkflowValue.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<FillMaskPostResponseItem[]>(() =>
            {
                var apiCallPath = "/bert-base-uncased";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(bodyoptionswaitForModel);
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
        [WorkflowExpressionFactory(nameof(__BuildSummarization))]
        public IBodyWorkflowAction<SummarizationPostResponseItem[]> Summarization([WorkflowExpression] Func<string> bodyinputs = null, [WorkflowExpression] Func<bool> bodyparametersdoSample = null, [WorkflowExpression] Func<int> bodyparametersminLength = null, [WorkflowExpression] Func<int> bodyparametersmaxLength = null, [WorkflowExpression] Func<int> bodyparameterstopK = null, [WorkflowExpression] Func<int> bodyparameterstopP = null, [WorkflowExpression] Func<double> bodyparameterstemperature = null, [WorkflowExpression] Func<double> bodyparametersrepetitionPenalty = null, [WorkflowExpression] Func<double> bodyparametersmaxTime = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SummarizationPostResponseItem[]> __BuildSummarization(WorkflowValue<string> bodyinputs = null, WorkflowValue<bool> bodyparametersdoSample = null, WorkflowValue<int> bodyparametersminLength = null, WorkflowValue<int> bodyparametersmaxLength = null, WorkflowValue<int> bodyparameterstopK = null, WorkflowValue<int> bodyparameterstopP = null, WorkflowValue<double> bodyparameterstemperature = null, WorkflowValue<double> bodyparametersrepetitionPenalty = null, WorkflowValue<double> bodyparametersmaxTime = null, WorkflowValue<bool> bodyoptionsuseCache = null, WorkflowValue<bool> bodyoptionswaitForModel = null)
        {
            WorkflowValue.Validate(bodyinputs, nameof(bodyinputs), required: false);
            WorkflowValue.Validate(bodyparametersdoSample, nameof(bodyparametersdoSample), required: false);
            WorkflowValue.Validate(bodyparametersminLength, nameof(bodyparametersminLength), required: false);
            WorkflowValue.Validate(bodyparametersmaxLength, nameof(bodyparametersmaxLength), required: false);
            WorkflowValue.Validate(bodyparameterstopK, nameof(bodyparameterstopK), required: false);
            WorkflowValue.Validate(bodyparameterstopP, nameof(bodyparameterstopP), required: false);
            WorkflowValue.Validate(bodyparameterstemperature, nameof(bodyparameterstemperature), required: false);
            WorkflowValue.Validate(bodyparametersrepetitionPenalty, nameof(bodyparametersrepetitionPenalty), required: false);
            WorkflowValue.Validate(bodyparametersmaxTime, nameof(bodyparametersmaxTime), required: false);
            WorkflowValue.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            WorkflowValue.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<SummarizationPostResponseItem[]>(() =>
            {
                var apiCallPath = "/facebook/bart-large-cnn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparametersdoSample != null)
                {
                    parametersObject["do_sample"] = ExpressionConverter.ConvertO(bodyparametersdoSample);
                    parametersObjectpropCount++;
                }

                if (bodyparametersminLength != null)
                {
                    parametersObject["min_length"] = ExpressionConverter.ConvertO(bodyparametersminLength);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxLength != null)
                {
                    parametersObject["max_length"] = ExpressionConverter.ConvertO(bodyparametersmaxLength);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopK != null)
                {
                    parametersObject["top_k"] = ExpressionConverter.ConvertO(bodyparameterstopK);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopP != null)
                {
                    parametersObject["top_p"] = ExpressionConverter.ConvertO(bodyparameterstopP);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstemperature != null)
                {
                    parametersObject["temperature"] = ExpressionConverter.ConvertO(bodyparameterstemperature);
                    parametersObjectpropCount++;
                }

                if (bodyparametersrepetitionPenalty != null)
                {
                    parametersObject["repetition_penalty"] = ExpressionConverter.ConvertO(bodyparametersrepetitionPenalty);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxTime != null)
                {
                    parametersObject["max_time"] = ExpressionConverter.ConvertO(bodyparametersmaxTime);
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
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(bodyoptionswaitForModel);
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
        [WorkflowExpressionFactory(nameof(__BuildAnswer))]
        public IBodyWorkflowAction<AnswerPostResponse> Answer([WorkflowExpression] Func<string> bodyinputsquestion = null, [WorkflowExpression] Func<string> bodyinputscontext = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AnswerPostResponse> __BuildAnswer(WorkflowValue<string> bodyinputsquestion = null, WorkflowValue<string> bodyinputscontext = null)
        {
            WorkflowValue.Validate(bodyinputsquestion, nameof(bodyinputsquestion), required: false);
            WorkflowValue.Validate(bodyinputscontext, nameof(bodyinputscontext), required: false);
            return new DeferredBodyAction<AnswerPostResponse>(() =>
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
                    inputsObject["question"] = ExpressionConverter.ConvertO(bodyinputsquestion);
                    inputsObjectpropCount++;
                }

                if (bodyinputscontext != null)
                {
                    inputsObject["context"] = ExpressionConverter.ConvertO(bodyinputscontext);
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
        [WorkflowExpressionFactory(nameof(__BuildSentenceSimilarity))]
        public IBodyWorkflowAction<double[]> SentenceSimilarity([WorkflowExpression] Func<string> bodyinputssourceSentence = null, [WorkflowExpression] Func<string[]> bodyinputssentences = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<double[]> __BuildSentenceSimilarity(WorkflowValue<string> bodyinputssourceSentence = null, WorkflowValue<string[]> bodyinputssentences = null, WorkflowValue<bool> bodyoptionsuseCache = null, WorkflowValue<bool> bodyoptionswaitForModel = null)
        {
            WorkflowValue.Validate(bodyinputssourceSentence, nameof(bodyinputssourceSentence), required: false);
            WorkflowValue.Validate(bodyinputssentences, nameof(bodyinputssentences), required: false);
            WorkflowValue.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            WorkflowValue.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<double[]>(() =>
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
                    inputsObject["source_sentence"] = ExpressionConverter.ConvertO(bodyinputssourceSentence);
                    inputsObjectpropCount++;
                }

                if (bodyinputssentences != null)
                {
                    inputsObject["sentences"] = ExpressionConverter.ConvertO(bodyinputssentences);
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
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(bodyoptionswaitForModel);
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
        [WorkflowExpressionFactory(nameof(__BuildTextClassification))]
        public IBodyWorkflowAction<TextClassificationPostResponseItemItem[][]> TextClassification([WorkflowExpression] Func<string> bodyinputs, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TextClassificationPostResponseItemItem[][]> __BuildTextClassification(WorkflowValue<string> bodyinputs, WorkflowValue<bool> bodyoptionsuseCache = null, WorkflowValue<bool> bodyoptionswaitForModel = null)
        {
            WorkflowValue.Validate(bodyinputs, nameof(bodyinputs), required: true);
            WorkflowValue.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            WorkflowValue.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<TextClassificationPostResponseItemItem[][]>(() =>
            {
                var apiCallPath = "/distilbert-base-uncased-finetuned-sst-2-english";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(bodyoptionswaitForModel);
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
        [WorkflowExpressionFactory(nameof(__BuildTextGeneration))]
        public IBodyWorkflowAction<TextGenerationPostResponseItem[]> TextGeneration([WorkflowExpression] Func<string> bodyinputs = null, [WorkflowExpression] Func<bool> bodyparametersdoSample = null, [WorkflowExpression] Func<int> bodyparametersminLength = null, [WorkflowExpression] Func<int> bodyparametersmaxLength = null, [WorkflowExpression] Func<int> bodyparameterstopK = null, [WorkflowExpression] Func<int> bodyparameterstopP = null, [WorkflowExpression] Func<double> bodyparameterstemperature = null, [WorkflowExpression] Func<double> bodyparametersrepetitionPenalty = null, [WorkflowExpression] Func<double> bodyparametersmaxTime = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TextGenerationPostResponseItem[]> __BuildTextGeneration(WorkflowValue<string> bodyinputs = null, WorkflowValue<bool> bodyparametersdoSample = null, WorkflowValue<int> bodyparametersminLength = null, WorkflowValue<int> bodyparametersmaxLength = null, WorkflowValue<int> bodyparameterstopK = null, WorkflowValue<int> bodyparameterstopP = null, WorkflowValue<double> bodyparameterstemperature = null, WorkflowValue<double> bodyparametersrepetitionPenalty = null, WorkflowValue<double> bodyparametersmaxTime = null, WorkflowValue<bool> bodyoptionsuseCache = null, WorkflowValue<bool> bodyoptionswaitForModel = null)
        {
            WorkflowValue.Validate(bodyinputs, nameof(bodyinputs), required: false);
            WorkflowValue.Validate(bodyparametersdoSample, nameof(bodyparametersdoSample), required: false);
            WorkflowValue.Validate(bodyparametersminLength, nameof(bodyparametersminLength), required: false);
            WorkflowValue.Validate(bodyparametersmaxLength, nameof(bodyparametersmaxLength), required: false);
            WorkflowValue.Validate(bodyparameterstopK, nameof(bodyparameterstopK), required: false);
            WorkflowValue.Validate(bodyparameterstopP, nameof(bodyparameterstopP), required: false);
            WorkflowValue.Validate(bodyparameterstemperature, nameof(bodyparameterstemperature), required: false);
            WorkflowValue.Validate(bodyparametersrepetitionPenalty, nameof(bodyparametersrepetitionPenalty), required: false);
            WorkflowValue.Validate(bodyparametersmaxTime, nameof(bodyparametersmaxTime), required: false);
            WorkflowValue.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            WorkflowValue.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<TextGenerationPostResponseItem[]>(() =>
            {
                var apiCallPath = "/gpt2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparametersdoSample != null)
                {
                    parametersObject["do_sample"] = ExpressionConverter.ConvertO(bodyparametersdoSample);
                    parametersObjectpropCount++;
                }

                if (bodyparametersminLength != null)
                {
                    parametersObject["min_length"] = ExpressionConverter.ConvertO(bodyparametersminLength);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxLength != null)
                {
                    parametersObject["max_length"] = ExpressionConverter.ConvertO(bodyparametersmaxLength);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopK != null)
                {
                    parametersObject["top_k"] = ExpressionConverter.ConvertO(bodyparameterstopK);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopP != null)
                {
                    parametersObject["top_p"] = ExpressionConverter.ConvertO(bodyparameterstopP);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstemperature != null)
                {
                    parametersObject["temperature"] = ExpressionConverter.ConvertO(bodyparameterstemperature);
                    parametersObjectpropCount++;
                }

                if (bodyparametersrepetitionPenalty != null)
                {
                    parametersObject["repetition_penalty"] = ExpressionConverter.ConvertO(bodyparametersrepetitionPenalty);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxTime != null)
                {
                    parametersObject["max_time"] = ExpressionConverter.ConvertO(bodyparametersmaxTime);
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
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(bodyoptionswaitForModel);
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
        [WorkflowExpressionFactory(nameof(__BuildTokenClassification))]
        public IBodyWorkflowAction<TokenClassificationPostResponseItem[]> TokenClassification([WorkflowExpression] Func<string> bodyinputs, [WorkflowExpression] Func<string> bodyparametersaggregationStrategy = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TokenClassificationPostResponseItem[]> __BuildTokenClassification(WorkflowValue<string> bodyinputs, WorkflowValue<string> bodyparametersaggregationStrategy = null, WorkflowValue<bool> bodyoptionsuseCache = null, WorkflowValue<bool> bodyoptionswaitForModel = null)
        {
            WorkflowValue.Validate(bodyinputs, nameof(bodyinputs), required: true);
            WorkflowValue.Validate(bodyparametersaggregationStrategy, nameof(bodyparametersaggregationStrategy), required: false);
            WorkflowValue.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            WorkflowValue.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<TokenClassificationPostResponseItem[]>(() =>
            {
                var apiCallPath = "/dbmdz/bert-large-cased-finetuned-conll03-english";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparametersaggregationStrategy != null)
                {
                    parametersObject["aggregation_strategy"] = ExpressionConverter.ConvertO(bodyparametersaggregationStrategy);
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
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(bodyoptionswaitForModel);
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
        [WorkflowExpressionFactory(nameof(__BuildTranslation))]
        public IBodyWorkflowAction<TranslationPostResponseItem[]> Translation([WorkflowExpression] Func<string> bodyinputs, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TranslationPostResponseItem[]> __BuildTranslation(WorkflowValue<string> bodyinputs, WorkflowValue<bool> bodyoptionsuseCache = null, WorkflowValue<bool> bodyoptionswaitForModel = null)
        {
            WorkflowValue.Validate(bodyinputs, nameof(bodyinputs), required: true);
            WorkflowValue.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            WorkflowValue.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<TranslationPostResponseItem[]>(() =>
            {
                var apiCallPath = "/t5-base";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(bodyoptionswaitForModel);
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
        [WorkflowExpressionFactory(nameof(__BuildZeroShot))]
        public IBodyWorkflowAction<ZeroShotPostResponse> ZeroShot([WorkflowExpression] Func<string> bodyinputs = null, [WorkflowExpression] Func<string[]> bodyparameterscandidateLabels = null, [WorkflowExpression] Func<bool> bodyparametersmultiLabel = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ZeroShotPostResponse> __BuildZeroShot(WorkflowValue<string> bodyinputs = null, WorkflowValue<string[]> bodyparameterscandidateLabels = null, WorkflowValue<bool> bodyparametersmultiLabel = null, WorkflowValue<bool> bodyoptionsuseCache = null, WorkflowValue<bool> bodyoptionswaitForModel = null)
        {
            WorkflowValue.Validate(bodyinputs, nameof(bodyinputs), required: false);
            WorkflowValue.Validate(bodyparameterscandidateLabels, nameof(bodyparameterscandidateLabels), required: false);
            WorkflowValue.Validate(bodyparametersmultiLabel, nameof(bodyparametersmultiLabel), required: false);
            WorkflowValue.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            WorkflowValue.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<ZeroShotPostResponse>(() =>
            {
                var apiCallPath = "/facebook/bart-large-mnli";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparameterscandidateLabels != null)
                {
                    parametersObject["candidate_labels"] = ExpressionConverter.ConvertO(bodyparameterscandidateLabels);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmultiLabel != null)
                {
                    parametersObject["multi_label"] = ExpressionConverter.ConvertO(bodyparametersmultiLabel);
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
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(bodyoptionswaitForModel);
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
        [WorkflowExpressionFactory(nameof(__BuildConversational))]
        public IBodyWorkflowAction<ConversationalPostResponse> Conversational([WorkflowExpression] Func<string[]> bodyinputspastUserInputs = null, [WorkflowExpression] Func<string[]> bodyinputsgeneratedResponses = null, [WorkflowExpression] Func<string> bodyinputstext = null, [WorkflowExpression] Func<int> bodyparametersminLength = null, [WorkflowExpression] Func<int> bodyparametersmaxLength = null, [WorkflowExpression] Func<int> bodyparameterstopK = null, [WorkflowExpression] Func<int> bodyparameterstopP = null, [WorkflowExpression] Func<double> bodyparameterstemperature = null, [WorkflowExpression] Func<double> bodyparametersrepetitionPenalty = null, [WorkflowExpression] Func<double> bodyparametersmaxTime = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConversationalPostResponse> __BuildConversational(WorkflowValue<string[]> bodyinputspastUserInputs = null, WorkflowValue<string[]> bodyinputsgeneratedResponses = null, WorkflowValue<string> bodyinputstext = null, WorkflowValue<int> bodyparametersminLength = null, WorkflowValue<int> bodyparametersmaxLength = null, WorkflowValue<int> bodyparameterstopK = null, WorkflowValue<int> bodyparameterstopP = null, WorkflowValue<double> bodyparameterstemperature = null, WorkflowValue<double> bodyparametersrepetitionPenalty = null, WorkflowValue<double> bodyparametersmaxTime = null, WorkflowValue<bool> bodyoptionsuseCache = null, WorkflowValue<bool> bodyoptionswaitForModel = null)
        {
            WorkflowValue.Validate(bodyinputspastUserInputs, nameof(bodyinputspastUserInputs), required: false);
            WorkflowValue.Validate(bodyinputsgeneratedResponses, nameof(bodyinputsgeneratedResponses), required: false);
            WorkflowValue.Validate(bodyinputstext, nameof(bodyinputstext), required: false);
            WorkflowValue.Validate(bodyparametersminLength, nameof(bodyparametersminLength), required: false);
            WorkflowValue.Validate(bodyparametersmaxLength, nameof(bodyparametersmaxLength), required: false);
            WorkflowValue.Validate(bodyparameterstopK, nameof(bodyparameterstopK), required: false);
            WorkflowValue.Validate(bodyparameterstopP, nameof(bodyparameterstopP), required: false);
            WorkflowValue.Validate(bodyparameterstemperature, nameof(bodyparameterstemperature), required: false);
            WorkflowValue.Validate(bodyparametersrepetitionPenalty, nameof(bodyparametersrepetitionPenalty), required: false);
            WorkflowValue.Validate(bodyparametersmaxTime, nameof(bodyparametersmaxTime), required: false);
            WorkflowValue.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            WorkflowValue.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            return new DeferredBodyAction<ConversationalPostResponse>(() =>
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
                    inputsObject["past_user_inputs"] = ExpressionConverter.ConvertO(bodyinputspastUserInputs);
                    inputsObjectpropCount++;
                }

                if (bodyinputsgeneratedResponses != null)
                {
                    inputsObject["generated_responses"] = ExpressionConverter.ConvertO(bodyinputsgeneratedResponses);
                    inputsObjectpropCount++;
                }

                if (bodyinputstext != null)
                {
                    inputsObject["text"] = ExpressionConverter.ConvertO(bodyinputstext);
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
                    parametersObject["min_length"] = ExpressionConverter.ConvertO(bodyparametersminLength);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxLength != null)
                {
                    parametersObject["max_length"] = ExpressionConverter.ConvertO(bodyparametersmaxLength);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopK != null)
                {
                    parametersObject["top_k"] = ExpressionConverter.ConvertO(bodyparameterstopK);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopP != null)
                {
                    parametersObject["top_p"] = ExpressionConverter.ConvertO(bodyparameterstopP);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstemperature != null)
                {
                    parametersObject["temperature"] = ExpressionConverter.ConvertO(bodyparameterstemperature);
                    parametersObjectpropCount++;
                }

                if (bodyparametersrepetitionPenalty != null)
                {
                    parametersObject["repetition_penalty"] = ExpressionConverter.ConvertO(bodyparametersrepetitionPenalty);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxTime != null)
                {
                    parametersObject["max_time"] = ExpressionConverter.ConvertO(bodyparametersmaxTime);
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
                    optionsObject["use_cache"] = ExpressionConverter.ConvertO(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = ExpressionConverter.ConvertO(bodyoptionswaitForModel);
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
