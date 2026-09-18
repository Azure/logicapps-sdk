//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Databoxip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DataboxipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "databoxip")]
        public IBodyWorkflowAction<DataPostResponse> Data([WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.databox.v2+json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<DataPostResponse>(BuildSourceInput);
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