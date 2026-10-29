//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infuraethereumip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InfuraethereumipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infuraethereumip")]
        public IBodyWorkflowAction<EthGasPriceResponse, ApiConnectionActionConfiguration> EthGasPrice(Expression<Func<EthGasPriceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EthGasPriceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/eth_gasPrice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EthGasPriceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infuraethereumip")]
        public IBodyWorkflowAction<EthBlockNumberResponse, ApiConnectionActionConfiguration> EthBlockNumber(Expression<Func<EthBlockNumberInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EthBlockNumberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/eth_blockNumber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EthBlockNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infuraethereumip")]
        public IBodyWorkflowAction<EthGetBalanceResponse, ApiConnectionActionConfiguration> EthGetBalance(Expression<Func<EthGetBalanceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EthGetBalanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/eth_getBalance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class EthGasPriceInput
    {
        [JsonProperty("jsonrpc", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Jsonrpc { get; set; } = "2.0";

        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Method { get; set; } = "eth_gasPrice";

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Id { get; set; } = 1;
    }

    public class EthBlockNumberResponse
    {
        [JsonProperty("result")]
        public int Result { get; set; }
    }

    public class EthBlockNumberInput
    {
        [JsonProperty("jsonrpc", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Jsonrpc { get; set; } = "2.0";

        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Method { get; set; } = "eth_blockNumber";

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Id { get; set; } = 1;
    }

    public class EthGetBalanceResponse
    {
        [JsonProperty("result")]
        public int Result { get; set; }
    }

    public class EthGetBalanceInput
    {
        [JsonProperty("jsonrpc", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Jsonrpc { get; set; } = "2.0";

        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Method { get; set; } = "eth_getBalance";

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Id { get; set; } = 1;

        [JsonProperty("params", DefaultValueHandling = DefaultValueHandling.Include)]
        public EthGetBalanceInputParamsType Params { get; set; }
    }

    public class EthGetBalanceInputParamsType
    {
        public string Address { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public EthGetBalanceInputParamsTypeBlockType? Block { get; set; } = EthGetBalanceInputParamsTypeBlockType.Latest;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EthGetBalanceInputParamsTypeBlockType
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