//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infuraethereumip
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
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionAction<EthGasPriceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infuraethereumip")]
        public IBodyWorkflowAction<EthBlockNumberResponse> EthBlockNumber()
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionAction<EthBlockNumberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infuraethereumip")]
        public IBodyWorkflowAction<EthGetBalanceResponse> EthGetBalance([WorkflowExpression] Func<string> bodyParamsaddress = null, [WorkflowExpression] Func<bodyParamsblockInput> bodyParamsblock = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    @paramsObject["Address"] = SourceExpressionConverter.ConvertToken(bodyParamsaddress);
                    @paramsObjectpropCount++;
                }

                if (bodyParamsblock != null)
                {
                    if (bodyParamsblock != null)
                    {
                        @paramsObject["Block"] = SourceExpressionConverter.Convert(bodyParamsblock);
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
                return callPayload;
            }

            return new ApiConnectionAction<EthGetBalanceResponse>(BuildSourceInput);
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