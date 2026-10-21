//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivecurrency
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
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
        public IBodyWorkflowAction<ConvertedCurrencyResult> CurrencyExchangeConvertCurrency(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<double>> sourcePrice = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_sourcePrice = WorkflowExpression.Compile(sourcePrice, nameof(sourcePrice), required: false);
            return new DeferredBodyAction<ConvertedCurrencyResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/currency/exchange-rates/convert/{0}/to/{1}", __workflow_source.WithUrlEncoding(1), __workflow_destination.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sourcePrice);
                return new ApiConnectionAction<ConvertedCurrencyResult>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivecurrency")]
        public IBodyWorkflowAction<ExchangeRateResult> CurrencyExchangeGetExchangeRate(Expression<Func<string>> source, Expression<Func<string>> destination)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            return new DeferredBodyAction<ExchangeRateResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/currency/exchange-rates/get/{0}/to/{1}", __workflow_source.WithUrlEncoding(1), __workflow_destination.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExchangeRateResult>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
