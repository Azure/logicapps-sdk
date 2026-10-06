//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Revai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RevaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<TranscriptionGetResponse> TranscriptionGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/speechtotext/v1/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TranscriptionGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> TranscriptionDelete([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/speechtotext/v1/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<TranscriptionsGetResponseItem[]> TranscriptionsGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> startingAfter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/speechtotext/v1/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (startingAfter != null)
                    callPayload.Queries["starting_after"] = SourceExpressionConverter.ConvertO(startingAfter);
                return callPayload;
            }

            return new ApiConnectionAction<TranscriptionsGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<TranscriptionPostResponse> Transcription([WorkflowExpression] Func<string> bodysourceConfigurl, [WorkflowExpression] Func<string> bodysourceConfigauthHeadersauthorization = null, [WorkflowExpression] Func<string> bodymetadata = null, [WorkflowExpression] Func<string> bodynotificationConfigurl = null, [WorkflowExpression] Func<string> bodynotificationConfigauthHeadersauthorization = null, [WorkflowExpression] Func<int> bodydeleteAfterSeconds = null, [WorkflowExpression] Func<string> bodytranscriber = null, [WorkflowExpression] Func<bool> bodyverbatim = null, [WorkflowExpression] Func<bool> bodyrush = null, [WorkflowExpression] Func<bool> bodytestMode = null, [WorkflowExpression] Func<bodysegmentsToTranscribeInputItem[]> bodysegmentsToTranscribe = null, [WorkflowExpression] Func<bodyspeakersNamesInputItem[]> bodyspeakersNames = null, [WorkflowExpression] Func<bool> bodyskipDiarization = null, [WorkflowExpression] Func<bool> bodyskipPostprocessing = null, [WorkflowExpression] Func<bool> bodyskipPunctuation = null, [WorkflowExpression] Func<bool> bodyremoveDisfluencies = null, [WorkflowExpression] Func<bool> bodyremoveAtmospherics = null, [WorkflowExpression] Func<bool> bodyfilterProfanity = null, [WorkflowExpression] Func<int> bodyspeakerChannelsCount = null, [WorkflowExpression] Func<int> bodyspeakersCount = null, [WorkflowExpression] Func<string> bodycustomVocabularyId = null, [WorkflowExpression] Func<bodycustomVocabulariesInputItem[]> bodycustomVocabularies = null, [WorkflowExpression] Func<string> bodylanguage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/speechtotext/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceConfigObject = new JObject();
                var sourceConfigObjectpropCount = 0;
                sourceConfigObjectpropCount++;
                sourceConfigObject["url"] = SourceExpressionConverter.ConvertToken(bodysourceConfigurl);
                var authHeadersObject = new JObject();
                var authHeadersObjectpropCount = 0;
                if (bodysourceConfigauthHeadersauthorization != null)
                {
                    authHeadersObject["Authorization"] = SourceExpressionConverter.ConvertToken(bodysourceConfigauthHeadersauthorization);
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

                if (bodymetadata != null)
                {
                    body["metadata"] = SourceExpressionConverter.ConvertToken(bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = SourceExpressionConverter.ConvertToken(bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                var authHeadersObject2 = new JObject();
                var authHeadersObject2propCount = 0;
                if (bodynotificationConfigauthHeadersauthorization != null)
                {
                    authHeadersObject2["Authorization"] = SourceExpressionConverter.ConvertToken(bodynotificationConfigauthHeadersauthorization);
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

                if (bodydeleteAfterSeconds != null)
                {
                    body["delete_after_seconds"] = SourceExpressionConverter.ConvertToken(bodydeleteAfterSeconds);
                    bodypropCount++;
                }

                if (bodytranscriber != null)
                {
                    body["transcriber"] = SourceExpressionConverter.ConvertToken(bodytranscriber);
                    bodypropCount++;
                }

                if (bodyverbatim != null)
                {
                    body["verbatim"] = SourceExpressionConverter.ConvertToken(bodyverbatim);
                    bodypropCount++;
                }

                if (bodyrush != null)
                {
                    body["rush"] = SourceExpressionConverter.ConvertToken(bodyrush);
                    bodypropCount++;
                }

                if (bodytestMode != null)
                {
                    body["test_mode"] = SourceExpressionConverter.ConvertToken(bodytestMode);
                    bodypropCount++;
                }

                if (bodysegmentsToTranscribe != null)
                {
                    body["segments_to_transcribe"] = SourceExpressionConverter.ConvertToken(bodysegmentsToTranscribe);
                    bodypropCount++;
                }

                if (bodyspeakersNames != null)
                {
                    body["speakers_names"] = SourceExpressionConverter.ConvertToken(bodyspeakersNames);
                    bodypropCount++;
                }

                if (bodyskipDiarization != null)
                {
                    body["skip_diarization"] = SourceExpressionConverter.ConvertToken(bodyskipDiarization);
                    bodypropCount++;
                }

                if (bodyskipPostprocessing != null)
                {
                    body["skip_postprocessing"] = SourceExpressionConverter.ConvertToken(bodyskipPostprocessing);
                    bodypropCount++;
                }

                if (bodyskipPunctuation != null)
                {
                    body["skip_punctuation"] = SourceExpressionConverter.ConvertToken(bodyskipPunctuation);
                    bodypropCount++;
                }

                if (bodyremoveDisfluencies != null)
                {
                    body["remove_disfluencies"] = SourceExpressionConverter.ConvertToken(bodyremoveDisfluencies);
                    bodypropCount++;
                }

                if (bodyremoveAtmospherics != null)
                {
                    body["remove_atmospherics"] = SourceExpressionConverter.ConvertToken(bodyremoveAtmospherics);
                    bodypropCount++;
                }

                if (bodyfilterProfanity != null)
                {
                    body["filter_profanity"] = SourceExpressionConverter.ConvertToken(bodyfilterProfanity);
                    bodypropCount++;
                }

                if (bodyspeakerChannelsCount != null)
                {
                    body["speaker_channels_count"] = SourceExpressionConverter.ConvertToken(bodyspeakerChannelsCount);
                    bodypropCount++;
                }

                if (bodyspeakersCount != null)
                {
                    body["speakers_count"] = SourceExpressionConverter.ConvertToken(bodyspeakersCount);
                    bodypropCount++;
                }

                if (bodycustomVocabularyId != null)
                {
                    body["custom_vocabulary_id"] = SourceExpressionConverter.ConvertToken(bodycustomVocabularyId);
                    bodypropCount++;
                }

                if (bodycustomVocabularies != null)
                {
                    body["custom_vocabularies"] = SourceExpressionConverter.ConvertToken(bodycustomVocabularies);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TranscriptionPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<TranscriptGetResponse> TranscriptGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/speechtotext/v1/jobs/{0}/transcript", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TranscriptGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> CaptionsGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<acceptInput> accept = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/speechtotext/v1/jobs/{0}/captions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/x-subrip");
                if (accept != null)
                    callPayload.Headers["Accept"] = SourceExpressionConverter.Convert(accept);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AccountGetResponse> AccountGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/speechtotext/v1/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AccountGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<VocabulariesGetResponseItem[]> VocabulariesGet([WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/speechtotext/v1/vocabularies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<VocabulariesGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<VocabularyPostResponse> Vocabulary([WorkflowExpression] Func<string> bodymetadata = null, [WorkflowExpression] Func<string> bodynotificationConfigurl = null, [WorkflowExpression] Func<string> bodynotificationConfigauthHeadersauthorization = null, [WorkflowExpression] Func<bodycustomVocabulariesInputItem[]> bodycustomVocabularies = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/speechtotext/v1/vocabularies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymetadata != null)
                {
                    body["metadata"] = SourceExpressionConverter.ConvertToken(bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = SourceExpressionConverter.ConvertToken(bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                var authHeadersObject = new JObject();
                var authHeadersObjectpropCount = 0;
                if (bodynotificationConfigauthHeadersauthorization != null)
                {
                    authHeadersObject["Authorization"] = SourceExpressionConverter.ConvertToken(bodynotificationConfigauthHeadersauthorization);
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

                if (bodycustomVocabularies != null)
                {
                    body["custom_vocabularies"] = SourceExpressionConverter.ConvertToken(bodycustomVocabularies);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<VocabularyPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<VocabularyGetResponse> VocabularyGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/speechtotext/v1/vocabularies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VocabularyGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> VocabularyDelete([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/speechtotext/v1/vocabularies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionsGetResponseItem[]> ExtractionsGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> startingAfter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/topic_extraction/v1/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (startingAfter != null)
                    callPayload.Queries["starting_after"] = SourceExpressionConverter.ConvertO(startingAfter);
                return callPayload;
            }

            return new ApiConnectionAction<ExtractionsGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionPostResponse> Extraction([WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodymetadata = null, [WorkflowExpression] Func<string> bodynotificationConfigurl = null, [WorkflowExpression] Func<string> bodynotificationConfigauthHeadersauthorization = null, [WorkflowExpression] Func<int> bodydeleteAfterSeconds = null, [WorkflowExpression] Func<bodyjsonmonologuesInputItem[]> bodyjsonmonologues = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/topic_extraction/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodymetadata != null)
                {
                    body["metadata"] = SourceExpressionConverter.ConvertToken(bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = SourceExpressionConverter.ConvertToken(bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                var authHeadersObject = new JObject();
                var authHeadersObjectpropCount = 0;
                if (bodynotificationConfigauthHeadersauthorization != null)
                {
                    authHeadersObject["Authorization"] = SourceExpressionConverter.ConvertToken(bodynotificationConfigauthHeadersauthorization);
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

                if (bodydeleteAfterSeconds != null)
                {
                    body["delete_after_seconds"] = SourceExpressionConverter.ConvertToken(bodydeleteAfterSeconds);
                    bodypropCount++;
                }

                var jsonObject = new JObject();
                var jsonObjectpropCount = 0;
                if (bodyjsonmonologues != null)
                {
                    jsonObject["monologues"] = SourceExpressionConverter.ConvertToken(bodyjsonmonologues);
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
                return callPayload;
            }

            return new ApiConnectionAction<ExtractionPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionGetResponse> ExtractionGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/topic_extraction/v1/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExtractionGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> ExtractionDelete([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/topic_extraction/v1/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionResultGetResponse> ExtractionResultGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<double> threshold = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/topic_extraction/v1/jobs/{0}/result", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (threshold != null)
                    callPayload.Queries["threshold"] = SourceExpressionConverter.ConvertO(threshold);
                return callPayload;
            }

            return new ApiConnectionAction<ExtractionResultGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IWorkflowAction AnalysisesGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> startingAfter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sentiment_analysis/v1/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (startingAfter != null)
                    callPayload.Queries["starting_after"] = SourceExpressionConverter.ConvertO(startingAfter);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AnalysisPostResponse> Analysis([WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodymetadata = null, [WorkflowExpression] Func<string> bodynotificationConfigurl = null, [WorkflowExpression] Func<string> bodynotificationConfigauthHeadersauthorization = null, [WorkflowExpression] Func<int> bodydeleteAfterSeconds = null, [WorkflowExpression] Func<bodyjsonmonologuesInputItem[]> bodyjsonmonologues = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sentiment_analysis/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodymetadata != null)
                {
                    body["metadata"] = SourceExpressionConverter.ConvertToken(bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = SourceExpressionConverter.ConvertToken(bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                var authHeadersObject = new JObject();
                var authHeadersObjectpropCount = 0;
                if (bodynotificationConfigauthHeadersauthorization != null)
                {
                    authHeadersObject["Authorization"] = SourceExpressionConverter.ConvertToken(bodynotificationConfigauthHeadersauthorization);
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

                if (bodydeleteAfterSeconds != null)
                {
                    body["delete_after_seconds"] = SourceExpressionConverter.ConvertToken(bodydeleteAfterSeconds);
                    bodypropCount++;
                }

                var jsonObject = new JObject();
                var jsonObjectpropCount = 0;
                if (bodyjsonmonologues != null)
                {
                    jsonObject["monologues"] = SourceExpressionConverter.ConvertToken(bodyjsonmonologues);
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
                return callPayload;
            }

            return new ApiConnectionAction<AnalysisPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AnalysisGetResponse> AnalysisGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sentiment_analysis/v1/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AnalysisGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> AnalysisDelete([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sentiment_analysis/v1/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AnalysisResultGetResponse> AnalysisResultGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<filterForInput> filterFor = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sentiment_analysis/v1/jobs/{0}/result", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filterFor != null)
                    callPayload.Queries["filter_for"] = SourceExpressionConverter.Convert(filterFor);
                return callPayload;
            }

            return new ApiConnectionAction<AnalysisResultGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationsGetResponseItem[]> IdentificationsGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> startingAfter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/languageid/v1/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (startingAfter != null)
                    callPayload.Queries["starting_after"] = SourceExpressionConverter.ConvertO(startingAfter);
                return callPayload;
            }

            return new ApiConnectionAction<IdentificationsGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationPostResponse> Identification([WorkflowExpression] Func<string> bodymetadata = null, [WorkflowExpression] Func<string> bodynotificationConfigurl = null, [WorkflowExpression] Func<int> bodydeleteAfterSeconds = null, [WorkflowExpression] Func<string> bodysourceConfigurl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/languageid/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymetadata != null)
                {
                    body["metadata"] = SourceExpressionConverter.ConvertToken(bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = SourceExpressionConverter.ConvertToken(bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                if (notificationConfigObjectpropCount > 0)
                {
                    body["notification_config"] = notificationConfigObject;
                    bodypropCount++;
                }

                if (bodydeleteAfterSeconds != null)
                {
                    body["delete_after_seconds"] = SourceExpressionConverter.ConvertToken(bodydeleteAfterSeconds);
                    bodypropCount++;
                }

                var sourceConfigObject = new JObject();
                var sourceConfigObjectpropCount = 0;
                if (bodysourceConfigurl != null)
                {
                    sourceConfigObject["url"] = SourceExpressionConverter.ConvertToken(bodysourceConfigurl);
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
                return callPayload;
            }

            return new ApiConnectionAction<IdentificationPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationGetResponse> IdentificationGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/languageid/v1/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IdentificationGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> IdentificationDelete([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/languageid/v1/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationResultGetResponse> IdentificationResultGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/languageid/v1/jobs/{0}/result", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IdentificationResultGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentsGetResponseItem[]> AlignmentsGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> startingAfter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alignment/v1/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (startingAfter != null)
                    callPayload.Queries["starting_after"] = SourceExpressionConverter.ConvertO(startingAfter);
                return callPayload;
            }

            return new ApiConnectionAction<AlignmentsGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentPostResponse> Alignment([WorkflowExpression] Func<string> bodymetadata = null, [WorkflowExpression] Func<string> bodynotificationConfigurl = null, [WorkflowExpression] Func<int> bodydeleteAfterSeconds = null, [WorkflowExpression] Func<string> bodysourceConfigurl = null, [WorkflowExpression] Func<string> bodytranscriptText = null, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alignment/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymetadata != null)
                {
                    body["metadata"] = SourceExpressionConverter.ConvertToken(bodymetadata);
                    bodypropCount++;
                }

                var notificationConfigObject = new JObject();
                var notificationConfigObjectpropCount = 0;
                if (bodynotificationConfigurl != null)
                {
                    notificationConfigObject["url"] = SourceExpressionConverter.ConvertToken(bodynotificationConfigurl);
                    notificationConfigObjectpropCount++;
                }

                if (notificationConfigObjectpropCount > 0)
                {
                    body["notification_config"] = notificationConfigObject;
                    bodypropCount++;
                }

                if (bodydeleteAfterSeconds != null)
                {
                    body["delete_after_seconds"] = SourceExpressionConverter.ConvertToken(bodydeleteAfterSeconds);
                    bodypropCount++;
                }

                var sourceConfigObject = new JObject();
                var sourceConfigObjectpropCount = 0;
                if (bodysourceConfigurl != null)
                {
                    sourceConfigObject["url"] = SourceExpressionConverter.ConvertToken(bodysourceConfigurl);
                    sourceConfigObjectpropCount++;
                }

                if (sourceConfigObjectpropCount > 0)
                {
                    body["source_config"] = sourceConfigObject;
                    bodypropCount++;
                }

                if (bodytranscriptText != null)
                {
                    body["transcript_text"] = SourceExpressionConverter.ConvertToken(bodytranscriptText);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    if (bodylanguage != null)
                    {
                        body["language"] = SourceExpressionConverter.Convert(bodylanguage);
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
                return callPayload;
            }

            return new ApiConnectionAction<AlignmentPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentGetResponse> AlignmentGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alignment/v1/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AlignmentGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> AlignmentDelete([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alignment/v1/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentTranscriptGetResponse> AlignmentTranscriptGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alignment/v1/jobs/{0}/transcript", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AlignmentTranscriptGetResponse>(BuildSourceInput);
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