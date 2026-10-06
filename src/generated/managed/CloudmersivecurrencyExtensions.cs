//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivecurrency
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivecurrencyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivecurrency")]
        public IBodyWorkflowAction<AvailableCurrencyResponse> CurrencyExchangeGetAvailableCurrencies()
        {
            var apiCallPath = "/currency/exchange-rates/list-available";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AvailableCurrencyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivecurrency")]
        [WorkflowExpressionFactory(nameof(__BuildCurrencyExchangeConvertCurrency))]
        public IBodyWorkflowAction<ConvertedCurrencyResult> CurrencyExchangeConvertCurrency([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<double> sourcePrice = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivecurrency")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConvertedCurrencyResult> __BuildCurrencyExchangeConvertCurrency(WorkflowExpression<string> source, WorkflowExpression<string> destination, WorkflowExpression<double> sourcePrice = null)
        {
            WorkflowExpression.Validate(source, nameof(source), required: true);
            WorkflowExpression.Validate(destination, nameof(destination), required: true);
            WorkflowExpression.Validate(sourcePrice, nameof(sourcePrice), required: false);
            return new DeferredBodyAction<ConvertedCurrencyResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/currency/exchange-rates/convert/{0}/to/{1}", ExpressionConverter.ConvertWithUrlEncoding(source, 1), ExpressionConverter.ConvertWithUrlEncoding(destination, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(sourcePrice);
                return new ApiConnectionAction<ConvertedCurrencyResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivecurrency")]
        [WorkflowExpressionFactory(nameof(__BuildCurrencyExchangeGetExchangeRate))]
        public IBodyWorkflowAction<ExchangeRateResult> CurrencyExchangeGetExchangeRate([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivecurrency")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeRateResult> __BuildCurrencyExchangeGetExchangeRate(WorkflowExpression<string> source, WorkflowExpression<string> destination)
        {
            WorkflowExpression.Validate(source, nameof(source), required: true);
            WorkflowExpression.Validate(destination, nameof(destination), required: true);
            return new DeferredBodyAction<ExchangeRateResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/currency/exchange-rates/get/{0}/to/{1}", ExpressionConverter.ConvertWithUrlEncoding(source, 1), ExpressionConverter.ConvertWithUrlEncoding(destination, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExchangeRateResult>(callPayload);
            });
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