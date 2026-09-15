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
        public IBodyWorkflowAction<SentimentClassifierResponseItem[]> SentimentClassifier(Expression<Func<bodydataInputItem[]>> bodydata = null)
        {
            var apiCallPath = "/text/SentimentClassifier";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SentimentClassifierResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        public IBodyWorkflowAction<PIIScrubberResponse> PIIScrubber(Expression<Func<string>> bodydata = null, Expression<Func<string>> bodyentityList = null)
        {
            var apiCallPath = "/text/PIIScrubber";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodyentityList != null)
            {
                body["entity_list"] = CSharpExpressionConverter.ConvertToken(bodyentityList);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PIIScrubberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        public IBodyWorkflowAction<KeyPhraseExtractorResponseItem[]> KeyPhraseExtractor(Expression<Func<string>> bodytext = null, Expression<Func<int>> bodykeyphrasesCount = null, Expression<Func<double>> bodydiversityThreshold = null, Expression<Func<double>> bodyaliasThreshold = null)
        {
            var apiCallPath = "/text/KeyPhrase";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytext != null)
            {
                body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
            }

            if (bodykeyphrasesCount != null)
            {
                body["keyphrases_count"] = CSharpExpressionConverter.ConvertToken(bodykeyphrasesCount);
                bodypropCount++;
            }

            if (bodydiversityThreshold != null)
            {
                body["diversity_threshold"] = CSharpExpressionConverter.ConvertToken(bodydiversityThreshold);
                bodypropCount++;
            }

            if (bodyaliasThreshold != null)
            {
                body["alias_threshold"] = CSharpExpressionConverter.ConvertToken(bodyaliasThreshold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<KeyPhraseExtractorResponseItem[]>(callPayload);
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