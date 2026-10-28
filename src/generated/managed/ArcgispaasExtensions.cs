//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Arcgispaas
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ArcgispaasActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<ReverseGeocodeResponse> ReverseGeocode(Expression<Func<double>> x, Expression<Func<double>> y, Expression<Func<string>> srs = null, Expression<Func<locationTypeInput>> locationType = null)
        {
            var __workflow_x = WorkflowExpression.Compile(x, nameof(x), required: true);
            var __workflow_y = WorkflowExpression.Compile(y, nameof(y), required: true);
            var __workflow_srs = WorkflowExpression.Compile(srs, nameof(srs), required: false);
            var __workflow_locationType = WorkflowExpression.Compile(locationType, nameof(locationType), required: false);
            return new DeferredBodyAction<ReverseGeocodeResponse>(() =>
            {
                var apiCallPath = "/v1/geocode/reverseGeocode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x"] = ExpressionConverter.Convert(__workflow_x);
                callPayload.Queries["y"] = ExpressionConverter.Convert(__workflow_y);
                if (__workflow_srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(__workflow_srs);
                callPayload.Queries["locationType"] = Convert.ToString("Rooftop");
                if (__workflow_locationType != null)
                    callPayload.Queries["locationType"] = ExpressionConverter.Convert(__workflow_locationType);
                return new ApiConnectionAction<ReverseGeocodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<JToken> GeometryService(Expression<Func<string>> operation, Expression<Func<object>> data = null)
        {
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v1/geometry/process";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["operation"] = ExpressionConverter.Convert(__workflow_operation);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<TimeConversionHelperResponse> TimeConversionHelper(Expression<Func<string>> datadateTime)
        {
            var __workflow_datadateTime = WorkflowExpression.Compile(datadateTime, nameof(datadateTime), required: true);
            return new DeferredBodyAction<TimeConversionHelperResponse>(() =>
            {
                var apiCallPath = "/v1/helper/convertTime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                datapropCount++;
                data["dateTime"] = ExpressionConverter.ConvertO(__workflow_datadateTime);
                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }

                return new ApiConnectionAction<TimeConversionHelperResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<CreatePointGeometryHelperResponse> CreatePointGeometryHelper(Expression<Func<double>> x, Expression<Func<double>> y, Expression<Func<string>> srs = null)
        {
            var __workflow_x = WorkflowExpression.Compile(x, nameof(x), required: true);
            var __workflow_y = WorkflowExpression.Compile(y, nameof(y), required: true);
            var __workflow_srs = WorkflowExpression.Compile(srs, nameof(srs), required: false);
            return new DeferredBodyAction<CreatePointGeometryHelperResponse>(() =>
            {
                var apiCallPath = "/v1/helper/createPointGeometry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x"] = ExpressionConverter.Convert(__workflow_x);
                callPayload.Queries["y"] = ExpressionConverter.Convert(__workflow_y);
                if (__workflow_srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(__workflow_srs);
                return new ApiConnectionAction<CreatePointGeometryHelperResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<JToken> EXIF(Expression<Func<string>> data = null)
        {
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v1/helper/exif";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<JToken> GeocodeAddresses(Expression<Func<string>> dataaddresses)
        {
            var __workflow_dataaddresses = WorkflowExpression.Compile(dataaddresses, nameof(dataaddresses), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v2/geocode/geocodeAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                datapropCount++;
                data["addresses"] = ExpressionConverter.ConvertO(__workflow_dataaddresses);
                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<GeoenrichV2Response> Geoenrich(Expression<Func<string>> country, Expression<Func<string>> datacollection, Expression<Func<string>> parameter, Expression<Func<buffertypeInput>> buffertype, Expression<Func<object>> body = null)
        {
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            var __workflow_datacollection = WorkflowExpression.Compile(datacollection, nameof(datacollection), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            var __workflow_buffertype = WorkflowExpression.Compile(buffertype, nameof(buffertype), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GeoenrichV2Response>(() =>
            {
                var apiCallPath = "/v2/geoenrichment/enrich";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                callPayload.Queries["datacollection"] = ExpressionConverter.Convert(__workflow_datacollection);
                callPayload.Queries["parameter"] = ExpressionConverter.Convert(__workflow_parameter);
                callPayload.Queries["buffertype"] = ExpressionConverter.Convert(__workflow_buffertype);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GeoenrichV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<GetRouteV2Response> GetRoute(Expression<Func<string>> routingroutingStops, Expression<Func<string>> travelModeName = null, Expression<Func<bool>> findBestSequence = null, Expression<Func<bool>> preserveFirstStop = null, Expression<Func<bool>> returnDirections = null)
        {
            var __workflow_routingroutingStops = WorkflowExpression.Compile(routingroutingStops, nameof(routingroutingStops), required: true);
            var __workflow_travelModeName = WorkflowExpression.Compile(travelModeName, nameof(travelModeName), required: false);
            var __workflow_findBestSequence = WorkflowExpression.Compile(findBestSequence, nameof(findBestSequence), required: false);
            var __workflow_preserveFirstStop = WorkflowExpression.Compile(preserveFirstStop, nameof(preserveFirstStop), required: false);
            var __workflow_returnDirections = WorkflowExpression.Compile(returnDirections, nameof(returnDirections), required: false);
            return new DeferredBodyAction<GetRouteV2Response>(() =>
            {
                var apiCallPath = "/v2/routing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_travelModeName != null)
                    callPayload.Queries["travelModeName"] = ExpressionConverter.Convert(__workflow_travelModeName);
                if (__workflow_findBestSequence != null)
                    callPayload.Queries["findBestSequence"] = ExpressionConverter.Convert(__workflow_findBestSequence);
                if (__workflow_preserveFirstStop != null)
                    callPayload.Queries["preserveFirstStop"] = ExpressionConverter.Convert(__workflow_preserveFirstStop);
                callPayload.Queries["returnDirections"] = Convert.ToString(true);
                if (__workflow_returnDirections != null)
                    callPayload.Queries["returnDirections"] = ExpressionConverter.Convert(__workflow_returnDirections);
                var routing = new JObject();
                var routingpropCount = 0;
                routingpropCount++;
                routing["stops"] = ExpressionConverter.ConvertO(__workflow_routingroutingStops);
                if (routingpropCount > 0)
                {
                    callPayload.Body = routing;
                }

                return new ApiConnectionAction<GetRouteV2Response>(callPayload);
            });
        }
    }

    public class ArcgispaasTriggers([ConnectionName] string connectionId)
    {
    }

    public class ReverseGeocodeResponse
    {
        [JsonProperty("address")]
        public ReverseGeocodeResponseAddressType Address { get; set; }

        [JsonProperty("location")]
        public ReverseGeocodeResponseLocationType Location { get; set; }
    }

    public class ReverseGeocodeResponseAddressType
    {
        [JsonProperty("Address")]
        public string ShortAddress { get; set; }

        [JsonProperty("LongLabel")]
        public string FullAddress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        [JsonProperty("CntryName")]
        public string Country { get; set; }

        [JsonProperty("Postal")]
        public string ZIPOrPostalCode { get; set; }
    }

    public class ReverseGeocodeResponseLocationType
    {
        [JsonProperty("x")]
        public double LongitudeX { get; set; }

        [JsonProperty("y")]
        public double LatitudeY { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum locationTypeInput
    {
        Rooftop,
        Street
    }

    public class TimeConversionHelperResponse
    {
        [JsonProperty("stringTime")]
        public string DateTime { get; set; }

        [JsonProperty("unixTimeStampSeconds")]
        public double UnixTimeStampInSeconds { get; set; }

        [JsonProperty("unixTimeStampMilliseconds")]
        public double UnixTimeStampInMilliseconds { get; set; }
    }

    public class CreatePointGeometryHelperResponse
    {
        [JsonProperty("geometry")]
        public JToken Geometry { get; set; }
    }

    public class GeoenrichV2Response
    {
        [JsonProperty("value")]
        public double ParameterValue { get; set; }

        [JsonProperty("parameterName")]
        public string ParameterName { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum buffertypeInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "ringbuffer")]
        RingBuffer,
        [EnumMember(Value = "networkservicearea")]
        NetworkServiceArea
    }

    public class GetRouteV2Response
    {
        public GetRouteV2ResponseDirectionsTypeItem[] Directions { get; set; }
        public string Name { get; set; }

        [JsonProperty("Kilometers")]
        public double DistanceInKilometers { get; set; }

        [JsonProperty("Miles")]
        public double DistanceInMiles { get; set; }
        public double TravelTime { get; set; }

        [JsonProperty("Geometry")]
        public JToken RouteGeometry { get; set; }
    }

    public class GetRouteV2ResponseDirectionsTypeItem
    {
        [JsonProperty("text")]
        public string DirectionText { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Arcgispaas;

    public partial class WorkflowManagedActions
    {
        public ArcgispaasActions Arcgispaas(string connectionId) => new ArcgispaasActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ArcgispaasTriggers Arcgispaas(string connectionId) => new ArcgispaasTriggers(connectionId);
    }
}
