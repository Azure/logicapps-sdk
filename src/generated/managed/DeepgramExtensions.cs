//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deepgram
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeepgramActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        [WorkflowExpressionFactory(nameof(__BuildTranscribe))]
        public IBodyWorkflowAction<TranscribePostResponse> Transcribe([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<modelInput> model = null, [WorkflowExpression] Func<tierInput> tier = null, [WorkflowExpression] Func<versionInput> version = null, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> detectLanguage = null, [WorkflowExpression] Func<bool> punctuate = null, [WorkflowExpression] Func<bool> profanityFilter = null, [WorkflowExpression] Func<redactInput> redact = null, [WorkflowExpression] Func<bool> diarize = null, [WorkflowExpression] Func<string> diarizeVersion = null, [WorkflowExpression] Func<bool> smartFormat = null, [WorkflowExpression] Func<bool> fillerWords = null, [WorkflowExpression] Func<bool> multichannel = null, [WorkflowExpression] Func<int> alternatives = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> replace = null, [WorkflowExpression] Func<string> callback = null, [WorkflowExpression] Func<string> keywords = null, [WorkflowExpression] Func<bool> paragraphs = null, [WorkflowExpression] Func<string> summarize = null, [WorkflowExpression] Func<bool> detectTopics = null, [WorkflowExpression] Func<bool> utterances = null, [WorkflowExpression] Func<double> uttSplit = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<bool> numerals = null, [WorkflowExpression] Func<bool> ner = null, [WorkflowExpression] Func<bool> measurements = null, [WorkflowExpression] Func<bool> dictation = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TranscribePostResponse> __BuildTranscribe(WorkflowExpression<string> bodyurl, WorkflowExpression<modelInput> model = null, WorkflowExpression<tierInput> tier = null, WorkflowExpression<versionInput> version = null, WorkflowExpression<string> language = null, WorkflowExpression<bool> detectLanguage = null, WorkflowExpression<bool> punctuate = null, WorkflowExpression<bool> profanityFilter = null, WorkflowExpression<redactInput> redact = null, WorkflowExpression<bool> diarize = null, WorkflowExpression<string> diarizeVersion = null, WorkflowExpression<bool> smartFormat = null, WorkflowExpression<bool> fillerWords = null, WorkflowExpression<bool> multichannel = null, WorkflowExpression<int> alternatives = null, WorkflowExpression<string> search = null, WorkflowExpression<string> replace = null, WorkflowExpression<string> callback = null, WorkflowExpression<string> keywords = null, WorkflowExpression<bool> paragraphs = null, WorkflowExpression<string> summarize = null, WorkflowExpression<bool> detectTopics = null, WorkflowExpression<bool> utterances = null, WorkflowExpression<double> uttSplit = null, WorkflowExpression<string> tag = null, WorkflowExpression<bool> numerals = null, WorkflowExpression<bool> ner = null, WorkflowExpression<bool> measurements = null, WorkflowExpression<bool> dictation = null)
        {
            WorkflowExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            WorkflowExpression.Validate(model, nameof(model), required: false);
            WorkflowExpression.Validate(tier, nameof(tier), required: false);
            WorkflowExpression.Validate(version, nameof(version), required: false);
            WorkflowExpression.Validate(language, nameof(language), required: false);
            WorkflowExpression.Validate(detectLanguage, nameof(detectLanguage), required: false);
            WorkflowExpression.Validate(punctuate, nameof(punctuate), required: false);
            WorkflowExpression.Validate(profanityFilter, nameof(profanityFilter), required: false);
            WorkflowExpression.Validate(redact, nameof(redact), required: false);
            WorkflowExpression.Validate(diarize, nameof(diarize), required: false);
            WorkflowExpression.Validate(diarizeVersion, nameof(diarizeVersion), required: false);
            WorkflowExpression.Validate(smartFormat, nameof(smartFormat), required: false);
            WorkflowExpression.Validate(fillerWords, nameof(fillerWords), required: false);
            WorkflowExpression.Validate(multichannel, nameof(multichannel), required: false);
            WorkflowExpression.Validate(alternatives, nameof(alternatives), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(replace, nameof(replace), required: false);
            WorkflowExpression.Validate(callback, nameof(callback), required: false);
            WorkflowExpression.Validate(keywords, nameof(keywords), required: false);
            WorkflowExpression.Validate(paragraphs, nameof(paragraphs), required: false);
            WorkflowExpression.Validate(summarize, nameof(summarize), required: false);
            WorkflowExpression.Validate(detectTopics, nameof(detectTopics), required: false);
            WorkflowExpression.Validate(utterances, nameof(utterances), required: false);
            WorkflowExpression.Validate(uttSplit, nameof(uttSplit), required: false);
            WorkflowExpression.Validate(tag, nameof(tag), required: false);
            WorkflowExpression.Validate(numerals, nameof(numerals), required: false);
            WorkflowExpression.Validate(ner, nameof(ner), required: false);
            WorkflowExpression.Validate(measurements, nameof(measurements), required: false);
            WorkflowExpression.Validate(dictation, nameof(dictation), required: false);
            return new DeferredBodyAction<TranscribePostResponse>(() =>
            {
                var apiCallPath = "/listen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (model != null)
                    callPayload.Queries["model"] = ExpressionConverter.Convert(model);
                if (tier != null)
                    callPayload.Queries["tier"] = ExpressionConverter.Convert(tier);
                if (version != null)
                    callPayload.Queries["version"] = ExpressionConverter.Convert(version);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                if (detectLanguage != null)
                    callPayload.Queries["detect_language"] = ExpressionConverter.Convert(detectLanguage);
                if (punctuate != null)
                    callPayload.Queries["punctuate"] = ExpressionConverter.Convert(punctuate);
                if (profanityFilter != null)
                    callPayload.Queries["profanity_filter"] = ExpressionConverter.Convert(profanityFilter);
                if (redact != null)
                    callPayload.Queries["redact"] = ExpressionConverter.Convert(redact);
                if (diarize != null)
                    callPayload.Queries["diarize"] = ExpressionConverter.Convert(diarize);
                if (diarizeVersion != null)
                    callPayload.Queries["diarize_version"] = ExpressionConverter.Convert(diarizeVersion);
                if (smartFormat != null)
                    callPayload.Queries["smart_format"] = ExpressionConverter.Convert(smartFormat);
                if (fillerWords != null)
                    callPayload.Queries["filler_words"] = ExpressionConverter.Convert(fillerWords);
                if (multichannel != null)
                    callPayload.Queries["multichannel"] = ExpressionConverter.Convert(multichannel);
                if (alternatives != null)
                    callPayload.Queries["alternatives"] = ExpressionConverter.Convert(alternatives);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (replace != null)
                    callPayload.Queries["replace"] = ExpressionConverter.Convert(replace);
                if (callback != null)
                    callPayload.Queries["callback"] = ExpressionConverter.Convert(callback);
                if (keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(keywords);
                if (paragraphs != null)
                    callPayload.Queries["paragraphs"] = ExpressionConverter.Convert(paragraphs);
                if (summarize != null)
                    callPayload.Queries["summarize"] = ExpressionConverter.Convert(summarize);
                if (detectTopics != null)
                    callPayload.Queries["detect_topics"] = ExpressionConverter.Convert(detectTopics);
                if (utterances != null)
                    callPayload.Queries["utterances"] = ExpressionConverter.Convert(utterances);
                if (uttSplit != null)
                    callPayload.Queries["utt_split"] = ExpressionConverter.Convert(uttSplit);
                if (tag != null)
                    callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
                if (numerals != null)
                    callPayload.Queries["numerals"] = ExpressionConverter.Convert(numerals);
                if (ner != null)
                    callPayload.Queries["ner"] = ExpressionConverter.Convert(ner);
                if (measurements != null)
                    callPayload.Queries["measurements"] = ExpressionConverter.Convert(measurements);
                if (dictation != null)
                    callPayload.Queries["dictation"] = ExpressionConverter.Convert(dictation);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
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
        [WorkflowExpressionFactory(nameof(__BuildProjectGet))]
        public IBodyWorkflowAction<ProjectGetResponse> ProjectGet([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectGetResponse> __BuildProjectGet(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        [WorkflowExpressionFactory(nameof(__BuildProjectDelete))]
        public IBodyWorkflowAction<JToken> ProjectDelete([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildProjectDelete(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        [WorkflowExpressionFactory(nameof(__BuildProjectPatch))]
        public IBodyWorkflowAction<ProjectPatchResponse> ProjectPatch([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectPatchResponse> __BuildProjectPatch(WorkflowExpression<string> projectId, WorkflowExpression<string> bodyname)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<ProjectPatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProjectPatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        [WorkflowExpressionFactory(nameof(__BuildRequestsGet))]
        public IBodyWorkflowAction<RequestsGetResponse> RequestsGet([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<statusInput> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RequestsGetResponse> __BuildRequestsGet(WorkflowExpression<string> projectId, WorkflowExpression<string> start = null, WorkflowExpression<string> end = null, WorkflowExpression<string> limit = null, WorkflowExpression<statusInput> status = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<RequestsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/requests", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                return new ApiConnectionAction<RequestsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        [WorkflowExpressionFactory(nameof(__BuildRequestGet))]
        public IBodyWorkflowAction<RequestGetResponse> RequestGet([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RequestGetResponse> __BuildRequestGet(WorkflowExpression<string> projectId, WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<RequestGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RequestGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        [WorkflowExpressionFactory(nameof(__BuildUsageGet))]
        public IBodyWorkflowAction<UsageGetResponse> UsageGet([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> accessor = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<methodInput> method = null, [WorkflowExpression] Func<string> model = null, [WorkflowExpression] Func<bool> multichannel = null, [WorkflowExpression] Func<bool> interimResults = null, [WorkflowExpression] Func<bool> punctuate = null, [WorkflowExpression] Func<bool> ner = null, [WorkflowExpression] Func<bool> utterances = null, [WorkflowExpression] Func<bool> replace = null, [WorkflowExpression] Func<bool> profanityFilter = null, [WorkflowExpression] Func<bool> keywords = null, [WorkflowExpression] Func<bool> detectTopics = null, [WorkflowExpression] Func<bool> diarize = null, [WorkflowExpression] Func<bool> search = null, [WorkflowExpression] Func<bool> redact = null, [WorkflowExpression] Func<bool> alternatives = null, [WorkflowExpression] Func<bool> numerals = null, [WorkflowExpression] Func<bool> smartFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UsageGetResponse> __BuildUsageGet(WorkflowExpression<string> projectId, WorkflowExpression<string> start = null, WorkflowExpression<string> end = null, WorkflowExpression<string> accessor = null, WorkflowExpression<string> tag = null, WorkflowExpression<methodInput> method = null, WorkflowExpression<string> model = null, WorkflowExpression<bool> multichannel = null, WorkflowExpression<bool> interimResults = null, WorkflowExpression<bool> punctuate = null, WorkflowExpression<bool> ner = null, WorkflowExpression<bool> utterances = null, WorkflowExpression<bool> replace = null, WorkflowExpression<bool> profanityFilter = null, WorkflowExpression<bool> keywords = null, WorkflowExpression<bool> detectTopics = null, WorkflowExpression<bool> diarize = null, WorkflowExpression<bool> search = null, WorkflowExpression<bool> redact = null, WorkflowExpression<bool> alternatives = null, WorkflowExpression<bool> numerals = null, WorkflowExpression<bool> smartFormat = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            WorkflowExpression.Validate(accessor, nameof(accessor), required: false);
            WorkflowExpression.Validate(tag, nameof(tag), required: false);
            WorkflowExpression.Validate(method, nameof(method), required: false);
            WorkflowExpression.Validate(model, nameof(model), required: false);
            WorkflowExpression.Validate(multichannel, nameof(multichannel), required: false);
            WorkflowExpression.Validate(interimResults, nameof(interimResults), required: false);
            WorkflowExpression.Validate(punctuate, nameof(punctuate), required: false);
            WorkflowExpression.Validate(ner, nameof(ner), required: false);
            WorkflowExpression.Validate(utterances, nameof(utterances), required: false);
            WorkflowExpression.Validate(replace, nameof(replace), required: false);
            WorkflowExpression.Validate(profanityFilter, nameof(profanityFilter), required: false);
            WorkflowExpression.Validate(keywords, nameof(keywords), required: false);
            WorkflowExpression.Validate(detectTopics, nameof(detectTopics), required: false);
            WorkflowExpression.Validate(diarize, nameof(diarize), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(redact, nameof(redact), required: false);
            WorkflowExpression.Validate(alternatives, nameof(alternatives), required: false);
            WorkflowExpression.Validate(numerals, nameof(numerals), required: false);
            WorkflowExpression.Validate(smartFormat, nameof(smartFormat), required: false);
            return new DeferredBodyAction<UsageGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/usage", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                if (accessor != null)
                    callPayload.Queries["accessor"] = ExpressionConverter.Convert(accessor);
                if (tag != null)
                    callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
                if (method != null)
                    callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                if (model != null)
                    callPayload.Queries["model"] = ExpressionConverter.Convert(model);
                if (multichannel != null)
                    callPayload.Queries["multichannel"] = ExpressionConverter.Convert(multichannel);
                if (interimResults != null)
                    callPayload.Queries["interim_results"] = ExpressionConverter.Convert(interimResults);
                if (punctuate != null)
                    callPayload.Queries["punctuate"] = ExpressionConverter.Convert(punctuate);
                if (ner != null)
                    callPayload.Queries["ner"] = ExpressionConverter.Convert(ner);
                if (utterances != null)
                    callPayload.Queries["utterances"] = ExpressionConverter.Convert(utterances);
                if (replace != null)
                    callPayload.Queries["replace"] = ExpressionConverter.Convert(replace);
                if (profanityFilter != null)
                    callPayload.Queries["profanity_filter"] = ExpressionConverter.Convert(profanityFilter);
                if (keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(keywords);
                if (detectTopics != null)
                    callPayload.Queries["detect_topics"] = ExpressionConverter.Convert(detectTopics);
                if (diarize != null)
                    callPayload.Queries["diarize"] = ExpressionConverter.Convert(diarize);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (redact != null)
                    callPayload.Queries["redact"] = ExpressionConverter.Convert(redact);
                if (alternatives != null)
                    callPayload.Queries["alternatives"] = ExpressionConverter.Convert(alternatives);
                if (numerals != null)
                    callPayload.Queries["numerals"] = ExpressionConverter.Convert(numerals);
                if (smartFormat != null)
                    callPayload.Queries["smart_format"] = ExpressionConverter.Convert(smartFormat);
                return new ApiConnectionAction<UsageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepgram")]
        [WorkflowExpressionFactory(nameof(__BuildFieldsGet))]
        public IBodyWorkflowAction<FieldsGetResponse> FieldsGet([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FieldsGetResponse> __BuildFieldsGet(WorkflowExpression<string> projectId, WorkflowExpression<string> start = null, WorkflowExpression<string> end = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            return new DeferredBodyAction<FieldsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/usage/fields", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
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