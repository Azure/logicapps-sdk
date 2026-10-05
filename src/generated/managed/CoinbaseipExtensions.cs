//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Coinbaseip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CoinbaseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coinbaseip")]
        [WorkflowExpressionFactory(nameof(__BuildGetSpotPrice))]
        public IBodyWorkflowAction<GetSpotPriceResponse> GetSpotPrice([WorkflowExpression] Func<string> currencyPair)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSpotPriceResponse> __BuildGetSpotPrice(WorkflowValue<string> currencyPair)
        {
            WorkflowValue.Validate(currencyPair, nameof(currencyPair), required: true);
            return new DeferredBodyAction<GetSpotPriceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/prices/{0}/spot", ExpressionConverter.ConvertWithUrlEncoding(currencyPair, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSpotPriceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coinbaseip")]
        public IBodyWorkflowAction<GetCurrenciesResponse> GetCurrencies()
        {
            var apiCallPath = "/currencies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCurrenciesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coinbaseip")]
        [WorkflowExpressionFactory(nameof(__BuildGetExchangeRate))]
        public IBodyWorkflowAction<GetExchangeRateResponse> GetExchangeRate([WorkflowExpression] Func<string> currency)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetExchangeRateResponse> __BuildGetExchangeRate(WorkflowValue<string> currency)
        {
            WorkflowValue.Validate(currency, nameof(currency), required: true);
            return new DeferredBodyAction<GetExchangeRateResponse>(() =>
            {
                var apiCallPath = "/exchange-rates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["currency"] = ExpressionConverter.Convert(currency);
                return new ApiConnectionAction<GetExchangeRateResponse>(callPayload);
            });
        }
    }

    public class CoinbaseipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSpotPriceResponse
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

    public class GetCurrenciesResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class GetExchangeRateResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Coinbaseip;

    public partial class WorkflowManagedActions
    {
        public CoinbaseipActions Coinbaseip(string connectionId) => new CoinbaseipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CoinbaseipTriggers Coinbaseip(string connectionId) => new CoinbaseipTriggers(connectionId);
    }
}
