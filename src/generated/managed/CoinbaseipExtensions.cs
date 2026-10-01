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
        public IBodyWorkflowAction<GetSpotPriceResponse> GetSpotPrice([WorkflowExpression] Func<string> currencyPair)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/prices/{0}/spot", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(currencyPair, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSpotPriceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coinbaseip")]
        public IBodyWorkflowAction<GetCurrenciesResponse> GetCurrencies()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/currencies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCurrenciesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coinbaseip")]
        public IBodyWorkflowAction<GetExchangeRateResponse> GetExchangeRate([WorkflowExpression] Func<string> currency)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/exchange-rates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["currency"] = SourceExpressionConverter.ConvertO(currency);
                return callPayload;
            }

            return new ApiConnectionAction<GetExchangeRateResponse>(BuildSourceInput);
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