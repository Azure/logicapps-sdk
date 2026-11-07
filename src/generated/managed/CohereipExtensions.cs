//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cohereip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CohereipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<EmbedResponse, ApiConnectionActionConfiguration> Embed(Expression<Func<EmbedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<EmbedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/embed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmbedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<ClassifyResponse, ApiConnectionActionConfiguration> Classify(Expression<Func<ClassifyBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ClassifyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/classify";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClassifyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<TokenResponse, ApiConnectionActionConfiguration> Token(Expression<Func<TokenBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TokenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tokenize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TokenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<DetokenResponse, ApiConnectionActionConfiguration> Detoken(Expression<Func<DetokenBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DetokenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/detokenize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DetokenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<LanguageResponse, ApiConnectionActionConfiguration> Language(Expression<Func<LanguageBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<LanguageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/detect-language";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LanguageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<ChatResponse, ApiConnectionActionConfiguration> Chat(Expression<Func<ChatBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ChatResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/chat";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ChatResponse>(callPayload);
            });
        }
    }

    public class CohereipTriggers([ConnectionName] string connectionId)
    {
    }

    public class EmbedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("texts")]
        public string[] Texts { get; set; }

        [JsonProperty("embeddings")]
        public double[][] Embeddings { get; set; }

        [JsonProperty("meta")]
        public EmbedResponseMetaType Meta { get; set; }
    }

    public class EmbedResponseMetaType
    {
        [JsonProperty("api_version")]
        public EmbedResponseMetaTypeApiVersionType ApiVersion { get; set; }
    }

    public class EmbedResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }
    }

    public class EmbedBodyInput
    {
        [JsonProperty("texts")]
        public string[] Texts { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmbedBodyInputModelType? Model { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Cohereip.EmbedBodyInputModelType.Large;

        [JsonProperty("truncate")]
        public BodyInputTruncateType? Truncate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EmbedBodyInputModelType
    {
        [EnumMember(Value = "large")]
        Large,
        [EnumMember(Value = "small")]
        Small
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTruncateType
    {
        NONE,
        START,
        END
    }

    public class ClassifyResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("classifications")]
        public ClassifyResponseClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("meta")]
        public ClassifyResponseMetaType Meta { get; set; }
    }

    public class ClassifyResponseClassificationsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("input")]
        public string Input { get; set; }

        [JsonProperty("prediction")]
        public string Prediction { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("confidences")]
        public ClassifyResponseClassificationsTypeItemConfidencesTypeItem[] Confidences { get; set; }

        [JsonProperty("labels")]
        public ClassifyResponseClassificationsTypeItemLabelsType Labels { get; set; }
    }

    public class ClassifyResponseClassificationsTypeItemConfidencesTypeItem
    {
        [JsonProperty("option")]
        public string Option { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class ClassifyResponseClassificationsTypeItemLabelsType
    {
        [JsonProperty("Not spam")]
        public ClassifyResponseClassificationsTypeItemLabelsTypeNotSpamType NotSpam { get; set; }
        public ClassifyResponseClassificationsTypeItemLabelsTypeSpamType Spam { get; set; }
    }

    public class ClassifyResponseClassificationsTypeItemLabelsTypeNotSpamType
    {
        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class ClassifyResponseClassificationsTypeItemLabelsTypeSpamType
    {
        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class ClassifyResponseMetaType
    {
        [JsonProperty("api_version")]
        public ClassifyResponseMetaTypeApiVersionType ApiVersion { get; set; }
    }

    public class ClassifyResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }
    }

    public class ClassifyBodyInput
    {
        [JsonProperty("inputs")]
        public string[] Inputs { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public ClassifyBodyInputModelType? Model { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Cohereip.ClassifyBodyInputModelType.Large;

        [JsonProperty("examples")]
        public BodyInputExamplesTypeItem[] Examples { get; set; }

        [JsonProperty("preset")]
        public string Preset { get; set; }

        [JsonProperty("truncate")]
        public BodyInputTruncateType? Truncate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ClassifyBodyInputModelType
    {
        [EnumMember(Value = "large")]
        Large,
        [EnumMember(Value = "small")]
        Small,
        [EnumMember(Value = "multilingual-22-12")]
        Multilingual2212
    }

    public class BodyInputExamplesTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class TokenResponse
    {
        [JsonProperty("tokens")]
        public int[] Tokens { get; set; }

        [JsonProperty("token_strings")]
        public string[] TokenStrings { get; set; }

        [JsonProperty("meta")]
        public TokenResponseMetaType Meta { get; set; }
    }

    public class TokenResponseMetaType
    {
        [JsonProperty("api_version")]
        public TokenResponseMetaTypeApiVersionType ApiVersion { get; set; }
    }

    public class TokenResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }
    }

    public class TokenBodyInput
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DetokenResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("meta")]
        public DetokenResponseMetaType Meta { get; set; }
    }

    public class DetokenResponseMetaType
    {
        [JsonProperty("api_version")]
        public DetokenResponseMetaTypeApiVersionType ApiVersion { get; set; }
    }

    public class DetokenResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }
    }

    public class DetokenBodyInput
    {
        [JsonProperty("tokens")]
        public int[] Tokens { get; set; }
    }

    public class LanguageResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("results")]
        public LanguageResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("meta")]
        public LanguageResponseMetaType Meta { get; set; }
    }

    public class LanguageResponseResultsTypeItem
    {
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("language_name")]
        public string LanguageName { get; set; }
    }

    public class LanguageResponseMetaType
    {
        [JsonProperty("api_version")]
        public LanguageResponseMetaTypeApiVersionType ApiVersion { get; set; }
    }

    public class LanguageResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }
    }

    public class LanguageBodyInput
    {
        [JsonProperty("texts")]
        public string[] Texts { get; set; }
    }

    public class ChatResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("generation_id")]
        public string GenerationId { get; set; }

        [JsonProperty("citations")]
        public ChatResponseCitationsTypeItem[] Citations { get; set; }

        [JsonProperty("documents")]
        public ChatResponseDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("is_search_required")]
        public bool IsSearchRequired { get; set; }

        [JsonProperty("search_queries")]
        public ChatResponseSearchQueriesTypeItem[] SearchQueries { get; set; }

        [JsonProperty("search_results")]
        public ChatResponseSearchResultsTypeItem[] SearchResults { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("tool_calls")]
        public ChatResponseToolCallsTypeItem[] ToolCalls { get; set; }

        [JsonProperty("chat_history")]
        public ChatResponseChatHistoryTypeItem[] ChatHistory { get; set; }

        [JsonProperty("meta")]
        public ChatResponseMetaType Meta { get; set; }
    }

    public class ChatResponseCitationsTypeItem
    {
        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("document_ids")]
        public string[] DocumentIds { get; set; }
    }

    public class ChatResponseDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("additionalProp")]
        public string AdditionalProp { get; set; }
    }

    public class ChatResponseSearchQueriesTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("generation_id")]
        public string GenerationId { get; set; }
    }

    public class ChatResponseSearchResultsTypeItem
    {
        [JsonProperty("search_query")]
        public ChatResponseSearchResultsTypeItemSearchQueryType SearchQuery { get; set; }

        [JsonProperty("connector")]
        public ChatResponseSearchResultsTypeItemConnectorType Connector { get; set; }

        [JsonProperty("document_ids")]
        public string[] DocumentIds { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("continue_on_failure")]
        public bool ContinueOnFailure { get; set; }
    }

    public class ChatResponseSearchResultsTypeItemSearchQueryType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("generation_id")]
        public string GenerationId { get; set; }
    }

    public class ChatResponseSearchResultsTypeItemConnectorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ChatResponseToolCallsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parameters")]
        public ChatResponseToolCallsTypeItemParametersType Parameters { get; set; }
    }

    public class ChatResponseToolCallsTypeItemParametersType
    {
        [JsonProperty("additionalProp")]
        public JToken AdditionalProp { get; set; }
    }

    public class ChatResponseChatHistoryTypeItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ChatResponseMetaType
    {
        [JsonProperty("api_version")]
        public ChatResponseMetaTypeApiVersionType ApiVersion { get; set; }

        [JsonProperty("billed_units")]
        public ChatResponseMetaTypeBilledUnitsType BilledUnits { get; set; }

        [JsonProperty("tokens")]
        public ChatResponseMetaTypeTokensType Tokens { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class ChatResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }

        [JsonProperty("is_experimental")]
        public bool IsExperimental { get; set; }
    }

    public class ChatResponseMetaTypeBilledUnitsType
    {
        [JsonProperty("input_tokens")]
        public int InputTokens { get; set; }

        [JsonProperty("output_tokens")]
        public int OutputTokens { get; set; }

        [JsonProperty("search_units")]
        public int SearchUnits { get; set; }

        [JsonProperty("classifications")]
        public int Classifications { get; set; }
    }

    public class ChatResponseMetaTypeTokensType
    {
        [JsonProperty("input_tokens")]
        public int InputTokens { get; set; }

        [JsonProperty("output_tokens")]
        public int OutputTokens { get; set; }
    }

    public class ChatBodyInput
    {
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Model { get; set; } = "command-r-plus";

        [JsonProperty("preamble")]
        public string Preamble { get; set; }

        [JsonProperty("chat_history")]
        public BodyInputChatHistoryTypeItem[] ChatHistory { get; set; }

        [JsonProperty("conversation_id")]
        public string ConversationId { get; set; }

        [JsonProperty("prompt_truncation")]
        public BodyInputPromptTruncationType? PromptTruncation { get; set; }

        [JsonProperty("connectors")]
        public BodyInputConnectorsTypeItem[] Connectors { get; set; }

        [JsonProperty("search_queries_only")]
        public bool? SearchQueriesOnly { get; set; }

        [JsonProperty("documents")]
        public BodyInputDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("citation_quality")]
        public BodyInputCitationQualityType? CitationQuality { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        [JsonProperty("max_input_tokens")]
        public int? MaxInputTokens { get; set; }

        [JsonProperty("k")]
        public int? K { get; set; }

        [JsonProperty("p")]
        public double? P { get; set; }

        [JsonProperty("seed")]
        public double? Seed { get; set; }

        [JsonProperty("stop_sequences")]
        public string[] StopSequences { get; set; }

        [JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        [JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        [JsonProperty("tools")]
        public BodyInputToolsTypeItem[] Tools { get; set; }
    }

    public class BodyInputChatHistoryTypeItem
    {
        [JsonProperty("role")]
        public BodyInputChatHistoryTypeItemRoleType? Role { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputChatHistoryTypeItemRoleType
    {
        CHATBOT,
        SYSTEM,
        USER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPromptTruncationType
    {
        AUTO,
        [EnumMember(Value = "AUTO_PRESERVE_ORDER")]
        AUTOPRESERVEORDER,
        OFF
    }

    public class BodyInputConnectorsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user_access_token")]
        public string UserAccessToken { get; set; }

        [JsonProperty("continue_on_failure")]
        public bool? ContinueOnFailure { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }
    }

    public class BodyInputDocumentsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCitationQualityType
    {
        [EnumMember(Value = "accurate")]
        Accurate,
        [EnumMember(Value = "fast")]
        Fast
    }

    public class BodyInputToolsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parameter_definitions")]
        public JToken ParameterDefinitions { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cohereip;

    public partial class WorkflowManagedActions
    {
        public CohereipActions Cohereip(string connectionId) => new CohereipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CohereipTriggers Cohereip(string connectionId) => new CohereipTriggers(connectionId);
    }
}