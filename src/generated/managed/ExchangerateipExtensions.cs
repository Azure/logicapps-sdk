//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Exchangerateip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExchangerateipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        [WorkflowExpressionFactory(nameof(__BuildGetExchangeRates))]
        public IBodyWorkflowAction<GetExchangeRatesResponse> GetExchangeRates([WorkflowExpression] Func<string> basecurrency)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetExchangeRatesResponse> __BuildGetExchangeRates(WorkflowExpression<string> basecurrency)
        {
            WorkflowExpression.Validate(basecurrency, nameof(basecurrency), required: true);
            return new DeferredBodyAction<GetExchangeRatesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/latest/{0}", ExpressionConverter.ConvertWithUrlEncoding(basecurrency, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetExchangeRatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        [WorkflowExpressionFactory(nameof(__BuildGetExchangeRate))]
        public IBodyWorkflowAction<GetExchangeRateResponse> GetExchangeRate([WorkflowExpression] Func<string> baseCurrency, [WorkflowExpression] Func<string> targetCurrency)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetExchangeRateResponse> __BuildGetExchangeRate(WorkflowExpression<string> baseCurrency, WorkflowExpression<string> targetCurrency)
        {
            WorkflowExpression.Validate(baseCurrency, nameof(baseCurrency), required: true);
            WorkflowExpression.Validate(targetCurrency, nameof(targetCurrency), required: true);
            return new DeferredBodyAction<GetExchangeRateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pair/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(baseCurrency, 1), ExpressionConverter.ConvertWithUrlEncoding(targetCurrency, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildGetHistoricalRates))]
        public IBodyWorkflowAction<GetHistoricalRatesResponse> GetHistoricalRates([WorkflowExpression] Func<string> baseCurrency, [WorkflowExpression] Func<string> year, [WorkflowExpression] Func<string> month, [WorkflowExpression] Func<string> day)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetHistoricalRatesResponse> __BuildGetHistoricalRates(WorkflowExpression<string> baseCurrency, WorkflowExpression<string> year, WorkflowExpression<string> month, WorkflowExpression<string> day)
        {
            WorkflowExpression.Validate(baseCurrency, nameof(baseCurrency), required: true);
            WorkflowExpression.Validate(year, nameof(year), required: true);
            WorkflowExpression.Validate(month, nameof(month), required: true);
            WorkflowExpression.Validate(day, nameof(day), required: true);
            return new DeferredBodyAction<GetHistoricalRatesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/history/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(baseCurrency, 1), ExpressionConverter.ConvertWithUrlEncoding(year, 1), ExpressionConverter.ConvertWithUrlEncoding(month, 1), ExpressionConverter.ConvertWithUrlEncoding(day, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetHistoricalRatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHistoricalConversions))]
        public IBodyWorkflowAction<GetHistoricalConversionsResponse> GetHistoricalConversions([WorkflowExpression] Func<string> baseCurrency, [WorkflowExpression] Func<string> year, [WorkflowExpression] Func<string> month, [WorkflowExpression] Func<string> day, [WorkflowExpression] Func<string> amount)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetHistoricalConversionsResponse> __BuildGetHistoricalConversions(WorkflowExpression<string> baseCurrency, WorkflowExpression<string> year, WorkflowExpression<string> month, WorkflowExpression<string> day, WorkflowExpression<string> amount)
        {
            WorkflowExpression.Validate(baseCurrency, nameof(baseCurrency), required: true);
            WorkflowExpression.Validate(year, nameof(year), required: true);
            WorkflowExpression.Validate(month, nameof(month), required: true);
            WorkflowExpression.Validate(day, nameof(day), required: true);
            WorkflowExpression.Validate(amount, nameof(amount), required: true);
            return new DeferredBodyAction<GetHistoricalConversionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/history/{0}/{1}/{2}/{3}/{4}", ExpressionConverter.ConvertWithUrlEncoding(baseCurrency, 1), ExpressionConverter.ConvertWithUrlEncoding(year, 1), ExpressionConverter.ConvertWithUrlEncoding(month, 1), ExpressionConverter.ConvertWithUrlEncoding(day, 1), ExpressionConverter.ConvertWithUrlEncoding(amount, 1));
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