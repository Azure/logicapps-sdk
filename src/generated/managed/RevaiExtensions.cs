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
        public IBodyWorkflowAction<TranscriptionResponse, ApiConnectionActionConfiguration> Transcription(Expression<Func<TranscriptionBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TranscriptionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/speechtotext/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TranscriptionResponse>(callPayload);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CaptionsGet(Expression<Func<string>> id, Expression<Func<AcceptInput>> accept = null)
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
        public IBodyWorkflowAction<VocabularyResponse, ApiConnectionActionConfiguration> Vocabulary(Expression<Func<VocabularyBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<VocabularyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/speechtotext/v1/vocabularies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<VocabularyResponse>(callPayload);
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
        public IBodyWorkflowAction<ExtractionResponse, ApiConnectionActionConfiguration> Extraction(Expression<Func<AnalysisBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/topic_extraction/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractionResponse>(callPayload);
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
        public IBodyWorkflowAction<AnalysisResponse, ApiConnectionActionConfiguration> Analysis(Expression<Func<AnalysisBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AnalysisResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sentiment_analysis/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AnalysisResponse>(callPayload);
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
        public IBodyWorkflowAction<AnalysisResultGetResponse, ApiConnectionActionConfiguration> AnalysisResultGet(Expression<Func<string>> id, Expression<Func<FilterForInput>> filterFor = null)
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
        public IBodyWorkflowAction<IdentificationResponse, ApiConnectionActionConfiguration> Identification(Expression<Func<IdentificationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IdentificationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/languageid/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IdentificationResponse>(callPayload);
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
        public IBodyWorkflowAction<AlignmentResponse, ApiConnectionActionConfiguration> Alignment(Expression<Func<AlignmentBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AlignmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/alignment/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AlignmentResponse>(callPayload);
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

    public class TranscriptionResponse
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

    public class TranscriptionBodyInput
    {
        [JsonProperty("source_config")]
        public TranscriptionBodyInputSourceConfigType SourceConfig { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("notification_config", DefaultValueHandling = DefaultValueHandling.Include)]
        public TranscriptionBodyInputNotificationConfigType NotificationConfig { get; set; }

        [JsonProperty("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        [JsonProperty("transcriber")]
        public string Transcriber { get; set; }

        [JsonProperty("verbatim")]
        public bool? Verbatim { get; set; }

        [JsonProperty("rush")]
        public bool? Rush { get; set; }

        [JsonProperty("test_mode")]
        public bool? TestMode { get; set; }

        [JsonProperty("segments_to_transcribe")]
        public BodyInputSegmentsToTranscribeTypeItem[] SegmentsToTranscribe { get; set; }

        [JsonProperty("speakers_names")]
        public BodyInputSpeakersNamesTypeItem[] SpeakersNames { get; set; }

        [JsonProperty("skip_diarization")]
        public bool? SkipDiarization { get; set; }

        [JsonProperty("skip_postprocessing")]
        public bool? SkipPostprocessing { get; set; }

        [JsonProperty("skip_punctuation")]
        public bool? SkipPunctuation { get; set; }

        [JsonProperty("remove_disfluencies")]
        public bool? RemoveDisfluencies { get; set; }

        [JsonProperty("remove_atmospherics")]
        public bool? RemoveAtmospherics { get; set; }

        [JsonProperty("filter_profanity")]
        public bool? FilterProfanity { get; set; }

        [JsonProperty("speaker_channels_count")]
        public int? SpeakerChannelsCount { get; set; }

        [JsonProperty("speakers_count")]
        public int? SpeakersCount { get; set; }

        [JsonProperty("custom_vocabulary_id")]
        public string CustomVocabularyId { get; set; }

        [JsonProperty("custom_vocabularies")]
        public BodyInputCustomVocabulariesTypeItem[] CustomVocabularies { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class TranscriptionBodyInputSourceConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("auth_headers")]
        public BodyInputSourceConfigTypeAuthHeadersType AuthHeaders { get; set; }
    }

    public class BodyInputSourceConfigTypeAuthHeadersType
    {
        public string Authorization { get; set; }
    }

    public class TranscriptionBodyInputNotificationConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("auth_headers")]
        public BodyInputNotificationConfigTypeAuthHeadersType AuthHeaders { get; set; }
    }

    public class BodyInputNotificationConfigTypeAuthHeadersType
    {
        public string Authorization { get; set; }
    }

    public class BodyInputSegmentsToTranscribeTypeItem
    {
        [JsonProperty("start")]
        public int? Start { get; set; }

        [JsonProperty("end")]
        public int? End { get; set; }
    }

    public class BodyInputSpeakersNamesTypeItem
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }

    public class BodyInputCustomVocabulariesTypeItem
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
    public enum AcceptInput
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

    public class VocabularyResponse
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

    public class VocabularyBodyInput
    {
        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("notification_config")]
        public AnalysisBodyInputNotificationConfigType NotificationConfig { get; set; }

        [JsonProperty("custom_vocabularies")]
        public BodyInputCustomVocabulariesTypeItem[] CustomVocabularies { get; set; }
    }

    public class AnalysisBodyInputNotificationConfigType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("auth_headers")]
        public BodyInputNotificationConfigTypeAuthHeadersType AuthHeaders { get; set; }
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

    public class ExtractionResponse
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

    public class AnalysisBodyInput
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("notification_config")]
        public AnalysisBodyInputNotificationConfigType NotificationConfig { get; set; }

        [JsonProperty("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        [JsonProperty("json")]
        public BodyInputJsonType Json { get; set; }
    }

    public class BodyInputJsonType
    {
        [JsonProperty("monologues")]
        public BodyInputJsonTypeMonologuesTypeItem[] Monologues { get; set; }
    }

    public class BodyInputJsonTypeMonologuesTypeItem
    {
        [JsonProperty("speaker")]
        public int? Speaker { get; set; }

        [JsonProperty("elements")]
        public BodyInputJsonTypeMonologuesTypeItemElementsTypeItem[] Elements { get; set; }
    }

    public class BodyInputJsonTypeMonologuesTypeItemElementsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("ts")]
        public double? Ts { get; set; }

        [JsonProperty("end_ts")]
        public double? EndTs { get; set; }

        [JsonProperty("confidence")]
        public double? Confidence { get; set; }
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

    public class AnalysisResponse
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
    public enum FilterForInput
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

    public class IdentificationResponse
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

    public class IdentificationBodyInput
    {
        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("notification_config")]
        public AlignmentBodyInputNotificationConfigType NotificationConfig { get; set; }

        [JsonProperty("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        [JsonProperty("source_config")]
        public AlignmentBodyInputSourceConfigType SourceConfig { get; set; }
    }

    public class AlignmentBodyInputNotificationConfigType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AlignmentBodyInputSourceConfigType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
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

    public class AlignmentResponse
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

    public class AlignmentBodyInput
    {
        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("notification_config")]
        public AlignmentBodyInputNotificationConfigType NotificationConfig { get; set; }

        [JsonProperty("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        [JsonProperty("source_config")]
        public AlignmentBodyInputSourceConfigType SourceConfig { get; set; }

        [JsonProperty("transcript_text")]
        public string TranscriptText { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLanguageType? Language { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Revai.BodyInputLanguageType.En;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLanguageType
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