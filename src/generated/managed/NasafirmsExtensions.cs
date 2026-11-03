//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nasafirms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NasafirmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetArea(Expression<Func<string>> source, Expression<Func<string>> areaCoord, Expression<Func<dayRangeInput>> dayRange)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_areaCoord = WorkflowExpression.Compile(areaCoord, nameof(areaCoord), required: true);
            var __workflow_dayRange = WorkflowExpression.Compile(dayRange, nameof(dayRange), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/area/csv/api_key/{0}/{1}/{2}", __workflow_source.WithUrlEncoding(1), __workflow_areaCoord.WithUrlEncoding(1), __workflow_dayRange.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetCountry(Expression<Func<string>> source, Expression<Func<string>> country, Expression<Func<dayRangeInput>> dayRange)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            var __workflow_dayRange = WorkflowExpression.Compile(dayRange, nameof(dayRange), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/country/csv/api_key/{0}/{1}/{2}", __workflow_source.WithUrlEncoding(1), __workflow_country.WithUrlEncoding(1), __workflow_dayRange.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IBodyWorkflowAction<CheckMapKeyResponse, ApiConnectionActionConfiguration> CheckMapKey(Expression<Func<string>> mAPKEY)
        {
            var __workflow_mAPKEY = WorkflowExpression.Compile(mAPKEY, nameof(mAPKEY), required: true);
            return new DeferredBodyAction<CheckMapKeyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mapserver/mapkey_status/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["MAP_KEY"] = ExpressionConverter.Convert(__workflow_mAPKEY);
                return new ApiConnectionAction<CheckMapKeyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ListCountries()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/countries/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ListDataSources()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/data_availability/csv/api_key/ALL";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class NasafirmsTriggers([ConnectionName] string connectionId)
    {
    }

    public enum dayRangeInput
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8,
        _9 = 9,
        _10 = 10
    }

    public class CheckMapKeyResponse
    {
        [JsonProperty("transaction_limit")]
        public int TransactionLimit { get; set; }

        [JsonProperty("current_transactions")]
        public int CurrentTransactions { get; set; }

        [JsonProperty("transaction_interval")]
        public string TransactionInterval { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nasafirms;

    public partial class WorkflowManagedActions
    {
        public NasafirmsActions Nasafirms(string connectionId) => new NasafirmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NasafirmsTriggers Nasafirms(string connectionId) => new NasafirmsTriggers(connectionId);
    }
}