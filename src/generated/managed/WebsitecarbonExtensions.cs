//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Websitecarbon
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebsitecarbonActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "websitecarbon")]
        public IBodyWorkflowAction<SiteAnalysisResponse> SiteAnalysis(Expression<Func<string>> url)
        {
            var apiCallPath = "/site";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["url"] = CSharpExpressionConverter.ConvertO(url);
            return new ApiConnectionAction<SiteAnalysisResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "websitecarbon")]
        public IBodyWorkflowAction<DataAnalysisResponse> DataAnalysis(Expression<Func<int>> bytes, Expression<Func<greenInput>> green)
        {
            var apiCallPath = "/data";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["bytes"] = CSharpExpressionConverter.ConvertO(bytes);
            callPayload.Queries["green"] = CSharpExpressionConverter.Convert(green);
            return new ApiConnectionAction<DataAnalysisResponse>(callPayload);
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