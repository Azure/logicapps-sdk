//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlepalm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglepalmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ListModels(Expression<Func<string>> aPIVersion, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageToken = null)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageToken = WorkflowExpression.Compile(pageToken, nameof(pageToken), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models", __workflow_aPIVersion.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageToken != null)
                    callPayload.Queries["pageToken"] = ExpressionConverter.Convert(__workflow_pageToken);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetModel(Expression<Func<string>> aPIVersion, Expression<Func<string>> name)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GenerateText(Expression<Func<string>> aPIVersion, Expression<Func<string>> modelType, Expression<Func<string>> modelName, Expression<Func<GenerateTextInput>> body)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_modelType = WorkflowExpression.Compile(modelType, nameof(modelType), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}:generateText", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_modelType.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GenerateMessage(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<GenerateMessageInput>> body)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:generateMessage", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CountTextTokens(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<CountTextTokensInput>> body)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:countTextTokens", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CountMessageTokens(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<CountMessageTokensInput>> body)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:countMessageTokens", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<EmbedTextResponse, ApiConnectionActionConfiguration> EmbedText(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<EmbedTextInput>> body)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EmbedTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:embedText", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmbedTextResponse>(callPayload);
            });
        }
    }

    public class GooglepalmTriggers([ConnectionName] string connectionId)
    {
    }

    public class GenerateTextInput
    {
        [JsonProperty("prompt")]
        public GenerateTextInputPromptType Prompt { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("candidateCount")]
        public int? CandidateCount { get; set; }

        [JsonProperty("maxOutputTokens")]
        public int? MaxOutputTokens { get; set; }

        [JsonProperty("topP")]
        public double? TopP { get; set; }

        [JsonProperty("topK")]
        public int? TopK { get; set; }

        [JsonProperty("safetySettings")]
        public JToken[] SafetySettings { get; set; }

        [JsonProperty("stopSequences")]
        public string[] StopSequences { get; set; }
    }

    public class GenerateTextInputPromptType
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }
    }

    public class GenerateMessageInput
    {
        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateMessageInputPromptType Prompt { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("topP")]
        public double? TopP { get; set; }

        [JsonProperty("topK")]
        public int? TopK { get; set; }
    }

    public class GenerateMessageInputPromptType
    {
        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateMessageInputPromptTypeMessagesTypeItem[] Messages { get; set; }
    }

    public class GenerateMessageInputPromptTypeMessagesTypeItem
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
    }

    public class CountTextTokensInput
    {
        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public CountTextTokensInputPromptType Prompt { get; set; }
    }

    public class CountTextTokensInputPromptType
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class CountMessageTokensInput
    {
        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public CountMessageTokensInputPromptType Prompt { get; set; }
    }

    public class CountMessageTokensInputPromptType
    {
        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public CountMessageTokensInputPromptTypeMessagesTypeItem[] Messages { get; set; }
    }

    public class CountMessageTokensInputPromptTypeMessagesTypeItem
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
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

    public class EmbedTextInput
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
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