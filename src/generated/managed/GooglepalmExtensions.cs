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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ListModels(Expression<Func<string>> apiVersion, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageToken = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageToken = WorkflowExpression.Compile(pageToken, nameof(pageToken), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models", __workflow_apiVersion.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetModel(Expression<Func<string>> apiVersion, Expression<Func<string>> name)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}", __workflow_apiVersion.WithUrlEncoding(1), __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GenerateText(Expression<Func<string>> apiVersion, Expression<Func<string>> modelType, Expression<Func<string>> modelName, Expression<Func<GenerateTextBodyInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelType = WorkflowExpression.Compile(modelType, nameof(modelType), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}:generateText", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelType.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GenerateMessage(Expression<Func<string>> apiVersion, Expression<Func<string>> model, Expression<Func<GenerateMessageBodyInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:generateMessage", __workflow_apiVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CountTextTokens(Expression<Func<string>> apiVersion, Expression<Func<string>> model, Expression<Func<CountTextTokensBodyInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:countTextTokens", __workflow_apiVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CountMessageTokens(Expression<Func<string>> apiVersion, Expression<Func<string>> model, Expression<Func<CountMessageTokensBodyInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:countMessageTokens", __workflow_apiVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<EmbedTextResponse, ApiConnectionActionConfiguration> EmbedText(Expression<Func<string>> apiVersion, Expression<Func<string>> model, Expression<Func<EmbedTextBodyInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EmbedTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:embedText", __workflow_apiVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
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

    public class GenerateTextBodyInput
    {
        [JsonProperty("prompt")]
        public GenerateTextBodyInputPromptType Prompt { get; set; }

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

    public class GenerateTextBodyInputPromptType
    {
        public GenerateTextBodyInputPromptType(string prompt)
        {
            this.Prompt = prompt;
        }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }
    }

    public class GenerateMessageBodyInput
    {
        public GenerateMessageBodyInput(CountMessageTokensBodyInputPromptType prompt)
        {
            this.Prompt = prompt;
        }

        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public CountMessageTokensBodyInputPromptType Prompt { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("topP")]
        public double? TopP { get; set; }

        [JsonProperty("topK")]
        public int? TopK { get; set; }
    }

    public class CountMessageTokensBodyInputPromptType
    {
        public CountMessageTokensBodyInputPromptType(BodyInputPromptTypeMessagesTypeItem[] messages)
        {
            this.Messages = messages;
        }

        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPromptTypeMessagesTypeItem[] Messages { get; set; }
    }

    public class BodyInputPromptTypeMessagesTypeItem
    {
        public BodyInputPromptTypeMessagesTypeItem(string content)
        {
            this.Content = content;
        }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
    }

    public class CountTextTokensBodyInput
    {
        public CountTextTokensBodyInput(CountTextTokensBodyInputPromptType prompt)
        {
            this.Prompt = prompt;
        }

        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public CountTextTokensBodyInputPromptType Prompt { get; set; }
    }

    public class CountTextTokensBodyInputPromptType
    {
        public CountTextTokensBodyInputPromptType(string text)
        {
            this.Text = text;
        }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class CountMessageTokensBodyInput
    {
        public CountMessageTokensBodyInput(CountMessageTokensBodyInputPromptType prompt)
        {
            this.Prompt = prompt;
        }

        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public CountMessageTokensBodyInputPromptType Prompt { get; set; }
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

    public class EmbedTextBodyInput
    {
        public EmbedTextBodyInput(string text)
        {
            this.Text = text;
        }

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