//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iqairip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IqairipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iqairip")]
        public IBodyWorkflowAction<ListCountriesResponse> ListCountries()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListCountriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iqairip")]
        public IBodyWorkflowAction<ListStatesResponse> ListStates([WorkflowExpression] Func<string> country = null)
        {
            SourceExpression.Validate(country, nameof(country), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/states";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                return callPayload;
            }

            return new ApiConnectionAction<ListStatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iqairip")]
        public IBodyWorkflowAction<ListCitiesResponse> ListCities([WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> country = null)
        {
            SourceExpression.Validate(state, nameof(state), required: false);
            SourceExpression.Validate(country, nameof(country), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                return callPayload;
            }

            return new ApiConnectionAction<ListCitiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iqairip")]
        public IBodyWorkflowAction<CityResponse> GetDataByCoordinates([WorkflowExpression] Func<string> lat = null, [WorkflowExpression] Func<string> lon = null)
        {
            SourceExpression.Validate(lat, nameof(lat), required: false);
            SourceExpression.Validate(lon, nameof(lon), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nearest_city";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                return callPayload;
            }

            return new ApiConnectionAction<CityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iqairip")]
        public IBodyWorkflowAction<CityResponse> GetDataByCity([WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> country = null)
        {
            SourceExpression.Validate(city, nameof(city), required: false);
            SourceExpression.Validate(state, nameof(state), required: false);
            SourceExpression.Validate(country, nameof(country), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/city";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                return callPayload;
            }

            return new ApiConnectionAction<CityResponse>(BuildSourceInput);
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