//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iqairip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IqairipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iqairip")]
        public IBodyWorkflowAction<ListCountriesResponse> ListCountries()
        {
            var apiCallPath = "/countries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListCountriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iqairip")]
        [WorkflowExpressionFactory(nameof(__BuildListStates))]
        public IBodyWorkflowAction<ListStatesResponse> ListStates([WorkflowExpression] Func<string> country = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListStatesResponse> __BuildListStates(WorkflowValue<string> country = null)
        {
            WorkflowValue.Validate(country, nameof(country), required: false);
            return new DeferredBodyAction<ListStatesResponse>(() =>
            {
                var apiCallPath = "/states";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                return new ApiConnectionAction<ListStatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iqairip")]
        [WorkflowExpressionFactory(nameof(__BuildListCities))]
        public IBodyWorkflowAction<ListCitiesResponse> ListCities([WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> country = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListCitiesResponse> __BuildListCities(WorkflowValue<string> state = null, WorkflowValue<string> country = null)
        {
            WorkflowValue.Validate(state, nameof(state), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            return new DeferredBodyAction<ListCitiesResponse>(() =>
            {
                var apiCallPath = "/cities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                return new ApiConnectionAction<ListCitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iqairip")]
        [WorkflowExpressionFactory(nameof(__BuildGetDataByCoordinates))]
        public IBodyWorkflowAction<CityResponse> GetDataByCoordinates([WorkflowExpression] Func<string> lat = null, [WorkflowExpression] Func<string> lon = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CityResponse> __BuildGetDataByCoordinates(WorkflowValue<string> lat = null, WorkflowValue<string> lon = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lon, nameof(lon), required: false);
            return new DeferredBodyAction<CityResponse>(() =>
            {
                var apiCallPath = "/nearest_city";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lon != null)
                    callPayload.Queries["lon"] = ExpressionConverter.Convert(lon);
                return new ApiConnectionAction<CityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iqairip")]
        [WorkflowExpressionFactory(nameof(__BuildGetDataByCity))]
        public IBodyWorkflowAction<CityResponse> GetDataByCity([WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> country = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CityResponse> __BuildGetDataByCity(WorkflowValue<string> city = null, WorkflowValue<string> state = null, WorkflowValue<string> country = null)
        {
            WorkflowValue.Validate(city, nameof(city), required: false);
            WorkflowValue.Validate(state, nameof(state), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            return new DeferredBodyAction<CityResponse>(() =>
            {
                var apiCallPath = "/city";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(city);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                return new ApiConnectionAction<CityResponse>(callPayload);
            });
        }
    }

    public class IqairipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListCountriesResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public ListCountriesResponseDataTypeItem[] Data { get; set; }
    }

    public class ListCountriesResponseDataTypeItem
    {
        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ListStatesResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public ListStatesResponseDataTypeItem[] Data { get; set; }
    }

    public class ListStatesResponseDataTypeItem
    {
        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class ListCitiesResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public ListCitiesResponseDataTypeItem[] Data { get; set; }
    }

    public class ListCitiesResponseDataTypeItem
    {
        [JsonProperty("city")]
        public string City { get; set; }
    }

    public class CityResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public CityResponseDataType Data { get; set; }
    }

    public class CityResponseDataType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("location")]
        public CityResponseDataTypeLocationType Location { get; set; }

        [JsonProperty("current")]
        public CityResponseDataTypeCurrentType Current { get; set; }
    }

    public class CityResponseDataTypeLocationType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }

    public class CityResponseDataTypeCurrentType
    {
        [JsonProperty("pollution")]
        public CityResponseDataTypeCurrentTypePollutionType Pollution { get; set; }

        [JsonProperty("weather")]
        public CityResponseDataTypeCurrentTypeWeatherType Weather { get; set; }
    }

    public class CityResponseDataTypeCurrentTypePollutionType
    {
        [JsonProperty("ts")]
        public string Ts { get; set; }

        [JsonProperty("aqius")]
        public int Aqius { get; set; }

        [JsonProperty("mainus")]
        public string Mainus { get; set; }

        [JsonProperty("aqicn")]
        public int Aqicn { get; set; }

        [JsonProperty("maincn")]
        public string Maincn { get; set; }
    }

    public class CityResponseDataTypeCurrentTypeWeatherType
    {
        [JsonProperty("ts")]
        public string Ts { get; set; }

        [JsonProperty("tp")]
        public int Tp { get; set; }

        [JsonProperty("pr")]
        public int Pr { get; set; }

        [JsonProperty("hu")]
        public int Hu { get; set; }

        [JsonProperty("ws")]
        public double Ws { get; set; }

        [JsonProperty("wd")]
        public int Wd { get; set; }

        [JsonProperty("ic")]
        public string Ic { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iqairip;

    public partial class WorkflowManagedActions
    {
        public IqairipActions Iqairip(string connectionId) => new IqairipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IqairipTriggers Iqairip(string connectionId) => new IqairipTriggers(connectionId);
    }
}
