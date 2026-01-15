//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Infuraethereumip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InfuraethereumipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infuraethereumip")]
        public IBodyWorkflowAction<EthGasPriceResponse> EthGasPrice()
        {
            var apiCallPath = "/eth_gasPrice";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["jsonrpc"] = "2.0";
            bodypropCount++;
            body["method"] = "eth_gasPrice";
            bodypropCount++;
            body["id"] = 1;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EthGasPriceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infuraethereumip")]
        public IBodyWorkflowAction<EthBlockNumberResponse> EthBlockNumber()
        {
            var apiCallPath = "/eth_blockNumber";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["jsonrpc"] = "2.0";
            bodypropCount++;
            body["method"] = "eth_blockNumber";
            bodypropCount++;
            body["id"] = 1;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EthBlockNumberResponse>(callPayload);
        }
    }

    public class InfuraethereumipTriggers([ConnectionName] string connectionId)
    {
    }

    public class EthGasPriceResponse
    {
        [JsonProperty("result")]
        public int Result { get; set; }
    }

    public class EthBlockNumberResponse
    {
        [JsonProperty("result")]
        public int Result { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Infuraethereumip;

    public partial class WorkflowManagedActions
    {
        public InfuraethereumipActions Infuraethereumip(string connectionId) => new InfuraethereumipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InfuraethereumipTriggers Infuraethereumip(string connectionId) => new InfuraethereumipTriggers(connectionId);
    }
}