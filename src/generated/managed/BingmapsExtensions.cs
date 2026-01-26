//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bingmaps
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BingmapsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingmaps")]
        public IBodyWorkflowAction<GetRouteResponse> GetRouteV3(Expression<Func<string>> wp0, Expression<Func<string>> wp1, Expression<Func<travelModeInput>> travelMode, Expression<Func<bool>> avoidHighways = null, Expression<Func<bool>> avoidTolls = null, Expression<Func<bool>> avoidFerry = null, Expression<Func<bool>> avoidMinimizeHighways = null, Expression<Func<bool>> avoidMinimizeTolls = null, Expression<Func<bool>> avoidBorderCrossing = null, Expression<Func<optimizeInput>> optimize = null, Expression<Func<distanceUnitInput>> distanceUnit = null, Expression<Func<string>> dateTime = null, Expression<Func<timeTypeInput>> timeType = null)
        {
            var apiCallPath = String.Format("/V3/REST/V1/Routes/{0}", ExpressionConverter.ConvertWithUrlEncoding(travelMode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["wp.0"] = ExpressionConverter.Convert(wp0);
            callPayload.Queries["wp.1"] = ExpressionConverter.Convert(wp1);
            callPayload.Queries["avoid_highways"] = Convert.ToString(false);
            if (avoidHighways != null)
                callPayload.Queries["avoid_highways"] = ExpressionConverter.Convert(avoidHighways);
            callPayload.Queries["avoid_tolls"] = Convert.ToString(false);
            if (avoidTolls != null)
                callPayload.Queries["avoid_tolls"] = ExpressionConverter.Convert(avoidTolls);
            callPayload.Queries["avoid_ferry"] = Convert.ToString(false);
            if (avoidFerry != null)
                callPayload.Queries["avoid_ferry"] = ExpressionConverter.Convert(avoidFerry);
            callPayload.Queries["avoid_minimizeHighways"] = Convert.ToString(false);
            if (avoidMinimizeHighways != null)
                callPayload.Queries["avoid_minimizeHighways"] = ExpressionConverter.Convert(avoidMinimizeHighways);
            callPayload.Queries["avoid_minimizeTolls"] = Convert.ToString(false);
            if (avoidMinimizeTolls != null)
                callPayload.Queries["avoid_minimizeTolls"] = ExpressionConverter.Convert(avoidMinimizeTolls);
            callPayload.Queries["avoid_borderCrossing"] = Convert.ToString(false);
            if (avoidBorderCrossing != null)
                callPayload.Queries["avoid_borderCrossing"] = ExpressionConverter.Convert(avoidBorderCrossing);
            if (optimize != null)
                callPayload.Queries["optimize"] = ExpressionConverter.Convert(optimize);
            if (distanceUnit != null)
                callPayload.Queries["distanceUnit"] = ExpressionConverter.Convert(distanceUnit);
            if (dateTime != null)
                callPayload.Queries["dateTime"] = ExpressionConverter.Convert(dateTime);
            if (timeType != null)
                callPayload.Queries["timeType"] = ExpressionConverter.Convert(timeType);
            return new ApiConnectionAction<GetRouteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingmaps")]
        public IBodyWorkflowAction<GetLocationResponse> GetLocationByPoint(Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<string>> includeEntityTypes = null, Expression<Func<bool>> includeNeighborhood = null, Expression<Func<bool>> include = null)
        {
            var apiCallPath = "/REST/v1/Locations/pointPlaceHolder";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
            callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
            if (includeEntityTypes != null)
                callPayload.Queries["includeEntityTypes"] = ExpressionConverter.Convert(includeEntityTypes);
            callPayload.Queries["includeNeighborhood"] = Convert.ToString(true);
            if (includeNeighborhood != null)
                callPayload.Queries["includeNeighborhood"] = ExpressionConverter.Convert(includeNeighborhood);
            callPayload.Queries["include"] = Convert.ToString(true);
            if (include != null)
                callPayload.Queries["include"] = ExpressionConverter.Convert(include);
            return new ApiConnectionAction<GetLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingmaps")]
        public IBodyWorkflowAction<GetLocationResponse> GetLocationByAddress(Expression<Func<string>> addressLine = null, Expression<Func<string>> locality = null, Expression<Func<string>> adminDistrict = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> countryRegion = null)
        {
            var apiCallPath = "/REST/v1/Locations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (addressLine != null)
                callPayload.Queries["addressLine"] = ExpressionConverter.Convert(addressLine);
            if (locality != null)
                callPayload.Queries["locality"] = ExpressionConverter.Convert(locality);
            if (adminDistrict != null)
                callPayload.Queries["adminDistrict"] = ExpressionConverter.Convert(adminDistrict);
            if (postalCode != null)
                callPayload.Queries["postalCode"] = ExpressionConverter.Convert(postalCode);
            if (countryRegion != null)
                callPayload.Queries["countryRegion"] = ExpressionConverter.Convert(countryRegion);
            return new ApiConnectionAction<GetLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingmaps")]
        public IBodyWorkflowAction<string> GetMapV2(Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<imagerySetInput>> imagerySet, Expression<Func<string>> zoomLevel, Expression<Func<formatInput>> format = null, Expression<Func<string>> mapSize = null, Expression<Func<double>> pushpinLatitude = null, Expression<Func<double>> pushpinLongitude = null, Expression<Func<int>> pushpinIconStyle = null, Expression<Func<string>> pushpinLabel = null)
        {
            var apiCallPath = String.Format("/V2/REST/v1/Imagery/Map/{0}/pointPlaceHolder/{1}", ExpressionConverter.ConvertWithUrlEncoding(imagerySet, 1), ExpressionConverter.ConvertWithUrlEncoding(zoomLevel, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
            callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
            if (format != null)
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            if (mapSize != null)
                callPayload.Queries["mapSize"] = ExpressionConverter.Convert(mapSize);
            if (pushpinLatitude != null)
                callPayload.Queries["pushpinLatitude"] = ExpressionConverter.Convert(pushpinLatitude);
            if (pushpinLongitude != null)
                callPayload.Queries["pushpinLongitude"] = ExpressionConverter.Convert(pushpinLongitude);
            if (pushpinIconStyle != null)
                callPayload.Queries["pushpinIconStyle"] = ExpressionConverter.Convert(pushpinIconStyle);
            if (pushpinLabel != null)
                callPayload.Queries["pushpinLabel"] = ExpressionConverter.Convert(pushpinLabel);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class BingmapsTriggers([ConnectionName] string connectionId)
    {
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

    public enum travelModeInput
    {
        Driving,
        Walking,
        Transit
    }

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

    public enum distanceUnitInput
    {
        Mile,
        Kilometer
    }

    public enum timeTypeInput
    {
        Arrival,
        Departure,
        LastAvailable
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

    public enum imagerySetInput
    {
        Aerial,
        AerialWithLabels,
        CanvasDark,
        CanvasLight,
        CanvasGray,
        Road
    }

    public enum formatInput
    {
        [EnumMember(Value = "gif")]
        Gif,
        [EnumMember(Value = "jpeg")]
        Jpeg,
        [EnumMember(Value = "png")]
        Png
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