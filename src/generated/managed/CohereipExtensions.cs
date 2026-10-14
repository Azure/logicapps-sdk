//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cohereip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CohereipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<EmbedPostResponse> Embed(Expression<Func<string[]>> bodytexts = null, Expression<Func<bodymodelInput>> bodymodel = null, Expression<Func<bodytruncateInput>> bodytruncate = null)
        {
            var __workflow_bodytexts = bodytexts == null ? null : WorkflowExpression.Compile(bodytexts);
            WorkflowExpression.Validate(__workflow_bodytexts, nameof(bodytexts), required: false);
            var __workflow_bodymodel = bodymodel == null ? null : WorkflowExpression.Compile(bodymodel);
            WorkflowExpression.Validate(__workflow_bodymodel, nameof(bodymodel), required: false);
            var __workflow_bodytruncate = bodytruncate == null ? null : WorkflowExpression.Compile(bodytruncate);
            WorkflowExpression.Validate(__workflow_bodytruncate, nameof(bodytruncate), required: false);
            return new DeferredBodyAction<EmbedPostResponse>(() =>
            {
                var apiCallPath = "/embed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytexts != null)
                {
                    body["texts"] = ExpressionConverter.ConvertO(__workflow_bodytexts);
                    bodypropCount++;
                }

                if (__workflow_bodymodel != null)
                {
                    if (__workflow_bodymodel != null)
                    {
                        body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "large";
                    bodypropCount++;
                }

                if (__workflow_bodytruncate != null)
                {
                    body["truncate"] = ExpressionConverter.ConvertO(__workflow_bodytruncate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EmbedPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<ClassifyPostResponse> Classify(Expression<Func<string[]>> bodyinputs = null, Expression<Func<bodymodelInput>> bodymodel = null, Expression<Func<bodyexamplesInputItem[]>> bodyexamples = null, Expression<Func<string>> bodypreset = null, Expression<Func<bodytruncateInput>> bodytruncate = null)
        {
            var __workflow_bodyinputs = bodyinputs == null ? null : WorkflowExpression.Compile(bodyinputs);
            WorkflowExpression.Validate(__workflow_bodyinputs, nameof(bodyinputs), required: false);
            var __workflow_bodymodel = bodymodel == null ? null : WorkflowExpression.Compile(bodymodel);
            WorkflowExpression.Validate(__workflow_bodymodel, nameof(bodymodel), required: false);
            var __workflow_bodyexamples = bodyexamples == null ? null : WorkflowExpression.Compile(bodyexamples);
            WorkflowExpression.Validate(__workflow_bodyexamples, nameof(bodyexamples), required: false);
            var __workflow_bodypreset = bodypreset == null ? null : WorkflowExpression.Compile(bodypreset);
            WorkflowExpression.Validate(__workflow_bodypreset, nameof(bodypreset), required: false);
            var __workflow_bodytruncate = bodytruncate == null ? null : WorkflowExpression.Compile(bodytruncate);
            WorkflowExpression.Validate(__workflow_bodytruncate, nameof(bodytruncate), required: false);
            return new DeferredBodyAction<ClassifyPostResponse>(() =>
            {
                var apiCallPath = "/classify";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                    bodypropCount++;
                }

                if (__workflow_bodymodel != null)
                {
                    if (__workflow_bodymodel != null)
                    {
                        body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "large";
                    bodypropCount++;
                }

                if (__workflow_bodyexamples != null)
                {
                    body["examples"] = ExpressionConverter.ConvertO(__workflow_bodyexamples);
                    bodypropCount++;
                }

                if (__workflow_bodypreset != null)
                {
                    body["preset"] = ExpressionConverter.ConvertO(__workflow_bodypreset);
                    bodypropCount++;
                }

                if (__workflow_bodytruncate != null)
                {
                    body["truncate"] = ExpressionConverter.ConvertO(__workflow_bodytruncate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ClassifyPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<TokenPostResponse> Token(Expression<Func<string>> bodytext = null)
        {
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: false);
            return new DeferredBodyAction<TokenPostResponse>(() =>
            {
                var apiCallPath = "/tokenize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TokenPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<DetokenPostResponse> Detoken(Expression<Func<int[]>> bodytokens = null)
        {
            var __workflow_bodytokens = bodytokens == null ? null : WorkflowExpression.Compile(bodytokens);
            WorkflowExpression.Validate(__workflow_bodytokens, nameof(bodytokens), required: false);
            return new DeferredBodyAction<DetokenPostResponse>(() =>
            {
                var apiCallPath = "/detokenize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytokens != null)
                {
                    body["tokens"] = ExpressionConverter.ConvertO(__workflow_bodytokens);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DetokenPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<LanguagePostResponse> Language(Expression<Func<string[]>> bodytexts = null)
        {
            var __workflow_bodytexts = bodytexts == null ? null : WorkflowExpression.Compile(bodytexts);
            WorkflowExpression.Validate(__workflow_bodytexts, nameof(bodytexts), required: false);
            return new DeferredBodyAction<LanguagePostResponse>(() =>
            {
                var apiCallPath = "/detect-language";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytexts != null)
                {
                    body["texts"] = ExpressionConverter.ConvertO(__workflow_bodytexts);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LanguagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        public IBodyWorkflowAction<ChatPostResponse> Chat(Expression<Func<string>> bodymessage, Expression<Func<string>> bodymodel = null, Expression<Func<string>> bodypreamble = null, Expression<Func<bodychatHistoryInputItem[]>> bodychatHistory = null, Expression<Func<string>> bodyconversationId = null, Expression<Func<bodypromptTruncationInput>> bodypromptTruncation = null, Expression<Func<bodyconnectorsInputItem[]>> bodyconnectors = null, Expression<Func<bool>> bodysearchQueriesOnly = null, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null, Expression<Func<bodycitationQualityInput>> bodycitationQuality = null, Expression<Func<double>> bodytemperature = null, Expression<Func<int>> bodymaxTokens = null, Expression<Func<int>> bodymaxInputTokens = null, Expression<Func<int>> bodyk = null, Expression<Func<double>> bodyp = null, Expression<Func<double>> bodyseed = null, Expression<Func<string[]>> bodystopSequences = null, Expression<Func<double>> bodyfrequencyPenalty = null, Expression<Func<double>> bodypresencePenalty = null, Expression<Func<bodytoolsInputItem[]>> bodytools = null)
        {
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodymodel = bodymodel == null ? null : WorkflowExpression.Compile(bodymodel);
            WorkflowExpression.Validate(__workflow_bodymodel, nameof(bodymodel), required: false);
            var __workflow_bodypreamble = bodypreamble == null ? null : WorkflowExpression.Compile(bodypreamble);
            WorkflowExpression.Validate(__workflow_bodypreamble, nameof(bodypreamble), required: false);
            var __workflow_bodychatHistory = bodychatHistory == null ? null : WorkflowExpression.Compile(bodychatHistory);
            WorkflowExpression.Validate(__workflow_bodychatHistory, nameof(bodychatHistory), required: false);
            var __workflow_bodyconversationId = bodyconversationId == null ? null : WorkflowExpression.Compile(bodyconversationId);
            WorkflowExpression.Validate(__workflow_bodyconversationId, nameof(bodyconversationId), required: false);
            var __workflow_bodypromptTruncation = bodypromptTruncation == null ? null : WorkflowExpression.Compile(bodypromptTruncation);
            WorkflowExpression.Validate(__workflow_bodypromptTruncation, nameof(bodypromptTruncation), required: false);
            var __workflow_bodyconnectors = bodyconnectors == null ? null : WorkflowExpression.Compile(bodyconnectors);
            WorkflowExpression.Validate(__workflow_bodyconnectors, nameof(bodyconnectors), required: false);
            var __workflow_bodysearchQueriesOnly = bodysearchQueriesOnly == null ? null : WorkflowExpression.Compile(bodysearchQueriesOnly);
            WorkflowExpression.Validate(__workflow_bodysearchQueriesOnly, nameof(bodysearchQueriesOnly), required: false);
            var __workflow_bodydocuments = bodydocuments == null ? null : WorkflowExpression.Compile(bodydocuments);
            WorkflowExpression.Validate(__workflow_bodydocuments, nameof(bodydocuments), required: false);
            var __workflow_bodycitationQuality = bodycitationQuality == null ? null : WorkflowExpression.Compile(bodycitationQuality);
            WorkflowExpression.Validate(__workflow_bodycitationQuality, nameof(bodycitationQuality), required: false);
            var __workflow_bodytemperature = bodytemperature == null ? null : WorkflowExpression.Compile(bodytemperature);
            WorkflowExpression.Validate(__workflow_bodytemperature, nameof(bodytemperature), required: false);
            var __workflow_bodymaxTokens = bodymaxTokens == null ? null : WorkflowExpression.Compile(bodymaxTokens);
            WorkflowExpression.Validate(__workflow_bodymaxTokens, nameof(bodymaxTokens), required: false);
            var __workflow_bodymaxInputTokens = bodymaxInputTokens == null ? null : WorkflowExpression.Compile(bodymaxInputTokens);
            WorkflowExpression.Validate(__workflow_bodymaxInputTokens, nameof(bodymaxInputTokens), required: false);
            var __workflow_bodyk = bodyk == null ? null : WorkflowExpression.Compile(bodyk);
            WorkflowExpression.Validate(__workflow_bodyk, nameof(bodyk), required: false);
            var __workflow_bodyp = bodyp == null ? null : WorkflowExpression.Compile(bodyp);
            WorkflowExpression.Validate(__workflow_bodyp, nameof(bodyp), required: false);
            var __workflow_bodyseed = bodyseed == null ? null : WorkflowExpression.Compile(bodyseed);
            WorkflowExpression.Validate(__workflow_bodyseed, nameof(bodyseed), required: false);
            var __workflow_bodystopSequences = bodystopSequences == null ? null : WorkflowExpression.Compile(bodystopSequences);
            WorkflowExpression.Validate(__workflow_bodystopSequences, nameof(bodystopSequences), required: false);
            var __workflow_bodyfrequencyPenalty = bodyfrequencyPenalty == null ? null : WorkflowExpression.Compile(bodyfrequencyPenalty);
            WorkflowExpression.Validate(__workflow_bodyfrequencyPenalty, nameof(bodyfrequencyPenalty), required: false);
            var __workflow_bodypresencePenalty = bodypresencePenalty == null ? null : WorkflowExpression.Compile(bodypresencePenalty);
            WorkflowExpression.Validate(__workflow_bodypresencePenalty, nameof(bodypresencePenalty), required: false);
            var __workflow_bodytools = bodytools == null ? null : WorkflowExpression.Compile(bodytools);
            WorkflowExpression.Validate(__workflow_bodytools, nameof(bodytools), required: false);
            return new DeferredBodyAction<ChatPostResponse>(() =>
            {
                var apiCallPath = "/v1/chat";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                if (__workflow_bodymodel != null)
                {
                    if (__workflow_bodymodel != null)
                    {
                        body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "command-r-plus";
                    bodypropCount++;
                }

                if (__workflow_bodypreamble != null)
                {
                    body["preamble"] = ExpressionConverter.ConvertO(__workflow_bodypreamble);
                    bodypropCount++;
                }

                if (__workflow_bodychatHistory != null)
                {
                    body["chat_history"] = ExpressionConverter.ConvertO(__workflow_bodychatHistory);
                    bodypropCount++;
                }

                if (__workflow_bodyconversationId != null)
                {
                    body["conversation_id"] = ExpressionConverter.ConvertO(__workflow_bodyconversationId);
                    bodypropCount++;
                }

                if (__workflow_bodypromptTruncation != null)
                {
                    body["prompt_truncation"] = ExpressionConverter.ConvertO(__workflow_bodypromptTruncation);
                    bodypropCount++;
                }

                if (__workflow_bodyconnectors != null)
                {
                    body["connectors"] = ExpressionConverter.ConvertO(__workflow_bodyconnectors);
                    bodypropCount++;
                }

                if (__workflow_bodysearchQueriesOnly != null)
                {
                    body["search_queries_only"] = ExpressionConverter.ConvertO(__workflow_bodysearchQueriesOnly);
                    bodypropCount++;
                }

                if (__workflow_bodydocuments != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(__workflow_bodydocuments);
                    bodypropCount++;
                }

                if (__workflow_bodycitationQuality != null)
                {
                    body["citation_quality"] = ExpressionConverter.ConvertO(__workflow_bodycitationQuality);
                    bodypropCount++;
                }

                if (__workflow_bodytemperature != null)
                {
                    body["temperature"] = ExpressionConverter.ConvertO(__workflow_bodytemperature);
                    bodypropCount++;
                }

                if (__workflow_bodymaxTokens != null)
                {
                    body["max_tokens"] = ExpressionConverter.ConvertO(__workflow_bodymaxTokens);
                    bodypropCount++;
                }

                if (__workflow_bodymaxInputTokens != null)
                {
                    body["max_input_tokens"] = ExpressionConverter.ConvertO(__workflow_bodymaxInputTokens);
                    bodypropCount++;
                }

                if (__workflow_bodyk != null)
                {
                    body["k"] = ExpressionConverter.ConvertO(__workflow_bodyk);
                    bodypropCount++;
                }

                if (__workflow_bodyp != null)
                {
                    body["p"] = ExpressionConverter.ConvertO(__workflow_bodyp);
                    bodypropCount++;
                }

                if (__workflow_bodyseed != null)
                {
                    body["seed"] = ExpressionConverter.ConvertO(__workflow_bodyseed);
                    bodypropCount++;
                }

                if (__workflow_bodystopSequences != null)
                {
                    body["stop_sequences"] = ExpressionConverter.ConvertO(__workflow_bodystopSequences);
                    bodypropCount++;
                }

                if (__workflow_bodyfrequencyPenalty != null)
                {
                    body["frequency_penalty"] = ExpressionConverter.ConvertO(__workflow_bodyfrequencyPenalty);
                    bodypropCount++;
                }

                if (__workflow_bodypresencePenalty != null)
                {
                    body["presence_penalty"] = ExpressionConverter.ConvertO(__workflow_bodypresencePenalty);
                    bodypropCount++;
                }

                if (__workflow_bodytools != null)
                {
                    body["tools"] = ExpressionConverter.ConvertO(__workflow_bodytools);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymodelInput
    {
        [EnumMember(Value = "large")]
        Large,
        [EnumMember(Value = "small")]
        Small,
        [EnumMember(Value = "multilingual-22-12")]
        Multilingual2212
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodychatHistoryInputItemRoleType
    {
        CHATBOT,
        SYSTEM,
        USER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
