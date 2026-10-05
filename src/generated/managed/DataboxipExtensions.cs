//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Databoxip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DataboxipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "databoxip")]
        [WorkflowExpressionFactory(nameof(__BuildData))]
        public IBodyWorkflowAction<DataPostResponse> Data([WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataPostResponse> __BuildData(WorkflowValue<bodyInputItem[]> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<DataPostResponse>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.databox.v2+json");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<DataPostResponse>(callPayload);
            });
        }
    }

    public class DataboxipTriggers([ConnectionName] string connectionId)
    {
    }

    public class DataPostResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("metric_key_id")]
        public string MetricKeyId { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("dimension")]
        public string Dimension { get; set; }

        [JsonProperty("dimension_value")]
        public string DimensionValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Databoxip;

    public partial class WorkflowManagedActions
    {
        public DataboxipActions Databoxip(string connectionId) => new DataboxipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DataboxipTriggers Databoxip(string connectionId) => new DataboxipTriggers(connectionId);
    }
}
