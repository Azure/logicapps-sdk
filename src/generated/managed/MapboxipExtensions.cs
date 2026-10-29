//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mapboxip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MapboxipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mapboxip")]
        public IBodyWorkflowAction<FwGeocodingResponse, ApiConnectionActionConfiguration> FwGeocoding(Expression<Func<string>> searchText, Expression<Func<string>> proximity = null, Expression<Func<string>> types = null, Expression<Func<int>> limit = null, Expression<Func<bool>> autocomplete = null, Expression<Func<string>> language = null)
        {
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: true);
            var __workflow_proximity = WorkflowExpression.Compile(proximity, nameof(proximity), required: false);
            var __workflow_types = WorkflowExpression.Compile(types, nameof(types), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_autocomplete = WorkflowExpression.Compile(autocomplete, nameof(autocomplete), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            return new DeferredBodyAction<FwGeocodingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/geocoding/v5/mapbox.places/{0}.json", __workflow_searchText.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["proximity"] = Convert.ToString("ip");
                if (__workflow_proximity != null)
                    callPayload.Queries["proximity"] = ExpressionConverter.Convert(__workflow_proximity);
                callPayload.Queries["types"] = Convert.ToString("place,postcode,address");
                if (__workflow_types != null)
                    callPayload.Queries["types"] = ExpressionConverter.Convert(__workflow_types);
                callPayload.Queries["limit"] = Convert.ToString(2);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["autocomplete"] = Convert.ToString(false);
                if (__workflow_autocomplete != null)
                    callPayload.Queries["autocomplete"] = ExpressionConverter.Convert(__workflow_autocomplete);
                callPayload.Queries["language"] = Convert.ToString("en");
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                return new ApiConnectionAction<FwGeocodingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mapboxip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetStaticMap(Expression<Func<string>> pinlon, Expression<Func<string>> pinlat, Expression<Func<double>> lon, Expression<Func<double>> lat, Expression<Func<double>> zoom, Expression<Func<double>> bearing, Expression<Func<double>> pitch, Expression<Func<int>> width, Expression<Func<int>> height)
        {
            var __workflow_pinlon = WorkflowExpression.Compile(pinlon, nameof(pinlon), required: true);
            var __workflow_pinlat = WorkflowExpression.Compile(pinlat, nameof(pinlat), required: true);
            var __workflow_lon = WorkflowExpression.Compile(lon, nameof(lon), required: true);
            var __workflow_lat = WorkflowExpression.Compile(lat, nameof(lat), required: true);
            var __workflow_zoom = WorkflowExpression.Compile(zoom, nameof(zoom), required: true);
            var __workflow_bearing = WorkflowExpression.Compile(bearing, nameof(bearing), required: true);
            var __workflow_pitch = WorkflowExpression.Compile(pitch, nameof(pitch), required: true);
            var __workflow_width = WorkflowExpression.Compile(width, nameof(width), required: true);
            var __workflow_height = WorkflowExpression.Compile(height, nameof(height), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/styles/v1/mapbox/streets-v11/static/pin-s+ff2211({0},{1})/{2},{3},{4},{5},{6}/{7}x{8}", __workflow_pinlon.WithUrlEncoding(1), __workflow_pinlat.WithUrlEncoding(1), __workflow_lon.WithUrlEncoding(1), __workflow_lat.WithUrlEncoding(1), __workflow_zoom.WithUrlEncoding(1), __workflow_bearing.WithUrlEncoding(1), __workflow_pitch.WithUrlEncoding(1), __workflow_width.WithUrlEncoding(1), __workflow_height.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mapboxip")]
        public IBodyWorkflowAction<GetRouteResponse, ApiConnectionActionConfiguration> GetRoute(Expression<Func<string>> routing, Expression<Func<string>> coordinates, Expression<Func<bool>> alternatives = null, Expression<Func<string>> geometries = null, Expression<Func<string>> overview = null, Expression<Func<bool>> steps = null, Expression<Func<string>> language = null)
        {
            var __workflow_routing = WorkflowExpression.Compile(routing, nameof(routing), required: true);
            var __workflow_coordinates = WorkflowExpression.Compile(coordinates, nameof(coordinates), required: true);
            var __workflow_alternatives = WorkflowExpression.Compile(alternatives, nameof(alternatives), required: false);
            var __workflow_geometries = WorkflowExpression.Compile(geometries, nameof(geometries), required: false);
            var __workflow_overview = WorkflowExpression.Compile(overview, nameof(overview), required: false);
            var __workflow_steps = WorkflowExpression.Compile(steps, nameof(steps), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            return new DeferredBodyAction<GetRouteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/directions/v5/mapbox/{0}/{1}", __workflow_routing.WithUrlEncoding(1), __workflow_coordinates.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["alternatives"] = Convert.ToString(false);
                if (__workflow_alternatives != null)
                    callPayload.Queries["alternatives"] = ExpressionConverter.Convert(__workflow_alternatives);
                callPayload.Queries["geometries"] = Convert.ToString("polyline");
                if (__workflow_geometries != null)
                    callPayload.Queries["geometries"] = ExpressionConverter.Convert(__workflow_geometries);
                callPayload.Queries["overview"] = Convert.ToString("simplified");
                if (__workflow_overview != null)
                    callPayload.Queries["overview"] = ExpressionConverter.Convert(__workflow_overview);
                callPayload.Queries["steps"] = Convert.ToString(false);
                if (__workflow_steps != null)
                    callPayload.Queries["steps"] = ExpressionConverter.Convert(__workflow_steps);
                callPayload.Queries["language"] = Convert.ToString("en");
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                return new ApiConnectionAction<GetRouteResponse>(callPayload);
            });
        }
    }

    public class MapboxipTriggers([ConnectionName] string connectionId)
    {
    }

    public class FwGeocodingResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("query")]
        public string[] Query { get; set; }

        [JsonProperty("features")]
        public FwGeocodingResponseFeaturesTypeItem[] Features { get; set; }

        [JsonProperty("attribution")]
        public string Attribution { get; set; }
    }

    public class FwGeocodingResponseFeaturesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("place_type")]
        public string[] PlaceType { get; set; }

        [JsonProperty("relevance")]
        public double Relevance { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("place_name")]
        public string PlaceName { get; set; }

        [JsonProperty("matching_text")]
        public string MatchingText { get; set; }

        [JsonProperty("matching_place_name")]
        public string MatchingPlaceName { get; set; }

        [JsonProperty("bbox")]
        public double[] Bbox { get; set; }

        [JsonProperty("center")]
        public double[] Center { get; set; }

        [JsonProperty("geometry")]
        public FwGeocodingResponseFeaturesTypeItemGeometryType Geometry { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("context")]
        public FwGeocodingResponseFeaturesTypeItemContextTypeItem[] Context { get; set; }
    }

    public class FwGeocodingResponseFeaturesTypeItemGeometryType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }

        [JsonProperty("interpolated")]
        public bool Interpolated { get; set; }

        [JsonProperty("omitted")]
        public bool Omitted { get; set; }
    }

    public class FwGeocodingResponseFeaturesTypeItemContextTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("wikidata")]
        public string Wikidata { get; set; }

        [JsonProperty("short_code")]
        public string ShortCode { get; set; }
    }

    public class GetRouteResponse
    {
        [JsonProperty("routes")]
        public GetRouteResponseRoutesTypeItem[] Routes { get; set; }

        [JsonProperty("waypoints")]
        public GetRouteResponseWaypointsTypeItem[] Waypoints { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class GetRouteResponseRoutesTypeItem
    {
        [JsonProperty("geometry")]
        public string Geometry { get; set; }

        [JsonProperty("legs")]
        public GetRouteResponseRoutesTypeItemLegsTypeItem[] Legs { get; set; }

        [JsonProperty("weight_name")]
        public string WeightName { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }
    }

    public class GetRouteResponseRoutesTypeItemLegsTypeItem
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("steps")]
        public GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItem[] Steps { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }
    }

    public class GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItem
    {
        [JsonProperty("intersections")]
        public GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemIntersectionsTypeItem[] Intersections { get; set; }

        [JsonProperty("driving_side")]
        public string DrivingSide { get; set; }

        [JsonProperty("geometry")]
        public string Geometry { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("maneuver")]
        public GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemManeuverType Maneuver { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("voiceInstructions")]
        public GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemVoiceInstructionsTypeItem[] VoiceInstructions { get; set; }

        [JsonProperty("bannerInstructions")]
        public GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemBannerInstructionsTypeItem[] BannerInstructions { get; set; }
    }

    public class GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemIntersectionsTypeItem
    {
        [JsonProperty("out")]
        public int Out { get; set; }

        [JsonProperty("entry")]
        public bool[] Entry { get; set; }

        [JsonProperty("bearings")]
        public int[] Bearings { get; set; }

        [JsonProperty("location")]
        public double[] Location { get; set; }

        [JsonProperty("in")]
        public int In { get; set; }
    }

    public class GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemManeuverType
    {
        [JsonProperty("bearing_after")]
        public int BearingAfter { get; set; }

        [JsonProperty("bearing_before")]
        public int BearingBefore { get; set; }

        [JsonProperty("location")]
        public double[] Location { get; set; }

        [JsonProperty("modifier")]
        public string Modifier { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("instruction")]
        public string Instruction { get; set; }
    }

    public class GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemVoiceInstructionsTypeItem
    {
        [JsonProperty("distanceAlongGeometry")]
        public double DistanceAlongGeometry { get; set; }

        [JsonProperty("announcement")]
        public string Announcement { get; set; }

        [JsonProperty("ssmlAnnouncement")]
        public string SsmlAnnouncement { get; set; }
    }

    public class GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemBannerInstructionsTypeItem
    {
        [JsonProperty("distanceAlongGeometry")]
        public int DistanceAlongGeometry { get; set; }

        [JsonProperty("primary")]
        public GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemBannerInstructionsTypeItemPrimaryType Primary { get; set; }

        [JsonProperty("secondary")]
        public GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemBannerInstructionsTypeItemSecondaryType Secondary { get; set; }

        [JsonProperty("sub")]
        public string Sub { get; set; }
    }

    public class GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemBannerInstructionsTypeItemPrimaryType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("components")]
        public GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemBannerInstructionsTypeItemPrimaryTypeComponentsTypeItem[] Components { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("modifier")]
        public string Modifier { get; set; }
    }

    public class GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemBannerInstructionsTypeItemPrimaryTypeComponentsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemBannerInstructionsTypeItemSecondaryType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("components")]
        public GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemBannerInstructionsTypeItemSecondaryTypeComponentsTypeItem[] Components { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("modifier")]
        public string Modifier { get; set; }
    }

    public class GetRouteResponseRoutesTypeItemLegsTypeItemStepsTypeItemBannerInstructionsTypeItemSecondaryTypeComponentsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetRouteResponseWaypointsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public double[] Location { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mapboxip;

    public partial class WorkflowManagedActions
    {
        public MapboxipActions Mapboxip(string connectionId) => new MapboxipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MapboxipTriggers Mapboxip(string connectionId) => new MapboxipTriggers(connectionId);
    }
}