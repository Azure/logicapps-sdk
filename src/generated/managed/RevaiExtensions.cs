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
        public IBodyWorkflowAction<TranscriptionGetResponse> TranscriptionGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/speechtotext/v1/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TranscriptionGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> TranscriptionDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/speechtotext/v1/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<TranscriptionsGetResponseItem[]> TranscriptionsGet(Expression<Func<int>> limit = null, Expression<Func<string>> startingAfter = null)
        {
            var apiCallPath = "/speechtotext/v1/jobs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(100);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (startingAfter != null)
                callPayload.Queries["starting_after"] = ExpressionConverter.Convert(startingAfter);
            return new ApiConnectionAction<TranscriptionsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<TranscriptGetResponse> TranscriptGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/speechtotext/v1/jobs/{0}/transcript", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TranscriptGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> CaptionsGet(Expression<Func<string>> id, Expression<Func<acceptInput>> accept = null)
        {
            var apiCallPath = String.Format("/speechtotext/v1/jobs/{0}/captions", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/x-subrip");
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AccountGetResponse> AccountGet()
        {
            var apiCallPath = "/speechtotext/v1/account";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<VocabulariesGetResponseItem[]> VocabulariesGet(Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/speechtotext/v1/vocabularies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(100);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<VocabulariesGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<VocabularyPostResponse> VocabularyPost(Expression<Func<string>> bodymetadata = null, Expression<Func<string>> bodynotificationConfigurl = null, Expression<Func<string>> bodynotificationConfigauthHeadersAuthorization = null, Expression<Func<bodycustomVocabulariesInputItem[]>> bodycustomVocabularies = null)
        {
            var apiCallPath = "/speechtotext/v1/vocabularies";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymetadata != null)
            {
                body["metadata"] = ExpressionConverter.ConvertO(bodymetadata);
                bodypropCount++;
            }

            var notification_configObject = new JObject();
            var notification_configObjectpropCount = 0;
            if (bodynotificationConfigurl != null)
            {
                notification_configObject["url"] = ExpressionConverter.ConvertO(bodynotificationConfigurl);
                notification_configObjectpropCount++;
            }

            var auth_headersObject = new JObject();
            var auth_headersObjectpropCount = 0;
            if (bodynotificationConfigauthHeadersAuthorization != null)
            {
                auth_headersObject["Authorization"] = ExpressionConverter.ConvertO(bodynotificationConfigauthHeadersAuthorization);
                auth_headersObjectpropCount++;
            }

            if (auth_headersObjectpropCount > 0)
            {
                notification_configObject["auth_headers"] = auth_headersObject;
                notification_configObjectpropCount++;
            }

            if (notification_configObjectpropCount > 0)
            {
                body["notification_config"] = notification_configObject;
                bodypropCount++;
            }

            if (bodycustomVocabularies != null)
            {
                body["custom_vocabularies"] = ExpressionConverter.ConvertO(bodycustomVocabularies);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<VocabularyPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<VocabularyGetResponse> VocabularyGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/speechtotext/v1/vocabularies/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VocabularyGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> VocabularyDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/speechtotext/v1/vocabularies/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionsGetResponseItem[]> ExtractionsGet(Expression<Func<int>> limit = null, Expression<Func<string>> startingAfter = null)
        {
            var apiCallPath = "/topic_extraction/v1/jobs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(100);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (startingAfter != null)
                callPayload.Queries["starting_after"] = ExpressionConverter.Convert(startingAfter);
            return new ApiConnectionAction<ExtractionsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionPostResponse> ExtractionPost(Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodymetadata = null, Expression<Func<string>> bodynotificationConfigurl = null, Expression<Func<string>> bodynotificationConfigauthHeadersAuthorization = null, Expression<Func<int>> bodydeleteAfterSeconds = null, Expression<Func<bodyjsonmonologuesInputItem[]>> bodyjsonmonologues = null)
        {
            var apiCallPath = "/topic_extraction/v1/jobs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodymetadata != null)
            {
                body["metadata"] = ExpressionConverter.ConvertO(bodymetadata);
                bodypropCount++;
            }

            var notification_configObject = new JObject();
            var notification_configObjectpropCount = 0;
            if (bodynotificationConfigurl != null)
            {
                notification_configObject["url"] = ExpressionConverter.ConvertO(bodynotificationConfigurl);
                notification_configObjectpropCount++;
            }

            var auth_headersObject = new JObject();
            var auth_headersObjectpropCount = 0;
            if (bodynotificationConfigauthHeadersAuthorization != null)
            {
                auth_headersObject["Authorization"] = ExpressionConverter.ConvertO(bodynotificationConfigauthHeadersAuthorization);
                auth_headersObjectpropCount++;
            }

            if (auth_headersObjectpropCount > 0)
            {
                notification_configObject["auth_headers"] = auth_headersObject;
                notification_configObjectpropCount++;
            }

            if (notification_configObjectpropCount > 0)
            {
                body["notification_config"] = notification_configObject;
                bodypropCount++;
            }

            if (bodydeleteAfterSeconds != null)
            {
                body["delete_after_seconds"] = ExpressionConverter.ConvertO(bodydeleteAfterSeconds);
                bodypropCount++;
            }

            var jsonObject = new JObject();
            var jsonObjectpropCount = 0;
            if (bodyjsonmonologues != null)
            {
                jsonObject["monologues"] = ExpressionConverter.ConvertO(bodyjsonmonologues);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionGetResponse> ExtractionGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/topic_extraction/v1/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ExtractionGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> ExtractionDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/topic_extraction/v1/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<ExtractionResultGetResponse> ExtractionResultGet(Expression<Func<string>> id, Expression<Func<double>> threshold = null)
        {
            var apiCallPath = String.Format("/topic_extraction/v1/jobs/{0}/result", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (threshold != null)
                callPayload.Queries["threshold"] = ExpressionConverter.Convert(threshold);
            return new ApiConnectionAction<ExtractionResultGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IWorkflowAction AnalysisesGet(Expression<Func<int>> limit = null, Expression<Func<string>> startingAfter = null)
        {
            var apiCallPath = "/sentiment_analysis/v1/jobs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(100);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (startingAfter != null)
                callPayload.Queries["starting_after"] = ExpressionConverter.Convert(startingAfter);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AnalysisPostResponse> AnalysisPost(Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodymetadata = null, Expression<Func<string>> bodynotificationConfigurl = null, Expression<Func<string>> bodynotificationConfigauthHeadersAuthorization = null, Expression<Func<int>> bodydeleteAfterSeconds = null, Expression<Func<bodyjsonmonologuesInputItem[]>> bodyjsonmonologues = null)
        {
            var apiCallPath = "/sentiment_analysis/v1/jobs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodymetadata != null)
            {
                body["metadata"] = ExpressionConverter.ConvertO(bodymetadata);
                bodypropCount++;
            }

            var notification_configObject = new JObject();
            var notification_configObjectpropCount = 0;
            if (bodynotificationConfigurl != null)
            {
                notification_configObject["url"] = ExpressionConverter.ConvertO(bodynotificationConfigurl);
                notification_configObjectpropCount++;
            }

            var auth_headersObject = new JObject();
            var auth_headersObjectpropCount = 0;
            if (bodynotificationConfigauthHeadersAuthorization != null)
            {
                auth_headersObject["Authorization"] = ExpressionConverter.ConvertO(bodynotificationConfigauthHeadersAuthorization);
                auth_headersObjectpropCount++;
            }

            if (auth_headersObjectpropCount > 0)
            {
                notification_configObject["auth_headers"] = auth_headersObject;
                notification_configObjectpropCount++;
            }

            if (notification_configObjectpropCount > 0)
            {
                body["notification_config"] = notification_configObject;
                bodypropCount++;
            }

            if (bodydeleteAfterSeconds != null)
            {
                body["delete_after_seconds"] = ExpressionConverter.ConvertO(bodydeleteAfterSeconds);
                bodypropCount++;
            }

            var jsonObject = new JObject();
            var jsonObjectpropCount = 0;
            if (bodyjsonmonologues != null)
            {
                jsonObject["monologues"] = ExpressionConverter.ConvertO(bodyjsonmonologues);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AnalysisGetResponse> AnalysisGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/sentiment_analysis/v1/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AnalysisGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> AnalysisDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/sentiment_analysis/v1/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AnalysisResultGetResponse> AnalysisResultGet(Expression<Func<string>> id, Expression<Func<filterForInput>> filterFor = null)
        {
            var apiCallPath = String.Format("/sentiment_analysis/v1/jobs/{0}/result", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filterFor != null)
                callPayload.Queries["filter_for"] = ExpressionConverter.Convert(filterFor);
            return new ApiConnectionAction<AnalysisResultGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationsGetResponseItem[]> IdentificationsGet(Expression<Func<int>> limit = null, Expression<Func<string>> startingAfter = null)
        {
            var apiCallPath = "/languageid/v1/jobs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(100);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (startingAfter != null)
                callPayload.Queries["starting_after"] = ExpressionConverter.Convert(startingAfter);
            return new ApiConnectionAction<IdentificationsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationPostResponse> IdentificationPost(Expression<Func<string>> bodymetadata = null, Expression<Func<string>> bodynotificationConfigurl = null, Expression<Func<int>> bodydeleteAfterSeconds = null, Expression<Func<string>> bodysourceConfigurl = null)
        {
            var apiCallPath = "/languageid/v1/jobs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymetadata != null)
            {
                body["metadata"] = ExpressionConverter.ConvertO(bodymetadata);
                bodypropCount++;
            }

            var notification_configObject = new JObject();
            var notification_configObjectpropCount = 0;
            if (bodynotificationConfigurl != null)
            {
                notification_configObject["url"] = ExpressionConverter.ConvertO(bodynotificationConfigurl);
                notification_configObjectpropCount++;
            }

            if (notification_configObjectpropCount > 0)
            {
                body["notification_config"] = notification_configObject;
                bodypropCount++;
            }

            if (bodydeleteAfterSeconds != null)
            {
                body["delete_after_seconds"] = ExpressionConverter.ConvertO(bodydeleteAfterSeconds);
                bodypropCount++;
            }

            var source_configObject = new JObject();
            var source_configObjectpropCount = 0;
            if (bodysourceConfigurl != null)
            {
                source_configObject["url"] = ExpressionConverter.ConvertO(bodysourceConfigurl);
                source_configObjectpropCount++;
            }

            if (source_configObjectpropCount > 0)
            {
                body["source_config"] = source_configObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IdentificationPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationGetResponse> IdentificationGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/languageid/v1/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IdentificationGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> IdentificationDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/languageid/v1/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<IdentificationResultGetResponse> IdentificationResultGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/languageid/v1/jobs/{0}/result", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IdentificationResultGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentsGetResponseItem[]> AlignmentsGet(Expression<Func<int>> limit = null, Expression<Func<string>> startingAfter = null)
        {
            var apiCallPath = "/alignment/v1/jobs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(100);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (startingAfter != null)
                callPayload.Queries["starting_after"] = ExpressionConverter.Convert(startingAfter);
            return new ApiConnectionAction<AlignmentsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentPostResponse> AlignmentPost(Expression<Func<string>> bodymetadata = null, Expression<Func<string>> bodynotificationConfigurl = null, Expression<Func<int>> bodydeleteAfterSeconds = null, Expression<Func<string>> bodysourceConfigurl = null, Expression<Func<string>> bodytranscriptText = null, Expression<Func<bodylanguageInput>> bodylanguage = null)
        {
            var apiCallPath = "/alignment/v1/jobs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymetadata != null)
            {
                body["metadata"] = ExpressionConverter.ConvertO(bodymetadata);
                bodypropCount++;
            }

            var notification_configObject = new JObject();
            var notification_configObjectpropCount = 0;
            if (bodynotificationConfigurl != null)
            {
                notification_configObject["url"] = ExpressionConverter.ConvertO(bodynotificationConfigurl);
                notification_configObjectpropCount++;
            }

            if (notification_configObjectpropCount > 0)
            {
                body["notification_config"] = notification_configObject;
                bodypropCount++;
            }

            if (bodydeleteAfterSeconds != null)
            {
                body["delete_after_seconds"] = ExpressionConverter.ConvertO(bodydeleteAfterSeconds);
                bodypropCount++;
            }

            var source_configObject = new JObject();
            var source_configObjectpropCount = 0;
            if (bodysourceConfigurl != null)
            {
                source_configObject["url"] = ExpressionConverter.ConvertO(bodysourceConfigurl);
                source_configObjectpropCount++;
            }

            if (source_configObjectpropCount > 0)
            {
                body["source_config"] = source_configObject;
                bodypropCount++;
            }

            if (bodytranscriptText != null)
            {
                body["transcript_text"] = ExpressionConverter.ConvertO(bodytranscriptText);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AlignmentPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentGetResponse> AlignmentGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/alignment/v1/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AlignmentGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<string> AlignmentDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/alignment/v1/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revai")]
        public IBodyWorkflowAction<AlignmentTranscriptGetResponse> AlignmentTranscriptGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/alignment/v1/jobs/{0}/transcript", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AlignmentTranscriptGetResponse>(callPayload);
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

    public class bodycustomVocabulariesInputItem
    {
        [JsonProperty("phrases")]
        public string[] Phrases { get; set; }
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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