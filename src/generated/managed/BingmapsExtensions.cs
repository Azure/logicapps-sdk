//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bingmaps
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class BingmapsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingmaps")]
        public IBodyWorkflowAction<GetLocationResponse> GetLocationByPoint(Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<string>> includeEntityTypes = null, Expression<Func<bool>> includeNeighborhood = null, Expression<Func<bool>> include = null)
        {
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: true);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: true);
            var __workflow_includeEntityTypes = includeEntityTypes == null ? null : WorkflowExpression.Compile(includeEntityTypes);
            WorkflowExpression.Validate(__workflow_includeEntityTypes, nameof(includeEntityTypes), required: false);
            var __workflow_includeNeighborhood = includeNeighborhood == null ? null : WorkflowExpression.Compile(includeNeighborhood);
            WorkflowExpression.Validate(__workflow_includeNeighborhood, nameof(includeNeighborhood), required: false);
            var __workflow_include = include == null ? null : WorkflowExpression.Compile(include);
            WorkflowExpression.Validate(__workflow_include, nameof(include), required: false);
            return new DeferredBodyAction<GetLocationResponse>(() =>
            {
                var apiCallPath = "/REST/v1/Locations/pointPlaceHolder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_includeEntityTypes != null)
                    callPayload.Queries["includeEntityTypes"] = ExpressionConverter.Convert(__workflow_includeEntityTypes);
                callPayload.Queries["includeNeighborhood"] = Convert.ToString(true);
                if (__workflow_includeNeighborhood != null)
                    callPayload.Queries["includeNeighborhood"] = ExpressionConverter.Convert(__workflow_includeNeighborhood);
                callPayload.Queries["include"] = Convert.ToString(true);
                if (__workflow_include != null)
                    callPayload.Queries["include"] = ExpressionConverter.Convert(__workflow_include);
                return new ApiConnectionAction<GetLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingmaps")]
        public IBodyWorkflowAction<GetLocationResponse> GetLocationByAddress(Expression<Func<string>> addressLine = null, Expression<Func<string>> locality = null, Expression<Func<string>> adminDistrict = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> countryRegion = null)
        {
            var __workflow_addressLine = addressLine == null ? null : WorkflowExpression.Compile(addressLine);
            WorkflowExpression.Validate(__workflow_addressLine, nameof(addressLine), required: false);
            var __workflow_locality = locality == null ? null : WorkflowExpression.Compile(locality);
            WorkflowExpression.Validate(__workflow_locality, nameof(locality), required: false);
            var __workflow_adminDistrict = adminDistrict == null ? null : WorkflowExpression.Compile(adminDistrict);
            WorkflowExpression.Validate(__workflow_adminDistrict, nameof(adminDistrict), required: false);
            var __workflow_postalCode = postalCode == null ? null : WorkflowExpression.Compile(postalCode);
            WorkflowExpression.Validate(__workflow_postalCode, nameof(postalCode), required: false);
            var __workflow_countryRegion = countryRegion == null ? null : WorkflowExpression.Compile(countryRegion);
            WorkflowExpression.Validate(__workflow_countryRegion, nameof(countryRegion), required: false);
            return new DeferredBodyAction<GetLocationResponse>(() =>
            {
                var apiCallPath = "/REST/v1/Locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_addressLine != null)
                    callPayload.Queries["addressLine"] = ExpressionConverter.Convert(__workflow_addressLine);
                if (__workflow_locality != null)
                    callPayload.Queries["locality"] = ExpressionConverter.Convert(__workflow_locality);
                if (__workflow_adminDistrict != null)
                    callPayload.Queries["adminDistrict"] = ExpressionConverter.Convert(__workflow_adminDistrict);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_countryRegion != null)
                    callPayload.Queries["countryRegion"] = ExpressionConverter.Convert(__workflow_countryRegion);
                return new ApiConnectionAction<GetLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingmaps")]
        public IBodyWorkflowAction<string> GetMap(Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<imagerySetInput>> imagerySet, Expression<Func<string>> zoomLevel, Expression<Func<formatInput>> format = null, Expression<Func<string>> mapSize = null, Expression<Func<double>> pushpinLatitude = null, Expression<Func<double>> pushpinLongitude = null, Expression<Func<int>> pushpinIconStyle = null, Expression<Func<string>> pushpinLabel = null)
        {
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: true);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: true);
            var __workflow_imagerySet = imagerySet == null ? null : WorkflowExpression.Compile(imagerySet);
            WorkflowExpression.Validate(__workflow_imagerySet, nameof(imagerySet), required: true);
            var __workflow_zoomLevel = zoomLevel == null ? null : WorkflowExpression.Compile(zoomLevel);
            WorkflowExpression.Validate(__workflow_zoomLevel, nameof(zoomLevel), required: true);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: false);
            var __workflow_mapSize = mapSize == null ? null : WorkflowExpression.Compile(mapSize);
            WorkflowExpression.Validate(__workflow_mapSize, nameof(mapSize), required: false);
            var __workflow_pushpinLatitude = pushpinLatitude == null ? null : WorkflowExpression.Compile(pushpinLatitude);
            WorkflowExpression.Validate(__workflow_pushpinLatitude, nameof(pushpinLatitude), required: false);
            var __workflow_pushpinLongitude = pushpinLongitude == null ? null : WorkflowExpression.Compile(pushpinLongitude);
            WorkflowExpression.Validate(__workflow_pushpinLongitude, nameof(pushpinLongitude), required: false);
            var __workflow_pushpinIconStyle = pushpinIconStyle == null ? null : WorkflowExpression.Compile(pushpinIconStyle);
            WorkflowExpression.Validate(__workflow_pushpinIconStyle, nameof(pushpinIconStyle), required: false);
            var __workflow_pushpinLabel = pushpinLabel == null ? null : WorkflowExpression.Compile(pushpinLabel);
            WorkflowExpression.Validate(__workflow_pushpinLabel, nameof(pushpinLabel), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/V2/REST/v1/Imagery/Map/{0}/pointPlaceHolder/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_imagerySet, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_zoomLevel, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_mapSize != null)
                    callPayload.Queries["mapSize"] = ExpressionConverter.Convert(__workflow_mapSize);
                if (__workflow_pushpinLatitude != null)
                    callPayload.Queries["pushpinLatitude"] = ExpressionConverter.Convert(__workflow_pushpinLatitude);
                if (__workflow_pushpinLongitude != null)
                    callPayload.Queries["pushpinLongitude"] = ExpressionConverter.Convert(__workflow_pushpinLongitude);
                if (__workflow_pushpinIconStyle != null)
                    callPayload.Queries["pushpinIconStyle"] = ExpressionConverter.Convert(__workflow_pushpinIconStyle);
                if (__workflow_pushpinLabel != null)
                    callPayload.Queries["pushpinLabel"] = ExpressionConverter.Convert(__workflow_pushpinLabel);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingmaps")]
        public IBodyWorkflowAction<GetRouteResponse> GetRoute(Expression<Func<string>> wp0, Expression<Func<string>> wp1, Expression<Func<travelModeInput>> travelMode, Expression<Func<bool>> avoidHighways = null, Expression<Func<bool>> avoidTolls = null, Expression<Func<bool>> avoidFerry = null, Expression<Func<bool>> avoidMinimizeHighways = null, Expression<Func<bool>> avoidMinimizeTolls = null, Expression<Func<bool>> avoidBorderCrossing = null, Expression<Func<optimizeInput>> optimize = null, Expression<Func<distanceUnitInput>> distanceUnit = null, Expression<Func<string>> dateTime = null, Expression<Func<timeTypeInput>> timeType = null)
        {
            var __workflow_wp0 = wp0 == null ? null : WorkflowExpression.Compile(wp0);
            WorkflowExpression.Validate(__workflow_wp0, nameof(wp0), required: true);
            var __workflow_wp1 = wp1 == null ? null : WorkflowExpression.Compile(wp1);
            WorkflowExpression.Validate(__workflow_wp1, nameof(wp1), required: true);
            var __workflow_travelMode = travelMode == null ? null : WorkflowExpression.Compile(travelMode);
            WorkflowExpression.Validate(__workflow_travelMode, nameof(travelMode), required: true);
            var __workflow_avoidHighways = avoidHighways == null ? null : WorkflowExpression.Compile(avoidHighways);
            WorkflowExpression.Validate(__workflow_avoidHighways, nameof(avoidHighways), required: false);
            var __workflow_avoidTolls = avoidTolls == null ? null : WorkflowExpression.Compile(avoidTolls);
            WorkflowExpression.Validate(__workflow_avoidTolls, nameof(avoidTolls), required: false);
            var __workflow_avoidFerry = avoidFerry == null ? null : WorkflowExpression.Compile(avoidFerry);
            WorkflowExpression.Validate(__workflow_avoidFerry, nameof(avoidFerry), required: false);
            var __workflow_avoidMinimizeHighways = avoidMinimizeHighways == null ? null : WorkflowExpression.Compile(avoidMinimizeHighways);
            WorkflowExpression.Validate(__workflow_avoidMinimizeHighways, nameof(avoidMinimizeHighways), required: false);
            var __workflow_avoidMinimizeTolls = avoidMinimizeTolls == null ? null : WorkflowExpression.Compile(avoidMinimizeTolls);
            WorkflowExpression.Validate(__workflow_avoidMinimizeTolls, nameof(avoidMinimizeTolls), required: false);
            var __workflow_avoidBorderCrossing = avoidBorderCrossing == null ? null : WorkflowExpression.Compile(avoidBorderCrossing);
            WorkflowExpression.Validate(__workflow_avoidBorderCrossing, nameof(avoidBorderCrossing), required: false);
            var __workflow_optimize = optimize == null ? null : WorkflowExpression.Compile(optimize);
            WorkflowExpression.Validate(__workflow_optimize, nameof(optimize), required: false);
            var __workflow_distanceUnit = distanceUnit == null ? null : WorkflowExpression.Compile(distanceUnit);
            WorkflowExpression.Validate(__workflow_distanceUnit, nameof(distanceUnit), required: false);
            var __workflow_dateTime = dateTime == null ? null : WorkflowExpression.Compile(dateTime);
            WorkflowExpression.Validate(__workflow_dateTime, nameof(dateTime), required: false);
            var __workflow_timeType = timeType == null ? null : WorkflowExpression.Compile(timeType);
            WorkflowExpression.Validate(__workflow_timeType, nameof(timeType), required: false);
            return new DeferredBodyAction<GetRouteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/V3/REST/V1/Routes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_travelMode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["wp.0"] = ExpressionConverter.Convert(__workflow_wp0);
                callPayload.Queries["wp.1"] = ExpressionConverter.Convert(__workflow_wp1);
                callPayload.Queries["avoid_highways"] = Convert.ToString(false);
                if (__workflow_avoidHighways != null)
                    callPayload.Queries["avoid_highways"] = ExpressionConverter.Convert(__workflow_avoidHighways);
                callPayload.Queries["avoid_tolls"] = Convert.ToString(false);
                if (__workflow_avoidTolls != null)
                    callPayload.Queries["avoid_tolls"] = ExpressionConverter.Convert(__workflow_avoidTolls);
                callPayload.Queries["avoid_ferry"] = Convert.ToString(false);
                if (__workflow_avoidFerry != null)
                    callPayload.Queries["avoid_ferry"] = ExpressionConverter.Convert(__workflow_avoidFerry);
                callPayload.Queries["avoid_minimizeHighways"] = Convert.ToString(false);
                if (__workflow_avoidMinimizeHighways != null)
                    callPayload.Queries["avoid_minimizeHighways"] = ExpressionConverter.Convert(__workflow_avoidMinimizeHighways);
                callPayload.Queries["avoid_minimizeTolls"] = Convert.ToString(false);
                if (__workflow_avoidMinimizeTolls != null)
                    callPayload.Queries["avoid_minimizeTolls"] = ExpressionConverter.Convert(__workflow_avoidMinimizeTolls);
                callPayload.Queries["avoid_borderCrossing"] = Convert.ToString(false);
                if (__workflow_avoidBorderCrossing != null)
                    callPayload.Queries["avoid_borderCrossing"] = ExpressionConverter.Convert(__workflow_avoidBorderCrossing);
                if (__workflow_optimize != null)
                    callPayload.Queries["optimize"] = ExpressionConverter.Convert(__workflow_optimize);
                if (__workflow_distanceUnit != null)
                    callPayload.Queries["distanceUnit"] = ExpressionConverter.Convert(__workflow_distanceUnit);
                if (__workflow_dateTime != null)
                    callPayload.Queries["dateTime"] = ExpressionConverter.Convert(__workflow_dateTime);
                if (__workflow_timeType != null)
                    callPayload.Queries["timeType"] = ExpressionConverter.Convert(__workflow_timeType);
                return new ApiConnectionAction<GetRouteResponse>(callPayload);
            });
        }
    }

    public class BingmapsTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetLocationResponse
    {
        [JsonProperty("address")]
        public GetLocationResponseAddressType Address { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("point")]
        public GetLocationResponsePointType Point { get; set; }
    }

    public class GetLocationResponseAddressType
    {
        [JsonProperty("addressLine")]
        public string Line { get; set; }

        [JsonProperty("countryRegion")]
        public string CountryRegion { get; set; }

        [JsonProperty("countryRegionIso2")]
        public string CountryRegionISO2 { get; set; }

        [JsonProperty("formattedAddress")]
        public string FormattedAddress { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class GetLocationResponsePointType
    {
        [JsonProperty("coordinates")]
        public GetLocationResponsePointTypeCoordinatesType Coordinates { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetLocationResponsePointTypeCoordinatesType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("combined")]
        public string Combined { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum imagerySetInput
    {
        Aerial,
        AerialWithLabels,
        CanvasDark,
        CanvasLight,
        CanvasGray,
        Road
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "gif")]
        Gif,
        [EnumMember(Value = "jpeg")]
        Jpeg,
        [EnumMember(Value = "png")]
        Png
    }

    public class GetRouteResponse
    {
        [JsonProperty("distanceUnit")]
        public string DistanceUnit { get; set; }

        [JsonProperty("durationUnit")]
        public string DurationUnit { get; set; }

        [JsonProperty("routeLegs")]
        public GetRouteResponseRouteLegsType RouteLegs { get; set; }

        [JsonProperty("trafficCongestion")]
        public string TrafficCongestion { get; set; }

        [JsonProperty("trafficDataUsed")]
        public string TrafficDataUsed { get; set; }

        [JsonProperty("travelDistance")]
        public double TravelDistance { get; set; }

        [JsonProperty("travelDuration")]
        public int TravelDuration { get; set; }

        [JsonProperty("travelDurationTraffic")]
        public int TravelDurationTraffic { get; set; }
    }

    public class GetRouteResponseRouteLegsType
    {
        [JsonProperty("actualEnd")]
        public GetRouteResponseRouteLegsTypeActualEndType ActualEnd { get; set; }

        [JsonProperty("actualStart")]
        public GetRouteResponseRouteLegsTypeActualStartType ActualStart { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("endLocation")]
        public GetRouteResponseRouteLegsTypeEndLocationType EndLocation { get; set; }

        [JsonProperty("routeRegion")]
        public string Region { get; set; }

        [JsonProperty("startLocation")]
        public GetRouteResponseRouteLegsTypeStartLocationType StartLocation { get; set; }
    }

    public class GetRouteResponseRouteLegsTypeActualEndType
    {
        [JsonProperty("coordinates")]
        public GetRouteResponseRouteLegsTypeActualEndTypeCoordinatesType Coordinates { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetRouteResponseRouteLegsTypeActualEndTypeCoordinatesType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("combined")]
        public string Combined { get; set; }
    }

    public class GetRouteResponseRouteLegsTypeActualStartType
    {
        [JsonProperty("coordinates")]
        public GetRouteResponseRouteLegsTypeActualStartTypeCoordinatesType Coordinates { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetRouteResponseRouteLegsTypeActualStartTypeCoordinatesType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("combined")]
        public string Combined { get; set; }
    }

    public class GetRouteResponseRouteLegsTypeEndLocationType
    {
        [JsonProperty("address")]
        public GetRouteResponseRouteLegsTypeEndLocationTypeAddressType Address { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetRouteResponseRouteLegsTypeEndLocationTypeAddressType
    {
        [JsonProperty("countryRegion")]
        public string CountryRegion { get; set; }

        [JsonProperty("formattedAddress")]
        public string FormattedAddress { get; set; }
    }

    public class GetRouteResponseRouteLegsTypeStartLocationType
    {
        [JsonProperty("address")]
        public GetRouteResponseRouteLegsTypeStartLocationTypeAddressType Address { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetRouteResponseRouteLegsTypeStartLocationTypeAddressType
    {
        [JsonProperty("countryRegion")]
        public string CountryRegion { get; set; }

        [JsonProperty("formattedAddress")]
        public string FormattedAddress { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum travelModeInput
    {
        Driving,
        Walking,
        Transit
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum optimizeInput
    {
        [EnumMember(Value = "distance")]
        Distance,
        [EnumMember(Value = "time ")]
        Time,
        [EnumMember(Value = "timeWithTraffic")]
        TimeWithTraffic,
        [EnumMember(Value = "timeAvoidClosure")]
        TimeAvoidClosure
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum distanceUnitInput
    {
        Mile,
        Kilometer
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum timeTypeInput
    {
        Arrival,
        Departure,
        LastAvailable
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bingmaps;

    public partial class WorkflowManagedActions
    {
        public BingmapsActions Bingmaps(string connectionId) => new BingmapsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BingmapsTriggers Bingmaps(string connectionId) => new BingmapsTriggers(connectionId);
    }
}
