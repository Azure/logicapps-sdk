//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Websitecarbon
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebsitecarbonActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "websitecarbon")]
        [WorkflowExpressionFactory(nameof(__BuildSiteAnalysis))]
        public IBodyWorkflowAction<SiteAnalysisResponse> SiteAnalysis([WorkflowExpression] Func<string> url)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SiteAnalysisResponse> __BuildSiteAnalysis(WorkflowExpression<string> url)
        {
            WorkflowExpression.Validate(url, nameof(url), required: true);
            return new DeferredBodyAction<SiteAnalysisResponse>(() =>
            {
                var apiCallPath = "/site";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                return new ApiConnectionAction<SiteAnalysisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "websitecarbon")]
        [WorkflowExpressionFactory(nameof(__BuildDataAnalysis))]
        public IBodyWorkflowAction<DataAnalysisResponse> DataAnalysis([WorkflowExpression] Func<int> bytes, [WorkflowExpression] Func<greenInput> green)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataAnalysisResponse> __BuildDataAnalysis(WorkflowExpression<int> bytes, WorkflowExpression<greenInput> green)
        {
            WorkflowExpression.Validate(bytes, nameof(bytes), required: true);
            WorkflowExpression.Validate(green, nameof(green), required: true);
            return new DeferredBodyAction<DataAnalysisResponse>(() =>
            {
                var apiCallPath = "/data";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bytes"] = ExpressionConverter.Convert(bytes);
                callPayload.Queries["green"] = ExpressionConverter.Convert(green);
                return new ApiConnectionAction<DataAnalysisResponse>(callPayload);
            });
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