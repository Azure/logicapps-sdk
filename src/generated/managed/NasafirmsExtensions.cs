//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nasafirms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NasafirmsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        [WorkflowExpressionFactory(nameof(__BuildGetArea))]
        public IWorkflowAction GetArea([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> areaCoord, [WorkflowExpression] Func<dayRangeInput> dayRange)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetArea(WorkflowExpression<string> source, WorkflowExpression<string> areaCoord, WorkflowExpression<dayRangeInput> dayRange)
        {
            WorkflowExpression.Validate(source, nameof(source), required: true);
            WorkflowExpression.Validate(areaCoord, nameof(areaCoord), required: true);
            WorkflowExpression.Validate(dayRange, nameof(dayRange), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/area/csv/api_key/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(source, 1), ExpressionConverter.ConvertWithUrlEncoding(areaCoord, 1), ExpressionConverter.ConvertWithUrlEncoding(dayRange, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        [WorkflowExpressionFactory(nameof(__BuildGetCountry))]
        public IWorkflowAction GetCountry([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> country, [WorkflowExpression] Func<dayRangeInput> dayRange)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetCountry(WorkflowExpression<string> source, WorkflowExpression<string> country, WorkflowExpression<dayRangeInput> dayRange)
        {
            WorkflowExpression.Validate(source, nameof(source), required: true);
            WorkflowExpression.Validate(country, nameof(country), required: true);
            WorkflowExpression.Validate(dayRange, nameof(dayRange), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/country/csv/api_key/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(source, 1), ExpressionConverter.ConvertWithUrlEncoding(country, 1), ExpressionConverter.ConvertWithUrlEncoding(dayRange, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        [WorkflowExpressionFactory(nameof(__BuildCheckMapKey))]
        public IBodyWorkflowAction<CheckMapKeyResponse> CheckMapKey([WorkflowExpression] Func<string> mAPKEY)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckMapKeyResponse> __BuildCheckMapKey(WorkflowExpression<string> mAPKEY)
        {
            WorkflowExpression.Validate(mAPKEY, nameof(mAPKEY), required: true);
            return new DeferredBodyAction<CheckMapKeyResponse>(() =>
            {
                var apiCallPath = "/mapserver/mapkey_status/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["MAP_KEY"] = ExpressionConverter.Convert(mAPKEY);
                return new ApiConnectionAction<CheckMapKeyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IWorkflowAction ListCountries()
        {
            var apiCallPath = "/api/countries/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IWorkflowAction ListDataSources()
        {
            var apiCallPath = "/api/data_availability/csv/api_key/ALL";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class NasafirmsTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum dayRangeInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10
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