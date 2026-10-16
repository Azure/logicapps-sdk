//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bitly
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class BitlyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitly")]
        public IBodyWorkflowAction<BitlinkV2> CreateBitlink(Expression<Func<string>> bodyuRL)
        {
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: true);
            return new DeferredBodyAction<BitlinkV2>(() =>
            {
                var apiCallPath = "/shorten";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["long_url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
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
        public IBodyWorkflowTrigger<OnBitlinkCreatedResponse> OnBitlinkCreated(Expression<Func<string>> id, FlowRecurrence recurrence = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyTrigger<OnBitlinkCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/bitlinks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OnBitlinkCreatedResponse>(callPayload, recurrence: recurrence);
            });
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
