//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Coinbaseip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CoinbaseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coinbaseip")]
        public IBodyWorkflowAction<GetSpotPriceResponse> GetSpotPrice(Expression<Func<string>> currencyPair)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/prices/{0}/spot", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(currencyPair, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSpotPriceResponse>(callPayload);
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
        public IBodyWorkflowAction<GetExchangeRateResponse> GetExchangeRate(Expression<Func<string>> currency)
        {
            var apiCallPath = "/exchange-rates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["currency"] = CSharpExpressionConverter.ConvertO(currency);
            return new ApiConnectionAction<GetExchangeRateResponse>(callPayload);
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