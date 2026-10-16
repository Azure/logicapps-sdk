//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Exchangerateip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExchangerateipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        public IBodyWorkflowAction<GetExchangeRatesResponse> GetExchangeRates(Expression<Func<string>> basecurrency)
        {
            var __workflow_basecurrency = WorkflowExpression.Compile(basecurrency, nameof(basecurrency), required: true);
            return new DeferredBodyAction<GetExchangeRatesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/latest/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_basecurrency, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetExchangeRatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        public IBodyWorkflowAction<GetExchangeRateResponse> GetExchangeRate(Expression<Func<string>> baseCurrency, Expression<Func<string>> targetCurrency)
        {
            var __workflow_baseCurrency = WorkflowExpression.Compile(baseCurrency, nameof(baseCurrency), required: true);
            var __workflow_targetCurrency = WorkflowExpression.Compile(targetCurrency, nameof(targetCurrency), required: true);
            return new DeferredBodyAction<GetExchangeRateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pair/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_baseCurrency, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_targetCurrency, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetExchangeRateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        public IBodyWorkflowAction<ListCurrenciesResponse> ListCurrencies()
        {
            var apiCallPath = "/codes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListCurrenciesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        public IBodyWorkflowAction<GetHistoricalRatesResponse> GetHistoricalRates(Expression<Func<string>> baseCurrency, Expression<Func<string>> year, Expression<Func<string>> month, Expression<Func<string>> day)
        {
            var __workflow_baseCurrency = WorkflowExpression.Compile(baseCurrency, nameof(baseCurrency), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            var __workflow_month = WorkflowExpression.Compile(month, nameof(month), required: true);
            var __workflow_day = WorkflowExpression.Compile(day, nameof(day), required: true);
            return new DeferredBodyAction<GetHistoricalRatesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/history/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_baseCurrency, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_year, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_month, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_day, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetHistoricalRatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        public IBodyWorkflowAction<GetHistoricalConversionsResponse> GetHistoricalConversions(Expression<Func<string>> baseCurrency, Expression<Func<string>> year, Expression<Func<string>> month, Expression<Func<string>> day, Expression<Func<string>> amount)
        {
            var __workflow_baseCurrency = WorkflowExpression.Compile(baseCurrency, nameof(baseCurrency), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            var __workflow_month = WorkflowExpression.Compile(month, nameof(month), required: true);
            var __workflow_day = WorkflowExpression.Compile(day, nameof(day), required: true);
            var __workflow_amount = WorkflowExpression.Compile(amount, nameof(amount), required: true);
            return new DeferredBodyAction<GetHistoricalConversionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/history/{0}/{1}/{2}/{3}/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_baseCurrency, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_year, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_month, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_day, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_amount, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetHistoricalConversionsResponse>(callPayload);
            });
        }
    }

    public class ExchangerateipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetExchangeRatesResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("documentation")]
        public string Documentation { get; set; }

        [JsonProperty("terms_of_use")]
        public string TermsOfUse { get; set; }

        [JsonProperty("time_last_update_unix")]
        public int TimeLastUpdateUnix { get; set; }

        [JsonProperty("time_last_update_utc")]
        public string TimeLastUpdateUtc { get; set; }

        [JsonProperty("time_next_update_unix")]
        public int TimeNextUpdateUnix { get; set; }

        [JsonProperty("time_next_update_utc")]
        public string TimeNextUpdateUtc { get; set; }

        [JsonProperty("base_code")]
        public string BaseCode { get; set; }

        [JsonProperty("conversion_rates")]
        public JToken ConversionRates { get; set; }
    }

    public class GetExchangeRateResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("documentation")]
        public string Documentation { get; set; }

        [JsonProperty("terms_of_use")]
        public string TermsOfUse { get; set; }

        [JsonProperty("time_last_update_unix")]
        public int TimeLastUpdateUnix { get; set; }

        [JsonProperty("time_last_update_utc")]
        public string TimeLastUpdateUtc { get; set; }

        [JsonProperty("time_next_update_unix")]
        public int TimeNextUpdateUnix { get; set; }

        [JsonProperty("time_next_update_utc")]
        public string TimeNextUpdateUtc { get; set; }

        [JsonProperty("base_code")]
        public string BaseCode { get; set; }

        [JsonProperty("target_code")]
        public string TargetCode { get; set; }

        [JsonProperty("conversion_rate")]
        public double ConversionRate { get; set; }
    }

    public class ListCurrenciesResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("documentation")]
        public string Documentation { get; set; }

        [JsonProperty("terms_of_use")]
        public string TermsOfUse { get; set; }

        [JsonProperty("supported_codes")]
        public string[][] SupportedCodes { get; set; }
    }

    public class GetHistoricalRatesResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("documentation")]
        public string Documentation { get; set; }

        [JsonProperty("terms_of_use")]
        public string TermsOfUse { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("base_code")]
        public string BaseCode { get; set; }

        [JsonProperty("conversion_rates")]
        public JToken ConversionRates { get; set; }
    }

    public class GetHistoricalConversionsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("documentation")]
        public string Documentation { get; set; }

        [JsonProperty("terms_of_use")]
        public string TermsOfUse { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("base_code")]
        public string BaseCode { get; set; }

        [JsonProperty("requested_amount")]
        public int RequestedAmount { get; set; }

        [JsonProperty("conversion_rates")]
        public JToken ConversionRates { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Exchangerateip;

    public partial class WorkflowManagedActions
    {
        public ExchangerateipActions Exchangerateip(string connectionId) => new ExchangerateipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExchangerateipTriggers Exchangerateip(string connectionId) => new ExchangerateipTriggers(connectionId);
    }
}
