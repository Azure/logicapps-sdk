//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cohereip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CohereipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<EmbedPostResponse> EmbedPost(Expression<Func<string[]>> bodytexts = null, Expression<Func<bodymodelInput>> bodymodel = null, Expression<Func<bodytruncateInput>> bodytruncate = null)
        {
            var apiCallPath = "/embed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytexts != null)
            {
                body["texts"] = ExpressionConverter.ConvertO(bodytexts);
                bodypropCount++;
            }

            if (bodymodel != null)
            {
                body["model"] = ExpressionConverter.ConvertO(bodymodel);
                bodypropCount++;
            }

            if (bodytruncate != null)
            {
                body["truncate"] = ExpressionConverter.ConvertO(bodytruncate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EmbedPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<ClassifyPostResponse> ClassifyPost(Expression<Func<string[]>> bodyinputs = null, Expression<Func<bodymodelInput>> bodymodel = null, Expression<Func<bodyexamplesInputItem[]>> bodyexamples = null, Expression<Func<string>> bodypreset = null, Expression<Func<bodytruncateInput>> bodytruncate = null)
        {
            var apiCallPath = "/classify";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                bodypropCount++;
            }

            if (bodymodel != null)
            {
                body["model"] = ExpressionConverter.ConvertO(bodymodel);
                bodypropCount++;
            }

            if (bodyexamples != null)
            {
                body["examples"] = ExpressionConverter.ConvertO(bodyexamples);
                bodypropCount++;
            }

            if (bodypreset != null)
            {
                body["preset"] = ExpressionConverter.ConvertO(bodypreset);
                bodypropCount++;
            }

            if (bodytruncate != null)
            {
                body["truncate"] = ExpressionConverter.ConvertO(bodytruncate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ClassifyPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<TokenPostResponse> TokenPost(Expression<Func<string>> bodytext = null)
        {
            var apiCallPath = "/tokenize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytext != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TokenPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<DetokenPostResponse> DetokenPost(Expression<Func<int[]>> bodytokens = null)
        {
            var apiCallPath = "/detokenize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytokens != null)
            {
                body["tokens"] = ExpressionConverter.ConvertO(bodytokens);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DetokenPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<LanguagePostResponse> LanguagePost(Expression<Func<string[]>> bodytexts = null)
        {
            var apiCallPath = "/detect-language";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytexts != null)
            {
                body["texts"] = ExpressionConverter.ConvertO(bodytexts);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LanguagePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<ChatPostResponse> ChatPost(Expression<Func<string>> bodymessage, Expression<Func<string>> bodymodel = null, Expression<Func<string>> bodypreamble = null, Expression<Func<bodychatHistoryInputItem[]>> bodychatHistory = null, Expression<Func<string>> bodyconversationId = null, Expression<Func<bodypromptTruncationInput>> bodypromptTruncation = null, Expression<Func<bodyconnectorsInputItem[]>> bodyconnectors = null, Expression<Func<bool>> bodysearchQueriesOnly = null, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null, Expression<Func<bodycitationQualityInput>> bodycitationQuality = null, Expression<Func<double>> bodytemperature = null, Expression<Func<int>> bodymaxTokens = null, Expression<Func<int>> bodymaxInputTokens = null, Expression<Func<int>> bodyk = null, Expression<Func<double>> bodyp = null, Expression<Func<double>> bodyseed = null, Expression<Func<string[]>> bodystopSequences = null, Expression<Func<double>> bodyfrequencyPenalty = null, Expression<Func<double>> bodypresencePenalty = null, Expression<Func<bodytoolsInputItem[]>> bodytools = null)
        {
            var apiCallPath = "/v1/chat";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["message"] = ExpressionConverter.ConvertO(bodymessage);
            if (bodymodel != null)
            {
                body["model"] = ExpressionConverter.ConvertO(bodymodel);
                bodypropCount++;
            }

            if (bodypreamble != null)
            {
                body["preamble"] = ExpressionConverter.ConvertO(bodypreamble);
                bodypropCount++;
            }

            if (bodychatHistory != null)
            {
                body["chat_history"] = ExpressionConverter.ConvertO(bodychatHistory);
                bodypropCount++;
            }

            if (bodyconversationId != null)
            {
                body["conversation_id"] = ExpressionConverter.ConvertO(bodyconversationId);
                bodypropCount++;
            }

            if (bodypromptTruncation != null)
            {
                body["prompt_truncation"] = ExpressionConverter.ConvertO(bodypromptTruncation);
                bodypropCount++;
            }

            if (bodyconnectors != null)
            {
                body["connectors"] = ExpressionConverter.ConvertO(bodyconnectors);
                bodypropCount++;
            }

            if (bodysearchQueriesOnly != null)
            {
                body["search_queries_only"] = ExpressionConverter.ConvertO(bodysearchQueriesOnly);
                bodypropCount++;
            }

            if (bodydocuments != null)
            {
                body["documents"] = ExpressionConverter.ConvertO(bodydocuments);
                bodypropCount++;
            }

            if (bodycitationQuality != null)
            {
                body["citation_quality"] = ExpressionConverter.ConvertO(bodycitationQuality);
                bodypropCount++;
            }

            if (bodytemperature != null)
            {
                body["temperature"] = ExpressionConverter.ConvertO(bodytemperature);
                bodypropCount++;
            }

            if (bodymaxTokens != null)
            {
                body["max_tokens"] = ExpressionConverter.ConvertO(bodymaxTokens);
                bodypropCount++;
            }

            if (bodymaxInputTokens != null)
            {
                body["max_input_tokens"] = ExpressionConverter.ConvertO(bodymaxInputTokens);
                bodypropCount++;
            }

            if (bodyk != null)
            {
                body["k"] = ExpressionConverter.ConvertO(bodyk);
                bodypropCount++;
            }

            if (bodyp != null)
            {
                body["p"] = ExpressionConverter.ConvertO(bodyp);
                bodypropCount++;
            }

            if (bodyseed != null)
            {
                body["seed"] = ExpressionConverter.ConvertO(bodyseed);
                bodypropCount++;
            }

            if (bodystopSequences != null)
            {
                body["stop_sequences"] = ExpressionConverter.ConvertO(bodystopSequences);
                bodypropCount++;
            }

            if (bodyfrequencyPenalty != null)
            {
                body["frequency_penalty"] = ExpressionConverter.ConvertO(bodyfrequencyPenalty);
                bodypropCount++;
            }

            if (bodypresencePenalty != null)
            {
                body["presence_penalty"] = ExpressionConverter.ConvertO(bodypresencePenalty);
                bodypropCount++;
            }

            if (bodytools != null)
            {
                body["tools"] = ExpressionConverter.ConvertO(bodytools);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ChatPostResponse>(callPayload);
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

    public enum bodymodelInput
    {
        [EnumMember(Value = "large")]
        Large,
        [EnumMember(Value = "small")]
        Small,
        [EnumMember(Value = "multilingual-22-12")]
        Multilingual2212
    }

    public enum bodytruncateInput
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

    public class bodyexamplesInputItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
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

    public class bodychatHistoryInputItem
    {
        [JsonProperty("role")]
        public bodychatHistoryInputItemRoleType Role { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public enum bodychatHistoryInputItemRoleType
    {
        CHATBOT,
        SYSTEM,
        USER
    }

    public enum bodypromptTruncationInput
    {
        AUTO,
        [EnumMember(Value = "AUTO_PRESERVE_ORDER")]
        AUTOPRESERVEORDER,
        OFF
    }

    public class bodyconnectorsInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user_access_token")]
        public string UserAccessToken { get; set; }

        [JsonProperty("continue_on_failure")]
        public bool ContinueOnFailure { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }
    }

    public class bodydocumentsInputItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public enum bodycitationQualityInput
    {
        [EnumMember(Value = "accurate")]
        Accurate,
        [EnumMember(Value = "fast")]
        Fast
    }

    public class bodytoolsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parameter_definitions")]
        public JToken ParameterDefinitions { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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