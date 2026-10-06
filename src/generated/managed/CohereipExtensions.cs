//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cohereip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CohereipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [WorkflowExpressionFactory(nameof(__BuildEmbed))]
        public IBodyWorkflowAction<EmbedPostResponse> Embed([WorkflowExpression] Func<string[]> bodytexts = null, [WorkflowExpression] Func<bodymodelInput> bodymodel = null, [WorkflowExpression] Func<bodytruncateInput> bodytruncate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmbedPostResponse> __BuildEmbed(WorkflowExpression<string[]> bodytexts = null, WorkflowExpression<bodymodelInput> bodymodel = null, WorkflowExpression<bodytruncateInput> bodytruncate = null)
        {
            WorkflowExpression.Validate(bodytexts, nameof(bodytexts), required: false);
            WorkflowExpression.Validate(bodymodel, nameof(bodymodel), required: false);
            WorkflowExpression.Validate(bodytruncate, nameof(bodytruncate), required: false);
            return new DeferredBodyAction<EmbedPostResponse>(() =>
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
                    if (bodymodel != null)
                    {
                        body["model"] = ExpressionConverter.ConvertO(bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "large";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [WorkflowExpressionFactory(nameof(__BuildClassify))]
        public IBodyWorkflowAction<ClassifyPostResponse> Classify([WorkflowExpression] Func<string[]> bodyinputs = null, [WorkflowExpression] Func<bodymodelInput> bodymodel = null, [WorkflowExpression] Func<bodyexamplesInputItem[]> bodyexamples = null, [WorkflowExpression] Func<string> bodypreset = null, [WorkflowExpression] Func<bodytruncateInput> bodytruncate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClassifyPostResponse> __BuildClassify(WorkflowExpression<string[]> bodyinputs = null, WorkflowExpression<bodymodelInput> bodymodel = null, WorkflowExpression<bodyexamplesInputItem[]> bodyexamples = null, WorkflowExpression<string> bodypreset = null, WorkflowExpression<bodytruncateInput> bodytruncate = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            WorkflowExpression.Validate(bodymodel, nameof(bodymodel), required: false);
            WorkflowExpression.Validate(bodyexamples, nameof(bodyexamples), required: false);
            WorkflowExpression.Validate(bodypreset, nameof(bodypreset), required: false);
            WorkflowExpression.Validate(bodytruncate, nameof(bodytruncate), required: false);
            return new DeferredBodyAction<ClassifyPostResponse>(() =>
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
                    if (bodymodel != null)
                    {
                        body["model"] = ExpressionConverter.ConvertO(bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "large";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [WorkflowExpressionFactory(nameof(__BuildToken))]
        public IBodyWorkflowAction<TokenPostResponse> Token([WorkflowExpression] Func<string> bodytext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TokenPostResponse> __BuildToken(WorkflowExpression<string> bodytext = null)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            return new DeferredBodyAction<TokenPostResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [WorkflowExpressionFactory(nameof(__BuildDetoken))]
        public IBodyWorkflowAction<DetokenPostResponse> Detoken([WorkflowExpression] Func<int[]> bodytokens = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetokenPostResponse> __BuildDetoken(WorkflowExpression<int[]> bodytokens = null)
        {
            WorkflowExpression.Validate(bodytokens, nameof(bodytokens), required: false);
            return new DeferredBodyAction<DetokenPostResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [WorkflowExpressionFactory(nameof(__BuildLanguage))]
        public IBodyWorkflowAction<LanguagePostResponse> Language([WorkflowExpression] Func<string[]> bodytexts = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LanguagePostResponse> __BuildLanguage(WorkflowExpression<string[]> bodytexts = null)
        {
            WorkflowExpression.Validate(bodytexts, nameof(bodytexts), required: false);
            return new DeferredBodyAction<LanguagePostResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [WorkflowExpressionFactory(nameof(__BuildChat))]
        public IBodyWorkflowAction<ChatPostResponse> Chat([WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodymodel = null, [WorkflowExpression] Func<string> bodypreamble = null, [WorkflowExpression] Func<bodychatHistoryInputItem[]> bodychatHistory = null, [WorkflowExpression] Func<string> bodyconversationId = null, [WorkflowExpression] Func<bodypromptTruncationInput> bodypromptTruncation = null, [WorkflowExpression] Func<bodyconnectorsInputItem[]> bodyconnectors = null, [WorkflowExpression] Func<bool> bodysearchQueriesOnly = null, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments = null, [WorkflowExpression] Func<bodycitationQualityInput> bodycitationQuality = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<int> bodymaxTokens = null, [WorkflowExpression] Func<int> bodymaxInputTokens = null, [WorkflowExpression] Func<int> bodyk = null, [WorkflowExpression] Func<double> bodyp = null, [WorkflowExpression] Func<double> bodyseed = null, [WorkflowExpression] Func<string[]> bodystopSequences = null, [WorkflowExpression] Func<double> bodyfrequencyPenalty = null, [WorkflowExpression] Func<double> bodypresencePenalty = null, [WorkflowExpression] Func<bodytoolsInputItem[]> bodytools = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohereip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChatPostResponse> __BuildChat(WorkflowExpression<string> bodymessage, WorkflowExpression<string> bodymodel = null, WorkflowExpression<string> bodypreamble = null, WorkflowExpression<bodychatHistoryInputItem[]> bodychatHistory = null, WorkflowExpression<string> bodyconversationId = null, WorkflowExpression<bodypromptTruncationInput> bodypromptTruncation = null, WorkflowExpression<bodyconnectorsInputItem[]> bodyconnectors = null, WorkflowExpression<bool> bodysearchQueriesOnly = null, WorkflowExpression<bodydocumentsInputItem[]> bodydocuments = null, WorkflowExpression<bodycitationQualityInput> bodycitationQuality = null, WorkflowExpression<double> bodytemperature = null, WorkflowExpression<int> bodymaxTokens = null, WorkflowExpression<int> bodymaxInputTokens = null, WorkflowExpression<int> bodyk = null, WorkflowExpression<double> bodyp = null, WorkflowExpression<double> bodyseed = null, WorkflowExpression<string[]> bodystopSequences = null, WorkflowExpression<double> bodyfrequencyPenalty = null, WorkflowExpression<double> bodypresencePenalty = null, WorkflowExpression<bodytoolsInputItem[]> bodytools = null)
        {
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodymodel, nameof(bodymodel), required: false);
            WorkflowExpression.Validate(bodypreamble, nameof(bodypreamble), required: false);
            WorkflowExpression.Validate(bodychatHistory, nameof(bodychatHistory), required: false);
            WorkflowExpression.Validate(bodyconversationId, nameof(bodyconversationId), required: false);
            WorkflowExpression.Validate(bodypromptTruncation, nameof(bodypromptTruncation), required: false);
            WorkflowExpression.Validate(bodyconnectors, nameof(bodyconnectors), required: false);
            WorkflowExpression.Validate(bodysearchQueriesOnly, nameof(bodysearchQueriesOnly), required: false);
            WorkflowExpression.Validate(bodydocuments, nameof(bodydocuments), required: false);
            WorkflowExpression.Validate(bodycitationQuality, nameof(bodycitationQuality), required: false);
            WorkflowExpression.Validate(bodytemperature, nameof(bodytemperature), required: false);
            WorkflowExpression.Validate(bodymaxTokens, nameof(bodymaxTokens), required: false);
            WorkflowExpression.Validate(bodymaxInputTokens, nameof(bodymaxInputTokens), required: false);
            WorkflowExpression.Validate(bodyk, nameof(bodyk), required: false);
            WorkflowExpression.Validate(bodyp, nameof(bodyp), required: false);
            WorkflowExpression.Validate(bodyseed, nameof(bodyseed), required: false);
            WorkflowExpression.Validate(bodystopSequences, nameof(bodystopSequences), required: false);
            WorkflowExpression.Validate(bodyfrequencyPenalty, nameof(bodyfrequencyPenalty), required: false);
            WorkflowExpression.Validate(bodypresencePenalty, nameof(bodypresencePenalty), required: false);
            WorkflowExpression.Validate(bodytools, nameof(bodytools), required: false);
            return new DeferredBodyAction<ChatPostResponse>(() =>
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
                    if (bodymodel != null)
                    {
                        body["model"] = ExpressionConverter.ConvertO(bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "command-r-plus";
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