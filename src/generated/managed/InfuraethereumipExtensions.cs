//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infuraethereumip
{
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infuraethereumip")]
        [WorkflowExpressionFactory(nameof(__BuildEthGetBalance))]
        public IBodyWorkflowAction<EthGetBalanceResponse> EthGetBalance([WorkflowExpression] Func<string> bodyParamsaddress = null, [WorkflowExpression] Func<bodyParamsblockInput> bodyParamsblock = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infuraethereumip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EthGetBalanceResponse> __BuildEthGetBalance(WorkflowExpression<string> bodyParamsaddress = null, WorkflowExpression<bodyParamsblockInput> bodyParamsblock = null)
        {
            WorkflowExpression.Validate(bodyParamsaddress, nameof(bodyParamsaddress), required: false);
            WorkflowExpression.Validate(bodyParamsblock, nameof(bodyParamsblock), required: false);
            return new DeferredBodyAction<EthGetBalanceResponse>(() =>
            {
                var apiCallPath = "/eth_getBalance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["jsonrpc"] = "2.0";
                bodypropCount++;
                body["method"] = "eth_getBalance";
                bodypropCount++;
                body["id"] = 1;
                bodypropCount++;
                var @paramsObject = new JObject();
                var @paramsObjectpropCount = 0;
                if (bodyParamsaddress != null)
                {
                    @paramsObject["Address"] = ExpressionConverter.ConvertO(bodyParamsaddress);
                    @paramsObjectpropCount++;
                }

                if (bodyParamsblock != null)
                {
                    if (bodyParamsblock != null)
                    {
                        @paramsObject["Block"] = ExpressionConverter.ConvertO(bodyParamsblock);
                        @paramsObjectpropCount++;
                    }

                    @paramsObjectpropCount++;
                }
                else
                {
                    @paramsObject["Block"] = "latest";
                    @paramsObjectpropCount++;
                }

                if (@paramsObjectpropCount > 0)
                {
                    body["params"] = @paramsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EthGetBalanceResponse>(callPayload);
            });
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

    public class EthGetBalanceResponse
    {
        [JsonProperty("result")]
        public int Result { get; set; }
    }

    public enum bodyParamsblockInput
    {
        [EnumMember(Value = "latest")]
        Latest,
        [EnumMember(Value = "earliest")]
        Earliest,
        [EnumMember(Value = "pending")]
        Pending
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Infuraethereumip;

    public partial class WorkflowManagedActions
    {
        public InfuraethereumipActions Infuraethereumip(string connectionId) => new InfuraethereumipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InfuraethereumipTriggers Infuraethereumip(string connectionId) => new InfuraethereumipTriggers(connectionId);
    }
}