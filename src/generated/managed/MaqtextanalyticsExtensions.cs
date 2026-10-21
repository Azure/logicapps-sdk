//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Maqtextanalytics
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MaqtextanalyticsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        public IBodyWorkflowAction<SentimentClassifierResponseItem[]> SentimentClassifier(Expression<Func<bodydataInputItem[]>> bodydata = null)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<SentimentClassifierResponseItem[]>(() =>
            {
                var apiCallPath = "/text/SentimentClassifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SentimentClassifierResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        public IBodyWorkflowAction<PIIScrubberResponse> PIIScrubber(Expression<Func<string>> bodydata = null, Expression<Func<string>> bodyentityList = null)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            var __workflow_bodyentityList = WorkflowExpression.Compile(bodyentityList, nameof(bodyentityList), required: false);
            return new DeferredBodyAction<PIIScrubberResponse>(() =>
            {
                var apiCallPath = "/text/PIIScrubber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (__workflow_bodyentityList != null)
                {
                    body["entity_list"] = ExpressionConverter.ConvertO(__workflow_bodyentityList);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PIIScrubberResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        public IBodyWorkflowAction<KeyPhraseExtractorResponseItem[]> KeyPhraseExtractor(Expression<Func<string>> bodytext = null, Expression<Func<int>> bodykeyphrasesCount = null, Expression<Func<double>> bodydiversityThreshold = null, Expression<Func<double>> bodyaliasThreshold = null)
        {
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodykeyphrasesCount = WorkflowExpression.Compile(bodykeyphrasesCount, nameof(bodykeyphrasesCount), required: false);
            var __workflow_bodydiversityThreshold = WorkflowExpression.Compile(bodydiversityThreshold, nameof(bodydiversityThreshold), required: false);
            var __workflow_bodyaliasThreshold = WorkflowExpression.Compile(bodyaliasThreshold, nameof(bodyaliasThreshold), required: false);
            return new DeferredBodyAction<KeyPhraseExtractorResponseItem[]>(() =>
            {
                var apiCallPath = "/text/KeyPhrase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (__workflow_bodykeyphrasesCount != null)
                {
                    body["keyphrases_count"] = ExpressionConverter.ConvertO(__workflow_bodykeyphrasesCount);
                    bodypropCount++;
                }

                if (__workflow_bodydiversityThreshold != null)
                {
                    body["diversity_threshold"] = ExpressionConverter.ConvertO(__workflow_bodydiversityThreshold);
                    bodypropCount++;
                }

                if (__workflow_bodyaliasThreshold != null)
                {
                    body["alias_threshold"] = ExpressionConverter.ConvertO(__workflow_bodyaliasThreshold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<KeyPhraseExtractorResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
