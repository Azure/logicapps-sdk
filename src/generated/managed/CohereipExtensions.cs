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
        public IBodyWorkflowAction<EmbedPostResponse, ApiConnectionActionConfiguration> Embed(Expression<Func<EmbedPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<EmbedPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/embed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmbedPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<ClassifyPostResponse, ApiConnectionActionConfiguration> Classify(Expression<Func<ClassifyPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ClassifyPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/classify";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClassifyPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<TokenPostResponse, ApiConnectionActionConfiguration> Token(Expression<Func<TokenPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TokenPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tokenize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TokenPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<DetokenPostResponse, ApiConnectionActionConfiguration> Detoken(Expression<Func<DetokenPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DetokenPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/detokenize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DetokenPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<LanguagePostResponse, ApiConnectionActionConfiguration> Language(Expression<Func<LanguagePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<LanguagePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/detect-language";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LanguagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<ChatPostResponse, ApiConnectionActionConfiguration> Chat(Expression<Func<ChatPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ChatPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/chat";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ChatPostResponse>(callPayload);
            });
        }
    }

    public class CohereipTriggers([ConnectionName] string connectionId)
    {
    }

    public class EmbedPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("texts")]
        public string[] Texts { get; set; }

        [JsonProperty("embeddings")]
        public double[][] Embeddings { get; set; }

        [JsonProperty("meta")]
        public EmbedPostResponseMetaType Meta { get; set; }
    }

    public class EmbedPostResponseMetaType
    {
        [JsonProperty("api_version")]
        public EmbedPostResponseMetaTypeApiVersionType ApiVersion { get; set; }
    }

    public class EmbedPostResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }
    }

    public class EmbedPostInput
    {
        [JsonProperty("texts")]
        public string[] Texts { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmbedPostInputModelType? Model { get; set; } = EmbedPostInputModelType.Large;

        [JsonProperty("truncate")]
        public EmbedPostInputTruncateType? Truncate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EmbedPostInputModelType
    {
        [EnumMember(Value = "large")]
        Large,
        [EnumMember(Value = "small")]
        Small
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EmbedPostInputTruncateType
    {
        NONE,
        START,
        END
    }

    public class ClassifyPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("classifications")]
        public ClassifyPostResponseClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("meta")]
        public ClassifyPostResponseMetaType Meta { get; set; }
    }

    public class ClassifyPostResponseClassificationsTypeItem
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
        public ClassifyPostResponseClassificationsTypeItemConfidencesTypeItem[] Confidences { get; set; }

        [JsonProperty("labels")]
        public ClassifyPostResponseClassificationsTypeItemLabelsType Labels { get; set; }
    }

    public class ClassifyPostResponseClassificationsTypeItemConfidencesTypeItem
    {
        [JsonProperty("option")]
        public string Option { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class ClassifyPostResponseClassificationsTypeItemLabelsType
    {
        [JsonProperty("Not spam")]
        public ClassifyPostResponseClassificationsTypeItemLabelsTypeNotSpamType NotSpam { get; set; }
        public ClassifyPostResponseClassificationsTypeItemLabelsTypeSpamType Spam { get; set; }
    }

    public class ClassifyPostResponseClassificationsTypeItemLabelsTypeNotSpamType
    {
        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class ClassifyPostResponseClassificationsTypeItemLabelsTypeSpamType
    {
        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class ClassifyPostResponseMetaType
    {
        [JsonProperty("api_version")]
        public ClassifyPostResponseMetaTypeApiVersionType ApiVersion { get; set; }
    }

    public class ClassifyPostResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }
    }

    public class ClassifyPostInput
    {
        [JsonProperty("inputs")]
        public string[] Inputs { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public ClassifyPostInputModelType? Model { get; set; } = ClassifyPostInputModelType.Large;

        [JsonProperty("examples")]
        public ClassifyPostInputExamplesTypeItem[] Examples { get; set; }

        [JsonProperty("preset")]
        public string Preset { get; set; }

        [JsonProperty("truncate")]
        public ClassifyPostInputTruncateType? Truncate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ClassifyPostInputModelType
    {
        [EnumMember(Value = "large")]
        Large,
        [EnumMember(Value = "small")]
        Small,
        [EnumMember(Value = "multilingual-22-12")]
        Multilingual2212
    }

    public class ClassifyPostInputExamplesTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ClassifyPostInputTruncateType
    {
        NONE,
        START,
        END
    }

    public class TokenPostResponse
    {
        [JsonProperty("tokens")]
        public int[] Tokens { get; set; }

        [JsonProperty("token_strings")]
        public string[] TokenStrings { get; set; }

        [JsonProperty("meta")]
        public TokenPostResponseMetaType Meta { get; set; }
    }

    public class TokenPostResponseMetaType
    {
        [JsonProperty("api_version")]
        public TokenPostResponseMetaTypeApiVersionType ApiVersion { get; set; }
    }

    public class TokenPostResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }
    }

    public class TokenPostInput
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DetokenPostResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("meta")]
        public DetokenPostResponseMetaType Meta { get; set; }
    }

    public class DetokenPostResponseMetaType
    {
        [JsonProperty("api_version")]
        public DetokenPostResponseMetaTypeApiVersionType ApiVersion { get; set; }
    }

    public class DetokenPostResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }
    }

    public class DetokenPostInput
    {
        [JsonProperty("tokens")]
        public int[] Tokens { get; set; }
    }

    public class LanguagePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("results")]
        public LanguagePostResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("meta")]
        public LanguagePostResponseMetaType Meta { get; set; }
    }

    public class LanguagePostResponseResultsTypeItem
    {
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("language_name")]
        public string LanguageName { get; set; }
    }

    public class LanguagePostResponseMetaType
    {
        [JsonProperty("api_version")]
        public LanguagePostResponseMetaTypeApiVersionType ApiVersion { get; set; }
    }

    public class LanguagePostResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }
    }

    public class LanguagePostInput
    {
        [JsonProperty("texts")]
        public string[] Texts { get; set; }
    }

    public class ChatPostResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("generation_id")]
        public string GenerationId { get; set; }

        [JsonProperty("citations")]
        public ChatPostResponseCitationsTypeItem[] Citations { get; set; }

        [JsonProperty("documents")]
        public ChatPostResponseDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("is_search_required")]
        public bool IsSearchRequired { get; set; }

        [JsonProperty("search_queries")]
        public ChatPostResponseSearchQueriesTypeItem[] SearchQueries { get; set; }

        [JsonProperty("search_results")]
        public ChatPostResponseSearchResultsTypeItem[] SearchResults { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("tool_calls")]
        public ChatPostResponseToolCallsTypeItem[] ToolCalls { get; set; }

        [JsonProperty("chat_history")]
        public ChatPostResponseChatHistoryTypeItem[] ChatHistory { get; set; }

        [JsonProperty("meta")]
        public ChatPostResponseMetaType Meta { get; set; }
    }

    public class ChatPostResponseCitationsTypeItem
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

    public class ChatPostResponseDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("additionalProp")]
        public string AdditionalProp { get; set; }
    }

    public class ChatPostResponseSearchQueriesTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("generation_id")]
        public string GenerationId { get; set; }
    }

    public class ChatPostResponseSearchResultsTypeItem
    {
        [JsonProperty("search_query")]
        public ChatPostResponseSearchResultsTypeItemSearchQueryType SearchQuery { get; set; }

        [JsonProperty("connector")]
        public ChatPostResponseSearchResultsTypeItemConnectorType Connector { get; set; }

        [JsonProperty("document_ids")]
        public string[] DocumentIds { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("continue_on_failure")]
        public bool ContinueOnFailure { get; set; }
    }

    public class ChatPostResponseSearchResultsTypeItemSearchQueryType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("generation_id")]
        public string GenerationId { get; set; }
    }

    public class ChatPostResponseSearchResultsTypeItemConnectorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ChatPostResponseToolCallsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parameters")]
        public ChatPostResponseToolCallsTypeItemParametersType Parameters { get; set; }
    }

    public class ChatPostResponseToolCallsTypeItemParametersType
    {
        [JsonProperty("additionalProp")]
        public JToken AdditionalProp { get; set; }
    }

    public class ChatPostResponseChatHistoryTypeItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ChatPostResponseMetaType
    {
        [JsonProperty("api_version")]
        public ChatPostResponseMetaTypeApiVersionType ApiVersion { get; set; }

        [JsonProperty("billed_units")]
        public ChatPostResponseMetaTypeBilledUnitsType BilledUnits { get; set; }

        [JsonProperty("tokens")]
        public ChatPostResponseMetaTypeTokensType Tokens { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class ChatPostResponseMetaTypeApiVersionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_deprecated")]
        public bool IsDeprecated { get; set; }

        [JsonProperty("is_experimental")]
        public bool IsExperimental { get; set; }
    }

    public class ChatPostResponseMetaTypeBilledUnitsType
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

    public class ChatPostResponseMetaTypeTokensType
    {
        [JsonProperty("input_tokens")]
        public int InputTokens { get; set; }

        [JsonProperty("output_tokens")]
        public int OutputTokens { get; set; }
    }

    public class ChatPostInput
    {
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Model { get; set; } = "command-r-plus";

        [JsonProperty("preamble")]
        public string Preamble { get; set; }

        [JsonProperty("chat_history")]
        public ChatPostInputChatHistoryTypeItem[] ChatHistory { get; set; }

        [JsonProperty("conversation_id")]
        public string ConversationId { get; set; }

        [JsonProperty("prompt_truncation")]
        public ChatPostInputPromptTruncationType? PromptTruncation { get; set; }

        [JsonProperty("connectors")]
        public ChatPostInputConnectorsTypeItem[] Connectors { get; set; }

        [JsonProperty("search_queries_only")]
        public bool? SearchQueriesOnly { get; set; }

        [JsonProperty("documents")]
        public ChatPostInputDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("citation_quality")]
        public ChatPostInputCitationQualityType? CitationQuality { get; set; }

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
        public ChatPostInputToolsTypeItem[] Tools { get; set; }
    }

    public class ChatPostInputChatHistoryTypeItem
    {
        [JsonProperty("role")]
        public ChatPostInputChatHistoryTypeItemRoleType? Role { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChatPostInputChatHistoryTypeItemRoleType
    {
        CHATBOT,
        SYSTEM,
        USER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChatPostInputPromptTruncationType
    {
        AUTO,
        [EnumMember(Value = "AUTO_PRESERVE_ORDER")]
        AUTOPRESERVEORDER,
        OFF
    }

    public class ChatPostInputConnectorsTypeItem
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

    public class ChatPostInputDocumentsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChatPostInputCitationQualityType
    {
        [EnumMember(Value = "accurate")]
        Accurate,
        [EnumMember(Value = "fast")]
        Fast
    }

    public class ChatPostInputToolsTypeItem
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