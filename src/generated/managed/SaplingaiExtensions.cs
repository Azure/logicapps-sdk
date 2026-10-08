//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Saplingai
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SaplingaiActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        [WorkflowExpressionFactory(nameof(__BuildSpellcheck))]
        public IBodyWorkflowAction<SpellcheckResponse> Spellcheck([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodyminLength, [WorkflowExpression] Func<string> bodysessionId, [WorkflowExpression] Func<bool> bodymultipleEdits = null, [WorkflowExpression] Func<bool> bodyneuralSpellcheck = null, [WorkflowExpression] Func<string> bodylang = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SpellcheckResponse> __BuildSpellcheck(WorkflowExpression<string> bodytext, WorkflowExpression<int> bodyminLength, WorkflowExpression<string> bodysessionId, WorkflowExpression<bool> bodymultipleEdits = null, WorkflowExpression<bool> bodyneuralSpellcheck = null, WorkflowExpression<string> bodylang = null)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodyminLength, nameof(bodyminLength), required: true);
            WorkflowExpression.Validate(bodysessionId, nameof(bodysessionId), required: true);
            WorkflowExpression.Validate(bodymultipleEdits, nameof(bodymultipleEdits), required: false);
            WorkflowExpression.Validate(bodyneuralSpellcheck, nameof(bodyneuralSpellcheck), required: false);
            WorkflowExpression.Validate(bodylang, nameof(bodylang), required: false);
            return new DeferredBodyAction<SpellcheckResponse>(() =>
            {
                var apiCallPath = "/v1/spellcheck";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
                body["min_length"] = ExpressionConverter.ConvertO(bodyminLength);
                bodypropCount++;
                body["session_id"] = ExpressionConverter.ConvertO(bodysessionId);
                if (bodymultipleEdits != null)
                {
                    body["multiple_edits"] = ExpressionConverter.ConvertO(bodymultipleEdits);
                    bodypropCount++;
                }

                if (bodyneuralSpellcheck != null)
                {
                    body["neural_spellcheck"] = ExpressionConverter.ConvertO(bodyneuralSpellcheck);
                    bodypropCount++;
                }

                if (bodylang != null)
                {
                    body["lang"] = ExpressionConverter.ConvertO(bodylang);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SpellcheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        [WorkflowExpressionFactory(nameof(__BuildMedicalSpellcheck))]
        public IBodyWorkflowAction<MedicalSpellcheckResponse> MedicalSpellcheck([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodyminLength, [WorkflowExpression] Func<string> bodysessionId, [WorkflowExpression] Func<bool> bodymultipleEdits = null, [WorkflowExpression] Func<bool> bodyneuralSpellcheck = null, [WorkflowExpression] Func<string> bodylang = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MedicalSpellcheckResponse> __BuildMedicalSpellcheck(WorkflowExpression<string> bodytext, WorkflowExpression<int> bodyminLength, WorkflowExpression<string> bodysessionId, WorkflowExpression<bool> bodymultipleEdits = null, WorkflowExpression<bool> bodyneuralSpellcheck = null, WorkflowExpression<string> bodylang = null)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodyminLength, nameof(bodyminLength), required: true);
            WorkflowExpression.Validate(bodysessionId, nameof(bodysessionId), required: true);
            WorkflowExpression.Validate(bodymultipleEdits, nameof(bodymultipleEdits), required: false);
            WorkflowExpression.Validate(bodyneuralSpellcheck, nameof(bodyneuralSpellcheck), required: false);
            WorkflowExpression.Validate(bodylang, nameof(bodylang), required: false);
            return new DeferredBodyAction<MedicalSpellcheckResponse>(() =>
            {
                var apiCallPath = "/v1/medical-spellcheck";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
                body["min_length"] = ExpressionConverter.ConvertO(bodyminLength);
                bodypropCount++;
                body["session_id"] = ExpressionConverter.ConvertO(bodysessionId);
                if (bodymultipleEdits != null)
                {
                    body["multiple_edits"] = ExpressionConverter.ConvertO(bodymultipleEdits);
                    bodypropCount++;
                }

                if (bodyneuralSpellcheck != null)
                {
                    body["neural_spellcheck"] = ExpressionConverter.ConvertO(bodyneuralSpellcheck);
                    bodypropCount++;
                }

                if (bodylang != null)
                {
                    body["lang"] = ExpressionConverter.ConvertO(bodylang);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MedicalSpellcheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        [WorkflowExpressionFactory(nameof(__BuildAutocomplete))]
        public IBodyWorkflowAction<AutocompleteResponse> Autocomplete([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodysessionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AutocompleteResponse> __BuildAutocomplete(WorkflowExpression<string> bodyquery, WorkflowExpression<string> bodysessionId)
        {
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            WorkflowExpression.Validate(bodysessionId, nameof(bodysessionId), required: true);
            return new DeferredBodyAction<AutocompleteResponse>(() =>
            {
                var apiCallPath = "/v1/complete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(bodyquery);
                bodypropCount++;
                body["session_id"] = ExpressionConverter.ConvertO(bodysessionId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AutocompleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        [WorkflowExpressionFactory(nameof(__BuildStatistics))]
        public IBodyWorkflowAction<StatisticsResponse> Statistics([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodysessionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StatisticsResponse> __BuildStatistics(WorkflowExpression<string> bodytext, WorkflowExpression<string> bodysessionId)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodysessionId, nameof(bodysessionId), required: true);
            return new DeferredBodyAction<StatisticsResponse>(() =>
            {
                var apiCallPath = "/v1/statistics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
                body["session_id"] = ExpressionConverter.ConvertO(bodysessionId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StatisticsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        [WorkflowExpressionFactory(nameof(__BuildDetectAi))]
        public IBodyWorkflowAction<DetectAiResponse> DetectAi([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<bool> bodysentScores = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetectAiResponse> __BuildDetectAi(WorkflowExpression<string> bodytext, WorkflowExpression<bool> bodysentScores = null)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodysentScores, nameof(bodysentScores), required: false);
            return new DeferredBodyAction<DetectAiResponse>(() =>
            {
                var apiCallPath = "/v1/aidetect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodysentScores != null)
                {
                    body["sent_scores"] = ExpressionConverter.ConvertO(bodysentScores);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DetectAiResponse>(callPayload);
            });
        }
    }

    public class SaplingaiTriggers([ConnectionName] string connectionId)
    {
    }

    public class SpellcheckResponse
    {
        [JsonProperty("edits")]
        public EditDef[] Edits { get; set; }
    }

    public class EditDef
    {
        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("replacement")]
        public string Replacement { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }

        [JsonProperty("sentence_start")]
        public int SentenceStart { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("error_type")]
        public string ErrorType { get; set; }

        [JsonProperty("general_error_type")]
        public string GeneralErrorType { get; set; }
    }

    public class MedicalSpellcheckResponse
    {
        [JsonProperty("edits")]
        public EditDef[] Edits { get; set; }
    }

    public class AutocompleteResponse
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class StatisticsResponse
    {
        [JsonProperty("chars")]
        public int Chars { get; set; }

        [JsonProperty("readability")]
        public double Readability { get; set; }

        [JsonProperty("reading_time_min")]
        public int ReadingTimeMin { get; set; }

        [JsonProperty("reading_time_sec")]
        public double ReadingTimeSec { get; set; }

        [JsonProperty("sentences")]
        public int Sentences { get; set; }

        [JsonProperty("words")]
        public int Words { get; set; }
    }

    public class DetectAiResponse
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("sentence_scores")]
        public DetectAiResponseSentenceScoresTypeItem[] SentenceScores { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }
    }

    public class DetectAiResponseSentenceScoresTypeItem
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Saplingai;

    public partial class WorkflowManagedActions
    {
        public SaplingaiActions Saplingai(string connectionId) => new SaplingaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SaplingaiTriggers Saplingai(string connectionId) => new SaplingaiTriggers(connectionId);
    }
}