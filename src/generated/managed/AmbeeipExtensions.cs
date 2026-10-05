//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ambeeip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AmbeeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildAirQualityGeo))]
        public IBodyWorkflowAction<AirQualityGeoResponse> AirQualityGeo([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AirQualityGeoResponse> __BuildAirQualityGeo(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            return new DeferredBodyAction<AirQualityGeoResponse>(() =>
            {
                var apiCallPath = "/latest/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                return new ApiConnectionAction<AirQualityGeoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildAirQualityPostal))]
        public IBodyWorkflowAction<AirQualityPostalResponse> AirQualityPostal([WorkflowExpression] Func<int> postalCode = null, [WorkflowExpression] Func<string> countryCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AirQualityPostalResponse> __BuildAirQualityPostal(WorkflowValue<int> postalCode = null, WorkflowValue<string> countryCode = null)
        {
            WorkflowValue.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowValue.Validate(countryCode, nameof(countryCode), required: false);
            return new DeferredBodyAction<AirQualityPostalResponse>(() =>
            {
                var apiCallPath = "/latest/by-postal-code";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(postalCode);
                if (countryCode != null)
                    callPayload.Queries["countryCode"] = ExpressionConverter.Convert(countryCode);
                return new ApiConnectionAction<AirQualityPostalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildAirQualityCity))]
        public IBodyWorkflowAction<AirQualityCityResponse> AirQualityCity([WorkflowExpression] Func<string> city = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AirQualityCityResponse> __BuildAirQualityCity(WorkflowValue<string> city = null)
        {
            WorkflowValue.Validate(city, nameof(city), required: false);
            return new DeferredBodyAction<AirQualityCityResponse>(() =>
            {
                var apiCallPath = "/latest/by-city";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(city);
                return new ApiConnectionAction<AirQualityCityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildAirQualityCountry))]
        public IBodyWorkflowAction<AirQualityCountryResponse> AirQualityCountry([WorkflowExpression] Func<string> countryCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AirQualityCountryResponse> __BuildAirQualityCountry(WorkflowValue<string> countryCode = null)
        {
            WorkflowValue.Validate(countryCode, nameof(countryCode), required: false);
            return new DeferredBodyAction<AirQualityCountryResponse>(() =>
            {
                var apiCallPath = "/latest/by-country-code";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (countryCode != null)
                    callPayload.Queries["countryCode"] = ExpressionConverter.Convert(countryCode);
                return new ApiConnectionAction<AirQualityCountryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildAirQualityGeoHistory))]
        public IBodyWorkflowAction<AirQualityGeoHistoryResponse> AirQualityGeoHistory([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AirQualityGeoHistoryResponse> __BuildAirQualityGeoHistory(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null, WorkflowValue<string> from = null, WorkflowValue<string> to = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            return new DeferredBodyAction<AirQualityGeoHistoryResponse>(() =>
            {
                var apiCallPath = "/history/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                return new ApiConnectionAction<AirQualityGeoHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildAirQualityPostalHistory))]
        public IBodyWorkflowAction<AirQualityPostalHistoryResponse> AirQualityPostalHistory([WorkflowExpression] Func<int> postalCode = null, [WorkflowExpression] Func<string> countryCode = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AirQualityPostalHistoryResponse> __BuildAirQualityPostalHistory(WorkflowValue<int> postalCode = null, WorkflowValue<string> countryCode = null, WorkflowValue<string> from = null, WorkflowValue<string> to = null)
        {
            WorkflowValue.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowValue.Validate(countryCode, nameof(countryCode), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            return new DeferredBodyAction<AirQualityPostalHistoryResponse>(() =>
            {
                var apiCallPath = "/history/by-postal-code";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(postalCode);
                if (countryCode != null)
                    callPayload.Queries["countryCode"] = ExpressionConverter.Convert(countryCode);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                return new ApiConnectionAction<AirQualityPostalHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        public IBodyWorkflowAction<AirQualityMostPollutedResponse> AirQualityMostPolluted()
        {
            var apiCallPath = "/latest/by-order/worst";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AirQualityMostPollutedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        public IBodyWorkflowAction<AirQualityLeastPollutedResponse> AirQualityLeastPolluted()
        {
            var apiCallPath = "/latest/by-order/best";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AirQualityLeastPollutedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildWeatherCurrent))]
        public IBodyWorkflowAction<WeatherCurrentResponse> WeatherCurrent([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WeatherCurrentResponse> __BuildWeatherCurrent(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            return new DeferredBodyAction<WeatherCurrentResponse>(() =>
            {
                var apiCallPath = "/weather/latest/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                return new ApiConnectionAction<WeatherCurrentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildWeatherHistory))]
        public IBodyWorkflowAction<WeatherHistoryResponse> WeatherHistory([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WeatherHistoryResponse> __BuildWeatherHistory(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null, WorkflowValue<string> from = null, WorkflowValue<string> to = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            return new DeferredBodyAction<WeatherHistoryResponse>(() =>
            {
                var apiCallPath = "/weather/history/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                return new ApiConnectionAction<WeatherHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildWeatherForecast))]
        public IBodyWorkflowAction<WeatherForecastResponse> WeatherForecast([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null, [WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WeatherForecastResponse> __BuildWeatherForecast(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null, WorkflowValue<string> filter = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<WeatherForecastResponse>(() =>
            {
                var apiCallPath = "/weather/forecast/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<WeatherForecastResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildPollenLatestGeo))]
        public IBodyWorkflowAction<PollenLatestGeoResponse> PollenLatestGeo([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PollenLatestGeoResponse> __BuildPollenLatestGeo(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            return new DeferredBodyAction<PollenLatestGeoResponse>(() =>
            {
                var apiCallPath = "/latest/pollen/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                return new ApiConnectionAction<PollenLatestGeoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildPollenLatestPlace))]
        public IBodyWorkflowAction<PollenLatestPlaceResponse> PollenLatestPlace([WorkflowExpression] Func<string> place = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PollenLatestPlaceResponse> __BuildPollenLatestPlace(WorkflowValue<string> place = null)
        {
            WorkflowValue.Validate(place, nameof(place), required: false);
            return new DeferredBodyAction<PollenLatestPlaceResponse>(() =>
            {
                var apiCallPath = "/latest/pollen/by-place";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (place != null)
                    callPayload.Queries["place"] = ExpressionConverter.Convert(place);
                return new ApiConnectionAction<PollenLatestPlaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildPollenHistoryGeo))]
        public IBodyWorkflowAction<PollenHistoryGeoResponse> PollenHistoryGeo([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PollenHistoryGeoResponse> __BuildPollenHistoryGeo(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null, WorkflowValue<string> from = null, WorkflowValue<string> to = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            return new DeferredBodyAction<PollenHistoryGeoResponse>(() =>
            {
                var apiCallPath = "/history/pollen/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                return new ApiConnectionAction<PollenHistoryGeoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildPollenHistoryPlace))]
        public IBodyWorkflowAction<PollenHistoryPlaceResponse> PollenHistoryPlace([WorkflowExpression] Func<string> place = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PollenHistoryPlaceResponse> __BuildPollenHistoryPlace(WorkflowValue<string> place = null, WorkflowValue<string> from = null, WorkflowValue<string> to = null)
        {
            WorkflowValue.Validate(place, nameof(place), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            return new DeferredBodyAction<PollenHistoryPlaceResponse>(() =>
            {
                var apiCallPath = "/history/pollen/by-place";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (place != null)
                    callPayload.Queries["place"] = ExpressionConverter.Convert(place);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                return new ApiConnectionAction<PollenHistoryPlaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildPollForecastGeo))]
        public IBodyWorkflowAction<PollForecastGeoResponse> PollForecastGeo([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PollForecastGeoResponse> __BuildPollForecastGeo(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            return new DeferredBodyAction<PollForecastGeoResponse>(() =>
            {
                var apiCallPath = "/forecast/pollen/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                return new ApiConnectionAction<PollForecastGeoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildFireCurrent))]
        public IBodyWorkflowAction<FireCurrentResponse> FireCurrent([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FireCurrentResponse> __BuildFireCurrent(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            return new DeferredBodyAction<FireCurrentResponse>(() =>
            {
                var apiCallPath = "/latest/fire";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                return new ApiConnectionAction<FireCurrentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildSoilCurrent))]
        public IBodyWorkflowAction<SoilCurrentResponse> SoilCurrent([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SoilCurrentResponse> __BuildSoilCurrent(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            return new DeferredBodyAction<SoilCurrentResponse>(() =>
            {
                var apiCallPath = "/soil/latest/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                return new ApiConnectionAction<SoilCurrentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildSoilHistory))]
        public IBodyWorkflowAction<SoilHistoryResponse> SoilHistory([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SoilHistoryResponse> __BuildSoilHistory(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null, WorkflowValue<string> from = null, WorkflowValue<string> to = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            return new DeferredBodyAction<SoilHistoryResponse>(() =>
            {
                var apiCallPath = "/soil/history/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                return new ApiConnectionAction<SoilHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildWaterVaporCurrent))]
        public IBodyWorkflowAction<WaterVaporCurrentResponse> WaterVaporCurrent([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WaterVaporCurrentResponse> __BuildWaterVaporCurrent(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            return new DeferredBodyAction<WaterVaporCurrentResponse>(() =>
            {
                var apiCallPath = "/waterVapor/latest/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                return new ApiConnectionAction<WaterVaporCurrentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ambeeip")]
        [WorkflowExpressionFactory(nameof(__BuildWaterVaporGeo))]
        public IBodyWorkflowAction<WaterVaporGeoResponse> WaterVaporGeo([WorkflowExpression] Func<int> lat = null, [WorkflowExpression] Func<int> lng = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WaterVaporGeoResponse> __BuildWaterVaporGeo(WorkflowValue<int> lat = null, WorkflowValue<int> lng = null, WorkflowValue<string> from = null, WorkflowValue<string> to = null)
        {
            WorkflowValue.Validate(lat, nameof(lat), required: false);
            WorkflowValue.Validate(lng, nameof(lng), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            return new DeferredBodyAction<WaterVaporGeoResponse>(() =>
            {
                var apiCallPath = "/waterVapor/history/by-lat-lng";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (lng != null)
                    callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                return new ApiConnectionAction<WaterVaporGeoResponse>(callPayload);
            });
        }
    }

    public class AmbeeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AirQualityGeoResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("stations")]
        public AirQualityGeoResponseStationsTypeItem[] Stations { get; set; }
    }

    public class AirQualityGeoResponseStationsTypeItem
    {
        public double CO { get; set; }
        public double NO2 { get; set; }
        public double OZONE { get; set; }
        public double PM10 { get; set; }
        public double PM25 { get; set; }
        public double SO2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("placeName")]
        public string PlaceName { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        public int AQI { get; set; }

        [JsonProperty("aqiInfo")]
        public AirQualityGeoResponseStationsTypeItemAqiInfoType AqiInfo { get; set; }
    }

    public class AirQualityGeoResponseStationsTypeItemAqiInfoType
    {
        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("concentration")]
        public double Concentration { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class AirQualityPostalResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("stations")]
        public AirQualityPostalResponseStationsTypeItem[] Stations { get; set; }
    }

    public class AirQualityPostalResponseStationsTypeItem
    {
        public double CO { get; set; }
        public double NO2 { get; set; }
        public double OZONE { get; set; }
        public double PM10 { get; set; }
        public double PM25 { get; set; }
        public double SO2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("placeName")]
        public string PlaceName { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        public int AQI { get; set; }

        [JsonProperty("aqiInfo")]
        public AirQualityPostalResponseStationsTypeItemAqiInfoType AqiInfo { get; set; }
    }

    public class AirQualityPostalResponseStationsTypeItemAqiInfoType
    {
        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("concentration")]
        public double Concentration { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class AirQualityCityResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("stations")]
        public AirQualityCityResponseStationsTypeItem[] Stations { get; set; }
    }

    public class AirQualityCityResponseStationsTypeItem
    {
        public double CO { get; set; }
        public double NO2 { get; set; }
        public double OZONE { get; set; }
        public double PM10 { get; set; }
        public double PM25 { get; set; }
        public double SO2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("placeName")]
        public string PlaceName { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        public int AQI { get; set; }

        [JsonProperty("aqiInfo")]
        public AirQualityCityResponseStationsTypeItemAqiInfoType AqiInfo { get; set; }
    }

    public class AirQualityCityResponseStationsTypeItemAqiInfoType
    {
        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("concentration")]
        public double Concentration { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class AirQualityCountryResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("stations")]
        public AirQualityCountryResponseStationsTypeItem[] Stations { get; set; }
    }

    public class AirQualityCountryResponseStationsTypeItem
    {
        public double CO { get; set; }
        public double NO2 { get; set; }
        public double OZONE { get; set; }
        public double PM10 { get; set; }
        public double PM25 { get; set; }
        public double SO2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("placeName")]
        public string PlaceName { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        public int AQI { get; set; }

        [JsonProperty("aqiInfo")]
        public AirQualityCountryResponseStationsTypeItemAqiInfoType AqiInfo { get; set; }
    }

    public class AirQualityCountryResponseStationsTypeItemAqiInfoType
    {
        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("concentration")]
        public double Concentration { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class AirQualityGeoHistoryResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public AirQualityGeoHistoryResponseDataTypeItem[] Data { get; set; }
    }

    public class AirQualityGeoHistoryResponseDataTypeItem
    {
        public double NO2 { get; set; }
        public double PM10 { get; set; }
        public double PM25 { get; set; }
        public double CO { get; set; }
        public double SO2 { get; set; }
        public double OZONE { get; set; }
        public int AQI { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("majorPollutant")]
        public string MajorPollutant { get; set; }
    }

    public class AirQualityPostalHistoryResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("stations")]
        public AirQualityPostalHistoryResponseStationsTypeItem[] Stations { get; set; }
    }

    public class AirQualityPostalHistoryResponseStationsTypeItem
    {
        public double CO { get; set; }
        public double NO2 { get; set; }
        public double OZONE { get; set; }
        public double PM10 { get; set; }
        public double PM25 { get; set; }
        public double SO2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("placeName")]
        public string PlaceName { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        public int AQI { get; set; }

        [JsonProperty("aqiInfo")]
        public AirQualityPostalHistoryResponseStationsTypeItemAqiInfoType AqiInfo { get; set; }
    }

    public class AirQualityPostalHistoryResponseStationsTypeItemAqiInfoType
    {
        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("concentration")]
        public double Concentration { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class AirQualityMostPollutedResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public AirQualityMostPollutedResponseDataTypeItem[] Data { get; set; }
    }

    public class AirQualityMostPollutedResponseDataTypeItem
    {
        public double NO2 { get; set; }
        public double PM10 { get; set; }
        public double PM25 { get; set; }
        public double CO { get; set; }
        public double SO2 { get; set; }
        public double OZONE { get; set; }
        public int AQI { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("majorPollutant")]
        public string MajorPollutant { get; set; }
    }

    public class AirQualityLeastPollutedResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("stations")]
        public AirQualityLeastPollutedResponseStationsTypeItem[] Stations { get; set; }
    }

    public class AirQualityLeastPollutedResponseStationsTypeItem
    {
        public double CO { get; set; }
        public double NO2 { get; set; }
        public double OZONE { get; set; }
        public double PM10 { get; set; }
        public double PM25 { get; set; }
        public double SO2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("placeName")]
        public string PlaceName { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        public int AQI { get; set; }

        [JsonProperty("aqiInfo")]
        public AirQualityLeastPollutedResponseStationsTypeItemAqiInfoType AqiInfo { get; set; }
    }

    public class AirQualityLeastPollutedResponseStationsTypeItemAqiInfoType
    {
        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("concentration")]
        public double Concentration { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class WeatherCurrentResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public WeatherCurrentResponseDataType Data { get; set; }
    }

    public class WeatherCurrentResponseDataType
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windBearing")]
        public int WindBearing { get; set; }

        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("ozone")]
        public double Ozone { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }
    }

    public class WeatherHistoryResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public WeatherHistoryResponseDataType Data { get; set; }
    }

    public class WeatherHistoryResponseDataType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("history")]
        public WeatherHistoryResponseDataTypeHistoryTypeItem[] History { get; set; }
    }

    public class WeatherHistoryResponseDataTypeHistoryTypeItem
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windBearing")]
        public int WindBearing { get; set; }

        [JsonProperty("cloudCover")]
        public int CloudCover { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("ozone")]
        public double Ozone { get; set; }
    }

    public class WeatherForecastResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public WeatherForecastResponseDataType Data { get; set; }
    }

    public class WeatherForecastResponseDataType
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }

        [JsonProperty("forecast")]
        public WeatherForecastResponseDataTypeForecastTypeItem[] Forecast { get; set; }
    }

    public class WeatherForecastResponseDataTypeForecastTypeItem
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("precipIntensity")]
        public double PrecipIntensity { get; set; }

        [JsonProperty("precipProbability")]
        public double PrecipProbability { get; set; }

        [JsonProperty("precipType")]
        public string PrecipType { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windBearing")]
        public int WindBearing { get; set; }

        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("uvIndex")]
        public int UvIndex { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("ozone")]
        public int Ozone { get; set; }
    }

    public class PollenLatestGeoResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public PollenLatestGeoResponseDataTypeItem[] Data { get; set; }
    }

    public class PollenLatestGeoResponseDataTypeItem
    {
        public PollenLatestGeoResponseDataTypeItemCountType Count { get; set; }
        public PollenLatestGeoResponseDataTypeItemRiskType Risk { get; set; }
    }

    public class PollenLatestGeoResponseDataTypeItemCountType
    {
        [JsonProperty("grass_pollen")]
        public int GrassPollen { get; set; }

        [JsonProperty("tree_pollen")]
        public int TreePollen { get; set; }

        [JsonProperty("weed_pollen")]
        public int WeedPollen { get; set; }
    }

    public class PollenLatestGeoResponseDataTypeItemRiskType
    {
        [JsonProperty("grass_pollen")]
        public string GrassPollen { get; set; }

        [JsonProperty("tree_pollen")]
        public string TreePollen { get; set; }

        [JsonProperty("weed_pollen")]
        public string WeedPollen { get; set; }
    }

    public class PollenLatestPlaceResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public PollenLatestPlaceResponseDataTypeItem[] Data { get; set; }
    }

    public class PollenLatestPlaceResponseDataTypeItem
    {
        public PollenLatestPlaceResponseDataTypeItemCountType Count { get; set; }
        public PollenLatestPlaceResponseDataTypeItemRiskType Risk { get; set; }
    }

    public class PollenLatestPlaceResponseDataTypeItemCountType
    {
        [JsonProperty("grass_pollen")]
        public int GrassPollen { get; set; }

        [JsonProperty("tree_pollen")]
        public int TreePollen { get; set; }

        [JsonProperty("weed_pollen")]
        public int WeedPollen { get; set; }
    }

    public class PollenLatestPlaceResponseDataTypeItemRiskType
    {
        [JsonProperty("grass_pollen")]
        public string GrassPollen { get; set; }

        [JsonProperty("tree_pollen")]
        public string TreePollen { get; set; }

        [JsonProperty("weed_pollen")]
        public string WeedPollen { get; set; }
    }

    public class PollenHistoryGeoResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public PollenHistoryGeoResponseDataTypeItem[] Data { get; set; }
    }

    public class PollenHistoryGeoResponseDataTypeItem
    {
        public PollenHistoryGeoResponseDataTypeItemCountType Count { get; set; }
        public PollenHistoryGeoResponseDataTypeItemRiskType Risk { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class PollenHistoryGeoResponseDataTypeItemCountType
    {
        [JsonProperty("grass_pollen")]
        public int GrassPollen { get; set; }

        [JsonProperty("tree_pollen")]
        public int TreePollen { get; set; }

        [JsonProperty("weed_pollen")]
        public int WeedPollen { get; set; }
    }

    public class PollenHistoryGeoResponseDataTypeItemRiskType
    {
        [JsonProperty("grass_pollen")]
        public string GrassPollen { get; set; }

        [JsonProperty("tree_pollen")]
        public string TreePollen { get; set; }

        [JsonProperty("weed_pollen")]
        public string WeedPollen { get; set; }
    }

    public class PollenHistoryPlaceResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public PollenHistoryPlaceResponseDataTypeItem[] Data { get; set; }
    }

    public class PollenHistoryPlaceResponseDataTypeItem
    {
        public PollenHistoryPlaceResponseDataTypeItemCountType Count { get; set; }
        public PollenHistoryPlaceResponseDataTypeItemRiskType Risk { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class PollenHistoryPlaceResponseDataTypeItemCountType
    {
        [JsonProperty("grass_pollen")]
        public int GrassPollen { get; set; }

        [JsonProperty("tree_pollen")]
        public int TreePollen { get; set; }

        [JsonProperty("weed_pollen")]
        public int WeedPollen { get; set; }
    }

    public class PollenHistoryPlaceResponseDataTypeItemRiskType
    {
        [JsonProperty("grass_pollen")]
        public string GrassPollen { get; set; }

        [JsonProperty("tree_pollen")]
        public string TreePollen { get; set; }

        [JsonProperty("weed_pollen")]
        public string WeedPollen { get; set; }
    }

    public class PollForecastGeoResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public PollForecastGeoResponseDataTypeItem[] Data { get; set; }
    }

    public class PollForecastGeoResponseDataTypeItem
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("lat")]
        public int Lat { get; set; }

        [JsonProperty("lng")]
        public int Lng { get; set; }
        public PollForecastGeoResponseDataTypeItemCountType Count { get; set; }
        public PollForecastGeoResponseDataTypeItemRiskType Risk { get; set; }
    }

    public class PollForecastGeoResponseDataTypeItemCountType
    {
        [JsonProperty("grass_pollen")]
        public int GrassPollen { get; set; }

        [JsonProperty("tree_pollen")]
        public int TreePollen { get; set; }

        [JsonProperty("weed_pollen")]
        public int WeedPollen { get; set; }
    }

    public class PollForecastGeoResponseDataTypeItemRiskType
    {
        [JsonProperty("grass_pollen")]
        public string GrassPollen { get; set; }

        [JsonProperty("tree_pollen")]
        public string TreePollen { get; set; }

        [JsonProperty("weed_pollen")]
        public string WeedPollen { get; set; }
    }

    public class FireCurrentResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public FireCurrentResponseDataTypeItem[] Data { get; set; }
    }

    public class FireCurrentResponseDataTypeItem
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        [JsonProperty("frp")]
        public double Frp { get; set; }

        [JsonProperty("daynight")]
        public string Daynight { get; set; }

        [JsonProperty("detection_time")]
        public string DetectionTime { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }
    }

    public class SoilCurrentResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public SoilCurrentResponseDataTypeItem[] Data { get; set; }
    }

    public class SoilCurrentResponseDataTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("scantime")]
        public string Scantime { get; set; }

        [JsonProperty("soil_temperature")]
        public int SoilTemperature { get; set; }

        [JsonProperty("soil_moisture")]
        public int SoilMoisture { get; set; }
    }

    public class SoilHistoryResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public SoilHistoryResponseDataTypeItem[] Data { get; set; }
    }

    public class SoilHistoryResponseDataTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("scantime")]
        public string Scantime { get; set; }

        [JsonProperty("soil_temperature")]
        public int SoilTemperature { get; set; }

        [JsonProperty("soil_moisture")]
        public int SoilMoisture { get; set; }
    }

    public class WaterVaporCurrentResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public WaterVaporCurrentResponseDataTypeItem[] Data { get; set; }
    }

    public class WaterVaporCurrentResponseDataTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("water_vapor")]
        public double WaterVapor { get; set; }
    }

    public class WaterVaporGeoResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public WaterVaporGeoResponseDataTypeItem[] Data { get; set; }
    }

    public class WaterVaporGeoResponseDataTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("water_vapor")]
        public double WaterVapor { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ambeeip;

    public partial class WorkflowManagedActions
    {
        public AmbeeipActions Ambeeip(string connectionId) => new AmbeeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AmbeeipTriggers Ambeeip(string connectionId) => new AmbeeipTriggers(connectionId);
    }
}
