//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Binanceusip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BinanceusipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "binanceusip")]
        public IBodyWorkflowAction<GetLiveTickerPriceResponse> GetLiveTickerPrice([WorkflowExpression] Func<string> symbol = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ticker/price";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (symbol != null)
                    callPayload.Queries["symbol"] = SourceExpressionConverter.ConvertO(symbol);
                return callPayload;
            }

            return new ApiConnectionAction<GetLiveTickerPriceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "binanceusip")]
        public IBodyWorkflowAction<GetExchangeInfoResponse> GetExchangeInformation([WorkflowExpression] Func<string> symbol = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/exchangeInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (symbol != null)
                    callPayload.Queries["symbol"] = SourceExpressionConverter.ConvertO(symbol);
                return callPayload;
            }

            return new ApiConnectionAction<GetExchangeInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "binanceusip")]
        public IBodyWorkflowAction<GetRecentTradesResponse> GetRecentTrades([WorkflowExpression] Func<string> symbol, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trades";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["symbol"] = SourceExpressionConverter.ConvertO(symbol);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<GetRecentTradesResponse>(BuildSourceInput);
        }
    }

    public class BinanceusipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetLiveTickerPriceResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class StatusDetails
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("messages")]
        public Messages[] Messages { get; set; }
    }

    public class Messages
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetExchangeInfoResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class GetRecentTradesResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Binanceusip;

    public partial class WorkflowManagedActions
    {
        public BinanceusipActions Binanceusip(string connectionId) => new BinanceusipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BinanceusipTriggers Binanceusip(string connectionId) => new BinanceusipTriggers(connectionId);
    }
}