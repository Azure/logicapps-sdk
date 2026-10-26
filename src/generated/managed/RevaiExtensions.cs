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
        public IBodyWorkflowAction<TranscriptionPostResponse, ApiConnectionActionConfiguration> Transcription(Expression<Func<TranscriptionPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TranscriptionPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/speechtotext/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<VocabularyPostResponse, ApiConnectionActionConfiguration> Vocabulary(Expression<Func<VocabularyPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<VocabularyPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/speechtotext/v1/vocabularies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<ExtractionPostResponse, ApiConnectionActionConfiguration> Extraction(Expression<Func<ExtractionPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractionPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/topic_extraction/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<AnalysisPostResponse, ApiConnectionActionConfiguration> Analysis(Expression<Func<AnalysisPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AnalysisPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sentiment_analysis/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<IdentificationPostResponse, ApiConnectionActionConfiguration> Identification(Expression<Func<IdentificationPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IdentificationPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/languageid/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<AlignmentPostResponse, ApiConnectionActionConfiguration> Alignment(Expression<Func<AlignmentPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AlignmentPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/alignment/v1/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class TranscriptionPostInput
    {
        [JsonProperty("source_config")]
        public TranscriptionPostInputSourceConfigType SourceConfig { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("notification_config", DefaultValueHandling = DefaultValueHandling.Include)]
        public TranscriptionPostInputNotificationConfigType NotificationConfig { get; set; }

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
        public TranscriptionPostInputSegmentsToTranscribeTypeItem[] SegmentsToTranscribe { get; set; }

        [JsonProperty("speakers_names")]
        public TranscriptionPostInputSpeakersNamesTypeItem[] SpeakersNames { get; set; }

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
        public TranscriptionPostInputCustomVocabulariesTypeItem[] CustomVocabularies { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class TranscriptionPostInputSourceConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("auth_headers")]
        public TranscriptionPostInputSourceConfigTypeAuthHeadersType AuthHeaders { get; set; }
    }

    public class TranscriptionPostInputSourceConfigTypeAuthHeadersType
    {
        public string Authorization { get; set; }
    }

    public class TranscriptionPostInputNotificationConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("auth_headers")]
        public TranscriptionPostInputNotificationConfigTypeAuthHeadersType AuthHeaders { get; set; }
    }

    public class TranscriptionPostInputNotificationConfigTypeAuthHeadersType
    {
        public string Authorization { get; set; }
    }

    public class TranscriptionPostInputSegmentsToTranscribeTypeItem
    {
        [JsonProperty("start")]
        public int? Start { get; set; }

        [JsonProperty("end")]
        public int? End { get; set; }
    }

    public class TranscriptionPostInputSpeakersNamesTypeItem
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }

    public class TranscriptionPostInputCustomVocabulariesTypeItem
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

    public class VocabularyPostInput
    {
        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("notification_config")]
        public VocabularyPostInputNotificationConfigType NotificationConfig { get; set; }

        [JsonProperty("custom_vocabularies")]
        public VocabularyPostInputCustomVocabulariesTypeItem[] CustomVocabularies { get; set; }
    }

    public class VocabularyPostInputNotificationConfigType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("auth_headers")]
        public VocabularyPostInputNotificationConfigTypeAuthHeadersType AuthHeaders { get; set; }
    }

    public class VocabularyPostInputNotificationConfigTypeAuthHeadersType
    {
        public string Authorization { get; set; }
    }

    public class VocabularyPostInputCustomVocabulariesTypeItem
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

    public class ExtractionPostInput
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("notification_config")]
        public ExtractionPostInputNotificationConfigType NotificationConfig { get; set; }

        [JsonProperty("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        [JsonProperty("json")]
        public ExtractionPostInputJsonType Json { get; set; }
    }

    public class ExtractionPostInputNotificationConfigType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("auth_headers")]
        public ExtractionPostInputNotificationConfigTypeAuthHeadersType AuthHeaders { get; set; }
    }

    public class ExtractionPostInputNotificationConfigTypeAuthHeadersType
    {
        public string Authorization { get; set; }
    }

    public class ExtractionPostInputJsonType
    {
        [JsonProperty("monologues")]
        public ExtractionPostInputJsonTypeMonologuesTypeItem[] Monologues { get; set; }
    }

    public class ExtractionPostInputJsonTypeMonologuesTypeItem
    {
        [JsonProperty("speaker")]
        public int? Speaker { get; set; }

        [JsonProperty("elements")]
        public ExtractionPostInputJsonTypeMonologuesTypeItemElementsTypeItem[] Elements { get; set; }
    }

    public class ExtractionPostInputJsonTypeMonologuesTypeItemElementsTypeItem
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

    public class AnalysisPostInput
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("notification_config")]
        public AnalysisPostInputNotificationConfigType NotificationConfig { get; set; }

        [JsonProperty("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        [JsonProperty("json")]
        public AnalysisPostInputJsonType Json { get; set; }
    }

    public class AnalysisPostInputNotificationConfigType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("auth_headers")]
        public AnalysisPostInputNotificationConfigTypeAuthHeadersType AuthHeaders { get; set; }
    }

    public class AnalysisPostInputNotificationConfigTypeAuthHeadersType
    {
        public string Authorization { get; set; }
    }

    public class AnalysisPostInputJsonType
    {
        [JsonProperty("monologues")]
        public AnalysisPostInputJsonTypeMonologuesTypeItem[] Monologues { get; set; }
    }

    public class AnalysisPostInputJsonTypeMonologuesTypeItem
    {
        [JsonProperty("speaker")]
        public int? Speaker { get; set; }

        [JsonProperty("elements")]
        public AnalysisPostInputJsonTypeMonologuesTypeItemElementsTypeItem[] Elements { get; set; }
    }

    public class AnalysisPostInputJsonTypeMonologuesTypeItemElementsTypeItem
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

    public class IdentificationPostInput
    {
        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("notification_config")]
        public IdentificationPostInputNotificationConfigType NotificationConfig { get; set; }

        [JsonProperty("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        [JsonProperty("source_config")]
        public IdentificationPostInputSourceConfigType SourceConfig { get; set; }
    }

    public class IdentificationPostInputNotificationConfigType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class IdentificationPostInputSourceConfigType
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

    public class AlignmentPostInput
    {
        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("notification_config")]
        public AlignmentPostInputNotificationConfigType NotificationConfig { get; set; }

        [JsonProperty("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        [JsonProperty("source_config")]
        public AlignmentPostInputSourceConfigType SourceConfig { get; set; }

        [JsonProperty("transcript_text")]
        public string TranscriptText { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public AlignmentPostInputLanguageType? Language { get; set; } = AlignmentPostInputLanguageType.En;
    }

    public class AlignmentPostInputNotificationConfigType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AlignmentPostInputSourceConfigType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AlignmentPostInputLanguageType
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