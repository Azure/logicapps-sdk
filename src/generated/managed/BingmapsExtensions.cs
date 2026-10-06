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
        public IBodyWorkflowAction<GetLocationResponse> GetLocationByPoint([WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude, [WorkflowExpression] Func<string> includeEntityTypes = null, [WorkflowExpression] Func<bool> includeNeighborhood = null, [WorkflowExpression] Func<bool> include = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/REST/v1/Locations/pointPlaceHolder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (includeEntityTypes != null)
                    callPayload.Queries["includeEntityTypes"] = SourceExpressionConverter.ConvertO(includeEntityTypes);
                callPayload.Queries["includeNeighborhood"] = Convert.ToString(true);
                if (includeNeighborhood != null)
                    callPayload.Queries["includeNeighborhood"] = SourceExpressionConverter.ConvertO(includeNeighborhood);
                callPayload.Queries["include"] = Convert.ToString(true);
                if (include != null)
                    callPayload.Queries["include"] = SourceExpressionConverter.ConvertO(include);
                return callPayload;
            }

            return new ApiConnectionAction<GetLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingmaps")]
        public IBodyWorkflowAction<GetLocationResponse> GetLocationByAddress([WorkflowExpression] Func<string> addressLine = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<string> adminDistrict = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> countryRegion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/REST/v1/Locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (addressLine != null)
                    callPayload.Queries["addressLine"] = SourceExpressionConverter.ConvertO(addressLine);
                if (locality != null)
                    callPayload.Queries["locality"] = SourceExpressionConverter.ConvertO(locality);
                if (adminDistrict != null)
                    callPayload.Queries["adminDistrict"] = SourceExpressionConverter.ConvertO(adminDistrict);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = SourceExpressionConverter.ConvertO(postalCode);
                if (countryRegion != null)
                    callPayload.Queries["countryRegion"] = SourceExpressionConverter.ConvertO(countryRegion);
                return callPayload;
            }

            return new ApiConnectionAction<GetLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingmaps")]
        public IBodyWorkflowAction<string> GetMap([WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude, [WorkflowExpression] Func<imagerySetInput> imagerySet, [WorkflowExpression] Func<string> zoomLevel, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> mapSize = null, [WorkflowExpression] Func<double> pushpinLatitude = null, [WorkflowExpression] Func<double> pushpinLongitude = null, [WorkflowExpression] Func<int> pushpinIconStyle = null, [WorkflowExpression] Func<string> pushpinLabel = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/V2/REST/v1/Imagery/Map/{0}/pointPlaceHolder/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(imagerySet, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(zoomLevel, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (mapSize != null)
                    callPayload.Queries["mapSize"] = SourceExpressionConverter.ConvertO(mapSize);
                if (pushpinLatitude != null)
                    callPayload.Queries["pushpinLatitude"] = SourceExpressionConverter.ConvertO(pushpinLatitude);
                if (pushpinLongitude != null)
                    callPayload.Queries["pushpinLongitude"] = SourceExpressionConverter.ConvertO(pushpinLongitude);
                if (pushpinIconStyle != null)
                    callPayload.Queries["pushpinIconStyle"] = SourceExpressionConverter.ConvertO(pushpinIconStyle);
                if (pushpinLabel != null)
                    callPayload.Queries["pushpinLabel"] = SourceExpressionConverter.ConvertO(pushpinLabel);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingmaps")]
        public IBodyWorkflowAction<GetRouteResponse> GetRoute([WorkflowExpression] Func<string> wp0, [WorkflowExpression] Func<string> wp1, [WorkflowExpression] Func<travelModeInput> travelMode, [WorkflowExpression] Func<bool> avoidHighways = null, [WorkflowExpression] Func<bool> avoidTolls = null, [WorkflowExpression] Func<bool> avoidFerry = null, [WorkflowExpression] Func<bool> avoidMinimizeHighways = null, [WorkflowExpression] Func<bool> avoidMinimizeTolls = null, [WorkflowExpression] Func<bool> avoidBorderCrossing = null, [WorkflowExpression] Func<optimizeInput> optimize = null, [WorkflowExpression] Func<distanceUnitInput> distanceUnit = null, [WorkflowExpression] Func<string> dateTime = null, [WorkflowExpression] Func<timeTypeInput> timeType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/V3/REST/V1/Routes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(travelMode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["wp.0"] = SourceExpressionConverter.ConvertO(wp0);
                callPayload.Queries["wp.1"] = SourceExpressionConverter.ConvertO(wp1);
                callPayload.Queries["avoid_highways"] = Convert.ToString(false);
                if (avoidHighways != null)
                    callPayload.Queries["avoid_highways"] = SourceExpressionConverter.ConvertO(avoidHighways);
                callPayload.Queries["avoid_tolls"] = Convert.ToString(false);
                if (avoidTolls != null)
                    callPayload.Queries["avoid_tolls"] = SourceExpressionConverter.ConvertO(avoidTolls);
                callPayload.Queries["avoid_ferry"] = Convert.ToString(false);
                if (avoidFerry != null)
                    callPayload.Queries["avoid_ferry"] = SourceExpressionConverter.ConvertO(avoidFerry);
                callPayload.Queries["avoid_minimizeHighways"] = Convert.ToString(false);
                if (avoidMinimizeHighways != null)
                    callPayload.Queries["avoid_minimizeHighways"] = SourceExpressionConverter.ConvertO(avoidMinimizeHighways);
                callPayload.Queries["avoid_minimizeTolls"] = Convert.ToString(false);
                if (avoidMinimizeTolls != null)
                    callPayload.Queries["avoid_minimizeTolls"] = SourceExpressionConverter.ConvertO(avoidMinimizeTolls);
                callPayload.Queries["avoid_borderCrossing"] = Convert.ToString(false);
                if (avoidBorderCrossing != null)
                    callPayload.Queries["avoid_borderCrossing"] = SourceExpressionConverter.ConvertO(avoidBorderCrossing);
                if (optimize != null)
                    callPayload.Queries["optimize"] = SourceExpressionConverter.Convert(optimize);
                if (distanceUnit != null)
                    callPayload.Queries["distanceUnit"] = SourceExpressionConverter.Convert(distanceUnit);
                if (dateTime != null)
                    callPayload.Queries["dateTime"] = SourceExpressionConverter.ConvertO(dateTime);
                if (timeType != null)
                    callPayload.Queries["timeType"] = SourceExpressionConverter.Convert(timeType);
                return callPayload;
            }

            return new ApiConnectionAction<GetRouteResponse>(BuildSourceInput);
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