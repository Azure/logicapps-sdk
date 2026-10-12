//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Maqtextanalytics
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MaqtextanalyticsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        [WorkflowExpressionFactory(nameof(__BuildSentimentClassifier))]
        public IBodyWorkflowAction<SentimentClassifierResponseItem[]> SentimentClassifier([WorkflowExpression] Func<bodydataInputItem[]> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SentimentClassifierResponseItem[]> __BuildSentimentClassifier(WorkflowExpression<bodydataInputItem[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<SentimentClassifierResponseItem[]>(() =>
            {
                var apiCallPath = "/text/SentimentClassifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SentimentClassifierResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        [WorkflowExpressionFactory(nameof(__BuildPIIScrubber))]
        public IBodyWorkflowAction<PIIScrubberResponse> PIIScrubber([WorkflowExpression] Func<string> bodydata = null, [WorkflowExpression] Func<string> bodyentityList = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PIIScrubberResponse> __BuildPIIScrubber(WorkflowExpression<string> bodydata = null, WorkflowExpression<string> bodyentityList = null)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            WorkflowExpression.Validate(bodyentityList, nameof(bodyentityList), required: false);
            return new DeferredBodyAction<PIIScrubberResponse>(() =>
            {
                var apiCallPath = "/text/PIIScrubber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodyentityList != null)
                {
                    body["entity_list"] = ExpressionConverter.ConvertO(bodyentityList);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PIIScrubberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        [WorkflowExpressionFactory(nameof(__BuildKeyPhraseExtractor))]
        public IBodyWorkflowAction<KeyPhraseExtractorResponseItem[]> KeyPhraseExtractor([WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<int> bodykeyphrasesCount = null, [WorkflowExpression] Func<double> bodydiversityThreshold = null, [WorkflowExpression] Func<double> bodyaliasThreshold = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KeyPhraseExtractorResponseItem[]> __BuildKeyPhraseExtractor(WorkflowExpression<string> bodytext = null, WorkflowExpression<int> bodykeyphrasesCount = null, WorkflowExpression<double> bodydiversityThreshold = null, WorkflowExpression<double> bodyaliasThreshold = null)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowExpression.Validate(bodykeyphrasesCount, nameof(bodykeyphrasesCount), required: false);
            WorkflowExpression.Validate(bodydiversityThreshold, nameof(bodydiversityThreshold), required: false);
            WorkflowExpression.Validate(bodyaliasThreshold, nameof(bodyaliasThreshold), required: false);
            return new DeferredBodyAction<KeyPhraseExtractorResponseItem[]>(() =>
            {
                var apiCallPath = "/text/KeyPhrase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
                    bodypropCount++;
                }

                if (bodykeyphrasesCount != null)
                {
                    body["keyphrases_count"] = ExpressionConverter.ConvertO(bodykeyphrasesCount);
                    bodypropCount++;
                }

                if (bodydiversityThreshold != null)
                {
                    body["diversity_threshold"] = ExpressionConverter.ConvertO(bodydiversityThreshold);
                    bodypropCount++;
                }

                if (bodyaliasThreshold != null)
                {
                    body["alias_threshold"] = ExpressionConverter.ConvertO(bodyaliasThreshold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<KeyPhraseExtractorResponseItem[]>(callPayload);
            });
        }
    }

    public class MaqtextanalyticsTriggers([ConnectionName] string connectionId)
    {
    }

    public class SentimentClassifierResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sentiment")]
        public double Sentiment { get; set; }
    }

    public class bodydataInputItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PIIScrubberResponse
    {
        [JsonProperty("scrubbed_text")]
        public string ScrubbedText { get; set; }
    }

    public class KeyPhraseExtractorResponseItem
    {
        public string KeyPhrase { get; set; }
        public double Score { get; set; }
        public string[] Similar { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Maqtextanalytics;

    public partial class WorkflowManagedActions
    {
        public MaqtextanalyticsActions Maqtextanalytics(string connectionId) => new MaqtextanalyticsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MaqtextanalyticsTriggers Maqtextanalytics(string connectionId) => new MaqtextanalyticsTriggers(connectionId);
    }
}