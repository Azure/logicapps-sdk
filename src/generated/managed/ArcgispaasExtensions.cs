//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Arcgispaas
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ArcgispaasActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [WorkflowExpressionFactory(nameof(__BuildReverseGeocode))]
        public IBodyWorkflowAction<ReverseGeocodeResponse> ReverseGeocode([WorkflowExpression] Func<double> x, [WorkflowExpression] Func<double> y, [WorkflowExpression] Func<string> srs = null, [WorkflowExpression] Func<locationTypeInput> locationType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReverseGeocodeResponse> __BuildReverseGeocode(WorkflowExpression<double> x, WorkflowExpression<double> y, WorkflowExpression<string> srs = null, WorkflowExpression<locationTypeInput> locationType = null)
        {
            WorkflowExpression.Validate(x, nameof(x), required: true);
            WorkflowExpression.Validate(y, nameof(y), required: true);
            WorkflowExpression.Validate(srs, nameof(srs), required: false);
            WorkflowExpression.Validate(locationType, nameof(locationType), required: false);
            return new DeferredBodyAction<ReverseGeocodeResponse>(() =>
            {
                var apiCallPath = "/v1/geocode/reverseGeocode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x"] = ExpressionConverter.Convert(x);
                callPayload.Queries["y"] = ExpressionConverter.Convert(y);
                if (srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(srs);
                callPayload.Queries["locationType"] = Convert.ToString("Rooftop");
                if (locationType != null)
                    callPayload.Queries["locationType"] = ExpressionConverter.Convert(locationType);
                return new ApiConnectionAction<ReverseGeocodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [WorkflowExpressionFactory(nameof(__BuildGeometryService))]
        public IBodyWorkflowAction<JToken> GeometryService([WorkflowExpression] Func<string> operation, [WorkflowExpression] Func<object> data = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGeometryService(WorkflowExpression<string> operation, WorkflowExpression<object> data = null)
        {
            WorkflowExpression.Validate(operation, nameof(operation), required: true);
            WorkflowExpression.Validate(data, nameof(data), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v1/geometry/process";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["operation"] = ExpressionConverter.Convert(operation);
                callPayload.Body = ExpressionConverter.ConvertO(data);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [WorkflowExpressionFactory(nameof(__BuildTimeConversionHelper))]
        public IBodyWorkflowAction<TimeConversionHelperResponse> TimeConversionHelper([WorkflowExpression] Func<string> datadateTime)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeConversionHelperResponse> __BuildTimeConversionHelper(WorkflowExpression<string> datadateTime)
        {
            WorkflowExpression.Validate(datadateTime, nameof(datadateTime), required: true);
            return new DeferredBodyAction<TimeConversionHelperResponse>(() =>
            {
                var apiCallPath = "/v1/helper/convertTime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                datapropCount++;
                data["dateTime"] = ExpressionConverter.ConvertO(datadateTime);
                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }

                return new ApiConnectionAction<TimeConversionHelperResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePointGeometryHelper))]
        public IBodyWorkflowAction<CreatePointGeometryHelperResponse> CreatePointGeometryHelper([WorkflowExpression] Func<double> x, [WorkflowExpression] Func<double> y, [WorkflowExpression] Func<string> srs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePointGeometryHelperResponse> __BuildCreatePointGeometryHelper(WorkflowExpression<double> x, WorkflowExpression<double> y, WorkflowExpression<string> srs = null)
        {
            WorkflowExpression.Validate(x, nameof(x), required: true);
            WorkflowExpression.Validate(y, nameof(y), required: true);
            WorkflowExpression.Validate(srs, nameof(srs), required: false);
            return new DeferredBodyAction<CreatePointGeometryHelperResponse>(() =>
            {
                var apiCallPath = "/v1/helper/createPointGeometry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x"] = ExpressionConverter.Convert(x);
                callPayload.Queries["y"] = ExpressionConverter.Convert(y);
                if (srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(srs);
                return new ApiConnectionAction<CreatePointGeometryHelperResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [WorkflowExpressionFactory(nameof(__BuildEXIF))]
        public IBodyWorkflowAction<JToken> EXIF([WorkflowExpression] Func<string> data = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildEXIF(WorkflowExpression<string> data = null)
        {
            WorkflowExpression.Validate(data, nameof(data), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v1/helper/exif";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(data);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [WorkflowExpressionFactory(nameof(__BuildGeocodeAddresses))]
        public IBodyWorkflowAction<JToken> GeocodeAddresses([WorkflowExpression] Func<string> dataaddresses)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGeocodeAddresses(WorkflowExpression<string> dataaddresses)
        {
            WorkflowExpression.Validate(dataaddresses, nameof(dataaddresses), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v2/geocode/geocodeAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                datapropCount++;
                data["addresses"] = ExpressionConverter.ConvertO(dataaddresses);
                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [WorkflowExpressionFactory(nameof(__BuildGeoenrich))]
        public IBodyWorkflowAction<GeoenrichV2Response> Geoenrich([WorkflowExpression] Func<string> country, [WorkflowExpression] Func<string> datacollection, [WorkflowExpression] Func<string> parameter, [WorkflowExpression] Func<buffertypeInput> buffertype, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GeoenrichV2Response> __BuildGeoenrich(WorkflowExpression<string> country, WorkflowExpression<string> datacollection, WorkflowExpression<string> parameter, WorkflowExpression<buffertypeInput> buffertype, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(country, nameof(country), required: true);
            WorkflowExpression.Validate(datacollection, nameof(datacollection), required: true);
            WorkflowExpression.Validate(parameter, nameof(parameter), required: true);
            WorkflowExpression.Validate(buffertype, nameof(buffertype), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<GeoenrichV2Response>(() =>
            {
                var apiCallPath = "/v2/geoenrichment/enrich";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                callPayload.Queries["datacollection"] = ExpressionConverter.Convert(datacollection);
                callPayload.Queries["parameter"] = ExpressionConverter.Convert(parameter);
                callPayload.Queries["buffertype"] = ExpressionConverter.Convert(buffertype);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<GeoenrichV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [WorkflowExpressionFactory(nameof(__BuildGetRoute))]
        public IBodyWorkflowAction<GetRouteV2Response> GetRoute([WorkflowExpression] Func<string> routingroutingStops, [WorkflowExpression] Func<string> travelModeName = null, [WorkflowExpression] Func<bool> findBestSequence = null, [WorkflowExpression] Func<bool> preserveFirstStop = null, [WorkflowExpression] Func<bool> returnDirections = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRouteV2Response> __BuildGetRoute(WorkflowExpression<string> routingroutingStops, WorkflowExpression<string> travelModeName = null, WorkflowExpression<bool> findBestSequence = null, WorkflowExpression<bool> preserveFirstStop = null, WorkflowExpression<bool> returnDirections = null)
        {
            WorkflowExpression.Validate(routingroutingStops, nameof(routingroutingStops), required: true);
            WorkflowExpression.Validate(travelModeName, nameof(travelModeName), required: false);
            WorkflowExpression.Validate(findBestSequence, nameof(findBestSequence), required: false);
            WorkflowExpression.Validate(preserveFirstStop, nameof(preserveFirstStop), required: false);
            WorkflowExpression.Validate(returnDirections, nameof(returnDirections), required: false);
            return new DeferredBodyAction<GetRouteV2Response>(() =>
            {
                var apiCallPath = "/v2/routing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (travelModeName != null)
                    callPayload.Queries["travelModeName"] = ExpressionConverter.Convert(travelModeName);
                if (findBestSequence != null)
                    callPayload.Queries["findBestSequence"] = ExpressionConverter.Convert(findBestSequence);
                if (preserveFirstStop != null)
                    callPayload.Queries["preserveFirstStop"] = ExpressionConverter.Convert(preserveFirstStop);
                callPayload.Queries["returnDirections"] = Convert.ToString(true);
                if (returnDirections != null)
                    callPayload.Queries["returnDirections"] = ExpressionConverter.Convert(returnDirections);
                var routing = new JObject();
                var routingpropCount = 0;
                routingpropCount++;
                routing["stops"] = ExpressionConverter.ConvertO(routingroutingStops);
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