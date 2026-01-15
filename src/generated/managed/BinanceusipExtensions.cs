//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Binanceusip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BinanceusipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "binanceusip")]
        public IBodyWorkflowAction<GetLiveTickerPriceResponse> GetLiveTickerPrice(Expression<Func<string>> symbol = null)
        {
            var apiCallPath = "/ticker/price";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (symbol != null)
                callPayload.Queries["symbol"] = ExpressionConverter.Convert(symbol);
            return new ApiConnectionAction<GetLiveTickerPriceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "binanceusip")]
        public IBodyWorkflowAction<GetExchangeInfoResponse> GetExchangeInformation(Expression<Func<string>> symbol = null)
        {
            var apiCallPath = "/exchangeInfo";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (symbol != null)
                callPayload.Queries["symbol"] = ExpressionConverter.Convert(symbol);
            return new ApiConnectionAction<GetExchangeInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "binanceusip")]
        public IBodyWorkflowAction<GetRecentTradesResponse> GetRecentTrades(Expression<Func<string>> symbol, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/trades";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["symbol"] = ExpressionConverter.Convert(symbol);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<GetRecentTradesResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Binanceusip;

    public partial class WorkflowManagedActions
    {
        public BinanceusipActions Binanceusip(string connectionId) => new BinanceusipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BinanceusipTriggers Binanceusip(string connectionId) => new BinanceusipTriggers(connectionId);
    }
}