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
        public IBodyWorkflowAction<JToken> ModelID([WorkflowExpression] Func<string> modelId, [WorkflowExpression] Func<string> bodyinputs, [WorkflowExpression] Func<string> bodyquery = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            SourceExpression.Validate(modelId, nameof(modelId), required: true);
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            SourceExpression.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            SourceExpression.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
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
                    optionsObject["use_cache"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = SourceExpressionConverter.ConvertToken(bodyoptionswaitForModel);
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
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<FillMaskPostResponseItem[]> FillMask([WorkflowExpression] Func<string> bodyinputs, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            SourceExpression.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            SourceExpression.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bert-base-uncased";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = SourceExpressionConverter.ConvertToken(bodyoptionswaitForModel);
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
                return callPayload;
            }

            return new ApiConnectionAction<FillMaskPostResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<SummarizationPostResponseItem[]> Summarization([WorkflowExpression] Func<string> bodyinputs = null, [WorkflowExpression] Func<bool> bodyparametersdoSample = null, [WorkflowExpression] Func<int> bodyparametersminLength = null, [WorkflowExpression] Func<int> bodyparametersmaxLength = null, [WorkflowExpression] Func<int> bodyparameterstopK = null, [WorkflowExpression] Func<int> bodyparameterstopP = null, [WorkflowExpression] Func<double> bodyparameterstemperature = null, [WorkflowExpression] Func<double> bodyparametersrepetitionPenalty = null, [WorkflowExpression] Func<double> bodyparametersmaxTime = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            SourceExpression.Validate(bodyparametersdoSample, nameof(bodyparametersdoSample), required: false);
            SourceExpression.Validate(bodyparametersminLength, nameof(bodyparametersminLength), required: false);
            SourceExpression.Validate(bodyparametersmaxLength, nameof(bodyparametersmaxLength), required: false);
            SourceExpression.Validate(bodyparameterstopK, nameof(bodyparameterstopK), required: false);
            SourceExpression.Validate(bodyparameterstopP, nameof(bodyparameterstopP), required: false);
            SourceExpression.Validate(bodyparameterstemperature, nameof(bodyparameterstemperature), required: false);
            SourceExpression.Validate(bodyparametersrepetitionPenalty, nameof(bodyparametersrepetitionPenalty), required: false);
            SourceExpression.Validate(bodyparametersmaxTime, nameof(bodyparametersmaxTime), required: false);
            SourceExpression.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            SourceExpression.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/facebook/bart-large-cnn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparametersdoSample != null)
                {
                    parametersObject["do_sample"] = SourceExpressionConverter.ConvertToken(bodyparametersdoSample);
                    parametersObjectpropCount++;
                }

                if (bodyparametersminLength != null)
                {
                    parametersObject["min_length"] = SourceExpressionConverter.ConvertToken(bodyparametersminLength);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxLength != null)
                {
                    parametersObject["max_length"] = SourceExpressionConverter.ConvertToken(bodyparametersmaxLength);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopK != null)
                {
                    parametersObject["top_k"] = SourceExpressionConverter.ConvertToken(bodyparameterstopK);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopP != null)
                {
                    parametersObject["top_p"] = SourceExpressionConverter.ConvertToken(bodyparameterstopP);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstemperature != null)
                {
                    parametersObject["temperature"] = SourceExpressionConverter.ConvertToken(bodyparameterstemperature);
                    parametersObjectpropCount++;
                }

                if (bodyparametersrepetitionPenalty != null)
                {
                    parametersObject["repetition_penalty"] = SourceExpressionConverter.ConvertToken(bodyparametersrepetitionPenalty);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxTime != null)
                {
                    parametersObject["max_time"] = SourceExpressionConverter.ConvertToken(bodyparametersmaxTime);
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
                    optionsObject["use_cache"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = SourceExpressionConverter.ConvertToken(bodyoptionswaitForModel);
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
                return callPayload;
            }

            return new ApiConnectionAction<SummarizationPostResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<AnswerPostResponse> Answer([WorkflowExpression] Func<string> bodyinputsquestion = null, [WorkflowExpression] Func<string> bodyinputscontext = null)
        {
            SourceExpression.Validate(bodyinputsquestion, nameof(bodyinputsquestion), required: false);
            SourceExpression.Validate(bodyinputscontext, nameof(bodyinputscontext), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    inputsObject["question"] = SourceExpressionConverter.ConvertToken(bodyinputsquestion);
                    inputsObjectpropCount++;
                }

                if (bodyinputscontext != null)
                {
                    inputsObject["context"] = SourceExpressionConverter.ConvertToken(bodyinputscontext);
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
                return callPayload;
            }

            return new ApiConnectionAction<AnswerPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<double[]> SentenceSimilarity([WorkflowExpression] Func<string> bodyinputssourceSentence = null, [WorkflowExpression] Func<string[]> bodyinputssentences = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            SourceExpression.Validate(bodyinputssourceSentence, nameof(bodyinputssourceSentence), required: false);
            SourceExpression.Validate(bodyinputssentences, nameof(bodyinputssentences), required: false);
            SourceExpression.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            SourceExpression.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    inputsObject["source_sentence"] = SourceExpressionConverter.ConvertToken(bodyinputssourceSentence);
                    inputsObjectpropCount++;
                }

                if (bodyinputssentences != null)
                {
                    inputsObject["sentences"] = SourceExpressionConverter.ConvertToken(bodyinputssentences);
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
                    optionsObject["use_cache"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = SourceExpressionConverter.ConvertToken(bodyoptionswaitForModel);
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
                return callPayload;
            }

            return new ApiConnectionAction<double[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TextClassificationPostResponseItemItem[][]> TextClassification([WorkflowExpression] Func<string> bodyinputs, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            SourceExpression.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            SourceExpression.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/distilbert-base-uncased-finetuned-sst-2-english";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = SourceExpressionConverter.ConvertToken(bodyoptionswaitForModel);
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
                return callPayload;
            }

            return new ApiConnectionAction<TextClassificationPostResponseItemItem[][]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TextGenerationPostResponseItem[]> TextGeneration([WorkflowExpression] Func<string> bodyinputs = null, [WorkflowExpression] Func<bool> bodyparametersdoSample = null, [WorkflowExpression] Func<int> bodyparametersminLength = null, [WorkflowExpression] Func<int> bodyparametersmaxLength = null, [WorkflowExpression] Func<int> bodyparameterstopK = null, [WorkflowExpression] Func<int> bodyparameterstopP = null, [WorkflowExpression] Func<double> bodyparameterstemperature = null, [WorkflowExpression] Func<double> bodyparametersrepetitionPenalty = null, [WorkflowExpression] Func<double> bodyparametersmaxTime = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            SourceExpression.Validate(bodyparametersdoSample, nameof(bodyparametersdoSample), required: false);
            SourceExpression.Validate(bodyparametersminLength, nameof(bodyparametersminLength), required: false);
            SourceExpression.Validate(bodyparametersmaxLength, nameof(bodyparametersmaxLength), required: false);
            SourceExpression.Validate(bodyparameterstopK, nameof(bodyparameterstopK), required: false);
            SourceExpression.Validate(bodyparameterstopP, nameof(bodyparameterstopP), required: false);
            SourceExpression.Validate(bodyparameterstemperature, nameof(bodyparameterstemperature), required: false);
            SourceExpression.Validate(bodyparametersrepetitionPenalty, nameof(bodyparametersrepetitionPenalty), required: false);
            SourceExpression.Validate(bodyparametersmaxTime, nameof(bodyparametersmaxTime), required: false);
            SourceExpression.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            SourceExpression.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gpt2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparametersdoSample != null)
                {
                    parametersObject["do_sample"] = SourceExpressionConverter.ConvertToken(bodyparametersdoSample);
                    parametersObjectpropCount++;
                }

                if (bodyparametersminLength != null)
                {
                    parametersObject["min_length"] = SourceExpressionConverter.ConvertToken(bodyparametersminLength);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxLength != null)
                {
                    parametersObject["max_length"] = SourceExpressionConverter.ConvertToken(bodyparametersmaxLength);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopK != null)
                {
                    parametersObject["top_k"] = SourceExpressionConverter.ConvertToken(bodyparameterstopK);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopP != null)
                {
                    parametersObject["top_p"] = SourceExpressionConverter.ConvertToken(bodyparameterstopP);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstemperature != null)
                {
                    parametersObject["temperature"] = SourceExpressionConverter.ConvertToken(bodyparameterstemperature);
                    parametersObjectpropCount++;
                }

                if (bodyparametersrepetitionPenalty != null)
                {
                    parametersObject["repetition_penalty"] = SourceExpressionConverter.ConvertToken(bodyparametersrepetitionPenalty);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxTime != null)
                {
                    parametersObject["max_time"] = SourceExpressionConverter.ConvertToken(bodyparametersmaxTime);
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
                    optionsObject["use_cache"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = SourceExpressionConverter.ConvertToken(bodyoptionswaitForModel);
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
                return callPayload;
            }

            return new ApiConnectionAction<TextGenerationPostResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TokenClassificationPostResponseItem[]> TokenClassification([WorkflowExpression] Func<string> bodyinputs, [WorkflowExpression] Func<string> bodyparametersaggregationStrategy = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            SourceExpression.Validate(bodyparametersaggregationStrategy, nameof(bodyparametersaggregationStrategy), required: false);
            SourceExpression.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            SourceExpression.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dbmdz/bert-large-cased-finetuned-conll03-english";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparametersaggregationStrategy != null)
                {
                    parametersObject["aggregation_strategy"] = SourceExpressionConverter.ConvertToken(bodyparametersaggregationStrategy);
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
                    optionsObject["use_cache"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = SourceExpressionConverter.ConvertToken(bodyoptionswaitForModel);
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
                return callPayload;
            }

            return new ApiConnectionAction<TokenClassificationPostResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TranslationPostResponseItem[]> Translation([WorkflowExpression] Func<string> bodyinputs, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            SourceExpression.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            SourceExpression.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/t5-base";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsuseCache != null)
                {
                    optionsObject["use_cache"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = SourceExpressionConverter.ConvertToken(bodyoptionswaitForModel);
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
                return callPayload;
            }

            return new ApiConnectionAction<TranslationPostResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<ZeroShotPostResponse> ZeroShot([WorkflowExpression] Func<string> bodyinputs = null, [WorkflowExpression] Func<string[]> bodyparameterscandidateLabels = null, [WorkflowExpression] Func<bool> bodyparametersmultiLabel = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            SourceExpression.Validate(bodyparameterscandidateLabels, nameof(bodyparameterscandidateLabels), required: false);
            SourceExpression.Validate(bodyparametersmultiLabel, nameof(bodyparametersmultiLabel), required: false);
            SourceExpression.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            SourceExpression.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/facebook/bart-large-mnli";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparameterscandidateLabels != null)
                {
                    parametersObject["candidate_labels"] = SourceExpressionConverter.ConvertToken(bodyparameterscandidateLabels);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmultiLabel != null)
                {
                    parametersObject["multi_label"] = SourceExpressionConverter.ConvertToken(bodyparametersmultiLabel);
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
                    optionsObject["use_cache"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = SourceExpressionConverter.ConvertToken(bodyoptionswaitForModel);
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
                return callPayload;
            }

            return new ApiConnectionAction<ZeroShotPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<ConversationalPostResponse> Conversational([WorkflowExpression] Func<string[]> bodyinputspastUserInputs = null, [WorkflowExpression] Func<string[]> bodyinputsgeneratedResponses = null, [WorkflowExpression] Func<string> bodyinputstext = null, [WorkflowExpression] Func<int> bodyparametersminLength = null, [WorkflowExpression] Func<int> bodyparametersmaxLength = null, [WorkflowExpression] Func<int> bodyparameterstopK = null, [WorkflowExpression] Func<int> bodyparameterstopP = null, [WorkflowExpression] Func<double> bodyparameterstemperature = null, [WorkflowExpression] Func<double> bodyparametersrepetitionPenalty = null, [WorkflowExpression] Func<double> bodyparametersmaxTime = null, [WorkflowExpression] Func<bool> bodyoptionsuseCache = null, [WorkflowExpression] Func<bool> bodyoptionswaitForModel = null)
        {
            SourceExpression.Validate(bodyinputspastUserInputs, nameof(bodyinputspastUserInputs), required: false);
            SourceExpression.Validate(bodyinputsgeneratedResponses, nameof(bodyinputsgeneratedResponses), required: false);
            SourceExpression.Validate(bodyinputstext, nameof(bodyinputstext), required: false);
            SourceExpression.Validate(bodyparametersminLength, nameof(bodyparametersminLength), required: false);
            SourceExpression.Validate(bodyparametersmaxLength, nameof(bodyparametersmaxLength), required: false);
            SourceExpression.Validate(bodyparameterstopK, nameof(bodyparameterstopK), required: false);
            SourceExpression.Validate(bodyparameterstopP, nameof(bodyparameterstopP), required: false);
            SourceExpression.Validate(bodyparameterstemperature, nameof(bodyparameterstemperature), required: false);
            SourceExpression.Validate(bodyparametersrepetitionPenalty, nameof(bodyparametersrepetitionPenalty), required: false);
            SourceExpression.Validate(bodyparametersmaxTime, nameof(bodyparametersmaxTime), required: false);
            SourceExpression.Validate(bodyoptionsuseCache, nameof(bodyoptionsuseCache), required: false);
            SourceExpression.Validate(bodyoptionswaitForModel, nameof(bodyoptionswaitForModel), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    inputsObject["past_user_inputs"] = SourceExpressionConverter.ConvertToken(bodyinputspastUserInputs);
                    inputsObjectpropCount++;
                }

                if (bodyinputsgeneratedResponses != null)
                {
                    inputsObject["generated_responses"] = SourceExpressionConverter.ConvertToken(bodyinputsgeneratedResponses);
                    inputsObjectpropCount++;
                }

                if (bodyinputstext != null)
                {
                    inputsObject["text"] = SourceExpressionConverter.ConvertToken(bodyinputstext);
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
                    parametersObject["min_length"] = SourceExpressionConverter.ConvertToken(bodyparametersminLength);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxLength != null)
                {
                    parametersObject["max_length"] = SourceExpressionConverter.ConvertToken(bodyparametersmaxLength);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopK != null)
                {
                    parametersObject["top_k"] = SourceExpressionConverter.ConvertToken(bodyparameterstopK);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstopP != null)
                {
                    parametersObject["top_p"] = SourceExpressionConverter.ConvertToken(bodyparameterstopP);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstemperature != null)
                {
                    parametersObject["temperature"] = SourceExpressionConverter.ConvertToken(bodyparameterstemperature);
                    parametersObjectpropCount++;
                }

                if (bodyparametersrepetitionPenalty != null)
                {
                    parametersObject["repetition_penalty"] = SourceExpressionConverter.ConvertToken(bodyparametersrepetitionPenalty);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmaxTime != null)
                {
                    parametersObject["max_time"] = SourceExpressionConverter.ConvertToken(bodyparametersmaxTime);
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
                    optionsObject["use_cache"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseCache);
                    optionsObjectpropCount++;
                }

                if (bodyoptionswaitForModel != null)
                {
                    optionsObject["wait_for_model"] = SourceExpressionConverter.ConvertToken(bodyoptionswaitForModel);
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
                return callPayload;
            }

            return new ApiConnectionAction<ConversationalPostResponse>(BuildSourceInput);
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