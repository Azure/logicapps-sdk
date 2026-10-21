//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Websitecarbon
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebsitecarbonActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "websitecarbon")]
        public IBodyWorkflowAction<SiteAnalysisResponse> SiteAnalysis(Expression<Func<string>> url)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: true);
            return new DeferredBodyAction<SiteAnalysisResponse>(() =>
            {
                var apiCallPath = "/site";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                return new ApiConnectionAction<SiteAnalysisResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "websitecarbon")]
        public IBodyWorkflowAction<DataAnalysisResponse> DataAnalysis(Expression<Func<int>> bytes, Expression<Func<greenInput>> green)
        {
            var __workflow_bytes = WorkflowExpression.Compile(bytes, nameof(bytes), required: true);
            var __workflow_green = WorkflowExpression.Compile(green, nameof(green), required: true);
            return new DeferredBodyAction<DataAnalysisResponse>(() =>
            {
                var apiCallPath = "/data";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bytes"] = ExpressionConverter.Convert(__workflow_bytes);
                callPayload.Queries["green"] = ExpressionConverter.Convert(__workflow_green);
                return new ApiConnectionAction<DataAnalysisResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class WebsitecarbonTriggers([ConnectionName] string connectionId)
    {
    }

    public class SiteAnalysisResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("green")]
        public bool Green { get; set; }

        [JsonProperty("bytes")]
        public int Bytes { get; set; }

        [JsonProperty("cleanerThan")]
        public double CleanerThan { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("statistics")]
        public StatisticsResponse Statistics { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }
    }

    public class StatisticsResponse
    {
        [JsonProperty("adjustedBytes")]
        public double AdjustedBytes { get; set; }

        [JsonProperty("energy")]
        public double Energy { get; set; }

        [JsonProperty("co2")]
        public StatisticsResponseCo2Type Co2 { get; set; }
    }

    public class StatisticsResponseCo2Type
    {
        [JsonProperty("grid")]
        public StatisticsResponseCo2TypeGridType Grid { get; set; }

        [JsonProperty("renewable")]
        public StatisticsResponseCo2TypeRenewableType Renewable { get; set; }
    }

    public class StatisticsResponseCo2TypeGridType
    {
        [JsonProperty("grams")]
        public double Grams { get; set; }

        [JsonProperty("litres")]
        public double Litres { get; set; }
    }

    public class StatisticsResponseCo2TypeRenewableType
    {
        [JsonProperty("grams")]
        public double Grams { get; set; }

        [JsonProperty("litres")]
        public double Litres { get; set; }
    }

    public class DataAnalysisResponse
    {
        [JsonProperty("statistics")]
        public StatisticsResponse Statistics { get; set; }

        [JsonProperty("cleanerThan")]
        public double CleanerThan { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("green")]
        public bool Green { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum greenInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Websitecarbon;

    public partial class WorkflowManagedActions
    {
        public WebsitecarbonActions Websitecarbon(string connectionId) => new WebsitecarbonActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WebsitecarbonTriggers Websitecarbon(string connectionId) => new WebsitecarbonTriggers(connectionId);
    }
}
