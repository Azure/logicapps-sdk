//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airlyip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirlyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetInstallationByIdResponseItem[], ApiConnectionActionConfiguration> GetInstallationById(Expression<Func<int>> installationId)
        {
            var __workflow_installationId = WorkflowExpression.Compile(installationId, nameof(installationId), required: true);
            return new DeferredBodyAction<GetInstallationByIdResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/installations/{0}", __workflow_installationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
                return new ApiConnectionAction<GetInstallationByIdResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetNearestInstallationsResponseItem[], ApiConnectionActionConfiguration> GetNearestInstallations(Expression<Func<double>> lat, Expression<Func<double>> lng, Expression<Func<double>> maxDistanceKM = null, Expression<Func<int>> maxResults = null)
        {
            var __workflow_lat = WorkflowExpression.Compile(lat, nameof(lat), required: true);
            var __workflow_lng = WorkflowExpression.Compile(lng, nameof(lng), required: true);
            var __workflow_maxDistanceKM = WorkflowExpression.Compile(maxDistanceKM, nameof(maxDistanceKM), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<GetNearestInstallationsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/installations/nearest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(__workflow_lng);
                if (__workflow_maxDistanceKM != null)
                    callPayload.Queries["maxDistanceKM"] = ExpressionConverter.Convert(__workflow_maxDistanceKM);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
                return new ApiConnectionAction<GetNearestInstallationsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetMeasurementsForInstallationResponse, ApiConnectionActionConfiguration> GetMeasurementsForInstallation(Expression<Func<int>> installationId, Expression<Func<acceptLanguageInput>> acceptLanguage = null, Expression<Func<indexTypeInput>> indexType = null)
        {
            var __workflow_installationId = WorkflowExpression.Compile(installationId, nameof(installationId), required: true);
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: false);
            var __workflow_indexType = WorkflowExpression.Compile(indexType, nameof(indexType), required: false);
            return new DeferredBodyAction<GetMeasurementsForInstallationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/measurements/installation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["installationId"] = ExpressionConverter.Convert(__workflow_installationId);
                callPayload.Queries["indexType"] = Convert.ToString("AIRLY_CAQI");
                if (__workflow_indexType != null)
                    callPayload.Queries["indexType"] = ExpressionConverter.Convert(__workflow_indexType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Accept-Language"] = Convert.ToString("en");
                if (__workflow_acceptLanguage != null)
                    callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
                return new ApiConnectionAction<GetMeasurementsForInstallationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetNearestMeasurementsResponse, ApiConnectionActionConfiguration> GetNearestMeasurements(Expression<Func<double>> lat, Expression<Func<double>> lng, Expression<Func<double>> maxDistanceKM = null, Expression<Func<indexTypeInput>> indexType = null, Expression<Func<acceptLanguageInput>> acceptLanguage = null)
        {
            var __workflow_lat = WorkflowExpression.Compile(lat, nameof(lat), required: true);
            var __workflow_lng = WorkflowExpression.Compile(lng, nameof(lng), required: true);
            var __workflow_maxDistanceKM = WorkflowExpression.Compile(maxDistanceKM, nameof(maxDistanceKM), required: false);
            var __workflow_indexType = WorkflowExpression.Compile(indexType, nameof(indexType), required: false);
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: false);
            return new DeferredBodyAction<GetNearestMeasurementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/measurements/nearest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(__workflow_lng);
                callPayload.Queries["maxDistanceKM"] = Convert.ToString(3);
                if (__workflow_maxDistanceKM != null)
                    callPayload.Queries["maxDistanceKM"] = ExpressionConverter.Convert(__workflow_maxDistanceKM);
                callPayload.Queries["indexType"] = Convert.ToString("AIRLY_CAQI");
                if (__workflow_indexType != null)
                    callPayload.Queries["indexType"] = ExpressionConverter.Convert(__workflow_indexType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Accept-Language"] = Convert.ToString("en");
                if (__workflow_acceptLanguage != null)
                    callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
                return new ApiConnectionAction<GetNearestMeasurementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetMeasurementsForPointResponse, ApiConnectionActionConfiguration> GetMeasurementsForPoint(Expression<Func<double>> lat, Expression<Func<double>> lng, Expression<Func<indexTypeInput>> indexType = null, Expression<Func<acceptLanguageInput>> acceptLanguage = null)
        {
            var __workflow_lat = WorkflowExpression.Compile(lat, nameof(lat), required: true);
            var __workflow_lng = WorkflowExpression.Compile(lng, nameof(lng), required: true);
            var __workflow_indexType = WorkflowExpression.Compile(indexType, nameof(indexType), required: false);
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: false);
            return new DeferredBodyAction<GetMeasurementsForPointResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/measurements/point";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(__workflow_lng);
                callPayload.Queries["indexType"] = Convert.ToString("AIRLY_CAQI");
                if (__workflow_indexType != null)
                    callPayload.Queries["indexType"] = ExpressionConverter.Convert(__workflow_indexType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Accept-Language"] = Convert.ToString("en");
                if (__workflow_acceptLanguage != null)
                    callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
                return new ApiConnectionAction<GetMeasurementsForPointResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetAvailableIndexesResponseItem[], ApiConnectionActionConfiguration> GetAvailableIndexes()
        {
            return new DeferredBodyAction<GetAvailableIndexesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/meta/indexes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
                return new ApiConnectionAction<GetAvailableIndexesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlyip")]
        public IBodyWorkflowAction<GetAvailableMeasurementsResponseItem[], ApiConnectionActionConfiguration> GetAvailableMeasurements(Expression<Func<acceptLanguageInput>> acceptLanguage = null)
        {
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: false);
            return new DeferredBodyAction<GetAvailableMeasurementsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/meta/measurements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Accept-Language"] = Convert.ToString("en");
                if (__workflow_acceptLanguage != null)
                    callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip");
                return new ApiConnectionAction<GetAvailableMeasurementsResponseItem[]>(callPayload);
            });
        }
    }

    public class AirlyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetInstallationByIdResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("location")]
        public GetInstallationByIdResponseItemLocationType Location { get; set; }

        [JsonProperty("locationId")]
        public int LocationId { get; set; }

        [JsonProperty("address")]
        public GetInstallationByIdResponseItemAddressType Address { get; set; }

        [JsonProperty("elevation")]
        public double Elevation { get; set; }

        [JsonProperty("airly")]
        public bool Airly { get; set; }

        [JsonProperty("sponsor")]
        public GetInstallationByIdResponseItemSponsorType Sponsor { get; set; }
    }

    public class GetInstallationByIdResponseItemLocationType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class GetInstallationByIdResponseItemAddressType
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

    public class GetInstallationByIdResponseItemSponsorType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum acceptLanguageInput
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "pl")]
        Pl
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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