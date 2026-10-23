//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Saplingai
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SaplingaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<SpellcheckResponse, ApiConnectionActionConfiguration> Spellcheck(Expression<Func<string>> bodytext, Expression<Func<int>> bodyminLength, Expression<Func<string>> bodysessionId, Expression<Func<bool>> bodymultipleEdits = null, Expression<Func<bool>> bodyneuralSpellcheck = null, Expression<Func<string>> bodylang = null)
        {
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyminLength = WorkflowExpression.Compile(bodyminLength, nameof(bodyminLength), required: true);
            var __workflow_bodysessionId = WorkflowExpression.Compile(bodysessionId, nameof(bodysessionId), required: true);
            var __workflow_bodymultipleEdits = WorkflowExpression.Compile(bodymultipleEdits, nameof(bodymultipleEdits), required: false);
            var __workflow_bodyneuralSpellcheck = WorkflowExpression.Compile(bodyneuralSpellcheck, nameof(bodyneuralSpellcheck), required: false);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            return new DeferredBodyAction<SpellcheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/spellcheck";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                bodypropCount++;
                body["min_length"] = ExpressionConverter.ConvertO(__workflow_bodyminLength);
                bodypropCount++;
                body["session_id"] = ExpressionConverter.ConvertO(__workflow_bodysessionId);
                if (__workflow_bodymultipleEdits != null)
                {
                    body["multiple_edits"] = ExpressionConverter.ConvertO(__workflow_bodymultipleEdits);
                    bodypropCount++;
                }

                if (__workflow_bodyneuralSpellcheck != null)
                {
                    body["neural_spellcheck"] = ExpressionConverter.ConvertO(__workflow_bodyneuralSpellcheck);
                    bodypropCount++;
                }

                if (__workflow_bodylang != null)
                {
                    body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
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
        public IBodyWorkflowAction<MedicalSpellcheckResponse, ApiConnectionActionConfiguration> MedicalSpellcheck(Expression<Func<string>> bodytext, Expression<Func<int>> bodyminLength, Expression<Func<string>> bodysessionId, Expression<Func<bool>> bodymultipleEdits = null, Expression<Func<bool>> bodyneuralSpellcheck = null, Expression<Func<string>> bodylang = null)
        {
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyminLength = WorkflowExpression.Compile(bodyminLength, nameof(bodyminLength), required: true);
            var __workflow_bodysessionId = WorkflowExpression.Compile(bodysessionId, nameof(bodysessionId), required: true);
            var __workflow_bodymultipleEdits = WorkflowExpression.Compile(bodymultipleEdits, nameof(bodymultipleEdits), required: false);
            var __workflow_bodyneuralSpellcheck = WorkflowExpression.Compile(bodyneuralSpellcheck, nameof(bodyneuralSpellcheck), required: false);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            return new DeferredBodyAction<MedicalSpellcheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/medical-spellcheck";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                bodypropCount++;
                body["min_length"] = ExpressionConverter.ConvertO(__workflow_bodyminLength);
                bodypropCount++;
                body["session_id"] = ExpressionConverter.ConvertO(__workflow_bodysessionId);
                if (__workflow_bodymultipleEdits != null)
                {
                    body["multiple_edits"] = ExpressionConverter.ConvertO(__workflow_bodymultipleEdits);
                    bodypropCount++;
                }

                if (__workflow_bodyneuralSpellcheck != null)
                {
                    body["neural_spellcheck"] = ExpressionConverter.ConvertO(__workflow_bodyneuralSpellcheck);
                    bodypropCount++;
                }

                if (__workflow_bodylang != null)
                {
                    body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
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
        public IBodyWorkflowAction<AutocompleteResponse, ApiConnectionActionConfiguration> Autocomplete(Expression<Func<string>> bodyquery, Expression<Func<string>> bodysessionId)
        {
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: true);
            var __workflow_bodysessionId = WorkflowExpression.Compile(bodysessionId, nameof(bodysessionId), required: true);
            return new DeferredBodyAction<AutocompleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/complete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                bodypropCount++;
                body["session_id"] = ExpressionConverter.ConvertO(__workflow_bodysessionId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AutocompleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<StatisticsResponse, ApiConnectionActionConfiguration> Statistics(Expression<Func<string>> bodytext, Expression<Func<string>> bodysessionId)
        {
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodysessionId = WorkflowExpression.Compile(bodysessionId, nameof(bodysessionId), required: true);
            return new DeferredBodyAction<StatisticsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/statistics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                bodypropCount++;
                body["session_id"] = ExpressionConverter.ConvertO(__workflow_bodysessionId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StatisticsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<DetectAiResponse, ApiConnectionActionConfiguration> DetectAi(Expression<Func<string>> bodytext, Expression<Func<bool>> bodysentScores = null)
        {
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodysentScores = WorkflowExpression.Compile(bodysentScores, nameof(bodysentScores), required: false);
            return new DeferredBodyAction<DetectAiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/aidetect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (__workflow_bodysentScores != null)
                {
                    body["sent_scores"] = ExpressionConverter.ConvertO(__workflow_bodysentScores);
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
