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
        public IBodyWorkflowAction<SpellcheckResponse> Spellcheck([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodyminLength, [WorkflowExpression] Func<string> bodysessionId, [WorkflowExpression] Func<bool> bodymultipleEdits = null, [WorkflowExpression] Func<bool> bodyneuralSpellcheck = null, [WorkflowExpression] Func<string> bodylang = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/spellcheck";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
                body["min_length"] = SourceExpressionConverter.ConvertToken(bodyminLength);
                bodypropCount++;
                body["session_id"] = SourceExpressionConverter.ConvertToken(bodysessionId);
                if (bodymultipleEdits != null)
                {
                    body["multiple_edits"] = SourceExpressionConverter.ConvertToken(bodymultipleEdits);
                    bodypropCount++;
                }

                if (bodyneuralSpellcheck != null)
                {
                    body["neural_spellcheck"] = SourceExpressionConverter.ConvertToken(bodyneuralSpellcheck);
                    bodypropCount++;
                }

                if (bodylang != null)
                {
                    body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SpellcheckResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<MedicalSpellcheckResponse> MedicalSpellcheck([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodyminLength, [WorkflowExpression] Func<string> bodysessionId, [WorkflowExpression] Func<bool> bodymultipleEdits = null, [WorkflowExpression] Func<bool> bodyneuralSpellcheck = null, [WorkflowExpression] Func<string> bodylang = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/medical-spellcheck";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
                body["min_length"] = SourceExpressionConverter.ConvertToken(bodyminLength);
                bodypropCount++;
                body["session_id"] = SourceExpressionConverter.ConvertToken(bodysessionId);
                if (bodymultipleEdits != null)
                {
                    body["multiple_edits"] = SourceExpressionConverter.ConvertToken(bodymultipleEdits);
                    bodypropCount++;
                }

                if (bodyneuralSpellcheck != null)
                {
                    body["neural_spellcheck"] = SourceExpressionConverter.ConvertToken(bodyneuralSpellcheck);
                    bodypropCount++;
                }

                if (bodylang != null)
                {
                    body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MedicalSpellcheckResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<AutocompleteResponse> Autocomplete([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodysessionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/complete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
                body["session_id"] = SourceExpressionConverter.ConvertToken(bodysessionId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AutocompleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<StatisticsResponse> Statistics([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodysessionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/statistics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
                body["session_id"] = SourceExpressionConverter.ConvertToken(bodysessionId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StatisticsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "saplingai")]
        public IBodyWorkflowAction<DetectAiResponse> DetectAi([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<bool> bodysentScores = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/aidetect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodysentScores != null)
                {
                    body["sent_scores"] = SourceExpressionConverter.ConvertToken(bodysentScores);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DetectAiResponse>(BuildSourceInput);
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