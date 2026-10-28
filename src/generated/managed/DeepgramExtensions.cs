//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deepgram
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeepgramActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        public IBodyWorkflowAction<TranscribePostResponse> Transcribe(Expression<Func<string>> bodyurl, Expression<Func<modelInput>> model = null, Expression<Func<tierInput>> tier = null, Expression<Func<versionInput>> version = null, Expression<Func<string>> language = null, Expression<Func<bool>> detectLanguage = null, Expression<Func<bool>> punctuate = null, Expression<Func<bool>> profanityFilter = null, Expression<Func<redactInput>> redact = null, Expression<Func<bool>> diarize = null, Expression<Func<string>> diarizeVersion = null, Expression<Func<bool>> smartFormat = null, Expression<Func<bool>> fillerWords = null, Expression<Func<bool>> multichannel = null, Expression<Func<int>> alternatives = null, Expression<Func<string>> search = null, Expression<Func<string>> replace = null, Expression<Func<string>> callback = null, Expression<Func<string>> keywords = null, Expression<Func<bool>> paragraphs = null, Expression<Func<string>> summarize = null, Expression<Func<bool>> detectTopics = null, Expression<Func<bool>> utterances = null, Expression<Func<double>> uttSplit = null, Expression<Func<string>> tag = null, Expression<Func<bool>> numerals = null, Expression<Func<bool>> ner = null, Expression<Func<bool>> measurements = null, Expression<Func<bool>> dictation = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: false);
            var __workflow_tier = WorkflowExpression.Compile(tier, nameof(tier), required: false);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_detectLanguage = WorkflowExpression.Compile(detectLanguage, nameof(detectLanguage), required: false);
            var __workflow_punctuate = WorkflowExpression.Compile(punctuate, nameof(punctuate), required: false);
            var __workflow_profanityFilter = WorkflowExpression.Compile(profanityFilter, nameof(profanityFilter), required: false);
            var __workflow_redact = WorkflowExpression.Compile(redact, nameof(redact), required: false);
            var __workflow_diarize = WorkflowExpression.Compile(diarize, nameof(diarize), required: false);
            var __workflow_diarizeVersion = WorkflowExpression.Compile(diarizeVersion, nameof(diarizeVersion), required: false);
            var __workflow_smartFormat = WorkflowExpression.Compile(smartFormat, nameof(smartFormat), required: false);
            var __workflow_fillerWords = WorkflowExpression.Compile(fillerWords, nameof(fillerWords), required: false);
            var __workflow_multichannel = WorkflowExpression.Compile(multichannel, nameof(multichannel), required: false);
            var __workflow_alternatives = WorkflowExpression.Compile(alternatives, nameof(alternatives), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_replace = WorkflowExpression.Compile(replace, nameof(replace), required: false);
            var __workflow_callback = WorkflowExpression.Compile(callback, nameof(callback), required: false);
            var __workflow_keywords = WorkflowExpression.Compile(keywords, nameof(keywords), required: false);
            var __workflow_paragraphs = WorkflowExpression.Compile(paragraphs, nameof(paragraphs), required: false);
            var __workflow_summarize = WorkflowExpression.Compile(summarize, nameof(summarize), required: false);
            var __workflow_detectTopics = WorkflowExpression.Compile(detectTopics, nameof(detectTopics), required: false);
            var __workflow_utterances = WorkflowExpression.Compile(utterances, nameof(utterances), required: false);
            var __workflow_uttSplit = WorkflowExpression.Compile(uttSplit, nameof(uttSplit), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            var __workflow_numerals = WorkflowExpression.Compile(numerals, nameof(numerals), required: false);
            var __workflow_ner = WorkflowExpression.Compile(ner, nameof(ner), required: false);
            var __workflow_measurements = WorkflowExpression.Compile(measurements, nameof(measurements), required: false);
            var __workflow_dictation = WorkflowExpression.Compile(dictation, nameof(dictation), required: false);
            return new DeferredBodyAction<TranscribePostResponse>(() =>
            {
                var apiCallPath = "/listen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_model != null)
                    callPayload.Queries["model"] = ExpressionConverter.Convert(__workflow_model);
                if (__workflow_tier != null)
                    callPayload.Queries["tier"] = ExpressionConverter.Convert(__workflow_tier);
                if (__workflow_version != null)
                    callPayload.Queries["version"] = ExpressionConverter.Convert(__workflow_version);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                if (__workflow_detectLanguage != null)
                    callPayload.Queries["detect_language"] = ExpressionConverter.Convert(__workflow_detectLanguage);
                if (__workflow_punctuate != null)
                    callPayload.Queries["punctuate"] = ExpressionConverter.Convert(__workflow_punctuate);
                if (__workflow_profanityFilter != null)
                    callPayload.Queries["profanity_filter"] = ExpressionConverter.Convert(__workflow_profanityFilter);
                if (__workflow_redact != null)
                    callPayload.Queries["redact"] = ExpressionConverter.Convert(__workflow_redact);
                if (__workflow_diarize != null)
                    callPayload.Queries["diarize"] = ExpressionConverter.Convert(__workflow_diarize);
                if (__workflow_diarizeVersion != null)
                    callPayload.Queries["diarize_version"] = ExpressionConverter.Convert(__workflow_diarizeVersion);
                if (__workflow_smartFormat != null)
                    callPayload.Queries["smart_format"] = ExpressionConverter.Convert(__workflow_smartFormat);
                if (__workflow_fillerWords != null)
                    callPayload.Queries["filler_words"] = ExpressionConverter.Convert(__workflow_fillerWords);
                if (__workflow_multichannel != null)
                    callPayload.Queries["multichannel"] = ExpressionConverter.Convert(__workflow_multichannel);
                if (__workflow_alternatives != null)
                    callPayload.Queries["alternatives"] = ExpressionConverter.Convert(__workflow_alternatives);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_replace != null)
                    callPayload.Queries["replace"] = ExpressionConverter.Convert(__workflow_replace);
                if (__workflow_callback != null)
                    callPayload.Queries["callback"] = ExpressionConverter.Convert(__workflow_callback);
                if (__workflow_keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(__workflow_keywords);
                if (__workflow_paragraphs != null)
                    callPayload.Queries["paragraphs"] = ExpressionConverter.Convert(__workflow_paragraphs);
                if (__workflow_summarize != null)
                    callPayload.Queries["summarize"] = ExpressionConverter.Convert(__workflow_summarize);
                if (__workflow_detectTopics != null)
                    callPayload.Queries["detect_topics"] = ExpressionConverter.Convert(__workflow_detectTopics);
                if (__workflow_utterances != null)
                    callPayload.Queries["utterances"] = ExpressionConverter.Convert(__workflow_utterances);
                if (__workflow_uttSplit != null)
                    callPayload.Queries["utt_split"] = ExpressionConverter.Convert(__workflow_uttSplit);
                if (__workflow_tag != null)
                    callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_numerals != null)
                    callPayload.Queries["numerals"] = ExpressionConverter.Convert(__workflow_numerals);
                if (__workflow_ner != null)
                    callPayload.Queries["ner"] = ExpressionConverter.Convert(__workflow_ner);
                if (__workflow_measurements != null)
                    callPayload.Queries["measurements"] = ExpressionConverter.Convert(__workflow_measurements);
                if (__workflow_dictation != null)
                    callPayload.Queries["dictation"] = ExpressionConverter.Convert(__workflow_dictation);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TranscribePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        public IBodyWorkflowAction<ProjectsGetResponse> ProjectsGet()
        {
            var apiCallPath = "/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        public IBodyWorkflowAction<ProjectGetResponse> ProjectGet(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        public IBodyWorkflowAction<JToken> ProjectDelete(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        public IBodyWorkflowAction<ProjectPatchResponse> ProjectPatch(Expression<Func<string>> projectId, Expression<Func<string>> bodyname)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<ProjectPatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProjectPatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        public IBodyWorkflowAction<RequestsGetResponse> RequestsGet(Expression<Func<string>> projectId, Expression<Func<string>> start = null, Expression<Func<string>> end = null, Expression<Func<string>> limit = null, Expression<Func<statusInput>> status = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<RequestsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/requests", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<RequestsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        public IBodyWorkflowAction<RequestGetResponse> RequestGet(Expression<Func<string>> projectId, Expression<Func<string>> requestId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<RequestGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/requests/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RequestGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        public IBodyWorkflowAction<UsageGetResponse> UsageGet(Expression<Func<string>> projectId, Expression<Func<string>> start = null, Expression<Func<string>> end = null, Expression<Func<string>> accessor = null, Expression<Func<string>> tag = null, Expression<Func<methodInput>> method = null, Expression<Func<string>> model = null, Expression<Func<bool>> multichannel = null, Expression<Func<bool>> interimResults = null, Expression<Func<bool>> punctuate = null, Expression<Func<bool>> ner = null, Expression<Func<bool>> utterances = null, Expression<Func<bool>> replace = null, Expression<Func<bool>> profanityFilter = null, Expression<Func<bool>> keywords = null, Expression<Func<bool>> detectTopics = null, Expression<Func<bool>> diarize = null, Expression<Func<bool>> search = null, Expression<Func<bool>> redact = null, Expression<Func<bool>> alternatives = null, Expression<Func<bool>> numerals = null, Expression<Func<bool>> smartFormat = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            var __workflow_accessor = WorkflowExpression.Compile(accessor, nameof(accessor), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: false);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: false);
            var __workflow_multichannel = WorkflowExpression.Compile(multichannel, nameof(multichannel), required: false);
            var __workflow_interimResults = WorkflowExpression.Compile(interimResults, nameof(interimResults), required: false);
            var __workflow_punctuate = WorkflowExpression.Compile(punctuate, nameof(punctuate), required: false);
            var __workflow_ner = WorkflowExpression.Compile(ner, nameof(ner), required: false);
            var __workflow_utterances = WorkflowExpression.Compile(utterances, nameof(utterances), required: false);
            var __workflow_replace = WorkflowExpression.Compile(replace, nameof(replace), required: false);
            var __workflow_profanityFilter = WorkflowExpression.Compile(profanityFilter, nameof(profanityFilter), required: false);
            var __workflow_keywords = WorkflowExpression.Compile(keywords, nameof(keywords), required: false);
            var __workflow_detectTopics = WorkflowExpression.Compile(detectTopics, nameof(detectTopics), required: false);
            var __workflow_diarize = WorkflowExpression.Compile(diarize, nameof(diarize), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_redact = WorkflowExpression.Compile(redact, nameof(redact), required: false);
            var __workflow_alternatives = WorkflowExpression.Compile(alternatives, nameof(alternatives), required: false);
            var __workflow_numerals = WorkflowExpression.Compile(numerals, nameof(numerals), required: false);
            var __workflow_smartFormat = WorkflowExpression.Compile(smartFormat, nameof(smartFormat), required: false);
            return new DeferredBodyAction<UsageGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/usage", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                if (__workflow_accessor != null)
                    callPayload.Queries["accessor"] = ExpressionConverter.Convert(__workflow_accessor);
                if (__workflow_tag != null)
                    callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_method != null)
                    callPayload.Queries["method"] = ExpressionConverter.Convert(__workflow_method);
                if (__workflow_model != null)
                    callPayload.Queries["model"] = ExpressionConverter.Convert(__workflow_model);
                if (__workflow_multichannel != null)
                    callPayload.Queries["multichannel"] = ExpressionConverter.Convert(__workflow_multichannel);
                if (__workflow_interimResults != null)
                    callPayload.Queries["interim_results"] = ExpressionConverter.Convert(__workflow_interimResults);
                if (__workflow_punctuate != null)
                    callPayload.Queries["punctuate"] = ExpressionConverter.Convert(__workflow_punctuate);
                if (__workflow_ner != null)
                    callPayload.Queries["ner"] = ExpressionConverter.Convert(__workflow_ner);
                if (__workflow_utterances != null)
                    callPayload.Queries["utterances"] = ExpressionConverter.Convert(__workflow_utterances);
                if (__workflow_replace != null)
                    callPayload.Queries["replace"] = ExpressionConverter.Convert(__workflow_replace);
                if (__workflow_profanityFilter != null)
                    callPayload.Queries["profanity_filter"] = ExpressionConverter.Convert(__workflow_profanityFilter);
                if (__workflow_keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(__workflow_keywords);
                if (__workflow_detectTopics != null)
                    callPayload.Queries["detect_topics"] = ExpressionConverter.Convert(__workflow_detectTopics);
                if (__workflow_diarize != null)
                    callPayload.Queries["diarize"] = ExpressionConverter.Convert(__workflow_diarize);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_redact != null)
                    callPayload.Queries["redact"] = ExpressionConverter.Convert(__workflow_redact);
                if (__workflow_alternatives != null)
                    callPayload.Queries["alternatives"] = ExpressionConverter.Convert(__workflow_alternatives);
                if (__workflow_numerals != null)
                    callPayload.Queries["numerals"] = ExpressionConverter.Convert(__workflow_numerals);
                if (__workflow_smartFormat != null)
                    callPayload.Queries["smart_format"] = ExpressionConverter.Convert(__workflow_smartFormat);
                return new ApiConnectionAction<UsageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        public IBodyWorkflowAction<FieldsGetResponse> FieldsGet(Expression<Func<string>> projectId, Expression<Func<string>> start = null, Expression<Func<string>> end = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            return new DeferredBodyAction<FieldsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/usage/fields", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<FieldsGetResponse>(callPayload);
            });
        }
    }

    public class DeepgramTriggers([ConnectionName] string connectionId)
    {
    }

    public class TranscribePostResponse
    {
        [JsonProperty("metadata")]
        public TranscribePostResponseMetadataType Metadata { get; set; }

        [JsonProperty("results")]
        public TranscribePostResponseResultsType Results { get; set; }
    }

    public class TranscribePostResponseMetadataType
    {
        [JsonProperty("transaction_key")]
        public string TransactionKey { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("channels")]
        public int Channels { get; set; }

        [JsonProperty("models")]
        public string[] Models { get; set; }

        [JsonProperty("model_info")]
        public JToken ModelInfo { get; set; }
    }

    public class TranscribePostResponseResultsType
    {
        [JsonProperty("channels")]
        public TranscribePostResponseResultsTypeChannelsTypeItem[] Channels { get; set; }
    }

    public class TranscribePostResponseResultsTypeChannelsTypeItem
    {
        [JsonProperty("alternatives")]
        public TranscribePostResponseResultsTypeChannelsTypeItemAlternativesTypeItem[] Alternatives { get; set; }
    }

    public class TranscribePostResponseResultsTypeChannelsTypeItemAlternativesTypeItem
    {
        [JsonProperty("transcript")]
        public string Transcript { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("words")]
        public TranscribePostResponseResultsTypeChannelsTypeItemAlternativesTypeItemWordsTypeItem[] Words { get; set; }
    }

    public class TranscribePostResponseResultsTypeChannelsTypeItemAlternativesTypeItemWordsTypeItem
    {
        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("start")]
        public double Start { get; set; }

        [JsonProperty("end")]
        public double End { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum modelInput
    {
        [EnumMember(Value = "general")]
        General,
        [EnumMember(Value = "meeting")]
        Meeting,
        [EnumMember(Value = "phonecall")]
        Phonecall,
        [EnumMember(Value = "voicemail")]
        Voicemail,
        [EnumMember(Value = "finance")]
        Finance,
        [EnumMember(Value = "conversationalai")]
        Conversationalai,
        [EnumMember(Value = "video")]
        Video
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum tierInput
    {
        [EnumMember(Value = "base")]
        Base,
        [EnumMember(Value = "enhanced")]
        Enhanced,
        [EnumMember(Value = "nova")]
        Nova
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum versionInput
    {
        [EnumMember(Value = "latest")]
        Latest
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum redactInput
    {
        [EnumMember(Value = "pci")]
        Pci,
        [EnumMember(Value = "numbers")]
        Numbers,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "ssn")]
        Ssn
    }

    public class ProjectsGetResponse
    {
        [JsonProperty("projects")]
        public ProjectsGetResponseProjectsTypeItem[] Projects { get; set; }
    }

    public class ProjectsGetResponseProjectsTypeItem
    {
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectGetResponse
    {
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }
    }

    public class ProjectPatchResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class RequestsGetResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("requests")]
        public RequestsGetResponseRequestsTypeItem[] Requests { get; set; }
    }

    public class RequestsGetResponseRequestsTypeItem
    {
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("api_key_id")]
        public string ApiKeyId { get; set; }

        [JsonProperty("response")]
        public RequestsGetResponseRequestsTypeItemResponseType Response { get; set; }

        [JsonProperty("callback")]
        public RequestsGetResponseRequestsTypeItemCallbackType Callback { get; set; }
    }

    public class RequestsGetResponseRequestsTypeItemResponseType
    {
        [JsonProperty("details")]
        public RequestsGetResponseRequestsTypeItemResponseTypeDetailsType Details { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }
    }

    public class RequestsGetResponseRequestsTypeItemResponseTypeDetailsType
    {
        [JsonProperty("usd")]
        public int Usd { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("total_audio")]
        public int TotalAudio { get; set; }

        [JsonProperty("channels")]
        public int Channels { get; set; }

        [JsonProperty("streams")]
        public int Streams { get; set; }

        [JsonProperty("models")]
        public string[] Models { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("features")]
        public string[] Features { get; set; }

        [JsonProperty("config")]
        public RequestsGetResponseRequestsTypeItemResponseTypeDetailsTypeConfigType Config { get; set; }
    }

    public class RequestsGetResponseRequestsTypeItemResponseTypeDetailsTypeConfigType
    {
        [JsonProperty("alternatives")]
        public int Alternatives { get; set; }

        [JsonProperty("diarize")]
        public bool Diarize { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("multichannel")]
        public bool Multichannel { get; set; }

        [JsonProperty("ner")]
        public bool Ner { get; set; }

        [JsonProperty("numerals")]
        public bool Numerals { get; set; }

        [JsonProperty("profanity_filter")]
        public bool ProfanityFilter { get; set; }

        [JsonProperty("punctuate")]
        public bool Punctuate { get; set; }

        [JsonProperty("redact")]
        public string[] Redact { get; set; }

        [JsonProperty("search")]
        public string[] Search { get; set; }

        [JsonProperty("utterances")]
        public bool Utterances { get; set; }
    }

    public class RequestsGetResponseRequestsTypeItemCallbackType
    {
        [JsonProperty("attempts")]
        public int Attempts { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "null")]
        Null
    }

    public class RequestGetResponse
    {
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("api_key_id")]
        public string ApiKeyId { get; set; }

        [JsonProperty("response")]
        public RequestGetResponseResponseType Response { get; set; }

        [JsonProperty("callback")]
        public RequestGetResponseCallbackType Callback { get; set; }
    }

    public class RequestGetResponseResponseType
    {
        [JsonProperty("details")]
        public RequestGetResponseResponseTypeDetailsType Details { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }
    }

    public class RequestGetResponseResponseTypeDetailsType
    {
        [JsonProperty("usd")]
        public int Usd { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("total_audio")]
        public int TotalAudio { get; set; }

        [JsonProperty("channels")]
        public int Channels { get; set; }

        [JsonProperty("streams")]
        public int Streams { get; set; }

        [JsonProperty("models")]
        public string[] Models { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("features")]
        public string[] Features { get; set; }

        [JsonProperty("config")]
        public RequestGetResponseResponseTypeDetailsTypeConfigType Config { get; set; }
    }

    public class RequestGetResponseResponseTypeDetailsTypeConfigType
    {
        [JsonProperty("alternatives")]
        public int Alternatives { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("diarize")]
        public bool Diarize { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("multichannel")]
        public bool Multichannel { get; set; }

        [JsonProperty("ner")]
        public bool Ner { get; set; }

        [JsonProperty("numerals")]
        public bool Numerals { get; set; }

        [JsonProperty("profanity_filter")]
        public bool ProfanityFilter { get; set; }

        [JsonProperty("punctuate")]
        public bool Punctuate { get; set; }

        [JsonProperty("redact")]
        public string[] Redact { get; set; }

        [JsonProperty("search")]
        public string[] Search { get; set; }

        [JsonProperty("utterances")]
        public bool Utterances { get; set; }
    }

    public class RequestGetResponseCallbackType
    {
        [JsonProperty("attempts")]
        public int Attempts { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }
    }

    public class UsageGetResponse
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("resolution")]
        public UsageGetResponseResolutionType Resolution { get; set; }

        [JsonProperty("results")]
        public UsageGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class UsageGetResponseResolutionType
    {
        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    public class UsageGetResponseResultsTypeItem
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("hours")]
        public int Hours { get; set; }

        [JsonProperty("total_hours")]
        public int TotalHours { get; set; }

        [JsonProperty("requests")]
        public int Requests { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum methodInput
    {
        [EnumMember(Value = "sync")]
        Sync,
        [EnumMember(Value = "async")]
        Async,
        [EnumMember(Value = "streaming")]
        Streaming
    }

    public class FieldsGetResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("models")]
        public FieldsGetResponseModelsTypeItem[] Models { get; set; }

        [JsonProperty("processing_methods")]
        public string[] ProcessingMethods { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }

        [JsonProperty("features")]
        public string[] Features { get; set; }
    }

    public class FieldsGetResponseModelsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("model_id")]
        public string ModelId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Deepgram;

    public partial class WorkflowManagedActions
    {
        public DeepgramActions Deepgram(string connectionId) => new DeepgramActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DeepgramTriggers Deepgram(string connectionId) => new DeepgramTriggers(connectionId);
    }
}
