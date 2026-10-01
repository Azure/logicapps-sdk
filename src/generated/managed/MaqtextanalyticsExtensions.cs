//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Maqtextanalytics
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MaqtextanalyticsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        public IBodyWorkflowAction<SentimentClassifierResponseItem[]> SentimentClassifier([WorkflowExpression] Func<bodydataInputItem[]> bodydata = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/text/SentimentClassifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SentimentClassifierResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        public IBodyWorkflowAction<PIIScrubberResponse> PIIScrubber([WorkflowExpression] Func<string> bodydata = null, [WorkflowExpression] Func<string> bodyentityList = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/text/PIIScrubber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodyentityList != null)
                {
                    body["entity_list"] = SourceExpressionConverter.ConvertToken(bodyentityList);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PIIScrubberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        public IBodyWorkflowAction<KeyPhraseExtractorResponseItem[]> KeyPhraseExtractor([WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<int> bodykeyphrasesCount = null, [WorkflowExpression] Func<double> bodydiversityThreshold = null, [WorkflowExpression] Func<double> bodyaliasThreshold = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/text/KeyPhrase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodykeyphrasesCount != null)
                {
                    body["keyphrases_count"] = SourceExpressionConverter.ConvertToken(bodykeyphrasesCount);
                    bodypropCount++;
                }

                if (bodydiversityThreshold != null)
                {
                    body["diversity_threshold"] = SourceExpressionConverter.ConvertToken(bodydiversityThreshold);
                    bodypropCount++;
                }

                if (bodyaliasThreshold != null)
                {
                    body["alias_threshold"] = SourceExpressionConverter.ConvertToken(bodyaliasThreshold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<KeyPhraseExtractorResponseItem[]>(BuildSourceInput);
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