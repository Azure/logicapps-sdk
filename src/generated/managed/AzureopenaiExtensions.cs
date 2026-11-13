//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureopenai
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureopenaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureopenai")]
        public IBodyWorkflowAction<CreateChatCompletionResponse2024Feb15Preview, ApiConnectionActionConfiguration> ChatCompletionsCreate2024Feb15Preview(Expression<Func<string>> deploymentId, Expression<Func<string>> apiVersion, Expression<Func<ChatCompletionsCreate2024Feb15PreviewRequestBodyInput>> requestBody)
        {
            var __workflow_deploymentId = WorkflowExpression.Compile(deploymentId, nameof(deploymentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<CreateChatCompletionResponse2024Feb15Preview, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/2024-02-15-preview/deployments/{0}/chat/completions", __workflow_deploymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<CreateChatCompletionResponse2024Feb15Preview>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureopenai")]
        public IBodyWorkflowAction<ExtensionsChatCompletionsResponse, ApiConnectionActionConfiguration> ExtensionsChatCompletionsCreate(Expression<Func<string>> deploymentId, Expression<Func<string>> deploymentId2, Expression<Func<string>> apiVersion, Expression<Func<ExtensionsChatCompletionsCreateRequestBodyInput>> requestBody)
        {
            var __workflow_deploymentId = WorkflowExpression.Compile(deploymentId, nameof(deploymentId), required: true);
            var __workflow_deploymentId2 = WorkflowExpression.Compile(deploymentId2, nameof(deploymentId2), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<ExtensionsChatCompletionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/deployments/{0}/extensions/chat/completions", __workflow_deploymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["deploymentId"] = ExpressionConverter.Convert(__workflow_deploymentId2);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<ExtensionsChatCompletionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureopenai")]
        public IBodyWorkflowAction<GetSingleEmbeddingsResponse2024Feb15Preview, ApiConnectionActionConfiguration> SingleEmbeddingsCreate2024Feb15Preview(Expression<Func<string>> deploymentId, Expression<Func<string>> apiVersion, Expression<Func<SingleEmbeddingsCreate2024Feb15PreviewRequestBodyInput>> requestBody)
        {
            var __workflow_deploymentId = WorkflowExpression.Compile(deploymentId, nameof(deploymentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<GetSingleEmbeddingsResponse2024Feb15Preview, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/deployments/{0}/embeddings", __workflow_deploymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<GetSingleEmbeddingsResponse2024Feb15Preview>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureopenai")]
        public IBodyWorkflowAction<GetMultipleEmbeddingsResponse2024Feb15Preview, ApiConnectionActionConfiguration> MultipleEmbeddingsCreate2024Feb15Preview(Expression<Func<string>> deploymentId, Expression<Func<string>> apiVersion, Expression<Func<MultipleEmbeddingsCreate2024Feb15PreviewRequestBodyInput>> requestBody)
        {
            var __workflow_deploymentId = WorkflowExpression.Compile(deploymentId, nameof(deploymentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<GetMultipleEmbeddingsResponse2024Feb15Preview, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/deployments/{0}/multipleEmbeddings", __workflow_deploymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<GetMultipleEmbeddingsResponse2024Feb15Preview>(callPayload);
            });
        }
    }

    public class AzureopenaiTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateChatCompletionResponse2024Feb15Preview
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public ChatCompletionResponseObject2024Feb15Preview ObjectEntity { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("usage")]
        public CompletionUsage2024Feb15Preview Usage { get; set; }

        [JsonProperty("system_fingerprint")]
        public string SystemFingerprint { get; set; }

        [JsonProperty("prompt_filter_results")]
        public PromptFilterResult2024Feb15Preview[] PromptFilterResults { get; set; }

        [JsonProperty("choices")]
        public CreateChatCompletionResponse2024Feb15PreviewChoicesTypeItem[] Choices { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChatCompletionResponseObject2024Feb15Preview
    {
        [EnumMember(Value = "chat.completion")]
        ChatCompletion
    }

    public class CompletionUsage2024Feb15Preview
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class PromptFilterResult2024Feb15Preview
    {
        [JsonProperty("prompt_index")]
        public int PromptIndex { get; set; }

        [JsonProperty("content_filter_results")]
        public ContentFilterPromptResults2024Feb15Preview ContentFilterResults { get; set; }
    }

    public class ContentFilterPromptResults2024Feb15Preview
    {
        [JsonProperty("sexual")]
        public ContentFilterSeverityResult2024Feb15Preview Sexual { get; set; }

        [JsonProperty("violence")]
        public ContentFilterSeverityResult2024Feb15Preview Violence { get; set; }

        [JsonProperty("hate")]
        public ContentFilterSeverityResult2024Feb15Preview Hate { get; set; }

        [JsonProperty("self_harm")]
        public ContentFilterSeverityResult2024Feb15Preview SelfHarm { get; set; }

        [JsonProperty("profanity")]
        public ContentFilterDetectedResult2024Feb15Preview Profanity { get; set; }

        [JsonProperty("custom_blocklists")]
        public ContentFilterIdResult2024Feb15Preview[] CustomBlocklists { get; set; }

        [JsonProperty("error")]
        public ErrorBase2024Feb15Preview Error { get; set; }

        [JsonProperty("jailbreak")]
        public ContentFilterDetectedResult2024Feb15Preview Jailbreak { get; set; }
    }

    public class ContentFilterSeverityResult2024Feb15Preview
    {
        [JsonProperty("filtered")]
        public bool Filtered { get; set; }

        [JsonProperty("severity")]
        public ContentFilterSeverityResult2024Feb15PreviewSeverityType Severity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContentFilterSeverityResult2024Feb15PreviewSeverityType
    {
        [EnumMember(Value = "safe")]
        Safe,
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High
    }

    public class ContentFilterDetectedResult2024Feb15Preview
    {
        [JsonProperty("filtered")]
        public bool Filtered { get; set; }

        [JsonProperty("detected")]
        public bool Detected { get; set; }
    }

    public class ContentFilterIdResult2024Feb15Preview
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("filtered")]
        public bool Filtered { get; set; }
    }

    public class ErrorBase2024Feb15Preview
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CreateChatCompletionResponse2024Feb15PreviewChoicesTypeItem
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("message")]
        public ChatCompletionResponseMessage2024Feb15Preview Message { get; set; }

        [JsonProperty("content_filter_results")]
        public ContentFilterChoiceResults2024Feb15Preview ContentFilterResults { get; set; }

        [JsonProperty("logprobs")]
        public ChatCompletionChoiceLogProbs2024Feb15Preview Logprobs { get; set; }
    }

    public class ChatCompletionResponseMessage2024Feb15Preview
    {
        [JsonProperty("role")]
        public ChatCompletionResponseMessageRole2024Feb15Preview Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("context")]
        public AzureChatExtensionsMessageContext2024Feb15Preview Context { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChatCompletionResponseMessageRole2024Feb15Preview
    {
        [EnumMember(Value = "assistant")]
        Assistant
    }

    public class AzureChatExtensionsMessageContext2024Feb15Preview
    {
        [JsonProperty("citations")]
        public Citation2024Feb15Preview[] Citations { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }
    }

    public class Citation2024Feb15Preview
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("filepath")]
        public string Filepath { get; set; }

        [JsonProperty("chunk_id")]
        public string ChunkId { get; set; }
    }

    public class ContentFilterChoiceResults2024Feb15Preview
    {
        [JsonProperty("sexual")]
        public ContentFilterSeverityResult2024Feb15Preview Sexual { get; set; }

        [JsonProperty("violence")]
        public ContentFilterSeverityResult2024Feb15Preview Violence { get; set; }

        [JsonProperty("hate")]
        public ContentFilterSeverityResult2024Feb15Preview Hate { get; set; }

        [JsonProperty("self_harm")]
        public ContentFilterSeverityResult2024Feb15Preview SelfHarm { get; set; }

        [JsonProperty("profanity")]
        public ContentFilterDetectedResult2024Feb15Preview Profanity { get; set; }

        [JsonProperty("custom_blocklists")]
        public ContentFilterIdResult2024Feb15Preview[] CustomBlocklists { get; set; }

        [JsonProperty("error")]
        public ErrorBase2024Feb15Preview Error { get; set; }

        [JsonProperty("protected_material_text")]
        public ContentFilterDetectedResult2024Feb15Preview ProtectedMaterialText { get; set; }

        [JsonProperty("protected_material_code")]
        public ContentFilterDetectedWithCitationResult2024Feb15Preview ProtectedMaterialCode { get; set; }
    }

    public class ContentFilterDetectedWithCitationResult2024Feb15Preview
    {
        [JsonProperty("filtered")]
        public bool Filtered { get; set; }

        [JsonProperty("detected")]
        public bool Detected { get; set; }

        [JsonProperty("citation")]
        public ContentFilterDetectedWithCitationResult2024Feb15PreviewCitationType Citation { get; set; }
    }

    public class ContentFilterDetectedWithCitationResult2024Feb15PreviewCitationType
    {
        [JsonProperty("URL")]
        public string Url { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }
    }

    public class ChatCompletionChoiceLogProbs2024Feb15Preview
    {
        [JsonProperty("content")]
        public ChatCompletionTokenLogprob2024Feb15Preview[] Content { get; set; }
    }

    public class ChatCompletionTokenLogprob2024Feb15Preview
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("logprob")]
        public double Logprob { get; set; }

        [JsonProperty("bytes")]
        public int[] Bytes { get; set; }

        [JsonProperty("top_logprobs")]
        public ChatCompletionTokenLogprob2024Feb15PreviewTopLogprobsTypeItem[] TopLogprobs { get; set; }
    }

    public class ChatCompletionTokenLogprob2024Feb15PreviewTopLogprobsTypeItem
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("logprob")]
        public double Logprob { get; set; }

        [JsonProperty("bytes")]
        public int[] Bytes { get; set; }
    }

    public class ChatCompletionsCreate2024Feb15PreviewRequestBodyInput
    {
        public ChatCompletionsCreate2024Feb15PreviewRequestBodyInput(ChatCompletionRequestMessage2024Feb15Preview[] messages)
        {
            this.Messages = messages;
        }

        [JsonProperty("temperature", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Temperature { get; set; } = 1;

        [JsonProperty("top_p", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TopP { get; set; } = 1;

        [JsonProperty("stream", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Stream { get; set; } = false;

        [JsonProperty("stop", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Stop { get; set; } = null;

        [JsonProperty("max_tokens", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxTokens { get; set; } = 4096;

        [JsonProperty("presence_penalty", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? PresencePenalty { get; set; } = 0;

        [JsonProperty("frequency_penalty", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? FrequencyPenalty { get; set; } = 0;

        [JsonProperty("logit_bias")]
        public JToken LogitBias { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public ChatCompletionRequestMessage2024Feb15Preview[] Messages { get; set; }

        [JsonProperty("data_sources")]
        public AzureSearchChatExtensionConfiguration2024Feb15Preview[] DataSources { get; set; }

        [JsonProperty("n", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? N { get; set; } = 1;

        [JsonProperty("seed", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Seed { get; set; } = 0;

        [JsonProperty("logprobs", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Logprobs { get; set; } = false;

        [JsonProperty("top_logprobs")]
        public int? TopLogprobs { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestBodyInputResponseFormatType ResponseFormat { get; set; } = new RequestBodyInputResponseFormatType();
    }

    public class ChatCompletionRequestMessage2024Feb15Preview
    {
        public ChatCompletionRequestMessage2024Feb15Preview(ChatCompletionRequestMessageRole2024Feb15Preview role, string content)
        {
            this.Role = role;
            this.Content = content;
        }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public ChatCompletionRequestMessageRole2024Feb15Preview Role { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChatCompletionRequestMessageRole2024Feb15Preview
    {
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
    }

    public class AzureSearchChatExtensionConfiguration2024Feb15Preview
    {
        public AzureSearchChatExtensionConfiguration2024Feb15Preview(AzureChatExtensionType2024Feb15Preview type, AzureSearchChatExtensionParameters2024Feb15Preview parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public AzureChatExtensionType2024Feb15Preview Type { get; set; }

        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public AzureSearchChatExtensionParameters2024Feb15Preview Parameters { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AzureChatExtensionType2024Feb15Preview
    {
        [EnumMember(Value = "azure_search")]
        AzureSearch
    }

    public class AzureSearchChatExtensionParameters2024Feb15Preview
    {
        public AzureSearchChatExtensionParameters2024Feb15Preview(string indexName)
        {
            this.IndexName = indexName;
        }

        [JsonProperty("top_n_documents")]
        public int? TopNDocuments { get; set; }

        [JsonProperty("in_scope")]
        public bool? InScope { get; set; }

        [JsonProperty("strictness")]
        public int? Strictness { get; set; }

        [JsonProperty("role_information")]
        public string RoleInformation { get; set; }

        [JsonProperty("index_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IndexName { get; set; }

        [JsonProperty("fields_mapping")]
        public AzureSearchIndexFieldMappingOptions2024Feb15Preview FieldsMapping { get; set; }

        [JsonProperty("query_type")]
        public AzureSearchQueryType2024Feb15Preview? QueryType { get; set; }

        [JsonProperty("semantic_configuration")]
        public string SemanticConfiguration { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("embedding_dependency")]
        public OnYourDataDeploymentNameVectorizationSource2024Feb15Preview EmbeddingDependency { get; set; }
    }

    public class AzureSearchIndexFieldMappingOptions2024Feb15Preview
    {
        [JsonProperty("title_field")]
        public string TitleField { get; set; }

        [JsonProperty("url_field")]
        public string UrlField { get; set; }

        [JsonProperty("filepath_field")]
        public string FilepathField { get; set; }

        [JsonProperty("content_fields")]
        public string[] ContentFields { get; set; }

        [JsonProperty("content_fields_separator")]
        public string ContentFieldsSeparator { get; set; }

        [JsonProperty("vector_fields")]
        public string[] VectorFields { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AzureSearchQueryType2024Feb15Preview
    {
        [EnumMember(Value = "simple")]
        Simple,
        [EnumMember(Value = "semantic")]
        Semantic,
        [EnumMember(Value = "vector")]
        Vector,
        [EnumMember(Value = "vector_simple_hybrid")]
        VectorSimpleHybrid,
        [EnumMember(Value = "vector_semantic_hybrid")]
        VectorSemanticHybrid
    }

    public class OnYourDataDeploymentNameVectorizationSource2024Feb15Preview
    {
        public OnYourDataDeploymentNameVectorizationSource2024Feb15Preview(string deploymentName)
        {
            this.DeploymentName = deploymentName;
        }

        [JsonProperty("type")]
        public OnYourDataVectorizationSourceType2024Feb15Preview? Type { get; set; }

        [JsonProperty("deployment_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeploymentName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OnYourDataVectorizationSourceType2024Feb15Preview
    {
        [EnumMember(Value = "deployment_name")]
        DeploymentName
    }

    public class RequestBodyInputResponseFormatType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public ChatCompletionResponseFormat2024Feb15Preview? Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Azureopenai.ChatCompletionResponseFormat2024Feb15Preview.Text;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChatCompletionResponseFormat2024Feb15Preview
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "json_object")]
        JsonObject
    }

    public class ExtensionsChatCompletionsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("prompt_filter_results")]
        public PromptFilterResult[] PromptFilterResults { get; set; }

        [JsonProperty("usage")]
        public ExtensionsChatCompletionsResponseUsageType Usage { get; set; }

        [JsonProperty("choices")]
        public ExtensionsChatCompletionChoice[] Choices { get; set; }
    }

    public class PromptFilterResult
    {
        [JsonProperty("prompt_index")]
        public int PromptIndex { get; set; }

        [JsonProperty("content_filter_results")]
        public ContentFilterResults ContentFilterResults { get; set; }
    }

    public class ContentFilterResults
    {
        [JsonProperty("sexual")]
        public ContentFilterResult Sexual { get; set; }

        [JsonProperty("violence")]
        public ContentFilterResult Violence { get; set; }

        [JsonProperty("hate")]
        public ContentFilterResult Hate { get; set; }

        [JsonProperty("self_harm")]
        public ContentFilterResult SelfHarm { get; set; }

        [JsonProperty("error")]
        public ErrorBase Error { get; set; }
    }

    public class ContentFilterResult
    {
        [JsonProperty("severity")]
        public ContentFilterResultSeverityType Severity { get; set; }

        [JsonProperty("filtered")]
        public bool Filtered { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContentFilterResultSeverityType
    {
        [EnumMember(Value = "safe")]
        Safe,
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High
    }

    public class ErrorBase
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ExtensionsChatCompletionsResponseUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class ExtensionsChatCompletionChoice
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("content_filter_results")]
        public ContentFilterResults ContentFilterResults { get; set; }

        [JsonProperty("messages")]
        public ExtensionsChatCompletionsCreateMessageResponse[] Messages { get; set; }
    }

    public class ExtensionsChatCompletionsCreateMessageResponse
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("role")]
        public ExtensionsChatCompletionsCreateMessageRoleTypeResponse Role { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("end_turn")]
        public bool EndTurn { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtensionsChatCompletionsCreateMessageRoleTypeResponse
    {
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant,
        [EnumMember(Value = "tool")]
        Tool
    }

    public class ExtensionsChatCompletionsCreateRequestBodyInput
    {
        public ExtensionsChatCompletionsCreateRequestBodyInput(ExtensionsChatCompletionsCreateMessage[] messages)
        {
            this.Messages = messages;
        }

        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtensionsChatCompletionsCreateMessage[] Messages { get; set; }

        [JsonProperty("dataSources")]
        public DataSource[] DataSources { get; set; }

        [JsonProperty("temperature", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Temperature { get; set; } = 1;

        [JsonProperty("top_p", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TopP { get; set; } = 1;

        [JsonProperty("stream", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Stream { get; set; } = false;

        [JsonProperty("stop", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Stop { get; set; } = null;

        [JsonProperty("max_tokens", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxTokens { get; set; } = 250;

        [JsonProperty("presence_penalty", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? PresencePenalty { get; set; } = 0;

        [JsonProperty("frequency_penalty", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? FrequencyPenalty { get; set; } = 0;

        [JsonProperty("logit_bias")]
        public JToken LogitBias { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class ExtensionsChatCompletionsCreateMessage
    {
        public ExtensionsChatCompletionsCreateMessage(ExtensionsChatCompletionsCreateMessageRoleType role, string content)
        {
            this.Role = role;
            this.Content = content;
        }

        [JsonProperty("index")]
        public int? Index { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtensionsChatCompletionsCreateMessageRoleType Role { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("end_turn")]
        public bool? EndTurn { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtensionsChatCompletionsCreateMessageRoleType
    {
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant,
        [EnumMember(Value = "tool")]
        Tool
    }

    public class DataSource
    {
        public DataSource(string type)
        {
            this.Type = type;
        }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("parameters")]
        public JToken Parameters { get; set; }
    }

    public class GetSingleEmbeddingsResponse2024Feb15Preview
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("embedding")]
        public double[] Embedding { get; set; }

        [JsonProperty("usage")]
        public GetSingleEmbeddingsResponse2024Feb15PreviewUsageType Usage { get; set; }
    }

    public class GetSingleEmbeddingsResponse2024Feb15PreviewUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class SingleEmbeddingsCreate2024Feb15PreviewRequestBodyInput
    {
        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Input { get; set; } = "";

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("input_type")]
        public string InputType { get; set; }
    }

    public class GetMultipleEmbeddingsResponse2024Feb15Preview
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("embeddings")]
        public double[][] Embeddings { get; set; }

        [JsonProperty("usage")]
        public GetMultipleEmbeddingsResponse2024Feb15PreviewUsageType Usage { get; set; }
    }

    public class GetMultipleEmbeddingsResponse2024Feb15PreviewUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class MultipleEmbeddingsCreate2024Feb15PreviewRequestBodyInput
    {
        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Input { get; set; } = new string[]
        {
        };

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("input_type")]
        public string InputType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureopenai;

    public partial class WorkflowManagedActions
    {
        public AzureopenaiActions Azureopenai(string connectionId) => new AzureopenaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureopenaiTriggers Azureopenai(string connectionId) => new AzureopenaiTriggers(connectionId);
    }
}