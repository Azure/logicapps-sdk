//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractexchangerate
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractexchangerateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractexchangerate")]
        public IBodyWorkflowAction<LiveRatesResponse, ApiConnectionActionConfiguration> LiveRates(Expression<Func<string>> @base, Expression<Func<string>> target = null)
        {
            var __workflow_base = WorkflowExpression.Compile(@base, nameof(@base), required: true);
            var __workflow_target = WorkflowExpression.Compile(target, nameof(target), required: false);
            return new DeferredBodyAction<LiveRatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/live/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["base"] = ExpressionConverter.Convert(__workflow_base);
                if (__workflow_target != null)
                    callPayload.Queries["target"] = ExpressionConverter.Convert(__workflow_target);
                return new ApiConnectionAction<LiveRatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractexchangerate")]
        public IBodyWorkflowAction<ConvertResponse, ApiConnectionActionConfiguration> Convert(Expression<Func<string>> @base, Expression<Func<string>> target, Expression<Func<string>> date = null, Expression<Func<double>> baseAmount = null)
        {
            var __workflow_base = WorkflowExpression.Compile(@base, nameof(@base), required: true);
            var __workflow_target = WorkflowExpression.Compile(target, nameof(target), required: true);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_baseAmount = WorkflowExpression.Compile(baseAmount, nameof(baseAmount), required: false);
            return new DeferredBodyAction<ConvertResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/convert/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["base"] = ExpressionConverter.Convert(__workflow_base);
                callPayload.Queries["target"] = ExpressionConverter.Convert(__workflow_target);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_baseAmount != null)
                    callPayload.Queries["base_amount"] = ExpressionConverter.Convert(__workflow_baseAmount);
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