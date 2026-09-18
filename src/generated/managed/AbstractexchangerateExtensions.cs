//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractexchangerate
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractexchangerateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractexchangerate")]
        public IBodyWorkflowAction<LiveRatesResponse> LiveRates([WorkflowExpression] Func<string> @base, [WorkflowExpression] Func<string> target = null)
        {
            SourceExpression.Validate(@base, nameof(@base), required: true);
            SourceExpression.Validate(target, nameof(target), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/live/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["base"] = SourceExpressionConverter.ConvertO(@base);
                if (target != null)
                    callPayload.Queries["target"] = SourceExpressionConverter.ConvertO(target);
                return callPayload;
            }

            return new ApiConnectionAction<LiveRatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractexchangerate")]
        public IBodyWorkflowAction<ConvertResponse> Convert([WorkflowExpression] Func<string> @base, [WorkflowExpression] Func<string> target, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<double> baseAmount = null)
        {
            SourceExpression.Validate(@base, nameof(@base), required: true);
            SourceExpression.Validate(target, nameof(target), required: true);
            SourceExpression.Validate(date, nameof(date), required: false);
            SourceExpression.Validate(baseAmount, nameof(baseAmount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/convert/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["base"] = SourceExpressionConverter.ConvertO(@base);
                callPayload.Queries["target"] = SourceExpressionConverter.ConvertO(target);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (baseAmount != null)
                    callPayload.Queries["base_amount"] = SourceExpressionConverter.ConvertO(baseAmount);
                return callPayload;
            }

            return new ApiConnectionAction<ConvertResponse>(BuildSourceInput);
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