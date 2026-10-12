//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dexcomip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DexcomipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dexcomip")]
        [WorkflowExpressionFactory(nameof(__BuildGetEGVs))]
        public IBodyWorkflowAction<GetEGVsResponse> GetEGVs([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEGVsResponse> __BuildGetEGVs(WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<GetEGVsResponse>(() =>
            {
                var apiCallPath = "/v2/users/self/egvs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
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