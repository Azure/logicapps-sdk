//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Binanceusip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BinanceusipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "binanceusip")]
        [WorkflowExpressionFactory(nameof(__BuildGetLiveTickerPrice))]
        public IBodyWorkflowAction<GetLiveTickerPriceResponse> GetLiveTickerPrice([WorkflowExpression] Func<string> symbol = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLiveTickerPriceResponse> __BuildGetLiveTickerPrice(WorkflowValue<string> symbol = null)
        {
            WorkflowValue.Validate(symbol, nameof(symbol), required: false);
            return new DeferredBodyAction<GetLiveTickerPriceResponse>(() =>
            {
                var apiCallPath = "/ticker/price";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (symbol != null)
                    callPayload.Queries["symbol"] = ExpressionConverter.Convert(symbol);
                return new ApiConnectionAction<GetLiveTickerPriceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "binanceusip")]
        [WorkflowExpressionFactory(nameof(__BuildGetExchangeInformation))]
        public IBodyWorkflowAction<GetExchangeInfoResponse> GetExchangeInformation([WorkflowExpression] Func<string> symbol = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetExchangeInfoResponse> __BuildGetExchangeInformation(WorkflowValue<string> symbol = null)
        {
            WorkflowValue.Validate(symbol, nameof(symbol), required: false);
            return new DeferredBodyAction<GetExchangeInfoResponse>(() =>
            {
                var apiCallPath = "/exchangeInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (symbol != null)
                    callPayload.Queries["symbol"] = ExpressionConverter.Convert(symbol);
                return new ApiConnectionAction<GetExchangeInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "binanceusip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecentTrades))]
        public IBodyWorkflowAction<GetRecentTradesResponse> GetRecentTrades([WorkflowExpression] Func<string> symbol, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRecentTradesResponse> __BuildGetRecentTrades(WorkflowValue<string> symbol, WorkflowValue<int> limit = null)
        {
            WorkflowValue.Validate(symbol, nameof(symbol), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<GetRecentTradesResponse>(() =>
            {
                var apiCallPath = "/trades";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["symbol"] = ExpressionConverter.Convert(symbol);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<GetRecentTradesResponse>(callPayload);
            });
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
