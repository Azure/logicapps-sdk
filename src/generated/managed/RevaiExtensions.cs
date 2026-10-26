//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Revai
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RevaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<TranscriptionGetResponse, ApiConnectionActionConfiguration> TranscriptionGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TranscriptionGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/speechtotext/v1/jobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TranscriptionGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> TranscriptionDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/speechtotext/v1/jobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<TranscriptionsGetResponseItem[], ApiConnectionActionConfiguration> TranscriptionsGet(Expression<Func<int>> limit = null, Expression<Func<string>> startingAfter = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_startingAfter = WorkflowExpression.Compile(startingAfter, nameof(startingAfter), required: false);
            return new DeferredBodyAction<TranscriptionsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/speechtotext/v1/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_startingAfter != null)
                    callPayload.Queries["starting_after"] = ExpressionConverter.Convert(__workflow_startingAfter);
                return new ApiConnectionAction<TranscriptionsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<TranscriptionPostResponse, ApiConnectionActionConfiguration> Transcription(Expression<Func<string>> bodysourceConfigurl, Expression<Func<string>> bodysourceConfigauthHeadersauthorization = null, Expression<Func<string>> bodymetadata = null, Expression<Func<string>> bodynotificationConfigurl = null, Expression<Func<string>> bodynotificationConfigauthHeadersauthorization = null, Expression<Func<int>> bodydeleteAfterSeconds = null, Expression<Func<string>> bodytranscriber = null, Expression<Func<bool>> bodyverbatim = null, Expression<Func<bool>> bodyrush = null, Expression<Func<bool>> bodytestMode = null, Expression<Func<bodysegmentsToTranscribeInputItem[]>> bodysegmentsToTranscribe = null, Expression<Func<bodyspeakersNamesInputItem[]>> bodyspeakersNames = null, Expression<Func<bool>> bodyskipDiarization = null, Expression<Func<bool>> bodyskipPostprocessing = null, Expression<Func<bool>> bodyskipPunctuation = null, Expression<Func<bool>> bodyremoveDisfluencies = null, Expression<Func<bool>> bodyremoveAtmospherics = null, Expression<Func<bool>> bodyfilterProfanity = null, Expression<Func<int>> bodyspeakerChannelsCount = null, Expression<Func<int>> bodyspeakersCount = null, Expression<Func<string>> bodycustomVocabularyId = null, Expression<Func<bodycustomVocabulariesInputItem[]>> bodycustomVocabularies = null, Expression<Func<string>> bodylanguage = null)
        {
            var __workflow_bodysourceConfigurl = WorkflowExpression.Compile(bodysourceConfigurl, nameof(bodysourceConfigurl), required: true);
            var __workflow_bodysourceConfigauthHeadersauthorization = WorkflowExpression.Compile(bodysourceConfigauthHeadersauthorization, nameof(bodysourceConfigauthHeadersauthorization), required: false);
            var __workflow_bodymetadata = WorkflowExpression.Compile(bodymetadata, nameof(bodymetadata), required: false);
            var __workflow_bodynotificationConfigurl = WorkflowExpression.Compile(bodynotificationConfigurl, nameof(bodynotificationConfigurl), required: false);
            var __workflow_bodynotificationConfigauthHeadersauthorization = WorkflowExpression.Compile(bodynotificationConfigauthHeadersauthorization, nameof(bodynotificationConfigauthHeadersauthorization), required: false);
            var __workflow_bodydeleteAfterSeconds = WorkflowExpression.Compile(bodydeleteAfterSeconds, nameof(bodydeleteAfterSeconds), required: false);
            var __workflow_bodytranscriber = WorkflowExpression.Compile(bodytranscriber, nameof(bodytranscriber), required: false);
            var __workflow_bodyverbatim = WorkflowExpression.Compile(bodyverbatim, nameof(bodyverbatim), required: false);
            var __workflow_bodyrush = WorkflowExpression.Compile(bodyrush, nameof(bodyrush), required: false);
            var __workflow_bodytestMode = WorkflowExpression.Compile(bodytestMode, nameof(bodytestMode), required: false);
            var __workflow_bodysegmentsToTranscribe = WorkflowExpression.Compile(bodysegmentsToTranscribe, nameof(bodysegmentsToTranscribe), required: false);
            var __workflow_bodyspeakersNames = WorkflowExpression.Compile(bodyspeakersNames, nameof(bodyspeakersNames), required: false);
            var __workflow_bodyskipDiarization = WorkflowExpression.Compile(bodyskipDiarization, nameof(bodyskipDiarization), required: false);
            var __workflow_bodyskipPostprocessing = WorkflowExpression.Compile(bodyskipPostprocessing, nameof(bodyskipPostprocessing), required: false);
            var __workflow_bodyskipPunctuation = WorkflowExpression.Compile(bodyskipPunctuation, nameof(bodyskipPunctuation), required: false);
            var __workflow_bodyremoveDisfluencies = WorkflowExpression.Compile(bodyremoveDisfluencies, nameof(bodyremoveDisfluencies), required: false);
            var __workflow_bodyremoveAtmospherics = WorkflowExpression.Compile(bodyremoveAtmospherics, nameof(bodyremoveAtmospherics), required: false);
            var __workflow_bodyfilterProfanity = WorkflowExpression.Compile(bodyfilterProfanity, nameof(bodyfilterProfanity), required: false);
            var __workflow_bodyspeakerChannelsCount = WorkflowExpression.Compile(bodyspeakerChannelsCount, nameof(bodyspeakerChannelsCount), required: false);
            var __workflow_bodyspeakersCount = WorkflowExpression.Compile(bodyspeakersCount, nameof(bodyspeakersCount), required: false);
            var __workflow_bodycustomVocabularyId = WorkflowExpression.Compile(bodycustomVocabularyId, nameof(bodycustomVocabularyId), required: false);
            var __workflow_bodycustomVocabularies = WorkflowExpression.Compile(bodycustomVocabularies, nameof(bodycustomVocabularies), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            return new DeferredBodyAction<TranscriptionPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/speechtotext/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceConfigObject = new JObject();
                var sourceConfigObjectpropCount = 0;
                sourceConfigObjectpropCount++;
                sourceConfigObject["url"] = ExpressionConverter.ConvertO(__workflow_bodysourceConfigurl);
                var authHeadersObject = new JObject();
                var authHeadersObjectpropCount = 0;
                if (__workflow_bodysourceConfigauthHeadersauthorization != null)
                {
                    authHeadersObject["Authorization"] = ExpressionConverter.ConvertO(__workflow_bodysourceConfigauthHeadersauthorization);
                    authHeadersObjectpropCount++;
                }

                if (authHeadersObjectpropCount > 0)
                {
                    sourceConfigObject["auth_headers"] = authHeadersObject;
                    sourceConfigObjectpropCount++;
                }

                if (sourceConfigObjectpropCount > 0)
                {
                    body["source_config"] = sourceConfigObject;
                    bodypropCount++;
                }

                if (__workflow_bodymetadata != null)
                {
                    body["metadata"] = ExpressionConverter.ConvertO(__workflow_bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (__workflow_bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = ExpressionConverter.ConvertO(__workflow_bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                var authHeadersObject2 = new JObject();
                var authHeadersObject2propCount = 0;
                if (__workflow_bodynotificationConfigauthHeadersauthorization != null)
                {
                    authHeadersObject2["Authorization"] = ExpressionConverter.ConvertO(__workflow_bodynotificationConfigauthHeadersauthorization);
                    authHeadersObject2propCount++;
                }

                if (authHeadersObject2propCount > 0)
                {
                    notificationConfigObject["auth_headers"] = authHeadersObject2;
                    notificationConfigObjectpropCount++;
                }

                if (notificationConfigObjectpropCount > 0)
                {
                    body["notification_config"] = notificationConfigObject;
                    bodypropCount++;
                }

                if (__workflow_bodydeleteAfterSeconds != null)
                {
                    body["delete_after_seconds"] = ExpressionConverter.ConvertO(__workflow_bodydeleteAfterSeconds);
                    bodypropCount++;
                }

                if (__workflow_bodytranscriber != null)
                {
                    body["transcriber"] = ExpressionConverter.ConvertO(__workflow_bodytranscriber);
                    bodypropCount++;
                }

                if (__workflow_bodyverbatim != null)
                {
                    body["verbatim"] = ExpressionConverter.ConvertO(__workflow_bodyverbatim);
                    bodypropCount++;
                }

                if (__workflow_bodyrush != null)
                {
                    body["rush"] = ExpressionConverter.ConvertO(__workflow_bodyrush);
                    bodypropCount++;
                }

                if (__workflow_bodytestMode != null)
                {
                    body["test_mode"] = ExpressionConverter.ConvertO(__workflow_bodytestMode);
                    bodypropCount++;
                }

                if (__workflow_bodysegmentsToTranscribe != null)
                {
                    body["segments_to_transcribe"] = ExpressionConverter.ConvertO(__workflow_bodysegmentsToTranscribe);
                    bodypropCount++;
                }

                if (__workflow_bodyspeakersNames != null)
                {
                    body["speakers_names"] = ExpressionConverter.ConvertO(__workflow_bodyspeakersNames);
                    bodypropCount++;
                }

                if (__workflow_bodyskipDiarization != null)
                {
                    body["skip_diarization"] = ExpressionConverter.ConvertO(__workflow_bodyskipDiarization);
                    bodypropCount++;
                }

                if (__workflow_bodyskipPostprocessing != null)
                {
                    body["skip_postprocessing"] = ExpressionConverter.ConvertO(__workflow_bodyskipPostprocessing);
                    bodypropCount++;
                }

                if (__workflow_bodyskipPunctuation != null)
                {
                    body["skip_punctuation"] = ExpressionConverter.ConvertO(__workflow_bodyskipPunctuation);
                    bodypropCount++;
                }

                if (__workflow_bodyremoveDisfluencies != null)
                {
                    body["remove_disfluencies"] = ExpressionConverter.ConvertO(__workflow_bodyremoveDisfluencies);
                    bodypropCount++;
                }

                if (__workflow_bodyremoveAtmospherics != null)
                {
                    body["remove_atmospherics"] = ExpressionConverter.ConvertO(__workflow_bodyremoveAtmospherics);
                    bodypropCount++;
                }

                if (__workflow_bodyfilterProfanity != null)
                {
                    body["filter_profanity"] = ExpressionConverter.ConvertO(__workflow_bodyfilterProfanity);
                    bodypropCount++;
                }

                if (__workflow_bodyspeakerChannelsCount != null)
                {
                    body["speaker_channels_count"] = ExpressionConverter.ConvertO(__workflow_bodyspeakerChannelsCount);
                    bodypropCount++;
                }

                if (__workflow_bodyspeakersCount != null)
                {
                    body["speakers_count"] = ExpressionConverter.ConvertO(__workflow_bodyspeakersCount);
                    bodypropCount++;
                }

                if (__workflow_bodycustomVocabularyId != null)
                {
                    body["custom_vocabulary_id"] = ExpressionConverter.ConvertO(__workflow_bodycustomVocabularyId);
                    bodypropCount++;
                }

                if (__workflow_bodycustomVocabularies != null)
                {
                    body["custom_vocabularies"] = ExpressionConverter.ConvertO(__workflow_bodycustomVocabularies);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TranscriptionPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<TranscriptGetResponse, ApiConnectionActionConfiguration> TranscriptGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TranscriptGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/speechtotext/v1/jobs/{0}/transcript", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TranscriptGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CaptionsGet(Expression<Func<string>> id, Expression<Func<acceptInput>> accept = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/speechtotext/v1/jobs/{0}/captions", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/x-subrip");
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AccountGetResponse, ApiConnectionActionConfiguration> AccountGet()
        {
            return new DeferredBodyAction<AccountGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/speechtotext/v1/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AccountGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<VocabulariesGetResponseItem[], ApiConnectionActionConfiguration> VocabulariesGet(Expression<Func<int>> limit = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<VocabulariesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/speechtotext/v1/vocabularies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<VocabulariesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<VocabularyPostResponse, ApiConnectionActionConfiguration> Vocabulary(Expression<Func<string>> bodymetadata = null, Expression<Func<string>> bodynotificationConfigurl = null, Expression<Func<string>> bodynotificationConfigauthHeadersauthorization = null, Expression<Func<bodycustomVocabulariesInputItem[]>> bodycustomVocabularies = null)
        {
            var __workflow_bodymetadata = WorkflowExpression.Compile(bodymetadata, nameof(bodymetadata), required: false);
            var __workflow_bodynotificationConfigurl = WorkflowExpression.Compile(bodynotificationConfigurl, nameof(bodynotificationConfigurl), required: false);
            var __workflow_bodynotificationConfigauthHeadersauthorization = WorkflowExpression.Compile(bodynotificationConfigauthHeadersauthorization, nameof(bodynotificationConfigauthHeadersauthorization), required: false);
            var __workflow_bodycustomVocabularies = WorkflowExpression.Compile(bodycustomVocabularies, nameof(bodycustomVocabularies), required: false);
            return new DeferredBodyAction<VocabularyPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/speechtotext/v1/vocabularies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymetadata != null)
                {
                    body["metadata"] = ExpressionConverter.ConvertO(__workflow_bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (__workflow_bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = ExpressionConverter.ConvertO(__workflow_bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                var authHeadersObject = new JObject();
                var authHeadersObjectpropCount = 0;
                if (__workflow_bodynotificationConfigauthHeadersauthorization != null)
                {
                    authHeadersObject["Authorization"] = ExpressionConverter.ConvertO(__workflow_bodynotificationConfigauthHeadersauthorization);
                    authHeadersObjectpropCount++;
                }

                if (authHeadersObjectpropCount > 0)
                {
                    notificationConfigObject["auth_headers"] = authHeadersObject;
                    notificationConfigObjectpropCount++;
                }

                if (notificationConfigObjectpropCount > 0)
                {
                    body["notification_config"] = notificationConfigObject;
                    bodypropCount++;
                }

                if (__workflow_bodycustomVocabularies != null)
                {
                    body["custom_vocabularies"] = ExpressionConverter.ConvertO(__workflow_bodycustomVocabularies);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<VocabularyPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<VocabularyGetResponse, ApiConnectionActionConfiguration> VocabularyGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<VocabularyGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/speechtotext/v1/vocabularies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VocabularyGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> VocabularyDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/speechtotext/v1/vocabularies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionsGetResponseItem[], ApiConnectionActionConfiguration> ExtractionsGet(Expression<Func<int>> limit = null, Expression<Func<string>> startingAfter = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_startingAfter = WorkflowExpression.Compile(startingAfter, nameof(startingAfter), required: false);
            return new DeferredBodyAction<ExtractionsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/topic_extraction/v1/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_startingAfter != null)
                    callPayload.Queries["starting_after"] = ExpressionConverter.Convert(__workflow_startingAfter);
                return new ApiConnectionAction<ExtractionsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionPostResponse, ApiConnectionActionConfiguration> Extraction(Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodymetadata = null, Expression<Func<string>> bodynotificationConfigurl = null, Expression<Func<string>> bodynotificationConfigauthHeadersauthorization = null, Expression<Func<int>> bodydeleteAfterSeconds = null, Expression<Func<bodyjsonmonologuesInputItem[]>> bodyjsonmonologues = null)
        {
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodymetadata = WorkflowExpression.Compile(bodymetadata, nameof(bodymetadata), required: false);
            var __workflow_bodynotificationConfigurl = WorkflowExpression.Compile(bodynotificationConfigurl, nameof(bodynotificationConfigurl), required: false);
            var __workflow_bodynotificationConfigauthHeadersauthorization = WorkflowExpression.Compile(bodynotificationConfigauthHeadersauthorization, nameof(bodynotificationConfigauthHeadersauthorization), required: false);
            var __workflow_bodydeleteAfterSeconds = WorkflowExpression.Compile(bodydeleteAfterSeconds, nameof(bodydeleteAfterSeconds), required: false);
            var __workflow_bodyjsonmonologues = WorkflowExpression.Compile(bodyjsonmonologues, nameof(bodyjsonmonologues), required: false);
            return new DeferredBodyAction<ExtractionPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/topic_extraction/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodymetadata != null)
                {
                    body["metadata"] = ExpressionConverter.ConvertO(__workflow_bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (__workflow_bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = ExpressionConverter.ConvertO(__workflow_bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                var authHeadersObject = new JObject();
                var authHeadersObjectpropCount = 0;
                if (__workflow_bodynotificationConfigauthHeadersauthorization != null)
                {
                    authHeadersObject["Authorization"] = ExpressionConverter.ConvertO(__workflow_bodynotificationConfigauthHeadersauthorization);
                    authHeadersObjectpropCount++;
                }

                if (authHeadersObjectpropCount > 0)
                {
                    notificationConfigObject["auth_headers"] = authHeadersObject;
                    notificationConfigObjectpropCount++;
                }

                if (notificationConfigObjectpropCount > 0)
                {
                    body["notification_config"] = notificationConfigObject;
                    bodypropCount++;
                }

                if (__workflow_bodydeleteAfterSeconds != null)
                {
                    body["delete_after_seconds"] = ExpressionConverter.ConvertO(__workflow_bodydeleteAfterSeconds);
                    bodypropCount++;
                }

                var jsonObject = new JObject();
                var jsonObjectpropCount = 0;
                if (__workflow_bodyjsonmonologues != null)
                {
                    jsonObject["monologues"] = ExpressionConverter.ConvertO(__workflow_bodyjsonmonologues);
                    jsonObjectpropCount++;
                }

                if (jsonObjectpropCount > 0)
                {
                    body["json"] = jsonObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExtractionPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionGetResponse, ApiConnectionActionConfiguration> ExtractionGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ExtractionGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/topic_extraction/v1/jobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExtractionGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExtractionDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/topic_extraction/v1/jobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionResultGetResponse, ApiConnectionActionConfiguration> ExtractionResultGet(Expression<Func<string>> id, Expression<Func<double>> threshold = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_threshold = WorkflowExpression.Compile(threshold, nameof(threshold), required: false);
            return new DeferredBodyAction<ExtractionResultGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/topic_extraction/v1/jobs/{0}/result", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_threshold != null)
                    callPayload.Queries["threshold"] = ExpressionConverter.Convert(__workflow_threshold);
                return new ApiConnectionAction<ExtractionResultGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AnalysisesGet(Expression<Func<int>> limit = null, Expression<Func<string>> startingAfter = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_startingAfter = WorkflowExpression.Compile(startingAfter, nameof(startingAfter), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sentiment_analysis/v1/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_startingAfter != null)
                    callPayload.Queries["starting_after"] = ExpressionConverter.Convert(__workflow_startingAfter);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AnalysisPostResponse, ApiConnectionActionConfiguration> Analysis(Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodymetadata = null, Expression<Func<string>> bodynotificationConfigurl = null, Expression<Func<string>> bodynotificationConfigauthHeadersauthorization = null, Expression<Func<int>> bodydeleteAfterSeconds = null, Expression<Func<bodyjsonmonologuesInputItem[]>> bodyjsonmonologues = null)
        {
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodymetadata = WorkflowExpression.Compile(bodymetadata, nameof(bodymetadata), required: false);
            var __workflow_bodynotificationConfigurl = WorkflowExpression.Compile(bodynotificationConfigurl, nameof(bodynotificationConfigurl), required: false);
            var __workflow_bodynotificationConfigauthHeadersauthorization = WorkflowExpression.Compile(bodynotificationConfigauthHeadersauthorization, nameof(bodynotificationConfigauthHeadersauthorization), required: false);
            var __workflow_bodydeleteAfterSeconds = WorkflowExpression.Compile(bodydeleteAfterSeconds, nameof(bodydeleteAfterSeconds), required: false);
            var __workflow_bodyjsonmonologues = WorkflowExpression.Compile(bodyjsonmonologues, nameof(bodyjsonmonologues), required: false);
            return new DeferredBodyAction<AnalysisPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sentiment_analysis/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodymetadata != null)
                {
                    body["metadata"] = ExpressionConverter.ConvertO(__workflow_bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (__workflow_bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = ExpressionConverter.ConvertO(__workflow_bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                var authHeadersObject = new JObject();
                var authHeadersObjectpropCount = 0;
                if (__workflow_bodynotificationConfigauthHeadersauthorization != null)
                {
                    authHeadersObject["Authorization"] = ExpressionConverter.ConvertO(__workflow_bodynotificationConfigauthHeadersauthorization);
                    authHeadersObjectpropCount++;
                }

                if (authHeadersObjectpropCount > 0)
                {
                    notificationConfigObject["auth_headers"] = authHeadersObject;
                    notificationConfigObjectpropCount++;
                }

                if (notificationConfigObjectpropCount > 0)
                {
                    body["notification_config"] = notificationConfigObject;
                    bodypropCount++;
                }

                if (__workflow_bodydeleteAfterSeconds != null)
                {
                    body["delete_after_seconds"] = ExpressionConverter.ConvertO(__workflow_bodydeleteAfterSeconds);
                    bodypropCount++;
                }

                var jsonObject = new JObject();
                var jsonObjectpropCount = 0;
                if (__workflow_bodyjsonmonologues != null)
                {
                    jsonObject["monologues"] = ExpressionConverter.ConvertO(__workflow_bodyjsonmonologues);
                    jsonObjectpropCount++;
                }

                if (jsonObjectpropCount > 0)
                {
                    body["json"] = jsonObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AnalysisPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AnalysisGetResponse, ApiConnectionActionConfiguration> AnalysisGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AnalysisGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sentiment_analysis/v1/jobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AnalysisGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AnalysisDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sentiment_analysis/v1/jobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AnalysisResultGetResponse, ApiConnectionActionConfiguration> AnalysisResultGet(Expression<Func<string>> id, Expression<Func<filterForInput>> filterFor = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_filterFor = WorkflowExpression.Compile(filterFor, nameof(filterFor), required: false);
            return new DeferredBodyAction<AnalysisResultGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sentiment_analysis/v1/jobs/{0}/result", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filterFor != null)
                    callPayload.Queries["filter_for"] = ExpressionConverter.Convert(__workflow_filterFor);
                return new ApiConnectionAction<AnalysisResultGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationsGetResponseItem[], ApiConnectionActionConfiguration> IdentificationsGet(Expression<Func<int>> limit = null, Expression<Func<string>> startingAfter = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_startingAfter = WorkflowExpression.Compile(startingAfter, nameof(startingAfter), required: false);
            return new DeferredBodyAction<IdentificationsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/languageid/v1/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_startingAfter != null)
                    callPayload.Queries["starting_after"] = ExpressionConverter.Convert(__workflow_startingAfter);
                return new ApiConnectionAction<IdentificationsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationPostResponse, ApiConnectionActionConfiguration> Identification(Expression<Func<string>> bodymetadata = null, Expression<Func<string>> bodynotificationConfigurl = null, Expression<Func<int>> bodydeleteAfterSeconds = null, Expression<Func<string>> bodysourceConfigurl = null)
        {
            var __workflow_bodymetadata = WorkflowExpression.Compile(bodymetadata, nameof(bodymetadata), required: false);
            var __workflow_bodynotificationConfigurl = WorkflowExpression.Compile(bodynotificationConfigurl, nameof(bodynotificationConfigurl), required: false);
            var __workflow_bodydeleteAfterSeconds = WorkflowExpression.Compile(bodydeleteAfterSeconds, nameof(bodydeleteAfterSeconds), required: false);
            var __workflow_bodysourceConfigurl = WorkflowExpression.Compile(bodysourceConfigurl, nameof(bodysourceConfigurl), required: false);
            return new DeferredBodyAction<IdentificationPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/languageid/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymetadata != null)
                {
                    body["metadata"] = ExpressionConverter.ConvertO(__workflow_bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (__workflow_bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = ExpressionConverter.ConvertO(__workflow_bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                if (notificationConfigObjectpropCount > 0)
                {
                    body["notification_config"] = notificationConfigObject;
                    bodypropCount++;
                }

                if (__workflow_bodydeleteAfterSeconds != null)
                {
                    body["delete_after_seconds"] = ExpressionConverter.ConvertO(__workflow_bodydeleteAfterSeconds);
                    bodypropCount++;
                }

                var sourceConfigObject = new JObject();
                var sourceConfigObjectpropCount = 0;
                if (__workflow_bodysourceConfigurl != null)
                {
                    sourceConfigObject["url"] = ExpressionConverter.ConvertO(__workflow_bodysourceConfigurl);
                    sourceConfigObjectpropCount++;
                }

                if (sourceConfigObjectpropCount > 0)
                {
                    body["source_config"] = sourceConfigObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IdentificationPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationGetResponse, ApiConnectionActionConfiguration> IdentificationGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<IdentificationGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/languageid/v1/jobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IdentificationGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> IdentificationDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/languageid/v1/jobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationResultGetResponse, ApiConnectionActionConfiguration> IdentificationResultGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<IdentificationResultGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/languageid/v1/jobs/{0}/result", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IdentificationResultGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentsGetResponseItem[], ApiConnectionActionConfiguration> AlignmentsGet(Expression<Func<int>> limit = null, Expression<Func<string>> startingAfter = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_startingAfter = WorkflowExpression.Compile(startingAfter, nameof(startingAfter), required: false);
            return new DeferredBodyAction<AlignmentsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/alignment/v1/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_startingAfter != null)
                    callPayload.Queries["starting_after"] = ExpressionConverter.Convert(__workflow_startingAfter);
                return new ApiConnectionAction<AlignmentsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentPostResponse, ApiConnectionActionConfiguration> Alignment(Expression<Func<string>> bodymetadata = null, Expression<Func<string>> bodynotificationConfigurl = null, Expression<Func<int>> bodydeleteAfterSeconds = null, Expression<Func<string>> bodysourceConfigurl = null, Expression<Func<string>> bodytranscriptText = null, Expression<Func<bodylanguageInput>> bodylanguage = null)
        {
            var __workflow_bodymetadata = WorkflowExpression.Compile(bodymetadata, nameof(bodymetadata), required: false);
            var __workflow_bodynotificationConfigurl = WorkflowExpression.Compile(bodynotificationConfigurl, nameof(bodynotificationConfigurl), required: false);
            var __workflow_bodydeleteAfterSeconds = WorkflowExpression.Compile(bodydeleteAfterSeconds, nameof(bodydeleteAfterSeconds), required: false);
            var __workflow_bodysourceConfigurl = WorkflowExpression.Compile(bodysourceConfigurl, nameof(bodysourceConfigurl), required: false);
            var __workflow_bodytranscriptText = WorkflowExpression.Compile(bodytranscriptText, nameof(bodytranscriptText), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            return new DeferredBodyAction<AlignmentPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/alignment/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymetadata != null)
                {
                    body["metadata"] = ExpressionConverter.ConvertO(__workflow_bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (__workflow_bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = ExpressionConverter.ConvertO(__workflow_bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                if (notificationConfigObjectpropCount > 0)
                {
                    body["notification_config"] = notificationConfigObject;
                    bodypropCount++;
                }

                if (__workflow_bodydeleteAfterSeconds != null)
                {
                    body["delete_after_seconds"] = ExpressionConverter.ConvertO(__workflow_bodydeleteAfterSeconds);
                    bodypropCount++;
                }

                var sourceConfigObject = new JObject();
                var sourceConfigObjectpropCount = 0;
                if (__workflow_bodysourceConfigurl != null)
                {
                    sourceConfigObject["url"] = ExpressionConverter.ConvertO(__workflow_bodysourceConfigurl);
                    sourceConfigObjectpropCount++;
                }

                if (sourceConfigObjectpropCount > 0)
                {
                    body["source_config"] = sourceConfigObject;
                    bodypropCount++;
                }

                if (__workflow_bodytranscriptText != null)
                {
                    body["transcript_text"] = ExpressionConverter.ConvertO(__workflow_bodytranscriptText);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    if (__workflow_bodylanguage != null)
                    {
                        body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AlignmentPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentGetResponse, ApiConnectionActionConfiguration> AlignmentGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AlignmentGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/alignment/v1/jobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AlignmentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AlignmentDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/alignment/v1/jobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentTranscriptGetResponse, ApiConnectionActionConfiguration> AlignmentTranscriptGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AlignmentTranscriptGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/alignment/v1/jobs/{0}/transcript", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AlignmentTranscriptGetResponse>(callPayload);
            });
        }
    }

    public class RevaiTriggers([ConnectionName] string connectionId)
    {
    }

    public class TranscriptionGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("transcriber")]
        public string Transcriber { get; set; }
    }

    public class TranscriptionsGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("delete_after_seconds")]
        public int DeleteAfterSeconds { get; set; }

        [JsonProperty("transcriber")]
        public string Transcriber { get; set; }
    }

    public class TranscriptionPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("transcriber")]
        public string Transcriber { get; set; }
    }

    public class bodysegmentsToTranscribeInputItem
    {
        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }

    public class bodyspeakersNamesInputItem
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }

    public class bodycustomVocabulariesInputItem
    {
        [JsonProperty("phrases")]
        public string[] Phrases { get; set; }
    }

    public class TranscriptGetResponse
    {
        [JsonProperty("monologues")]
        public TranscriptGetResponseMonologuesTypeItem[] Monologues { get; set; }
    }

    public class TranscriptGetResponseMonologuesTypeItem
    {
        [JsonProperty("speaker")]
        public int Speaker { get; set; }

        [JsonProperty("elements")]
        public TranscriptGetResponseMonologuesTypeItemElementsTypeItem[] Elements { get; set; }
    }

    public class TranscriptGetResponseMonologuesTypeItemElementsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("ts")]
        public double Ts { get; set; }

        [JsonProperty("end_ts")]
        public double EndTs { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum acceptInput
    {
        [EnumMember(Value = "application/x-subrip")]
        ApplicationXSubrip,
        [EnumMember(Value = "text/vtt")]
        TextVtt
    }

    public class AccountGetResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("free_balance")]
        public double FreeBalance { get; set; }

        [JsonProperty("purchased_balance")]
        public double PurchasedBalance { get; set; }

        [JsonProperty("total_balance")]
        public int TotalBalance { get; set; }

        [JsonProperty("invoiced_balance")]
        public double InvoicedBalance { get; set; }

        [JsonProperty("balance_seconds")]
        public int BalanceSeconds { get; set; }

        [JsonProperty("hipaa_enabled")]
        public bool HipaaEnabled { get; set; }
    }

    public class VocabulariesGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("completed_on")]
        public string CompletedOn { get; set; }

        [JsonProperty("failure")]
        public string Failure { get; set; }

        [JsonProperty("failure_detail")]
        public string FailureDetail { get; set; }
    }

    public class VocabularyPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }
    }

    public class VocabularyGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }
    }

    public class ExtractionsGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("completed_on")]
        public string CompletedOn { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("word_count")]
        public int WordCount { get; set; }
    }

    public class ExtractionPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class bodyjsonmonologuesInputItem
    {
        [JsonProperty("speaker")]
        public int Speaker { get; set; }

        [JsonProperty("elements")]
        public bodyjsonmonologuesInputItemElementsTypeItem[] Elements { get; set; }
    }

    public class bodyjsonmonologuesInputItemElementsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("ts")]
        public double Ts { get; set; }

        [JsonProperty("end_ts")]
        public double EndTs { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class ExtractionGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ExtractionResultGetResponse
    {
        [JsonProperty("topics")]
        public ExtractionResultGetResponseTopicsTypeItem[] Topics { get; set; }
    }

    public class ExtractionResultGetResponseTopicsTypeItem
    {
        [JsonProperty("topic_name")]
        public string TopicName { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("informants")]
        public ExtractionResultGetResponseTopicsTypeItemInformantsTypeItem[] Informants { get; set; }
    }

    public class ExtractionResultGetResponseTopicsTypeItemInformantsTypeItem
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("ts")]
        public double Ts { get; set; }

        [JsonProperty("end_ts")]
        public double EndTs { get; set; }
    }

    public class AnalysisPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AnalysisGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AnalysisResultGetResponse
    {
        [JsonProperty("messages")]
        public AnalysisResultGetResponseMessagesTypeItem[] Messages { get; set; }
    }

    public class AnalysisResultGetResponseMessagesTypeItem
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("sentiment")]
        public string Sentiment { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }

        [JsonProperty("end_ts")]
        public double EndTs { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum filterForInput
    {
        [EnumMember(Value = "positive")]
        Positive,
        [EnumMember(Value = "negative")]
        Negative,
        [EnumMember(Value = "neutral")]
        Neutral
    }

    public class IdentificationsGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("completed_on")]
        public string CompletedOn { get; set; }
    }

    public class IdentificationPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class IdentificationGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class IdentificationResultGetResponse
    {
        [JsonProperty("top_language")]
        public string TopLanguage { get; set; }

        [JsonProperty("language_confidences")]
        public IdentificationResultGetResponseLanguageConfidencesTypeItem[] LanguageConfidences { get; set; }
    }

    public class IdentificationResultGetResponseLanguageConfidencesTypeItem
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class AlignmentsGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("completed_on")]
        public string CompletedOn { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class AlignmentPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylanguageInput
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "fr")]
        Fr
    }

    public class AlignmentGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AlignmentTranscriptGetResponse
    {
        [JsonProperty("monologues")]
        public AlignmentTranscriptGetResponseMonologuesTypeItem[] Monologues { get; set; }
    }

    public class AlignmentTranscriptGetResponseMonologuesTypeItem
    {
        [JsonProperty("speaker")]
        public int Speaker { get; set; }

        [JsonProperty("elements")]
        public AlignmentTranscriptGetResponseMonologuesTypeItemElementsTypeItem[] Elements { get; set; }
    }

    public class AlignmentTranscriptGetResponseMonologuesTypeItemElementsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("ts")]
        public double Ts { get; set; }

        [JsonProperty("end_ts")]
        public double EndTs { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Revai;

    public partial class WorkflowManagedActions
    {
        public RevaiActions Revai(string connectionId) => new RevaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RevaiTriggers Revai(string connectionId) => new RevaiTriggers(connectionId);
    }
}