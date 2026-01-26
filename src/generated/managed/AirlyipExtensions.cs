//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airlyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirlyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetInstallationByIDResponseItem[]> GetInstallationByID(Expression<Func<int>> installationID)
        {
            var apiCallPath = String.Format("/installations/{0}", ExpressionConverter.ConvertWithUrlEncoding(installationID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
            return new ApiConnectionAction<GetInstallationByIDResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetNearestInstallationsResponseItem[]> GetNearestInstallations(Expression<Func<double>> lat, Expression<Func<double>> lng, Expression<Func<double>> maxDistanceKM = null, Expression<Func<int>> maxResults = null)
        {
            var apiCallPath = "/installations/nearest";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
            callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
            if (maxDistanceKM != null)
                callPayload.Queries["maxDistanceKM"] = ExpressionConverter.Convert(maxDistanceKM);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
            return new ApiConnectionAction<GetNearestInstallationsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetMeasurementsForInstallationResponse> GetMeasurementsForInstallation(Expression<Func<int>> installationId, Expression<Func<acceptLanguageInput>> acceptLanguage = null, Expression<Func<indexTypeInput>> indexType = null)
        {
            var apiCallPath = "/measurements/installation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["installationId"] = ExpressionConverter.Convert(installationId);
            callPayload.Queries["indexType"] = Convert.ToString("AIRLY_CAQI");
            if (indexType != null)
                callPayload.Queries["indexType"] = ExpressionConverter.Convert(indexType);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Accept-Language"] = Convert.ToString("en");
            if (acceptLanguage != null)
                callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(acceptLanguage);
            callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
            return new ApiConnectionAction<GetMeasurementsForInstallationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetNearestMeasurementsResponse> GetNearestMeasurements(Expression<Func<double>> lat, Expression<Func<double>> lng, Expression<Func<double>> maxDistanceKM = null, Expression<Func<indexTypeInput>> indexType = null, Expression<Func<acceptLanguageInput>> acceptLanguage = null)
        {
            var apiCallPath = "/measurements/nearest";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
            callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
            callPayload.Queries["maxDistanceKM"] = Convert.ToString(3);
            if (maxDistanceKM != null)
                callPayload.Queries["maxDistanceKM"] = ExpressionConverter.Convert(maxDistanceKM);
            callPayload.Queries["indexType"] = Convert.ToString("AIRLY_CAQI");
            if (indexType != null)
                callPayload.Queries["indexType"] = ExpressionConverter.Convert(indexType);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Accept-Language"] = Convert.ToString("en");
            if (acceptLanguage != null)
                callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(acceptLanguage);
            callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
            return new ApiConnectionAction<GetNearestMeasurementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetMeasurementsForPointResponse> GetMeasurementsForPoint(Expression<Func<double>> lat, Expression<Func<double>> lng, Expression<Func<indexTypeInput>> indexType = null, Expression<Func<acceptLanguageInput>> acceptLanguage = null)
        {
            var apiCallPath = "/measurements/point";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
            callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
            callPayload.Queries["indexType"] = Convert.ToString("AIRLY_CAQI");
            if (indexType != null)
                callPayload.Queries["indexType"] = ExpressionConverter.Convert(indexType);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Accept-Language"] = Convert.ToString("en");
            if (acceptLanguage != null)
                callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(acceptLanguage);
            callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
            return new ApiConnectionAction<GetMeasurementsForPointResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetAvailableIndexesResponseItem[]> GetAvailableIndexes()
        {
            var apiCallPath = "/meta/indexes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
            return new ApiConnectionAction<GetAvailableIndexesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetAvailableMeasurementsResponseItem[]> GetAvailableMeasurements(Expression<Func<acceptLanguageInput>> acceptLanguage = null)
        {
            var apiCallPath = "/meta/measurements";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Accept-Language"] = Convert.ToString("en");
            if (acceptLanguage != null)
                callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(acceptLanguage);
            callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
            return new ApiConnectionAction<GetAvailableMeasurementsResponseItem[]>(callPayload);
        }
    }

    public class AirlyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetInstallationByIDResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("location")]
        public GetInstallationByIDResponseItemLocationType Location { get; set; }

        [JsonProperty("locationId")]
        public int LocationId { get; set; }

        [JsonProperty("address")]
        public GetInstallationByIDResponseItemAddressType Address { get; set; }

        [JsonProperty("elevation")]
        public double Elevation { get; set; }

        [JsonProperty("airly")]
        public bool Airly { get; set; }

        [JsonProperty("sponsor")]
        public GetInstallationByIDResponseItemSponsorType Sponsor { get; set; }
    }

    public class GetInstallationByIDResponseItemLocationType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class GetInstallationByIDResponseItemAddressType
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("displayAddress1")]
        public string DisplayAddress1 { get; set; }

        [JsonProperty("displayAddress2")]
        public string DisplayAddress2 { get; set; }
    }

    public class GetInstallationByIDResponseItemSponsorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetNearestInstallationsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("location")]
        public GetNearestInstallationsResponseItemLocationType Location { get; set; }

        [JsonProperty("locationId")]
        public int LocationId { get; set; }

        [JsonProperty("address")]
        public GetNearestInstallationsResponseItemAddressType Address { get; set; }

        [JsonProperty("elevation")]
        public double Elevation { get; set; }

        [JsonProperty("airly")]
        public bool Airly { get; set; }

        [JsonProperty("sponsor")]
        public GetNearestInstallationsResponseItemSponsorType Sponsor { get; set; }
    }

    public class GetNearestInstallationsResponseItemLocationType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class GetNearestInstallationsResponseItemAddressType
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("displayAddress1")]
        public string DisplayAddress1 { get; set; }

        [JsonProperty("displayAddress2")]
        public string DisplayAddress2 { get; set; }
    }

    public class GetNearestInstallationsResponseItemSponsorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetMeasurementsForInstallationResponse
    {
        [JsonProperty("current")]
        public GetMeasurementsForInstallationResponseCurrentType Current { get; set; }

        [JsonProperty("history")]
        public GetMeasurementsForInstallationResponseHistoryTypeItem[] History { get; set; }

        [JsonProperty("forecast")]
        public GetMeasurementsForInstallationResponseForecastTypeItem[] Forecast { get; set; }
    }

    public class GetMeasurementsForInstallationResponseCurrentType
    {
        [JsonProperty("fromDateTime")]
        public string FromDateTime { get; set; }

        [JsonProperty("tillDateTime")]
        public string TillDateTime { get; set; }

        [JsonProperty("values")]
        public GetMeasurementsForInstallationResponseCurrentTypeValuesTypeItem[] Values { get; set; }

        [JsonProperty("indexes")]
        public GetMeasurementsForInstallationResponseCurrentTypeIndexesTypeItem[] Indexes { get; set; }

        [JsonProperty("standards")]
        public GetMeasurementsForInstallationResponseCurrentTypeStandardsTypeItem[] Standards { get; set; }
    }

    public class GetMeasurementsForInstallationResponseCurrentTypeValuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetMeasurementsForInstallationResponseCurrentTypeIndexesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("advice")]
        public string Advice { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class GetMeasurementsForInstallationResponseCurrentTypeStandardsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetMeasurementsForInstallationResponseHistoryTypeItem
    {
        [JsonProperty("fromDateTime")]
        public string FromDateTime { get; set; }

        [JsonProperty("tillDateTime")]
        public string TillDateTime { get; set; }

        [JsonProperty("values")]
        public GetMeasurementsForInstallationResponseHistoryTypeItemValuesTypeItem[] Values { get; set; }

        [JsonProperty("indexes")]
        public GetMeasurementsForInstallationResponseHistoryTypeItemIndexesTypeItem[] Indexes { get; set; }

        [JsonProperty("standards")]
        public GetMeasurementsForInstallationResponseHistoryTypeItemStandardsTypeItem[] Standards { get; set; }
    }

    public class GetMeasurementsForInstallationResponseHistoryTypeItemValuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetMeasurementsForInstallationResponseHistoryTypeItemIndexesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetMeasurementsForInstallationResponseHistoryTypeItemStandardsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetMeasurementsForInstallationResponseForecastTypeItem
    {
        [JsonProperty("fromDateTime")]
        public string FromDateTime { get; set; }

        [JsonProperty("tillDateTime")]
        public string TillDateTime { get; set; }

        [JsonProperty("values")]
        public GetMeasurementsForInstallationResponseForecastTypeItemValuesTypeItem[] Values { get; set; }

        [JsonProperty("indexes")]
        public GetMeasurementsForInstallationResponseForecastTypeItemIndexesTypeItem[] Indexes { get; set; }

        [JsonProperty("standards")]
        public GetMeasurementsForInstallationResponseForecastTypeItemStandardsTypeItem[] Standards { get; set; }
    }

    public class GetMeasurementsForInstallationResponseForecastTypeItemValuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetMeasurementsForInstallationResponseForecastTypeItemIndexesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetMeasurementsForInstallationResponseForecastTypeItemStandardsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public enum acceptLanguageInput
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "pl")]
        Pl
    }

    public enum indexTypeInput
    {
        [EnumMember(Value = "AIRLY_CAQI")]
        AIRLYCAQI,
        CAQI,
        PIJP
    }

    public class GetNearestMeasurementsResponse
    {
        [JsonProperty("current")]
        public GetNearestMeasurementsResponseCurrentType Current { get; set; }

        [JsonProperty("history")]
        public GetNearestMeasurementsResponseHistoryTypeItem[] History { get; set; }

        [JsonProperty("forecast")]
        public GetNearestMeasurementsResponseForecastTypeItem[] Forecast { get; set; }
    }

    public class GetNearestMeasurementsResponseCurrentType
    {
        [JsonProperty("fromDateTime")]
        public string FromDateTime { get; set; }

        [JsonProperty("tillDateTime")]
        public string TillDateTime { get; set; }

        [JsonProperty("values")]
        public GetNearestMeasurementsResponseCurrentTypeValuesTypeItem[] Values { get; set; }

        [JsonProperty("indexes")]
        public GetNearestMeasurementsResponseCurrentTypeIndexesTypeItem[] Indexes { get; set; }

        [JsonProperty("standards")]
        public GetNearestMeasurementsResponseCurrentTypeStandardsTypeItem[] Standards { get; set; }
    }

    public class GetNearestMeasurementsResponseCurrentTypeValuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetNearestMeasurementsResponseCurrentTypeIndexesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("advice")]
        public string Advice { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class GetNearestMeasurementsResponseCurrentTypeStandardsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetNearestMeasurementsResponseHistoryTypeItem
    {
        [JsonProperty("fromDateTime")]
        public string FromDateTime { get; set; }

        [JsonProperty("tillDateTime")]
        public string TillDateTime { get; set; }

        [JsonProperty("values")]
        public GetNearestMeasurementsResponseHistoryTypeItemValuesTypeItem[] Values { get; set; }

        [JsonProperty("indexes")]
        public GetNearestMeasurementsResponseHistoryTypeItemIndexesTypeItem[] Indexes { get; set; }

        [JsonProperty("standards")]
        public GetNearestMeasurementsResponseHistoryTypeItemStandardsTypeItem[] Standards { get; set; }
    }

    public class GetNearestMeasurementsResponseHistoryTypeItemValuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetNearestMeasurementsResponseHistoryTypeItemIndexesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetNearestMeasurementsResponseHistoryTypeItemStandardsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetNearestMeasurementsResponseForecastTypeItem
    {
        [JsonProperty("fromDateTime")]
        public string FromDateTime { get; set; }

        [JsonProperty("tillDateTime")]
        public string TillDateTime { get; set; }

        [JsonProperty("values")]
        public GetNearestMeasurementsResponseForecastTypeItemValuesTypeItem[] Values { get; set; }

        [JsonProperty("indexes")]
        public GetNearestMeasurementsResponseForecastTypeItemIndexesTypeItem[] Indexes { get; set; }

        [JsonProperty("standards")]
        public GetNearestMeasurementsResponseForecastTypeItemStandardsTypeItem[] Standards { get; set; }
    }

    public class GetNearestMeasurementsResponseForecastTypeItemValuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetNearestMeasurementsResponseForecastTypeItemIndexesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetNearestMeasurementsResponseForecastTypeItemStandardsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetMeasurementsForPointResponse
    {
        [JsonProperty("current")]
        public GetMeasurementsForPointResponseCurrentType Current { get; set; }

        [JsonProperty("history")]
        public GetMeasurementsForPointResponseHistoryTypeItem[] History { get; set; }

        [JsonProperty("forecast")]
        public GetMeasurementsForPointResponseForecastTypeItem[] Forecast { get; set; }
    }

    public class GetMeasurementsForPointResponseCurrentType
    {
        [JsonProperty("fromDateTime")]
        public string FromDateTime { get; set; }

        [JsonProperty("tillDateTime")]
        public string TillDateTime { get; set; }

        [JsonProperty("values")]
        public GetMeasurementsForPointResponseCurrentTypeValuesTypeItem[] Values { get; set; }

        [JsonProperty("indexes")]
        public GetMeasurementsForPointResponseCurrentTypeIndexesTypeItem[] Indexes { get; set; }

        [JsonProperty("standards")]
        public GetMeasurementsForPointResponseCurrentTypeStandardsTypeItem[] Standards { get; set; }
    }

    public class GetMeasurementsForPointResponseCurrentTypeValuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetMeasurementsForPointResponseCurrentTypeIndexesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("advice")]
        public string Advice { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class GetMeasurementsForPointResponseCurrentTypeStandardsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetMeasurementsForPointResponseHistoryTypeItem
    {
        [JsonProperty("fromDateTime")]
        public string FromDateTime { get; set; }

        [JsonProperty("tillDateTime")]
        public string TillDateTime { get; set; }

        [JsonProperty("values")]
        public GetMeasurementsForPointResponseHistoryTypeItemValuesTypeItem[] Values { get; set; }

        [JsonProperty("indexes")]
        public GetMeasurementsForPointResponseHistoryTypeItemIndexesTypeItem[] Indexes { get; set; }

        [JsonProperty("standards")]
        public GetMeasurementsForPointResponseHistoryTypeItemStandardsTypeItem[] Standards { get; set; }
    }

    public class GetMeasurementsForPointResponseHistoryTypeItemValuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetMeasurementsForPointResponseHistoryTypeItemIndexesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetMeasurementsForPointResponseHistoryTypeItemStandardsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetMeasurementsForPointResponseForecastTypeItem
    {
        [JsonProperty("fromDateTime")]
        public string FromDateTime { get; set; }

        [JsonProperty("tillDateTime")]
        public string TillDateTime { get; set; }

        [JsonProperty("values")]
        public GetMeasurementsForPointResponseForecastTypeItemValuesTypeItem[] Values { get; set; }

        [JsonProperty("indexes")]
        public GetMeasurementsForPointResponseForecastTypeItemIndexesTypeItem[] Indexes { get; set; }

        [JsonProperty("standards")]
        public GetMeasurementsForPointResponseForecastTypeItemStandardsTypeItem[] Standards { get; set; }
    }

    public class GetMeasurementsForPointResponseForecastTypeItemValuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetMeasurementsForPointResponseForecastTypeItemIndexesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetMeasurementsForPointResponseForecastTypeItemStandardsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("averaging")]
        public string Averaging { get; set; }
    }

    public class GetAvailableIndexesResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("levels")]
        public GetAvailableIndexesResponseItemLevelsTypeItem[] Levels { get; set; }
    }

    public class GetAvailableIndexesResponseItemLevelsTypeItem
    {
        [JsonProperty("minValue")]
        public double MinValue { get; set; }

        [JsonProperty("maxValue")]
        public double MaxValue { get; set; }

        [JsonProperty("values")]
        public string Values { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class GetAvailableMeasurementsResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Airlyip;

    public partial class WorkflowManagedActions
    {
        public AirlyipActions Airlyip(string connectionId) => new AirlyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AirlyipTriggers Airlyip(string connectionId) => new AirlyipTriggers(connectionId);
    }
}