//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivecurrency
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivecurrencyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivecurrency")]
        public IBodyWorkflowAction<AvailableCurrencyResponse> CurrencyExchangeGetAvailableCurrencies()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/currency/exchange-rates/list-available";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AvailableCurrencyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivecurrency")]
        public IBodyWorkflowAction<ConvertedCurrencyResult> CurrencyExchangeConvertCurrency([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<double> sourcePrice = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/currency/exchange-rates/convert/{0}/to/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(source, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(destination, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(sourcePrice);
                return callPayload;
            }

            return new ApiConnectionAction<ConvertedCurrencyResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivecurrency")]
        public IBodyWorkflowAction<ExchangeRateResult> CurrencyExchangeGetExchangeRate([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/currency/exchange-rates/get/{0}/to/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(source, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(destination, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeRateResult>(BuildSourceInput);
        }
    }

    public class CloudmersivecurrencyTriggers([ConnectionName] string connectionId)
    {
    }

    public class AvailableCurrencyResponse
    {
        public AvailableCurrency[] Currencies { get; set; }
    }

    public class AvailableCurrency
    {
        public string ISOCurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyEnglishName { get; set; }
        public string CountryName { get; set; }
        public string CountryThreeLetterCode { get; set; }
        public string CountryISOTwoLetterCode { get; set; }
        public bool IsEuropeanUnionMember { get; set; }
    }

    public class ConvertedCurrencyResult
    {
        public double ConvertedPrice { get; set; }
        public string ISOCurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
        public string FormattedPriceAsString { get; set; }
    }

    public class ExchangeRateResult
    {
        public double ExchangeRate { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivecurrency;

    public partial class WorkflowManagedActions
    {
        public CloudmersivecurrencyActions Cloudmersivecurrency(string connectionId) => new CloudmersivecurrencyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersivecurrencyTriggers Cloudmersivecurrency(string connectionId) => new CloudmersivecurrencyTriggers(connectionId);
    }
}