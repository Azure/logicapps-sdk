//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Exchangerateip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExchangerateipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        public IBodyWorkflowAction<GetExchangeRatesResponse> GetExchangeRates([WorkflowExpression] Func<string> basecurrency)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/latest/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(basecurrency, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetExchangeRatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        public IBodyWorkflowAction<GetExchangeRateResponse> GetExchangeRate([WorkflowExpression] Func<string> baseCurrency, [WorkflowExpression] Func<string> targetCurrency)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pair/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseCurrency, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(targetCurrency, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetExchangeRateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        public IBodyWorkflowAction<ListCurrenciesResponse> ListCurrencies()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListCurrenciesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        public IBodyWorkflowAction<GetHistoricalRatesResponse> GetHistoricalRates([WorkflowExpression] Func<string> baseCurrency, [WorkflowExpression] Func<string> year, [WorkflowExpression] Func<string> month, [WorkflowExpression] Func<string> day)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/history/{0}/{1}/{2}/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseCurrency, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(year, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(month, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(day, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetHistoricalRatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "exchangerateip")]
        public IBodyWorkflowAction<GetHistoricalConversionsResponse> GetHistoricalConversions([WorkflowExpression] Func<string> baseCurrency, [WorkflowExpression] Func<string> year, [WorkflowExpression] Func<string> month, [WorkflowExpression] Func<string> day, [WorkflowExpression] Func<string> amount)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/history/{0}/{1}/{2}/{3}/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseCurrency, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(year, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(month, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(day, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(amount, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetHistoricalConversionsResponse>(BuildSourceInput);
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