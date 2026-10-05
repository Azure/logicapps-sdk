//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractexchangerate
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractexchangerateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractexchangerate")]
        [WorkflowExpressionFactory(nameof(__BuildLiveRates))]
        public IBodyWorkflowAction<LiveRatesResponse> LiveRates([WorkflowExpression] Func<string> @base, [WorkflowExpression] Func<string> target = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LiveRatesResponse> __BuildLiveRates(WorkflowValue<string> @base, WorkflowValue<string> target = null)
        {
            WorkflowValue.Validate(@base, nameof(@base), required: true);
            WorkflowValue.Validate(target, nameof(target), required: false);
            return new DeferredBodyAction<LiveRatesResponse>(() =>
            {
                var apiCallPath = "/v1/live/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["base"] = ExpressionConverter.Convert(@base);
                if (target != null)
                    callPayload.Queries["target"] = ExpressionConverter.Convert(target);
                return new ApiConnectionAction<LiveRatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractexchangerate")]
        [WorkflowExpressionFactory(nameof(__BuildConvert))]
        public IBodyWorkflowAction<ConvertResponse> Convert([WorkflowExpression] Func<string> @base, [WorkflowExpression] Func<string> target, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<double> baseAmount = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConvertResponse> __BuildConvert(WorkflowValue<string> @base, WorkflowValue<string> target, WorkflowValue<string> date = null, WorkflowValue<double> baseAmount = null)
        {
            WorkflowValue.Validate(@base, nameof(@base), required: true);
            WorkflowValue.Validate(target, nameof(target), required: true);
            WorkflowValue.Validate(date, nameof(date), required: false);
            WorkflowValue.Validate(baseAmount, nameof(baseAmount), required: false);
            return new DeferredBodyAction<ConvertResponse>(() =>
            {
                var apiCallPath = "/v1/convert/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["base"] = ExpressionConverter.Convert(@base);
                callPayload.Queries["target"] = ExpressionConverter.Convert(target);
                if (date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                if (baseAmount != null)
                    callPayload.Queries["base_amount"] = ExpressionConverter.Convert(baseAmount);
                return new ApiConnectionAction<ConvertResponse>(callPayload);
            });
        }
    }

    public class AbstractexchangerateTriggers([ConnectionName] string connectionId)
    {
    }

    public class LiveRatesResponse
    {
        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("last_updated")]
        public int LastUpdated { get; set; }

        [JsonProperty("exchange_rates")]
        public JToken ExchangeRates { get; set; }
    }

    public class ConvertResponse
    {
        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("base_amount")]
        public double BaseAmount { get; set; }

        [JsonProperty("converted_amount")]
        public double ConvertedAmount { get; set; }

        [JsonProperty("exchange_rate")]
        public double ExchangeRate { get; set; }

        [JsonProperty("last_updated")]
        public int LastUpdated { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abstractexchangerate;

    public partial class WorkflowManagedActions
    {
        public AbstractexchangerateActions Abstractexchangerate(string connectionId) => new AbstractexchangerateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbstractexchangerateTriggers Abstractexchangerate(string connectionId) => new AbstractexchangerateTriggers(connectionId);
    }
}
