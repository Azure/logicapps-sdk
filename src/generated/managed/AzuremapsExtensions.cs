//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuremaps
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuremapsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremaps")]
        public IBodyWorkflowAction<GetRouteResponse, ApiConnectionActionConfiguration> GetRoute(Expression<Func<string>> wp0, Expression<Func<string>> wp1, Expression<Func<travelModeInput>> travelMode = null, Expression<Func<bool>> avoidHighways = null, Expression<Func<bool>> avoidTolls = null, Expression<Func<bool>> avoidFerry = null, Expression<Func<bool>> avoidBorderCrossing = null, Expression<Func<optimizeInput>> optimize = null)
        {
            var __workflow_wp0 = WorkflowExpression.Compile(wp0, nameof(wp0), required: true);
            var __workflow_wp1 = WorkflowExpression.Compile(wp1, nameof(wp1), required: true);
            var __workflow_travelMode = WorkflowExpression.Compile(travelMode, nameof(travelMode), required: false);
            var __workflow_avoidHighways = WorkflowExpression.Compile(avoidHighways, nameof(avoidHighways), required: false);
            var __workflow_avoidTolls = WorkflowExpression.Compile(avoidTolls, nameof(avoidTolls), required: false);
            var __workflow_avoidFerry = WorkflowExpression.Compile(avoidFerry, nameof(avoidFerry), required: false);
            var __workflow_avoidBorderCrossing = WorkflowExpression.Compile(avoidBorderCrossing, nameof(avoidBorderCrossing), required: false);
            var __workflow_optimize = WorkflowExpression.Compile(optimize, nameof(optimize), required: false);
            return new DeferredBodyAction<GetRouteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/route/directions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["wp.0"] = ExpressionConverter.Convert(__workflow_wp0);
                callPayload.Queries["wp.1"] = ExpressionConverter.Convert(__workflow_wp1);
                if (__workflow_travelMode != null)
                    callPayload.Queries["travelMode"] = ExpressionConverter.Convert(__workflow_travelMode);
                callPayload.Queries["avoid_highways"] = Convert.ToString(false);
                if (__workflow_avoidHighways != null)
                    callPayload.Queries["avoid_highways"] = ExpressionConverter.Convert(__workflow_avoidHighways);
                callPayload.Queries["avoid_tolls"] = Convert.ToString(false);
                if (__workflow_avoidTolls != null)
                    callPayload.Queries["avoid_tolls"] = ExpressionConverter.Convert(__workflow_avoidTolls);
                callPayload.Queries["avoid_ferry"] = Convert.ToString(false);
                if (__workflow_avoidFerry != null)
                    callPayload.Queries["avoid_ferry"] = ExpressionConverter.Convert(__workflow_avoidFerry);
                callPayload.Queries["avoid_borderCrossing"] = Convert.ToString(false);
                if (__workflow_avoidBorderCrossing != null)
                    callPayload.Queries["avoid_borderCrossing"] = ExpressionConverter.Convert(__workflow_avoidBorderCrossing);
                if (__workflow_optimize != null)
                    callPayload.Queries["optimize"] = ExpressionConverter.Convert(__workflow_optimize);
                return new ApiConnectionAction<GetRouteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremaps")]
        public IBodyWorkflowAction<GetLocationByAddressResponse, ApiConnectionActionConfiguration> GetLocationByAddress(Expression<Func<string>> addressLine = null, Expression<Func<string>> locality = null, Expression<Func<string>> adminDistrict = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> countryRegion = null, Expression<Func<int>> top = null)
        {
            var __workflow_addressLine = WorkflowExpression.Compile(addressLine, nameof(addressLine), required: false);
            var __workflow_locality = WorkflowExpression.Compile(locality, nameof(locality), required: false);
            var __workflow_adminDistrict = WorkflowExpression.Compile(adminDistrict, nameof(adminDistrict), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_countryRegion = WorkflowExpression.Compile(countryRegion, nameof(countryRegion), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<GetLocationByAddressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/geocode";
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
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<GetLocationByAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremaps")]
        public IBodyWorkflowAction<GetLocationByAddressResponse, ApiConnectionActionConfiguration> GetLocationByPoint(Expression<Func<double>> latitude, Expression<Func<double>> longitude)
        {
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: true);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: true);
            return new DeferredBodyAction<GetLocationByAddressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reverseGeocode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                return new ApiConnectionAction<GetLocationByAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremaps")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetMap(Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<imagerySetInput>> imagerySet, Expression<Func<string>> zoomLevel, Expression<Func<int>> width = null, Expression<Func<int>> height = null, Expression<Func<formatInput>> format = null, Expression<Func<double>> pushpinLatitude = null, Expression<Func<double>> pushpinLongitude = null, Expression<Func<string>> pushpinLabel = null)
        {
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: true);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: true);
            var __workflow_imagerySet = WorkflowExpression.Compile(imagerySet, nameof(imagerySet), required: true);
            var __workflow_zoomLevel = WorkflowExpression.Compile(zoomLevel, nameof(zoomLevel), required: true);
            var __workflow_width = WorkflowExpression.Compile(width, nameof(width), required: false);
            var __workflow_height = WorkflowExpression.Compile(height, nameof(height), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_pushpinLatitude = WorkflowExpression.Compile(pushpinLatitude, nameof(pushpinLatitude), required: false);
            var __workflow_pushpinLongitude = WorkflowExpression.Compile(pushpinLongitude, nameof(pushpinLongitude), required: false);
            var __workflow_pushpinLabel = WorkflowExpression.Compile(pushpinLabel, nameof(pushpinLabel), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/map/static";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                callPayload.Queries["imagerySet"] = ExpressionConverter.Convert(__workflow_imagerySet);
                callPayload.Queries["zoomLevel"] = ExpressionConverter.Convert(__workflow_zoomLevel);
                callPayload.Queries["width"] = Convert.ToString(512);
                if (__workflow_width != null)
                    callPayload.Queries["width"] = ExpressionConverter.Convert(__workflow_width);
                callPayload.Queries["height"] = Convert.ToString(512);
                if (__workflow_height != null)
                    callPayload.Queries["height"] = ExpressionConverter.Convert(__workflow_height);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_pushpinLatitude != null)
                    callPayload.Queries["pushpinLatitude"] = ExpressionConverter.Convert(__workflow_pushpinLatitude);
                if (__workflow_pushpinLongitude != null)
                    callPayload.Queries["pushpinLongitude"] = ExpressionConverter.Convert(__workflow_pushpinLongitude);
                if (__workflow_pushpinLabel != null)
                    callPayload.Queries["pushpinLabel"] = ExpressionConverter.Convert(__workflow_pushpinLabel);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class AzuremapsTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetRouteResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("features")]
        public GetRouteResponseFeaturesTypeItem[] Features { get; set; }
    }

    public class GetRouteResponseFeaturesTypeItem
    {
        [JsonProperty("type")]
        public string FeatureType { get; set; }

        [JsonProperty("geometry")]
        public JToken Geometry { get; set; }

        [JsonProperty("properties")]
        public GetRouteResponseFeaturesTypeItemPropertiesType Properties { get; set; }
    }

    public class GetRouteResponseFeaturesTypeItemPropertiesType
    {
        [JsonProperty("type")]
        public string FeatureKind { get; set; }

        [JsonProperty("distanceInMeters")]
        public double DistanceMeters { get; set; }

        [JsonProperty("durationInSeconds")]
        public int DurationSeconds { get; set; }

        [JsonProperty("trafficDelayInSeconds")]
        public int TrafficDelaySeconds { get; set; }

        [JsonProperty("trafficCongestion")]
        public string TrafficCongestion { get; set; }

        [JsonProperty("trafficDataUsed")]
        public string TrafficDataUsed { get; set; }

        [JsonProperty("departureAt")]
        public string DepartureAt { get; set; }

        [JsonProperty("arrivalAt")]
        public string ArrivalAt { get; set; }

        [JsonProperty("instruction")]
        public GetRouteResponseFeaturesTypeItemPropertiesTypeInstructionType Instruction { get; set; }

        [JsonProperty("order")]
        public GetRouteResponseFeaturesTypeItemPropertiesTypeOrderType Order { get; set; }
    }

    public class GetRouteResponseFeaturesTypeItemPropertiesTypeInstructionType
    {
        [JsonProperty("text")]
        public string InstructionText { get; set; }

        [JsonProperty("maneuverType")]
        public string ManeuverType { get; set; }
    }

    public class GetRouteResponseFeaturesTypeItemPropertiesTypeOrderType
    {
        [JsonProperty("inputIndex")]
        public int WaypointIndex { get; set; }

        [JsonProperty("legIndex")]
        public int LegIndex { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum travelModeInput
    {
        [EnumMember(Value = "driving")]
        Driving,
        [EnumMember(Value = "walking")]
        Walking
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum optimizeInput
    {
        [EnumMember(Value = "fastestWithoutTraffic")]
        FastestWithoutTraffic,
        [EnumMember(Value = "fastestWithTraffic")]
        FastestWithTraffic,
        [EnumMember(Value = "shortest")]
        Shortest
    }

    public class GetLocationByAddressResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("features")]
        public GetLocationByAddressResponseFeaturesTypeItem[] Features { get; set; }
    }

    public class GetLocationByAddressResponseFeaturesTypeItem
    {
        [JsonProperty("type")]
        public string FeatureType { get; set; }

        [JsonProperty("geometry")]
        public GetLocationByAddressResponseFeaturesTypeItemGeometryType Geometry { get; set; }

        [JsonProperty("properties")]
        public GetLocationByAddressResponseFeaturesTypeItemPropertiesType Properties { get; set; }
    }

    public class GetLocationByAddressResponseFeaturesTypeItemGeometryType
    {
        [JsonProperty("type")]
        public string GeometryType { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }

    public class GetLocationByAddressResponseFeaturesTypeItemPropertiesType
    {
        [JsonProperty("type")]
        public string FeatureKind { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        [JsonProperty("matchCodes")]
        public string[] MatchCodes { get; set; }

        [JsonProperty("address")]
        public GetLocationByAddressResponseFeaturesTypeItemPropertiesTypeAddressType Address { get; set; }
    }

    public class GetLocationByAddressResponseFeaturesTypeItemPropertiesTypeAddressType
    {
        [JsonProperty("addressLine")]
        public string AddressLine { get; set; }

        [JsonProperty("locality")]
        public string LocalityCity { get; set; }

        [JsonProperty("adminDistricts")]
        public GetLocationByAddressResponseFeaturesTypeItemPropertiesTypeAddressTypeAdminDistrictsTypeItem[] AdminDistricts { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("countryRegion")]
        public string CountryRegion { get; set; }

        [JsonProperty("formattedAddress")]
        public string FormattedAddress { get; set; }
    }

    public class GetLocationByAddressResponseFeaturesTypeItemPropertiesTypeAddressTypeAdminDistrictsTypeItem
    {
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
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
        [EnumMember(Value = "jpeg")]
        Jpeg,
        [EnumMember(Value = "png")]
        Png
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuremaps;

    public partial class WorkflowManagedActions
    {
        public AzuremapsActions Azuremaps(string connectionId) => new AzuremapsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuremapsTriggers Azuremaps(string connectionId) => new AzuremapsTriggers(connectionId);
    }
}