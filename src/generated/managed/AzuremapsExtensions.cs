//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuremaps
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuremapsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremaps")]
        public IBodyWorkflowAction<GetRouteResponse> GetRoute([WorkflowExpression] Func<string> wp0, [WorkflowExpression] Func<string> wp1, [WorkflowExpression] Func<travelModeInput> travelMode = null, [WorkflowExpression] Func<bool> avoidHighways = null, [WorkflowExpression] Func<bool> avoidTolls = null, [WorkflowExpression] Func<bool> avoidFerry = null, [WorkflowExpression] Func<bool> avoidBorderCrossing = null, [WorkflowExpression] Func<optimizeInput> optimize = null)
        {
            SourceExpression.Validate(wp0, nameof(wp0), required: true);
            SourceExpression.Validate(wp1, nameof(wp1), required: true);
            SourceExpression.Validate(travelMode, nameof(travelMode), required: false);
            SourceExpression.Validate(avoidHighways, nameof(avoidHighways), required: false);
            SourceExpression.Validate(avoidTolls, nameof(avoidTolls), required: false);
            SourceExpression.Validate(avoidFerry, nameof(avoidFerry), required: false);
            SourceExpression.Validate(avoidBorderCrossing, nameof(avoidBorderCrossing), required: false);
            SourceExpression.Validate(optimize, nameof(optimize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/route/directions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["wp.0"] = SourceExpressionConverter.ConvertO(wp0);
                callPayload.Queries["wp.1"] = SourceExpressionConverter.ConvertO(wp1);
                if (travelMode != null)
                    callPayload.Queries["travelMode"] = SourceExpressionConverter.Convert(travelMode);
                callPayload.Queries["avoid_highways"] = Convert.ToString(false);
                if (avoidHighways != null)
                    callPayload.Queries["avoid_highways"] = SourceExpressionConverter.ConvertO(avoidHighways);
                callPayload.Queries["avoid_tolls"] = Convert.ToString(false);
                if (avoidTolls != null)
                    callPayload.Queries["avoid_tolls"] = SourceExpressionConverter.ConvertO(avoidTolls);
                callPayload.Queries["avoid_ferry"] = Convert.ToString(false);
                if (avoidFerry != null)
                    callPayload.Queries["avoid_ferry"] = SourceExpressionConverter.ConvertO(avoidFerry);
                callPayload.Queries["avoid_borderCrossing"] = Convert.ToString(false);
                if (avoidBorderCrossing != null)
                    callPayload.Queries["avoid_borderCrossing"] = SourceExpressionConverter.ConvertO(avoidBorderCrossing);
                if (optimize != null)
                    callPayload.Queries["optimize"] = SourceExpressionConverter.Convert(optimize);
                return callPayload;
            }

            return new ApiConnectionAction<GetRouteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremaps")]
        public IBodyWorkflowAction<GetLocationByAddressResponse> GetLocationByAddress([WorkflowExpression] Func<string> addressLine = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<string> adminDistrict = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> countryRegion = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(addressLine, nameof(addressLine), required: false);
            SourceExpression.Validate(locality, nameof(locality), required: false);
            SourceExpression.Validate(adminDistrict, nameof(adminDistrict), required: false);
            SourceExpression.Validate(postalCode, nameof(postalCode), required: false);
            SourceExpression.Validate(countryRegion, nameof(countryRegion), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/geocode";
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
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<GetLocationByAddressResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremaps")]
        public IBodyWorkflowAction<GetLocationByAddressResponse> GetLocationByPoint([WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude)
        {
            SourceExpression.Validate(latitude, nameof(latitude), required: true);
            SourceExpression.Validate(longitude, nameof(longitude), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reverseGeocode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                return callPayload;
            }

            return new ApiConnectionAction<GetLocationByAddressResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremaps")]
        public IBodyWorkflowAction<string> GetMap([WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude, [WorkflowExpression] Func<imagerySetInput> imagerySet, [WorkflowExpression] Func<string> zoomLevel, [WorkflowExpression] Func<int> width = null, [WorkflowExpression] Func<int> height = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<double> pushpinLatitude = null, [WorkflowExpression] Func<double> pushpinLongitude = null, [WorkflowExpression] Func<string> pushpinLabel = null)
        {
            SourceExpression.Validate(latitude, nameof(latitude), required: true);
            SourceExpression.Validate(longitude, nameof(longitude), required: true);
            SourceExpression.Validate(imagerySet, nameof(imagerySet), required: true);
            SourceExpression.Validate(zoomLevel, nameof(zoomLevel), required: true);
            SourceExpression.Validate(width, nameof(width), required: false);
            SourceExpression.Validate(height, nameof(height), required: false);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(pushpinLatitude, nameof(pushpinLatitude), required: false);
            SourceExpression.Validate(pushpinLongitude, nameof(pushpinLongitude), required: false);
            SourceExpression.Validate(pushpinLabel, nameof(pushpinLabel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/map/static";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                callPayload.Queries["imagerySet"] = SourceExpressionConverter.Convert(imagerySet);
                callPayload.Queries["zoomLevel"] = SourceExpressionConverter.ConvertO(zoomLevel);
                callPayload.Queries["width"] = Convert.ToString(512);
                if (width != null)
                    callPayload.Queries["width"] = SourceExpressionConverter.ConvertO(width);
                callPayload.Queries["height"] = Convert.ToString(512);
                if (height != null)
                    callPayload.Queries["height"] = SourceExpressionConverter.ConvertO(height);
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (pushpinLatitude != null)
                    callPayload.Queries["pushpinLatitude"] = SourceExpressionConverter.ConvertO(pushpinLatitude);
                if (pushpinLongitude != null)
                    callPayload.Queries["pushpinLongitude"] = SourceExpressionConverter.ConvertO(pushpinLongitude);
                if (pushpinLabel != null)
                    callPayload.Queries["pushpinLabel"] = SourceExpressionConverter.ConvertO(pushpinLabel);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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

    public enum travelModeInput
    {
        [EnumMember(Value = "driving")]
        Driving,
        [EnumMember(Value = "walking")]
        Walking
    }

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