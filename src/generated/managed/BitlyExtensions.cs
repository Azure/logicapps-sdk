//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bitly
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BitlyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitly")]
        [WorkflowExpressionFactory(nameof(__BuildCreateBitlink))]
        public IBodyWorkflowAction<BitlinkV2> CreateBitlink([WorkflowExpression] Func<string> bodyuRL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BitlinkV2> __BuildCreateBitlink(WorkflowValue<string> bodyuRL)
        {
            WorkflowValue.Validate(bodyuRL, nameof(bodyuRL), required: true);
            return new DeferredBodyAction<BitlinkV2>(() =>
            {
                var apiCallPath = "/shorten";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["long_url"] = ExpressionConverter.ConvertO(bodyuRL);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BitlinkV2>(callPayload);
            });
        }
    }

    public class BitlyTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnBitlinkCreated))]
        public IBodyWorkflowTrigger<OnBitlinkCreatedResponse> OnBitlinkCreated([WorkflowExpression] Func<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnBitlinkCreatedResponse> __BuildOnBitlinkCreated(WorkflowValue<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyTrigger<OnBitlinkCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/bitlinks", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OnBitlinkCreatedResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class BitlinkV2
    {
        [JsonProperty("link")]
        public string URL { get; set; }

        [JsonProperty("long_url")]
        public string LongURL { get; set; }
    }

    public class OnBitlinkCreatedResponse
    {
        [JsonProperty("links")]
        public BitlinkV2[] Links { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bitly;

    public partial class WorkflowManagedActions
    {
        public BitlyActions Bitly(string connectionId) => new BitlyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BitlyTriggers Bitly(string connectionId) => new BitlyTriggers(connectionId);
    }
}
