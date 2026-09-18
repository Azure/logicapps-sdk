//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlepalm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglepalmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> ListModels([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> pageToken = null)
        {
            SourceExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(pageToken, nameof(pageToken), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (pageToken != null)
                    callPayload.Queries["pageToken"] = SourceExpressionConverter.ConvertO(pageToken);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GetModel([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GenerateText([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> modelType, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<string> bodypromptprompt, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<int> bodycandidateCount = null, [WorkflowExpression] Func<int> bodymaxOutputTokens = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<int> bodytopK = null, [WorkflowExpression] Func<JToken[]> bodysafetySettings = null, [WorkflowExpression] Func<string[]> bodystopSequences = null)
        {
            SourceExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            SourceExpression.Validate(modelType, nameof(modelType), required: true);
            SourceExpression.Validate(modelName, nameof(modelName), required: true);
            SourceExpression.Validate(bodypromptprompt, nameof(bodypromptprompt), required: true);
            SourceExpression.Validate(bodytemperature, nameof(bodytemperature), required: false);
            SourceExpression.Validate(bodycandidateCount, nameof(bodycandidateCount), required: false);
            SourceExpression.Validate(bodymaxOutputTokens, nameof(bodymaxOutputTokens), required: false);
            SourceExpression.Validate(bodytopP, nameof(bodytopP), required: false);
            SourceExpression.Validate(bodytopK, nameof(bodytopK), required: false);
            SourceExpression.Validate(bodysafetySettings, nameof(bodysafetySettings), required: false);
            SourceExpression.Validate(bodystopSequences, nameof(bodystopSequences), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}:generateText", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var promptObject = new JObject();
                var promptObjectpropCount = 0;
                promptObjectpropCount++;
                promptObject["text"] = SourceExpressionConverter.ConvertToken(bodypromptprompt);
                if (promptObjectpropCount > 0)
                {
                    body["prompt"] = promptObject;
                    bodypropCount++;
                }

                if (bodytemperature != null)
                {
                    body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
                    bodypropCount++;
                }

                if (bodycandidateCount != null)
                {
                    body["candidateCount"] = SourceExpressionConverter.ConvertToken(bodycandidateCount);
                    bodypropCount++;
                }

                if (bodymaxOutputTokens != null)
                {
                    body["maxOutputTokens"] = SourceExpressionConverter.ConvertToken(bodymaxOutputTokens);
                    bodypropCount++;
                }

                if (bodytopP != null)
                {
                    body["topP"] = SourceExpressionConverter.ConvertToken(bodytopP);
                    bodypropCount++;
                }

                if (bodytopK != null)
                {
                    body["topK"] = SourceExpressionConverter.ConvertToken(bodytopK);
                    bodypropCount++;
                }

                if (bodysafetySettings != null)
                {
                    body["safetySettings"] = SourceExpressionConverter.ConvertToken(bodysafetySettings);
                    bodypropCount++;
                }

                if (bodystopSequences != null)
                {
                    body["stopSequences"] = SourceExpressionConverter.ConvertToken(bodystopSequences);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GenerateMessage([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<bodypromptmessagesInputItem[]> bodypromptmessages = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<int> bodytopK = null)
        {
            SourceExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            SourceExpression.Validate(model, nameof(model), required: true);
            SourceExpression.Validate(bodypromptmessages, nameof(bodypromptmessages), required: false);
            SourceExpression.Validate(bodytemperature, nameof(bodytemperature), required: false);
            SourceExpression.Validate(bodytopP, nameof(bodytopP), required: false);
            SourceExpression.Validate(bodytopK, nameof(bodytopK), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:generateMessage", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(model, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var promptObject = new JObject();
                var promptObjectpropCount = 0;
                if (bodypromptmessages != null)
                {
                    promptObject["messages"] = SourceExpressionConverter.ConvertToken(bodypromptmessages);
                    promptObjectpropCount++;
                }

                if (promptObjectpropCount > 0)
                {
                    body["prompt"] = promptObject;
                    bodypropCount++;
                }

                if (bodytemperature != null)
                {
                    body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
                    bodypropCount++;
                }

                if (bodytopP != null)
                {
                    body["topP"] = SourceExpressionConverter.ConvertToken(bodytopP);
                    bodypropCount++;
                }

                if (bodytopK != null)
                {
                    body["topK"] = SourceExpressionConverter.ConvertToken(bodytopK);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> CountTextTokens([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<string> bodyprompttext = null)
        {
            SourceExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            SourceExpression.Validate(model, nameof(model), required: true);
            SourceExpression.Validate(bodyprompttext, nameof(bodyprompttext), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:countTextTokens", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(model, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var promptObject = new JObject();
                var promptObjectpropCount = 0;
                if (bodyprompttext != null)
                {
                    promptObject["text"] = SourceExpressionConverter.ConvertToken(bodyprompttext);
                    promptObjectpropCount++;
                }

                if (promptObjectpropCount > 0)
                {
                    body["prompt"] = promptObject;
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> CountMessageTokens([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<bodypromptmessagesInputItem[]> bodypromptmessages = null)
        {
            SourceExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            SourceExpression.Validate(model, nameof(model), required: true);
            SourceExpression.Validate(bodypromptmessages, nameof(bodypromptmessages), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:countMessageTokens", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(model, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var promptObject = new JObject();
                var promptObjectpropCount = 0;
                if (bodypromptmessages != null)
                {
                    promptObject["messages"] = SourceExpressionConverter.ConvertToken(bodypromptmessages);
                    promptObjectpropCount++;
                }

                if (promptObjectpropCount > 0)
                {
                    body["prompt"] = promptObject;
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<EmbedTextResponse> EmbedText([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<string> bodytext)
        {
            SourceExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            SourceExpression.Validate(model, nameof(model), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:embedText", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(model, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EmbedTextResponse>(BuildSourceInput);
        }
    }

    public class GooglepalmTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodypromptmessagesInputItem
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class EmbedTextResponse
    {
        [JsonProperty("embedding")]
        public EmbedTextResponseEmbeddingType Embedding { get; set; }
    }

    public class EmbedTextResponseEmbeddingType
    {
        [JsonProperty("value")]
        public double[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googlepalm;

    public partial class WorkflowManagedActions
    {
        public GooglepalmActions Googlepalm(string connectionId) => new GooglepalmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglepalmTriggers Googlepalm(string connectionId) => new GooglepalmTriggers(connectionId);
    }
}