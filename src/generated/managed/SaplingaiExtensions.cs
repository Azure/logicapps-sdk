//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Saplingai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SaplingaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<SpellcheckResponse> Spellcheck(Expression<Func<string>> bodytext, Expression<Func<int>> bodyminLength, Expression<Func<string>> bodysessionId, Expression<Func<bool>> bodymultipleEdits = null, Expression<Func<bool>> bodyneuralSpellcheck = null, Expression<Func<string>> bodylang = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<MedicalSpellcheckResponse> MedicalSpellcheck(Expression<Func<string>> bodytext, Expression<Func<int>> bodyminLength, Expression<Func<string>> bodysessionId, Expression<Func<bool>> bodymultipleEdits = null, Expression<Func<bool>> bodyneuralSpellcheck = null, Expression<Func<string>> bodylang = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<AutocompleteResponse> Autocomplete(Expression<Func<string>> bodyquery, Expression<Func<string>> bodysessionId)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<StatisticsResponse> Statistics(Expression<Func<string>> bodytext, Expression<Func<string>> bodysessionId)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<DetectAiResponse> DetectAi(Expression<Func<string>> bodytext, Expression<Func<bool>> bodysentScores = null)
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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