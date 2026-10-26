//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dexcomip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DexcomipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dexcomip")]
        public IBodyWorkflowAction<GetEGVsResponse, ApiConnectionActionConfiguration> GetEGVs(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<GetEGVsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/users/self/egvs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<GetEGVsResponse>(callPayload);
            });
        }
    }

    public class DexcomipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetEGVsResponse
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("rateUnit")]
        public string RateUnit { get; set; }

        [JsonProperty("egvs")]
        public GetEGVsResponseEgvsTypeItem[] Egvs { get; set; }
    }

    public class GetEGVsResponseEgvsTypeItem
    {
        [JsonProperty("systemTime")]
        public string SystemTime { get; set; }

        [JsonProperty("displayTime")]
        public string DisplayTime { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("realtimeValue")]
        public int RealtimeValue { get; set; }

        [JsonProperty("smoothedValue")]
        public string SmoothedValue { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("trend")]
        public string Trend { get; set; }

        [JsonProperty("trendRate")]
        public double TrendRate { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dexcomip;

    public partial class WorkflowManagedActions
    {
        public DexcomipActions Dexcomip(string connectionId) => new DexcomipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DexcomipTriggers Dexcomip(string connectionId) => new DexcomipTriggers(connectionId);
    }
}