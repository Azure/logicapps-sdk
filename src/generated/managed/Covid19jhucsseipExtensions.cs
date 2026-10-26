//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Covid19jhucsseip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Covid19jhucsseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "covid19jhucsseip")]
        public IBodyWorkflowAction<GetCurrentV2CurrentGetResponse, ApiConnectionActionConfiguration> GetCurrentV2CurrentGet()
        {
            return new DeferredBodyAction<GetCurrentV2CurrentGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/current";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCurrentV2CurrentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "covid19jhucsseip")]
        public IBodyWorkflowAction<GetCurrentUsV2CurrentUSGetResponse, ApiConnectionActionConfiguration> GetCurrentUsV2CurrentUSGet()
        {
            return new DeferredBodyAction<GetCurrentUsV2CurrentUSGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/current/US";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCurrentUsV2CurrentUSGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "covid19jhucsseip")]
        public IBodyWorkflowAction<GetTotalV2TotalGetResponse, ApiConnectionActionConfiguration> GetTotalV2TotalGet()
        {
            return new DeferredBodyAction<GetTotalV2TotalGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/total";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTotalV2TotalGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "covid19jhucsseip")]
        public IBodyWorkflowAction<GetConfirmedV2ConfirmedGetResponse, ApiConnectionActionConfiguration> GetConfirmedV2ConfirmedGet()
        {
            return new DeferredBodyAction<GetConfirmedV2ConfirmedGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/confirmed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetConfirmedV2ConfirmedGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "covid19jhucsseip")]
        public IBodyWorkflowAction<GetDeathsV2DeathsGetResponse, ApiConnectionActionConfiguration> GetDeathsV2DeathsGet()
        {
            return new DeferredBodyAction<GetDeathsV2DeathsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/deaths";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDeathsV2DeathsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "covid19jhucsseip")]
        public IBodyWorkflowAction<GetRecoveredV2RecoveredGetResponse, ApiConnectionActionConfiguration> GetRecoveredV2RecoveredGet()
        {
            return new DeferredBodyAction<GetRecoveredV2RecoveredGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/recovered";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRecoveredV2RecoveredGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "covid19jhucsseip")]
        public IBodyWorkflowAction<GetActiveV2ActiveGetResponse, ApiConnectionActionConfiguration> GetActiveV2ActiveGet()
        {
            return new DeferredBodyAction<GetActiveV2ActiveGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/active";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetActiveV2ActiveGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "covid19jhucsseip")]
        public IBodyWorkflowAction<GetCountryV2CountryCountryNameGetResponse, ApiConnectionActionConfiguration> GetCountryV2CountryCountryNameGet(Expression<Func<string>> countryName)
        {
            var __workflow_countryName = WorkflowExpression.Compile(countryName, nameof(countryName), required: true);
            return new DeferredBodyAction<GetCountryV2CountryCountryNameGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/country/{0}", __workflow_countryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCountryV2CountryCountryNameGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "covid19jhucsseip")]
        public IBodyWorkflowAction<GetTimeSeriesV2TimeseriesCaseGetResponse, ApiConnectionActionConfiguration> GetTimeSeriesV2TimeseriesCaseGet(Expression<Func<string>> @case)
        {
            var __workflow_case = WorkflowExpression.Compile(@case, nameof(@case), required: true);
            return new DeferredBodyAction<GetTimeSeriesV2TimeseriesCaseGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/timeseries/{0}", __workflow_case.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTimeSeriesV2TimeseriesCaseGetResponse>(callPayload);
            });
        }
    }

    public class Covid19jhucsseipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCurrentV2CurrentGetResponse
    {
        [JsonProperty("data")]
        public GetCurrentV2CurrentGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }
    }

    public class GetCurrentV2CurrentGetResponseDataTypeItem
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("confirmed")]
        public int Confirmed { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }
    }

    public class GetCurrentUsV2CurrentUSGetResponse
    {
        [JsonProperty("data")]
        public GetCurrentUsV2CurrentUSGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }
    }

    public class GetCurrentUsV2CurrentUSGetResponseDataTypeItem
    {
        [JsonProperty("Province_State")]
        public string ProvinceState { get; set; }
        public int Confirmed { get; set; }
        public int Deaths { get; set; }
        public int Recovered { get; set; }
        public int Active { get; set; }
    }

    public class GetTotalV2TotalGetResponse
    {
        [JsonProperty("data")]
        public GetTotalV2TotalGetResponseDataType Data { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }
    }

    public class GetTotalV2TotalGetResponseDataType
    {
        [JsonProperty("confirmed")]
        public int Confirmed { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }
    }

    public class GetConfirmedV2ConfirmedGetResponse
    {
        [JsonProperty("data")]
        public GetConfirmedV2ConfirmedGetResponseDataType Data { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }
    }

    public class GetConfirmedV2ConfirmedGetResponseDataType
    {
        [JsonProperty("confirmed")]
        public int Confirmed { get; set; }
    }

    public class GetDeathsV2DeathsGetResponse
    {
        [JsonProperty("data")]
        public GetDeathsV2DeathsGetResponseDataType Data { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }
    }

    public class GetDeathsV2DeathsGetResponseDataType
    {
        [JsonProperty("deaths")]
        public int Deaths { get; set; }
    }

    public class GetRecoveredV2RecoveredGetResponse
    {
        [JsonProperty("data")]
        public GetRecoveredV2RecoveredGetResponseDataType Data { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }
    }

    public class GetRecoveredV2RecoveredGetResponseDataType
    {
        [JsonProperty("recovered")]
        public int Recovered { get; set; }
    }

    public class GetActiveV2ActiveGetResponse
    {
        [JsonProperty("data")]
        public GetActiveV2ActiveGetResponseDataType Data { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }
    }

    public class GetActiveV2ActiveGetResponseDataType
    {
        [JsonProperty("active")]
        public int Active { get; set; }
    }

    public class GetCountryV2CountryCountryNameGetResponse
    {
        [JsonProperty("data")]
        public GetCountryV2CountryCountryNameGetResponseDataType Data { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }
    }

    public class GetCountryV2CountryCountryNameGetResponseDataType
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("confirmed")]
        public int Confirmed { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }
    }

    public class GetTimeSeriesV2TimeseriesCaseGetResponse
    {
        [JsonProperty("data")]
        public JToken[] Data { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Covid19jhucsseip;

    public partial class WorkflowManagedActions
    {
        public Covid19jhucsseipActions Covid19jhucsseip(string connectionId) => new Covid19jhucsseipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Covid19jhucsseipTriggers Covid19jhucsseip(string connectionId) => new Covid19jhucsseipTriggers(connectionId);
    }
}