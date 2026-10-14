//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivecurrency
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
        public IBodyWorkflowAction<ConvertedCurrencyResult> CurrencyExchangeConvertCurrency(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<double>> sourcePrice = null)
        {
            var __workflow_source = source == null ? null : WorkflowExpression.Compile(source);
            WorkflowExpression.Validate(__workflow_source, nameof(source), required: true);
            var __workflow_destination = destination == null ? null : WorkflowExpression.Compile(destination);
            WorkflowExpression.Validate(__workflow_destination, nameof(destination), required: true);
            var __workflow_sourcePrice = sourcePrice == null ? null : WorkflowExpression.Compile(sourcePrice);
            WorkflowExpression.Validate(__workflow_sourcePrice, nameof(sourcePrice), required: false);
            return new DeferredBodyAction<ConvertedCurrencyResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/currency/exchange-rates/convert/{0}/to/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_source, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_destination, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sourcePrice);
                return new ApiConnectionAction<ConvertedCurrencyResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivecurrency")]
        public IBodyWorkflowAction<ExchangeRateResult> CurrencyExchangeGetExchangeRate(Expression<Func<string>> source, Expression<Func<string>> destination)
        {
            var __workflow_source = source == null ? null : WorkflowExpression.Compile(source);
            WorkflowExpression.Validate(__workflow_source, nameof(source), required: true);
            var __workflow_destination = destination == null ? null : WorkflowExpression.Compile(destination);
            WorkflowExpression.Validate(__workflow_destination, nameof(destination), required: true);
            return new DeferredBodyAction<ExchangeRateResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/currency/exchange-rates/get/{0}/to/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_source, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_destination, 1));
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
